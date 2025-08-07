using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC
{
    public class SharedUtilities
    {
        static string projectDir = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;

        public static string[] LoadData(string dayPath) 
        {
            string inputFile = Path.Combine(projectDir, "data", dayPath);
            string[] lines = File.ReadAllLines(inputFile);

            return lines;

        }
    }
}
