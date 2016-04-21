using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GenskaRegulacijaAVPR1a
{    
    public class SmallMoleculePerturbation : Molecule
    {
        /**
         * The locations where the small molecules are present on the screen
         */
        public List<Point> Locations { get; set; }
        /**
         * The colour used to fill the small molecules representation on the screen
         */
        public Color FillColour { get; set; }
        /**
         * The radius of the circle representation of the small molecule
         */
        public int Radius { get; set; }
        /**
         * The area on the screen where the small molecules may appear
         */
        public Rectangle AllowedArea { get; set; }

        public SmallMoleculePerturbation(string name, string details, bool visibility, float speed, Color fillColour, int radius, Rectangle allowedArea) : base(name, details, visibility, speed, new Point(0, 0))
        {
            this.FillColour = fillColour;
            this.Radius = radius;
            this.AllowedArea = allowedArea;
            this.Locations = new List<Point>();
        }

        /**
         * Creates a new unit of the given molecule on a randomly generated point
         * in a given rectangular space
         */
        public void increaseSmallMoleculeQuantity()
        {
            Random rndGen = new Random();
            int x = this.AllowedArea.X + rndGen.Next(this.AllowedArea.Width - 2 * this.Radius) + this.Radius;
            int y = this.AllowedArea.Y + rndGen.Next(this.AllowedArea.Height - 2 * this.Radius) + this.Radius;
            this.Locations.Add(new Point(x, y));
        }

        /**
         * Removes a molecular unit from the rectangular area on the screen
         */
        public void decreaseSmallMoleculeQuantity()
        {
            if (this.Locations.Count != 0)
                this.Locations.RemoveAt(this.Locations.Count - 1);
        }

        public override void moveBy(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void move()
        {
            throw new NotImplementedException();
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            foreach (var item in this.Locations)
            {
                if (this.Visibility)
                {
                    Pen pen = new Pen(Color.Black, 0.5f);
                    SolidBrush brush = new SolidBrush(this.FillColour);
                    g.FillEllipse(brush, item.X - this.Radius, item.Y - Radius, 2 * this.Radius, 2 * this.Radius);
                    g.DrawEllipse(pen, item.X - this.Radius, item.Y - Radius, 2 * this.Radius, 2 * this.Radius);
                    g.DrawString(this.Name, new Font("Calibri", 9, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(item.X - this.Radius / 2 + 1, item.Y - this.Radius / 2));
                }
            }
        }
    }
}
