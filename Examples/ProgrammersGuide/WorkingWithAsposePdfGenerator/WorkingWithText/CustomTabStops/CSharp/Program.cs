//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CustomTabStops
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

            //Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            //Create a text object 
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("This #$TAB is a example for custom TAB stop positions.");

            //Assign an instance of TabStops to the TabStops property of text object
            text1.TabStops = new Aspose.Pdf.Generator.TabStops();

            //Call Add method of TabStops and pass a specified position as argument
            text1.TabStops.Add(150);

            //Call Add method with specified position and tab leader type as Dot
            text1.TabStops.Add(350, Aspose.Pdf.Generator.TabLeaderType.Dot);

            pdf.Save(dataDir + "Output.pdf");
            
        }
    }
}