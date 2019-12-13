using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Project_Car_Service_History
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
            this.buttonCreate.Enabled = false;
            this.textBoxMake.Tag = false;
            this.textBoxModel.Tag = false;
            this.textBoxLicensePlate.Tag = false;
            this.textBoxVin.Tag = false;

            this.textBoxMake.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxModel.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxLicensePlate.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxVin.Validating += new CancelEventHandler(textBoxEmpty_Validating);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (createXmlFile())
            {
                this.Close();
                MessageBox.Show("Автомобилът е създаен успешно! Моля заредете файла с данните.");
            }
            else
            {
                MessageBox.Show("Възникна грешка при създаването на таблицата!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateCreate()
        {
            this.buttonCreate.Enabled = ((bool)this.textBoxMake.Tag && (bool)this.textBoxModel.Tag && (bool)this.textBoxLicensePlate.Tag && (bool)this.textBoxVin.Tag);
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

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

            ValidateCreate();
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
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }

            ValidateCreate();
        }

        private bool createXmlFile()
        {
            string carMake = this.textBoxMake.Text;
            string carModel = this.textBoxModel.Text;
            string licensePlate = this.textBoxLicensePlate.Text;
            string fileName = licensePlate + "_" + carMake + "_" + carModel + ".xml";
            bool result;

            try
            {
                if (File.Exists(fileName))
                {
                    MessageBox.Show("Файлът " + fileName + " вече съществува!");
                    result = false;
                }
                else
                {
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlElement element1 = doc.CreateElement(string.Empty, "carData", string.Empty);
                    doc.AppendChild(element1);

                    XmlElement element2 = doc.CreateElement(string.Empty, "details", string.Empty);
                    element1.AppendChild(element2);

                    XmlElement element3 = doc.CreateElement(string.Empty, "make", string.Empty);
                    XmlText text1 = doc.CreateTextNode(carMake);
                    element3.AppendChild(text1);
                    element2.AppendChild(element3);

                    XmlElement element4 = doc.CreateElement(string.Empty, "model", string.Empty);
                    XmlText text2 = doc.CreateTextNode(carModel);
                    element4.AppendChild(text2);
                    element2.AppendChild(element4);

                    XmlElement element5 = doc.CreateElement(string.Empty, "licensePlate", string.Empty);
                    XmlText text3 = doc.CreateTextNode(licensePlate);
                    element5.AppendChild(text3);
                    element2.AppendChild(element5);

                    XmlElement element6 = doc.CreateElement(string.Empty, "vin", string.Empty);
                    XmlText text4 = doc.CreateTextNode(this.textBoxVin.Text);
                    element6.AppendChild(text4);
                    element2.AppendChild(element6);

                    doc.Save(fileName);

                    result = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Възникна грешка при създаване на файла: " + err.ToString());
                result = false;
            }

            return result;
        }
    }
}
