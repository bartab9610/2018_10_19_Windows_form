using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_10_19_Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button_save.Click += (sender, e) =>
            {
                Mentes();
            };
            Button_open.Click += (sender, e) =>
            {
                Megnyitas();
            };
        }
        public void Mentes()
        {
            string tartalom = TextBox_content.Text;
            var eredmeny = SaveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string File_nev = SaveFileDialog.FileName;
                /* using (var file = File.CreateText(File_nev))
                {
                    file.Write(tartalom);
                } */
                File.WriteAllText(File_nev, tartalom);
            }
        }
        public void Megnyitas()
        {
            if (OpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TextBox_content.Text = File.ReadAllText(OpenFileDialog.FileName);
            }
        }
    }
}