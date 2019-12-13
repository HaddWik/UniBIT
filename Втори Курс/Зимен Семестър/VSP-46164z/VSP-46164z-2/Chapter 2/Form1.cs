using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            this.Text = "English";
        }

        private void buttonBulgarian_Click(object sender, EventArgs e)
        {
            this.Text = "Български";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
