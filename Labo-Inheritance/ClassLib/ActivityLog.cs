using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class ActivityLog : Log
    {
        public ActivityLog(string fileName) : base(fileName)
        {
            
        }

        public override void Write(string message)
        {
            message = $"ACTIVITY: {message}";
            base.Write(message);
        }
    }
}
