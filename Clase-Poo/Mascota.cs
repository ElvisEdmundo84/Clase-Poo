using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Poo
{
    public class Mascota
    {
        //Variable
        public string _Id { get; set; }
        public string _Nombre { get; set; }
        public int _Edad {  get; set; }

        // constructor
        public Mascota(string Id, string Nombre, int Edad) 
        {
            _Nombre = Nombre;
            _Edad = Edad;
            _Id = Id;
        }
        //METODO
        public void Caminar () 
        {
            Console.WriteLine("Estoy caminando");        
        }
        //Sobreescribir un método
        public void CaminarDos() 
        {
            Console.WriteLine("Estoy caminando" + "arriba");
        }
    }
}
