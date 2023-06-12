using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_5_Itog_Task2
{
    public static class GetDirInfo
    {
        public static long GetDirSize(string urlPath)
        {
            long size = 0;
            
            DirectoryInfo d = new (urlPath);
            FileInfo[] fls = d.GetFiles();
            foreach (FileInfo fi in fls)
            {
                size += fi.Length;
            }

            DirectoryInfo[] drs = d.GetDirectories();
            foreach (DirectoryInfo di in drs)
            {
                size += GetDirSize(di.FullName);
            }
            return size;
        }
    }
}
