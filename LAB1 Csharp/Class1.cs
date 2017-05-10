using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace LAB1_Csharp{
    class Class1{
        public static void Main(string[] args){
            Console.WriteLine("kek");
            Console.WriteLine("{1} pierwszy arg to: {0}", args[0] , ":)");
            //-------------foldery
            DirectoryInfo di = new DirectoryInfo(@"D:\");
            DirectoryInfo[] dirTab = di.GetDirectories();
            foreach (var singleDirectory in dirTab){
                Console.WriteLine("singleDir: {0}", singleDirectory.Name);

            }
            //------------------poj pliki
            foreach (var singleFile in di.GetFiles()){
                Console.WriteLine("singleFile: {0}", singleFile.Name);
            }
            //-----------------Serializacja i deserializacja kolekcji
            //-----------------Serializacja:
            FileStream plikZSerialami = new FileStream("Serials.txt", FileMode.Create);
            BinaryFormatter formater = new BinaryFormatter();

            try{
                formater.Serialize(plikZSerialami, dirTab);
            }
            catch{
                Console.WriteLine("ERROR");
            }
            finally{
                plikZSerialami.Close();
            }
            //------------------Deserializacja:
            FileStream OtwieralnyPlik = new FileStream("Serials.txt", FileMode.Open);
            OtwieralnyPlik.Position = 0;
            DirectoryInfo[] de = null;
            BinaryFormatter deformater = new BinaryFormatter();
            de = (DirectoryInfo[]) deformater.Deserialize(OtwieralnyPlik);
            
            try {
                foreach (var xex in de) {
                    Console.WriteLine("deserializowane: {0}", xex);
                }
            }catch(SerializationException e) {
                Console.WriteLine("ERROR DESERIALIZE: {0}", e.Message);
            } finally {
                OtwieralnyPlik.Close();
            }








            while (true) { }
        }
    }


class Test{
        public static void Kain(){
            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(@"D:\MyDir");
            try{
                // Determine whether the directory exists.
                if (di.Exists){
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
            catch (Exception e){
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            while (true) ;
        }
    }
}

