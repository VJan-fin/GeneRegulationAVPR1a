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
    public partial class mRNAForm : Form
    {
        public int secondsTimer;
        private static string tooltipMessage = "Кликни за повеќе информации";
        private string startText = "Целта на оваа анимација е да го прикаже процесот на регулација на деградација на mRNA молекула добиена од генот AVPR1a. Тоа подразбира додавање на глукокортикоиди во цитоплазмата на клетката кои ја успоруваат деградацијата на mRNA молекулата.\r\n\r\nЗа да може да започне целиот процес, најпрво е потребно рибозомот да се поврзе со mRNA молекулата на местото наречено Ribosome Binding Site (RBS), односно почетно место на транслација.\r\nЗа таа цел притисни ПОВРЗИ.";
        private string ribosomeMovingText = "Рибозомот е привлечен од RNA секвенцата која се наоѓа на почетното место на транслација, како резултат на голем број физички и хемиски привлечни сили. Тоа се нарекува афинитет.";
        private string translationText = "За да може да започне транслацијата потребно е да се избере ЗАПОЧНИ ТРАНСЛАЦИЈА. Со тоа рибозомот почнува да се движи по mRNA молекулата и да извршува нејзина транслација. Но, mRNA молекулата ќе почне да деградира. За да го продолжиме времето на “живот“ и да се осигураме дека транслацијата ќе се изврши, можеме со клик на “+“ да додаваме од соодветниот глукокортикоид и со тоа да се зголемува времето на тајмерот.\r\nИзбери РЕСЕТИРАЈ доколку сакаш одново да започне транслацијата.";
        private string translationGoingText = "Процесот на транслација на mRNA молекулата е во тек.\r\nЗа да го продолжиме времето и да се осигураме дека транслацијата ќе се изврши, со клик на “+“ да додаваме од соодветниот глукокортикоид и со тоа да се зголемува времето на тајмерот.";

        public Ribosome ribosome { get; set; }

        public mRNAForm()
        {
            InitializeComponent();
            setScreenLayout();
            this.DoubleBuffered = true;
            // Necessary for proper and consistent change during mouse over
            this.lblDexamethasone.FontSize = this.lblCorticosterone.FontSize = this.lblAldosterone.FontSize = 11;
            this.lblGeneNamemRNA.FontSize = 18;
            this.lblGlucocorticoids.FontSize = this.lblRibosome.FontSize = 14;

            // Fill text in clickable labels
            this.lblProcessExplanation.Text = this.startText;
            this.lblGeneNamemRNA.ExplanationText = "mRNA молекула која што се добива како резултат на транскрипција на генот AVPR1a.";
            this.lblGlucocorticoids.ExplanationText = "Глукокортикоиди се класа на стероидни хормони кои се поврзуваат за глукокортикоидните рецептори. Името глукокортикоид (глукоза + кортекс + стероид) е добиено од нивната функција во регулацијата на метаболизмот на глукоза, нивната синтеза во кората на надбубрежната жлезда и нивната стероидна структура. Помалку користен синоним е глукокортикостероид.";
            this.lblDexamethasone.ExplanationText = "Dexamethasone е тип на глукокортикоиден лек.";
            this.lblCorticosterone.ExplanationText = "Corticosterone е тип на глукокортикоиден лек.";
            this.lblAldosterone.ExplanationText = "Aldosterone е тип на глукокортикоиден лек.";
            this.lblRibosome.ExplanationText = "Рибозомите се органели во кои се остварува процесот на транслација, односно синтезата на протеините, со учество на mRNA и tRNA. Секој рибозом се состои од две морфолошки субединици, кои се разликуваат по големина и тежина, наречени голема и мала субединица. Тоа се универзални органели за сите живи клетки. Се создаваат во јадренцето и по нивното создавање преминуваат во цитоплазмата.";

            // Set tooltip message
            toolTipMsg.SetToolTip(this.lblGeneNamemRNA, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblRibosome, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblGlucocorticoids, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblDexamethasone, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblCorticosterone, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblAldosterone, tooltipMessage);
        }

        public void setScreenLayout()
        {
            this.ribosome = new Ribosome("Рибозом", "Објаснување за Рибозомот", true, 200,
                new Point(this.pbRibosome.Location.X, this.pbRibosome.Location.Y),
                new Point(this.lblRBSMark.Location.X - 30, this.lblRBSMark.Location.Y - 10),
                new Point(this.lblUTR3Mark.Location.X + this.lblUTR3Mark.Width, this.lblUTR3Mark.Location.Y - 10));

        }

        private void pbMrna_Click(object sender, EventArgs e)
        {

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Поврзи")
            {
                this.lblProcessExplanation.Text = this.ribosomeMovingText;
                this.ribosome.IsMoving = true;
                this.timerRibosomeBinding.Start();
                btn.Enabled = false;

            }
            else if (btn.Text == "Започни транслација")
            {
                this.lblProcessExplanation.Text = this.translationGoingText;
                btn.Enabled = false;
                this.ribosome.IsMoving = true;
                this.timerTranslation.Start();
                this.timerDegrade.Start();
            }
        }

        private void timerRibosomeBinding_Tick(object sender, EventArgs e)
        {
            this.ribosome.move();
            if (this.ribosome.IsAttached)
            {
                this.btnStartTransl.Text = "Започни транслација";
                this.lblProcessExplanation.Text = this.translationText;
                this.btnStartTransl.Enabled = true;
                this.ribosome.IsMoving = false;
                this.timerRibosomeBinding.Stop();
            }
            Invalidate();
        }

        private void timerTranslation_Tick(object sender, EventArgs e)
        {
            this.ribosome.move();
            secondsTimer++;
            lblTimer.Text = (100 - secondsTimer).ToString();
            if (secondsTimer == 100)
            {
                Reset();
                MessageBox.Show("Транслацијата не може да заврши бидејќи mRNA молекулата е деградирана.");
            }
            if (this.ribosome.CurrentPosition == this.ribosome.InitialPosition)
            {
                this.btnStartTransl.Text = "Поврзи";
                this.lblProcessExplanation.Text = this.startText;
                this.btnStartTransl.Enabled = true;
                this.timerTranslation.Stop();
                this.lblProtein.Visible = true;
                this.lblNextPhase.Visible = true;
                this.lblTimer.Text = 100.ToString();
                this.timerDegrade.Stop();
            }
            Invalidate();
        }

        private void Reset()
        {
            this.setScreenLayout();
            this.btnStartTransl.Text = "Поврзи";
            this.btnStartTransl.Enabled = true;
            this.timerDegrade.Stop();
            this.timerRibosomeBinding.Stop();
            this.timerTranslation.Stop();
            this.lblProcessExplanation.Text = this.startText;
            this.secondsTimer = 0;
            this.lblTimer.Text = 100.ToString();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.drawRNAStrand(e.Graphics);
            this.drawRNARegions(e.Graphics);
            this.ribosome.Draw(e.Graphics);
        }

        private void drawRNAStrand(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_rna_strand);
            g.DrawImage(bitmap, 250, 480, 529, 47);
        }

        private void drawRNARegions(Graphics g)
        {
            SolidBrush brush;
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));
            Control control;
            Font labels = new Font("Calibri", (float)11.5, FontStyle.Bold);
            PointF textLocation;
            int alphaValue = 190;

            // Ribosome Binding Site (RBS)
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 255, 192));
            control = this.lblRBSMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 10, control.Location.Y + control.Height / 3);
            g.DrawString("RBS", labels, textBrush, textLocation);

            // Poly-A tail
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 128));
            control = this.lblUTR3Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 4, control.Location.Y + control.Height / 3);
            g.DrawString("3' UTR", labels, textBrush, textLocation);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.lblProcessExplanation.Text = "Избери " + this.btnStartTransl.Text + " за да продолжи процесот.";
            this.timerDegrade.Stop();
            this.timerRibosomeBinding.Stop();
            this.timerTranslation.Stop();
            this.ribosome.IsMoving = false;
            this.btnStartTransl.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            secondsTimer -= 5;
        }

        private void lblProtein_Click(object sender, EventArgs e)
        {
            ProteinForm next = new ProteinForm();
            next.Show();
        }

        private void lblRNAQuantity_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblRNAQuantity_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
