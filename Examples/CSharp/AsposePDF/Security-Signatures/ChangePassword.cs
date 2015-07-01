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
    public class ChangePassword
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            //open document
            Document document = new Document(dataDir+ "ChangePassword.pdf", "owner");
            //change password
            document.ChangePasswords("owner", "newuser", "newowner");
            //save updated PDF
            document.Save(dataDir+ "ChangePassword_out.pdf");
            
            
        }
    }
}