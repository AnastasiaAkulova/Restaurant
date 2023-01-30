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
    public partial class autorizacia : Form
    {
        public autorizacia()
        {
            InitializeComponent();
        }

        private void autorizacia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter1.Fill(this.ресторанDataSet1.Пользователи);

        }
        private void ok_Click(object sender, EventArgs e)
        {
            string pass = Password.Text;
            DataRowView selectedGroupItem = Group.SelectedItem as DataRowView;
            string requiredPass = пользователиTableAdapter1.GetData().First(u => u.userGroup == Group.Text).userPassword;
            if (pass == requiredPass)
            {
                if (Group.Text.ToLower() == "admin")
                {
                    admin f = new admin();
                    f.Show();
                }
                if (Group.Text.ToLower() == "user")
                {
                    user f = new user();
                    f.Show();
                }
            }
            else MessageBox.Show("Wrong password", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
