using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace core_lib.common
{
    public class FileUtil
    {
        public static void writeFile(string filename, byte[] bytes)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        public static void copyFile(string destFile, string srcFile)
        {
            File.Copy(srcFile, destFile);
        }
    }
}
