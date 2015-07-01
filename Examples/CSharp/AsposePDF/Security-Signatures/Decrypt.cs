//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.SecuritySignatures
{
    public class Decrypt
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();


            //open document
            Document document = new Document(dataDir+ "Decrypt.pdf", "password");
            //decrypt PDF
            document.Decrypt();
            //save updated PDF
            document.Save(dataDir + "Decrypt_out.pdf");
            
        }
    }
}