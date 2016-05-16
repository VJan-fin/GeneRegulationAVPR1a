using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GenskaRegulacijaAVPR1a
{
    public class RNAPolymerase : Molecule
    {
        /**
         * The location of the DNA binding site for the polymerase
         * (location of TSS)
         */
        public Point PolymeraseBindingSite { get; private set; }
        /**
         * The location where the polymerase detaches from
         * the DNA sequence
         */
        public Point TranscriptionEndSite { get; private set; }

        public RNAPolymerase(string name, string details, bool visibility, float speed, Point initialPosition, Point polymeraseBindingSite, Point transcriptionEndSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.PolymeraseBindingSite = polymeraseBindingSite;
            this.TranscriptionEndSite = transcriptionEndSite;
        }

        public override void moveBy(int x, int y)
        {
            this.CurrentPosition = new Point(this.CurrentPosition.X + x, this.CurrentPosition.Y + y);
        }

        public override void move()
        {
            if (!this.IsMoving)
                return;

            int dx = 0;
            int dy = 0;
            int steps = 20;
            if (this.IsAttached)
            {
                dx = (this.TranscriptionEndSite.X - this.PolymeraseBindingSite.X) / steps;
                dy = (this.TranscriptionEndSite.Y - this.PolymeraseBindingSite.Y) / steps;
                if ((this.CurrentPosition.X + dx >= this.TranscriptionEndSite.X) && (this.CurrentPosition.Y + dy >= this.TranscriptionEndSite.Y))
                {
                    this.IsAttached = false;
                    this.CurrentPosition = this.InitialPosition;
                    this.IsMoving = false;
                    return;
                }
            }
            else
            {
                dx = (this.PolymeraseBindingSite.X - this.InitialPosition.X) / steps;
                dy = (this.PolymeraseBindingSite.Y - this.InitialPosition.Y) / steps;
                if (this.CurrentPosition.Y + dy >= this.PolymeraseBindingSite.Y)
                {
                    this.IsAttached = true;
                    this.CurrentPosition = this.PolymeraseBindingSite;
                    return;
                }
            }

            this.CurrentPosition = new Point(this.CurrentPosition.X + dx, this.CurrentPosition.Y + dy);
        }

        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.RNA_pol_II);
            g.DrawImage(bitmap, this.CurrentPosition.X, this.CurrentPosition.Y, 80, 62);
        }

        public void ChangeMovementRate(int rateDiff)
        {
            this.Speed += rateDiff;
        }
    }
}
