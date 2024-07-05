using logTest;
using System.ComponentModel.Design;

Console.Write("What is your name: ");
string name = Console.ReadLine();

void Menu()
{
    try
    {
        switch (name.Trim().ToLower())
        {
            case "one":
                GoodName.Name();
                Logger.CreateLog("the name one was logged, they have a great name");
                break;
            default:
                BadName.BName();
                Logger.CreateLog("the name wasn't one, they don't have a great name");
                break;
        }
    }
    catch
    {
        Console.WriteLine("sorry something went wrong maybe you didn't enter a name");
    }

}

Menu();