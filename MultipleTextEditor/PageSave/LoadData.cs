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

            int count = 2;
            string line = sr.ReadLine();
            while (sr.Peek() != -1)
            {
                string[] tmp = line.Split(' ');
                
                string tmpLine = tmp[1];
                while (!tmpLine.Contains("\n"))
                {
                    tmpLine = sr.ReadLine();
                    string nextNum = tmpLine.Substring(0, 1);
                    if (nextNum.Equals(count.ToString()))
                    {
                        Console.WriteLine("exit");
                        count += 1;
                        line = tmpLine;
                        break;
                    }
                    else
                    {
                        tmp[1] += "\n"+tmpLine;
                        Console.WriteLine(tmp[1]);
                    }
                }
                lp.Add((int.Parse(tmp[0])), tmp[1]);

            }
            sr.Close();
            return lp;

        }
    }
}
