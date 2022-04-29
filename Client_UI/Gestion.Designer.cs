namespace Client_UI
{
    partial class Gestion
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
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_saldo_actual = new System.Windows.Forms.TextBox();
            this.btn_realizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que tipo de transaccion desea realizar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Abono",
            "Retiro"});
            this.cb_tipo.Location = new System.Drawing.Point(317, 117);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 23);
            this.cb_tipo.TabIndex = 1;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(338, 198);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 23);
            this.txt_monto.TabIndex = 2;
           // this.txt_monto.TextChanged += new System.EventHandler(this.txt_monto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(575, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo Actual:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_saldo_actual
            // 
            this.txt_saldo_actual.Location = new System.Drawing.Point(709, 18);
            this.txt_saldo_actual.Name = "txt_saldo_actual";
            this.txt_saldo_actual.Size = new System.Drawing.Size(79, 23);
            this.txt_saldo_actual.TabIndex = 5;
            // 
            // btn_realizar
            // 
            this.btn_realizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_realizar.Location = new System.Drawing.Point(352, 276);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(86, 42);
            this.btn_realizar.TabIndex = 6;
            this.btn_realizar.Text = "REALIZAR";
            this.btn_realizar.UseVisualStyleBackColor = true;
            this.btn_realizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_realizar);
            this.Controls.Add(this.txt_saldo_actual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.label1);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cb_tipo;
        private TextBox txt_monto;
        private Label label2;
        private Label label3;
        private TextBox txt_saldo_actual;
        private Button btn_realizar;
    }
}