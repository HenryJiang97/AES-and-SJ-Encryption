using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.Cryptography;


namespace Simple_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Functions
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
            byte[] key = { 0xc5, 0x68, 0x97, 0xe3 };

            //Init the result byte[]
            byte[] result = new byte[byteText.Length + 1];


            //Loop
            var j = 0;
            for (var i = 0; i < byteText.Length; i++)
            {
                result[i] = (byte)(byteText[i] ^ key[j]);

                j += 1;

                if (j > 3)
                {
                    j = 0;
                }
            }


            //Add the check byte in the end
            result[byteText.Length] = result[0];
            for (var k = 1; k < byteText.Length; k++)
            {
                result[byteText.Length] = (byte)(result[byteText.Length] ^ result[k]);
            }


            return result;

        }





        private void ptext_TextChanged(object sender, EventArgs e)
        {

        }

        private void rpathtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void wpathtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            rpathtext.Text = filePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filePath = fbd.SelectedPath;
                    wpathtext.Text = filePath;
                }
            }
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            string path_r = rpathtext.Text;
            string pw = ptext.Text;
            string path_w = wpathtext.Text + "\\SJ加密密文.txt";
            

            ArrayList result = new ArrayList();


            //Read file
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

                MessageBox.Show("转码成功!");
            }
            catch (Exception error)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(error.Message);

                MessageBox.Show("密码错误");
            }


            //Combine the result string
            string r = "";

            foreach (string s in result)
            {

                r = r + s + "\r" + "\n";
            }


            //Transfer string into byte array
            byte[] byteText = ASCIIEncoding.ASCII.GetBytes(r);

            //Do simple encrypt
            byte[] simpleResult = SimpleEncrypt(byteText);

            //Write byte array into a file            
            File.WriteAllBytes(path_w, simpleResult);

        }
    }
}
