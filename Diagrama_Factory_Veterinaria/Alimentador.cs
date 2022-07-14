using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_Factory_Veterinaria
{
    public abstract class Alimentador
    {
        public String Nombre { get; set; }
        public Alimentador(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void createAnimal()
        {
            Console.WriteLine("Estoy en Creator");
            IAnimal product = CreateProduct(Nombre);
            product.alimentador();
        }

        public abstract IAnimal CreateProduct(String Nombre);
    }
}
