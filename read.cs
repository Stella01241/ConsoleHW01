using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Class1
    {
        public static void ReadFile(string path)
        {
            if (!File.Exists(path))  //判斷檔案是否存在，如果不存在則結束程式
            {
                Console.WriteLine("找不到檔案");
                return;
            }

            Console.Write("是否繼續 ? (Y/N):");
            string yes = Console.ReadLine().ToLower(); //將使用者輸入轉乘小寫


            if (yes == "yes" || yes == "y")  
            {
                
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();  //開始計時

                string readFile = File.ReadAllText(path);  //讀取檔案裡的文字

                
                Console.WriteLine(readFile);
                stopWatch.Stop(); //結束計時

                TimeSpan ts = stopWatch.Elapsed;
                Console.WriteLine($"檔案讀取完成,共使用{ts.TotalMilliseconds}毫秒");


            }
            else
            {
                return;
            }
            

            
        }

        public static void MoveFile(string fromPath, string toPaht)
        {

        }

    }
}
