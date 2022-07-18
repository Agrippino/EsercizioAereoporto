using EsercizioAeroporto;
//creo dei voli
Volo AndataMilano = new Volo("Milano",DateTime.Now,100, 20);
Volo AndataRitornoMilano = new Volo("Milano", DateTime.Now, "Napoli",DateTime.Now, 100, 50); ;

Volo AndataRoma = new Volo("Roma", DateTime.Now, 50,10);
Volo AndataRitornoRoma = new Volo("Roma", DateTime.Now, "Napoli", DateTime.Now, 100,20);

Volo AndataGenova = new Volo("Genova", DateTime.Now, 200,30);
Volo AndataRitornoGenova = new Volo("Roma", DateTime.Now, "Napoli", DateTime.Now, 100, 60);

//aggiungo voli alla lista per la sola andata 
List<Volo> ListaVoliSoloAndata = new List<Volo>();
ListaVoliSoloAndata.Add(AndataMilano);
ListaVoliSoloAndata.Add(AndataRoma);
ListaVoliSoloAndata.Add(AndataGenova);

//aggiungo voli alla lista per andata e ritorno 
List<Volo> ListaVoliAndataRitorno = new List<Volo>();
ListaVoliAndataRitorno.Add(AndataRitornoMilano);
ListaVoliAndataRitorno.Add(AndataRitornoRoma);
ListaVoliAndataRitorno.Add(AndataRitornoGenova);

//creo la lista per aggiungere i clienti 
List<Clienti> ClienteDaAggiungere = new List<Clienti>();
//istanzio l'oggetto cliente 
Clienti Cliente = new Clienti();
//Istanzio l'oggetto movimentazioni 
Movimentazioni movimentazioni = new Movimentazioni();
Volo voloProva = new Volo();


//inizio richiesta voli
Console.WriteLine("Benvenuto nell'aereoporto di Napoli Btinkeeng di Napoli");
bool TipoViaggio = false;
while(TipoViaggio == false)
{
    Console.WriteLine("Vuole prenotare un volo solo andata ?");
    Console.WriteLine("Premere 0 per volo solo andata");
    Console.WriteLine("Premere 1 per volo andata e ritorno");
    int SceltaTipoViaggio = int.Parse(Console.ReadLine());
    //scelta del tipo di viaggio 
    switch (SceltaTipoViaggio)
    {

        case 0:
            TipoViaggio = true;
            Console.WriteLine("Ha scelto volo solo andata");
            Console.WriteLine("Abbiamo i seguenti voli disponibili");
            foreach (Volo volo in ListaVoliSoloAndata)
            {
                StampaVoliAndata(volo);
            }
            Console.WriteLine("Quale volo vuoi prenotare? \n");
            Console.WriteLine("Digita 0 per Milano, 1 per Roma, 2 per Genova");
            int SceltaVoloAndata = int.Parse(Console.ReadLine());
            PrenotazioneVoloAndata(SceltaVoloAndata);



            break;

        case 1:
            TipoViaggio = true;
            Console.WriteLine("Ha scelto volo andata e ritorno");
            Console.WriteLine("Abbiamo i seguenti voli disponibili");
            foreach (Volo volo in ListaVoliSoloAndata)
            {
                StampaVoliAndata(volo);
            }
            Console.WriteLine("Quale volo vuoi prenotare? \n");
            Console.WriteLine("Digita 0 per Milano, 1 per Roma, 2 per Genova");
            int SceltaVoloAndataRitorno = int.Parse(Console.ReadLine());
            PrenotazioneVoloAndataRitorno(SceltaVoloAndataRitorno);
            break;
        default:
            Console.WriteLine("Per favore scegli una delle opzioni precedenti");
            TipoViaggio = false;
            break;
    }
}
//metodo per scelta viaggio sola andata
void PrenotazioneVoloAndata(int SceltaVoloAndata)
{
    bool RipetizioneVolo = false;
    while (RipetizioneVolo == false)
    {
        switch (SceltaVoloAndata)
        {
            case 0:
                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Milano");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaMilano = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaMilano);
                AndataMilano.SetDataPartenza(DataPartenzaMilano);
                bool ControlloBigliettiMilano = false;
                while (ControlloBigliettiMilano == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataMilano.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataMilano.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiMilano = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataMilano);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata! \n");


                break;
            case 1:

                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Roma");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaRoma = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaRoma);
                AndataRoma.SetDataPartenza(DataPartenzaRoma);
                bool ControlloBigliettiRoma = false;
                while (ControlloBigliettiRoma == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataRoma.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataRoma.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiRoma = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataRoma);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata!");

                break;
            case 2:

                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Genova");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaGenova = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaGenova);
                AndataGenova.SetDataPartenza(DataPartenzaGenova);
                bool ControlloBigliettiGenova = false;
                while (ControlloBigliettiGenova == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataGenova.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataGenova.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiGenova = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataGenova);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata!");

                break;
            default:
                Console.WriteLine("Per favore scegli una delle opzioni presenti");
                RipetizioneVolo = false;
                Console.WriteLine("Inserisci questo campo correttamente: ");
                Console.WriteLine("Digita 0 per Milano, 1 per Roma, 2 per Genova");
                SceltaVoloAndata = int.Parse(Console.ReadLine());
                PrenotazioneVoloAndata(SceltaVoloAndata);
                break;
        }
    }
}
//metodo per scelta viaggio andata e ritorno 
void PrenotazioneVoloAndataRitorno(int SceltaVoloAndataRitorno)
{
    bool RipetizioneVolo = false;
    while (RipetizioneVolo == false)
    {

        switch (SceltaVoloAndataRitorno)
        {
            case 0:
                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Milano");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaMilano = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaMilano);
                AndataRitornoMilano.SetDataPartenza(DataPartenzaMilano);
                Console.WriteLine("Qual è la data di ritorno?");
                DateTime DataRitornoMilano = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataRitornoMilano);
                AndataRitornoMilano.SetDataRitorno(DataRitornoMilano);
                bool ControlloBigliettiMilano = false;
                while (ControlloBigliettiMilano == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataRitornoMilano.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataRitornoMilano.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiMilano = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataRitornoMilano);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata!");

                break;

            case 1:
                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Roma");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaRoma = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaRoma);
                AndataRitornoRoma.SetDataPartenza(DataPartenzaRoma);
                Console.WriteLine("Qual è la data di ritorno?");
                DateTime DataRitornoRoma = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataRitornoRoma);
                AndataRitornoRoma.SetDataRitorno(DataRitornoRoma);
                bool ControlloBigliettiRoma = false;
                while (ControlloBigliettiRoma == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataRitornoRoma.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataRitornoRoma.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiRoma = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataMilano);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata!");

                break;
            case 2:
                RipetizioneVolo = true;
                Console.WriteLine("Hai Scelto Genova");
                Console.WriteLine("Qual è la data di partenza?");
                DateTime DataPartenzaGenova = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataPartenzaGenova);
                AndataRitornoGenova.SetDataPartenza(DataPartenzaGenova);
                Console.WriteLine("Qual è la data di ritorno?");
                DateTime DataRitornoGenova = DateTime.Parse(Console.ReadLine());
                RispostaControlloDateTime(DataRitornoGenova);
                AndataRitornoGenova.SetDataRitorno(DataRitornoGenova);
                bool ControlloBigliettiGenova = false;
                while (ControlloBigliettiGenova == false)
                {
                    try
                    {
                        Console.WriteLine("Per questo volo sono disponibili " + AndataRitornoGenova.GetBigliettiDisponibili() + " Biglietti");
                        Console.WriteLine("Quanti biglietti vuoi acquistare");
                        int BigliettiDaAcquistare = int.Parse(Console.ReadLine());
                        AndataRitornoGenova.SetBiglettiDaAcquistare(BigliettiDaAcquistare);
                        ControlloBigliettiGenova = true;
                    }
                    catch (Exception erroreData)
                    {
                        Console.WriteLine(erroreData.Message);
                    }
                }
                Console.WriteLine("Bene, ora inserisci i tuoi dati per completare l'acquisto!");
                DatiCliente();
                ClienteDaAggiungere.Add(Cliente);
                StampaDettagliVolo(AndataMilano);
                StampaAnagraficaCliente(ClienteDaAggiungere);
                Console.WriteLine("Grazie per l'acquisto, buona giornata!");

                break;
            default:
                Console.WriteLine("Per favore scegli una delle opzioni precedenti");
                RipetizioneVolo = false;
                Console.WriteLine("Inserisci questo campo correttamente: ");
                Console.WriteLine("Digita 0 per Milano, 1 per Roma, 2 per Genova");
                SceltaVoloAndataRitorno = int.Parse(Console.ReadLine());
                PrenotazioneVoloAndata(SceltaVoloAndataRitorno);
                break;
        }
    }
}

//metodo per chiedere i dati al cliente
void DatiCliente()
{
    //chiedo e setto il nome cliente
    Console.WriteLine("Nome: ");
    string Nome = Console.ReadLine();
    RispostaControlloString(Nome);
    Cliente.SetNome(Nome);
    //chiedo e setto il cognome cliente
    Console.WriteLine("Cognome: ");
    string Cognome = Console.ReadLine();
    RispostaControlloString(Cognome);
    Cliente.SetCognome(Cognome);
    //chiedo e setto l'età del cliente
    Console.WriteLine("Età : ");
    int Eta = int.Parse(Console.ReadLine());
    RispostaControlloInt(Eta);
    Cliente.SetEta(Eta);
    //chiedo e setto l'anno di nascita 
    bool ControlloData = false;
    while (ControlloData == false)
    {
        try
        {
            Console.WriteLine("Data di nascita: ");
            DateTime DataDiNascita = DateTime.Parse(Console.ReadLine());
            Cliente.SetDataNascita(DataDiNascita);
            ControlloData = true;
        }
        catch (Exception erroreData)
        {
            Console.WriteLine(erroreData.Message);
        }
    } 
    //chiedo e setto il luogo di nascita del cliente
    Console.WriteLine("Luogo di nascita: ");
    string LuogoNascita = Console.ReadLine();
    RispostaControlloString(LuogoNascita);
    Cliente.SetLuogoNascita(LuogoNascita);
    //chiedo e setto il Codice Fiscale
    bool ControlloCF = false;
    while (ControlloCF == false)
    {
        try
        {
            Console.WriteLine("Codice Fiscale : ");
            string CF = Console.ReadLine();
            Cliente.SetCodiceFiscale(CF);
            ControlloCF = true;
        }
        catch (Exception erroreData)
        {
            Console.WriteLine(erroreData.Message);
        }
    }
    //chiedo e setto la residenza cliente
    Console.WriteLine("Città di residenza : ");
    string CittaResidenza = Console.ReadLine();
    RispostaControlloString(CittaResidenza);
    Cliente.SetLuogoNascita(CittaResidenza);
    //chiedo e setto la provincia cliente
    Console.WriteLine("Provincia di  : ");
    string Provincia = Console.ReadLine();
    RispostaControlloString(Provincia);
    Cliente.SetProvincia(Provincia);
    //chiedo e setto l'indirizzo civico cliente
    Console.WriteLine("Indirizzo civico : ");
    string IndirizzoCivico = Console.ReadLine();
    RispostaControlloString(IndirizzoCivico);
    Cliente.SetIndirizzoCivico(IndirizzoCivico);
    //chiedo e setto il numero civico cliente  
    Console.WriteLine("Numero civico : ");
    int NumeroCivico = int.Parse(Console.ReadLine());
    RispostaControlloInt(NumeroCivico);
    Cliente.SetNumeroCivico(NumeroCivico);
    //chiedo e setto il l'email cliente
    Console.WriteLine("Email : ");
    string Email = Console.ReadLine();
    RispostaControlloString(Email);
    Cliente.SetEmail(Email);
    //chiedo e setto il numero di cellulare 
    bool ControlloCellulare = false;
    while (ControlloCellulare == false)
    {
        try
        {
            Console.WriteLine("Numero cellulare: ");
            string NumeroCellulare = Console.ReadLine();
            Cliente.SetNumeroCellulare(NumeroCellulare);
            ControlloCellulare = true;
        }
        catch (Exception erroreData)
        {
            Console.WriteLine(erroreData.Message);
        }
    }
    //chiedo e setto l'IBAN 
    bool ControlloIban = false;
    while (ControlloIban == false)
    {
        try
        {
            Console.WriteLine("IBAN : ");
            string NumeroIban = Console.ReadLine();
            Cliente.SetIBAN(NumeroIban);
            ControlloIban = true;
        }
        catch (Exception erroreData)
        {
            Console.WriteLine(erroreData.Message);
        }
    }
}
//metodo per stamapare tutti i voli 
void StampaVoliAndata(Volo volo)
{
    Console.WriteLine("Città di destinazione :" + volo.GetCittaArrivo());
}
//metodo per stampare i dettagli del viaggio 
void StampaDettagliVolo(Volo volo)
{
    Console.WriteLine("/-----Dettagli viaggio------/ \n");
    Console.WriteLine("Città di arrivo: " + volo.GetCittaArrivo());
    Console.WriteLine("Data di partenza : " + volo.GetDataPartenza().ToString("MM/dd/yyyy HH:mm"));
    Console.WriteLine("Città di ritorno : " + volo?.GetCittaRitorno());
    Console.WriteLine("Data di ritono: " + volo?.GetDataRitorno().ToString("MM/dd/yyyy HH:mm"));
    Console.WriteLine("Numero biglitti acquistati: " + volo.GetBigliettiDaAcquistare());
    Console.WriteLine("Costo Biglietto singolo : " + volo.GetCostoBiglietto() + " euro" );
    Console.WriteLine("Costo totale: " + movimentazioni.Acquista(volo.GetCostoBiglietto(),volo.GetBigliettiDaAcquistare()) + " euro" + "\n");
}
//metodo per stamapare l'anagrafica del cliente 
void StampaAnagraficaCliente(List<Clienti> anagraficaDeiClienti)
{
    Console.WriteLine("---Dati Cliente --- \n");
    Console.WriteLine("Nome = " + Cliente.GetNome());
    Console.WriteLine("Cognome = " + Cliente.GetCognome());
    Console.WriteLine("Età = " + Cliente.GetEta());
    Console.WriteLine("Data di nascita = " + Cliente.GetDataNascita());
    Console.WriteLine("Luogo di nascita = " + Cliente.GetLuogoNascita());
    Console.WriteLine("Codice Fiscale = " + Cliente.GetCodiceFiscale());
    Console.WriteLine("Città di residenza = " + Cliente.GetCittaResidenza());
    Console.WriteLine("Provincia di  = " + Cliente.GetProvincia());
    Console.WriteLine("Indirizzo civico = " + Cliente.GetIndirizzoCivico());
    Console.WriteLine("Numero civico = " + Cliente.GetNumeroCivico());
    Console.WriteLine("Email = " + Cliente.GetEmail());
    Console.WriteLine("Numero cellulare = " + Cliente.GetNumeroCellulare());
    Console.WriteLine("IBAN = " + Cliente.GetIBAN());
}
//metodo per controllare le stringhe
void RispostaControlloString(string RispostaControllo)
{
    bool ControlloRipetizione = false;
    while(ControlloRipetizione == false) 
    {
    
    try
    {
        Cliente.ControlloParametriStringa(RispostaControllo);

        ControlloRipetizione = true;

    } 
    catch (Exception ErroreStringa)
    {
        Console.WriteLine(ErroreStringa.Message);
        ControlloRipetizione = false;
        Console.WriteLine("Inserisci questo campo correttamente: ");
        RispostaControllo = Console.ReadLine();
        RispostaControlloString(RispostaControllo);
        ControlloRipetizione=true;
    }
    }
}
//metodo per controllare gli int 
void RispostaControlloInt(int ControlloInt)
{
    bool ControlloRipetizione = false;
    while (ControlloRipetizione == false)
    {

        try
        {
            Cliente.ControlloParametriInt(ControlloInt);

            ControlloRipetizione = true;

        }
        catch (Exception ErroreStringa)
        {
            Console.WriteLine(ErroreStringa.Message);
            ControlloRipetizione = false;
            Console.WriteLine("Inserisci questo campo correttamente: ");
            ControlloInt = int.Parse(Console.ReadLine());
            RispostaControlloInt(ControlloInt);
            ControlloRipetizione = true;
        }
    }

}
//metodo per contrllare i DateTime 
void RispostaControlloDateTime(DateTime ControlloDateTime)
{
    bool ControlloRipetizione = false;
    while (ControlloRipetizione == false)
    {

        try
        {
            voloProva.ControlloParametriDateTime(ControlloDateTime);

            ControlloRipetizione = true;

        }
        catch (Exception ErroreStringa)
        {
            Console.WriteLine(ErroreStringa.Message);
            ControlloRipetizione = false;
            Console.WriteLine("Inserisci questo campo correttamente: ");
            ControlloDateTime = DateTime.Parse(Console.ReadLine());
            RispostaControlloDateTime(ControlloDateTime);
            ControlloRipetizione = true;
        }
    }
}