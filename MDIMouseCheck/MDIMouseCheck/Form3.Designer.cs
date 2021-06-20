
namespace MDIMouseCheck
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAutosave = new System.Windows.Forms.Button();
            this.buttonAutoRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.buttonDeserial = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveSerial = new System.Windows.Forms.CheckBox();
            this.buttonChooseSave = new System.Windows.Forms.Button();
            this.radioButtonRead = new System.Windows.Forms.RadioButton();
            this.radioButtonDeserial = new System.Windows.Forms.RadioButton();
            this.buttonChooseRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 297);
            this.textBox1.TabIndex = 0;
            // 
            // buttonAutosave
            // 
            this.buttonAutosave.Location = new System.Drawing.Point(40, 363);
            this.buttonAutosave.Name = "buttonAutosave";
            this.buttonAutosave.Size = new System.Drawing.Size(171, 23);
            this.buttonAutosave.TabIndex = 1;
            this.buttonAutosave.Text = "자동저장";
            this.buttonAutosave.UseVisualStyleBackColor = true;
            this.buttonAutosave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAutoRead
            // 
            this.buttonAutoRead.Location = new System.Drawing.Point(230, 363);
            this.buttonAutoRead.Name = "buttonAutoRead";
            this.buttonAutoRead.Size = new System.Drawing.Size(173, 23);
            this.buttonAutoRead.TabIndex = 2;
            this.buttonAutoRead.Text = "자동읽기";
            this.buttonAutoRead.UseVisualStyleBackColor = true;
            this.buttonAutoRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(40, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(171, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(230, 392);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(173, 23);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.Text = "읽기";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "--------------------------------------------------------------------------";
            // 
            // buttonSerial
            // 
            this.buttonSerial.Location = new System.Drawing.Point(40, 421);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(171, 23);
            this.buttonSerial.TabIndex = 6;
            this.buttonSerial.Text = "직렬화저장";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // buttonDeserial
            // 
            this.buttonDeserial.Location = new System.Drawing.Point(230, 421);
            this.buttonDeserial.Name = "buttonDeserial";
            this.buttonDeserial.Size = new System.Drawing.Size(173, 23);
            this.buttonDeserial.TabIndex = 7;
            this.buttonDeserial.Text = "역직렬화읽기";
            this.buttonDeserial.UseVisualStyleBackColor = true;
            this.buttonDeserial.Click += new System.EventHandler(this.buttonDeserial_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(40, 521);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(74, 19);
            this.checkBoxSave.TabIndex = 9;
            this.checkBoxSave.Text = "일반저장";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveSerial
            // 
            this.checkBoxSaveSerial.AutoSize = true;
            this.checkBoxSaveSerial.Location = new System.Drawing.Point(40, 561);
            this.checkBoxSaveSerial.Name = "checkBoxSaveSerial";
            this.checkBoxSaveSerial.Size = new System.Drawing.Size(86, 19);
            this.checkBoxSaveSerial.TabIndex = 10;
            this.checkBoxSaveSerial.Text = "직렬화저장";
            this.checkBoxSaveSerial.UseVisualStyleBackColor = true;
            // 
            // buttonChooseSave
            // 
            this.buttonChooseSave.Location = new System.Drawing.Point(40, 603);
            this.buttonChooseSave.Name = "buttonChooseSave";
            this.buttonChooseSave.Size = new System.Drawing.Size(132, 23);
            this.buttonChooseSave.TabIndex = 11;
            this.buttonChooseSave.Text = "선택저장";
            this.buttonChooseSave.UseVisualStyleBackColor = true;
            this.buttonChooseSave.Click += new System.EventHandler(this.buttonChooseSave_Click);
            // 
            // radioButtonRead
            // 
            this.radioButtonRead.AutoSize = true;
            this.radioButtonRead.Location = new System.Drawing.Point(230, 521);
            this.radioButtonRead.Name = "radioButtonRead";
            this.radioButtonRead.Size = new System.Drawing.Size(73, 19);
            this.radioButtonRead.TabIndex = 12;
            this.radioButtonRead.TabStop = true;
            this.radioButtonRead.Text = "일반읽기";
            this.radioButtonRead.UseVisualStyleBackColor = true;
            this.radioButtonRead.CheckedChanged += new System.EventHandler(this.radioButtonRead_CheckedChanged);
            // 
            // radioButtonDeserial
            // 
            this.radioButtonDeserial.AutoSize = true;
            this.radioButtonDeserial.Location = new System.Drawing.Point(230, 560);
            this.radioButtonDeserial.Name = "radioButtonDeserial";
            this.radioButtonDeserial.Size = new System.Drawing.Size(73, 19);
            this.radioButtonDeserial.TabIndex = 13;
            this.radioButtonDeserial.TabStop = true;
            this.radioButtonDeserial.Text = "역직렬화";
            this.radioButtonDeserial.UseVisualStyleBackColor = true;
            // 
            // buttonChooseRead
            // 
            this.buttonChooseRead.Location = new System.Drawing.Point(230, 603);
            this.buttonChooseRead.Name = "buttonChooseRead";
            this.buttonChooseRead.Size = new System.Drawing.Size(132, 23);
            this.buttonChooseRead.TabIndex = 14;
            this.buttonChooseRead.Text = "선택읽기";
            this.buttonChooseRead.UseVisualStyleBackColor = true;
            this.buttonChooseRead.Click += new System.EventHandler(this.buttonChooseRead_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 662);
            this.Controls.Add(this.buttonChooseRead);
            this.Controls.Add(this.radioButtonDeserial);
            this.Controls.Add(this.radioButtonRead);
            this.Controls.Add(this.buttonChooseSave);
            this.Controls.Add(this.checkBoxSaveSerial);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.buttonDeserial);
            this.Controls.Add(this.buttonSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAutoRead);
            this.Controls.Add(this.buttonAutosave);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAutosave;
        private System.Windows.Forms.Button buttonAutoRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.Button buttonDeserial;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.CheckBox checkBoxSaveSerial;
        private System.Windows.Forms.Button buttonChooseSave;
        private System.Windows.Forms.RadioButton radioButtonRead;
        private System.Windows.Forms.RadioButton radioButtonDeserial;
        private System.Windows.Forms.CheckBox checkBoxSerial;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonChooseRead;
    }
}