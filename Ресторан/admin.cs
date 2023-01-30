using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin1 f = new admin1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin2 f = new admin2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin4 f = new admin4();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin3 f = new admin3();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
