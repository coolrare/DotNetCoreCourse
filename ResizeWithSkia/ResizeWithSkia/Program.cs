using SkiaSharp;
using System;
using System.IO;

namespace ResizeWithSkia
{
    class Program
    {
        static void Main(string[] args)
        {
            var resizeFactor = 0.5f;
            var bitmap = SKBitmap.Decode("input.png");
            var toBitmap = new SKBitmap((int)Math.Round(bitmap.Width * resizeFactor), (int)Math.Round(bitmap.Height * resizeFactor), bitmap.ColorType, bitmap.AlphaType);

            var canvas = new SKCanvas(toBitmap);
            // Draw a bitmap rescaled
            canvas.SetMatrix(SKMatrix.MakeScale(resizeFactor, resizeFactor));
            canvas.DrawBitmap(bitmap, 0, 0);
            canvas.ResetMatrix();

            var font = SKTypeface.FromFamilyName("Arial");
            var brush = new SKPaint
            {
                Typeface = font,
                TextSize = 40.0f,
                IsAntialias = true,
                Color = new SKColor(255, 255, 255, 255)
            };
            canvas.DrawText("Resized!", 0, bitmap.Height * resizeFactor / 2.0f, brush);

            canvas.Flush();

            var image = SKImage.FromBitmap(toBitmap);
            var data = image.Encode(SKEncodedImageFormat.Png, 90);

            using (var stream = new FileStream("output.png", FileMode.Create, FileAccess.Write))
                data.SaveTo(stream);

            data.Dispose();
            image.Dispose();
            canvas.Dispose();
            brush.Dispose();
            font.Dispose();
            toBitmap.Dispose();
            bitmap.Dispose();
        }
    }
}
