using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        private static int AfficherMenu(List<string> menu)
        {
            foreach (string ligne in menu)
            {
                Console.WriteLine(ligne);

            }

            Console.Write("Faites votre choix");
            int ChoixUtilisateur = int.Parse(Console.ReadLine());
            return ChoixUtilisateur;


        }
    }
}
