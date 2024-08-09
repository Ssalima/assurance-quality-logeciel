using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_sommative3_2726563
{
    public class Cours

    {  //declaration des varibales  de la classe cours
        public int NumeroCours { get; private set; }
        public string Code { get; private set; }
        public string Titre { get; private set; }

        public Cours(int numeroCours, string code, string titre)
        {
            NumeroCours = numeroCours;
            Code = code;
            Titre = titre;
        }

        public override string ToString()
        {
            return $"Numéro: {NumeroCours}, Code: {Code}, Titre: {Titre}";
        }
    }

}
