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
 

namespace SimpleDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //Functions
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
            string path_w = wpathtext.Text + "\\SJ解密明文.txt";
            

            //Read file
            byte[] simpleText = File.ReadAllBytes(path_r);


            MessageBox.Show("解密完成");


            //Decrypt the simple encrypted file
            byte[] simpleEncryptResult = new byte[simpleText.Length - 1];

            for (var i = 0; i < simpleText.Length - 1; i++)
            {
                simpleEncryptResult[i] = simpleText[i];
            }

            //Console.WriteLine("1234");

            //Write result into the destination file
            using (StreamWriter sw = new StreamWriter(path_w))
            {
                sw.WriteLine(Encoding.UTF8.GetString(SimpleEncrypt(simpleEncryptResult)));
            }
        
        }
    }
}
