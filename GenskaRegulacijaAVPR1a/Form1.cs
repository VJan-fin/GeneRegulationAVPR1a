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

        public NucleusForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadComponents();
            FillTexts();

            this.rnaPolymerase = new RNAPolymerase("РНК полимераза", "Објаснување за полимеразата", true,
                new Point(496, 64),
                new Point(this.lblTSSMark.Location.X - 30, this.lblTSSMark.Location.Y - 10),
                new Point(this.lblUTR3Mark.Location.X + this.lblUTR3Mark.Width, this.lblUTR3Mark.Location.Y - 10));

            this.timePolymerase.Interval = (int)this.rnaPolymerase.Speed;
        }

        public void LoadComponents()
        {
            // Animation control buttons
            this.btnStart.BackColor = this.btnStop.BackColor = Color.FromArgb(255, 139, 146, 174);
            this.btnStart.FlatAppearance.BorderColor = this.btnStop.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 85, 108);
            this.btnStart.FlatAppearance.BorderSize = this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStart.ForeColor = this.btnStop.ForeColor = Color.White;

            // Necessary for proper and consistent change during mouse over
            this.lblTATA.FontSize = this.lblTSS.FontSize = this.lbl3UTR.FontSize = this.lbl5UTR.FontSize = 11;
            this.lblGeneName.FontSize = 18;
            this.lblRNAPolymerase.FontSize = this.lblTF.FontSize = this.lblSmallMolecules.FontSize = 14;

            // Setting a tooltip message that labels contain more details on click
            toolTip1.SetToolTip(this.lblTATA, tooltipMessage);
            toolTip1.SetToolTip(this.lblTSS, tooltipMessage);
            toolTip1.SetToolTip(this.lbl3UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lbl5UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lblGeneName, tooltipMessage);
            toolTip1.SetToolTip(this.lblRNAPolymerase, tooltipMessage);
            toolTip1.SetToolTip(this.lblTF, tooltipMessage);
            toolTip1.SetToolTip(this.lblSmallMolecules, tooltipMessage);
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

        private void timePolymerase_Tick(object sender, EventArgs e)
        {
            this.rnaPolymerase.move();
            Invalidate(true);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.drawDNAStrand(e.Graphics);
            this.drawDNARegions(e.Graphics);

            this.rnaPolymerase.Draw(e.Graphics);
        }

        private void NucleusForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timePolymerase.Start();
            this.rnaPolymerase.IsMoving = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timePolymerase.Stop();
            this.rnaPolymerase.IsMoving = false;
        }
    }
}
