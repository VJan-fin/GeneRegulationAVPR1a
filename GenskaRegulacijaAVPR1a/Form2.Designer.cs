namespace GenskaRegulacijaAVPR1a
{
    partial class mRNAForm
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
            this.pbMrna = new System.Windows.Forms.PictureBox();
            this.pbRibosome = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblBasicExplanation = new System.Windows.Forms.Label();
            this.lblProcessExplanation = new System.Windows.Forms.Label();
            this.timerDegrade = new System.Windows.Forms.Timer(this.components);
            this.btnStartTransl = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerTranslation = new System.Windows.Forms.Timer(this.components);
            this.timerRibosomeBinding = new System.Windows.Forms.Timer(this.components);
            this.lblRBSMark = new System.Windows.Forms.Label();
            this.lblUTR3Mark = new System.Windows.Forms.Label();
            this.btnDexPlus = new System.Windows.Forms.Button();
            this.btncortPlus = new System.Windows.Forms.Button();
            this.btnAldPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAldosterone = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblCorticosterone = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblDexamethasone = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblGlucocorticoids = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblRibosome = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblGeneNamemRNA = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.toolTipMsg = new System.Windows.Forms.ToolTip(this.components);
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblNextPhase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMrna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRibosome)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMrna
            // 
            this.pbMrna.BackColor = System.Drawing.Color.Transparent;
            this.pbMrna.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_rna_strand;
            this.pbMrna.Location = new System.Drawing.Point(247, 480);
            this.pbMrna.Name = "pbMrna";
            this.pbMrna.Size = new System.Drawing.Size(529, 47);
            this.pbMrna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMrna.TabIndex = 18;
            this.pbMrna.TabStop = false;
            this.pbMrna.Visible = false;
            this.pbMrna.Click += new System.EventHandler(this.pbMrna_Click);
            // 
            // pbRibosome
            // 
            this.pbRibosome.BackColor = System.Drawing.Color.Transparent;
            this.pbRibosome.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_ribosome;
            this.pbRibosome.Location = new System.Drawing.Point(297, 208);
            this.pbRibosome.Name = "pbRibosome";
            this.pbRibosome.Size = new System.Drawing.Size(70, 70);
            this.pbRibosome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRibosome.TabIndex = 16;
            this.pbRibosome.TabStop = false;
            this.pbRibosome.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTimer.Location = new System.Drawing.Point(94, 420);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 29);
            this.lblTimer.TabIndex = 47;
            this.lblTimer.Text = "100";
            // 
            // lblBasicExplanation
            // 
            this.lblBasicExplanation.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicExplanation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBasicExplanation.ForeColor = System.Drawing.Color.White;
            this.lblBasicExplanation.Location = new System.Drawing.Point(47, 70);
            this.lblBasicExplanation.Name = "lblBasicExplanation";
            this.lblBasicExplanation.Size = new System.Drawing.Size(256, 66);
            this.lblBasicExplanation.TabIndex = 48;
            this.lblBasicExplanation.Text = "За повеќе детали во врска со секој од елементите во процесот, кликнете на нивното" +
    " име.";
            // 
            // lblProcessExplanation
            // 
            this.lblProcessExplanation.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessExplanation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcessExplanation.ForeColor = System.Drawing.Color.White;
            this.lblProcessExplanation.Location = new System.Drawing.Point(440, 27);
            this.lblProcessExplanation.Name = "lblProcessExplanation";
            this.lblProcessExplanation.Size = new System.Drawing.Size(499, 190);
            this.lblProcessExplanation.TabIndex = 49;
            this.lblProcessExplanation.Text = "Објаснување на чекорите";
            // 
            // timerDegrade
            // 
            this.timerDegrade.Interval = 1000;
            // 
            // btnStartTransl
            // 
            this.btnStartTransl.BackColor = System.Drawing.Color.White;
            this.btnStartTransl.FlatAppearance.BorderSize = 2;
            this.btnStartTransl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTransl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTransl.Location = new System.Drawing.Point(763, 222);
            this.btnStartTransl.Name = "btnStartTransl";
            this.btnStartTransl.Size = new System.Drawing.Size(198, 33);
            this.btnStartTransl.TabIndex = 53;
            this.btnStartTransl.Text = "Поврзи";
            this.btnStartTransl.UseVisualStyleBackColor = false;
            this.btnStartTransl.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(763, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(198, 33);
            this.btnReset.TabIndex = 55;
            this.btnReset.Text = "Ресетирај";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(763, 272);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(198, 33);
            this.btnStop.TabIndex = 54;
            this.btnStop.Text = "Запри транслација";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerTranslation
            // 
            this.timerTranslation.Tick += new System.EventHandler(this.timerTranslation_Tick);
            // 
            // timerRibosomeBinding
            // 
            this.timerRibosomeBinding.Tick += new System.EventHandler(this.timerRibosomeBinding_Tick);
            // 
            // lblRBSMark
            // 
            this.lblRBSMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRBSMark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRBSMark.Location = new System.Drawing.Point(258, 480);
            this.lblRBSMark.Name = "lblRBSMark";
            this.lblRBSMark.Size = new System.Drawing.Size(45, 47);
            this.lblRBSMark.TabIndex = 56;
            this.lblRBSMark.Text = "RBS";
            this.lblRBSMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRBSMark.Visible = false;
            // 
            // lblUTR3Mark
            // 
            this.lblUTR3Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUTR3Mark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUTR3Mark.Location = new System.Drawing.Point(680, 480);
            this.lblUTR3Mark.Name = "lblUTR3Mark";
            this.lblUTR3Mark.Size = new System.Drawing.Size(84, 47);
            this.lblUTR3Mark.TabIndex = 57;
            this.lblUTR3Mark.Text = "Poly-A tail";
            this.lblUTR3Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUTR3Mark.Visible = false;
            // 
            // btnDexPlus
            // 
            this.btnDexPlus.BackColor = System.Drawing.Color.White;
            this.btnDexPlus.FlatAppearance.BorderSize = 2;
            this.btnDexPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDexPlus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDexPlus.Location = new System.Drawing.Point(175, 227);
            this.btnDexPlus.Name = "btnDexPlus";
            this.btnDexPlus.Size = new System.Drawing.Size(30, 30);
            this.btnDexPlus.TabIndex = 61;
            this.btnDexPlus.Text = "+";
            this.btnDexPlus.UseVisualStyleBackColor = false;
            this.btnDexPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btncortPlus
            // 
            this.btncortPlus.BackColor = System.Drawing.Color.White;
            this.btncortPlus.FlatAppearance.BorderSize = 2;
            this.btncortPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncortPlus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncortPlus.Location = new System.Drawing.Point(175, 264);
            this.btncortPlus.Name = "btncortPlus";
            this.btncortPlus.Size = new System.Drawing.Size(30, 30);
            this.btncortPlus.TabIndex = 62;
            this.btncortPlus.Text = "+";
            this.btncortPlus.UseVisualStyleBackColor = false;
            this.btncortPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnAldPlus
            // 
            this.btnAldPlus.BackColor = System.Drawing.Color.White;
            this.btnAldPlus.FlatAppearance.BorderSize = 2;
            this.btnAldPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAldPlus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAldPlus.Location = new System.Drawing.Point(175, 301);
            this.btnAldPlus.Name = "btnAldPlus";
            this.btnAldPlus.Size = new System.Drawing.Size(30, 30);
            this.btnAldPlus.TabIndex = 63;
            this.btnAldPlus.Text = "+";
            this.btnAldPlus.UseVisualStyleBackColor = false;
            this.btnAldPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Преостанато време";
            // 
            // lblAldosterone
            // 
            this.lblAldosterone.AutoSize = true;
            this.lblAldosterone.BackColor = System.Drawing.Color.Transparent;
            this.lblAldosterone.ExplanationText = null;
            this.lblAldosterone.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblAldosterone.FontSize = 0F;
            this.lblAldosterone.ForeColor = System.Drawing.Color.White;
            this.lblAldosterone.Location = new System.Drawing.Point(44, 310);
            this.lblAldosterone.Name = "lblAldosterone";
            this.lblAldosterone.Size = new System.Drawing.Size(85, 18);
            this.lblAldosterone.TabIndex = 43;
            this.lblAldosterone.Text = "Aldosterone";
            this.lblAldosterone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAldosterone.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblAldosterone.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblAldosterone.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblCorticosterone
            // 
            this.lblCorticosterone.AutoSize = true;
            this.lblCorticosterone.BackColor = System.Drawing.Color.Transparent;
            this.lblCorticosterone.ExplanationText = null;
            this.lblCorticosterone.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblCorticosterone.FontSize = 0F;
            this.lblCorticosterone.ForeColor = System.Drawing.Color.White;
            this.lblCorticosterone.Location = new System.Drawing.Point(44, 272);
            this.lblCorticosterone.Name = "lblCorticosterone";
            this.lblCorticosterone.Size = new System.Drawing.Size(99, 18);
            this.lblCorticosterone.TabIndex = 41;
            this.lblCorticosterone.Text = "Corticosterone";
            this.lblCorticosterone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCorticosterone.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblCorticosterone.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblCorticosterone.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblDexamethasone
            // 
            this.lblDexamethasone.AutoSize = true;
            this.lblDexamethasone.BackColor = System.Drawing.Color.Transparent;
            this.lblDexamethasone.ExplanationText = null;
            this.lblDexamethasone.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblDexamethasone.FontSize = 0F;
            this.lblDexamethasone.ForeColor = System.Drawing.Color.White;
            this.lblDexamethasone.Location = new System.Drawing.Point(44, 234);
            this.lblDexamethasone.Name = "lblDexamethasone";
            this.lblDexamethasone.Size = new System.Drawing.Size(109, 18);
            this.lblDexamethasone.TabIndex = 39;
            this.lblDexamethasone.Text = "Dexamethasone";
            this.lblDexamethasone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDexamethasone.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblDexamethasone.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblDexamethasone.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblGlucocorticoids
            // 
            this.lblGlucocorticoids.AutoSize = true;
            this.lblGlucocorticoids.BackColor = System.Drawing.Color.Transparent;
            this.lblGlucocorticoids.ExplanationText = null;
            this.lblGlucocorticoids.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGlucocorticoids.FontSize = 0F;
            this.lblGlucocorticoids.ForeColor = System.Drawing.Color.White;
            this.lblGlucocorticoids.Location = new System.Drawing.Point(43, 176);
            this.lblGlucocorticoids.Name = "lblGlucocorticoids";
            this.lblGlucocorticoids.Size = new System.Drawing.Size(150, 23);
            this.lblGlucocorticoids.TabIndex = 21;
            this.lblGlucocorticoids.Text = "Глукокортикоиди";
            this.lblGlucocorticoids.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGlucocorticoids.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblGlucocorticoids.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblGlucocorticoids.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblRibosome
            // 
            this.lblRibosome.BackColor = System.Drawing.Color.Transparent;
            this.lblRibosome.ExplanationText = null;
            this.lblRibosome.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblRibosome.FontSize = 0F;
            this.lblRibosome.ForeColor = System.Drawing.Color.White;
            this.lblRibosome.Location = new System.Drawing.Point(257, 169);
            this.lblRibosome.Name = "lblRibosome";
            this.lblRibosome.Size = new System.Drawing.Size(153, 37);
            this.lblRibosome.TabIndex = 17;
            this.lblRibosome.Text = "Рибозом";
            this.lblRibosome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRibosome.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblRibosome.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblRibosome.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblGeneNamemRNA
            // 
            this.lblGeneNamemRNA.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneNamemRNA.ExplanationText = null;
            this.lblGeneNamemRNA.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneNamemRNA.FontSize = 0F;
            this.lblGeneNamemRNA.ForeColor = System.Drawing.Color.White;
            this.lblGeneNamemRNA.Location = new System.Drawing.Point(30, 27);
            this.lblGeneNamemRNA.Name = "lblGeneNamemRNA";
            this.lblGeneNamemRNA.Size = new System.Drawing.Size(297, 29);
            this.lblGeneNamemRNA.TabIndex = 15;
            this.lblGeneNamemRNA.Text = "AVPR1a mRNA молекула";
            this.lblGeneNamemRNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGeneNamemRNA.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblGeneNamemRNA.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblGeneNamemRNA.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProtein.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblProtein.Location = new System.Drawing.Point(523, 539);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(116, 29);
            this.lblProtein.TabIndex = 65;
            this.lblProtein.Text = "+ протеин";
            this.lblProtein.Visible = false;
            this.lblProtein.Click += new System.EventHandler(this.lblProtein_Click);
            this.lblProtein.MouseEnter += new System.EventHandler(this.lblRNAQuantity_MouseEnter);
            this.lblProtein.MouseLeave += new System.EventHandler(this.lblRNAQuantity_MouseLeave);
            // 
            // lblNextPhase
            // 
            this.lblNextPhase.AutoSize = true;
            this.lblNextPhase.BackColor = System.Drawing.Color.Transparent;
            this.lblNextPhase.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNextPhase.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNextPhase.Location = new System.Drawing.Point(458, 568);
            this.lblNextPhase.Name = "lblNextPhase";
            this.lblNextPhase.Size = new System.Drawing.Size(278, 36);
            this.lblNextPhase.TabIndex = 66;
            this.lblNextPhase.Text = "Кликнете на протеинот за да продолжите \r\nво наредната фаза";
            this.lblNextPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNextPhase.Visible = false;
            // 
            // mRNAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenskaRegulacijaAVPR1a.Properties.Resources.cytosol1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.lblNextPhase);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAldPlus);
            this.Controls.Add(this.btncortPlus);
            this.Controls.Add(this.btnDexPlus);
            this.Controls.Add(this.lblUTR3Mark);
            this.Controls.Add(this.lblRBSMark);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartTransl);
            this.Controls.Add(this.lblProcessExplanation);
            this.Controls.Add(this.lblBasicExplanation);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblAldosterone);
            this.Controls.Add(this.lblCorticosterone);
            this.Controls.Add(this.lblDexamethasone);
            this.Controls.Add(this.lblGlucocorticoids);
            this.Controls.Add(this.pbMrna);
            this.Controls.Add(this.lblRibosome);
            this.Controls.Add(this.pbRibosome);
            this.Controls.Add(this.lblGeneNamemRNA);
            this.Name = "mRNAForm";
            this.Text = "Генска регулација на AVPR1a";
            ((System.ComponentModel.ISupportInitialize)(this.pbMrna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRibosome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClickableLabel lblGeneNamemRNA;
        private System.Windows.Forms.PictureBox pbRibosome;
        private ClickableLabel lblRibosome;
        private System.Windows.Forms.PictureBox pbMrna;
        private ClickableLabel lblGlucocorticoids;
        private ClickableLabel lblAldosterone;
        private ClickableLabel lblCorticosterone;
        private ClickableLabel lblDexamethasone;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblBasicExplanation;
        private System.Windows.Forms.Label lblProcessExplanation;
        private System.Windows.Forms.Timer timerDegrade;
        private System.Windows.Forms.Button btnStartTransl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerTranslation;
        private System.Windows.Forms.Timer timerRibosomeBinding;
        private System.Windows.Forms.Label lblRBSMark;
        private System.Windows.Forms.Label lblUTR3Mark;
        private System.Windows.Forms.Button btnDexPlus;
        private System.Windows.Forms.Button btncortPlus;
        private System.Windows.Forms.Button btnAldPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipMsg;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblNextPhase;
    }
}