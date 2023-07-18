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
            try
            {
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
                        try
                        {
                            nextNum = tmpLine.Substring(0, 1);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            nextNum = (count + 1).ToString();
                        }
                    }
                    else
                    {
                        tmp = line.Split(' ');
                        tmpLine = sr.ReadLine();
                        try
                        {
                            nextNum = tmpLine.Substring(0, 1);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            nextNum = "-1";
                        }
                    }
                    if (nextNum.Equals(count.ToString()))//次のページを読み込む処理
                    {
                        lp.Add((int.Parse(tmp[0])), tmpString);
                        count += 1;
                        line = tmpLine;
                        tmpString = "";
                        notNext = false;
                        continue;
                    }
                    else if (!tmpLine.Equals(" "))//
                    {
                        tmpString += $"\n{tmpLine}";
                        Console.WriteLine("tmpString = " + tmpString);
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
            catch (DirectoryNotFoundException)
            {

                lp.Add(1, "#データが存在しませんでした.");
                return lp;
            }
            catch (FileNotFoundException)
            {
                File.Create(path + "/PageData.txt").Close();
                lp.Add(1, "#データが存在しませんでした.");
                return lp;
            }
        }

        public string[] LoadFont(string path)
        {
           
                StreamReader sr = new StreamReader(path + "/FontData.txt");
                string font = sr.ReadToEnd();
                Console.WriteLine("aa", font);
                sr.Close();
                string[] fontData = new string[5];
                string[] fontTmp = font.Split(',');
            try
            {
                fontData[0] = fontTmp[0].Replace("[Font: Name=", "");
                fontData[1] = fontTmp[1].Replace(" Size=", "");
                fontData[2] = fontTmp[2].Replace(" Units=", "");
                fontData[3] = fontTmp[3].Replace(" GdiCharSet=", "");
                fontData[4] = fontTmp[4].Replace(" GdiVerticalFont=", "").Replace("]", "");

                foreach (string str in fontData)
                {
                    Console.WriteLine(str);
                }
                return fontData;
            }catch (IndexOutOfRangeException){
                fontData[0] = "MS UI Gothic";
                fontData[1] = "9";
                return fontData;
            }
        }
    }
}
