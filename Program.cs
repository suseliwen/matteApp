// See https://aka.ms/new-console-template for more information

Mathematics mathematics = new Mathematics();

System.Console.WriteLine("gör ett val:");
System.Console.WriteLine("1. Multiplikationstabellen på tid");
System.Console.WriteLine("2. Träna matte");
System.Console.WriteLine("3. Avsluta");
string input = Console.ReadLine();

switch(input)
{
    case "1":
    {
        System.Console.WriteLine("Multiplikationstabellen på tid");
        mathematics.MultiplicationGame();
        break;
    }
     case "2":
    {
        System.Console.WriteLine("Öva på matte");
        mathematics.PracticeMultiplication();
        break;
    }
    case "3":
    {
        System.Console.WriteLine("Avslutar programmet");
        break;
    }
    
}
