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

        public NucleusForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadComponents();
            FillTexts();
        }

        public void LoadComponents()
        {
            int alphaValue = 180;
            this.lblPromotorMark.BackColor = Color.FromArgb(alphaValue, 143, 188, 143); // dark sea green
            this.lblTATAMark.BackColor = Color.FromArgb(alphaValue, 255, 192, 255);
            this.lblTSSMark.BackColor = Color.FromArgb(alphaValue, 192, 255, 192);
            this.lblUTR5Mark.BackColor = Color.FromArgb(alphaValue, 255, 192, 128);
            this.lblExon1Mark.BackColor = Color.FromArgb(alphaValue, 192, 192, 255);
            this.lblIntron1Mark.BackColor = Color.FromArgb(alphaValue, 255, 128, 128);
            this.lblExon2Mark.BackColor = Color.FromArgb(alphaValue, 192, 192, 255);
            this.lblUTR3Mark.BackColor = Color.FromArgb(alphaValue, 255, 192, 128);

            this.lblTATA.FontSize = this.lblTSS.FontSize = this.lbl3UTR.FontSize = this.lbl5UTR.FontSize = 11;
            this.lblGeneName.FontSize = 18;

            toolTip1.SetToolTip(this.lblTATA, tooltipMessage);
            toolTip1.SetToolTip(this.lblTSS, tooltipMessage);
            toolTip1.SetToolTip(this.lbl3UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lbl5UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lblGeneName, tooltipMessage);
        }

        private void FillTexts()
        {
            this.lblTATA.ExplanationText = "This is a sample text";
            this.lblTSS.ExplanationText = "ClickableLabel sample text";
            this.lbl5UTR.ExplanationText = this.lbl3UTR.ExplanationText = "Пример објаснување за нетранслираниот регион";

            this.lblGeneName.ExplanationText = "Детали за генот";
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
    }
}
