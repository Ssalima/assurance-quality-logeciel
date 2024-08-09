using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative3_2726563
{
    public class Etudiant
    {  //declaration des varibales  de la classe Etudiant
        public int NumeroEtudiant { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            NumeroEtudiant = numeroEtudiant;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"Numéro: {NumeroEtudiant}, Nom: {Nom}, Prénom: {Prenom}";
        }
    }

}
