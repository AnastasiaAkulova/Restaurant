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
    public partial class admin11 : Form
    {
        public admin11()
        {
            InitializeComponent();
        }

        database Database = new database();
        public int value;
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("id", "id");
            dgv.Columns.Add("вкус", "вкус");
        }
        private void makecolumn1(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("название", "название");
            dgv.Columns.Add("масса", "масса");
            dgv.Columns.Add("информация", "информация");
            dgv.Columns.Add("готовка", "готовка");
        }
        private void refreshgrid()
        {
            string query = "SELECT id, вкус from тип ";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].DataPropertyName = "id";
            dataGridView1.Columns["вкус"].DataPropertyName = "вкус";
            dataGridView1.Update();
        }
        private void refreshgrid1()
        {
            string query1 = "select * from блюдо where тип = " + value;
            SqlCommand command1 = new SqlCommand(query1, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();

            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = table1;
            dataGridView2.Columns["ID"].DataPropertyName = "ID";
            dataGridView2.Columns["название"].DataPropertyName = "название";
            dataGridView2.Columns["масса"].DataPropertyName = "масса";
            dataGridView2.Columns["информация"].DataPropertyName = "информация";
            dataGridView2.Columns["готовка"].DataPropertyName = "готовка";
            dataGridView2.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                label1.Text = "Вкус: " + (dataGridView1[1, c].Value).ToString();
                label2.Text = (dataGridView1[1, c].Value).ToString();
                value = int.Parse((dataGridView1[0, c].Value).ToString());
            }
        }

        private void updatefields1()
        {
            if (dataGridView2.RowCount > 0)
            {
                int c = dataGridView2.CurrentCell.RowIndex;
                label5.Text = "Название: " + (dataGridView2[1, c].Value).ToString();
                label3.Text = "Масса: " + (dataGridView2[2, c].Value).ToString();
                label4.Text = "Инструкция: " + (dataGridView2[3, c].Value).ToString();
                label7.Text = "Время готовки: " + (dataGridView2[4, c].Value).ToString();
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
            refreshgrid1();
            updatefields1();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < dataGridView1.RowCount - 1)
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
            updatefields();
            refreshgrid1();
            updatefields1();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.RowIndex > 0)
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex - 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
            updatefields1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentCell.RowIndex < dataGridView2.RowCount - 1)
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex + 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
            updatefields1();
        }
        private void admin11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter1.Fill(this.ресторанDataSet1.Блюдо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter1.Fill(this.ресторанDataSet1.Тип);
            makecolumn(dataGridView1);
            makecolumn1(dataGridView2);
            refreshgrid();
            updatefields();
            refreshgrid1();
            updatefields1();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var word = textBox1.Text;

            }
        }
    }
}
