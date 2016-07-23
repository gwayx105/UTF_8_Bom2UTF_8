using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                       
/*
 * Author: Sylvester Zowonu
 * Description: Converting UTF-8-BOM file to
 *              UTF-8 using Command Line Interface
 *              
 * */

namespace UTF_8_Bom2UTF_8
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string path = Path.GetFullPath(args[0]);
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    Console.WriteLine("\nWriting "+lines.Length+" of Records...Please Wait!");
                    File.WriteAllLines(path, lines);
                    Console.WriteLine("Finished Writing :"+lines.Length+" Lines of Records."); 
                }
                else {
                    Console.WriteLine("\nFile not found...!\nPlease Check and try again...");
                }
            }
            else {
                Console.WriteLine("Please specify file...!");
            }
        }
    }
}
