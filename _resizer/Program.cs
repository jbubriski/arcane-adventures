using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Png;

int[] sizes = new [] { 120, 320 };
const int quality = 95;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pngEncoder = new PngEncoder
{
    BitDepth = PngBitDepth.Bit8,
    ColorType = PngColorType.RgbWithAlpha,
    CompressionLevel = PngCompressionLevel.Level9,
    FilterMethod = PngFilterMethod.Adaptive
};

var files = Directory.GetFiles("../assets/images/", "*.png", SearchOption.AllDirectories);

foreach (var fullOriginalFilePath in files)
{
    var fileName = Path.GetFileName(fullOriginalFilePath);
    var newFilePath = Path.Combine(Path.GetDirectoryName(fullOriginalFilePath), @"resized");

    if (!Directory.Exists(newFilePath))
    {
        Console.WriteLine($"Creating directory {newFilePath}...");
        Directory.CreateDirectory(newFilePath);
    }

    var fullNewFilePath = Path.Combine(newFilePath, fileName);

    Console.WriteLine($"Processing {fullOriginalFilePath}...");

    if (fullNewFilePath.EndsWith("_1x.png") || fullNewFilePath.EndsWith("_2x.png") || fullNewFilePath.EndsWith("_3x.png"))
    {
        Console.WriteLine($"Already processed file, skipping.");
        continue;
    }

    foreach (var size in sizes)
    {
        using var image = Image.Load(fullOriginalFilePath);

        image.Mutate(x => x
                .Resize(size, size));

        var newFileName = fullNewFilePath.Substring(0, fullNewFilePath.Length - 4) + $"_{size}_1x.png";

        Console.WriteLine($"Writing {newFileName}...");
        image.Save(newFileName, pngEncoder);

        using var image2 = Image.Load(fullOriginalFilePath);

        image2.Mutate(x => x
                .Resize(size * 2, size * 2));

        var newFileName2 = fullNewFilePath.Substring(0, fullNewFilePath.Length - 4) + $"_{size}_2x.png";

        Console.WriteLine($"Writing {newFileName2}...");
        image2.Save(newFileName2, pngEncoder);
        

        using var image3 = Image.Load(fullOriginalFilePath);

        image3.Mutate(x => x
                .Resize(size * 3, size * 3));

        var newFileName3 = fullNewFilePath.Substring(0, fullNewFilePath.Length - 4) + $"_{size}_3x.png";

        Console.WriteLine($"Writing {newFileName3}...");
        image3.Save(newFileName3, pngEncoder);
    }
}

Console.WriteLine("Done!");
