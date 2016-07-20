Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class GetXFAProperties
        Public Shared Sub Run()
            ' ExStart:GetXFAProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load XFA form
            Dim doc As New Document(dataDir & Convert.ToString("GetXFAProperties.pdf"))

            Dim names As String() = doc.Form.XFA.FieldNames

            ' Set field values
            doc.Form.XFA(names(0)) = "Field 0"
            doc.Form.XFA(names(1)) = "Field 1"

            ' Get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names(0)).Attributes("x").Value)

            ' Get field position
            Console.WriteLine(doc.Form.XFA.GetFieldTemplate(names(0)).Attributes("y").Value)

            dataDir = dataDir & Convert.ToString("Filled_XFA_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:GetXFAProperties
            Console.WriteLine(Convert.ToString(vbLf & "XFA fields properties retrieved successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
