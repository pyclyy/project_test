using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textpacker_to_dit
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 使用方法  首先实例化 然后制作数据 查询数据 首先需要判断 然后查新 调用  

            readplist newplist = new readplist(@"E:\C\work\2019-08-00\bug\textpacker\ceshi.plist");
            newplist.dependListarrayMakeUvValue(); //根据依赖制作uv数据 
            string tgamap = "tex_1430_1@n.tga";

            if (newplist.IsFind(tgamap))
            {
                plistcom_tomax ci = newplist.Find_UV(tgamap);

                Console.WriteLine(ci.uv_x_offset);
            }else
            {
                Console.WriteLine("贴图不在");
            }





            Console.ReadKey();
        }
    }
}
