using System;
using System.IO;

namespace bloco_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\TEMP\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado!");
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}

