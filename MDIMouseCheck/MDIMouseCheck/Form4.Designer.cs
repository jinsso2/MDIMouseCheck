
namespace MDIMouseCheck
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonFontForecolor = new System.Windows.Forms.Button();
            this.buttonFontBackcolor = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(38, 33);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 0;
            this.buttonFont.Text = "폰트";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonFontForecolor
            // 
            this.buttonFontForecolor.Location = new System.Drawing.Point(167, 33);
            this.buttonFontForecolor.Name = "buttonFontForecolor";
            this.buttonFontForecolor.Size = new System.Drawing.Size(75, 23);
            this.buttonFontForecolor.TabIndex = 1;
            this.buttonFontForecolor.Text = "폰트전경색";
            this.buttonFontForecolor.UseVisualStyleBackColor = true;
            this.buttonFontForecolor.Click += new System.EventHandler(this.buttonFontForecolor_Click);
            // 
            // buttonFontBackcolor
            // 
            this.buttonFontBackcolor.Location = new System.Drawing.Point(294, 32);
            this.buttonFontBackcolor.Name = "buttonFontBackcolor";
            this.buttonFontBackcolor.Size = new System.Drawing.Size(75, 23);
            this.buttonFontBackcolor.TabIndex = 2;
            this.buttonFontBackcolor.Text = "배경색";
            this.buttonFontBackcolor.UseVisualStyleBackColor = true;
            this.buttonFontBackcolor.Click += new System.EventHandler(this.buttonFontBackcolor_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "textbox";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "richtextbox";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(295, 97);
            this.textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 178);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "textbox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "richtextbox";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(157, 523);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 585);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonFontBackcolor);
            this.Controls.Add(this.buttonFontForecolor);
            this.Controls.Add(this.buttonFont);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonFontForecolor;
        private System.Windows.Forms.Button buttonFontBackcolor;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
    }
}