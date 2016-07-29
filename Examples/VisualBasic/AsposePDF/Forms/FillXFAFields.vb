Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class FillXFAFields
        Public Shared Sub Run()
            ' ExStart:FillXFAFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load XFA form
            Dim doc As New Document(dataDir & Convert.ToString("FillXFAFields.pdf"))

            ' Get names of XFA form fields
            Dim names As String() = doc.Form.XFA.FieldNames

            ' Set field values
            doc.Form.XFA(names(0)) = "Field 0"
            doc.Form.XFA(names(1)) = "Field 1"
            dataDir = dataDir & Convert.ToString("Filled_XFA_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:FillXFAFields
            Console.WriteLine(Convert.ToString(vbLf & "XFA fields filled successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
