namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("To do list");
            Console.WriteLine("Please choose from following options, for example type 1 and press enter to make a new note");
            Console.WriteLine("1. Make new note");
            Console.WriteLine("2. View notes");
            Console.WriteLine("3. Delete notes");
            Console.WriteLine("4. Exit");

            List<string> j4NoteList = new List<string>();

            while (true)
            {
                Console.Write("Please enter your choice: ");
                string j4UserInput = Console.ReadLine();

                if (j4UserInput == "1")
                {
                    Console.WriteLine("Please enter the note you would like to create: ");
                    string j4UserInputOption1 = Console.ReadLine();
                    j4NoteList.Add(j4UserInputOption1);
                }
                else if (j4UserInput == "2")
                {
                    if (j4NoteList.Count <= 0)
                    {
                        Console.WriteLine("No notes yet");
                    }
                    else
                    {
                        foreach (string note in j4NoteList)
                        {
                            Console.WriteLine($"{note}");
                        }
                    }
                }
                else if (j4UserInput == "3")
                {
                    foreach(string note in j4NoteList)
                    {
                        Console.WriteLine($"{j4NoteList.IndexOf(note)}, {note}");
                    }
                    if (j4NoteList.Count == 0)
                    {
                        Console.WriteLine("There are no notes");
                    }
                    else
                    {
                        Console.WriteLine("Delete entry by entering the number in the list, first one starts at 0");
                        Console.WriteLine("Which note would you like to delete: ");
                        try
                        {
                            string j4UserInputDelete = Console.ReadLine();
                            int j4Converter = Convert.ToInt32(j4UserInputDelete);
                            j4NoteList.Remove(j4NoteList[j4Converter]);
                        }
                        catch
                        {
                            Console.WriteLine("There was an error please ensure you enter the correct corresponding numbers");
                        }
                    }
                }
                else if (j4UserInput == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Something went wrong, please make sure you only enter 1,2,3 or 4");
                }
            }
        }
    }
}