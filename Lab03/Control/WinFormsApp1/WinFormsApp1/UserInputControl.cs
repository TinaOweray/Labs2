using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class UserInputControl : UserControl
    {
        public event EventHandler<User>? UserValidated; // событие: данные прошли проверку

        private bool _emailCheckedByLeave = false;
        private bool _fullNameTouched;
        private bool _ageTouched;
        private bool _emailTouched;

        private bool _isClearing = false; //на зачистку после заполнения не выдвать ошибку
        public UserInputControl()
        {
            InitializeComponent();
            tbFullName.TextChanged += TbFullName_TextChanged;
            tbFullName.Leave += TbFullName_Leave;

            tbAge.TextChanged += TbAge_TextChanged;
            tbAge.Leave += TbAge_Leave;

            tbEmail.TextChanged += TbEmail_TextChanged;
            tbEmail.Leave += TbEmail_Leave;

            UpdateSaveButtonState();
        }
        private void TbFullName_TextChanged(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            _fullNameTouched = true;

            // Если уже начал вводить — валидируем и показываем
            ValidateFullName(showError: true);

            UpdateSaveButtonState();
        }

        private void TbAge_TextChanged(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            _ageTouched = true;
            ValidateAge(showError: true);

            UpdateSaveButtonState();
        }

        private void TbEmail_TextChanged(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            _emailTouched = true;

            // Пока печатает — можно НЕ проверять формат, но можно убирать прошлую ошибку:
            errorProvider1.SetError(tbEmail, "");

            _emailCheckedByLeave = false;
            UpdateSaveButtonState();
        }
        private void TbFullName_Leave(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            // Ушёл из поля -> показываем ошибку, даже если не вводил
            ValidateFullName(showError: true);
            UpdateSaveButtonState();
        }

        private void TbAge_Leave(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            ValidateAge(showError: true);
            UpdateSaveButtonState();
        }

        private void TbEmail_Leave(object? sender, EventArgs e)
        {
            if (_isClearing) return;

            ValidateEmail(showError: true);
            _emailCheckedByLeave = true;

            UpdateSaveButtonState();
        }

        // ----------------------------
        // Кнопка "Сохранить"
        // ----------------------------

        private void btnSave_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();

            // На всякий случай проверим всё ещё раз.
            // Email проверим принудительно, даже если пользователь не уходил из поля.
            bool ok =
                ValidateFullName(showError: true) &&
                ValidateAge(showError: true) &&
                ValidateEmail(showError: true);

            if (!ok)
            {
                UpdateSaveButtonState();
                return;
            }

            var user = BuildUserFromInputs();
            UserValidated?.Invoke(this, user);

            ClearInputs();
        }

        // ----------------------------
        // Валидация полей
        // ----------------------------

        private bool ValidateFullName(bool showError, bool required = true)
        {
            string fullName = tbFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                if (required)
                {
                    if (showError) errorProvider1.SetError(tbFullName, "Введите ФИО");
                    return false;
                }

                if (showError) errorProvider1.SetError(tbFullName, "");
                return false; // пусто — не валидно для сохранения, но без ошибки
            }

            if (!IsValidFullName(fullName))
            {
                if (showError) errorProvider1.SetError(tbFullName, "ФИО: только буквы, пробел и дефис");
                return false;
            }

            if (showError) errorProvider1.SetError(tbFullName, "");
            return true;
        }

        private bool ValidateAge(bool showError, bool required = true)
        {
            string text = tbAge.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                if (required)
                {
                    if (showError) errorProvider1.SetError(tbAge, "Введите возраст");
                    return false;
                }

                if (showError) errorProvider1.SetError(tbAge, "");
                return false;
            }

            if (!int.TryParse(text, out int age))
            {
                if (showError) errorProvider1.SetError(tbAge, "Возраст должен быть числом");
                return false;
            }

            if (age < 1 || age > 120)
            {
                if (showError) errorProvider1.SetError(tbAge, "Возраст 1–120");
                return false;
            }

            if (showError) errorProvider1.SetError(tbAge, "");
            return true;
        }

        private bool ValidateEmail(bool showError)
        {
            string email = tbEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                if (showError) errorProvider1.SetError(tbEmail, "Введите Email");
                return false;
            }

            if (!IsValidEmail(email))
            {
                if (showError) errorProvider1.SetError(tbEmail, "Некорректный Email");
                return false;
            }

            if (showError) errorProvider1.SetError(tbEmail, "");
            return true;
        }

        // ФИО: только буквы + пробел + дефис. Без цифр и без прочих знаков.
        private static bool IsValidFullName(string fullName)
        {
            return fullName.All(ch => char.IsLetter(ch) || ch == ' ' || ch == '-');
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // ----------------------------
        // Построение модели + доступность кнопки сохранить
        // ----------------------------

        private User BuildUserFromInputs()
        {
            return new User
            {
                FullName = tbFullName.Text.Trim(),
                Age = int.Parse(tbAge.Text.Trim()),
                Email = tbEmail.Text.Trim()
            };
        }

        private void UpdateSaveButtonState()
        {
            bool nameOk = ValidateFullName(showError: false, required: false) && !string.IsNullOrWhiteSpace(tbFullName.Text);
            bool ageOk = ValidateAge(showError: false, required: false) && !string.IsNullOrWhiteSpace(tbAge.Text);

            // email считаем "готовым" только после Leave
            bool emailOk = _emailCheckedByLeave && ValidateEmail(showError: false);

            btnSave.Enabled = nameOk && ageOk && emailOk;
        }

        //----------------------
        //Очистка полей после сохранения
        //----------------------
        private void ClearInputs()
        {
            _isClearing = true;
            try
            {
                tbFullName.Clear();
                tbAge.Clear();
                tbEmail.Clear();

                errorProvider1.Clear();

                _fullNameTouched = false;
                _ageTouched = false;
                _emailTouched = false;

                _emailCheckedByLeave = false;

                UpdateSaveButtonState();
                tbFullName.Focus();
            }
            finally
            {
                _isClearing = false;
            }
        }

    }
}
