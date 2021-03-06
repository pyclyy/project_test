﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
namespace whydds2432
{
    public class whydds2432
    {
        /// <summary>
        /// / 该方法是通过传入的dss 来判断是 24 32 位 如果是0 就错的  
        /// 利用 显卡格式转换 
        /// </summary>
        /// <param name="files">原始文件dds文件要求不能有中文路径</param>
        /// <param name="oust">转换后文件路径 </param>
        /// <returns></returns>
        public int dds_to_tga(string files, string oust)
        {
            string[] dds24_32 = { "R8G8B8", "A8R8G8B8" };
            int[] dds = { 24, 32, 0 };

            string exe =  @"texconv.exe";

            string bat = (exe + " -ft TGA  -w 20 -h 20  " + files + "  -o  " + oust);

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
            string[] c = output.Split(new char[] { ' ' });
            int ai = 0;
            foreach (var i in c)
            {
                if (i == dds24_32[0])
                {
                    ai = dds[0];
                    break;
                }
                else if (i == dds24_32[1])
                {
                    ai = dds[1];
                    break;
                }
                else
                {
                    ai = dds[2];
                }

            }
            return (ai);

        }
        public void runexe(int d2432, string absmappath)
        {

            string d24 =  "ddstotga3.exe";
            string d32 =  "ddstotga4.exe";
            string bat = "";
            if (d2432 == 24)
            {
                bat += d24 + "  " + absmappath;

            }
            else if (d2432 == 32)
            {
                bat += d32 + "  " + absmappath;

            }

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
        }
        public void ddsmaptotgamap (string  ddsmappath , string toolpath  )
        {
            string newdds = (toolpath + "\\tem.dds");
            File.Copy(ddsmappath, newdds, true);

            string ou = Path.GetDirectoryName(newdds);
            int why34 = dds_to_tga(newdds, ou);
            //Console.WriteLine("sss" + ddsmappath);
            runexe(why34, ddsmappath);

        }




    }



}
