Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Forms

Namespace AsposePDF.Forms
    Public Class GetFieldsFromRegion
        Public Shared Sub Run()
            ' ExStart:GetFieldsFromRegion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Open pdf file
            Dim doc As New Document(dataDir & Convert.ToString("GetFieldsFromRegion.pdf"))

            ' Create rectangle object to get fields in that area
            Dim rectangle As New Rectangle(35, 30, 500, 500)

            ' Get the PDF form
            Dim form As Form = doc.Form

            ' Get fields in the rectangular area
            Dim fields As Field() = form.GetFieldsInRect(rectangle)

            ' Display Field names and values
            For Each field As Field In fields
                ' Display image placement properties for all placements
                Console.Out.WriteLine("Field Name: " + field.FullName + "-" + "Field Value: " + field.Value)
            Next
            ' ExEnd:GetFieldsFromRegion
        End Sub
    End Class
End Namespace

