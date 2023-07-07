﻿using System;
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
            string tmpLine = "";
            string nextNum = "";
            string[] tmp = new string[1];
            string tmpString = "";
            string line = sr.ReadLine();
            bool notNext = false;
            while (sr.Peek() != -1)
            {
                if (notNext == false)
                {
                    tmp = line.Split(' ');
                    Console.WriteLine(tmp[1]);
                    tmpString += tmp[1];
                    tmpLine = sr.ReadLine();
                    nextNum = tmpLine.Substring(0, 1);
                }else{
                    tmp = line.Split(' ');
                    tmpLine = sr.ReadLine();
                    nextNum = tmpLine.Substring(0, 1);

                }

                    

                if (nextNum.Equals(count.ToString()))
                {
                    lp.Add((int.Parse(tmp[0])), tmpString);
                    count += 1;
                    line = tmpLine;
                    tmpString = "";
                    notNext = false;
                    continue;

                }
                else if (!tmpLine.Equals(" "))
                {
                    tmpString += $"\n{tmpLine}";
                    Console.WriteLine("tmpString = "+tmpString);
                    notNext = true;
                    continue;
                }
                else
                {
                    lp.Add((int.Parse(tmp[0])), tmp[1]);
                }
               
                
            }

            foreach (var entry in lp)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            sr.Close();
            return lp;

        }
    }
}
