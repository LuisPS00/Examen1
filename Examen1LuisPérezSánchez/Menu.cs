using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPérezSánchez
{
   static class Menu
    {
        
        
        public static void Principal()
        {
           Tipo tipo = new Tipo();
            
            int opcion = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Menu Principal ********");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vheículos");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ventas");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Reportes");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("4- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: SubVMenuheículos(); break; 
                    case 2:  Vehiculos.Ventas(); break;
                        

                    case 3:  
                        Vendedores.ListadoVendedores();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("********************************");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Los Tipos de Vehículos disponibles son:");
                        tipo.ListadoVehículos();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("********************************");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Los vehículos registrado son:");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Vehiculos.VehículosRegistrados(); 
                        break;
                    case 4: Console.WriteLine("Gracias,  Adios");
                        

                        break;
                  
                }
            } while (opcion != 4);

        }

        public static void SubVMenuheículos()
        {
            byte opcion = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Servicios ********");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Agregar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Modificar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("3- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Consultar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("4- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Salir");             
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: Vehiculos.AgregarVehículos();break;
                    case 2:Vehiculos.ModificarVehiculo(); break;
                    case 3:  Vehiculos.consultarVehículo(); break;
                    case 4:
                        Console.WriteLine("Volviendo al menú principal....");
                        Menu.Principal(); break;
                       
                       
                    
                    default:
                        break;
                }
            } while (opcion != 4);

        }
    }
}
