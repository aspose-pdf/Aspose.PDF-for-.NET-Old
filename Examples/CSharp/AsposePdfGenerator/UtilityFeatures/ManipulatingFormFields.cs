using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class ManipulatingFormFields
    {
        public static void Run()
        {
            // ExStart:ManipulatingFormFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate a Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a form field
            Aspose.Pdf.Generator.FormField combo = new Aspose.Pdf.Generator.FormField();

            // Set the type of form field to Combo
            combo.FormFieldType = Aspose.Pdf.Generator.FormFieldType.Combo;

            // Set the field name
            combo.FieldName = "ACombo";

            // Add few options to the combo
            combo.ChoiceOptions = new string[] { "Red", "Green", "Blue" };

            // Set the default selected value of the combo field
            combo.FieldValue = "Red";

            // Set the width of the field
            combo.FormWidth = 80;

            // Set the height of the field
            combo.FormHeight = 20;

            // Add the combo form field to the paragraphs collection of the section
            sec1.Paragraphs.Add(combo); 

            dataDir = dataDir + "ManipulatingFormFields_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:ManipulatingFormFields           
        }
        public static void RadioButtonWithCustomPosition()
        {
            // ExStart:RadioButtonWithCustomPosition
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate the Pdf document and add a section to it
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();


            // Create a table, set its column widths and add it to paragraphs collection
            // Of the  section
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();
            tab1.ColumnWidths = "120 120 120";
            sec1.Paragraphs.Add(tab1);


            // Add a row to the table
            Aspose.Pdf.Generator.Row r1 = tab1.Rows.Add();


            // Add 1st cell to the row, set its padding and set the ID of the first paragraph
            // In the cell to "text1"
            Aspose.Pdf.Generator.Cell c1 = r1.Cells.Add("item1");
            c1.Padding.Left = 30;
            c1.Paragraphs[0].ID = "text1";


            // Add 2nd cell to the row, set its padding and set the ID of the first paragraph
            // In the cell to "text2"
            Aspose.Pdf.Generator.Cell c2 = r1.Cells.Add("item2");
            c2.Padding.Left = 30;
            c2.Paragraphs[0].ID = "text2";


            // Add 3rd cell to the row, set its padding and set the ID of the first paragraph
            // In the cell to "text3"
            Aspose.Pdf.Generator.Cell c3 = r1.Cells.Add("item3");
            c3.Padding.Left = 30;
            c3.Paragraphs[0].ID = "text3";


            // Create a form field of RadioButton type. Set its field name and button color.
            // Then set the index of the radio button value to be checked
            Aspose.Pdf.Generator.FormField radio = new Aspose.Pdf.Generator.FormField();
            radio.FormFieldType = Aspose.Pdf.Generator.FormFieldType.RadioButton;
            radio.FieldName = "ARadio";
            radio.ButtonColor = System.Drawing.Color.FromName("Red");
            radio.RadioButtonCheckedIndex = 0;


            // Create 1st radio button instance and add it to above created radio form field.
            // Set its width and height. The position of the radio button is set to be
            // Relative to the paragraph. Link this radio button with the paragraph with ID
            // Equal to "text1".
            Aspose.Pdf.Generator.RadioButton bt1 = radio.RadioButtons.Add();
            bt1.ButtonHeight = 12;
            bt1.ButtonWidth = 12;
            bt1.PositioningType = Aspose.Pdf.Generator.PositioningType.ParagraphRelative;
            bt1.ReferenceParagraphID = "text1";
            bt1.Left = -20;
            bt1.Top = 0;


            // Create 2nd radio button instance and add it to above created radio form field.
            // Set its width and height. The position of the radio button is set to be
            // Relative to the paragraph. Link this radio button with the paragraph with ID
            // Equal to "text2".
            Aspose.Pdf.Generator.RadioButton bt2 = radio.RadioButtons.Add();
            bt2.ButtonHeight = 12;
            bt2.ButtonWidth = 12;
            bt2.PositioningType = Aspose.Pdf.Generator.PositioningType.ParagraphRelative;
            bt2.ReferenceParagraphID = "text2";
            bt2.Left = -20;
            bt2.Top = 0;


            // Create 3rd radio button instance and add it to above created radio form field.
            // Set its width and height. The position of the radio button is set to be
            // Relative to the paragraph. Link this radio button with the paragraph with ID
            // Equal to "text3".
            Aspose.Pdf.Generator.RadioButton bt3 = radio.RadioButtons.Add();
            bt3.ButtonHeight = 12;
            bt3.ButtonWidth = 12;
            bt3.PositioningType = Aspose.Pdf.Generator.PositioningType.ParagraphRelative;
            bt3.ReferenceParagraphID = "text3";
            bt3.Left = -20;
            bt3.Top = 0;


            // Add the radio form field to the paragraphs collection of the section
            sec1.Paragraphs.Add(radio);

            dataDir = dataDir + "RadioButtonWithCustomPosition_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:RadioButtonWithCustomPosition           
        }
       
    }
}