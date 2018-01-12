using System.IO;
using Ionic.Zip;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class SecureLicense
    {
        public static void Run()
        {
            // ExStart:1
            using (Stream zip = new SecureLicense().GetType().Assembly.GetManifestResourceStream("Aspose.Total.lic.zip"))
            {
                // Download DotNetZip utility from (http://dotnetzip.codeplex.com/) and uncomment following code 
                // after referencing Ionic.Zip.Reduced.dll from downloaded package.

                //using (ZipFile zf = ZipFile.Read(zip))
                //{
                //    MemoryStream ms = new MemoryStream();
                //    ZipEntry e = zf["Aspose.Total.lic"];
                //    e.ExtractWithPassword(ms, "test");
                //    ms.Position = 0;
                //}
            }
            // ExEnd:1
        }
    }
}
