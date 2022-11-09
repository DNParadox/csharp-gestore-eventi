// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

public  class Evento
{
    //Variabili
    public string Titolo
    {
        get
        {
            return Titolo;
        }
            
        protected set
        {
            
        }
    }
    private int Data
    {
        get
        {
            return Data;
        }
        set
        {

        }
    }
    public int CapienzaMassimaEvento { get; private set; }
    public int NumeroPostiPrenotati { get; private set; }

  

    // Costruttore 
    public Evento(string titolo, int data, int capienzaMassimaEvento, int numeroPostiPrenotati)
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
            if (CapienzaMassimaEvento != NumeroPostiPrenotati)
            {
                Console.WriteLine("Quanti posti vuoi prenotare?");

                Console.WriteLine("Attualmente Posti prenotati:{0} " , NumeroPostiPrenotati);

                int AggiungiPosto = Convert.ToInt32(Console.ReadLine());

                int NumeroPostiAggiornato = AggiungiPosto + NumeroPostiPrenotati;

                Console.WriteLine("Ottimo hai riservato: " + AggiungiPosto);
                Console.WriteLine("Al momento ci sono :" + NumeroPostiAggiornato);

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


    public void DisdiciPosti()
    {
        try
        {
            if (CapienzaMassimaEvento != NumeroPostiPrenotati)
            {
                Console.WriteLine("Attualmente Posti prenotati:{0} " + NumeroPostiPrenotati);

                Console.WriteLine("Quanti posti vuoi prenotare?");

                int DiminuisciPosto = Convert.ToInt32(Console.ReadLine());

                int NumeroPostiAggiornato = NumeroPostiPrenotati - DiminuisciPosto;

                Console.WriteLine("Ottimo hai riservato: " + DiminuisciPosto);
                Console.WriteLine("Al momento ci sono : {0}" , NumeroPostiAggiornato);

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
        return Data.ToString("dd/MM/yyyy");
    }



}