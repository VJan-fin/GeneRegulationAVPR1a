using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenskaRegulacijaAVPR1a
{
    public class Vaprisol : Molecule
    {
        public Point vaprisolBindingSite { get; private set; }
        public Point vaprisolEndSite { get; set; }

        public Vaprisol(string name, string details, bool visibility, float speed, Point initialPosition, Point vaprisolBindingSite, Point vaprisolEndSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.vaprisolBindingSite = vaprisolBindingSite;
            this.vaprisolEndSite = vaprisolEndSite;
        }
        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_vaprisol);
            //Bitmap bitmap = new Bitmap(Properties.Resources.rna_polymerase);
            g.DrawImage(bitmap, this.CurrentPosition.X, this.CurrentPosition.Y, 64, 46);
        }

        public override void move()
        {
            if (!this.IsMoving)
                return;

            int dx = 0;
            int dy = 0;

            if (this.IsAttached)
            {
                int steps = 130;
                dx = (this.vaprisolEndSite.X - this.vaprisolBindingSite.X) / steps;
                dy = (this.vaprisolEndSite.Y - this.vaprisolBindingSite.Y) / steps;
                if ((this.CurrentPosition.X + dx >= this.vaprisolEndSite.X - 40))
                {
                    this.IsAttached = false;
                    this.CurrentPosition = this.InitialPosition;
                    this.IsMoving = false;
                    return;
                }
            }
            else
            {
                int steps = 30;
                dx = (this.vaprisolBindingSite.X - this.InitialPosition.X) / steps;
                dy = (this.vaprisolBindingSite.Y - this.InitialPosition.Y) / steps;
                if (/*(this.CurrentPosition.X + dx >= this.vaprisolBindingSite.X) && */(this.CurrentPosition.Y + dy >= this.vaprisolBindingSite.Y))
                {
                    this.IsAttached = true;
                    this.CurrentPosition = this.vaprisolBindingSite;
                    //this.IsMoving = false;
                    return;
                }
            }

            this.CurrentPosition = new Point(this.CurrentPosition.X + dx, this.CurrentPosition.Y + dy);
        }

        public override void moveBy(int x, int y)
        {
            this.CurrentPosition = new Point(this.CurrentPosition.X + x, this.CurrentPosition.Y + y);
        }
    }
}
