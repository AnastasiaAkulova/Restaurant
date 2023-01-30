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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user1 f = new user1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user3 f = new user3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user2 f = new user2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
