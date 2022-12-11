using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_exo_9bis
{
    class Program
    { static void abs(int n,ref int result)
        {
            if(n < 0)
            {
                result = -n;
            }
            else
            {
                result = n;
            }
        }
        static void Main(string[] args)
        {// declaration 
            int resultat = 0;
            //saisie du nombre 
            Console.Write("Entrez un nombre entier = ");
            int nombre = int.Parse(Console.ReadLine());
            //calcul de la valeur absolue 
            abs(nombre, ref resultat);
            //affichage de la valeur abolue 
            Console.WriteLine("La valeur absolue de " + nombre + " est " + resultat);
            Console.ReadLine();
        }
    }
}
