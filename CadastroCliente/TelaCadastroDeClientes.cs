using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class TelaCadastro : Form
    {
        private Conexao conexao; 
        public TelaCadastro()
        {
            InitializeComponent();
            conexao = new Conexao(); 
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string endereco = txtEndereco.Text;

            if (SalvarCliente(nome, cpf, email, telefone, endereco))
            {
                MessageBox.Show("Cliente salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao salvar o cliente.");
            }
        }

        private bool SalvarCliente(string nome, string cpf, string email, string telefone, string endereco)
        {
            string query = "INSERT INTO Clientes (Nome, CPF, Email, Telefone, Endereco) VALUES (@nome, @cpf, @email, @telefone, @endereco)";

            SqlConnection con = null; 

            try
            {
                con = conexao.AbrirConexao(); 

                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cpf", cpf);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@endereco", endereco);

                    int rowsAffected = comando.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro SQL: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral: " + ex.Message);
                return false;
            }
            finally
            {
                if (con != null) 
                {
                    conexao.FecharConexao(con);
                }
            }
        }



        private void LimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            
                this.Hide(); 
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show(); 
        }
      
    }
}
