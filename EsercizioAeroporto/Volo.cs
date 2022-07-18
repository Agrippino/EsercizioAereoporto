using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace EsercizioAeroporto
{
    internal class Volo
    {
        private string CittaArrivo { get; set; }

        private DateTime DataPartenza { get; set; }
        private string CittaRitorno { get; set; }
        private DateTime DataRitorno { get; set; }
        private int BigliettiDisponibili { get; set; }
        private int BigliettiDaAcquistare { get; set; }
        private double CostoBiglietto { get; set; }
        private int BigliettiRimanenti { get; set; }

        private Movimentazioni Movimento;
        //costruttore che offre il volo di andata e ritorno
        public Volo(string CittaArrivo, DateTime DataPartenza, string CittaRitorno,DateTime DataRitorno, int BigliettiDisponibili, double CostoBiglietto)
        {
            this.CittaArrivo = CittaArrivo;
            this.DataPartenza = DataPartenza;
            this.CittaRitorno = CittaRitorno;
            this.DataRitorno = DataRitorno;     
            this.BigliettiDisponibili = BigliettiDisponibili;
            this.CostoBiglietto = CostoBiglietto;
        }
        
        //costruttore che offre solo il volo di andata 
        public Volo(string CittaArrivo,DateTime DataPartenza, int BigliettiDisponibili, double CostoBiglietto)
        {
            this.CittaArrivo = CittaArrivo;
            this.DataPartenza = DataPartenza;
            this.BigliettiDisponibili = BigliettiDisponibili;
            this.CostoBiglietto = CostoBiglietto;

        }
        
        public Volo()
        {

        }
        //Metodi Get e Set
        public void SetCittaArrivo(string CittaArrivo)
        {
            this.CittaArrivo = CittaArrivo;
        }
        public string GetCittaArrivo()
        {
            return this.CittaArrivo;
        }
        public void SetDataPartenza(DateTime DataPartenza)
        {   
            this.DataPartenza= DataPartenza;
            
        }
        public DateTime GetDataPartenza()
        {
            return this.DataPartenza;
        }
        public void SetDataRitorno(DateTime DataRitorno)
        {
            this.DataRitorno = DataRitorno;
        }
        public DateTime GetDataRitorno()
        {
            return this.DataRitorno;
        }
        public void SetCittaRitorno(string CittaRitorno)
        {
            this.CittaRitorno = CittaRitorno;
        }
        public string GetCittaRitorno()
        {
            return this.CittaRitorno;
        }        
        public int GetBigliettiDisponibili()
        {
            return this.BigliettiDisponibili;
        }
        public void SetBigliettiDisponibili(int BigliettiDisponibili)
        {
            this.BigliettiDisponibili = BigliettiDisponibili;
        }
        public int GetBigliettiDaAcquistare()
        {
            return this.BigliettiDaAcquistare;
        }
        public void SetBiglettiDaAcquistare(int BigliettiDaAcquistare)
        {
            if(BigliettiDaAcquistare < 1)
            {
                throw new Exception("I biglietti richiesti sono minori di 1");
            }
            this.BigliettiDaAcquistare = BigliettiDaAcquistare;
        }
        public double GetCostoBiglietto()
        {
            return this.CostoBiglietto;
        }
        public void SetCostoBiglietto(double CostoBiglietto)
        {
            this.CostoBiglietto = CostoBiglietto;
        }
        public int GetBigliettiRimanenti()
        {
            return this.BigliettiRimanenti;
        }
        public void SetBigliettiRimanenti(int BigliettiRimanenti)
        {
            this.BigliettiRimanenti = BigliettiRimanenti;
        }

        //metodo per controllare i DateTime delle partenze 
        public DateTime ControlloParametriDateTime(DateTime ControlloDateTime)
        {
            if (ControlloDateTime < DateTime.Now)
            {
                throw new Exception("La data non può essere precedente");
            }
            else
            {
                Console.WriteLine("Campo inserito correttamente \n");
            }
            return ControlloDateTime;
        }
        //idee per parsare la data 
        static void LetturaData() 
        { 
            var cultureInfo = new CultureInfo("en - US");
            string dateString = "12 Juni 2008";
            var dateTime = DateTime.Parse(dateString, cultureInfo);
            Console.WriteLine(dateTime);
            //Prima idea per Set
            /*var StampaData = DateTime.Parse(DataPartenza);
            StampaData.ToString("MM/dd/yyyy HH:mm");
            return StampaData;*/

            //Idea utilizzata inizialmente nei get funzionante 
            /*var StampaData = DateTime.Parse(DataPartenza);
            this.DataPartenza = StampaData.ToString("MM/dd/yyyy HH:mm");
            return this.DataPartenza;*/

        }
    }
}
