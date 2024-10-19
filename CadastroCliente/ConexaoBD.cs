using System;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Diagnostics.Metrics;

public class Conexao
{
    private string connectionString;

    
    public Conexao()    
    {
        
        connectionString = "Data Source=DESKTOP-F9N7RMS;Initial Catalog=Cadastro;Integrated Security=True;TrustServerCertificate=True";
    }

    
    public SqlConnection AbrirConexao()
    {
        SqlConnection con = new SqlConnection(connectionString);
        try
        {
            con.Open();
            Console.WriteLine("Conexão aberta com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
            con = null;
        }
        return con;
    }

    
    public void FecharConexao(SqlConnection con)
    {
        if (con != null && con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
            Console.WriteLine("Conexão fechada com sucesso!");
        }
        else
        {
            Console.WriteLine("A conexão já está fechada ou é nula.");
        }
    }
}
