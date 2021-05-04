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

            
        }
        //public Rect(Point point, Vector vector);
        public Rect(double x, double y, double width, double height)
        {

        }

        public static Rect Empty { get; }
        public Point BottomRight { get; }
        //public Size Size { get; set; }
        public Point Location { get; set; }
        public bool IsEmpty { get; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Point BottomLeft { get; }
        public double Left { get; }
        public double Top { get; }
        public double X { get; set; }
        public double Right { get; }
        public double Y { get; set; }
        public Point TopRight { get; }
        public double Bottom { get; }
        public Point TopLeft { get; }

        internal bool IntersectsWith(Rect lineRect)
        {
            throw new NotImplementedException();
        }

        internal void Inflate(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal bool Contains(Rect r)
        {
            throw new NotImplementedException();
        }
    }
}
