namespace _2018_10_19_Windows_form
{
    partial class Form1
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
            this.Button_open = new System.Windows.Forms.Button();
            this.Button_save = new System.Windows.Forms.Button();
            this.TextBox_content = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Button_open
            // 
            this.Button_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_open.Location = new System.Drawing.Point(55, 21);
            this.Button_open.Name = "Button_open";
            this.Button_open.Size = new System.Drawing.Size(75, 23);
            this.Button_open.TabIndex = 0;
            this.Button_open.Text = "Open";
            this.Button_open.UseVisualStyleBackColor = true;
            // 
            // Button_save
            // 
            this.Button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_save.Location = new System.Drawing.Point(160, 21);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(75, 23);
            this.Button_save.TabIndex = 1;
            this.Button_save.Text = "Save";
            this.Button_save.UseVisualStyleBackColor = true;
            // 
            // TextBox_content
            // 
            this.TextBox_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_content.Location = new System.Drawing.Point(26, 55);
            this.TextBox_content.Multiline = true;
            this.TextBox_content.Name = "TextBox_content";
            this.TextBox_content.Size = new System.Drawing.Size(241, 186);
            this.TextBox_content.TabIndex = 2;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "Szöveges fájlok (.txt)|*.txt|Minden fájl|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Szöveges fájlok|*.txt|Minden fájl|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.TextBox_content);
            this.Controls.Add(this.Button_save);
            this.Controls.Add(this.Button_open);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_open;
        private System.Windows.Forms.Button Button_save;
        private System.Windows.Forms.TextBox TextBox_content;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

