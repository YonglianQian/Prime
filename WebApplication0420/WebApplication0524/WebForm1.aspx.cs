using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;

namespace WebApplication0524
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1.CreateWordprocessingDocument("d:\\1.docx");
            WebForm1.AddPicHeader("d:\\1.docx");
        }

        public static void CreateWordprocessingDocument(string filepath)
        {
            // Create a document by supplying the filepath. 
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));
            }
        }

        public static void AddPicHeader(string docxFileName)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(docxFileName, true))
            {

                var mainDocPart = doc.MainDocumentPart;
                //var imgPart = mainDocPart.AddImagePart(ImagePartType.Png, "rId999");
                //var image = GetImageFromFile(logoFileName);
                //var imagePartID = mainDocPart.GetIdOfPart(imgPart);
                //GenerateImagePartContent(imgPart, image);

                if (!mainDocPart.HeaderParts.Any())
                {
                    mainDocPart.DeleteParts(mainDocPart.HeaderParts);
                    var newHeaderPart = mainDocPart.AddNewPart<HeaderPart>();
                    // try this instead
                    var imgPart = newHeaderPart.AddImagePart(ImagePartType.Jpeg, "rId999");
                    var imagePartID = newHeaderPart.GetIdOfPart(imgPart);

                    //System.Drawing.Image image = System.Drawing.Image.FromFile("‪D:\\1.jpg");
                    using (FileStream fs = new FileStream("D:\\1.jpg", FileMode.Open))
                    {
                        imgPart.FeedData(fs);
                    }
                    var rId = mainDocPart.GetIdOfPart(newHeaderPart);
                    var headerRef = new HeaderReference { Id = rId };
                    var sectionProps = doc.MainDocumentPart.Document.Body.Elements<SectionProperties>().LastOrDefault();
                    if (sectionProps == null)
                    {
                        sectionProps = new SectionProperties();
                        doc.MainDocumentPart.Document.Body.Append(sectionProps);
                    }
                    sectionProps.RemoveAllChildren<HeaderReference>();
                    sectionProps.Append(headerRef);
                    newHeaderPart.Header = GeneratePicHeader(imagePartID);
                    newHeaderPart.Header.Save();
                }
            }
        }
        private static Header GeneratePicHeader(string relationshipId)
        {
            var element =
                new Drawing(
                    new DW.Inline(
                        new DW.Extent() { Cx = 990000L, Cy = 792000L },
                        new DW.EffectExtent()
                        {
                            LeftEdge = 0L,
                            TopEdge = 0L,
                            RightEdge = 0L,
                            BottomEdge = 0L
                        },
                        new DW.DocProperties()
                        {
                            Id = (UInt32Value)1U,
                            Name = "NIS Logo"
                        },
                        new DW.NonVisualGraphicFrameDrawingProperties(
                            new A.GraphicFrameLocks() { NoChangeAspect = true }),
                        new A.Graphic(
                            new A.GraphicData(
                                new PIC.Picture(
                                    new PIC.NonVisualPictureProperties(
                                        new PIC.NonVisualDrawingProperties()
                                        {
                                            Id = (UInt32Value)0U,
                                            Name = "nis.png"
                                        },
                                        new PIC.NonVisualPictureDrawingProperties()),
                                    new PIC.BlipFill(
                                        new A.Blip(
                                            new A.BlipExtensionList(
                                                new A.BlipExtension()
                                                {
                                                    Uri =
                                                        "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                })
                                        )
                                        {
                                            Embed = relationshipId,
                                            CompressionState =
                                                A.BlipCompressionValues.Print
                                        },
                                        new A.Stretch(
                                            new A.FillRectangle())),
                                    new PIC.ShapeProperties(
                                        new A.Transform2D(
                                            new A.Offset() { X = 0L, Y = 0L },
                                            new A.Extents() { Cx = 990000L, Cy = 792000L }),
                                        new A.PresetGeometry(
                                            new A.AdjustValueList()
                                        )
                                        { Preset = A.ShapeTypeValues.Rectangle }))
                            )
                            { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                    )
                    {
                        DistanceFromTop = (UInt32Value)0U,
                        DistanceFromBottom = (UInt32Value)0U,
                        DistanceFromLeft = (UInt32Value)0U,
                        DistanceFromRight = (UInt32Value)0U,
                        EditId = "50D07946"
                    });

            var header = new Header();
            var paragraph = new Paragraph();
            var run = new Run();

            run.Append(element);
            paragraph.Append(run);
            header.Append(paragraph);
            return header;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\");
        }
    }
}