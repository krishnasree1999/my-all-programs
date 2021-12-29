using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace contactdetails
{
    class contacts
    {
        public void GetContactDetails()
        {
            FileStream fileStreamObj = new FileStream("D:\\Assignment\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStreamObj);
            string[] str1 = new string[72];
            string[] str2 = new string[72];
            int index = 0;
            int x = 0;
            int y = 6;
            int g = 12;
            while(sr.Peek()>0)
            {
                string readMyLine = sr.ReadLine();
                string[] strings = readMyLine.Split(':');
                if(strings.Length > 1)
                {
                    str1[index] = strings[0];
                    str2[index] = strings[1];
                    index++;
                }
            }
            for (int i=x; i<y; i++)
            {
                Console.Write(str1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            while (g>0)
            {
                for (int i=x; i<y; i++)
                {
                    Console.Write(str2[i] + " ");
                }
                x = x + 6;
                y = y + 6;
                Console.WriteLine();
                Console.WriteLine();
                g = g - 1;
            }
            sr.Close();
            fileStreamObj.Close();
        }
    }
}
