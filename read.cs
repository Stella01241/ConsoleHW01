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
        //if(!File.Exists()) 

        public static void MoveFile(string fromPath, string toPaht)
        {
            if (File.Exists(fromPath) == false)
            {
                Console.WriteLine($"沒有此檔案{fromPath}");
                return;
            }
            Console.WriteLine($"是否將{fromPath}搬移至{toPaht}請輸入Y/N");
            string yes = Console.ReadLine().ToLower();

            if (File.Exists(toPaht)) 
            {
                Console.WriteLine("已存在相同檔案");
                return;
            }
            if(yes=="y"|| yes == "yes")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                File.Move(fromPath, toPaht);
                sw.Stop();
                Console.WriteLine($"檔案讀取完成,共使用{sw.Elapsed.TotalMilliseconds}毫秒");
            }
            else
            {
                return;
            }
                
        }

        public static void copy(string fromPath, string toPaht)
        {
            if (File.Exists(fromPath) == false)
            {
                Console.WriteLine($"沒有此檔案{fromPath}");
                return;
            }
            Console.WriteLine($"是否將{fromPath}複製至{toPaht}請輸入Y/N");
            string yes = Console.ReadLine().ToLower();

            if (File.Exists(toPaht))
            {
                Console.WriteLine("已存在相同檔案");
                return;
            }
            if (yes == "y" || yes == "yes")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                File.Copy(fromPath, toPaht);
                sw.Stop();
                Console.WriteLine($"檔案複製完成,共使用{sw.Elapsed.TotalMilliseconds}");
            }
            else
            {
                return;
            }

        }

        public static void deletefile(string[] fromPath)
        {

            for (int i=1;i < fromPath.Length;i++)
            {
                File.Delete(fromPath[i]);
            }


        }

        public static void createfolder(string fromPath)
        {
            
            Console.Write("是否繼續 ? (Y/N):");


            string yes = Console.ReadLine().ToLower(); //將使用者輸入轉乘小寫


            if (Directory.Exists(fromPath))
            {
                Console.WriteLine("已存在相同資料夾");
                return;
            }


           

            if (yes == "y" || yes == "yes")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Directory.CreateDirectory(fromPath);
                
                sw.Stop();
                Console.WriteLine($"創建資料夾完成,共使用{sw.Elapsed.TotalMilliseconds}");
            }
            else
            {
                return;
            }
        }
        public static void deletefolder(string fromPath)
        {
           
            
                foreach (string d in Directory.GetFileSystemEntries(fromPath))
                {
                    if (System.IO.File.Exists(d))
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        System.IO.File.Delete(d);//直接删除其中的文件   
                    }
                    else
                    deletefolder(d);//递归删除子文件夹   
                }
                Directory.Delete(fromPath);//删除已空文件夹   
            
        }
    }
}
