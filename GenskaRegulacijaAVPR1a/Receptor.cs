using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenskaRegulacijaAVPR1a
{
    public class Receptor : Molecule
    {
        public Point receptorEndSite { get; set; }

        public Receptor(string name, string details, bool visibility, float speed, Point initialPosition, Point receptorEndSite) : base(name, details, visibility, speed, initialPosition)
        {
            this.receptorEndSite = receptorEndSite;
        }
        public override void Draw(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.res_avpr1a_receptor);
            //Bitmap bitmap = new Bitmap(Properties.Resources.rna_polymerase);
            g.DrawImage(bitmap, this.CurrentPosition.X, this.CurrentPosition.Y, 159, 126);
        }

        public override void move()
        {
            if (!this.IsMoving)
                return;

            if (this.IsAttached)
            {
                this.IsAttached = false;
                return;
            }

            int dx = 0;
            int dy = 0;

            
                int steps = 30;
                dx = (this.receptorEndSite.X - this.InitialPosition.X) / steps;
                dy = (this.receptorEndSite.Y - this.InitialPosition.Y) / steps;
                if ((this.CurrentPosition.X + dx <= this.receptorEndSite.X))
                {
                    this.IsAttached = true;
                    this.IsMoving = false;
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
