using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class DisplayCurrencySymbol
    {
        public static void Run()
        {
            // ExStart:DisplayCurrencySymbol           
            // Create an object of TableFormatInfo class.
            Aspose.Pdf.Generator.TableFormatInfo tfi = new Aspose.Pdf.Generator.TableFormatInfo();

            // Sets a string value that indicate currency symbol of money, the default is "$".
            tfi.CurrencySymbol = "$";
            // Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();

            // Format the table in specified columns and rows with given TableFormatInfo
            tab1.FormatTableWithFormatInfo(tfi, 1, 1, 1, 1);
            // ExEnd:DisplayCurrencySymbol           
        }
    }
}