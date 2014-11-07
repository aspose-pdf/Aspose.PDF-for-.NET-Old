//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddingJavaScript
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);


            //Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            //Instantiate a Aspose PDF JavaScript Object
            pdf.JavaScripts = new Aspose.Pdf.Generator.JavaScripts();

            //Call the Add method and pass JavaScript statement as an argument, to show Print Dialog
            pdf.JavaScripts.Add("this.print(true);");

            //Call the Add method and JavaScript statement as an argument, to show alert
            pdf.JavaScripts.Add("app.alert(\"hello world\");");

            //Save Pdf Document
            pdf.Save(dataDir+ "Aspose.pdf");
            
            
        }
    }
}