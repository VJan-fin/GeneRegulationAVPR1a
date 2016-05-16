namespace GenskaRegulacijaAVPR1a
{
    partial class ProteinForm
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
            this.trackBarOPressure = new System.Windows.Forms.TrackBar();
            this.trackBarPlasmaVolume = new System.Windows.Forms.TrackBar();
            this.pbGprotein = new System.Windows.Forms.PictureBox();
            this.pbArginineVasopressin = new System.Windows.Forms.PictureBox();
            this.lblBasicExplanation = new System.Windows.Forms.Label();
            this.lblProcessExplanation = new System.Windows.Forms.Label();
            this.pbProtein = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbVaprisol = new System.Windows.Forms.PictureBox();
            this.timerVasopresinToRec = new System.Windows.Forms.Timer(this.components);
            this.timerVaprisolToRec = new System.Windows.Forms.Timer(this.components);
            this.timerReceptorToGprotein = new System.Windows.Forms.Timer(this.components);
            this.toolTipMsg = new System.Windows.Forms.ToolTip(this.components);
            this.lblVaprisol = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblGprotein = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblPlasmaVolume = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblOpressure = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblArganineVasopressin = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblProtein = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.lblGeneNameProtein = new GenskaRegulacijaAVPR1a.ClickableLabel();
            this.timerVasopresinToRec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlasmaVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGprotein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArginineVasopressin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVaprisol)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarOPressure
            // 
            this.trackBarOPressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBarOPressure.Location = new System.Drawing.Point(573, 546);
            this.trackBarOPressure.Maximum = 8;
            this.trackBarOPressure.Name = "trackBarOPressure";
            this.trackBarOPressure.Size = new System.Drawing.Size(100, 45);
            this.trackBarOPressure.TabIndex = 45;
            this.trackBarOPressure.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarOPressure.Value = 4;
            // 
            // trackBarPlasmaVolume
            // 
            this.trackBarPlasmaVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackBarPlasmaVolume.Location = new System.Drawing.Point(814, 546);
            this.trackBarPlasmaVolume.Maximum = 8;
            this.trackBarPlasmaVolume.Name = "trackBarPlasmaVolume";
            this.trackBarPlasmaVolume.Size = new System.Drawing.Size(100, 45);
            this.trackBarPlasmaVolume.TabIndex = 46;
            this.trackBarPlasmaVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPlasmaVolume.Value = 4;
            // 
            // pbGprotein
            // 
            this.pbGprotein.BackColor = System.Drawing.Color.Transparent;
            this.pbGprotein.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_g_protein;
            this.pbGprotein.Location = new System.Drawing.Point(38, 134);
            this.pbGprotein.Name = "pbGprotein";
            this.pbGprotein.Size = new System.Drawing.Size(246, 500);
            this.pbGprotein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGprotein.TabIndex = 22;
            this.pbGprotein.TabStop = false;
            // 
            // pbArginineVasopressin
            // 
            this.pbArginineVasopressin.BackColor = System.Drawing.Color.Transparent;
            this.pbArginineVasopressin.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_arginine_vasopressin;
            this.pbArginineVasopressin.Location = new System.Drawing.Point(601, 305);
            this.pbArginineVasopressin.Name = "pbArginineVasopressin";
            this.pbArginineVasopressin.Size = new System.Drawing.Size(64, 46);
            this.pbArginineVasopressin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArginineVasopressin.TabIndex = 19;
            this.pbArginineVasopressin.TabStop = false;
            this.pbArginineVasopressin.Visible = false;

            // 
            // lblBasicExplanation
            // 
            this.lblBasicExplanation.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicExplanation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBasicExplanation.ForeColor = System.Drawing.Color.White;
            this.lblBasicExplanation.Location = new System.Drawing.Point(44, 65);
            this.lblBasicExplanation.Name = "lblBasicExplanation";
            this.lblBasicExplanation.Size = new System.Drawing.Size(256, 66);
            this.lblBasicExplanation.TabIndex = 49;
            this.lblBasicExplanation.Text = "За повеќе детали во врска со секој од елементите во процесот, кликнете на нивното" +
    " име.";
            // 
            // lblProcessExplanation
            // 
            this.lblProcessExplanation.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessExplanation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcessExplanation.ForeColor = System.Drawing.Color.White;
            this.lblProcessExplanation.Location = new System.Drawing.Point(384, 31);
            this.lblProcessExplanation.Name = "lblProcessExplanation";
            this.lblProcessExplanation.Size = new System.Drawing.Size(630, 219);
            this.lblProcessExplanation.TabIndex = 50;
            this.lblProcessExplanation.Text = "Објаснување на чекорите";
            // 
            // pbProtein
            // 
            this.pbProtein.BackColor = System.Drawing.Color.Transparent;
            this.pbProtein.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_avpr1a_receptor;
            this.pbProtein.Location = new System.Drawing.Point(333, 307);
            this.pbProtein.Name = "pbProtein";
            this.pbProtein.Size = new System.Drawing.Size(159, 126);
            this.pbProtein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProtein.TabIndex = 17;
            this.pbProtein.TabStop = false;
            this.pbProtein.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(779, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(198, 33);
            this.btnReset.TabIndex = 58;
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
            this.btnStop.Location = new System.Drawing.Point(779, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(198, 33);
            this.btnStop.TabIndex = 57;
            this.btnStop.Text = "Блокирај протеин";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(779, 280);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 33);
            this.btnStart.TabIndex = 56;
            this.btnStart.Text = "Активирај протеин";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbVaprisol
            // 
            this.pbVaprisol.BackColor = System.Drawing.Color.Transparent;
            this.pbVaprisol.Image = global::GenskaRegulacijaAVPR1a.Properties.Resources.res_vaprisol;
            this.pbVaprisol.Location = new System.Drawing.Point(584, 389);
            this.pbVaprisol.Name = "pbVaprisol";
            this.pbVaprisol.Size = new System.Drawing.Size(84, 65);
            this.pbVaprisol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVaprisol.TabIndex = 60;
            this.pbVaprisol.TabStop = false;
            this.pbVaprisol.Visible = false;
            // 
            // timerVasopresinToRec
            // 
            this.timerVasopresinToRec.Tick += new System.EventHandler(this.timerVasopresinToRec_Tick);
            // 
            // timerVaprisolToRec
            // 
            this.timerVaprisolToRec.Tick += new System.EventHandler(this.timerVaprisolToRec_Tick);
            // 
            // timerReceptorToGprotein
            // 
            this.timerReceptorToGprotein.Tick += new System.EventHandler(this.timerReceptorToGprotein_Tick);
            // 
            // lblVaprisol
            // 
            this.lblVaprisol.BackColor = System.Drawing.Color.Transparent;
            this.lblVaprisol.ExplanationText = null;
            this.lblVaprisol.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblVaprisol.FontSize = 0F;
            this.lblVaprisol.ForeColor = System.Drawing.Color.White;
            this.lblVaprisol.Location = new System.Drawing.Point(525, 356);
            this.lblVaprisol.Name = "lblVaprisol";
            this.lblVaprisol.Size = new System.Drawing.Size(205, 37);
            this.lblVaprisol.TabIndex = 59;
            this.lblVaprisol.Text = "Vaprisol";
            this.lblVaprisol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVaprisol.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblVaprisol.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblVaprisol.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblGprotein
            // 
            this.lblGprotein.BackColor = System.Drawing.Color.Transparent;
            this.lblGprotein.ExplanationText = null;
            this.lblGprotein.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblGprotein.FontSize = 0F;
            this.lblGprotein.ForeColor = System.Drawing.Color.White;
            this.lblGprotein.Location = new System.Drawing.Point(146, 242);
            this.lblGprotein.Name = "lblGprotein";
            this.lblGprotein.Size = new System.Drawing.Size(136, 37);
            this.lblGprotein.TabIndex = 51;
            this.lblGprotein.Text = "G протеин";
            this.lblGprotein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGprotein.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblGprotein.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblGprotein.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblPlasmaVolume
            // 
            this.lblPlasmaVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaVolume.ExplanationText = null;
            this.lblPlasmaVolume.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblPlasmaVolume.FontSize = 0F;
            this.lblPlasmaVolume.ForeColor = System.Drawing.Color.White;
            this.lblPlasmaVolume.Location = new System.Drawing.Point(775, 506);
            this.lblPlasmaVolume.Name = "lblPlasmaVolume";
            this.lblPlasmaVolume.Size = new System.Drawing.Size(202, 37);
            this.lblPlasmaVolume.TabIndex = 25;
            this.lblPlasmaVolume.Text = "Волумен на плазма";
            this.lblPlasmaVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlasmaVolume.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblPlasmaVolume.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblPlasmaVolume.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblOpressure
            // 
            this.lblOpressure.BackColor = System.Drawing.Color.Transparent;
            this.lblOpressure.ExplanationText = null;
            this.lblOpressure.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblOpressure.FontSize = 0F;
            this.lblOpressure.ForeColor = System.Drawing.Color.White;
            this.lblOpressure.Location = new System.Drawing.Point(534, 506);
            this.lblOpressure.Name = "lblOpressure";
            this.lblOpressure.Size = new System.Drawing.Size(202, 37);
            this.lblOpressure.TabIndex = 24;
            this.lblOpressure.Text = "Осмотски притисок";
            this.lblOpressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpressure.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblOpressure.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblOpressure.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblArganineVasopressin
            // 
            this.lblArganineVasopressin.BackColor = System.Drawing.Color.Transparent;
            this.lblArganineVasopressin.ExplanationText = null;
            this.lblArganineVasopressin.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblArganineVasopressin.FontSize = 0F;
            this.lblArganineVasopressin.ForeColor = System.Drawing.Color.White;
            this.lblArganineVasopressin.Location = new System.Drawing.Point(534, 267);
            this.lblArganineVasopressin.Name = "lblArganineVasopressin";
            this.lblArganineVasopressin.Size = new System.Drawing.Size(205, 37);
            this.lblArganineVasopressin.TabIndex = 20;
            this.lblArganineVasopressin.Text = "Arganine Vasopressin";
            this.lblArganineVasopressin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArganineVasopressin.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblArganineVasopressin.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblArganineVasopressin.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblProtein
            // 
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.ExplanationText = null;
            this.lblProtein.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblProtein.FontSize = 0F;
            this.lblProtein.ForeColor = System.Drawing.Color.White;
            this.lblProtein.Location = new System.Drawing.Point(329, 267);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(153, 37);
            this.lblProtein.TabIndex = 18;
            this.lblProtein.Text = "AVPR1a рецептор";
            this.lblProtein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProtein.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblProtein.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblProtein.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // lblGeneNameProtein
            // 
            this.lblGeneNameProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneNameProtein.ExplanationText = null;
            this.lblGeneNameProtein.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneNameProtein.FontSize = 0F;
            this.lblGeneNameProtein.ForeColor = System.Drawing.Color.White;
            this.lblGeneNameProtein.Location = new System.Drawing.Point(32, 26);
            this.lblGeneNameProtein.Name = "lblGeneNameProtein";
            this.lblGeneNameProtein.Size = new System.Drawing.Size(323, 29);
            this.lblGeneNameProtein.TabIndex = 16;
            this.lblGeneNameProtein.Text = "AVPR1a рецепторен протеин";
            this.lblGeneNameProtein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGeneNameProtein.Click += new System.EventHandler(this.ClickableLabel_Click);
            this.lblGeneNameProtein.MouseEnter += new System.EventHandler(this.ClickableLabel_MouseEnter);
            this.lblGeneNameProtein.MouseLeave += new System.EventHandler(this.ClickableLabel_MouseLeave);
            // 
            // ProteinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::GenskaRegulacijaAVPR1a.Properties.Resources.plasma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 629);
            this.Controls.Add(this.pbVaprisol);
            this.Controls.Add(this.lblVaprisol);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGprotein);
            this.Controls.Add(this.lblProcessExplanation);
            this.Controls.Add(this.lblBasicExplanation);
            this.Controls.Add(this.trackBarPlasmaVolume);
            this.Controls.Add(this.trackBarOPressure);
            this.Controls.Add(this.lblPlasmaVolume);
            this.Controls.Add(this.lblOpressure);
            this.Controls.Add(this.pbProtein);
            this.Controls.Add(this.pbGprotein);
            this.Controls.Add(this.lblArganineVasopressin);
            this.Controls.Add(this.pbArginineVasopressin);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblGeneNameProtein);
            this.Name = "ProteinForm";
            this.Text = "Генска регулација на AVPR1a";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlasmaVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGprotein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArginineVasopressin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVaprisol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClickableLabel lblGeneNameProtein;
        private ClickableLabel lblProtein;
        private System.Windows.Forms.PictureBox pbArginineVasopressin;
        private ClickableLabel lblArganineVasopressin;
        private System.Windows.Forms.PictureBox pbGprotein;
        private ClickableLabel lblOpressure;
        private ClickableLabel lblPlasmaVolume;
        private System.Windows.Forms.TrackBar trackBarOPressure;
        private System.Windows.Forms.TrackBar trackBarPlasmaVolume;
        private System.Windows.Forms.Label lblBasicExplanation;
        private System.Windows.Forms.Label lblProcessExplanation;
        private System.Windows.Forms.PictureBox pbProtein;
        private ClickableLabel lblGprotein;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private ClickableLabel lblVaprisol;
        private System.Windows.Forms.PictureBox pbVaprisol;
        private System.Windows.Forms.Timer timerVasopresinToRec;
        private System.Windows.Forms.Timer timerVaprisolToRec;
        private System.Windows.Forms.Timer timerReceptorToGprotein;
        private System.Windows.Forms.ToolTip toolTipMsg;
    }
}