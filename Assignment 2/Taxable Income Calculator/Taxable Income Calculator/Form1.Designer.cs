namespace WindowsFormsApplication1
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
            this.txttaxinc = new System.Windows.Forms.Label();
            this.txtfilsts = new System.Windows.Forms.Label();
            this.txttxdue = new System.Windows.Forms.Label();
            this.txtinc = new System.Windows.Forms.TextBox();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.radsin = new System.Windows.Forms.RadioButton();
            this.radmar = new System.Windows.Forms.RadioButton();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttaxinc
            // 
            this.txttaxinc.AutoSize = true;
            this.txttaxinc.Location = new System.Drawing.Point(60, 91);
            this.txttaxinc.Name = "txttaxinc";
            this.txttaxinc.Size = new System.Drawing.Size(83, 13);
            this.txttaxinc.TabIndex = 0;
            this.txttaxinc.Text = "Taxable Income";
            // 
            // txtfilsts
            // 
            this.txtfilsts.AutoSize = true;
            this.txtfilsts.Location = new System.Drawing.Point(60, 142);
            this.txtfilsts.Name = "txtfilsts";
            this.txtfilsts.Size = new System.Drawing.Size(64, 13);
            this.txtfilsts.TabIndex = 1;
            this.txtfilsts.Text = "Filing Status";
            // 
            // txttxdue
            // 
            this.txttxdue.AutoSize = true;
            this.txttxdue.Location = new System.Drawing.Point(60, 203);
            this.txttxdue.Name = "txttxdue";
            this.txttxdue.Size = new System.Drawing.Size(48, 13);
            this.txttxdue.TabIndex = 2;
            this.txttxdue.Text = "Tax Due";
            // 
            // txtinc
            // 
            this.txtinc.Location = new System.Drawing.Point(170, 84);
            this.txtinc.Name = "txtinc";
            this.txtinc.Size = new System.Drawing.Size(100, 20);
            this.txtinc.TabIndex = 3;
            this.txtinc.Text = "70700";
            // 
            // txtdue
            // 
            this.txtdue.Location = new System.Drawing.Point(170, 196);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(100, 20);
            this.txtdue.TabIndex = 4;
            // 
            // radsin
            // 
            this.radsin.AutoSize = true;
            this.radsin.Location = new System.Drawing.Point(170, 138);
            this.radsin.Name = "radsin";
            this.radsin.Size = new System.Drawing.Size(54, 17);
            this.radsin.TabIndex = 5;
            this.radsin.Text = "Single";
            this.radsin.UseVisualStyleBackColor = true;
            // 
            // radmar
            // 
            this.radmar.AutoSize = true;
            this.radmar.Checked = true;
            this.radmar.Location = new System.Drawing.Point(261, 138);
            this.radmar.Name = "radmar";
            this.radmar.Size = new System.Drawing.Size(60, 17);
            this.radmar.TabIndex = 6;
            this.radmar.TabStop = true;
            this.radmar.Text = "Married";
            this.radmar.UseVisualStyleBackColor = true;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(180, 249);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 7;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 365);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.radmar);
            this.Controls.Add(this.radsin);
            this.Controls.Add(this.txtdue);
            this.Controls.Add(this.txtinc);
            this.Controls.Add(this.txttxdue);
            this.Controls.Add(this.txtfilsts);
            this.Controls.Add(this.txttaxinc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttaxinc;
        private System.Windows.Forms.Label txtfilsts;
        private System.Windows.Forms.Label txttxdue;
        private System.Windows.Forms.TextBox txtinc;
        private System.Windows.Forms.TextBox txtdue;
        private System.Windows.Forms.RadioButton radsin;
        private System.Windows.Forms.RadioButton radmar;
        private System.Windows.Forms.Button btncalc;
    }
}

