
namespace chap05_Enum
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
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnResultStringFormat = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(12, 12);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 23);
            this.tboxName.TabIndex = 0;
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 15;
            this.lboxDay.Location = new System.Drawing.Point(12, 53);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(139, 154);
            this.lboxDay.TabIndex = 1;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 15;
            this.lboxTime.Location = new System.Drawing.Point(157, 53);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(139, 154);
            this.lboxTime.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 225);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnResultStringFormat
            // 
            this.btnResultStringFormat.Location = new System.Drawing.Point(112, 225);
            this.btnResultStringFormat.Name = "btnResultStringFormat";
            this.btnResultStringFormat.Size = new System.Drawing.Size(130, 23);
            this.btnResultStringFormat.TabIndex = 4;
            this.btnResultStringFormat.Text = "String Format Test";
            this.btnResultStringFormat.UseVisualStyleBackColor = true;
            this.btnResultStringFormat.Click += new System.EventHandler(this.btnResultStringFormat_Click);
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(12, 264);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(284, 90);
            this.tboxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 365);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnResultStringFormat);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.tboxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnResultStringFormat;
        private System.Windows.Forms.TextBox tboxResult;
    }
}

