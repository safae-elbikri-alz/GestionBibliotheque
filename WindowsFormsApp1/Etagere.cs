using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Etagere
    {
        int num;
        private List<Livre> etagere;

        public Etagere()
        {
            num = 0;
            etagere = new List<Livre>();
        }

        //Remise d’un livre dans l’étagère
        public void Remettre_livre(Livre lelivre)
        {
            etagere.Add(lelivre);
        }

        //Vérifier l'existence du livre dans l'étagère et renvoyer sa position ou -1 sinon
        public int Position_livre(Livre L)
        {
            int pos = 0;
            foreach (Livre l in etagere)
            {
                if (L.Equals(l))
                {
                    pos = etagere.IndexOf(L);
                }
                pos = -1;
            }
            return pos;
        }

        //Renvoyer le livre stocké à un indice donné 
        public Livre livres_a_une_position(int k)
        {
            Livre livre = null;

            foreach (Livre l in etagere)
            {
                try
                {
                    if (k.Equals(etagere.IndexOf(l)))
                    {
                        livre = l;
                    }
                }
                catch { Console.WriteLine("Verifier la position du livre!!"); }

            }
            return livre;
        }

        //Retirer un livre de l’étagère
        public void retirer_livre(Livre lelivre)
        {
            foreach (Livre l in etagere)
            {
                try
                {
                    if (lelivre.Equals(l))
                    {
                        etagere.Remove(lelivre);
                    }
                }
                catch { Console.WriteLine("Le livre donne n'existe pas dans l'etagere"); }
            }
        }

        //Remplacer un livre par un autre dans l'étagère 
        public void remplacer(Livre ancien_livre, Livre nouveau_livre)
        {
            foreach (Livre l in etagere)
            {
                try
                {
                    if (ancien_livre.Equals(l))
                    {
                        try
                        {
                            if (!nouveau_livre.Equals(l))
                            {
                                ancien_livre = nouveau_livre;
                            }
                        }
                        catch { Console.WriteLine("le livre remplacant existe deja dans l'etagere !!"); }
                    }
                }
                catch
                {
                    Console.WriteLine("Le livre a remplacé n'existe pas dans l'etagere !!");
                }
            }
        }

        //Renvoyer le nombre de livre de l’étagère
        public int nbre_livres()
        {
            return etagere.Count();
        }
    }

    class Test
    {
        private List<Livre> ListeLivre;
        private List<Etagere> ListeEtagere;
        public Test()
        {
            ListeLivre = new List<Livre>();
            ListeEtagere = new List<Etagere>();
        }

        //Rechercher un livre et renvoyer null si le livre n’existe pas dans ListeLivre 
        public static Livre Rechercher_livre(String code)
        {
            Livre livre;
            foreach (Livre l in ListeLvre)
            {

                if (code.Equals(l.code))
                {
                    livre = l;
                }
                livre = null;
            }
            return livre;
        }

        //Rechercher une étagère et renvoyer null si l’étagère n’existe pas dans ListeEtagère 
        public static Etagere Rechercher_etagere(String num)
        {
            Etagere et;
            foreach (Etagere e in ListeEtagere)
            {
                if (num.Equals(e.num))
                {
                    et = e;
                }
                et = null;
            }
            return et;
        }

        //Ajout d'un livre dans la collection des livres ListeLivre
        public static void ajout_livre(String code, String titre, double prix)
        {
            foreach (Livre l in ListeLivre)
            {

                if (!code.Equals(l.code))
                {

                    ListeLivre.Add(l);
                }
            }
        }

        //Ajout d'une étagère dans la collection des étagères ListeEtagère
        public static void ajout_etagere(int num)
        {
            foreach (Etagere et in ListeEtagere)
            {

                if (!num.Equals(et.num))
                {

                    ListeEtagere.Add(et);
                }
            }
        }

        //Remettre un livre dans une étagère
        public static void Remettre_livre_etagere(String code, int num)
        {
            Etagere E = null;
            foreach (Etagere et in ListeEtagere)
            {

                if (num.Equals(et.num))
                {
                    E = et.num;
                    foreach (Livre l in E)
                    {

                        if (!code.Equals(l.code))
                        {
                            E.Remettre_livre(l);

                        }
                    }

                }
            }
        }


        //retirer un livre d'une étagère 
        public static void Retirer_livre_etagere(String code, int num)
        {
            Etagere E = null;
            foreach (Etagere et in ListeEtagere)
            {

                if (num.Equals(et.num))
                {
                    E = et.num;
                    foreach (Livre l in E)
                    {
                        if (code.Equals(l.code))
                        {
                            E.retirer_livre(l);

                        }
                    }

                }
            }

        }

        // Remplacer un livre par un autre
        public static void remplacer_livre_etagere(String code1, String code2, int num)
        {
            Etagere E = null;
            Livre li1 = null;
            Livre li2 = null;
            foreach (Etagere et in ListeEtagere)
            {

                if (num.Equals(et.num))
                {
                    E = et.num;
                    foreach (Livre l in E)
                    {
                        if (code1.Equals(l.code))
                        {
                            li1 = l.code;
                        }
                        E.remplacer(li1,li2.code2);
                    }
                }
            }
        }

        //lister les livres d'une étagère 
        public static List<Livre> lister_livre_etagere()
        {
            foreach (Etagere et in ListeEtagere)
            {

                if (num.Equals(et.num))
                {
                    E = et.num;
                }
            }
            return E;
        }

    }
}