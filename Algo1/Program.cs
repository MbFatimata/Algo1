using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo1.MenuPerso;

namespace Algo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.InsererLigne (new MenuItem { Numero = 2, Libelle = "menu 2" });
            menu.InsererLigne (new MenuItem { Numero = 3, Libelle = "menu 3" });
            menu.InsererLigne (new MenuItem { Numero = 4, Libelle = "menu 4" });
            menu.InsererLigne (new MenuItem { Numero = 5, Libelle = "menu 5" });
            menu.InsererLigne(new MenuItem { Numero = 5, Libelle = "menu 5" });

            int resultat = menu.Choisir();
            Console.WriteLine(resultat);
            Console.ReadLine();
        }

    }
}

            

