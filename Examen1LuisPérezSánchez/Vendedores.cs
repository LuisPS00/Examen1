using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPérezSánchez
{
    internal class Vendedores
    {
        private static Dictionary<string, string> Vendedor = new Dictionary<string, string>()
        {
            { "1", "Jose Gutierrez" },
            { "2", "Maria Soto" }

        };
        public Vendedores()
        {

        }
        public static void ListadoVendedores()
        {
            foreach (var Ven in Vendedor)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Codigo:{Ven.Key} Nombre del Vendedor: {Ven.Value}");
            }
        }
        public static String BuscarVendedor(string Vendedores)
        {
            string result;
            Console.WriteLine("Ingrese el codigo de vendedor:");
            result= Console.ReadLine();
            if (result == Vendedores)
            {
                Console.WriteLine(result);
            }
            else
            { Console.WriteLine("El vndedor no existe"); }

            return Vendedores;


        }
         class vendedor1: Ivendedor1
        {
            public string nombre { get; set; }

            public vendedor1()
            {
                nombre = "Jose Gutierrez";
            }
            public void VentasContado()
            {

            }
        }
       public class vendedor2: Ivendedor2
        {
            public string nombre { get; set; }

            public vendedor2()
            {
                nombre = "MariaSoto";
            }
        public void VentasCredito()
            {
               
            }
        }
        



    }
}
