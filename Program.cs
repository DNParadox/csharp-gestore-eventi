//Evento eve = new Evento("Conferenza", Convert.ToDateTime("26/05/1996"), 100, 30);
using System;
// Logica Terminale 
Console.WriteLine("Inserisci titolo dell'Evento");
string titolo = Console.ReadLine();
Console.WriteLine("Inserisci la data nel formato dd/MM/yyyy");
string data = Console.ReadLine();
Console.WriteLine("Quant'è la capienza massima dell'evento?");
int capienzaMassimaEvento = Convert.ToInt32(Console.ReadLine());
int numeroPostiPrenotati = 0;

Evento eve = new Evento(titolo, Convert.ToDateTime(data), capienzaMassimaEvento, numeroPostiPrenotati);
ProgrammaEventi programmaEventi = RegistrazioneProgrammazioneEvento();


bool menu = true;
    while (menu)
    {
    try
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Benvenuto nel Terminale");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("1 - Prenota Posti");
        Console.WriteLine("2 - Disdici Posti");
        int selected = Convert.ToInt32(Console.ReadLine());

        switch (selected)
        {
            case 1:
                eve.PrenotaPosti();

                break;
            case 2:
                eve.DisdiciPosti();

                break;
        }
    }
    catch(Exception e)
    {
        Console.WriteLine("Devi inserire un numero!");
    }


    }
     

ProgrammaEventi RegistrazioneProgrammazioneEvento()
{
    Console.WriteLine("Inserisci il nome del programma");
    string titolo = Console.ReadLine();

    ProgrammaEventi programmaEventi = new ProgrammaEventi(titolo);
    return programmaEventi;
}