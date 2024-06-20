using ConsoleApp1;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Note> note = new List<Note>();

            Console.WriteLine("To do list");
            Console.WriteLine("Please choose from following options, for example type 1 and press enter to make a new note");
            Console.WriteLine("1. Make new note");
            Console.WriteLine("2. View notes");
            Console.WriteLine("3. Delete notes");
            Console.WriteLine("4. Exit");

            while (true)
            {
                Console.Write("Please enter your choice: ");
                string j4UserInput = Console.ReadLine();

                if (j4UserInput == "1")
                {
                    AddNote(note);
                }
                else if (j4UserInput == "2")
                {
                    if (note.Count <= 0)
                    {
                        Console.WriteLine("No notes yet");
                    }
                    else
                    {
                        foreach (Note a in note)
                        {
                            Console.WriteLine($"{a.NoteName}");
                        }
                    }
                }
                else if (j4UserInput == "3")
                {
                    foreach(var n in note)
                    {
                        Console.WriteLine($"{note.IndexOf(n)}, {note}");
                    }
                    if (note.Count == 0)
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
                            note.Remove(note[j4Converter]);
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

        private static void AddNote(List<Note> note)
        {

            Console.WriteLine("Please enter a name for the note: ");
            string namenote = Console.ReadLine();

            Console.WriteLine("Please enter the note you would like to create: ");
            string notecontent = Console.ReadLine();
            note.Add(new Note { NoteContent = notecontent, NoteName = namenote });

        }
    }
}