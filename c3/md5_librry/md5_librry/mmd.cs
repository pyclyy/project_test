using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace md5_librry
{
    public class mmd
    {
        public string  getmd5 (string filename)
        {
            FileInfo fi = new FileInfo(filename);
            FileStream fs = fi.Open(FileMode.Open);

            MD5 m = MD5.Create();
            byte[] b = m.ComputeHash(fs);
            string s = "";
            foreach (var i in b)
            {
                s += Convert.ToString(i);
            }
            fs.Dispose();
            return s;
        }

    }
}
