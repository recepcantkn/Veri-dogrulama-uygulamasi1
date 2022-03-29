using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Kullanıcı adını giriniz.", "Uyarı" );
            }
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Şifreyi giriniz.", "Uyarı");

            }
        }
    }
}
