// See https://aka.ms/new-console-template for more information


public  class Evento
{
    private string _titolo;
    private DateTime _data;
    private int _NumeroPostiPrenotati;


    //Variabili
    public string Titolo
    {
        get
        {
            return _titolo;
        }
            
        set
        {
            
        }
    }
    private DateTime Data
    {
        get
        {
            return _data;
        }
        set
        {
          
        }
    }
    public int CapienzaMassimaEvento { get; private set; }
    public int NumeroPostiPrenotati
    {
        get
        {
            return _NumeroPostiPrenotati;
        }

        private set
        {

        }
    }

  
  

    // Costruttore 
    public Evento(string titolo, DateTime data, int capienzaMassimaEvento, int numeroPostiPrenotati)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMassimaEvento = capienzaMassimaEvento;
        NumeroPostiPrenotati = numeroPostiPrenotati;


    }


    public void PrenotaPosti()
    {
        try
        {
            if (CapienzaMassimaEvento > NumeroPostiPrenotati)
            {
               

                Console.WriteLine("Attualmente Posti prenotati:{0} " , NumeroPostiPrenotati);

          
                    Console.WriteLine("Quanti posti vuoi prenotare?");

                    int AggiungiPosto = Convert.ToInt32(Console.ReadLine());

                    int NumeroPostiAggiornato = AggiungiPosto + NumeroPostiPrenotati;
                    int PostiRimanenti = CapienzaMassimaEvento - NumeroPostiAggiornato;

                    Console.WriteLine("Ottimo hai riservato: {0} ", AggiungiPosto);
                    Console.WriteLine("Al momento ci sono :  {0}", NumeroPostiAggiornato);
                    Console.WriteLine("Rimangono soltanto: {0}", PostiRimanenti + " Fai presto ad accaparrarti gli ultimi");
                    NumeroPostiPrenotati = NumeroPostiAggiornato;
           
                 
            }
            else
            {
                Console.WriteLine("Al momento non ci sono posti disponibili, riprova al prossimo Evento");
            }
        }
        catch(FormatException e)
        {
            Console.WriteLine("Qualcosa è andato storto");
        }
    }


    public void DisdiciPosti()
    {
        try
        {
            if (NumeroPostiPrenotati <=  CapienzaMassimaEvento )
            {
                Console.WriteLine("Attualmente Posti prenotati:{0} " , NumeroPostiPrenotati);

                Console.WriteLine("Quanti posti vuoi disdire?");

                int DiminuisciPosto = Convert.ToInt32(Console.ReadLine());

                int NumeroPostiAggiornato = NumeroPostiPrenotati - DiminuisciPosto;
                int PostiRimanenti = CapienzaMassimaEvento - NumeroPostiAggiornato;

                Console.WriteLine("Hai disdetto: {0} ", DiminuisciPosto);
                Console.WriteLine("Rimangono gli ultimi: {0}", PostiRimanenti + " Posti disponibili");
                Console.WriteLine("Al momento ci sono : {0}", NumeroPostiAggiornato + " Posti disponibili");

                NumeroPostiPrenotati = NumeroPostiAggiornato;

            }
            else
            {
                Console.WriteLine("Al momento non ci sono posti disponibili, riprova al prossimo Evento");
            }
        }
        catch
        {

        }
    }

    public override string ToString()
    {
        return this.Data.ToString("dd/MM/yyyy");
    }



}