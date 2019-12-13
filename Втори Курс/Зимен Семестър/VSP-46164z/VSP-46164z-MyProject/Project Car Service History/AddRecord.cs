using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_Car_Service_History
{
    public partial class AddRecord : Form
    {
        public string FileName { get; set; }
        
        public AddRecord()
        {
            InitializeComponent();
            this.buttonSubmit.Enabled = false;
            this.textBoxOdometer.Tag = false;
            this.boxDescription.Tag = false;

            this.textBoxOdometer.Validating += new CancelEventHandler(textBoxOdometerEmpty_Validating);
            this.boxDescription.Validating += new CancelEventHandler(textBoxDescEmpty_Validating);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (AddRecordToDatabase())
            {
                mainForm.LoadDetails(FileName);
                this.Close();
                MessageBox.Show("Сервизните данни са запазени успешно.");
            }
            else
            {
                MessageBox.Show("Възникна грешка при запазването на данните!");
            }
        }

        private void ValidateSubmit()
        {
            this.buttonSubmit.Enabled = ((bool)this.textBoxOdometer.Tag && (bool)this.boxDescription.Tag);
        }

        private void textBoxOdometerEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.OrangeRed;
                tb.Tag = false;
            }
            else
            {
                bool isNumeric = true;
                foreach (char c in tb.Text)
                {
                    if (!Char.IsNumber(c))
                    {
                        isNumeric = false;
                        break;
                    }
                }

                if (isNumeric)
                {
                    tb.BackColor = SystemColors.Window;
                    tb.Tag = true;
                }
                else
                {
                    tb.BackColor = Color.OrangeRed;
                    tb.Tag = false;
                }
            }

            ValidateSubmit();
        }

        private void textBoxDescEmpty_Validating(object sender, CancelEventArgs e)
        {
            RichTextBox tb = (RichTextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.OrangeRed;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }

            ValidateSubmit();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.OrangeRed;
                tb.Tag = false;
            }
            else
            {
                bool isNumeric = true;
                foreach (char c in tb.Text)
                {
                    if (!Char.IsNumber(c))
                    {
                        isNumeric = false;
                        break;
                    }
                }

                if (isNumeric)
                {
                    tb.BackColor = SystemColors.Window;
                    tb.Tag = true;
                }
                else
                {
                    tb.BackColor = Color.OrangeRed;
                    tb.Tag = false;
                }
            }

            ValidateSubmit();
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            RichTextBox tb = (RichTextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.OrangeRed;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }

            ValidateSubmit();
        }

        private bool AddRecordToDatabase()
        {
            bool result;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(FileName);

                XmlNode node = doc.CreateNode(XmlNodeType.Element, "service", null);

                XmlNode nodeDate = doc.CreateElement("date");
                nodeDate.InnerText = DateTime.Now.ToString("dd MMMM yyyy");

                XmlNode nodeOdo = doc.CreateElement("odometer");
                nodeOdo.InnerText = this.textBoxOdometer.Text;

                XmlNode nodeDesc = doc.CreateElement("description");
                nodeDesc.InnerText = this.boxDescription.Text;

                node.AppendChild(nodeDate);
                node.AppendChild(nodeOdo);
                node.AppendChild(nodeDesc);

                doc.DocumentElement.AppendChild(node);
                doc.Save(FileName);

                result = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Възникна грешка при записването на промените: " + err.ToString());
                result = false;
            }

            return result;
        }
    }
}
