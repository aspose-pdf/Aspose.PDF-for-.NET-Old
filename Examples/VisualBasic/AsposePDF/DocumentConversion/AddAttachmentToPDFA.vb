Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class AddAttachmentToPDFA
        Public Shared Sub Run()
            ' ExStart:AddAttachmentToPDFA
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

            ' Instantiate Document instance to load existing file
            Dim doc As Document = New Document(dataDir & Convert.ToString("input.pdf"))
            ' Setup new file to be added as attachment
            Dim fileSpecification As New FileSpecification(dataDir & Convert.ToString("aspose-logo.jpg"), "Large Image file")
            ' Add attachment to document's attachment collection
            doc.EmbeddedFiles.Add(fileSpecification)
            ' Perform conversion to PDF/A_3a so attachment is included in resultnat file
            doc.Convert(dataDir & Convert.ToString("log.txt"), PdfFormat.PDF_A_3A, ConvertErrorAction.Delete)
            ' Save resultant file
            doc.Save(dataDir & Convert.ToString("AddAttachmentToPDFA_out_.pdf"))
            ' ExEnd:AddAttachmentToPDFA
            Console.WriteLine(Convert.ToString(vbLf & "Attachment added successfully to PDF/A file." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace