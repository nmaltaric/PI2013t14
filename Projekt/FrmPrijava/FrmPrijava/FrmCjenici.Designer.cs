namespace FrmPrijava
{
    partial class FrmKreirajCjenik
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
            this.dgvPregledUsluga = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPohraniCjenik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziCjenike = new System.Windows.Forms.Button();
            this.rbtnAktivan = new System.Windows.Forms.RadioButton();
            this.rbtnNeaktivan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledUsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledUsluga
            // 
            this.dgvPregledUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledUsluga.Location = new System.Drawing.Point(40, 56);
            this.dgvPregledUsluga.Name = "dgvPregledUsluga";
            this.dgvPregledUsluga.Size = new System.Drawing.Size(472, 90);
            this.dgvPregledUsluga.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pregled usluga (stavke cjenika)";
            // 
            // btnPohraniCjenik
            // 
            this.btnPohraniCjenik.Location = new System.Drawing.Point(40, 209);
            this.btnPohraniCjenik.Name = "btnPohraniCjenik";
            this.btnPohraniCjenik.Size = new System.Drawing.Size(102, 31);
            this.btnPohraniCjenik.TabIndex = 29;
            this.btnPohraniCjenik.Text = "Pohrani cjenik";
            this.btnPohraniCjenik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Datum kreiranja";
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(124, 169);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(133, 20);
            this.dtpDatumKreiranja.TabIndex = 32;
            // 
            // btnPrikaziCjenike
            // 
            this.btnPrikaziCjenike.Location = new System.Drawing.Point(155, 209);
            this.btnPrikaziCjenike.Name = "btnPrikaziCjenike";
            this.btnPrikaziCjenike.Size = new System.Drawing.Size(102, 31);
            this.btnPrikaziCjenike.TabIndex = 33;
            this.btnPrikaziCjenike.Text = "Prikaži cjenike";
            this.btnPrikaziCjenike.UseVisualStyleBackColor = true;
            this.btnPrikaziCjenike.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnAktivan
            // 
            this.rbtnAktivan.AutoSize = true;
            this.rbtnAktivan.Location = new System.Drawing.Point(306, 172);
            this.rbtnAktivan.Name = "rbtnAktivan";
            this.rbtnAktivan.Size = new System.Drawing.Size(61, 17);
            this.rbtnAktivan.TabIndex = 36;
            this.rbtnAktivan.TabStop = true;
            this.rbtnAktivan.Text = "Aktivan";
            this.rbtnAktivan.UseVisualStyleBackColor = true;
            // 
            // rbtnNeaktivan
            // 
            this.rbtnNeaktivan.AutoSize = true;
            this.rbtnNeaktivan.Location = new System.Drawing.Point(387, 171);
            this.rbtnNeaktivan.Name = "rbtnNeaktivan";
            this.rbtnNeaktivan.Size = new System.Drawing.Size(74, 17);
            this.rbtnNeaktivan.TabIndex = 37;
            this.rbtnNeaktivan.TabStop = true;
            this.rbtnNeaktivan.Text = "Neaktivan";
            this.rbtnNeaktivan.UseVisualStyleBackColor = true;
            // 
            // FrmKreirajCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.rbtnNeaktivan);
            this.Controls.Add(this.rbtnAktivan);
            this.Controls.Add(this.btnPrikaziCjenike);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPohraniCjenik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPregledUsluga);
            this.Name = "FrmKreirajCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledUsluga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledUsluga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPohraniCjenik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.Button btnPrikaziCjenike;
        private System.Windows.Forms.RadioButton rbtnAktivan;
        private System.Windows.Forms.RadioButton rbtnNeaktivan;
    }
}