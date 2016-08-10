Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf

Namespace AsposePdfGenerator.Paragraphs
    Public Class AssignID
        Public Shared Sub Run()
            ' ExStart:AssignID
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs()

            ' Instantiate Pdf object by calling its empty constructor and add a new section to the Pdf object
            Dim pdf1 As New AP.Generator.Pdf()
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph with the reference of a section, sec1 and add the text paragraph in the section
            Dim text3 As New AP.Generator.Text(sec1, "product 1 info ...")
            sec1.Paragraphs.Add(text3)

            ' Set the text paragraph to be the first paragraph among the other ones
            text3.IsFirstParagraph = True

            ' Assign and ID to the text paragraph
            text3.ID = "product1"

            dataDir = dataDir & Convert.ToString("AssignID_out_.pdf")
            ' Save the resultant PDF
            pdf1.Save(dataDir)
            ' ExEnd:AssignID   
            Console.WriteLine(Convert.ToString(vbLf & "An id assigned successfully to a paragraph." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace