using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo1.MenuPerso
{
    class Menu
    {
        private List<MenuItem> lignes; //valeur nulle par default
        public Menu()
        {
            lignes = new List<MenuItem>();
        }

        public void InsererLigne (MenuItem ligne)
        {
            ///<summary>
            /////insere une Ligne dans le menu
            ///</summary>
            ///<param name = "item"> Element a inserer dans le menu </param>
            ///<exception cref="ArgumentException"> Si le numero de la ligne est deja present dans le menu </exception>

            foreach (MenuItem numero in lignes)
            {
                if (numero.Numero == ligne.Numero)
                {
                    throw new ArgumentException($"Le numero {ligne.Numero} existe deja dans le menu");//throw permet de 'jeter' la valeur de l'exception

                }
            }
            // ou a la place du foreach 
            //if (menuItems.Exists(x=>x.Numero == item.Numero))
            //    { 
            //      throw new ArgumentException(
            //          $"Le numero {ligne.Numero} existe deja dans le menu");
            //    }
            lignes.Add(ligne);
                
        }


        public void Afficher()
        {
            foreach (MenuItem ligne in lignes)
            {
                Console.WriteLine($"{ligne.Numero} - {ligne.Libelle}");

            }
        }

        public int Choisir()
        {
            //récupération saisie
            Console.WriteLine("Faites votre choix ");
            int ChoixUtilisateur = int.Parse(Console.ReadLine());

            //test du choix par rapport aux elements du menu
            while (true)
            {
                foreach (MenuItem ligne in lignes)
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

    }
}
