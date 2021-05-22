using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Livre
    {
        String code;
        String titre;
        double prix;

        public Livre()
        {
            this.code = null;
            this.titre = null;
            this.prix = 0;
        }

        public Livre(string code, string titre, double prix)
        {
            this.code = code;
            this.titre = titre;
            this.prix = prix;
        }


        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
        public double Prix { get => prix; set => prix = value; }


        public override string ToString()
        {
            return "Code: " + code + " | Titre: " + titre + " | Prix: " + prix;
        }



    }
}
