using System;

namespace LibrarieClase
{
    public class Auto
    {
        //constante
        private const char SEPARATOR_FISIER = ';';
        private const int ID = 0;
        private const int MARCA = 1;
        private const int CULOARE = 2;
        private const int AN = 3;
        private const int VIN = 4;
        private const int INCHIRIAT = 5;

        //proprietati
        private int IdAuto;
        private string marca;
        private string culoare;
        private string an;
        private string vin;
        private string inchiriat;

        //constructori
        public Auto()
        {
            marca = culoare = an = vin = inchiriat = string.Empty;
        }

        public Auto(int _idAuto, string _marca, string _culoare, string _an, string _vin, string _inchiriat)
        {
            this.IdAuto = _idAuto;
            this.marca = _marca;
            this.culoare = _culoare;
            this.an = _an;
            this.vin = _vin;
            this.inchiriat = _inchiriat;



        }

        public Auto(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);

            //ORDINEA DE PRELUARE A CAMPURILOR
            IdAuto = Convert.ToInt32(dateFisier[ID]);
            marca = dateFisier[MARCA];
            culoare = dateFisier[CULOARE];
            an = dateFisier[AN];
            vin = dateFisier[VIN];
            inchiriat = dateFisier[INCHIRIAT];

        }

        //ordinea in care sunt scrie in fisier
        public string conversieSir()
        {
            string obiectPersoanaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_FISIER,
                IdAuto.ToString(),
                (marca ?? " NECUNOSCUT "),
                (culoare ?? " NECUNOSCUT "),
                (an ?? " NECUNOSCUT "),
                (vin ?? " NECUNOSCUT "),
                (inchiriat ?? "NECUNOSCUT"));

            return obiectPersoanaPentruFisier;
        }

        public int GetIDAuto()
        {
            return IdAuto;
        }

        public string GetMarca()
        {
            return marca;
        }

        public string GetCuloare()
        {
            return culoare;
        }


        public string GetAN()
        {
            return an;
        }
        public string GetVin()
        {
            return vin;
        }
        public string GetInchiriat()
        {
            return inchiriat;
        }


    }
}
