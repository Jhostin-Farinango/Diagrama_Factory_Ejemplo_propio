using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_Factory_Veterinaria
{
    public class Gato : IAnimal
    {
        public String Nombre { get; set; }
        public String Sexo { get; set; }
        public int añoNacimiento { get; set; }

        public Gato(string Sexo, int Año)
        {
            this.Sexo = Sexo;
            this.añoNacimiento = añoNacimiento;
        }
        public void alimentador()
        {
            Console.WriteLine("--Estoy en Gato / alimentador()");
            Console.WriteLine("Nombre " + this.Nombre);
            Console.WriteLine("Sexo " + this.Sexo);
            Console.WriteLine("añoNacimiento " + this.añoNacimiento);
        }
    }
}
