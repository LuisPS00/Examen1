using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPérezSánchez
{
    public class Vehiculos
    {


        static string[] Codigo = new string[5];
        static string[] Marca = new string[5];
        static float[] Costo = new float[5];
        static string[] Modelo = new string[5];
        static int indiceGeneral = 0;

        public Vehiculos()
        {

        }



        public static void AgregarVehículos()
        {
            char opcion = ' ';

            do
            {
                Console.WriteLine("Ingrese el codigo del vehículo");
                Codigo[indiceGeneral] = Console.ReadLine();
                Console.WriteLine("Ingrese la Marca del vehículo");
                Marca[indiceGeneral] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del vehículo");
                Costo[indiceGeneral] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el modelo del vehículo");
                Modelo[indiceGeneral] = Console.ReadLine();
                indiceGeneral++;
                Console.WriteLine("Desea continuar (S/N)");
 
            } while (!opcion.Equals('N'));
            if (indiceGeneral > 5)
            {
                Console.WriteLine("No puede agregar más de 5 vehículos.");
            }
            
           
        } public static void ModificarVehiculo()
        {
            Console.WriteLine("Digite el código. ");
            String codigo = Console.ReadLine();
            int indice = 0;
            float Resultado = 0;

            while (indice < indiceGeneral && !codigo.Equals(Codigo[indice]))
            {
                indice++;

            }


            if (indice > indiceGeneral - 1)
            {
                Console.WriteLine("El código digitado no existe");

            }
            else
            {
                Console.WriteLine("Ingrese marca nueva: " ); Marca[indice] = Console.ReadLine().ToUpper();
                Console.WriteLine("Ingrese modelo nuevo: " );  Modelo[indice] = Console.ReadLine().ToUpper();
                Console.WriteLine("ingrese nuevo costo: "  ); Costo[indice] = float.Parse(Console.ReadLine());
                
               
            }
        
    }
           
        
        public static void consultarVehículo()
        {

            Console.WriteLine("Digite el código. ");
            String codigo = Console.ReadLine();
            int indice = 0;
            float Resultado = 0;

            while (indice < indiceGeneral && !codigo.Equals(Codigo[indice]))
            {
                indice++;

            }


            if (indice > indiceGeneral - 1)
            {
                Console.WriteLine("El código digitado no existe");

            }
            else
            {
                Console.WriteLine("Marca: " + Marca[indice]);
                Console.WriteLine("Modelo: " + Modelo[indice]);
                Console.WriteLine("Costo: " + Costo[indice]);
              
            }
            
           
        }public static void Ventas() {
            int indice = 0;
            int codigo;
            Boolean Existe = false;
            Tipo tipo = new Tipo();
            Console.WriteLine("Digite le código del vehículo que desea consultar:"); codigo =int.Parse(Console.ReadLine());
            
            {
                if (indice < indiceGeneral && !codigo.Equals(Codigo[indice])) 
                {
                Console.WriteLine($"Marca: {Marca[indice]}");
                Console.WriteLine($"Modelo: {Modelo[indice]}");
                Console.WriteLine($"Modelo: {Costo[indice]}");
                Existe= true;
                 
                }
                

            } if (!Existe) Console.WriteLine("El Vehículo no existe.");

            Console.WriteLine("Digite el tipo");
            
            
            if (tipo.BuscarTipo(Console.ReadLine())) 
            { 
                Console.WriteLine("Tipo existe"); 
            }
            else
            {
                Console.WriteLine("Tipo no existe");
            }
        }public static void VehículosRegistrados()
        {
            
                foreach (string item1 in Codigo)
                {
                    Console.WriteLine("Codigo:" + item1);
                }
                foreach (string item2 in Marca)
                {
                    Console.WriteLine("Marca: "+ item2);
                }
                foreach (string item3 in Modelo)
                {
                    Console.WriteLine("Modelo:" + item3);
                }
                
                foreach (float item4 in Costo)
                {
                    Console.WriteLine("Costo:" + item4);
                }
          
        }
       
    }
}
