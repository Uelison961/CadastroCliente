
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class TelaConsulta : Form
    {
        private Form telaAnterior; 


        private Conexao conexao; 
        public TelaConsulta()
        {
            InitializeComponent();
            conexao = new Conexao(); 
            this.telaAnterior = telaAnterior; 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            DataTable resultados = BuscarClientes(pesquisa); 

            
            if (resultados != null)
            {
                dgvResultados.DataSource = resultados; 
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao buscar os clientes.");
            }
        }

        
        private DataTable BuscarClientes(string pesquisa)
        {
            string query = "SELECT * FROM Clientes WHERE Nome LIKE @pesquisa OR CPF LIKE @pesquisa";
            SqlConnection con = null;

            try
            {
                con = conexao.AbrirConexao(); 

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable resultados = new DataTable();

                    adapter.Fill(resultados); 

                    
                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum cliente encontrado com os critérios de pesquisa.");
                    }

                    return resultados; 
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro SQL: " + sqlEx.Message); 
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar clientes: " + ex.Message); 
                return null;
            }
            finally
            {
                if (con != null)
                {
                    conexao.FecharConexao(con); 
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultados.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvResultados.SelectedRows[0].Cells["Id"].Value);
                ExcluirCliente(id);
                MessageBox.Show("Cliente excluído com sucesso!");
                btnBuscar.PerformClick(); 
            }
        }

        private void ExcluirCliente(int id)
        {
            string query = "DELETE FROM Clientes WHERE Id = @id";
            SqlConnection con = null;

            try
            {
                con = conexao.AbrirConexao(); 

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    conexao.FecharConexao(con); 
                }
            }
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaConsulta_Load(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show(); 
        }

    }
}


