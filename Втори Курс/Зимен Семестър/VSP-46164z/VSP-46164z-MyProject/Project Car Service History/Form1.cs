using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_Car_Service_History
{
    public partial class mainForm : Form
    {
        private string dataFilePath = "empty";

        public mainForm()
        {
            InitializeComponent();
            CreateHandlersAndFillListView();
            buttonAddRecord.Enabled = false;
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            AddCar formAdd = new AddCar();
            formAdd.ShowDialog();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataFilePath = openFileDialog.FileName;
                LoadDetails(dataFilePath);
                buttonAddRecord.Enabled = true;
            }
        }

        private void CreateHandlersAndFillListView()
        {
            listViewServiceData.View = View.Details;
            listViewServiceData.GridLines = true;
            listViewServiceData.FullRowSelect = true;
            listViewServiceData.Columns.Add("Дата", 100);
            listViewServiceData.Columns.Add("Километраж", 100);
            listViewServiceData.Columns.Add("Описание на дейността", 556);
        }

        public static void LoadDetails(string filePath)
        {
            listViewServiceData.Items.Clear();
            DataSet ds = new DataSet();
            ds.ReadXml(filePath);
            ListViewItem item;

            foreach (DataRow dr in ds.Tables["details"].Rows)
            {
                labelMakeFill.Text = dr["make"].ToString();
                labelModelFill.Text = dr["model"].ToString();
                labelLicensePlateFill.Text = dr["licensePlate"].ToString();
                labelVinFill.Text = dr["vin"].ToString();
            }

            if (ds.Tables["service"] != null)
            {
                foreach (DataRow dr in ds.Tables["service"].Rows)
                {
                    item = new ListViewItem(new string[] { dr["date"].ToString(), dr["odometer"].ToString(), dr["description"].ToString() });
                    listViewServiceData.Items.Add(item);
                }
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord();
            addRecord.FileName = dataFilePath;
            addRecord.ShowDialog();
        }
    }
}
