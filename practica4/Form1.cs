using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            /*RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Software\Practica");
            int colorA = Int32.Parse(key2.GetValue("colorA").ToString());
            int colorR = Int32.Parse(key2.GetValue("colorR").ToString());
            int colorG = Int32.Parse(key2.GetValue("colorG").ToString());
            int colorB = Int32.Parse(key2.GetValue("colorB").ToString());
            this.BackColor = Color.FromArgb(colorA, colorR, colorG, colorB);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.AllowFullOpen = true;
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                
                this.BackColor = colorDialog1.Color;
                RegistryKey key1 = Registry.CurrentUser.CreateSubKey(@"Software\Practica");
                key1.SetValue("colorA", this.BackColor.A);
                key1.SetValue("colorR", this.BackColor.R);
                key1.SetValue("colorG", this.BackColor.G);
                key1.SetValue("colorB", this.BackColor.B);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }

}
