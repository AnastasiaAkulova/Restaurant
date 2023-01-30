using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ресторан
{
    public partial class user2 : Form
    {
        public user2()
        {
            InitializeComponent();
        }

        database Database = new database();
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("название", "название");
            dgv.Columns.Add("масса", "масса");
            dgv.Columns.Add("информация", "информация");
            dgv.Columns.Add("готовка", "готовка");
            dgv.Columns.Add("тип", "тип");
        }
        private void refreshgrid()
        {
            string query = "select блюдо.id, блюдо.название, масса, информация, готовка, тип.Название as тип from блюдо join тип on (Блюдо.Тип = Тип.id)";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["ID"].DataPropertyName = "ID";
            dataGridView1.Columns["название"].DataPropertyName = "название";
            dataGridView1.Columns["масса"].DataPropertyName = "масса";
            dataGridView1.Columns["информация"].DataPropertyName = "информация";
            dataGridView1.Columns["готовка"].DataPropertyName = "готовка";
            dataGridView1.Columns["тип"].DataPropertyName = "тип";
            dataGridView1.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                label1.Text = "Название: " + (dataGridView1[1, c].Value).ToString();
                label3.Text = "Масса: " + (dataGridView1[2, c].Value).ToString();
                label4.Text = "Инструкция: " + (dataGridView1[3, c].Value).ToString();
                label7.Text = "Время готовки: " + (dataGridView1[4, c].Value).ToString();
                label5.Text = "Тип: " + (dataGridView1[5, c].Value).ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex - 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            updatefields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < dataGridView1.RowCount - 1)
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            updatefields();
        }



        private void user2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter1.Fill(this.ресторанDataSet1.Блюдо);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
        }
    }
}
