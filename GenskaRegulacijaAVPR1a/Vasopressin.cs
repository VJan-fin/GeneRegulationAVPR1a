using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenskaRegulacijaAVPR1a
{
    public class Vasopressin : Molecule
    {
        public Point vasopressinBindingSite { get; private set; }
        public Point vasopressinEndSite { get; set; }

        public Vasopressin(string name, string details, bool visibility, float speed, Point initialPosition, Point vasopressinBindingSite, Point vasopressinEndSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.vasopressinBindingSite = vasopressinBindingSite;
            this.vasopressinEndSite = vasopressinEndSite;
        }
        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_arginine_vasopressin);
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
                int steps = 30;
                dx = (this.vasopressinEndSite.X - this.vasopressinBindingSite.X) / steps;
                dy = (this.vasopressinEndSite.Y - this.vasopressinBindingSite.Y) / steps;
                if ((this.CurrentPosition.X + dx <= this.vasopressinEndSite.X))
                {
                    this.IsAttached = false;
                    this.IsMoving = false;
                    return;
                }
            }
            else
            {
                int steps = 30;
                dx = (this.vasopressinBindingSite.X - this.InitialPosition.X) / steps;
                dy = (this.vasopressinBindingSite.Y - this.InitialPosition.Y) / steps;
                if (this.CurrentPosition.X + dx <= this.vasopressinBindingSite.X)
                {
                    this.IsAttached = true;
                    this.CurrentPosition = this.vasopressinBindingSite;
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
