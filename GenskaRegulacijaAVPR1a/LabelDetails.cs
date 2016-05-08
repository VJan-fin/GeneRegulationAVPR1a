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
    public partial class LabelDetails : Form
    {
        public LabelDetails()
        {
            InitializeComponent();
        }

        public LabelDetails(string title, string details)
        {
            InitializeComponent();
            this.Text = title;
            this.tbDetails.Text = details;

            this.BackColor = Color.FromArgb(144, 153, 186);
            this.tbDetails.BackColor = Color.FromArgb(144, 153, 186);
        }
    }
}
