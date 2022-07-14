using System;
using System.Collections.Generic;

namespace Diagrama_Factory_Veterinaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Alimentador> lista = new List<Alimentador>();
            lista.Add(new CreateGato("Michi"));
            lista.Add(new CreateGato("Pedro"));
            lista.Add(new CreatePerro("Lupe"));

            foreach (Alimentador alimentador in lista)
            {
                alimentador.createAnimal();
            }
        }
    }
}