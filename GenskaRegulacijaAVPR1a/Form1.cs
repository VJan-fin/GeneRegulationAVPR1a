using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenskaRegulacijaAVPR1a
{
    public partial class NucleusForm : Form
    {
        private static string tooltipMessage = "Кликни за повеќе информации";

        public RNAPolymerase rnaPolymerase { get; set; }
        public Dictionary<string, TransciptionFactor> TFs { get; set; }

        public NucleusForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadComponents();
            FillTexts();
            setScreenLayout();

            this.timeMoleculeBinding.Interval = this.timeRNATranscription.Interval = (int)this.rnaPolymerase.Speed;
        }

        public void setScreenLayout()
        {
            LoadTranscriptionFactors();

            this.rnaPolymerase = new RNAPolymerase("РНК полимераза", "Објаснување за полимеразата", true, 120,
                new Point(586, 64),
                new Point(this.lblTSSMark.Location.X - 30, this.lblTSSMark.Location.Y - 10),
                new Point(this.lblUTR3Mark.Location.X + this.lblUTR3Mark.Width, this.lblUTR3Mark.Location.Y - 10));
        }

        public void LoadComponents()
        {
            // Animation control buttons
            this.btnStart.BackColor = this.btnStop.BackColor = this.btnReset.BackColor = Color.FromArgb(255, 139, 146, 174);
            this.btnStart.FlatAppearance.BorderColor = this.btnStop.FlatAppearance.BorderColor = this.btnReset.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 85, 108);
            this.btnStart.FlatAppearance.BorderSize = this.btnStop.FlatAppearance.BorderSize = this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnStart.ForeColor = this.btnStop.ForeColor = this.btnReset.ForeColor = Color.White;


            // Necessary for proper and consistent change during mouse over
            this.lblTATA.FontSize = this.lblTSS.FontSize = this.lbl3UTR.FontSize = this.lbl5UTR.FontSize = 11;
            this.lblGeneName.FontSize = 18;
            this.lblRNAPolymerase.FontSize = this.lblTF.FontSize = this.lblSmallMolecules.FontSize = 14;
            this.lblRP58.FontSize = this.lblXBP1.FontSize = this.lblE2F1.FontSize = this.lblCLOCK.FontSize = this.lblTRIM28.FontSize = 11;
            this.lblDiclofenamide.FontSize = this.lblLincomycin.FontSize = this.lblProcaine.FontSize = this.lblTroglitazone.FontSize = 11;


            // Setting a tooltip message that labels contain more details on click
            toolTip1.SetToolTip(this.lblTATA, tooltipMessage);
            toolTip1.SetToolTip(this.lblTSS, tooltipMessage);
            toolTip1.SetToolTip(this.lbl3UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lbl5UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lblGeneName, tooltipMessage);
            toolTip1.SetToolTip(this.lblRNAPolymerase, tooltipMessage);
            toolTip1.SetToolTip(this.lblTF, tooltipMessage);
            toolTip1.SetToolTip(this.lblSmallMolecules, tooltipMessage);

            toolTip1.SetToolTip(this.lblRP58, tooltipMessage);
            toolTip1.SetToolTip(this.lblXBP1, tooltipMessage);
            toolTip1.SetToolTip(this.lblE2F1, tooltipMessage);
            toolTip1.SetToolTip(this.lblCLOCK, tooltipMessage);
            toolTip1.SetToolTip(this.lblTRIM28, tooltipMessage);

            toolTip1.SetToolTip(this.lblDiclofenamide, tooltipMessage);
            toolTip1.SetToolTip(this.lblLincomycin, tooltipMessage);
            toolTip1.SetToolTip(this.lblProcaine, tooltipMessage);
            toolTip1.SetToolTip(this.lblTroglitazone, tooltipMessage);
        }

        private void FillTexts()
        {
            this.lblTATA.ExplanationText = "This is a sample text";
            this.lblTSS.ExplanationText = "ClickableLabel sample text";
            this.lbl5UTR.ExplanationText = this.lbl3UTR.ExplanationText = "Пример објаснување за нетранслираниот регион";

            this.lblGeneName.ExplanationText = "Детали за генот";
            this.lblRNAPolymerase.ExplanationText = "Детали за полимеразата";
            this.lblTF.ExplanationText = "Детали за транскрипциските фактори";
            this.lblSmallMolecules.ExplanationText = "Детали за малите молекули";

            this.lblRP58.ExplanationText = "Репресор";
            this.lblXBP1.ExplanationText = "Активатор";
            this.lblE2F1.ExplanationText = "Активатор";
            this.lblCLOCK.ExplanationText = "Активатор";
            this.lblTRIM28.ExplanationText = "Репресор";
        }

        public void LoadTranscriptionFactors()
        {
            float bindingSpeed = 120;
            this.TFs = new Dictionary<string, TransciptionFactor>();

            this.TFs.Add(this.cbRP58.Name, new TransciptionFactor("RP58", "", cbRP58.Checked, bindingSpeed, new Point(50, 320), -1, new Point(125, 507), Color.PaleVioletRed, 19));
            this.TFs.Add(this.cbXBP1.Name, new TransciptionFactor("XBP-1", "", cbXBP1.Checked, bindingSpeed, new Point(105, 320), 1, new Point(138, 502), Color.LemonChiffon, 22));
            this.TFs.Add(this.cbE2F1.Name, new TransciptionFactor("E2F-1", "", cbE2F1.Checked, bindingSpeed, new Point(160, 320), 1, new Point(166, 512), Color.LightBlue, 19));
            this.TFs.Add(this.cbCLOCK.Name, new TransciptionFactor("CLOCK", "", cbCLOCK.Checked, bindingSpeed, new Point(210, 320), 1, new Point(183, 517), Color.Lavender, 21));
            this.TFs.Add(this.cbTRIM28.Name, new TransciptionFactor("TRIM28", "", cbTRIM28.Checked, bindingSpeed, new Point(270, 320), -1, new Point(208, 509), Color.Khaki, 25));
        
        }

        /**
         * Draws the two DNA strands in the bottom of the screen
         */
        private void drawDNAStrand(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.dna_strand);
            g.DrawImage(bitmap, -5, 491, 529, 47);
            g.DrawImage(bitmap, 523, 488, 467, 47);
        }

        /**
         * Draws the labels for the different regions on the DNA strand
         */
        private void drawDNARegions(Graphics g)
        {
            SolidBrush brush;
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));
            Control control;
            Font labels = new Font("Calibri", (float)11.5, FontStyle.Bold);
            PointF textLocation;
            int alphaValue = 190;

            // Proximal promotor
            brush = new SolidBrush(Color.FromArgb(alphaValue, Color.DarkSeaGreen)); // RGB(143, 188, 143)
            control = this.lblPromotorMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 10, control.Location.Y + control.Height / 3);
            g.DrawString("Близок промотор", labels, textBrush, textLocation);
        
            // TATA box
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 255));
            control = this.lblTATAMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 12, control.Location.Y + control.Height / 3);
            g.DrawString("TATA", labels, textBrush, textLocation);

            // Transcription Start Site (TSS)
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 255, 192));
            control = this.lblTSSMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 10, control.Location.Y + control.Height / 3);
            g.DrawString("TSS", labels, textBrush, textLocation);

            // Untranslated region 5'
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 128));
            control = this.lblUTR5Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 4, control.Location.Y + control.Height / 3);
            g.DrawString("5' UTR", labels, textBrush, textLocation);

            // Exon 1
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 192, 255));
            control = this.lblExon1Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 5, control.Location.Y + control.Height / 3);
            g.DrawString("Егзон 1", labels, textBrush, textLocation);

            // Intron 1
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 128, 128));
            control = this.lblIntron1Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 5, control.Location.Y + control.Height / 3);
            g.DrawString("Интрон 1", labels, textBrush, textLocation);

            // Exon 2
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 192, 255));
            control = this.lblExon2Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 12, control.Location.Y + control.Height / 3);
            g.DrawString("Егзон 2", labels, textBrush, textLocation);

            // Untranslated region 3'
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 128));
            control = this.lblUTR3Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 4, control.Location.Y + control.Height / 3);
            g.DrawString("3' UTR", labels, textBrush, textLocation);
        
        }

        /**
         * Returns true if the transcription of the gene can begin,
         * false otherwise
         */
        private bool checkInfluence()
        {
            List<TransciptionFactor> tmp = new List<TransciptionFactor>(this.TFs.Values.Where<TransciptionFactor>(x => x.Visibility && x.IsAttached));
            if (tmp.Count == 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи нема транскрипциски фактори поврзани за промоторот");
                return false;
            }

            int influence = 0;
            foreach (var item in tmp)
            {
                influence += item.Influence;
            }

            if (influence == 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи нема доволно активатори кои придонесуваат со своето позитивно влијание");
                return false;
            }
            else if (influence < 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи има повеќе репресори отколку активатори на промотор секвенцата. Овие репресори ја спречуваат експресијата на генот.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClickableLabel_Click(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.showExplanation();
        }

        private void ClickableLabel_MouseEnter(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.ForeColor = ClickableLabel.FocusTextColour;
            customLabel.Font = new Font("Calibri", customLabel.FontSize, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
        }

        private void ClickableLabel_MouseLeave(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.ForeColor = ClickableLabel.NormalTextColour;
            customLabel.Font = new Font("Calibri", customLabel.FontSize, FontStyle.Regular);
            this.Cursor = Cursors.Default;
        }

        private void timeMoleculeBinding_Tick(object sender, EventArgs e)
        {
            this.rnaPolymerase.move();
            if (this.rnaPolymerase.IsAttached)
            {
                this.btnStart.Text = "Започни транскрипција";
                this.btnStart.Enabled = true;
                this.rnaPolymerase.IsMoving = false;
                this.timeMoleculeBinding.Stop();
            }

            foreach (var item in this.TFs.Values)
            {
                item.move();
            }
            Invalidate();
        }

        private void timeRNATranscription_Tick(object sender, EventArgs e)
        {
            this.rnaPolymerase.move();
            if (this.rnaPolymerase.CurrentPosition == this.rnaPolymerase.InitialPosition)
            {
                this.btnStart.Text = "Поврзи";
                this.btnStart.Enabled = true;
                this.timeRNATranscription.Stop();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.drawDNAStrand(e.Graphics);
            this.drawDNARegions(e.Graphics);

            this.rnaPolymerase.Draw(e.Graphics);
            foreach (var item in this.TFs.Values)
            {
                item.Draw(e.Graphics);
            }
        }

        private void NucleusForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Поврзи")
            {
                this.timeMoleculeBinding.Start();
                btn.Enabled = false;
                this.rnaPolymerase.IsMoving = true;
                foreach (var item in this.TFs.Values)
                {
                    item.IsMoving = true;
                }
            }
            else if (btn.Text == "Започни транскрипција")
            {
                bool canTranscribe = this.checkInfluence();
                if (canTranscribe)
                {
                    btn.Enabled = false;
                    this.rnaPolymerase.IsMoving = true;
                    this.timeRNATranscription.Start();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timeMoleculeBinding.Stop();
            this.timeRNATranscription.Stop();
            this.rnaPolymerase.IsMoving = false;
            this.btnStart.Enabled = true;
            foreach (var item in this.TFs.Values)
            {
                item.IsMoving = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.setScreenLayout();
            this.btnStart.Text = "Поврзи";
            this.btnStart.Enabled = true;
            this.timeMoleculeBinding.Stop();
            this.timeRNATranscription.Stop();
            Invalidate();
        }

        private void cbTF_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            TransciptionFactor tf;
            if (this.TFs.ContainsKey(cb.Name))
            {
                tf = this.TFs[cb.Name];
                tf.Visibility = cb.Checked;
            }
            Invalidate();
        }
    }
}
