using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Attachments
{
    public class AttachAnyFile
    {
        public static void Run()
        {
            // ExStart:AttachAnyFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Attachments();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate attachment instance by calling its empty constructor
            Aspose.Pdf.Generator.Attachment fileAttachment = new Aspose.Pdf.Generator.Attachment();

            // Add attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(fileAttachment);

            // Set attachment type to File using AttachmentType enumeration
            fileAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.File;

            // Set the path of the attachment file. This could be any file like doc, tif etc
            fileAttachment.AttachedFileName = dataDir + "input.pdf";

            // Set the type of the file to be attached
            fileAttachment.AttachedFileType = "pdf";

            // Set the file icon type to Graph
            fileAttachment.FileIconType = Aspose.Pdf.Generator.FileIconType.Graph;

            // Set the color of the icon to Brown
            fileAttachment.IconColor = new Aspose.Pdf.Generator.Color("Brown"); 

            dataDir = dataDir + "AttachAnyFile_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AttachAnyFile           
        }
    }
}