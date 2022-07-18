using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAeroporto
{
    internal class Clienti
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }

        private DateTime DataNascita = new DateTime();
        private int Eta { get; set; }
        private string LuogoNascita { get; set; }
        private string CodiceFiscale { get; set; }
        private string IndirizzoCivico { get; set; }
        private int NumeroCivico { get; set; }
        private string CittaResidenza { get; set; }
        private string Provincia { get; set; }
        private string Email { get; set; }
        private string NumeroCellulare { get; set; }
        private string IBAN { get; set; }

        public Clienti(string Nome, string Cognome, int Eta, DateTime DataNascita, string LuogoNascita, string CodiceFiscale, string IndirizzoCivico, int NumeroCivico, string CittaResidenza, string Provincia, string Email, string NumeroCellulare, string IBAN)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
            this.DataNascita = DataNascita;
            this.LuogoNascita = LuogoNascita;
            this.CodiceFiscale = CodiceFiscale;
            this.IndirizzoCivico = IndirizzoCivico;
            this.CittaResidenza = CittaResidenza;
            this.Provincia = Provincia;
            this.NumeroCivico = NumeroCivico;
            this.Email = Email;
            this.NumeroCellulare = NumeroCellulare;
            this.IBAN = IBAN;
        }
        public Clienti()
        {

        }

        //metodi get e set con i dovuti controlli 
        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public void SetCognome(string Cognome)
        {
            this.Cognome = Cognome;
        }
        public string GetCognome()
        {
            return this.Cognome;
        }
        public void SetDataNascita(DateTime DataNascita)
        {
            if (DataNascita == DateTime.Today || DataNascita > DateTime.Now)
            {
                throw new Exception("La data inserita non può essere uguale o superirore a oggi");
            }
            this.DataNascita = DataNascita;
        }
        public DateTime GetDataNascita()
        {
            return this.DataNascita;
        } 
        public void SetEta(int Eta)
        {
            this.Eta = Eta;
        }
        public int GetEta()
        {
            return this.Eta;
        }
        public void SetLuogoNascita(string LuogoNascita)
        {
            this.LuogoNascita = LuogoNascita;
        }
        public string GetLuogoNascita()
        {
            return this.LuogoNascita;
        }
        public void SetCodiceFiscale(string CodiceFiscale)
        {
            if (CodiceFiscale.Length < 15)
            {
                throw new Exception("Il codice fiscale inserito è minore di 16 caratteri");
            }
            this.CodiceFiscale = CodiceFiscale;
        }
        public string GetCodiceFiscale()
        {
            return this.CodiceFiscale;
        }
        public void SetIndirizzoCivico(string IndirizzoCivico)
        {
            this.IndirizzoCivico = IndirizzoCivico;
        }
        public string GetIndirizzoCivico()
        {
            return this.IndirizzoCivico;
        }
        public void SetCittaResidenza(string CittaResidenza)
        {
            this.CittaResidenza = CittaResidenza;
        }
        public string GetCittaResidenza()
        {
            return this.CittaResidenza;
        }
        public void SetProvincia(string Provincia)
        {
            this.Provincia = Provincia;
        }
        public string GetProvincia()
        {
            return this.Provincia;
        }
        public void SetNumeroCivico(int NumeroCivico)
        {
            this.NumeroCivico = NumeroCivico;
        }
        public int GetNumeroCivico()
        {
            return this.NumeroCivico;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public void SetNumeroCellulare(string NumeroCellulare)
        {
            if (NumeroCellulare.Length < 9)
            {
                throw new Exception("Questo campo non può essere vuoto o inferirore a 9 cifre");
            }
            this.NumeroCellulare = NumeroCellulare;
        }
        public string GetNumeroCellulare()
        {
            return this.NumeroCellulare;
        }
        public void SetIBAN(string IBAN)
        {
            if (IBAN == "" || IBAN.Length < 26)
            {
                throw new Exception("Questo campo non può essere vuoto o inferiore a 27 caratteri ");
            }
            this.IBAN = IBAN;
        }
        public string GetIBAN()
        {
            return this.IBAN;
        }     

        //metodo per controllare i parametri stringa 
        public string ControlloParametriStringa(string ControlloStringa)
        {
            if (ControlloStringa == "")
            {
                throw new Exception("Questo campo è obbligatorio");
            } else
            {
                Console.WriteLine("Campo inserito correttamente \n");
            } return ControlloStringa;
        }
        //metodo per controllare i parametri int 
        public int ControlloParametriInt(int ControlloInt)
        {
            if (ControlloInt == 0 || ControlloInt < 1)
            {
                throw new Exception("Questo campo è obbligatorio");
            }
            else
            {
                Console.WriteLine("Campo inserito correttamente \n");
            }
            return ControlloInt;
        }
        
    }
}
