using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GenskaRegulacijaAVPR1a
{
    public abstract class Molecule
    {
        /**
         * The name of the molecule
         */
        public string Name { get; set; }
        /**
         * Explanation about the molecule that can be shown on the screen
         */
        public string Details { get; set; }
        /**
         * Is the molecule visible on the screen
         */
        public bool Visibility { get; set; }
        /**
         * The speed at which the molecule is moving towards
         * its final destination or binding site
         */
        public float Speed { get; set; }
        /**
         * The starting position at which the molecule is 
         * shown on the screen
         */
        public Point InitialPosition { get; set; }
        /**
         * The current location of the molecule on the screen
         */
        public Point CurrentPosition { get; set; }
        /**
         * Indicates whether the molecule should be animated or not
         */
        public bool IsMoving { get; set; }

        public Molecule()
        {
        }

        public Molecule(string name, string details, bool visibility, Point initialPosition)
        {
            this.Name = name;
            this.Details = details;
            this.InitialPosition = this.CurrentPosition = initialPosition;
            this.Visibility = visibility;
            this.IsMoving = false;
            this.Speed = 120;
        }

        /**
         * Move the molecule by a given change in coordinates
         */
        abstract public void moveBy(int x, int y);
        /**
         * Moves the molecule according to a computed next point
         */
        abstract public void move();
        /**
         * Handles the drawing of the molecule on the screen
         */
        abstract public void Draw(Graphics g);
    }
}
