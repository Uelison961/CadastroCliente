using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class TelaPrincipal : Form
    {
        private Form telaLogin; 


        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog(); 
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            TelaConsulta telaConsulta = new TelaConsulta();
            telaConsulta.ShowDialog(); 
        }

        private void btnSair_Click(object sender, EventArgs e)

        {
            this.Hide(); 
            Form1 form1 = new Form1();
            form1.Show(); 
        }
    }
}
    

