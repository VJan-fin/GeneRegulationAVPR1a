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

        public Vaprisol(string name, string details, bool visibility, float speed, Point initialPosition, Point vaprisolBindingSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.vaprisolBindingSite = vaprisolBindingSite;
        }
        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_vaprisol);
            g.DrawImage(bitmap, this.CurrentPosition.X, this.CurrentPosition.Y, 84, 65);
        }

        public override void move()
        {
            if (!this.IsMoving)
                return;

            int dx = 0;
            int dy = 0;

            int steps = 30;
            dx = (this.vaprisolBindingSite.X - this.InitialPosition.X) / steps;
            dy = (this.vaprisolBindingSite.Y - this.InitialPosition.Y) / steps;
            if (this.CurrentPosition.X + dx <= this.vaprisolBindingSite.X)
            {
                this.IsAttached = true;
                //this.IsMoving = false;
                return;
            }

            this.CurrentPosition = new Point(this.CurrentPosition.X + dx, this.CurrentPosition.Y + dy);
        }

        public override void moveBy(int x, int y)
        {
            this.CurrentPosition = new Point(this.CurrentPosition.X + x, this.CurrentPosition.Y + y);
        }
    }
}
