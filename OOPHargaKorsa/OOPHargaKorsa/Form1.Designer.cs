
namespace OOPHargaKorsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtJumlahItem = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblHarga = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTitikBordir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBahan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJumlahItem
            // 
            this.txtJumlahItem.Location = new System.Drawing.Point(168, 123);
            this.txtJumlahItem.Name = "txtJumlahItem";
            this.txtJumlahItem.Size = new System.Drawing.Size(225, 20);
            this.txtJumlahItem.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(258, 234);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(135, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check It Out!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(165, 268);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(25, 13);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jumlah Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jumlah Titik Bordir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estimasi Harga";
            // 
            // cmbTitikBordir
            // 
            this.cmbTitikBordir.DisplayMember = "3";
            this.cmbTitikBordir.FormattingEnabled = true;
            this.cmbTitikBordir.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbTitikBordir.Location = new System.Drawing.Point(168, 152);
            this.cmbTitikBordir.Name = "cmbTitikBordir";
            this.cmbTitikBordir.Size = new System.Drawing.Size(121, 21);
            this.cmbTitikBordir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bahan";
            // 
            // cmbBahan
            // 
            this.cmbBahan.FormattingEnabled = true;
            this.cmbBahan.Items.AddRange(new object[] {
            "Nagata",
            "American"});
            this.cmbBahan.Location = new System.Drawing.Point(168, 182);
            this.cmbBahan.Name = "cmbBahan";
            this.cmbBahan.Size = new System.Drawing.Size(121, 21);
            this.cmbBahan.TabIndex = 11;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(168, 313);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 360);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbBahan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTitikBordir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtJumlahItem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJumlahItem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTitikBordir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBahan;
        private System.Windows.Forms.Button btnOrder;
    }
}

