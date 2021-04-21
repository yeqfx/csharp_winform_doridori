
namespace chap09_for_foreach
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.btnMultiFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(12, 12);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxResult.Size = new System.Drawing.Size(213, 276);
            this.tboxResult.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(231, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(152, 69);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "for 문";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(231, 162);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(152, 69);
            this.btnForeach.TabIndex = 2;
            this.btnForeach.Text = "foreach 문";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // btnMultiFor
            // 
            this.btnMultiFor.Location = new System.Drawing.Point(231, 87);
            this.btnMultiFor.Name = "btnMultiFor";
            this.btnMultiFor.Size = new System.Drawing.Size(152, 69);
            this.btnMultiFor.TabIndex = 3;
            this.btnMultiFor.Text = "다중 for 문";
            this.btnMultiFor.UseVisualStyleBackColor = true;
            this.btnMultiFor.Click += new System.EventHandler(this.btnMultiFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 303);
            this.Controls.Add(this.btnMultiFor);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.tboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnForeach;
        private System.Windows.Forms.Button btnMultiFor;
    }
}

