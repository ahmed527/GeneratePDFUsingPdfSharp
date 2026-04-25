using PdfSharp.Fonts;

namespace GeneratePDFUsingGeneratePDFMigraDoc
{
    public class MinimalFontResolver : IFontResolver
    {
        public byte[]? GetFont(string faceName)
        {
            string fontPath = Path.Combine(AppContext.BaseDirectory, "Fonts", faceName);

            if (File.Exists(fontPath))
            {
                return File.ReadAllBytes(fontPath);
            }

            return null;
        }

        public FontResolverInfo? ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                if (isBold)
                {
                    return new FontResolverInfo("arialbd.ttf");  
                }

                return new FontResolverInfo("arial.ttf");  
            }
             
            return new FontResolverInfo("arial.ttf");
        }
    }
}
