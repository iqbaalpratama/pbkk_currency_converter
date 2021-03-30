
namespace pbkk_dynamic_currency_converter
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
            this.frombox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.convertbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM";
            // 
            // frombox
            // 
            this.frombox.FormattingEnabled = true;
            this.frombox.Items.AddRange(new object[] {
            "IDR",
            "USD",
            "EUR",
            "JPY",
            "CNY",
            "KRW"});
            this.frombox.Location = new System.Drawing.Point(61, 57);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(219, 23);
            this.frombox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TO";
            // 
            // tobox
            // 
            this.tobox.FormattingEnabled = true;
            this.tobox.Items.AddRange(new object[] {
            "IDR",
            "USD",
            "EUR",
            "JPY",
            "CNY",
            "KRW"});
            this.tobox.Location = new System.Drawing.Point(390, 57);
            this.tobox.Name = "tobox";
            this.tobox.Size = new System.Drawing.Size(234, 23);
            this.tobox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESULT";
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(390, 152);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(234, 23);
            this.resultbox.TabIndex = 6;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(61, 152);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(219, 23);
            this.amountbox.TabIndex = 7;
            // 
            // convertbtn
            // 
            this.convertbtn.Location = new System.Drawing.Point(268, 206);
            this.convertbtn.Name = "convertbtn";
            this.convertbtn.Size = new System.Drawing.Size(125, 44);
            this.convertbtn.TabIndex = 8;
            this.convertbtn.Text = "Convert";
            this.convertbtn.UseVisualStyleBackColor = true;
            this.convertbtn.Click += new System.EventHandler(this.convertbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 262);
            this.Controls.Add(this.convertbtn);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frombox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dynamic Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frombox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Button convertbtn;
    }
}

