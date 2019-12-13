using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLinkLabel();
        }

        internal System.Windows.Forms.LinkLabel LinkLabelExample;
        string[] keywords;
        string[] urlAddress = new string[] { };

        private void InitializeLinkLabel()
        {
            this.LinkLabelExample = new System.Windows.Forms.LinkLabel();
            this.LinkLabelExample.Links.Clear();

            this.LinkLabelExample.Location = new System.Drawing.Point(200, 30);
            this.LinkLabelExample.Name = "Example Links";

            this.LinkLabelExample.Size = new System.Drawing.Size(180, 30);
            this.LinkLabelExample.AutoSize = true;

            this.LinkLabelExample.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            string textString = "Главна уеб страница на УниБИТ.\n Подстраница за новини.";

            this.LinkLabelExample.Text = textString;
            this.LinkLabelExample.LinkColor = System.Drawing.Color.Blue;
            this.LinkLabelExample.ActiveLinkColor = System.Drawing.Color.Red;

            this.LinkLabelExample.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel_LinkClicked);

            keywords = new string[] { "уеб страница", "новини" };
            urlAddress = new string[] { "www.unibit.bg", "www.unibit.bg/news" };

            foreach (string keyword in keywords)
                this.LinkLabelExample.Links.Add(textString.IndexOf(keyword),keyword.Length);

            this.Controls.Add(this.LinkLabelExample);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "";

            switch (LinkLabelExample.Links.IndexOf(e.Link))
            {
                case 0:
                    url = urlAddress[0];
                    break;
                case 1:
                    url = urlAddress[1];
                    break;
            }

            e.Link.Visited = true;
            System.Diagnostics.Process.Start("opera.exe", url);
        }
    }
}
