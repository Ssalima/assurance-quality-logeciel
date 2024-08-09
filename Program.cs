using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative3_2726563
{
    internal class Program
    {


        private static Dictionary<int, Etudiant> etudiants = new Dictionary<int, Etudiant>();
        private static Dictionary<int, Cours> cours = new Dictionary<int, Cours>();
        private static List<Notes> notes = new List<Notes>();

        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Ajouter un cours");
                Console.WriteLine("3. Ajouter une note");
                Console.WriteLine("4. Afficher un relevé de notes");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AjouterEtudiant();
                        break;
                    case "2":
                        AjouterCours();
                        break;
                    case "3":
                        AjouterNote();
                        break;
                    case "4":
                        AfficherReleve();
                        break;
                    case "5":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Option invalide");
                        break;
                }
            }
        }

        static void AjouterEtudiant()
        {
            Console.Write("Numéro d'étudiant: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nom: ");
            string nom = Console.ReadLine();
            Console.Write("Prénom: ");
            string prenom = Console.ReadLine();

            Etudiant etudiant = new Etudiant(numero, nom, prenom);
            etudiants[numero] = etudiant;
            DataManager.SauvegarderEtudiant(etudiant);
            Console.WriteLine("Étudiant ajouté !");
        }

        static void AjouterCours()
        {
            Console.Write("Numéro du cours: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Code: ");
            string code = Console.ReadLine();
            Console.Write("Titre: ");
            string titre = Console.ReadLine();

            Cours c = new Cours(numero, code, titre);
            cours[numero] = c;
            Console.WriteLine("Cours ajouté !");
        }

        static void AjouterNote()
        {
            Console.Write("Numéro d'étudiant: ");
            int numeroEtudiant = int.Parse(Console.ReadLine());
            Console.Write("Numéro du cours: ");
            int numeroCours = int.Parse(Console.ReadLine());
            Console.Write("Note: ");
            float note = float.Parse(Console.ReadLine());

            Notes n = new Notes(numeroEtudiant, numeroCours, note);
            notes.Add(n);
            Console.WriteLine("Note ajoutée !");
        }

        static void AfficherReleve()
        {
            Console.Write("Numéro d'étudiant: ");
            int numeroEtudiant = int.Parse(Console.ReadLine());

            Etudiant etudiant = DataManager.ChargerEtudiant(numeroEtudiant);
            if (etudiant == null)
            {
                Console.WriteLine("Étudiant non trouvé");
                return;
            }

            Console.WriteLine(etudiant);
            Console.WriteLine("Notes:");
            foreach (var note in notes)
            {
                if (note.NumeroEtudiant == numeroEtudiant)
                {
                    Console.WriteLine(note);
                }
            }
        }
    }

}

