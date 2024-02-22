using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

var mainImageSizes = new[] { 120, 320 };
var regularSizes = new[] { 320 };

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

var webpEncoder = new WebpEncoder
{
    Quality = 90,
    SkipMetadata = true
};

var fileSuffixEncoderMap = new Dictionary<string, ImageEncoder> {
    { "png", pngEncoder },
    { "jpeg", jpegEncoder },
    { "jpg", jpegEncoder },
    { "webp", webpEncoder }
};

var reresize = false;

foreach (var fileSuffixPair in fileSuffixEncoderMap)
{
    var fileSuffix = fileSuffixPair.Key;
    var suffixLength = fileSuffix.Length;
    var encoder = fileSuffixPair.Value;

    var folderToFindImages = Path.Combine(Environment.CurrentDirectory, "../assets/images");
    var files = Directory.GetFiles(folderToFindImages, $"*.{fileSuffix}", SearchOption.AllDirectories);

    foreach (var fullOriginalFilePath in files)
    {
        var fileName = Path.GetFileName(fullOriginalFilePath);
        var newFilePath = Path.Combine(Path.GetDirectoryName(fullOriginalFilePath), @"resized");

        var fullNewFilePath = Path.Combine(newFilePath, fileName);

        Console.WriteLine($"Processing {fullOriginalFilePath}...");

        if (fullNewFilePath.EndsWith($"_1x.{fileSuffix}")
            || fullNewFilePath.EndsWith($"_2x.{fileSuffix}")
            || fullNewFilePath.EndsWith($"_3x.{fileSuffix}")
            || fullNewFilePath.EndsWith($"_4x.{fileSuffix}"))
        {
            Console.WriteLine($"Already processed file, skipping.");
            continue;
        }

        if (!Directory.Exists(newFilePath))
        {
            Console.WriteLine($"Creating directory {newFilePath}...");
            Directory.CreateDirectory(newFilePath);
        }

        var sizes = fileName.EndsWith($"-01.{fileSuffix}") && !fileName.EndsWith($"-extra-01.{fileSuffix}") ? mainImageSizes : regularSizes;

        foreach (var size in sizes)
        {

            var newFileName = fullNewFilePath[..^(suffixLength + 1)] + $"_{size}_1x.{fileSuffix}";
            var newFileName2 = fullNewFilePath[..^(suffixLength + 1)] + $"_{size}_2x.{fileSuffix}";
            var newFileName3 = fullNewFilePath[..^(suffixLength + 1)] + $"_{size}_3x.{fileSuffix}";

            if (reresize || !Path.Exists(newFileName))
            {
                using (var image = Image.Load(fullOriginalFilePath))
                {
                    image.Mutate(x => x
                            .Resize(size, size, KnownResamplers.Bicubic));

                    Console.WriteLine($"Writing 1x {newFileName}...");
                    image.Save(newFileName, encoder);
                }
            }

            if (reresize || !Path.Exists(newFileName2))
            {
                using (var image2 = Image.Load(fullOriginalFilePath))
                {
                    image2.Mutate(x => x
                            .Resize(size * 2, size * 2));

                    Console.WriteLine($"Writing 2x {newFileName2}...");
                    image2.Save(newFileName2, encoder);
                }
            }

            if (reresize || !Path.Exists(newFileName3))
            {
                using (var image3 = Image.Load(fullOriginalFilePath))
                {
                    image3.Mutate(x => x
                            .Resize(size * 3, size * 3));

                    Console.WriteLine($"Writing 3x {newFileName3}...");
                    image3.Save(newFileName3, encoder);
                }
            }
        }
    }
}

Console.WriteLine("Done!");
