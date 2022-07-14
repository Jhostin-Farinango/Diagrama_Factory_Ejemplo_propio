using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_Factory_Veterinaria
{
    public class Perro : IAnimal
    {
        public String Nombre { get; set; }

        public string Raza { get; set; }

        public Perro(String Raza)
        {
            this.Raza = Raza;
        }
        public void alimentador()
        {
            Console.WriteLine("--Estoy en Perro / alimentador()");
            Console.WriteLine("Nombre " + this.Nombre);
            Console.WriteLine("Raza " + this.Raza);
        }
    }
}
