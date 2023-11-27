using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;

var sizes = new[] { 120, 320 };

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pngEncoder = new PngEncoder
{
    BitDepth = PngBitDepth.Bit8,
    ColorType = PngColorType.RgbWithAlpha,
    CompressionLevel = PngCompressionLevel.Level9
};

var jpegEncoder = new JpegEncoder
{
    Quality = 90,
    SkipMetadata = true
};

var reresize = false;

var folderToFindImages = Path.Combine(Environment.CurrentDirectory, "../assets/images");
var files = Directory.GetFiles(folderToFindImages, "*.png", SearchOption.AllDirectories);

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

    if (fullNewFilePath.EndsWith("_1x.png")
        || fullNewFilePath.EndsWith("_2x.png")
        || fullNewFilePath.EndsWith("_3x.png")
        || fullNewFilePath.EndsWith("_4x.png"))
    {
        Console.WriteLine($"Already processed file, skipping.");
        continue;
    }

    foreach (var size in sizes)
    {
        var newFileName = fullNewFilePath[..^4] + $"_{size}_1x.png";
        var newFileName2 = fullNewFilePath[..^4] + $"_{size}_2x.png";
        var newFileName3 = fullNewFilePath[..^4] + $"_{size}_3x.png";

        if (reresize || !Path.Exists(newFileName))
        {
            using (var image = Image.Load(fullOriginalFilePath))
            {
                image.Mutate(x => x
                        .Resize(size, size, KnownResamplers.Bicubic));

                Console.WriteLine($"Writing 1x {newFileName}...");
                image.Save(newFileName, pngEncoder);
            }
        }

        if (reresize || !Path.Exists(newFileName2))
        {
            using (var image2 = Image.Load(fullOriginalFilePath))
            {
                image2.Mutate(x => x
                        .Resize(size * 2, size * 2));

                Console.WriteLine($"Writing 2x {newFileName2}...");
                image2.Save(newFileName2, pngEncoder);
            }
        }

        if (reresize || !Path.Exists(newFileName3))
        {
            using (var image3 = Image.Load(fullOriginalFilePath))
            {
                image3.Mutate(x => x
                        .Resize(size * 3, size * 3));

                Console.WriteLine($"Writing 3x {newFileName3}...");
                image3.Save(newFileName3, pngEncoder);
            }
        }
    }
}

Console.WriteLine("Done!");
