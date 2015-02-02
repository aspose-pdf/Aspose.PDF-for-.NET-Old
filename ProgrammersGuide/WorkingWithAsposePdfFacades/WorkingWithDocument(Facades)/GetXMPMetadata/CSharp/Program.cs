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
using System;

namespace GetXMPMetadataExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //create PdfXmpMetadata object
            PdfXmpMetadata xmpMetaData = new PdfXmpMetadata();

            //bind pdf file to the object
            xmpMetaData.BindPdf(dataDir+ "input.pdf");

            //get XMP Meta Data properties
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.CreateDate].ToString());
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.MetadataDate].ToString());
            Console.WriteLine(": {0}", xmpMetaData[DefaultMetadataProperties.CreatorTool].ToString());
            Console.WriteLine(": {0}", xmpMetaData["customNamespace:UserPropertyName"].ToString());

            Console.ReadLine();
            
        }
    }
}