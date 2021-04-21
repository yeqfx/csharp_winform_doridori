
namespace chap08_if_switch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnifResult = new System.Windows.Forms.Button();
            this.lblifResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.btnswitchResult = new System.Windows.Forms.Button();
            this.lblswitchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2)";
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(12, 27);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(120, 23);
            this.nNumber1.TabIndex = 2;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(161, 27);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(120, 23);
            this.nNumber2.TabIndex = 3;
            // 
            // btnifResult
            // 
            this.btnifResult.Location = new System.Drawing.Point(331, 25);
            this.btnifResult.Name = "btnifResult";
            this.btnifResult.Size = new System.Drawing.Size(102, 23);
            this.btnifResult.TabIndex = 4;
            this.btnifResult.Text = "Number 비교";
            this.btnifResult.UseVisualStyleBackColor = true;
            this.btnifResult.Click += new System.EventHandler(this.btnifResult_Click);
            // 
            // lblifResult
            // 
            this.lblifResult.AutoSize = true;
            this.lblifResult.Location = new System.Drawing.Point(12, 77);
            this.lblifResult.Name = "lblifResult";
            this.lblifResult.Size = new System.Drawing.Size(12, 15);
            this.lblifResult.TabIndex = 5;
            this.lblifResult.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "요일선택)";
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(12, 147);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 23);
            this.cboxDay.TabIndex = 7;
            this.cboxDay.Text = "월";
            // 
            // btnswitchResult
            // 
            this.btnswitchResult.Location = new System.Drawing.Point(331, 147);
            this.btnswitchResult.Name = "btnswitchResult";
            this.btnswitchResult.Size = new System.Drawing.Size(102, 23);
            this.btnswitchResult.TabIndex = 8;
            this.btnswitchResult.Text = "선택요일확인";
            this.btnswitchResult.UseVisualStyleBackColor = true;
            this.btnswitchResult.Click += new System.EventHandler(this.btnswitchResult_Click);
            // 
            // lblswitchResult
            // 
            this.lblswitchResult.AutoSize = true;
            this.lblswitchResult.Location = new System.Drawing.Point(12, 197);
            this.lblswitchResult.Name = "lblswitchResult";
            this.lblswitchResult.Size = new System.Drawing.Size(12, 15);
            this.lblswitchResult.TabIndex = 9;
            this.lblswitchResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 255);
            this.Controls.Add(this.lblswitchResult);
            this.Controls.Add(this.btnswitchResult);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblifResult);
            this.Controls.Add(this.btnifResult);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.Button btnifResult;
        private System.Windows.Forms.Label lblifResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Button btnswitchResult;
        private System.Windows.Forms.Label lblswitchResult;
    }
}

