using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace run_bat_exe_have_wait
{
    class Program
    {
        static void    Main(string[] args)
        {
            string batpath = args[0];
            string batcom = args[1];

            //string batpath = @"E:\C\work\2019-07-00\贴图流程化测试\ling_tga_d.exe";
            //string batcom = @"E:\C\work\2019-07-00\贴图流程化测试\mesh_0638_tex_1054_0.tga";

            Program newp = new Program();
           string s =  newp.runexe(batpath, batcom);
            //Console.WriteLine(s );
            //Console.ReadKey();
            //return s; 

        }


        /// <summary>
        /// 利用c# 封装一下 bat 只要是有事件等待 
        /// </summary>
        /// <param name="batexepath"> 具体 bat exe 的位置u </param>
        /// <param name="batDom"> bat exe 后面传入的命令 </param>
        /// <returns></returns>
        public string runexe( string batexepath , string batDom  )
        {
            string bat = batexepath + "  " + batDom ;


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
            string output = process.StandardOutput.ReadToEnd();//读取进程的输出 
                                                               // Console.WriteLine(output+"sss");
            return (output + "1");
        }
    }
}
