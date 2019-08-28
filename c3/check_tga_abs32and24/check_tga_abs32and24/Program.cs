using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeImageAPI.Plugins;
using FreeImageAPI.IO;
using FreeImageAPI;

/// <summary>
/// 这里主要提供图片查询是图片格式tga 是32还是24 注意如果图片的a通道全是白色就是a通道没有 
/// </summary>
namespace check_tga_abs32and24
{
    class Program
    {
        static void Main(string[] args)
        {
            string pa = @"E:\C\work\2019-08-00\bug\textpacker\tex_1717_2@m.tga";
            image_a_abs_32_24 obj = new image_a_abs_32_24(pa);
            int a =  obj.is3224();
            Console.WriteLine(a );
            Console.ReadKey();
        }
    }
}
