using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("----啟動程式----");
            }

            string method = args[0];//參數1
            string path = args[1]; //參數2
            

            //ReadFile時用這個↓↓↓
            if(method.ToLower() == "readfile")
            {
                Class1.ReadFile(path);
            }
            //ReadFile時用這個↑↑↑



            if(method.ToLower() == "movefile")
            {
                string path2 = args[2];
                Class1.MoveFile(path, path2);
            }

            if (method.ToLower() == "copyfile")
            {
                string path2 = args[2];
                Class1.copy(path, path2);
            }

            if(method.ToLower()=="deletefile")
            {
                Class1.deletefile(args);
            }

            if(method.ToLower() == "createfolder")
            {
                Class1.createfolder(path);
            }

            if (method.ToLower() == "deletefolder")
            {
                Class1.createfolder(path);
            }




            Console.WriteLine("----程式結束----");


            Console.ReadLine();
        }

        
        
    }
}
