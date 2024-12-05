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
using MySql.Data.MySqlClient;
namespace ControleDeEstoque
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=estoque;user=root;password=root";
        public Form1()
        {
            InitializeComponent();
            AtualizarDataGridView();
        }
        private void AtualizarDataGridView()
        {
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM produtos", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (int.TryParse(textBox2.Text, out int quantidade) && decimal.TryParse(textBox3.Text, out decimal preco))
            {
                MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

                {
                    connection.Open();
                    string query = "INSERT INTO produtos (nome, quantidade, preco) VALUES (@nome, @quantidade, @preco)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", textBox1.Text);
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@preco", preco);
                        command.ExecuteNonQuery();
                    }
                }
                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para quantidade e preço.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                if (int.TryParse(textBox2.Text, out int quantidade) && decimal.TryParse(textBox3.Text, out decimal preco))
                {
                    MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

                    {
                        connection.Open();
                        string query = "UPDATE produtos SET nome=@nome, quantidade=@quantidade, preco=@preco WHERE id=@id";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@nome", textBox1.Text);
                            command.Parameters.AddWithValue("@quantidade", quantidade);
                            command.Parameters.AddWithValue("@preco", preco);
                            command.ExecuteNonQuery();
                        }
                    }
                    AtualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores válidos para quantidade e preço.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

                {
                    connection.Open();
                    string query = "DELETE FROM produtos WHERE id=@id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                AtualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            {
                connection.Open();
                string query = "SELECT * FROM produtos WHERE nome LIKE @nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", "%" + textBox1.Text + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            AtualizarDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["nome"].Value.ToString();
                textBox2.Text = row.Cells["quantidade"].Value.ToString();
                textBox3.Text = row.Cells["preco"].Value.ToString();
            }
        }
    }
}
