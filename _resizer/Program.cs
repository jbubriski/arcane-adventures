using Newtonsoft.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

internal class Program
{
    private static void Main(string[] args)
    {
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

        var config = GetConfig();

        var directoriesToIgnore = GetDirectoriesToIgnore();

        // Start the work
        foreach (var fileSuffixPair in fileSuffixEncoderMap)
        {
            var fileSuffix = fileSuffixPair.Key;
            var suffixLength = fileSuffix.Length;
            var encoder = fileSuffixPair.Value;

            var folderToFindImages = Path.Combine(Environment.CurrentDirectory, config.PathToResize);
            var files = Directory.GetFiles(folderToFindImages, $"*.{fileSuffix}", SearchOption.AllDirectories);

            foreach (var originalFilePath in files)
            {
                var fullOriginalFilePath = Path.GetFullPath(originalFilePath);
                var fileName = Path.GetFileName(originalFilePath);
                var newFilePath = Path.Combine(Path.GetDirectoryName(fullOriginalFilePath), @"resized");

                var fullNewFilePath = Path.Combine(newFilePath, fileName);

                var ignoredPath = "";

                foreach (var directoryToIgnore in directoriesToIgnore)
                {
                    if (fullOriginalFilePath.StartsWith(directoryToIgnore))
                    {
                        ignoredPath = directoryToIgnore;
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(ignoredPath))
                {
                    Console.WriteLine($"Ignored path: {ignoredPath}, skipping.");
                    continue;
                }

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

                    if (config.Reresize || !Path.Exists(newFileName))
                    {
                        using (var image = Image.Load(fullOriginalFilePath))
                        {
                            image.Mutate(x => x
                                    .Resize(size, size, KnownResamplers.Bicubic));

                            Console.WriteLine($"Writing 1x {newFileName}...");
                            image.Save(newFileName, encoder);
                        }
                    }

                    if (config.Reresize || !Path.Exists(newFileName2))
                    {
                        using (var image2 = Image.Load(fullOriginalFilePath))
                        {
                            image2.Mutate(x => x
                                    .Resize(size * 2, size * 2));

                            Console.WriteLine($"Writing 2x {newFileName2}...");
                            image2.Save(newFileName2, encoder);
                        }
                    }

                    if (config.Reresize || !Path.Exists(newFileName3))
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

        JsonConfig GetConfig()
        {
            using var streamReader = new StreamReader(".resizerconfig");

            var json = streamReader.ReadToEnd();
            var item = JsonConvert.DeserializeObject<JsonConfig>(json);
            return item;
        }

        List<string> GetDirectoriesToIgnore()
        {
            var directoriesToIgnore = new List<string>();

            // Load ignored paths
            foreach (var ignoredPath in config.PathsToIgnore)
            {
                var ignoredFullPath = Path.GetFullPath(ignoredPath);

                Console.WriteLine($"Adding to ignore list: {ignoredFullPath}");

                directoriesToIgnore.Add(ignoredFullPath);
            }

            return directoriesToIgnore;
        }
    }
}


class JsonConfig
{
    public string PathToResize { get; set; }
    public string[] PathsToIgnore { get; set; }

    public bool Reresize { get; set; }
}
