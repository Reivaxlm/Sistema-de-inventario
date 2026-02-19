using System;
using System.Collections.Generic;
using Tienda.Modelos;

namespace Tienda.Logica
{
    public class TiendaManager
    {
        private List<Producto> inventario = new List<Producto>();

        public void AgregarProducto(Producto p)
        {
            inventario.Add(p);
            Console.WriteLine("¡Producto agregado con éxito!");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n--- INVENTARIO DE LA TIENDA ---");
            if (inventario.Count == 0) Console.WriteLine("El inventario está vacío.");
            foreach (var prod in inventario)
            {
                Console.WriteLine(prod.ToString());
            }
        }
    }
}