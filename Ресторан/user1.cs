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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }
        database Database = new database();
        public int value;
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("id", "id");
            dgv.Columns.Add("блюдо", "блюдо");
        }
        private void makecolumn1(DataGridView dgv)
        {
            dgv.Columns.Add("ингредиенты", "ингредиенты");
        }
        private void refreshgrid()
        {
            string query = "SELECT id, блюдо.название as блюдо from блюдо ";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].DataPropertyName = "id";
            dataGridView1.Columns["блюдо"].DataPropertyName = "блюдо";
            dataGridView1.Update();
        }
        private void refreshgrid1()
        {
            string query1 = "select ингредиенты.название as ингредиенты from рецепт join ингредиенты on (ингредиенты.id = рецепт.ингредиенты) where рецепт.блюдо = " + value;
            SqlCommand command1 = new SqlCommand(query1, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();

            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = table1;
            dataGridView2.Columns["ингредиенты"].DataPropertyName = "ингредиенты";
            dataGridView2.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                label1.Text = "Блюдо: " + (dataGridView1[1, c].Value).ToString();
                label2.Text = (dataGridView1[1, c].Value).ToString();
                value = int.Parse((dataGridView1[0, c].Value).ToString());
            }
        }

        private void updatefields1()
        {
            if (dataGridView2.RowCount > 0)
            {
                int c = dataGridView2.CurrentCell.RowIndex;
                label3.Text = "Ингредиент: " + (dataGridView2[0, c].Value).ToString();
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
        private void user1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter1.Fill(this.ресторанDataSet1.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter1.Fill(this.ресторанDataSet1.Блюдо);
            makecolumn(dataGridView1);
            makecolumn1(dataGridView2);
            refreshgrid();
            updatefields();
            refreshgrid1();
            updatefields1();
        }
    }
}
