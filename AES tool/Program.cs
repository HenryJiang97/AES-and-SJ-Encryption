using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Collections;

namespace Encode
{
    class Program
    {
        //Encrypt
        static string Encrypt(string toEncrypt,string key)
        {
           byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
           byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
 
           RijndaelManaged rDel = new RijndaelManaged();
           rDel.Key = keyArray;
           rDel.Mode = CipherMode.ECB;
           rDel.Padding = PaddingMode.PKCS7;
 
           ICryptoTransform cTransform = rDel.CreateEncryptor();
           byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
 
           return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        static void Main(string[] args)
        {
            ArrayList result = new ArrayList();

            
            //Read file
            Console.WriteLine("Input reading path:");
            string path_r = Console.ReadLine();
            Console.WriteLine("Input password:");
            string pw = Console.ReadLine();
            Console.WriteLine("Input writing path:");
            string path_w = Console.ReadLine();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(path_r))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Add into an ArrayList
                        result.Add(Encrypt(line, pw));
                    }
                }
            }
            catch (Exception error)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(error.Message);
            }



            //Write into file
            using (StreamWriter sw = new StreamWriter(path_w))
            {
                foreach (string r in result)
                {
                    sw.WriteLine(r);
                }
            }
        }
        
    }
}
