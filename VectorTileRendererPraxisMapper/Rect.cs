using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTileRendererPraxisMapper
{
    public class Rect
    {
        //TODO:
        //work out proper constructor logic (do these rects have an origin at upper-left, center, lower-left, etc?)

        //public Rect(Size size){ }
        //public Rect(Point location, Size size);
        public Rect(Point point1, Point point2)
        {
            Left = point1.X;
            Bottom = point1.Y;
            Top = point2.Y;
            Right = point2.X;           
        }
        //public Rect(Point point, Vector vector);
        public Rect(double x, double y, double width, double height)
        {
            //TODO: confirm this is the correct right/top logic.
            Left = x;
            Right = x + width;
            Bottom = y;
            Top = y + height;
        }

        //public static Rect Empty { get; }
        //public Point BottomRight { get; }
        //public Size Size { get; set; }
//        public Point Location { get; set; }
        //public bool IsEmpty { get; }
        //public double Width { get; set; }
        //public double Height { get; set; }
        //public Point BottomLeft { get; }
        public double Left { get; set; }
        public double Top { get; set; }
        //public double X { get; set; }
        public double Right { get; set; }
        //public double Y { get; set; }
        //public Point TopRight { get; }
        public double Bottom { get; set; }
        //public Point TopLeft { get; }

        internal bool IntersectsWith(Rect lineRect)
        {
            var left = Math.Max(Left, lineRect.Left);
            var right = Math.Max(Right, lineRect.Right);
            var top = Math.Max(Top, lineRect.Top);
            var bottom = Math.Max(Bottom, lineRect.Bottom);

            if (left < right || top < bottom)
                return true;

            return false;
        }

        internal void Inflate(int width, int height)
        {
            Left -= width;
            Right += width;
            Top += height;
            Bottom -= height;
        }

        internal bool Contains(Rect r)
        {
            if (r.Left > Left && r.Right < Right && r.Top < Top && r.Bottom > Bottom)
                return true;

            return false;
        }
    }
}
