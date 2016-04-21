using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GenskaRegulacijaAVPR1a
{
    public class TransciptionFactor : Molecule
    {
        /**
         * Positive influence if the TF is an activator,
         * negative if it is a repressor
         */
        public int Influence { get; set; }
        /**
         * The location where the TF binds the DNA molecule
         */
        public Point BindingSite { get; set; }
        /**
         * The colour used to fill the representation on the screen
         */
        public Color FillColour { get; set; }
        /**
         * The radius of the circle representation of the molecule
         */
        public int Radius { get; set; }

        public TransciptionFactor(string name, string details, bool visibility, float speed, Point initialPosition, int influence, Point bindingSite, Color fillColour, int radius) : base(name, details, visibility, speed, initialPosition)
        {
            this.Influence = influence;
            this.BindingSite = bindingSite;
            this.FillColour = fillColour;
            this.Radius = radius;
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
            int steps = 10;
            if (!this.IsAttached)
            {
                dx = (this.BindingSite.X - this.InitialPosition.X) / steps;
                dy = (this.BindingSite.Y - this.InitialPosition.Y) / steps;
                if (/*(this.CurrentPosition.X + dx >= this.BindingSite.X) &&*/ (this.CurrentPosition.Y + dy >= this.BindingSite.Y))
                {
                    this.IsAttached = true;
                    this.CurrentPosition = this.BindingSite;
                    this.IsMoving = false;
                    return;
                }
            }

            this.CurrentPosition = new Point(this.CurrentPosition.X + dx, this.CurrentPosition.Y + dy);
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if (this.Visibility)
            {
                Pen pen = new Pen(Color.Black, 1);
                SolidBrush brush = new SolidBrush(this.FillColour);
                g.FillEllipse(brush, this.CurrentPosition.X - this.Radius, this.CurrentPosition.Y - Radius, 2 * this.Radius, 2 * this.Radius);
                g.DrawEllipse(pen, this.CurrentPosition.X - this.Radius, this.CurrentPosition.Y - Radius, 2 * this.Radius, 2 * this.Radius);
                g.DrawString(this.Name, new Font("Calibri", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(this.CurrentPosition.X - this.Radius + 3, this.CurrentPosition.Y - this.Radius / 3));
            }
        }
    }
}
