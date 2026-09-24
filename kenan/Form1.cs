using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace kenan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            if (ValidateUsername(username, out string errorMessage))
            {
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "İstifadəçi adı uğurla qəbul edildi!";
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = errorMessage;
            }
        }

        private bool ValidateUsername(string username, out string errorMessage)
        {
            // 1) Minimum 8 simvol
            if (string.IsNullOrEmpty(username) || username.Length < 8)
            {
                errorMessage = "Minimum 8 simvol olmalıdır.";
                return false;
            }

            // 5) Rəqəmlə başlamaz
            if (char.IsDigit(username[0]))
            {
                errorMessage = "Rəqəmlə başlaya bilməz.";
                return false;
            }

            // 3) Mütləq böyük simvol
            if (!username.Any(char.IsUpper))
            {
                errorMessage = "Ən azı bir böyük hərf olmalıdır.";
                return false;
            }

            // 4) Mütləq rəqəm
            if (!username.Any(char.IsDigit))
            {
                errorMessage = "Ən azı bir rəqəm olmalıdır.";
                return false;
            }

            // 2) *, boşluq və # simvolları
            if (!username.Contains('*') || !username.Contains(' ') || !username.Contains('#'))
            {
                errorMessage = " '*', '#' və boşluq simvollarının hər biri olmalıdır.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}