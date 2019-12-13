using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter_8
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        public Form1()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHandlersAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");
        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0)
                    return;

                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.listViewFilesAndFolders.Items.Clear();
                this.labelCurrentPath.Text = root;
                this.listViewFilesAndFolders.BeginUpdate();

                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.listViewFilesAndFolders.Items.Add(lvi);
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.listViewFilesAndFolders.Items.Add(lvi);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CreateHandlersAndFillListView()
        {
            ColumnHeader colHead = new ColumnHeader();

            colHead.Text = "Папки/Фаилове";
            colHead.Width = 200;
            this.listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Размер";
            colHead.Width = 100;
            this.listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Последна Модификация";
            colHead.Width = 200;
            this.listViewFilesAndFolders.Columns.Add(colHead);
        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            ListView lw = (ListView)sender;
            string fileName = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch
                {

                    return;
                }
            }
            else
            {
                PaintListView(fileName);
                folderCol.Add(fileName);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
                PaintListView(folderCol[0].ToString());
        }

        private void radioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                this.listViewFilesAndFolders.View = View.LargeIcon;
        }

        private void radioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                this.listViewFilesAndFolders.View = View.SmallIcon;
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                this.listViewFilesAndFolders.View = View.List;
        }

        private void radioButtonDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                this.listViewFilesAndFolders.View = View.Details;
        }

        private void radioButtonTile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                this.listViewFilesAndFolders.View = View.Tile;
        }
    }
}
