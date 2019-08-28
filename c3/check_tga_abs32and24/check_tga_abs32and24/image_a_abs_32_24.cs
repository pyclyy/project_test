using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeImageAPI.Plugins;
using FreeImageAPI.IO;
using FreeImageAPI;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO; 



namespace check_tga_abs32and24
{

    public enum  imagebit {abs32 , abs24 ,error0 };


    /// <summary>
    /// 判断图片是多少位 如果有a通道需要知道a通道不是纯白色
    /// 打开图片格式需要是 tag png bmp jpg gif tif dds psd pc上美术常用的的东西 
    /// </summary>
   public class image_a_abs_32_24
    {
        private string imagepath = "";

        private int ina = 10;
        private int bai = 255; 
        public  image_a_abs_32_24 (string imagepath)
        {
            this.imagepath = imagepath; 
        }  

        /// <summary>
        /// 根据传入图片判读图片格式是什么格式  格式只是识别 rgb argb 
        //// 返回 0 文件路径不对 或者格式不对 
        //// 返回 24 32 说明通道企管科
        /// </summary>
        /// <returns></returns>
        public  int  is3224 ()
        {
            
            if (! File.Exists(this.imagepath))
            {
                ///路径不对也是按户籍0 
                return 0;
            } 

            FreeImageBitmap fb = new FreeImageBitmap(this.imagepath);

            Bitmap bim = fb.ToBitmap();
            fb.Dispose();
            ///这里只是处理美术用的2中格式 rgb argb  其他返回0  
            ///
            PixelFormat  imformat  = bim.PixelFormat; 
            if (imformat == PixelFormat.Format24bppRgb)
            {
                bim.Dispose();
                return 24; 
            }else if (imformat == PixelFormat.Format32bppArgb)
            {
                //// 这里还要判断是不是真的32位， 对于有一个a通道但是全是纯白的，这种情况就是假的a通道， 会当作24处理  
                /// 最后返回的还是 24 
                /// 
                int wdith = bim.Width;
                int height = bim.Height;
                for  (int i=0;i <height;i++  )
                {
                    for (int fo=0; fo <wdith; fo ++)
                    {
                        /// 防止加入变大 从0开始 
                        if (fo > wdith-1) { fo = wdith-1; };
                        if (i >height-1) { i = height-1; };

                        Color  cl =  bim.GetPixel(fo, i);
                        if (cl.A != this.bai)
                        {
                            /// 本来这里就是告诉你这里使用的是32位图，有一个不是255 就告诉你 就是32 不用在处理的 
                            /// 直接返回你就是32位 
                            return 32; 
                        }
                         

                        fo += this.ina;
                        
                         
                    }
                    i += this.ina; 
                }

                /// 处理完成之后每10 像素采样完成 都是白色 直接返回 24 
                return 24; 


            }else
            {
               
                bim.Dispose();

                //// 对于其他格式一律不处理  返回0 表示该图有问题 
                return 0;
            }
        }


    }
}
