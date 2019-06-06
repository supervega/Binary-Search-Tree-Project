namespace BinarySearchTree
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
            this.ADDTextBox = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ADDTextBox
            // 
            this.ADDTextBox.Location = new System.Drawing.Point(54, 31);
            this.ADDTextBox.Name = "ADDTextBox";
            this.ADDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ADDTextBox.TabIndex = 0;
            this.ADDTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ADDTextBox_KeyUp);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(170, 29);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(76, 23);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 344);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ADDTextBox);
            this.Name = "Form1";
            this.Text = "BST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ADDTextBox;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel panel1;
    }
}

