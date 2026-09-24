using System;
using System.Windows.Forms;

namespace kenan
{
    public partial class Form1 : Form
    {
        private string registeredUsername = "";
        private string registeredPassword = "";

        public Form1()
        {
            InitializeComponent();
        }

        // button1 (Qeydiyyat düyməsi)
        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1: Yuxarı sol (İstifadəçi adı)
            // textBox2: Yuxarı sağ (Şifrə)
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Lütfən, qeydiyyat üçün istifadəçi adı və şifrəni daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            registeredUsername = textBox1.Text;
            registeredPassword = textBox2.Text;

            MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
        }

        // button2 (Daxil ol düyməsi)
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(registeredUsername))
            {
                MessageBox.Show("Əvvəlcə qeydiyyatdan keçməlisiniz!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // textBox3: Aşağı sol (Daxil ol istifadəçi adı)
            // textBox4: Aşağı sağ (Daxil ol şifrə)
            if (textBox3.Text == registeredUsername && textBox4.Text == registeredPassword)
            {
                MessageBox.Show("Sistemə uğurla daxil oldunuz!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}