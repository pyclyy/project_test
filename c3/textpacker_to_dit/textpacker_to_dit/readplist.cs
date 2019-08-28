using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Collections;

namespace textpackerplist_to_uv
{
    public class plistcom 
    {
        public string tagname;
        public Rectangle frame;
        public Point offset;
        public bool rotated;
        public Point sourcesize;
        public Point pakesize; 




    }
    /// <summary>
    /// 返回的uv 信息都是在 0 -1 之间实习那处理 
    /// </summary>
    public class plistcom_tomax
    {
        public string name;
        /// <summary>
        /// uv 缩小后的宽度 高度 1之内
        /// </summary>
        public float uv_width;
        public float uv_height;
        /// <summary>
        /// 最后uv 移动对应合并的后的图
        /// </summary>
        public float uv_x_offset;
        public float uv_y_offset;

        public bool is_rotate;  
    }


    public class readplist
    {
        private string plistfile;
        private string usekey = "key";
        private string usedit = "dict";
        public plistcom newre;
        /// <summary>
        /// 在元素循环中建立 plistcom 对象 
        /// </summary>
        private string useframe = "frame";
        private string useoffset = "offset";
        private string userotaed = "rotated";
        private string usesourcesize = "sourcesize";
        private string usetrue = "true";
        private string usefalse = "false";
        private string usesize = "size";
        private Point packe_text_size; 


        public readplist(string plistfile)
        {
            this.plistfile = plistfile;

        }

        public List<plistcom> listarray = new List<plistcom>();
        public List<plistcom_tomax> uv_com = new List<plistcom_tomax>();
        /// <summary>
        /// 根据传入的plist  返回一个 数组  每个数组是一个plistcom 对象， 
        /// 需要说明，这个plistcom 有几个属性， tagname  贴图名称 
        /// frame 是一个矩形 告诉合并后贴图的位置 
        /// offset 是一个偏于数据，对于UI 有才将的管用，对于场景合并不需要裁剪，那样会有问题 
        /// rotaed 是bool 旋转也是在位置去顶了之后进行的旋转操作， 这里如果反项处理uv 
        /// sourcesize 处理的图像大小 
        /// pakesize 打包图片的大小 
        /// </summary>
        /// <returns></returns>
        public Array loadxmltolistarray()
        {
            listarray.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load(this.plistfile);
            XmlElement rooxml = xml.DocumentElement;

            XmlNode  packesize = rooxml.ChildNodes.Item(0).ChildNodes.Item(3);
            IEnumerator pack_inum  = packesize.GetEnumerator();
            while(pack_inum.MoveNext())
            {
                XmlElement ct = (XmlElement)pack_inum.Current;
                if (ct.InnerText == this.usesize)
                {
                    // 移动到下一位 
                    pack_inum.MoveNext();
                    ct = (XmlElement)pack_inum.Current;
                    string sr =ct.InnerText;
                    /// 分割字符进行转换并 去掉空的字符 
                    string[] get = sr.Split(new char[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int x = Convert.ToInt16((get[0]));
                    int y = Convert.ToInt16((get[1]));
                    packe_text_size = new Point(x, y);
                }
            }






            XmlNode totodit_kv = rooxml.ChildNodes.Item(0).ChildNodes.Item(1);
            /// 利用迭代器处理 
            /// 
            IEnumerator ienum = totodit_kv.GetEnumerator();


            /// 运行期间
            while (ienum.MoveNext())
            {

                XmlNode t = (XmlNode)ienum.Current;
                XmlElement ct = (XmlElement)t;
                if (ct.Name == this.usekey)
                {
                    newre = new plistcom();
                    newre.tagname = ct.InnerText.ToString();
                }
                //// 是字典的
                if (ct.Name == this.usedit)
                {
                    /// 内部小迭代 使 元素  
                    ///  
                    for (int i = 0; i < ct.ChildNodes.Count; i++)
                    {

                        string ss = ct.ChildNodes.Item(i).InnerText;
                        if (ss == useframe)
                        {
                            //i加1  处理边框数据 
                            i += 1;
                            string sr = ct.ChildNodes.Item(i).InnerText;
                            /// 分割字符进行转换并 去掉空的字符 
                            string[] get = sr.Split(new char[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
                            int x = Convert.ToInt16((get[0]));
                            int y = Convert.ToInt16((get[1]));
                            int width = Convert.ToInt16((get[2]));
                            int height = Convert.ToInt16((get[3]));

                            newre.frame = new Rectangle(x, y, width, height);

                        }
                        else if (ss == useoffset)
                        {
                            i += 1;
                            string sr = ct.ChildNodes.Item(i).InnerText;
                            /// 分割字符进行转换并 去掉空的字符 
                            string[] get = sr.Split(new char[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
                            int x = Convert.ToInt16((get[0]));
                            int y = Convert.ToInt16((get[1]));

                            newre.offset = new Point(x, y);
                        }
                        else if (ss == userotaed)
                        {
                            i += 1;
                            string sr = ct.ChildNodes.Item(i).Name;
                            if (sr == usetrue)
                            {
                                newre.rotated = true;

                            }
                            else if (sr == usefalse)
                            {
                                newre.rotated = false;
                            }

                        }
                        else if (ss == usesourcesize)
                        {
                            i += 1;
                            /// 每次等于key 向下移动一位进行取值操作 完成的操作 
                            /// 
                            string sr = ct.ChildNodes.Item(i).InnerText;
                            /// 分割字符进行转换并 去掉空的字符 
                            string[] get = sr.Split(new char[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
                            int x = Convert.ToInt16((get[0]));
                            int y = Convert.ToInt16((get[1]));
                            newre.sourcesize = new Point(x, y);

                        }

                        // 最后加入 pack tex size 
                        newre.pakesize = packe_text_size;

                    }
                    ///  循环完成装入一个对象 
                    ///  
                    listarray.Add(newre);
                }

                // Console.WriteLine(ct.Name );

            }
            /// 迭代器好事很好处理 还是

            return listarray.ToArray();

        }


        /// <summary>
        ///  最后数据放到这里提供查找查询的方法
        ///  通过uv_width  uv_height  uv_x_offset uv_y_offset uv_isrotate 
        /// </summary>
        public plistcom_tomax[]   GetPlistSetUvValues ;
        public plistcom_tomax poly_tem; 
        /// <summary>
        /// 依赖查loadxmltolistarray 中循环每张图片的需要图片缩放后 宽和高 和处理后偏移竖直，还有就是是否进行旋转的处理  
        /// </summary>
        /// <returns></returns>
        public  void  dependListarrayMakeUvValue ()
        {
            // 最后社会吃uv com 
            GetPlistSetUvValues = new plistcom_tomax[] { };
            uv_com.Clear();
            Array getlistarray = loadxmltolistarray();

            foreach (var i in getlistarray)
            {
                plistcom_tomax tem = new plistcom_tomax();
                plistcom obj = (plistcom)i;
                tem.name = obj.tagname;
                tem.is_rotate = obj.rotated;

                int imagewidth = obj.pakesize.X;
                int imageheight = obj.pakesize.Y;

                int image_st_x = obj.frame.X;
                int image_st_y = obj.frame.Y;
                int image_en_x = obj.frame.Width;
                int image_en_y = obj.frame.Height;
                /// 计算的uv 缩小比例 
                tem.uv_width = image_en_x / (float)imagewidth;
                tem.uv_height = image_en_y / (float)imageheight;

                /// 计算的uv 偏移数 
                tem.uv_x_offset = image_st_x / (float)imagewidth;
                tem.uv_y_offset = image_st_y / (float)imageheight;

                uv_com.Add(tem);

            }

            /// 不做返回， 处理完成数据给到一点， 后续通过查询的方法和方式处理   
            /// 
            GetPlistSetUvValues = uv_com.ToArray();


        }// end 

        public  plistcom_tomax  Find_UV  (string tganame )
        {
            if (GetPlistSetUvValues.Length <1)
            {
                // 防止查询没有制作数据 
                dependListarrayMakeUvValue();
            }
            plistcom_tomax tem = poly_tem ; 
            /// 循环查询 
            foreach (plistcom_tomax i in GetPlistSetUvValues)
            {
                plistcom_tomax t = (plistcom_tomax)i;
                if (t.name == tganame )
                {
                    tem = i;
                    break;
                }

            }

            return tem; 

        }

        public  bool  IsFind (string tganame )
        {
            bool tem = false; 
            /// 循环查询 
            foreach (plistcom_tomax i in GetPlistSetUvValues)
            {
                plistcom_tomax t = (plistcom_tomax)i;
                if (t.name == tganame)
                {
                    tem = true ;
                    break;
                }

            }

            return tem;


        }

    }
}
