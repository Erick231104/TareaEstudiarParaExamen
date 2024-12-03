using System.Collections.Generic;

public class Categoria
{
    public string Nombre { get; set; }
    public List<Producto> Productos { get; set; }

    public Categoria(string nombre)
    {
        Nombre = nombre;
        Productos = new List<Producto>();
    }
}
