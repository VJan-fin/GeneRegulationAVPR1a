namespace GenskaRegulacijaAVPR1a
{
    partial class NucleusForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTSSMark = new System.Windows.Forms.Label();
            this.lblUTR5Mark = new System.Windows.Forms.Label();
            this.lblUTR3Mark = new System.Windows.Forms.Label();
            this.lblExon2Mark = new System.Windows.Forms.Label();
            this.lblExon1Mark = new System.Windows.Forms.Label();
            this.lblIntron1Mark = new System.Windows.Forms.Label();
            this.lblTATAMark = new System.Windows.Forms.Label();
            this.lblPromotorMark = new System.Windows.Forms.Label();
            this.pbDNA1 = new System.Windows.Forms.PictureBox();
            this.pbDNA2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbRNAPolymerase = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timePolymerase = new System.Windows.Forms.Timer(this.components);
            this.lblRNAPolymerase = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblGeneName = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblTATA = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lbl5UTR = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lbl3UTR = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblTSS = new GenskaRegulacijaAVPR1a.ClickableLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRNAPolymerase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTSSMark
            // 
            this.lblTSSMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTSSMark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTSSMark.Location = new System.Drawing.Point(403, 491);
            this.lblTSSMark.Name = "lblTSSMark";
            this.lblTSSMark.Size = new System.Drawing.Size(30, 47);
            this.lblTSSMark.TabIndex = 3;
            this.lblTSSMark.Text = "TSS";
            this.lblTSSMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTSSMark.Visible = false;
            // 
            // lblUTR5Mark
            // 
            this.lblUTR5Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUTR5Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUTR5Mark.Location = new System.Drawing.Point(473, 488);
            this.lblUTR5Mark.Name = "lblUTR5Mark";
            this.lblUTR5Mark.Size = new System.Drawing.Size(80, 47);
            this.lblUTR5Mark.TabIndex = 4;
            this.lblUTR5Mark.Text = "5\' UTR";
            this.lblUTR5Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUTR5Mark.Visible = false;
            // 
            // lblUTR3Mark
            // 
            this.lblUTR3Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUTR3Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUTR3Mark.Location = new System.Drawing.Point(805, 488);
            this.lblUTR3Mark.Name = "lblUTR3Mark";
            this.lblUTR3Mark.Size = new System.Drawing.Size(120, 47);
            this.lblUTR3Mark.TabIndex = 5;
            this.lblUTR3Mark.Text = "3\' UTR";
            this.lblUTR3Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUTR3Mark.Visible = false;
            // 
            // lblExon2Mark
            // 
            this.lblExon2Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblExon2Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExon2Mark.Location = new System.Drawing.Point(744, 488);
            this.lblExon2Mark.Name = "lblExon2Mark";
            this.lblExon2Mark.Size = new System.Drawing.Size(55, 47);
            this.lblExon2Mark.TabIndex = 6;
            this.lblExon2Mark.Text = "Егзон 2";
            this.lblExon2Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExon2Mark.Visible = false;
            // 
            // lblExon1Mark
            // 
            this.lblExon1Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblExon1Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExon1Mark.Location = new System.Drawing.Point(557, 488);
            this.lblExon1Mark.Name = "lblExon1Mark";
            this.lblExon1Mark.Size = new System.Drawing.Size(80, 47);
            this.lblExon1Mark.TabIndex = 7;
            this.lblExon1Mark.Text = "Егзон 1";
            this.lblExon1Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExon1Mark.Visible = false;
            // 
            // lblIntron1Mark
            // 
            this.lblIntron1Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblIntron1Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIntron1Mark.Location = new System.Drawing.Point(643, 488);
            this.lblIntron1Mark.Name = "lblIntron1Mark";
            this.lblIntron1Mark.Size = new System.Drawing.Size(95, 47);
            this.lblIntron1Mark.TabIndex = 8;
            this.lblIntron1Mark.Text = "Интрон 1";
            this.lblIntron1Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntron1Mark.Visible = false;
            // 
            // lblTATAMark
            // 
            this.lblTATAMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTATAMark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTATAMark.Location = new System.Drawing.Point(301, 491);
            this.lblTATAMark.Name = "lblTATAMark";
            this.lblTATAMark.Size = new System.Drawing.Size(40, 47);
            this.lblTATAMark.TabIndex = 11;
            this.lblTATAMark.Text = "ТАТА";
            this.lblTATAMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTATAMark.Visible = false;
            // 
            // lblPromotorMark
            // 
            this.lblPromotorMark.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPromotorMark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPromotorMark.Location = new System.Drawing.Point(106, 491);
            this.lblPromotorMark.Name = "lblPromotorMark";
            this.lblPromotorMark.Size = new System.Drawing.Size(138, 47);
            this.lblPromotorMark.TabIndex = 13;
            this.lblPromotorMark.Text = "Близок промотор";
            this.lblPromotorMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPromotorMark.Visible = false;
            // 
            // pbDNA1
            // 
            this.pbDNA1.BackColor = System.Drawing.Color.Transparent;
            this.pbDNA1.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.dna_strand;
            this.pbDNA1.Location = new System.Drawing.Point(-5, 491);
            this.pbDNA1.Name = "pbDNA1";
            this.pbDNA1.Size = new System.Drawing.Size(529, 47);
            this.pbDNA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNA1.TabIndex = 1;
            this.pbDNA1.TabStop = false;
            this.pbDNA1.Visible = false;
            // 
            // pbDNA2
            // 
            this.pbDNA2.BackColor = System.Drawing.Color.Transparent;
            this.pbDNA2.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.dna_strand;
            this.pbDNA2.Location = new System.Drawing.Point(523, 488);
            this.pbDNA2.Name = "pbDNA2";
            this.pbDNA2.Size = new System.Drawing.Size(467, 47);
            this.pbDNA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNA2.TabIndex = 0;
            this.pbDNA2.TabStop = false;
            this.pbDNA2.Visible = false;
            // 
            // pbRNAPolymerase
            // 
            this.pbRNAPolymerase.BackColor = System.Drawing.Color.Transparent;
            this.pbRNAPolymerase.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.RNA_pol_II;
            this.pbRNAPolymerase.Location = new System.Drawing.Point(496, 64);
            this.pbRNAPolymerase.Name = "pbRNAPolymerase";
            this.pbRNAPolymerase.Size = new System.Drawing.Size(70, 55);
            this.pbRNAPolymerase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRNAPolymerase.TabIndex = 15;
            this.pbRNAPolymerase.TabStop = false;
            this.pbRNAPolymerase.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(747, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 49);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Започни транскрипција";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(747, 356);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(203, 49);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Запри транскрипција";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timePolymerase
            // 
            this.timePolymerase.Interval = 20;
            this.timePolymerase.Tick += new System.EventHandler(this.timePolymerase_Tick);
            // 
            // lblRNAPolymerase
            // 
            this.lblRNAPolymerase.BackColor = System.Drawing.Color.Transparent;
            this.lblRNAPolymerase.ExplanationText = null;
            this.lblRNAPolymerase.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblRNAPolymerase.FontSize = 0F;
            this.lblRNAPolymerase.ForeColor = System.Drawing.Color.White;
            this.lblRNAPolymerase.Location = new System.Drawing.Point(463, 24);
            this.lblRNAPolymerase.Name = "lblRNAPolymerase";
            this.lblRNAPolymerase.Size = new System.Drawing.Size(153, 37);
            this.lblRNAPolymerase.TabIndex = 16;
            this.lblRNAPolymerase.Text = "RNA полимераза";
            this.lblRNAPolymerase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRNAPolymerase.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblRNAPolymerase.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblRNAPolymerase.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblGeneName
            // 
            this.lblGeneName.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneName.ExplanationText = null;
            this.lblGeneName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneName.FontSize = 0F;
            this.lblGeneName.ForeColor = System.Drawing.Color.White;
            this.lblGeneName.Location = new System.Drawing.Point(32, 26);
            this.lblGeneName.Name = "lblGeneName";
            this.lblGeneName.Size = new System.Drawing.Size(131, 29);
            this.lblGeneName.TabIndex = 14;
            this.lblGeneName.Text = "AVPR1a ген";
            this.lblGeneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGeneName.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblGeneName.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblGeneName.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblTATA
            // 
            this.lblTATA.BackColor = System.Drawing.Color.Transparent;
            this.lblTATA.ExplanationText = null;
            this.lblTATA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTATA.FontSize = 0F;
            this.lblTATA.ForeColor = System.Drawing.Color.White;
            this.lblTATA.Location = new System.Drawing.Point(277, 538);
            this.lblTATA.Name = "lblTATA";
            this.lblTATA.Size = new System.Drawing.Size(88, 38);
            this.lblTATA.TabIndex = 12;
            this.lblTATA.Text = "Основен промотор";
            this.lblTATA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTATA.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblTATA.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblTATA.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lbl5UTR
            // 
            this.lbl5UTR.BackColor = System.Drawing.Color.Transparent;
            this.lbl5UTR.ExplanationText = null;
            this.lbl5UTR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5UTR.FontSize = 0F;
            this.lbl5UTR.ForeColor = System.Drawing.Color.White;
            this.lbl5UTR.Location = new System.Drawing.Point(464, 540);
            this.lbl5UTR.Name = "lbl5UTR";
            this.lbl5UTR.Size = new System.Drawing.Size(102, 38);
            this.lbl5UTR.TabIndex = 10;
            this.lbl5UTR.Text = "Нетранслиран регион";
            this.lbl5UTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5UTR.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lbl5UTR.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lbl5UTR.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lbl3UTR
            // 
            this.lbl3UTR.BackColor = System.Drawing.Color.Transparent;
            this.lbl3UTR.ExplanationText = null;
            this.lbl3UTR.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3UTR.FontSize = 0F;
            this.lbl3UTR.ForeColor = System.Drawing.Color.White;
            this.lbl3UTR.Location = new System.Drawing.Point(812, 538);
            this.lbl3UTR.Name = "lbl3UTR";
            this.lbl3UTR.Size = new System.Drawing.Size(102, 38);
            this.lbl3UTR.TabIndex = 9;
            this.lbl3UTR.Text = "Нетранслиран регион";
            this.lbl3UTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3UTR.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lbl3UTR.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lbl3UTR.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblTSS
            // 
            this.lblTSS.BackColor = System.Drawing.Color.Transparent;
            this.lblTSS.ExplanationText = null;
            this.lblTSS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTSS.FontSize = 0F;
            this.lblTSS.ForeColor = System.Drawing.Color.White;
            this.lblTSS.Location = new System.Drawing.Point(365, 540);
            this.lblTSS.Name = "lblTSS";
            this.lblTSS.Size = new System.Drawing.Size(102, 64);
            this.lblTSS.TabIndex = 2;
            this.lblTSS.Text = "Почетно место на транскрипција";
            this.lblTSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTSS.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblTSS.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblTSS.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // NucleusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenskaRegulacijaAVPR1a.Properties.Resources.dna_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRNAPolymerase);
            this.Controls.Add(this.pbRNAPolymerase);
            this.Controls.Add(this.lblGeneName);
            this.Controls.Add(this.lblPromotorMark);
            this.Controls.Add(this.lblTATA);
            this.Controls.Add(this.lblTATAMark);
            this.Controls.Add(this.lbl5UTR);
            this.Controls.Add(this.lbl3UTR);
            this.Controls.Add(this.lblIntron1Mark);
            this.Controls.Add(this.lblExon1Mark);
            this.Controls.Add(this.lblExon2Mark);
            this.Controls.Add(this.lblUTR3Mark);
            this.Controls.Add(this.lblUTR5Mark);
            this.Controls.Add(this.lblTSSMark);
            this.Controls.Add(this.lblTSS);
            this.Controls.Add(this.pbDNA1);
            this.Controls.Add(this.pbDNA2);
            this.Name = "NucleusForm";
            this.Text = "Генска регулација на AVPR1a";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NucleusForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbDNA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRNAPolymerase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDNA2;
        private System.Windows.Forms.PictureBox pbDNA1;
        private ClickableLabel lblTSS;
        private System.Windows.Forms.Label lblTSSMark;
        private System.Windows.Forms.Label lblUTR5Mark;
        private System.Windows.Forms.Label lblUTR3Mark;
        private System.Windows.Forms.Label lblExon2Mark;
        private System.Windows.Forms.Label lblExon1Mark;
        private System.Windows.Forms.Label lblIntron1Mark;
        private ClickableLabel lbl3UTR;
        private ClickableLabel lbl5UTR;
        private System.Windows.Forms.Label lblTATAMark;
        private ClickableLabel lblTATA;
        private System.Windows.Forms.Label lblPromotorMark;
        private System.Windows.Forms.ToolTip toolTip1;
        private ClickableLabel lblGeneName;
        private System.Windows.Forms.PictureBox pbRNAPolymerase;
        private ClickableLabel lblRNAPolymerase;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timePolymerase;
    }
}

