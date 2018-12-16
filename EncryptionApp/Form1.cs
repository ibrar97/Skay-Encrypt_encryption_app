using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // When Encrption button is clicked a new form will open
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            EncryptionForm e1 = new EncryptionForm();
            e1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DecryptionFrom d1 = new DecryptionFrom();
            d1.ShowDialog();
        }
    }
}
