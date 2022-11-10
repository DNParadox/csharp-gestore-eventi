//Evento eve = new Evento("Conferenza", Convert.ToDateTime("26/05/1996"), 100, 30);
public class ProgrammaEventi
{
    // Var
    string Titolo { get; set; }
    protected List <Evento> eventi { get; set; }

    //Costruttore
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        eventi = new List<Evento>();
    }
    public string StampaEventiLista(List<Evento> EventoStampa)
    {
        string EventoStampato = "";
        foreach (Evento evento in EventoStampa)
        {
            EventoStampato += evento.ToString();
        }

        return EventoStampato;
    }

    public string StampaTuttiEventi()
    {
        string EventoStampato = Titolo;
        string Eventi = StampaEventiLista(eventi);

        return  EventoStampato + Eventi;
    }

    public void AggiungiEvento(Evento evento)
    {
        eventi.Add(evento);
    }

    public void RimuoviTuttiGliEventi()
    {
        eventi.Clear();
    }

    public List<Evento> CercaEventoConData(DateTime date)
    {
        List<Evento> eventidelgiorno = new List<Evento>();

        foreach (Evento evento in eventi)
        {
            if (evento.Data.CompareTo(date) == 0)
            {
                eventidelgiorno.Add(evento);
            }
        }

        return eventidelgiorno;
    }

}