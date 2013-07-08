//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace GetAlltheAttachmentsFromPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            
            //get embedded files collection
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            
            //get count of the embedded files
            Console.WriteLine("Total files : {0}", embeddedFiles.Count);

            int count = 1;
            
            //loop through the collection to get all the attachments
            foreach (FileSpecification fileSpecification in embeddedFiles)
            {
                Console.WriteLine("Name: {0}", fileSpecification.Name);
                Console.WriteLine("Description: {0}",
                fileSpecification.Description);
                Console.WriteLine("Mime Type: {0}", fileSpecification.MIMEType);

                
                
                //check if parameter object contains the parameters
                if (fileSpecification.Params != null)
                {
                    Console.WriteLine("CheckSum: {0}",
                    fileSpecification.Params.CheckSum);
                    Console.WriteLine("Creation Date: {0}",
                    fileSpecification.Params.CreationDate);
                    Console.WriteLine("Modification Date: {0}",
                    fileSpecification.Params.ModDate);
                    Console.WriteLine("Size: {0}", fileSpecification.Params.Size);
                }
                
                //get the attachment and write to file or stream
                byte[] fileContent = new byte[fileSpecification.Contents.Length];
                fileSpecification.Contents.Read(fileContent, 0,
                fileContent.Length);
                FileStream fileStream = new FileStream(dataDir + count + ".txt",
                FileMode.Create);
                fileStream.Write(fileContent, 0, fileContent.Length);
                fileStream.Close();
                count+=1;
            }

        }
    }
}