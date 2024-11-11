using System.Diagnostics;
using System.Runtime.CompilerServices;
//En klass som håller ihop alla metoder som gäller ämnet matematik
public class Mathematics
{
    public List<int> Factors {get; set;}

    public Mathematics()
    {
        Factors = new List<int>();        
    }

    public void NewMultiplicationTable()
    {
        Factors.Clear();
        for(int i = 1; i <= 10; i++)
        {
            Factors.Add(i);
        }
    }

    public void PracticeMultiplication()
    {
        System.Console.Write("Ange talet för den multiplikationstabell som vill öva på: ");
        if(int.TryParse(Console.ReadLine(), out int chosenTable))
        {
            NewMultiplicationTable();

            Random rnd = new Random();

            while(Factors.Count > 0)
            {
                int rndIndex = rnd.Next(Factors.Count);
                int factor = Factors[rndIndex];
                int product = factor * chosenTable;

                System.Console.Write($"Vad är {chosenTable} * {factor}? ");

                if(int.TryParse(Console.ReadLine(), out int userAnswer))
                {
                    if(userAnswer == product)
                    {
                        System.Console.WriteLine("Rätt svar. Bra jobbat!");
                        Factors.RemoveAt(rndIndex);
                        System.Console.WriteLine();
                    }
                    else
                    {
                        System.Console.WriteLine($"Ditt svar var tyvärr fel. Rätt svar är: {product} ");
                    }
                }
                else
                {
                    System.Console.WriteLine("Ogiltig inmatning. Skriv in ett heltal.");
                }
            }
            
            System.Console.WriteLine("Inga fler svar att beräkna. Bra jobbat!");

        }
        else
        {
            System.Console.WriteLine("Ogiltig inmatning. Skriv in ett heltal.");;
        }
    }
    
    public void MultiplicationGame()
    {
        List<int> wrongAnswers = new List<int>();
       
        System.Console.WriteLine("Välkommen till multiplikationsspelet!");
        System.Console.WriteLine("Här får du svara på 10 olika tal på tid");
        System.Console.WriteLine("Tiden startar när du får det första talet.");
        System.Console.WriteLine("När du svarat på alla tal får du den totala tiden.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine("------Klicka på enter för att börja spelet---------");
        System.Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();       

        
        Random rnd = new Random();
        Stopwatch totalStopwatch = Stopwatch.StartNew();     

       for(int i = 0; i < 10; i ++)
       {
            int factor1 = rnd.Next(1, 12);
            int factor2 = rnd.Next(1, 12);
            int product = factor1 * factor2;

            System.Console.Write($"Vad är {factor1} * {factor2}? ");
            if(int.TryParse(Console.ReadLine(), out int userAnswer))
            {
                if(userAnswer == product)
                {
                    System.Console.WriteLine("Rätt svar!");
                    System.Console.WriteLine();
                }
                else
                {
                    System.Console.WriteLine("Ditt svar var tyvärr fel");
                    System.Console.WriteLine();
                    wrongAnswers.Add(userAnswer);
                }                
            }
            else
            {
                System.Console.WriteLine("Felaktig inmatning. Ange ditt svar som ett heltal");
            }
       }
       totalStopwatch.Stop();
       System.Console.WriteLine($"Inga fler tal. Din totala tid blev: {totalStopwatch.Elapsed.TotalSeconds} sekunder.");
       System.Console.WriteLine($"Du svarade fel på {wrongAnswers.Count} frågor");
       System.Console.WriteLine("Kan du göra det bättre nästa gång?");
    }       
}


       
       