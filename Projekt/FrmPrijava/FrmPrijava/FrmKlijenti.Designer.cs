﻿namespace FrmPrijava
{
    partial class FrmKlijenti
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.dgvPregledKlijenata = new System.Windows.Forms.DataGridView();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnZensko = new System.Windows.Forms.RadioButton();
            this.rbtnMusko = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKlijenata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Spol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(131, 156);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(152, 20);
            this.txtPrezime.TabIndex = 29;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(131, 130);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(152, 20);
            this.txtIme.TabIndex = 28;
            // 
            // dgvPregledKlijenata
            // 
            this.dgvPregledKlijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledKlijenata.Location = new System.Drawing.Point(43, 24);
            this.dgvPregledKlijenata.Name = "dgvPregledKlijenata";
            this.dgvPregledKlijenata.Size = new System.Drawing.Size(472, 90);
            this.dgvPregledKlijenata.TabIndex = 27;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(131, 249);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(121, 20);
            this.btnUnesi.TabIndex = 26;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime";
            // 
            // rbtnZensko
            // 
            this.rbtnZensko.AutoSize = true;
            this.rbtnZensko.Location = new System.Drawing.Point(131, 182);
            this.rbtnZensko.Name = "rbtnZensko";
            this.rbtnZensko.Size = new System.Drawing.Size(32, 17);
            this.rbtnZensko.TabIndex = 36;
            this.rbtnZensko.TabStop = true;
            this.rbtnZensko.Text = "Ž";
            this.rbtnZensko.UseVisualStyleBackColor = true;
            // 
            // rbtnMusko
            // 
            this.rbtnMusko.AutoSize = true;
            this.rbtnMusko.Location = new System.Drawing.Point(177, 182);
            this.rbtnMusko.Name = "rbtnMusko";
            this.rbtnMusko.Size = new System.Drawing.Size(34, 17);
            this.rbtnMusko.TabIndex = 37;
            this.rbtnMusko.TabStop = true;
            this.rbtnMusko.Text = "M";
            this.rbtnMusko.UseVisualStyleBackColor = true;
            // 
            // FrmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.rbtnMusko);
            this.Controls.Add(this.rbtnZensko);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvPregledKlijenata);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Name = "FrmKlijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledKlijenata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.DataGridView dgvPregledKlijenata;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnZensko;
        private System.Windows.Forms.RadioButton rbtnMusko;
    }
}