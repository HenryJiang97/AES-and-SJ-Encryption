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

namespace Decoder
{
    public partial class Decoder : Form
    {
        public Decoder()
        {
            InitializeComponent();
        }

        //AesDecrypt Method
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

        //AesEncrypt Method
        static string Encrypt(string toEncrypt, string key)
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


        //Decrypt Trigger
        private void button1_Click(object sender, EventArgs e)
        {
            string path_r = rpathtext.Text;
            string pw = ptext.Text;
            string path_w = wpathtext.Text + "\\明文.txt";


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

                MessageBox.Show("解码成功!");
            }
            catch (Exception error)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(error.Message);
                
                MessageBox.Show("密码错误");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Select read-in file (Decrypt)
        private void button1_Click_1(object sender, EventArgs e)
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

        //Select output file folder (Decrypt)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Select read-in file (Encrypt)
        private void button3_Click(object sender, EventArgs e)
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

            rpathtext_e.Text = filePath;
        }

        //Select output file folder (Encrypt)
        private void button4_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filePath = fbd.SelectedPath;
                    wpathtext_e.Text = filePath;
                }
            }
        }


        //Encrypt Trigger
        private void button5_Click(object sender, EventArgs e)
        {
            string path_r = rpathtext_e.Text;
            string pw = ptext_e.Text;
            string path_w = wpathtext_e.Text + "\\密文.txt";
            ;

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
                        result.Add(Encrypt(line, pw));
                    }
                }

                MessageBox.Show("加密成功!");
            }
            catch (Exception error)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(error.Message);

                MessageBox.Show("密码长度应为16位");
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
