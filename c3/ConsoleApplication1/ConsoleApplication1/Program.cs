using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeImageAPI;
using FreeImageAPI.IO;
using FreeImageAPI.Plugins;
using System.IO;
using System.Drawing;




namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           ///. string path = (@"E:\C\work\2019-07-00\贴图流程化测试\2 (2).tga");
            string path = args[0];

            FreeImageBitmap ne = new FreeImageBitmap(path, FREE_IMAGE_FORMAT.FIF_TARGA);
            Size b = ne.Size;
            int image_h = b.Height;
            int image_w = b.Width;
            // FreeImageBitmap new_tem = new FreeImageBitmap(image_w, image_h);
            Bitmap new_tem = new Bitmap(image_w, image_h);

            Color tt = ne.GetPixel(0, 0); /// 优先获得高度 在高度上去处理 宽度 
            Console.WriteLine(image_w);
            

            Bitmap ne_type = (Bitmap) ne.ToBitmap();
            ne.Dispose();

            for (int i =0;  i<image_h; i++)
            {
                for (int j =0;j<image_w; j++ )
                {
                    //Color t = ne.GetPixel(i, j); /// 优先获得高度 在高度上去处理 宽度 
                    Color t = ne_type.GetPixel(i, j);  
                                        
                    Program pro = new Program();
                    Color  srgbcolor  =  pro.linetosrgb(t);
                    new_tem.SetPixel(i, j, srgbcolor);
                    
                }
            }

            ///对图形处理完成   
            ///
            FreeImageBitmap yy = new FreeImageBitmap(new_tem);
            yy.Save(path);

        }

        
        /// <summary>
        ///实现对rgb  线性空间转 srgb 空间 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public  Color   linetosrgb  (Color i )
        {
            int r =     Math.Max (   (Convert.ToInt32((1.055 * Math.Pow( (i.R/255.0),(0.416666667))-0.055 )*255 ) )   , 0 ) ; 
            int g =  Math.Max( (Convert.ToInt32((1.055 * Math.Pow((i.G / 255.0), (0.416666667)) - 0.055) * 255)) , 0);
            int b = Math.Max(Convert.ToInt32((1.055 * Math.Pow((i.B / 255.0), (0.416666667)) - 0.055) * 255), 0);
            ///线性转srgb a不错处理保存线性状态  
            ///
            int a = Convert.ToInt32(i.A);
            return Color.FromArgb(a, r, g, b);

        }


    }
}
