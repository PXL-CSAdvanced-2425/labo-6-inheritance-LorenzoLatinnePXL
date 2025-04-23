using Microsoft.Data.SqlClient;

namespace ClassLib
{
    public class Log
    {
        private Dictionary<DateTime, string> _log = new Dictionary<DateTime, string>();
        private string _fileName;

        public Log(string fileName)
        {
            _fileName = fileName;
        }

        public Log(SqlConnection conn)
        {
            _fileName = conn.ConnectionString;
        }

        public virtual void Write(string message)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{DateTime.Now} - {message}");
                }
            }
            _log.Add(DateTime.Now, message);
        }

        public void DisplayLog()
        {
            foreach (KeyValuePair<DateTime, string> kvp in _log)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
