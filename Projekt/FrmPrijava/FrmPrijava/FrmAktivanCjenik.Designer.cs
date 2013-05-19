namespace FrmPrijava
{
    partial class FrmAktivanCjenik
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
            this.dgvAktivanCjenik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivanCjenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktivanCjenik
            // 
            this.dgvAktivanCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivanCjenik.Location = new System.Drawing.Point(47, 30);
            this.dgvAktivanCjenik.Name = "dgvAktivanCjenik";
            this.dgvAktivanCjenik.Size = new System.Drawing.Size(464, 226);
            this.dgvAktivanCjenik.TabIndex = 0;
            // 
            // FrmAktivanCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.dgvAktivanCjenik);
            this.Name = "FrmAktivanCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivan cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivanCjenik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivanCjenik;
    }
}