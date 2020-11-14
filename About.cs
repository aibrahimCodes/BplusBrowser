using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WBrowser
{
    public partial class About : Form
    {
        private bool p;

        public About()
        {
            InitializeComponent();
        }

        public About(bool p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
