Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Attachments
    Public Class AddAttachment
        Public Shared Sub Run()
            ' ExStart:AddAttachment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Attachments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddAttachment.pdf"))

            ' Setup new file to be added as attachment
            Dim fileSpecification As New FileSpecification(dataDir & Convert.ToString("test.txt"), "Sample text file")

            ' Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification)

            dataDir = dataDir & Convert.ToString("AddAttachment_out_.pdf")

            ' Save new output
            pdfDocument.Save(dataDir)
            ' ExEnd:AddAttachment
            Console.WriteLine(Convert.ToString(vbLf & "Sample text file attached successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
