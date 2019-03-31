namespace HomeFinance
{
    partial class frmBaseFechar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseFechar));
            this.toolStripForm = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripForm
            // 
            this.toolStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnFechar});
            this.toolStripForm.Location = new System.Drawing.Point(0, 0);
            this.toolStripForm.Name = "toolStripForm";
            this.toolStripForm.Size = new System.Drawing.Size(800, 25);
            this.toolStripForm.TabIndex = 0;
            this.toolStripForm.Text = "toolStrip1";
            // 
            // toolStripBtnFechar
            // 
            this.toolStripBtnFechar.Image = global::HomeFinance.Properties.Resources.error;
            this.toolStripBtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFechar.Name = "toolStripBtnFechar";
            this.toolStripBtnFechar.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnFechar.Text = "Fechar";
            this.toolStripBtnFechar.Click += new System.EventHandler(this.toolStripBtnFechar_Click);
            // 
            // frmBaseFechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseFechar";
            this.Text = "frmBaseFechar";
            this.toolStripForm.ResumeLayout(false);
            this.toolStripForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripForm;
        private System.Windows.Forms.ToolStripButton toolStripBtnFechar;
    }
}