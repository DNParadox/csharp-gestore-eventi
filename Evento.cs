// See https://aka.ms/new-console-template for more information


public class Evento
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
            _titolo = value;
        }
    }
    public DateTime Data
    {
        get
        {
            return _data;
        }
        set
        {
          _data = value;
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
            if (value < 0)
            {
                throw new Exception("Devi inserire un valore valido");
            }
           else
            {
                _NumeroPostiPrenotati = value;
            }
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
            if (CapienzaMassimaEvento > _NumeroPostiPrenotati)
            {
                Console.WriteLine("Attualmente Posti prenotati:{0} " , _NumeroPostiPrenotati);
                Console.WriteLine("Quanti posti vuoi prenotare?");
                int AggiungiPosto = Convert.ToInt32(Console.ReadLine());

                int NumeroPostiAggiornato = AggiungiPosto + _NumeroPostiPrenotati;

                if (NumeroPostiAggiornato > CapienzaMassimaEvento)
                {
                        Console.WriteLine("Non è stato possibile aggiungere posti ");
                }
                else
                {              
                    int PostiRimanenti = CapienzaMassimaEvento - NumeroPostiAggiornato;

                    Console.WriteLine("Ottimo hai riservato: {0} ", AggiungiPosto);
                    Console.WriteLine("Al momento ci sono :  {0}", NumeroPostiAggiornato);
                    Console.WriteLine("Rimangono soltanto: {0}", PostiRimanenti + " Fai presto ad accaparrarti gli ultimi");
                    _NumeroPostiPrenotati = NumeroPostiAggiornato;
                }
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
            if(_NumeroPostiPrenotati <= 0)
            {
                Console.WriteLine("Non puoi disdire ulteriori posti");
            }
            else
            {
                Console.WriteLine("Attualmente Posti prenotati:{0} ", _NumeroPostiPrenotati);

                Console.WriteLine("Quanti posti vuoi disdire?");

                int DiminuisciPosto = Convert.ToInt32(Console.ReadLine());
                int NumeroPostiAggiornato = _NumeroPostiPrenotati - DiminuisciPosto;
                int PostiRimanenti = CapienzaMassimaEvento - NumeroPostiAggiornato;

                if (NumeroPostiAggiornato <= -1)
                {
                    Console.WriteLine("Non è possibile Disderi ulteriori Posti");
                }
                else
                {
                    Console.WriteLine("Hai disdetto: {0} ", DiminuisciPosto);
                    Console.WriteLine("Rimangono gli ultimi: {0}", PostiRimanenti + " Posti disponibili");
                    Console.WriteLine("Al momento ci sono : {0}", NumeroPostiAggiornato + " Posti disponibili");

                    _NumeroPostiPrenotati = NumeroPostiAggiornato;
                }
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Qualcosa è andato storto");
        }
    }

    public override string ToString()
    {
        return Data.ToString("dd/MM/yyyy") + Titolo ;
    }



}