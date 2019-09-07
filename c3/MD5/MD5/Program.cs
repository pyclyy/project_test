using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;



namespace MD5a
{
    class Program
    {

  

        static void Main(string[] args)
        {
            string path = @"D:\work\2019-04-00\df.fbx";

            FileInfo fi = new FileInfo(path);
            FileStream fs =  fi.Open(FileMode.Open);

            MD5 m = MD5.Create();
            byte[]  b = m.ComputeHash(fs);
            string s = "";
            foreach (var i in b )
            {
                s += Convert.ToString(i);
            }

            Console.WriteLine(s);


    
            Console.ReadKey();
        }
    }
}
