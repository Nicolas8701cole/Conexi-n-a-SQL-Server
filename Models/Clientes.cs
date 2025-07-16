public class Clientes
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Email { get; set; }
    public Clientes(string Nombre, string Apellido, int DNI, DateTime FechaNacimiento, string Email){
        this.Apellido = Apellido;
        this.Nombre = Nombre;
        this.DNI = DNI;
        this.FechaNacimiento = FechaNacimiento;
        this.Email = Email;
    }

    public Clientes ()
    {
        
    }
}