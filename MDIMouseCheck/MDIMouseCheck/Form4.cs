﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MDIMouseCheck
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (radioButton1.Checked == true)
            {
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fd.Font;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fd.Font;
                }
            }
        }

        private void buttonFontForecolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (radioButton1.Checked == true)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = cd.Color;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = cd.Color;
                }
            }
        }

        private void buttonFontBackcolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (radioButton1.Checked == true)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.BackColor = cd.Color;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = cd.Color;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "All File|*.*|Text|*.txt";
                saveFileDialog.Title = "Save an Text File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
            else if (radioButton2.Checked == true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "All File|*.*|RTF|*.rtf";
                saveFileDialog.Title = "Save an Text File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Rtf);
                }
            }
        }
    }
}
