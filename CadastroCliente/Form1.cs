
using System.Data.SqlClient;
namespace CadastroCliente
{
    public partial class Form1 : Form

    {
        private Conexao conexao; 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
            conexao = new Conexao(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (ValidarLogin(usuario, senha))
            {
                this.Hide(); 
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private bool ValidarLogin(string Usuario, string Senha)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Senha = @senha";
            SqlConnection con = null; 

            try
            {
                con = conexao.AbrirConexao(); 
                using (SqlCommand comando = new SqlCommand(query, con))
                {
                    comando.Parameters.AddWithValue("@usuario", Usuario);
                    comando.Parameters.AddWithValue("@senha", Senha);

                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


