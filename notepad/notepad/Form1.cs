using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace notepad
{ 
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        public void dosyaAc()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Metin Dosyası Aç";
            ofd.Filter = "Desteklenen Formatlar(*.log,*.txt)|*.txt;*.log";
            if (ofd.ShowDialog() == DialogResult.OK){richTextBox1.Text = File.ReadAllText(ofd.FileName, Encoding.Default);this.Text = "Açılan:" + ofd.FileName;}
        }

        public void dosyaKaydet()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Metin Dosyası Kaydet";
            sfd.Filter = "Desteklenen Formatlar(*.log,*.txt)|*.txt;*.log";
            if (sfd.ShowDialog() == DialogResult.OK){File.WriteAllText(sfd.FileName, richTextBox1.Text, Encoding.Default); this.Text = "Kaydedilen:" + sfd.FileName;}
        }
        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //https://www.youtube.com/watch?v=DqUgnkqsZ9Q
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void eğikToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);

        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();
       }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Çalışmanız Kaybolacak", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                path = string.Empty;
                richTextBox1.Clear();
            }
 
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda hkk = new hakkinda();
            hkk.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void saatTarihToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text =DateTime.Now.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (this.Opacity==0.70f){this.Opacity = 1;}
            else { this.Opacity = 0.70f; }
          
                     
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (richTextBox1.SelectedText !=null && richTextBox1.SelectedText !="")
            {
                kesToolStripMenuItem.Enabled = true;
                kopyalaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kesToolStripMenuItem.Enabled = false;
                kopyalaToolStripMenuItem.Enabled = false;
            }

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 12);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 16);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 24);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 36);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 54);
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 68);
         
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, 8);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstiyor Musunuz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }


        
    
    
    }
      }
 

