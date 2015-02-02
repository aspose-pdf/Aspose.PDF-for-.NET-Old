//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace PrintingDifferentPageRangeExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Aspose.Pdf.Facades.PdfViewer pdfv = new Aspose.Pdf.Facades.PdfViewer();

            pdfv.PdfQueryPageSettings += PdfvOnPdfQueryPageSettings;

            System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();
            System.Drawing.Printing.PrinterSettings prin = new System.Drawing.Printing.PrinterSettings();

            pdfv.BindPdf(dataDir + "NewInput.pdf");
            prin.PrinterName = "HP LaserJet M9050 MFP PCL6";
            prin.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

            Aspose.Pdf.Facades.PdfPageEditor pageEditor = new Aspose.Pdf.Facades.PdfPageEditor();
            pageEditor.BindPdf(dataDir+ "temp.pdf");

            pgs.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            pgs.PaperSize = prin.DefaultPageSettings.PaperSize;

            pdfv.PrintDocumentWithSettings(pgs, prin);
            pdfv.Close();
        }

        private static void PdfvOnPdfQueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs queryPageSettingsEventArgs, PdfPrintPageInfo currentPageInfo)
        {
            bool isOdd = currentPageInfo.PageNumber % 2 != 0;

            System.Drawing.Printing.PrinterSettings.PaperSourceCollection paperSources = queryPageSettingsEventArgs.PageSettings.PrinterSettings.PaperSources;

            if (isOdd)
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources[0];
            else
                queryPageSettingsEventArgs.PageSettings.PaperSource = paperSources[1];
        }


    }
}