using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class MessagePrinter
    {
        // Delegate void để in ra message
        public delegate void MessageDelegate(string message);

        // Phương thức in ra message
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
