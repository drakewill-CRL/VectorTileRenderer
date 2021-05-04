using System.Collections.Generic;
using System.IO;
using System.Windows;
using SkiaSharp;

namespace VectorTileRenderer
{
    public interface ICanvas
    {
        bool ClipOverflow { get; set; }

        void StartDrawing(double sizeX, double sizeY);

        void DrawBackground(Brush style);

        void DrawLineString(List<SKPoint> geometry, Brush style);

        void DrawPolygon(List<SKPoint> geometry, Brush style);

        void DrawPoint(SKPoint geometry, Brush style);

        void DrawText(SKPoint geometry, Brush style);

        void DrawTextOnPath(List<SKPoint> geometry, Brush style);

        void DrawImage(Stream imageStream, Brush style);

        void DrawUnknown(List<List<SKPoint>> geometry, Brush style);

        BitmapSource FinishDrawing();
    }
}
