using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_3_3
{
    public static class DirectoryExtension
    {
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fls = d.GetFiles();
            foreach (FileInfo fi in fls) 
            {
                size += fi.Length;
            }

            DirectoryInfo[] drs = d.GetDirectories();
            foreach (DirectoryInfo di in drs)  
            {
                size += DirSize(di);
            }

            return size;
        }
    }
}
