using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class ConvertTextFile
    {
        public static void Run()
        {         
            // ExStart:ConvertTextFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Read the source text file
            System.IO.TextReader tr = new StreamReader(dataDir + "test.txt");

            // Instantiate Pdf pbject by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a new text paragraph and pass the text to its constructor as argument
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text(tr.ReadToEnd());
            sec1.Paragraphs.Add(t2);

            pdf1.Save(dataDir + "ConvertTextFile_out_.Pdf");
            // ExEnd:ConvertTextFile           
            
        }
        public static void ConvertLargeTextFile()
        {
            // ExStart:ConvertLargeTextFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate Pdf pbject by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Specify the location of input text file
            String FILE_NAME =  dataDir + "test.txt";

            if (File.Exists(FILE_NAME))
            {

                System.IO.TextReader objReader = new System.IO.StreamReader(FILE_NAME);
                // Read the file till the end of the file has come
                do
                {
                    // Create a new text paragraph & pass text to its constructor as argument
                    Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text(objReader.ReadLine());
                    // Add the text object to paragraphs collection of section
                    sec1.Paragraphs.Add(t2);

                    // Read till the end of file
                } while (objReader.Peek() != -1);

                // Close the StreamReader object
                objReader.Close();
            }
            else
                Console.WriteLine("File Does Not Exist");

            // Save the PDF file
            pdf1.Save(dataDir + "ConvertLargeTextFile_out_.pdf");
            // ExEnd:ConvertLargeTextFile
 
        }
    }
}