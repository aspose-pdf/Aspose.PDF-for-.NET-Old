//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.InteractiveFeatures.Forms;
using System.Collections;

namespace DigitallySignPDFFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            string inFile = dataDir+ @"input.pdf";
            string outFile = dataDir + @"output.pdf";
            using (Document document = new Document(inFile))
            {
                using (PdfFileSignature signature = new PdfFileSignature(document))
                {
                    PKCS7 pkcs = new PKCS7(@"c:\test.pfx", "WebSales"); // Use PKCS7/PKCS7Detached objects
                    DocMDPSignature docMdpSignature = new DocMDPSignature(pkcs, DocMDPAccessPermissions.FillingInForms);
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(100, 100, 200, 100);
                    //set signature appearance
                    signature.SignatureAppearance = dataDir + @"aspose-logo.jpg";
                    //create any of the three signature types
                    signature.Certify(1, "Signature Reason", "Contact", "Location", true, rect, docMdpSignature);
                    //save output PDF file
                    signature.Save(outFile);
                }
            }

            using (Document document = new Document(outFile))
            {
                using (PdfFileSignature signature = new PdfFileSignature(document))
                {
                    IList sigNames = signature.GetSignNames();
                    if (sigNames.Count > 0) // Any signatures?
                    {
                        if (signature.VerifySigned(sigNames[0] as string)) // Verify first one
                        {
                            if (signature.IsCertified) // Certified?
                            {
                                if (signature.GetAccessPermissions() == DocMDPAccessPermissions.FillingInForms) // Get access permission
                                {
                                    // Do something
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}