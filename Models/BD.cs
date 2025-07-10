using Microsoft.Data.SqlClient;
using Dapper;

public static class Bd
{
    private static string _connectionString = @"Server=localhost;DataBase=NombreBase;Integrated Security=True;TrustServerCertificate =True;";
    public static List<Clientes> LevantarClientes()
    {
        List<Clientes> clientes = new List<Clientes>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Patentes";
            clientes = connection.Query<Clientes>(query).ToList();
        }
        return clientes;
    }
    public static void AgregarComidas(Comidas comida)
    {
        string query = "INSERT INTO Jugadores (IdEquipo, Nombre, Fecha Nacimiento) VALUES (@Nombre, @IdTipoComida, @Precio, @SinGluten)";
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
}