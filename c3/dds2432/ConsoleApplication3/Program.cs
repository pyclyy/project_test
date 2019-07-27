using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;




namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read the file into <bits>
            // string path = "E:\\C\\work\\2019-07-00\\python_rip\\6.rip" ;
            string files = @"E:\C\game_jie\_NinjaRipper\cao\_NinjaRipper\2019.07.18_12.26.32_Three_Kingdoms.exe_13128\test\Mesh_0211_Tex_0530_0.dds";
            string oust = @"E:\C\game_jie\_NinjaRipper\cao\_NinjaRipper\2019.07.18_12.26.32_Three_Kingdoms.exe_13128\test";


            Program ib = new Program();
            int c  = ib.dds_to_tga(files , oust);
            Console.WriteLine(c ); 
            //string[] c  = ib.GetRipdds(path);
            //foreach (string i in c )
            //{
            //    Console.WriteLine(i);
            //}



            Console.ReadLine();
        }
        public  string[]   GetRipdds (string  pathname )
        {
            List<string> tem = new List<string>();
            var fs = new FileStream(pathname, FileMode.Open);
            var len = (int)fs.Length;
            var bits = new byte[len];
            fs.Read(bits, 0, len);
            var pattern = @"Tex_[0-9_]+\.dds";
            foreach (Match match in Regex.Matches(Encoding.ASCII.GetString(bits), pattern))
            {
                tem.Add(match.Value.ToString());
            }
            fs.Close();
            fs.Dispose(); 

            return tem.ToArray(); 
        }


        /// <summary>
        /// / 该方法是通过传入的dss 来判断是 24 32 位 如果是0 就错的  
        /// 利用 显卡格式转换 
        /// </summary>
        /// <param name="files">原始文件dds文件要求不能有中文路径</param>
        /// <param name="oust">转换后文件路径 </param>
        /// <returns></returns>
        public  int  dds_to_tga  (string files , string oust)
        {
            string[] dds24_32 = { "R8G8B8" , "A8R8G8B8"  }; 
            int[] dds = {24 , 32 , 0  }; 
            string exe = @"texconv.exe";

            string bat = (exe + " -ft TGA  -w 20 -h 20  " +  files + "  -o  " + oust);

            Process process = new Process();//创建进程对象  
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";//设定需要执行的命令  
            startInfo.Arguments = "/C " + bat;//“/C”表示执行完命令后马上退出  
            startInfo.UseShellExecute = false;//不使用系统外壳程序启动 
            startInfo.RedirectStandardInput = false;//不重定向输入  
            startInfo.RedirectStandardOutput = true; //重定向输出  
            startInfo.CreateNoWindow = true;//不创建窗口  
            process.StartInfo = startInfo;
            process.Start();
           string  output = process.StandardOutput.ReadToEnd();//读取进程的输出 
            string[] c = output.Split(new char[] {' ' });
            int ai =  0 ; 
           foreach  (var i in c )
            {
                if (i == dds24_32[0])
                {
                    ai =  dds[0];
                    break; 
                } else if  ( i == dds24_32[1])
                {
                    ai =  dds[1];
                    break; 
                }else
                {
                    ai =  dds[2]; 
                }

            }
            return ai; 

        } 




    }
}
