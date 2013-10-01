using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;

namespace PdfSample
{
    public static class PdfGenerator
    {
        public static PdfDocument CreatePdf(string author)
        {
            var document = new Document();
            var sec = document.Sections.AddSection();
            sec.AddParagraph("Author:" + author);
            return RenderDocument(document);
        }

        private static PdfDocument RenderDocument(Document document)
        {
            var rend = new PdfDocumentRenderer {Document = document};
            rend.RenderDocument();
            return rend.PdfDocument;
        }
    }
}