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
    public partial class user3 : Form
    {
        public user3()
        {
            InitializeComponent();
        }

        database Database = new database();
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("ингредиент", "ингредиент");
            dgv.Columns.Add("датапоставщик", "датапоставщик");
            dgv.Columns.Add("датапоставки", "датапоставки");
        }
        private void refreshgrid()
        {
            string query = "Select датапоставки, ингредиенты.название as ингредиент,датапоставщик from соответствие join ингредиенты on (соответствие.ингредиенты = ингредиенты.id) order by датапоставки desc";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["ID"].DataPropertyName = "ID";
            dataGridView1.Columns["ингредиент"].DataPropertyName = "ингредиент";
            dataGridView1.Columns["датапоставки"].DataPropertyName = "датапоставки";
            dataGridView1.Columns["датапоставщик"].DataPropertyName = "датапоставщик";
            dataGridView1.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                label1.Text = "Название: " + (dataGridView1[1, c].Value).ToString();
                label2.Text = "Дата ухода от поставщика: " + (dataGridView1[2, c].Value).ToString().Substring(0,10);
                label3.Text = "Дата поставки в ресторан: " + (dataGridView1[3, c].Value).ToString().Substring(0, 10);
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

        private void user3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Соответствие". При необходимости она может быть перемещена или удалена.
            this.соответствиеTableAdapter1.Fill(this.ресторанDataSet1.Соответствие);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
        }
    }
}
