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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
        }

        database Database = new database();
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("название", "название");
            dgv.Columns.Add("вкус", "вкус");
        }
        private void refreshgrid()
        {
            string query = "SELECT * FROM тип";
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
            dataGridView1.Columns["вкус"].DataPropertyName = "вкус";
            dataGridView1.Update();
        }
        private void updatefields()
        {
            if (dataGridView1.RowCount > 0)
            {
                int c = dataGridView1.CurrentCell.RowIndex;
                textBox5.Text = (dataGridView1[0, c].Value).ToString();
                textBox3.Text = (dataGridView1[1, c].Value).ToString();
                textBox2.Text = (dataGridView1[2, c].Value).ToString();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[dataGridView1.ColumnCount - 1];
            textBox5.Text = dataGridView1.RowCount.ToString();
            textBox3.Text = "";
            textBox2.Text = "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox5.Text == dataGridView1.RowCount.ToString())
                {
                    if ((textBox3.Text != "") && (textBox2.Text != ""))
                    {
                        var addquery = $"INSERT INTO тип VALUES ('{textBox3.Text}','{textBox2.Text}')";
                        var command = new SqlCommand(addquery, Database.getconnection());
                        command.ExecuteNonQuery();
                        refreshgrid();
                        updatefields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if ((textBox3.Text != "") && (textBox2.Text != ""))
                    {
                        var addquery = $"UPDATE тип SET название= '{textBox3.Text}', вкус='{textBox2.Text}' WHERE ID={Int32.Parse(textBox5.Text)}";
                        var command = new SqlCommand(addquery, Database.getconnection());
                        command.ExecuteNonQuery();
                        refreshgrid();
                        updatefields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if ((textBox3.Text != "") && (textBox2.Text != ""))
                {
                    var addquery = $"DELETE FROM тип WHERE ID = {Int32.Parse(textBox5.Text)}";
                    var command = new SqlCommand(addquery, Database.getconnection());
                    command.ExecuteNonQuery();
                    refreshgrid();
                    updatefields();
                }
                else
                {
                    MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void admin2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter1.Fill(this.ресторанDataSet1.Тип);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
        }
    }
}
