using Spammeur.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Spammeur
{
    public partial class Form1 : Form
    {
        //int i;
        String text;
        


        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void Spam_Click(object sender, EventArgs e)
        {
            
            timer1.Interval = ((int)numericUpDown1.Value);  //defini le temps d'intervalle via l'outil numericUpDown du disigner
            timer1.Enabled = true;                          //lance le collage


        }

        private void Quitter_Click(object sender, EventArgs e)
        {

            Application.Exit();             //ferme l'application           
        }

        
       

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            Clipboard.SetText(text);                        // permet de copier dans le press papier

        }


        private void button2_Click(object sender, EventArgs e)          //boutton stop
        {
            timer1.Enabled = false;                                     //arrete le timer et donc par conséquent les actions produites
        }

        private void timer1_Tick(object sender, EventArgs e)            // à chaque tick du timer, il executera le code
        {
            SendKeys.Send("^{v}");                    //permet de réaliser une secession de touche clavier ----- ^ correspond a la touche Ctrl
            SendKeys.Send("~");                      //~ correspond a la touche Entrée
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
