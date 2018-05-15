using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            VisFiler("C:\\temp");


        }
        public static void VisFiler(string mappe)
        {
            string[] filer = System.IO.Directory.GetFiles(mappe);
            foreach (var fil in filer)
                Console.WriteLine(fil);
            String[] mapper = System.IO.Directory.GetDirectories(mappe);
            foreach (var _mappe in mapper)
                VisFiler(_mappe);

        }
    }
}
