using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Laboratorio13
{
    public partial class Form1 : Form
    {
       string connectionString = @"Server=DESKTOP-F9A2H8U;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show(@"Se abri� la conexi�n con el servidor SQL Server y se seleccion� la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerr� la conexi�n.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
