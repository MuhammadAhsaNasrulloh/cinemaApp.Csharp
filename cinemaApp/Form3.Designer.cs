namespace cinemaApp
{
    partial class HomePage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNamaTiket = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Umur";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VVIP",
            "VIP",
            "Reguler"});
            this.comboBox1.Location = new System.Drawing.Point(132, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // txtNamaTiket
            // 
            this.txtNamaTiket.Location = new System.Drawing.Point(132, 119);
            this.txtNamaTiket.Name = "txtNamaTiket";
            this.txtNamaTiket.Size = new System.Drawing.Size(100, 22);
            this.txtNamaTiket.TabIndex = 5;
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(132, 179);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(100, 22);
            this.txtUmur.TabIndex = 6;
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(364, 119);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(100, 22);
            this.txtBayar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Film";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "VVIP",
            "VIP",
            "Reguler"});
            this.comboBox2.Location = new System.Drawing.Point(364, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(367, 232);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(79, 35);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtNamaTiket);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNamaTiket;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnOrder;
    }
}