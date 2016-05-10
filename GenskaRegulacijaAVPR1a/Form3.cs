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

        public ProteinForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }
    }
}
