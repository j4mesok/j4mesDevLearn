using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace logTest
{
    internal class Logger
    {
        public static void CreateLog(string text)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Log\Log.txt", true))
            {
                sw.WriteLine(DateTime.Now + " | " + text);
            }

        }
    }
}
