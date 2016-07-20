Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Forms
Imports System.Collections

Namespace AsposePDF.SecuritySignatures
    Public Class DigitallySignWithTimeStamp
        Public Shared Sub Run()
            ' ExStart:DigitallySignWithTimeStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()
            Dim pfxFile As String = ""
            Using document As New Document(dataDir & Convert.ToString("DigitallySign.pdf"))
                Using signature As New PdfFileSignature(document)
                    Dim pkcs As New PKCS7(pfxFile, "pfx_password")
                    Dim timestampSettings As New TimestampSettings("https:\your_timestamp_settings", "user:password")
                    ' User/Password can be omitted
                    pkcs.TimestampSettings = timestampSettings
                    Dim rect As New System.Drawing.Rectangle(100, 100, 200, 100)
                    ' Create any of the three signature types
                    signature.Sign(1, "Signature Reason", "Contact", "Location", True, rect, _
                        pkcs)
                    ' Save output PDF file
                    signature.Save(dataDir & Convert.ToString("DigitallySignWithTimeStamp_out_.pdf"))
                End Using
            End Using
            ' ExEnd:DigitallySignWithTimeStamp
        End Sub
    End Class
End Namespace