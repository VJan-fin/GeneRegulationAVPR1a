namespace GenskaRegulacijaAVPR1a
{
    partial class LabelDetails
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
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDetails
            // 
            this.tbDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDetails.ForeColor = System.Drawing.Color.White;
            this.tbDetails.Location = new System.Drawing.Point(10, 10);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.ReadOnly = true;
            this.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDetails.Size = new System.Drawing.Size(415, 483);
            this.tbDetails.TabIndex = 0;
            this.tbDetails.TabStop = false;
            // 
            // LabelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 503);
            this.Controls.Add(this.tbDetails);
            this.Name = "LabelDetails";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDetails;
    }
}