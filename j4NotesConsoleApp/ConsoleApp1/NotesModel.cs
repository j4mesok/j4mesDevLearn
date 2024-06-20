using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Notes 
    {
        List<Note> Note = new List<Note>();
    }

    public class Note 
    { 
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
    }

    
}
