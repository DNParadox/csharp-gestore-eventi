

Evento eve = new Evento("Conferenza", 50, 150, 70);
Console.WriteLine("-------------------------");
Console.WriteLine("Benvenuto nel Terminale");
Console.WriteLine("-------------------------");


bool menu = true;
while(menu)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine("Benvenuto nel Terminale");
    Console.WriteLine("-------------------------");

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
   



