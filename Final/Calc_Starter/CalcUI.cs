using Calculator;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    /// <summary>
    /// Summary description for CalcUI.
    /// </summary>
    public class CalcUI : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyExit;
        private System.Windows.Forms.Button KeyDate;
        private System.Windows.Forms.TextBox OutputDisplay;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;

        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private Button KeyPow;
        private Button KeySqrt;
        private Button KeyInv;
        private Button KeySquare;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ViewToolStripMenuItem;
        private ToolStripMenuItem simpleViewToolStripMenuItem;
        private ToolStripMenuItem scientificViewToolStripMenuItem;
        private ToolStripMenuItem RefToolStripMenuItem;
        private ToolStripMenuItem RefAboutToolStripMenuItem;
        private ToolTip toolTip1 = new ToolTip();
        private Button KeyFactorial;
        private Button KeyCbrt;
        private Button KeyQuadrEq;

        //режим работы
        private bool scientificMode = false;
        private TextBox OutputDisplayAsync;

        //режим первой инициализации
        private bool _modeInitialized;
        private Button KeyFactorialAsync;
        private Panel panelScientific;

        // для отмены токена
        private CancellationTokenSource _factCts;

        public CalcUI()
        {
            InitializeComponent();
            // всплывающие подсказки
            toolTip1.ShowAlways = true;
            // для того, что уже было
            toolTip1.SetToolTip(KeyPlus, "Сложение");
            toolTip1.SetToolTip(KeyMinus, "Вычитание");
            toolTip1.SetToolTip(KeyMultiply, "Умножение");
            toolTip1.SetToolTip(KeyDivide, "Деление");
            toolTip1.SetToolTip(KeyEqual, "Посчитать результат");
            toolTip1.SetToolTip(KeyClear, "Очистить");
            toolTip1.SetToolTip(KeyDate, "Показать дату/время");
            toolTip1.SetToolTip(KeySign, "Сменить знак");
            toolTip1.SetToolTip(KeyPoint, "Десятичная точка");
            toolTip1.SetToolTip(KeyExit, "Выход");
            // для новых функций
            toolTip1.SetToolTip(KeyPow, "Возведение в степень (x^y)");
            toolTip1.SetToolTip(KeySqrt, "Квадратный корень (√x)");
            toolTip1.SetToolTip(KeyInv, "Обратное значение (1/x)");
            toolTip1.SetToolTip(KeySquare, "Квадрат числа (x²)");
            toolTip1.SetToolTip(KeyFactorial, "Факториал (целое)");
            toolTip1.SetToolTip(KeyCbrt, "Кубический корень");
            toolTip1.SetToolTip(KeyQuadrEq, "Решение квадратного уравнения");
            toolTip1.SetToolTip(KeyFactorialAsync, "Фоновый расчёт факториала");

            // Версия/стартовый экран
            VersionInfo.Text = CalcEngine.GetVersion();
            OutputDisplay.Text = "0";

            // 1) Запрет изменения размера
            this.FormBorderStyle = FormBorderStyle.Fixed3D; // фиксированный размер
            this.MaximizeBox = false;                            // запрет увеличения
            this.MinimizeBox = false;                             // запрет уменьшения

            // 2) Центр экрана
            this.StartPosition = FormStartPosition.CenterScreen;

            // 3) Поверх всех окон
            this.TopMost = true;

            // 4) Курсор Hand
            this.Cursor = Cursors.Hand;

            // 5) Цвет формы (любой)
            this.BackColor = Color.FromArgb(235, 240, 255);

            // 6) Запрет клавиатуры для ввода 
            OutputDisplay.TabStop = false;
            OutputDisplay.ShortcutsEnabled = false;
            OutputDisplay.KeyPress += (s, e) => e.Handled = true;
            OutputDisplay.KeyDown += (s, e) => e.SuppressKeyPress = true;

            OutputDisplayAsync.TabStop = false;
            OutputDisplayAsync.ShortcutsEnabled = false;
            OutputDisplayAsync.KeyPress += (s, e) => e.Handled = true;
            OutputDisplayAsync.KeyDown += (s, e) => e.SuppressKeyPress = true;
        }
        //Подгоняем размер окна при первом запуске
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_modeInitialized) return;
            _modeInitialized = true;
            SetMode(false);
        }
        // Режим
        private void SetMode(bool scientific)
        {
            scientificMode = scientific;
            panelScientific.Visible = scientific;
            //новый размер окна
            FitToVisibleControls();
        }
        private void FitToVisibleControls(int padding = 12)
        {
            int maxRight = 0;
            int maxBottom = 0;

            foreach (Control c in this.Controls)
            {
                if (!c.Visible) continue;

                maxRight = Math.Max(maxRight, c.Right);
                maxBottom = Math.Max(maxBottom, c.Bottom);
            }
            this.ClientSize = new Size(maxRight + padding, maxBottom + padding);
        }
        private void simpleViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMode(false);
        }
        private void scientificViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMode(true);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeyPow = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyInv = new System.Windows.Forms.Button();
            this.KeySquare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.KeyCbrt = new System.Windows.Forms.Button();
            this.KeyQuadrEq = new System.Windows.Forms.Button();
            this.OutputDisplayAsync = new System.Windows.Forms.TextBox();
            this.KeyFactorialAsync = new System.Windows.Forms.Button();
            this.panelScientific = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelScientific.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(321, 203);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(90, 59);
            this.KeyDate.TabIndex = 17;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Дата";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(14, 274);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(64, 58);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(14, 40);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(397, 27);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(167, 203);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(64, 59);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(91, 203);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(64, 59);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(321, 344);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(90, 58);
            this.KeyEqual.TabIndex = 19;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(91, 274);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(64, 58);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(14, 344);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(64, 58);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(167, 274);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(64, 58);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(244, 344);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(64, 58);
            this.KeyPlus.TabIndex = 15;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(321, 274);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(90, 58);
            this.KeyExit.TabIndex = 18;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Выход";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(167, 344);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(64, 58);
            this.KeySign.TabIndex = 11;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(14, 133);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(64, 59);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(91, 344);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(64, 58);
            this.KeyPoint.TabIndex = 10;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(167, 133);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(64, 59);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(14, 86);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.ShortcutsEnabled = false;
            this.OutputDisplay.Size = new System.Drawing.Size(397, 35);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(244, 274);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(64, 58);
            this.KeyMinus.TabIndex = 14;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(91, 133);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(64, 59);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(244, 203);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(64, 59);
            this.KeyMultiply.TabIndex = 13;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(14, 203);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(64, 59);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(321, 133);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(90, 59);
            this.KeyClear.TabIndex = 16;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(244, 133);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(64, 59);
            this.KeyDivide.TabIndex = 12;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeyPow
            // 
            this.KeyPow.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPow.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyPow.Location = new System.Drawing.Point(6, 263);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(100, 58);
            this.KeyPow.TabIndex = 24;
            this.KeyPow.TabStop = false;
            this.KeyPow.Text = "x^y";
            this.KeyPow.Click += new System.EventHandler(this.KeyPow_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrt.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeySqrt.Location = new System.Drawing.Point(153, 333);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(64, 58);
            this.KeySqrt.TabIndex = 27;
            this.KeySqrt.TabStop = false;
            this.KeySqrt.Text = "√x";
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // KeyInv
            // 
            this.KeyInv.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyInv.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyInv.Location = new System.Drawing.Point(117, 263);
            this.KeyInv.Name = "KeyInv";
            this.KeyInv.Size = new System.Drawing.Size(100, 58);
            this.KeyInv.TabIndex = 25;
            this.KeyInv.TabStop = false;
            this.KeyInv.Text = "1/x";
            this.KeyInv.Click += new System.EventHandler(this.KeyInv_Click);
            // 
            // KeySquare
            // 
            this.KeySquare.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySquare.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeySquare.Location = new System.Drawing.Point(6, 192);
            this.KeySquare.Name = "KeySquare";
            this.KeySquare.Size = new System.Drawing.Size(100, 58);
            this.KeySquare.TabIndex = 22;
            this.KeySquare.TabStop = false;
            this.KeySquare.Text = "x²";
            this.KeySquare.Click += new System.EventHandler(this.KeySquare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolStripMenuItem,
            this.RefToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(163, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleViewToolStripMenuItem,
            this.scientificViewToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // simpleViewToolStripMenuItem
            // 
            this.simpleViewToolStripMenuItem.Name = "simpleViewToolStripMenuItem";
            this.simpleViewToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.simpleViewToolStripMenuItem.Text = "Обычный";
            this.simpleViewToolStripMenuItem.Click += new System.EventHandler(this.simpleViewToolStripMenuItem_Click);
            // 
            // scientificViewToolStripMenuItem
            // 
            this.scientificViewToolStripMenuItem.Name = "scientificViewToolStripMenuItem";
            this.scientificViewToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.scientificViewToolStripMenuItem.Text = "Расширенный";
            this.scientificViewToolStripMenuItem.Click += new System.EventHandler(this.scientificViewToolStripMenuItem_Click);
            // 
            // RefToolStripMenuItem
            // 
            this.RefToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefAboutToolStripMenuItem});
            this.RefToolStripMenuItem.Name = "RefToolStripMenuItem";
            this.RefToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.RefToolStripMenuItem.Text = "Справка";
            // 
            // RefAboutToolStripMenuItem
            // 
            this.RefAboutToolStripMenuItem.Name = "RefAboutToolStripMenuItem";
            this.RefAboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.RefAboutToolStripMenuItem.Text = "О программе";
            this.RefAboutToolStripMenuItem.Click += new System.EventHandler(this.RefAboutToolStripMenuItem_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFactorial.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyFactorial.Location = new System.Drawing.Point(6, 123);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(100, 58);
            this.KeyFactorial.TabIndex = 20;
            this.KeyFactorial.TabStop = false;
            this.KeyFactorial.Text = "n!";
            this.KeyFactorial.Click += new System.EventHandler(this.KeyFactorial_Click);
            // 
            // KeyCbrt
            // 
            this.KeyCbrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyCbrt.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyCbrt.Location = new System.Drawing.Point(117, 192);
            this.KeyCbrt.Name = "KeyCbrt";
            this.KeyCbrt.Size = new System.Drawing.Size(100, 58);
            this.KeyCbrt.TabIndex = 23;
            this.KeyCbrt.TabStop = false;
            this.KeyCbrt.Text = "∛x";
            this.KeyCbrt.Click += new System.EventHandler(this.KeyCbrt_Click);
            // 
            // KeyQuadrEq
            // 
            this.KeyQuadrEq.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyQuadrEq.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyQuadrEq.Location = new System.Drawing.Point(0, 333);
            this.KeyQuadrEq.Name = "KeyQuadrEq";
            this.KeyQuadrEq.Size = new System.Drawing.Size(147, 58);
            this.KeyQuadrEq.TabIndex = 26;
            this.KeyQuadrEq.TabStop = false;
            this.KeyQuadrEq.Text = "Квадратное уравнение";
            this.KeyQuadrEq.Click += new System.EventHandler(this.KeyQuadrEq_Click);
            // 
            // OutputDisplayAsync
            // 
            this.OutputDisplayAsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(217)))));
            this.OutputDisplayAsync.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputDisplayAsync.Location = new System.Drawing.Point(6, 29);
            this.OutputDisplayAsync.Multiline = true;
            this.OutputDisplayAsync.Name = "OutputDisplayAsync";
            this.OutputDisplayAsync.ReadOnly = true;
            this.OutputDisplayAsync.ShortcutsEnabled = false;
            this.OutputDisplayAsync.Size = new System.Drawing.Size(211, 81);
            this.OutputDisplayAsync.TabIndex = 31;
            this.OutputDisplayAsync.TabStop = false;
            this.OutputDisplayAsync.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyFactorialAsync
            // 
            this.KeyFactorialAsync.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFactorialAsync.ForeColor = System.Drawing.Color.OliveDrab;
            this.KeyFactorialAsync.Location = new System.Drawing.Point(117, 123);
            this.KeyFactorialAsync.Name = "KeyFactorialAsync";
            this.KeyFactorialAsync.Size = new System.Drawing.Size(100, 58);
            this.KeyFactorialAsync.TabIndex = 21;
            this.KeyFactorialAsync.TabStop = false;
            this.KeyFactorialAsync.Text = "n!⏳";
            this.KeyFactorialAsync.Click += new System.EventHandler(this.KeyFactorialAsync_Click);
            // 
            // panelScientific
            // 
            this.panelScientific.Controls.Add(this.KeyFactorialAsync);
            this.panelScientific.Controls.Add(this.KeySqrt);
            this.panelScientific.Controls.Add(this.OutputDisplayAsync);
            this.panelScientific.Controls.Add(this.KeySquare);
            this.panelScientific.Controls.Add(this.KeyFactorial);
            this.panelScientific.Controls.Add(this.KeyCbrt);
            this.panelScientific.Controls.Add(this.KeyInv);
            this.panelScientific.Controls.Add(this.KeyPow);
            this.panelScientific.Controls.Add(this.KeyQuadrEq);
            this.panelScientific.Location = new System.Drawing.Point(418, 11);
            this.panelScientific.Name = "panelScientific";
            this.panelScientific.Size = new System.Drawing.Size(226, 403);
            this.panelScientific.TabIndex = 33;
            this.panelScientific.TabStop = true;
            this.panelScientific.Visible = false;
            // 
            // CalcUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.panelScientific);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelScientific.ResumeLayout(false);
            this.panelScientific.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";

            _factCts?.Cancel();
            OutputDisplayAsync.Text = "";
        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        //
        // Numeric key click methods.
        //
        #region Numeric key click methods
        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }
        #endregion

        #region Special key click methods
        private void KeyPow_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePower);
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrt();
        }

        private void KeyInv_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcReciprocal();
        }

        private void KeySquare_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSquare();
        }

        private void KeyFactorial_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFactorial();
        }

        private void KeyCbrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcCbrt();
        }

        private void KeyQuadrEq_Click(object sender, EventArgs e)
        {
            using (var dlg = new QuadraticDialog())
            {
                dlg.StartPosition = FormStartPosition.CenterParent;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string result = QuadraticSolver.Solve(dlg.A, dlg.B, dlg.C);

                    OutputDisplay.Text = result;
                }
            }
        }
        // ассихр. факториал
        private async void KeyFactorialAsync_Click(object sender, EventArgs e)
        {
            // отменяем предыдущий асинхронный расчёт, если он ещё идёт
            _factCts?.Cancel();
            _factCts = new CancellationTokenSource();

            // Берём n из OutputDisplay
            if (!int.TryParse(OutputDisplay.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int n))
            {
                OutputDisplayAsync.Text = "Error";
                return;
            }
            if (n < 0)
            {
                OutputDisplayAsync.Text = "Ошибка";
                return;
            }

            OutputDisplayAsync.Text = "Считаю...";
            try
            {
                double res = await Task.Run(() =>
                {
                    return LongMathService.FactorialAsync(n, _factCts.Token);
                }, _factCts.Token);

                OutputDisplayAsync.Text = res.ToString(CultureInfo.InvariantCulture);

            }
            catch (OperationCanceledException)
            {
                OutputDisplayAsync.Text = "";
            }
            catch
            {
                OutputDisplayAsync.Text = "Ошибка";
            }
        }

        #endregion 
        //
        // End the program.
        //
        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void RefAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Калькулятор\n\n" +
                "Обычный режим: базовые операции с числами\n" +
                "Специальный режим содержит различные дополнительные инструменты для расчётов, \n" +
                "в том числе расчёты корня(ей квадратного  уравнения)\n" +
                "и два различных расчёт факториала: фоновый и моментальный. \n" +
                "Для фонового расчёта результат отображается во 2-е поле.\n" +
                "Версия: " + CalcEngine.GetVersion(),
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                            );
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new CalcUI());
        }
    }
}
