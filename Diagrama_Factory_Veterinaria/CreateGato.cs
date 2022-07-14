using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_Factory_Veterinaria
{
    public class CreateGato : Alimentador
    {
        public CreateGato(String Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IAnimal CreateProduct(string Nombre)
        {
            Console.WriteLine(" - CreateGato / CreateAnimal ");
            Gato gato = new Gato("Femenino", 2022);
            gato.Nombre = Nombre;
            return gato;
        }
    }
}
