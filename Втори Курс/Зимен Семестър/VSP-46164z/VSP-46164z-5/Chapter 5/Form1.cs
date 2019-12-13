using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.buttonOk.Enabled = false;
            this.textBoxAddress.Tag = false;
            this.textBoxAge.Tag = false;

            this.textBoxName.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxAddress.Validating += new CancelEventHandler(textBoxEmpty_Validating);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string output;

            output = "Име: " + this.textBoxName.Text + "\r\n";
            output += "Адрес: " + this.textBoxAddress.Text + "\r\n";
            output += "Професия: " + (string)(this.checkBoxProgrammer.Checked ? "Програмист" : "Не е програмист") + "\r\n";
            output += "Пол: " + (string)(this.radioButtonMale.Checked ? "Мъж" : "Жена") + "\r\n";
            output += "Възраст: " + this.textBoxAge.Text + "\r\n";

            this.textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;

            output = "Помощна информация:\r\n\r\n";
            output += "Име = Вашето име\r\n";
            output += "Адрес = Вашият адрес\r\n";
            output += "Програмист = Маркирайте полето ако сте програмист\r\n";
            output += "Пол = Маркирайте своя пол\r\n";
            output += "Възраст = Вашата възраст\r\n";

            this.textBoxOutput.Text = output;
        }

        private void ValidateOK()
        {
            this.buttonOk.Enabled = ((bool) this.textBoxAddress.Tag
                && (bool) this.textBoxAge.Tag
                && (bool) this.textBoxName.Tag);
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }

            ValidateOK();
        }

        private void textBoxOccupation_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.CompareTo("Програмист") == 0 || tb.Text.Length == 0)
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }

            ValidateOK();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) || ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
                e.Handled = true;
        }

        private void textBoxAge_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.Text.Length > 0)
            {
                if(Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }

                ValidateOK();
            }
        }

        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }

            ValidateOK();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            ValidateOK();
        }
    }
}
