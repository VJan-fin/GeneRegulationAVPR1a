using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenskaRegulacijaAVPR1a
{
    public partial class ClickableLabel : Label
    {
        public string ExplanationText { get; set; }
        public static Color NormalTextColour = Color.White;
        public static Color FocusTextColour = Color.Red;
        public float FontSize { get; set; }

        public ClickableLabel()
        {
            InitializeComponent();

            this.BackColor = Color.Transparent;
            this.ForeColor = ClickableLabel.NormalTextColour;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FontSize = 11;
            this.Font = new Font("Calibri", this.FontSize, FontStyle.Regular);
        }

        public void showExplanation()
        {
            //MessageBox.Show(this.ExplanationText);
            LabelDetails detailsForm = new LabelDetails("Детали за " + this.Text, this.ExplanationText);
            detailsForm.Show();
        }
    }
}
