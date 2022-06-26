
namespace uasSISCER
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxJual = new System.Windows.Forms.TextBox();
            this.boxSedia = new System.Windows.Forms.TextBox();
            this.btHitung = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.boxHasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dPT = new System.Windows.Forms.Label();
            this.dPR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dST = new System.Windows.Forms.Label();
            this.dSR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persediaan";
            // 
            // boxJual
            // 
            this.boxJual.Location = new System.Drawing.Point(127, 56);
            this.boxJual.Name = "boxJual";
            this.boxJual.Size = new System.Drawing.Size(239, 22);
            this.boxJual.TabIndex = 2;
            // 
            // boxSedia
            // 
            this.boxSedia.Location = new System.Drawing.Point(127, 88);
            this.boxSedia.Name = "boxSedia";
            this.boxSedia.Size = new System.Drawing.Size(239, 22);
            this.boxSedia.TabIndex = 3;
            // 
            // btHitung
            // 
            this.btHitung.Location = new System.Drawing.Point(149, 159);
            this.btHitung.Name = "btHitung";
            this.btHitung.Size = new System.Drawing.Size(142, 54);
            this.btHitung.TabIndex = 4;
            this.btHitung.Text = "Hitung";
            this.btHitung.UseVisualStyleBackColor = true;
            this.btHitung.Click += new System.EventHandler(this.btHitung_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(297, 160);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(69, 53);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // boxHasil
            // 
            this.boxHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHasil.Location = new System.Drawing.Point(32, 159);
            this.boxHasil.Name = "boxHasil";
            this.boxHasil.Size = new System.Drawing.Size(100, 53);
            this.boxHasil.TabIndex = 6;
            this.boxHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sistem Penunjang Keputusan Produksi T-Shirt ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dSR);
            this.groupBox1.Controls.Add(this.dST);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dPR);
            this.groupBox1.Controls.Add(this.dPT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(32, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Penjualan Tinggi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Penjualan Rendah";
            // 
            // dPT
            // 
            this.dPT.AutoSize = true;
            this.dPT.Location = new System.Drawing.Point(154, 28);
            this.dPT.Name = "dPT";
            this.dPT.Size = new System.Drawing.Size(46, 17);
            this.dPT.TabIndex = 2;
            this.dPT.Text = "label6";
            // 
            // dPR
            // 
            this.dPR.AutoSize = true;
            this.dPR.Location = new System.Drawing.Point(154, 50);
            this.dPR.Name = "dPR";
            this.dPR.Size = new System.Drawing.Size(46, 17);
            this.dPR.TabIndex = 3;
            this.dPR.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Persediaan Tinggi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Persediaan Rendah";
            // 
            // dST
            // 
            this.dST.AutoSize = true;
            this.dST.Location = new System.Drawing.Point(154, 72);
            this.dST.Name = "dST";
            this.dST.Size = new System.Drawing.Size(46, 17);
            this.dST.TabIndex = 6;
            this.dST.Text = "label8";
            // 
            // dSR
            // 
            this.dSR.AutoSize = true;
            this.dSR.Location = new System.Drawing.Point(154, 94);
            this.dSR.Name = "dSR";
            this.dSR.Size = new System.Drawing.Size(46, 17);
            this.dSR.TabIndex = 7;
            this.dSR.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Jumlah yang harus di produksi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 486);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxHasil);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHitung);
            this.Controls.Add(this.boxSedia);
            this.Controls.Add(this.boxJual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistem Penunjang Keputusan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxJual;
        private System.Windows.Forms.TextBox boxSedia;
        private System.Windows.Forms.Button btHitung;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox boxHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dPR;
        private System.Windows.Forms.Label dPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dSR;
        private System.Windows.Forms.Label dST;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

