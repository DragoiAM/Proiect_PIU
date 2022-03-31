using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarieClase
{
    public class Persoana
    {
        //constante
        private const char SEPARATOR_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int CNP = 3;

        //proprietati
        private int idPersoana;
        private string nume;
        private string prenume;
        private string cnp;

        //constructori
        public Persoana()
        {
            nume = prenume = cnp = string.Empty;
        }

        public Persoana(int idPersoana, string nume, string prenume, string _cnp)
        {
            this.idPersoana = idPersoana;
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = _cnp;
        }

        public Persoana(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);

            //ORDINEA DE PRELUARE A CAMPURILOR
            idPersoana = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            cnp = dateFisier[CNP];

        }

        //ordinea in care sunt scrie in fisier
        public string conversieSir()
        {
            string obiectPersoanaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_FISIER,
                idPersoana.ToString(),
                (nume ?? " NECUNOSCUT "),
                (prenume ?? " NECUNOSCUT "),
                (cnp ?? "NECUNOSCUT"));

            return obiectPersoanaPentruFisier;
        }

        public int GetIDPersoana()
        {
            return idPersoana;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }

        public string GetCNP()
        {
            return cnp;
        }
       
    }
}
