//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.LinksActions
{
    public class RemoveOpenAction
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            //open document
            Document document = new Document(dataDir + "RemoveOpenAction.pdf");

            //remove document open action
            document.OpenAction = null;

            //save updated document
            document.Save(dataDir + "RemoveOpenAction_out.pdf");
            
            
        }
    }
}