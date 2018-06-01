using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> list = new List<MenuItem>
            {
                new MenuItem { Numero =1, Libelle= "menu 1"},
                new MenuItem { Numero =2, Libelle= "menu 2"},
                new MenuItem { Numero =3, Libelle= "menu 3"},
                new MenuItem { Numero =4, Libelle= "menu 4"},
                new MenuItem { Numero =5, Libelle= "menu 5"},
                new MenuItem { Numero =5, Libelle= "menu 5"},
            };
            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();

        }
        private static int GererMenu(List<MenuItem> menu)
        {
            //Afiche les elements du menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} - {ligne.Libelle}");

            }

            // recuperation choix utilisateur
            Console.WriteLine("Faites votre choix ");
            int ChoixUtilisateur = int.Parse(Console.ReadLine());

            //test du choix par rapport aux elements du menu
            while (true)
            {
                foreach (MenuItem ligne in menu)
                {
                    if (ChoixUtilisateur == ligne.Numero)
                    {
                        return ChoixUtilisateur;
                    }
                    //return menu.SingleOrDefault(x=> x.Numero == choixUtilisateur) != null ? choix : -1;              
                }
                Console.WriteLine("Erreur lors du choix");
            }
        }

        /// <summary>
        /// MenuItem représente une ligne du menu
        /// </summary>
        class MenuItem
        {
            public int Numero { get; set; }
            public string Libelle { get; set; }
        }
        class NumeroItem
        {
            public int Numero { get; set; }
        }
    }
}

            

