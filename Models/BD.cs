using Microsoft.Data.SqlClient;
using Dapper;

public static class BD
{
    
    private static string _connectionString = @"Server=localhost;DataBase=TP07 -ORT Gourmet;Integrated Security=True;TrustServerCertificate=True;";
    
        public static List<Mesas> LevantarMesas()
    {
        List<Mesas> mesas = new List<Mesas>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Mesas";
            mesas = connection.Query<Mesas>(query).ToList();
        }
        return mesas;
    }
    public static List<Clientes> LevantarClientes()
    {
        List<Clientes> clientes = new List<Clientes>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Clientes";
            clientes = connection.Query<Clientes>(query).ToList();
        }
        return clientes;
    }
    public static void AgregarComidas(Comidas comida)
    {
        string query = "INSERT INTO Comidas (Nombre, IdTipoComida, Precio, SinGluten) VALUES (@Nombre, @IdTipoComida, @Precio, @SinGluten)";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Execute(query, new { Nombre = comida.Nombre, IdTipoComida = comida.IdTipoComida, Precio = comida.Precio, SinGluten = comida.SinGluten });
        }
    }
    public static int EliminarClientes()
    {
        string query = "DELETE FROM Clientes";
        int registrosAfectados = 0;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            registrosAfectados = connection.Execute(query);
        }
        return registrosAfectados;
    }
    public static void ActualizarMozos()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "update Mozos set Apellido = 'Pérez' where id in (Select idMozo from RegistroMesas where IdMesa = 5)";
            connection.Query<Clientes>(query).ToList();
        } 
    }
}