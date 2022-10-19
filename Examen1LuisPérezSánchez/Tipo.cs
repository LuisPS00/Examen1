using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPérezSánchez
{
       class Tipo
    {

        
        List<string>tipos=new List<string>() { "Automovil", "Motocicleta", "Dron"};
        int x = 0;

        public  Tipo()
        {

        }
         public  void ListadoVehículos()
        {
             foreach (string tipoV in tipos)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(tipoV);
                }
             
          

        }
        public  virtual  void TipoVehiculo() { Console.WriteLine("Hay muchos tipos de vehículos"); }
        
        public Boolean BuscarTipo(string valor) 
        { 
            Boolean existe = tipos.Contains(valor);
            return existe; 
        }
        class automovil : Tipo
        {
            public override void TipoVehiculo()
            {
                Console.WriteLine("Vehículo de 4 ruedas.");  
            }
        }
        class Motocicleta : Tipo
        {
            public override void TipoVehiculo()
            {
                Console.WriteLine("Vehículo de 2 ruedas.");
            }
        }
        class Dron : Tipo
        {
            public override void TipoVehiculo()
            {
                Console.WriteLine("Vehículo volador.");
            }
        }





    }
        
       
    
    
    
    
    
    
}


    
  

           
        
        
