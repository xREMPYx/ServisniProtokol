using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public abstract class BaseDrawableModel
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected Font HeadingFont { get; set; }
        protected Font Font { get; set; }

        public BaseDrawableModel()
        {
            Font = new Font("Arial", 13);
            HeadingFont = new Font("Arial", 17);
        }

        public abstract void Draw(Graphics graphics);

        public void SetX(int x)
        {
            this.X = x;
        }

        public void SetY(int y)
        {
            this.Y = y;
        }
    }
}