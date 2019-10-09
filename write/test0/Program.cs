using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg = 0;
            while (true) { 
            avg++;
            var content = (avg).ToString();
            FileStream fs = new FileStream(@"C:\Users\27870\Desktop\WriteLines2.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            var buffer1 = Encoding.Default.GetBytes(content + "\r\n" + content+100);
            //var buffer2 = Encoding.Default.GetBytes("world");
            fs.Write(buffer1, 0, buffer1.Length);
            // fs.Write(buffer2, 3, buffer2.Length);
            fs.Flush();
            fs.Close();
            // WriteFile(FileMode.Create, FileAccess.Write, FileShare.Read);*/
        }
        }
    }
}
