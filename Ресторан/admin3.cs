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
    public partial class admin3 : Form
    {
        public admin3()
        {
            InitializeComponent();
        }

        private void admin3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter1.Fill(this.ресторанDataSet1.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ресторанDataSet1.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter1.Fill(this.ресторанDataSet1.Блюдо);
            makecolumn(dataGridView1);
            refreshgrid();
            updatefields();
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
            string query = "SELECT * FROM блюдо where название like'%" + textBox6.Text + "%'";
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
                textBox5.Text = (dataGridView1[0, c].Value).ToString();
                textBox3.Text = (dataGridView1[1, c].Value).ToString();
                textBox2.Text = (dataGridView1[2, c].Value).ToString();
                textBox4.Text = (dataGridView1[3, c].Value).ToString();
                textBox1.Text = (dataGridView1[4, c].Value).ToString();
                listBox1.SelectedValue = (dataGridView1[5, c].Value).ToString();
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
                    if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != ""))
                    {
                        var addquery = $"INSERT INTO блюдо VALUES ('{textBox3.Text}',{textBox2.Text},'{textBox4.Text}',{textBox1.Text},{int.Parse(listBox1.SelectedValue.ToString())})";
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
                    if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != ""))
                    {
                        var addquery = $"UPDATE блюдо SET название='{textBox3.Text}', масса={textBox2.Text}, информация='{textBox4.Text}', готовка={textBox1.Text}, тип={int.Parse(listBox1.SelectedValue.ToString())} WHERE ID={Int32.Parse(textBox5.Text)}";
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

                if ((textBox3.Text != "") && (textBox2.Text != "") && (textBox4.Text != "") && (textBox1.Text != ""))
                {
                    var addquery = $"DELETE FROM блюдо WHERE ID = {Int32.Parse(textBox5.Text)}";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            refreshgrid();
            updatefields();
        }
    }
}
