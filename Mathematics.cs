
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
}


       
       