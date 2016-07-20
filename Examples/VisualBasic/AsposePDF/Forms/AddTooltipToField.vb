Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf

Namespace AsposePDF.Forms
    Public Class AddTooltipToField
        Public Shared Sub Run()
            ' ExStart:AddTooltipToField
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

            ' Load source PDF form
            Dim doc As New Document(dataDir & Convert.ToString("AddTooltipToField.pdf"))

            ' Set the tooltip for textfield
            TryCast(doc.Form("textbox1"), Field).AlternateName = "Text box tool tip"

            dataDir = dataDir & Convert.ToString("AddTooltipToField_out_.pdf")
            ' Save the updated document
            doc.Save(dataDir)
            ' ExEnd:AddTooltipToField   
            Console.WriteLine(Convert.ToString(vbLf & "Tooltip added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
