Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PDFSigningMechanism
        Public Shared Sub Run()
            ' ExStart:PDFSigningMechanism
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            Dim doc As New Document(dataDir & Convert.ToString("inFile.pdf"))
            ' Create PdfFileSignature object and bind input and output PDF files
            Dim pdfSign As New PdfFileSignature(doc)
            ' Create a rectangle for signature location
            Dim rect As New System.Drawing.Rectangle(100, 100, 200, 100)
            ' Set signature appearance
            pdfSign.SignatureAppearance = dataDir & Convert.ToString("aspose-logo.jpg")

            ' Create any of the three signature types
            Dim signature As New PKCS1(dataDir & Convert.ToString("inFile2.pdf"), "password")

            pdfSign.Sign(1, "Signature Reason", "Alice", "Odessa", True, rect, _
                signature)
            ' ExEnd:PDFSigningMechanism                      
        End Sub
        Public Shared Sub AddSignatureFields()
            ' ExStart:AddSignatureFields
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()
            Dim doc As New Document(dataDir & Convert.ToString("inFile.pdf"))
            ' Create FormEditor object
            Dim editor As New FormEditor(doc)
            ' Add signature fields
            editor.AddField(FieldType.Signature, "Signature from Alice", 1, 10, 10, 110, _
                110)
            editor.AddField(FieldType.Signature, "Signature from John", 1, 120, 150, 220, _
                250)
            editor.AddField(FieldType.Signature, "Signature from Smith", 1, 300, 200, 400, _
                300)
            ' Save the form
            editor.Save(dataDir & Convert.ToString("AddSignatureFields_1_out_.pdf"))

            Dim doc2 As New Document(dataDir & Convert.ToString("inFile2.pdf"))
            ' Add signature to any of the signature fields
            Dim pdfSign As New PdfFileSignature(doc2)
            pdfSign.Sign("Signature from John", "Signature Reason", "John", "Kharkov", New PKCS1("inFile1.pdf", "password"))
            ' Each time new signature is added you must save the document
            pdfSign.Save(dataDir & Convert.ToString("AddSignatureFields_2_out_.pdf"))

            Dim doc3 As New Document(dataDir & Convert.ToString("FilledForm.pdf"))
            ' Add second signature
            Dim pdfSign2 As New PdfFileSignature(doc3)
            pdfSign2.Sign("Signature from Alice", "Signature Reason", "Alice", "Odessa", New PKCS1(dataDir & Convert.ToString("FilledForm - 2.pfx"), "password"))
            ' Each time new signature is added you must save the document
            pdfSign2.Save(dataDir & Convert.ToString("AddSignatureFields_3_out_.pdf"))
            ' ExEnd:AddSignatureFields
        End Sub
        Public Shared Sub VerifySignatures()
            ' ExStart:VerifySignatures
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()
            ' Create PdfFileSignature object
            Dim pdfVerify As New PdfFileSignature()
            ' Bind input PDF file
            pdfVerify.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            ' Check if PDF contains signature
            Dim isSigned As Boolean = pdfVerify.ContainsSignature()
            ' All signatures have names Signaure#, this names kit generates automatically
            Dim isSignatureVerified As Boolean = pdfVerify.VerifySignature("Signature1")
            ' However we can set necessary name manualy if we use signature fields (see below)
            Dim isSignatureVerified2 As Boolean = pdfVerify.VerifySignature("Signature from Alice")
            ' ExEnd:VerifySignatures
        End Sub
    End Class
End Namespace
