using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative3_2726563
{
    public static class DataManager
    {
        public static void SauvegarderEtudiant(Etudiant etudiant)
        {
            string path = $"{etudiant.NumeroEtudiant}.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(etudiant.ToString());
            }
        }

        public static Etudiant ChargerEtudiant(int numeroEtudiant)
        {
            string path = $"{numeroEtudiant}.txt";
            if (!File.Exists(path))
            {
                return null;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string contenu = sr.ReadToEnd();
                string[] parties = contenu.Split(new[] { ", " }, StringSplitOptions.None);
                int num = int.Parse(parties[0].Split(':')[1]);
                string nom = parties[1].Split(':')[1];
                string prenom = parties[2].Split(':')[1];

                return new Etudiant(num, nom, prenom);
            }
        }
    }

}
