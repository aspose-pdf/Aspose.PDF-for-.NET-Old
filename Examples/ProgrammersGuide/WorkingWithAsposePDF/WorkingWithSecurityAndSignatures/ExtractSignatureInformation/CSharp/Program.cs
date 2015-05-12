//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;

namespace ExtractSignatureInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            string input = dataDir+ @"input.pdf";
            using (Document pdfDocument = new Document(input))
            {
                foreach (Field field in pdfDocument.Form)
                {
                    SignatureField sf = field as SignatureField;
                    if (sf != null)
                    {
                        Stream cerStream = sf.ExtractCertificate();
                        if (cerStream != null)
                        {
                            using (cerStream)
                            {
                                byte[] bytes = new byte[cerStream.Length];
                                using (FileStream fs = new FileStream(dataDir+ @"input.cer", FileMode.CreateNew))
                                {
                                    cerStream.Read(bytes, 0, bytes.Length);
                                    fs.Write(bytes, 0, bytes.Length);
                                }
                            }
                        }
                    }
                }
            }
            
            
        }
    }
}