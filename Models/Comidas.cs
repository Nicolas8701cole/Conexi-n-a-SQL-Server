public class Comidas
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int IdTipoComida { get; set; }
    public double Precio { get; set; }
    public bool SinGluten { get; set; }
    public Comidas(string Nombre, int IdTipoComida, double Precio, bool SinGluten){
        this.Nombre = Nombre;
        this.IdTipoComida = IdTipoComida;
        this.Precio = Precio;
        this.SinGluten = SinGluten;
    }
}