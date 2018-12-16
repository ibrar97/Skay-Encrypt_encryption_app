using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class DecryptionFrom : Form
    {
        public DecryptionFrom()
        {
            InitializeComponent();
        }

        // Instantiating openFileDialog
        OpenFileDialog ofd = new OpenFileDialog();

        // Instantiatinf SaveFileDialog
        SaveFileDialog sfd = new SaveFileDialog();

        // Decrypt Method
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {

                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException Error :" + ex_CryptographicException);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CryptoStream Error: " + ex);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
                MessageBox.Show("Your file has been decrypted");
            }
        }

        // Method for locating input encrypted file
        private void button1_Click(object sender, EventArgs e)
        {
                       
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // copies select file path to the txtbox_filepath
                    txtbox_INPUT_filePath.Text = ofd.FileName;
                }
            
        }
 
        // Method for saving OUTPUT file ( decrypted file) borwsing
        private void txtbox_OUTpath_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                txtbox_OUTPUT_path.Text = sfd.FileName;
            }

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            FileDecrypt(txtbox_INPUT_filePath.Text, txtbox_OUTPUT_path.Text, txtbox_password_field.Text);
        }
    }
}


