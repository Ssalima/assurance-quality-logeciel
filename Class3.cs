using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative3_2726563
{
    public class Notes
    {  //declaration des varibales  de la classe notes
        public int NumeroEtudiant { get; private set; }
        public int NumeroCours { get; private set; }
        public float Note { get; private set; }

        public Notes(int numeroEtudiant, int numeroCours, float note)
        {
            NumeroEtudiant = numeroEtudiant;
            NumeroCours = numeroCours;
            Note = note;
        }

        public override string ToString()
        {
            return $"Numéro Étudiant: {NumeroEtudiant}, Numéro Cours: {NumeroCours}, Note: {Note}";
        }
    }

}
