using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Sweepstakes
{
    public class FileWriter
    {
        public void writeToFile(string path, string content)
        {
            File.AppendAllText(path, content);
        }
    }
}
