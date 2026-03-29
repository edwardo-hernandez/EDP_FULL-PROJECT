using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hernandez_Edwardo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regform rform = new regform();
            rform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shopform sform = new shopform();
            sform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            priceform pform = new priceform();
            pform.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vendorform vform = new vendorform();
            vform.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
               userform uform = new userform();
            uform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timeform tform = new timeform();
            tform.Show();
        }
    }
}
