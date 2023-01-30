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
    public partial class admin12 : Form
    {
        public admin12()
        {
            InitializeComponent();
        }

        database Database = new database();
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("id", "id");
            dgv.Columns.Add("название", "название");
            dgv.Columns.Add("масса", "масса");
        }
        private void refreshgrid()
        {
            string query = "SELECT Блюдо.название as название, Sum(Рецепт.Количество) AS масса FROM Блюдо JOIN Рецепт ON Блюдо.id = Рецепт.блюдо GROUP BY Блюдо.название";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].DataPropertyName = "id";
            dataGridView1.Columns["название"].DataPropertyName = "название";
            dataGridView1.Columns["масса"].DataPropertyName = "масса";
            dataGridView1.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                label1.Text = "Название: " + (dataGridView1[1, c].Value).ToString();
                label2.Text = "Вес: " + (dataGridView1[2, c].Value).ToString();
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

        private void admin12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter1.Fill(this.ресторанDataSet1.Блюдо);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter =
                    string.Format("[название] LIKE '%{0}%'", textBox1.Text);
                updatefields();
            }
        }
    }
}
