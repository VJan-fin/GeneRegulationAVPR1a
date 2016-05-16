using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenskaRegulacijaAVPR1a
{
    public class Ribosome : Molecule
    {
        public Point RibosomeBindingSite { get; private set; }

        public Point TranslationEndSite { get; private set; }

        public Ribosome(string name, string details, bool visibility, float speed, Point initialPosition, Point RibosomeBindingSite, Point TranslationEndSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.RibosomeBindingSite = RibosomeBindingSite;
            this.TranslationEndSite = TranslationEndSite;
        }

        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_ribosome);
            g.DrawImage(bitmap, this.CurrentPosition.X, this.CurrentPosition.Y, 70, 70);
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
                dx = (this.TranslationEndSite.X - this.RibosomeBindingSite.X) / steps;
                dy = (this.TranslationEndSite.Y - this.RibosomeBindingSite.Y) / steps;
                if ((this.CurrentPosition.X + dx >= this.TranslationEndSite.X - 40))
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
                dx = (this.RibosomeBindingSite.X - this.InitialPosition.X) / steps;
                dy = (this.RibosomeBindingSite.Y - this.InitialPosition.Y) / steps;
                if (this.CurrentPosition.Y + dy >= this.RibosomeBindingSite.Y)
                {
                    this.IsAttached = true;
                    this.CurrentPosition = this.RibosomeBindingSite;
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
