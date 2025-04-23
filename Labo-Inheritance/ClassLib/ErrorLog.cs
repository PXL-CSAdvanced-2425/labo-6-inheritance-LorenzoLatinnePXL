using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class ErrorLog : Log
    {
        public ErrorLog(string fileName) : base(fileName)
        {

        }

        public override void Write(string message)
        {
            message = $"ERROR: {message}";
            Console.WriteLine(message);
            base.Write(message);
        }
    }
}
