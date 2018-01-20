using SixLabors.ImageSharp;
using System;

namespace ImageSharpCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Image<Rgba32> image = Image.Load("NETCore.png"))
            {
                image.Mutate(x => x
                     .Resize(image.Width / 2, image.Height / 2)
                     .Grayscale());
                image.Save("bar.jpg"); // automatic encoder selected based on extension.
            }
        }
    }
}
