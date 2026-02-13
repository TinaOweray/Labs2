using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {
        public string FullName { get; set; } = "";
        public int Age { get; set; }
        public string Email { get; set; } = "";

        public override string ToString()
            => $"ФИО: {FullName}\r\nВозраст: {Age}\r\nEmail: {Email}";
    }
}
