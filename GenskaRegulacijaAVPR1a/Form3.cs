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
    public partial class ProteinForm : Form
    {
        public Vasopressin vasopressin { get; set;  }
        public Vaprisol vaprisol { get; set; }
        public Receptor receptor { get; set; }

        public Boolean isBlocked;

        private static string tooltipMessage = "Кликни за повеќе информации";
        private string startText = "Целта на оваа анимација е да го прикаже процесот на регулација на активација на протеинот AVPR1a рецептор добиен од генот AVPR1a.\r\n\r\nДоколку осмотскиот притисок и волуменот на плазмата се на нормално или високо ниво нема да се лачи Arganine Vasopressin кој што е потребен за активација на рецепторот. За да може да се активира потребно е да се намали осмотскиот притисок или крвната плазма. Тогаш ќе надојде Arganine Vasopressin кој што ќе се врзе со рецепторот и ќе го придвижи кон G протеинот во клеточната мембрана. Врзани заедно овозможуваат праќање на клеточен сигнал за внес на вода во клетката.\r\n\r\nИсто така, може да се блокира активацијата со внесување на антидеуретичен хормон во клетката, пр. Vaprisol. Тој се врзува со рецепторот и спречува врзување со Arganine Vasopressin.";
        private string activationText = "Arganine Vasopressin успешно се врзува со AVPR1a рецепторот, го активира и заедно со G протеинот испраќаат сигнал за внес на вода во клетката.";
        private string blockingText = "Внесен е Vaprisol во клетката и тој се врзува со AVPR1a рецепторот и го оневозможува неговото врзување со Arganine Vasopressin, а со тоа и неговата активација.";
       

        public ProteinForm()
        {
            InitializeComponent();
            setScreenLayout();
            this.DoubleBuffered = true;
            isBlocked = false;
            // Necessary for proper and consistent change during mouse over
            this.lblGeneNameProtein.FontSize = 18;
            this.lblGprotein.FontSize = this.lblArganineVasopressin.FontSize = this.lblOpressure.FontSize = this.lblPlasmaVolume.FontSize = this.lblProtein.FontSize = this.lblVaprisol.FontSize = 14;

            // Fill text in clickable labels
            this.lblProcessExplanation.Text = this.startText;
            this.lblGeneNameProtein.ExplanationText = "APVR1a рецептор е протеинот што се создава како продукт на транслација на генот AVPR1a.";
            this.lblGprotein.ExplanationText = "G протеинот припаѓа на фамилијата 7-трансмембрански протеини бидејќи се превиткува 7 низ клеточната мембрана. Тој служи за примање и пренесување на клеточните сигнали т.е. лиганди. Користи два сигнални патишта: cAMP сигнален пат и фосфатидилинозитолен сигнален пат.";
            this.lblProtein.ExplanationText = "APVR1a рецептор е протеин што се создава како продукт на транслација на генот AVPR1a. Тој претставува рецептор за Arganine Vasopressin. Се активира така што ќе се врзе со Arganine Vasopressin и ќе се придвижи кон G протеин којшто се наоѓа во мембраната на клетката. Врзувањето со конкретниот G протеин всушност претставува испраќање на клеточен сигнал за регулација на количеството на вода во клетката.";
            this.lblOpressure.ExplanationText = "Осмотски притисок е притисокот што се создава со преминувањето на материите преку полупропустливи мембрани до нивното изедначување на концентрациите. Кога притисокот е намален потребно е да се пропушти вода во клетката, односно да се активира AVPR1a рецепторот.";
            this.lblPlasmaVolume.ExplanationText = "Волуменот што го зафаќа плазмата. Доколку волуменот е под нормала треба да се пропушти вода во клетката, односно да се активира AVPR1a рецепторот.";
            this.lblVaprisol.ExplanationText = "Vaprisol е антидеуретичен хормонски лек.";
            this.lblArganineVasopressin.ExplanationText = "Arganine Vasopressin се секретира од неврохипофизата и влијае врз водениот метаболизам на организмот, при што го инхибира исфрлањето на вода и овозможува доток на вода во клетката.";

            // Set tooltip message
            toolTipMsg.SetToolTip(this.lblProtein, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblVaprisol, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblArganineVasopressin, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblGeneNameProtein, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblPlasmaVolume, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblOpressure, tooltipMessage);
            toolTipMsg.SetToolTip(this.lblGprotein, tooltipMessage);
        }

        public void setScreenLayout()
        {

            this.receptor = new Receptor("Рецептор", "Објаснување за рецепторот", true, 200,
                new Point(this.pbProtein.Location.X, this.pbProtein.Location.Y),
                new Point(this.pbGprotein.Location.X + 205, this.pbProtein.Location.Y));

            this.vasopressin = new Vasopressin("Vasopressin", "Објаснување за Vasopressin", true, 200,
                new Point(this.pbArginineVasopressin.Location.X, this.pbArginineVasopressin.Location.Y),
                new Point(this.pbProtein.Location.X + 150, this.pbArginineVasopressin.Location.Y),
                new Point(this.pbGprotein.Location.X + 355, this.pbArginineVasopressin.Location.Y));

            this.vaprisol = new Vaprisol("Vaprisol", "Објаснување за Vaprisol", true, 200,
                new Point(this.pbVaprisol.Location.X, this.pbVaprisol.Location.Y),
                new Point(this.pbProtein.Location.X + 120, this.pbVaprisol.Location.Y));

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
            if (!isBlocked && (trackBarOPressure.Value<4 || trackBarPlasmaVolume.Value<4))
            {
                this.lblProcessExplanation.Text = this.activationText;
                this.vasopressin.IsMoving = true;
                this.receptor.IsMoving = true;
                this.timerVasopresinToRec.Start();
                btn.Enabled = false;
                this.btnStop.Enabled = false;
            }
            else if (isBlocked)
            {
                MessageBox.Show("AVPR1a рецепторот е блокиран со Vaprisol. Не може да се активира.");
            }
            else
            {
                MessageBox.Show("AVPR1a рецепторот не може да се активира бидејќи осмотскиот притисок или волуменот на плазмата не се доволно ниски за да се појави Arganine Vassopresin.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Блокирај протеин")
            {
                this.lblProcessExplanation.Text = this.blockingText;
                isBlocked = true;
                this.vaprisol.IsMoving = true;
                this.timerVaprisolToRec.Start();
                btn.Enabled = false;
                btn.Text = "Одблокирај протеин";
            }
            else
            {
                isBlocked = false;
                this.lblProcessExplanation.Text = this.startText;
                this.vaprisol.CurrentPosition = this.vaprisol.InitialPosition;
                Invalidate();
                btn.Text = "Блокирај протеин";
            }

        }

        private void timerVasopresinToRec_Tick(object sender, EventArgs e)
        {
            this.vasopressin.move();
            if (this.vasopressin.IsAttached)
            {
                this.lblProcessExplanation.Text = this.activationText;
                this.timerVasopresinToRec.Stop();
                this.timerReceptorToGprotein.Start();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.receptor.Draw(e.Graphics);
            this.vaprisol.Draw(e.Graphics);
            this.vasopressin.Draw(e.Graphics);
        }

        private void timerVaprisolToRec_Tick(object sender, EventArgs e)
        {
            this.vaprisol.move();

            if(vaprisol.IsAttached)
            {
                vaprisol.IsAttached = false;
                timerVaprisolToRec.Stop();
                vaprisol.IsMoving = false;
                btnStop.Enabled = true;
            }


            Invalidate();
        }

        private void timerReceptorToGprotein_Tick(object sender, EventArgs e)
        {
            this.receptor.move();
            this.vasopressin.move();

            if (this.receptor.IsAttached)
            {
                this.receptor.IsMoving = false;
                this.vasopressin.IsMoving = false;               
                this.timerReceptorToGprotein.Stop();
            }

            Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lblProcessExplanation.Text = this.startText;
            receptor.CurrentPosition = receptor.InitialPosition;
            receptor.IsMoving = false;
            receptor.IsAttached = false;
            vasopressin.CurrentPosition = vasopressin.InitialPosition;
            vasopressin.IsMoving = false;
            vasopressin.IsAttached = false;
            vaprisol.IsMoving = false;
            vaprisol.IsAttached = false;

            timerReceptorToGprotein.Stop();
            timerVasopresinToRec.Stop();
            timerVaprisolToRec.Stop();
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = true;

            Invalidate();
        }
    }
}
