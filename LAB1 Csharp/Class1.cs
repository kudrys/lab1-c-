using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB1_Csharp
{
    class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("kek");
            Console.WriteLine("{1} pierwszy arg to: {0}", args[0] , ":)");
            //-------------foldery
            DirectoryInfo di = new DirectoryInfo(@"D:\");
            DirectoryInfo[] dirTab = di.GetDirectories();
            foreach (var singleDirectory in dirTab)
            {
                Console.WriteLine("singleDir: {0}", singleDirectory.Name);

            }
            //------------------poj pliki
            foreach (var singleFile in di.GetFiles())
            {
                Console.WriteLine("singleFile: {0}", singleFile.Name);
            }





            while (true) { }
        }
    }


class Test
    {
        public static void Kain()
        {
            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(@"D:\MyDir");
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                di.Create();
                Console.WriteLine("The directory was created successfully.");

                //// Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            while (true) ;
        }
    }
}

