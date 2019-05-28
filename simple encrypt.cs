using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;


namespace AesToSimpleDecrypt
{
    class Program
    {
    	//AES Decrypt
    	static string AesDecrypt(string str, string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Convert.FromBase64String(str);

            System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = System.Security.Cryptography.CipherMode.ECB,
                Padding = System.Security.Cryptography.PaddingMode.PKCS7
            };

            System.Security.Cryptography.ICryptoTransform cTransform = rm.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Encoding.UTF8.GetString(resultArray);
        }


        // Simple Encrypt
        static byte[] SimpleEncrypt(byte[] byteText)
    	{
    		
        	//Key
        	byte[] key = {0xc5, 0x68, 0x97, 0xe3};

        	//Init the result byte[]
            byte[] result = new byte[byteText.Length + 1];


            //Loop
            var j = 0;
            for(var i = 0; i < byteText.Length; i++)
            {
            	result[i] = (byte)(byteText[i] ^ key[j]);

            	j += 1;

            	if(j > 3)
            	{
            		j = 0;
            	}
            }


            //Add the check byte in the end
            result[byteText.Length] = result[0];
            for(var k = 1; k < byteText.Length; k++)
            {
            	result[byteText.Length] = (byte)(result[byteText.Length] ^ result[k]);
            }


        	return result;

    	}


        static void Main(string[] args)
        {
        	ArrayList result = new ArrayList();
        	
            
            //Read file
            Console.WriteLine("Input reading path:");
            string path_r = Console.ReadLine();
            Console.WriteLine("Input password:");
            string pw = Console.ReadLine();
            // Console.WriteLine("Input writing path:");
            // string path_w = Console.ReadLine();


            //Read in file
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
                        result.Add(AesDecrypt(line, pw));
                    }
                }
            }
            catch (Exception error)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(error.Message);
            }



            // var byteText = new byte[1000];
            
            // byte[] r = Encoding.UTF8.GetBytes(a);
            string r = "";

            foreach (string s in result)
            {           	

            	r = r + s + "\r" + "\n";
            }
            
            Console.WriteLine(r);
            byte[] byteText = ASCIIEncoding.ASCII.GetBytes(r);

            //Display byte array
            Console.WriteLine(BitConverter.ToString(byteText));
            
        }
    }
}
