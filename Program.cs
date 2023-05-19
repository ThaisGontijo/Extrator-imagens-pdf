
using GroupDocs.Parser;
using GroupDocs.Parser.Data;
using GroupDocs.Parser.Options;

// Extract images from PDF using C#
using (Parser parser = new Parser("C:\\Thais\\Carta - Pernoita Velada Atividade Sbado de Manh.pdf"))
{
    IEnumerable<PageImageArea> images = parser.GetImages();
    // Check if image extraction is supported
    if (images == null)
    {
        Console.WriteLine("Images extraction isn't supported");
        return;
    }

    ImageOptions options = new ImageOptions(ImageFormat.Jpeg);
    int imageNumber = 0;

    // Iterate over retrieved images
    foreach (PageImageArea image in images)
    {
        // Save Images
        image.Save("C:\\Thais\\image-" + imageNumber.ToString() + ".jpeg", options);
        imageNumber++;
    }
}