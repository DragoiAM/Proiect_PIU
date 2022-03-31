using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibrarieClase
{
    public class Fisier_persoana
    {
        private const int NR_MAX_PERSOANE = 50;
        private string numeFisier;

        public Fisier_persoana(string _numeFisier)
        {
            this.numeFisier = _numeFisier;
            Stream streamFisierText = File.Open(_numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddPersoana(Persoana persoana)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(persoana.conversieSir());
            }
        }

        public Persoana[] GetPersoana(out int nrPersoane)
        {
            Persoana[] persoana = new Persoana[NR_MAX_PERSOANE];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPersoane = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoana[nrPersoane++] = new Persoana(linieFisier);
                }
            }

            return persoana;
        }
        public Persoana GetPersoanaCautata(string nume, string prenume)
        {

            Persoana persoana;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {

                    persoana = new Persoana(linieFisier);
                    if (persoana.GetNume() == nume && persoana.GetPrenume() == prenume)
                    {

                        return persoana;

                    }

                }
                Persoana persoana_invalid = new Persoana();
                return persoana_invalid;
            }


        }


    }
}
