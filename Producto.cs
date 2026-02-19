namespace Tienda.Modelos
{
    public class Producto
    {
        public string Nombre { get; set; } = string.Empty;
        public int Stock { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, int stock, decimal precio)
        {
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }

        // SOLO UN ToString, no más.
        public override string ToString()
        {
            return $"{Nombre} - {Precio:C}";
        }
    }
}