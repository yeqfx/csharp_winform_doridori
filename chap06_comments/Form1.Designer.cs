
namespace chap06_comments
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxComment1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxComment2 = new System.Windows.Forms.TextBox();
            this.tboxComment3 = new System.Windows.Forms.TextBox();
            this.tboxComment4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxComment1
            // 
            this.tboxComment1.Enabled = false;
            this.tboxComment1.Location = new System.Drawing.Point(12, 27);
            this.tboxComment1.Multiline = true;
            this.tboxComment1.Name = "tboxComment1";
            this.tboxComment1.Size = new System.Drawing.Size(397, 23);
            this.tboxComment1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "주석1 : //";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "주석2 : //";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "주석3 : /* */";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "주석4 : ///";
            // 
            // tboxComment2
            // 
            this.tboxComment2.Enabled = false;
            this.tboxComment2.Location = new System.Drawing.Point(12, 94);
            this.tboxComment2.Multiline = true;
            this.tboxComment2.Name = "tboxComment2";
            this.tboxComment2.Size = new System.Drawing.Size(397, 23);
            this.tboxComment2.TabIndex = 5;
            // 
            // tboxComment3
            // 
            this.tboxComment3.Enabled = false;
            this.tboxComment3.Location = new System.Drawing.Point(12, 164);
            this.tboxComment3.Multiline = true;
            this.tboxComment3.Name = "tboxComment3";
            this.tboxComment3.Size = new System.Drawing.Size(397, 23);
            this.tboxComment3.TabIndex = 6;
            // 
            // tboxComment4
            // 
            this.tboxComment4.Enabled = false;
            this.tboxComment4.Location = new System.Drawing.Point(12, 243);
            this.tboxComment4.Multiline = true;
            this.tboxComment4.Name = "tboxComment4";
            this.tboxComment4.Size = new System.Drawing.Size(397, 114);
            this.tboxComment4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 383);
            this.Controls.Add(this.tboxComment4);
            this.Controls.Add(this.tboxComment3);
            this.Controls.Add(this.tboxComment2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxComment1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxComment1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxComment2;
        private System.Windows.Forms.TextBox tboxComment3;
        private System.Windows.Forms.TextBox tboxComment4;
    }
}

