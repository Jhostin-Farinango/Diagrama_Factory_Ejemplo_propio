using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_Factory_Veterinaria
{
    public class CreatePerro : Alimentador
    {
        public CreatePerro(String Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IAnimal CreateProduct(string Nombre)
        {
            Console.WriteLine(" - CreatePerro  ");

            Perro perro = new Perro("Labrador");
            perro.Nombre = Nombre;

            return perro;
        }
    }
}
