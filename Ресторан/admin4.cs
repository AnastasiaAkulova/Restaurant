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
    public partial class admin4 : Form
    {
        public admin4()
        {
            InitializeComponent();
        }

        database Database = new database();
        private void makecolumn(DataGridView dgv)
        {
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("вес", "вес");
            dgv.Columns.Add("цена", "цена");
            dgv.Columns.Add("название", "название");
            dgv.Columns.Add("фирма", "фирма");
            dgv.Columns.Add("телефон", "телефон");
            dgv.Columns.Add("фио", "фио");
        }
        private void refreshgrid()
        {
            string query = "SELECT * FROM поставщик";
            SqlCommand command = new SqlCommand(query, Database.getconnection());
            Database.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns["ID"].DataPropertyName = "ID";
            dataGridView1.Columns["вес"].DataPropertyName = "вес";
            dataGridView1.Columns["цена"].DataPropertyName = "цена";
            dataGridView1.Columns["название"].DataPropertyName = "название";
            dataGridView1.Columns["фирма"].DataPropertyName = "фирма";
            dataGridView1.Columns["телефон"].DataPropertyName = "телефон";
            dataGridView1.Columns["фио"].DataPropertyName = "фио";
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
                textBox4.Text = (dataGridView1[3, c].Value).ToString();
                textBox1.Text = (dataGridView1[4, c].Value).ToString();
                textBox6.Text = (dataGridView1[5, c].Value).ToString();
                textBox7.Text = (dataGridView1[6, c].Value).ToString();
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
            textBox4.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
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
                    if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
                    {
                        var addquery = $"INSERT INTO поставщик VALUES ({textBox3.Text},{textBox2.Text},'{textBox4.Text}','{textBox1.Text}','{textBox6.Text}','{textBox7.Text}')";
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
                    if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
                    {
                        var addquery = $"UPDATE поставщик SET вес={textBox3.Text}, цена={textBox2.Text}, название='{textBox4.Text}', фирма='{textBox1.Text}', телефон='{textBox6.Text}', фио='{textBox7.Text}' WHERE ID={Int32.Parse(textBox5.Text)}";
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

                if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
                {
                    var addquery = $"DELETE FROM поставщик WHERE ID = {Int32.Parse(textBox5.Text)}";
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

        private void admin4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter1.Fill(this.ресторанDataSet1.Поставщик);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
        }
    }
}
