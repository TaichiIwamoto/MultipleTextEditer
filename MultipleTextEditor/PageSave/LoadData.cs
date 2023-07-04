using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTextEditor.PageSave
{
    internal class LoadData
    {
        public Dictionary<int, string> LoadPage(string path)
        {
            Dictionary<int, string> lp = new Dictionary<int, string>();

            StreamReader sr = new StreamReader(path + "/PageData.txt");

            while (sr.Peek() != -1)
            {
                String line = sr.ReadLine();
                string[] tmp = line.Split(' ');
                lp.Add((int.Parse(tmp[0])), tmp[1]);               
            }
/*            foreach (var entry in lp)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }*/
            sr.Close();
            return lp;

        }
    }
}
