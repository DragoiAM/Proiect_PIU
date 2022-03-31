using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibrarieClase
{
    public class Fisier_auto
    {
        private const int NR_MAX_AUTO = 50;
        private string numeFisier;

        public Fisier_auto(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddAuto(Auto auto)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(auto.conversieSir());
            }
        }

        public Auto[] GetAuto(out int nrAuto)
        {
            Auto[] auto = new Auto[NR_MAX_AUTO];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrAuto = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    auto[nrAuto++] = new Auto(linieFisier);
                }
            }

            return auto;
        }


    }
}
