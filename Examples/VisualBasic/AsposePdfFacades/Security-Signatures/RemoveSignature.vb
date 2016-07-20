Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Collections
Imports Aspose.Pdf.Forms

Namespace AsposePDFFacades.SecuritySignatures
    Public Class RemoveSignature
        Public Shared Sub Run()
            Try
                ' ExStart:RemoveSignature                
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures()
                ' Create PdfFileSignature object
                Dim pdfSign As New PdfFileSignature()
                ' Open PDF document
                pdfSign.BindPdf(dataDir & Convert.ToString("DigitallySign.pdf"))
                ' Get list of signature names
                Dim names As IList = pdfSign.GetSignNames()
                ' Remove all the signatures from the PDF file
                For index As Integer = 0 To names.Count - 1
                    pdfSign.RemoveSignature(DirectCast(names(index), String))
                Next
                ' Save updated PDF file
                ' ExEnd:RemoveSignature
                pdfSign.Save(dataDir & Convert.ToString("RemoveSignature_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Private Shared Sub Run_34561_tests()
            ' ExStart:Run_34561_tests
            ' New License().SetLicense("E:\Aspose.Pdf.lic")
            Dim inSingleSignedFile As String = "C:\pdftest\PDFNEWNET_34561_SingleSigned.pdf"
            Dim outSingleUnsignedFile As String = "C:\pdftest\PDFNEWNET_34561_SingleUnSigned.pdf"
            Dim inOutSingleResignedFile As String = "C:\pdftest\PDFNEWNET_34561_SingleReSigned.pdf"

            Dim pdfSignSingle As New PdfFileSignature()
            pdfSignSingle.BindPdf(inSingleSignedFile)
            Dim names As IList = pdfSignSingle.GetSignNames()
            Dim pfx As Stream = New FileStream("C:\pdftest\test1.pfx", FileMode.Open)
            Dim pcks As New PKCS7(pfx, "test1")
            Dim sigNameSingle As String = TryCast(names(0), String)
            If sigNameSingle IsNot Nothing AndAlso sigNameSingle <> String.Empty Then
                pdfSignSingle.RemoveSignature(sigNameSingle, False)
                pdfSignSingle.Save(outSingleUnsignedFile)

                Dim pdfSignSingle2 As New PdfFileSignature()
                pdfSignSingle2.BindPdf(outSingleUnsignedFile)
                pdfSignSingle2.SignatureAppearance = "C:\pdftest\butterfly.jpg"
                pdfSignSingle2.Sign("Signature1", pcks)
                pdfSignSingle2.Save(inOutSingleResignedFile)
                pdfSignSingle2.BindPdf(inOutSingleResignedFile)
                ' Assert.True(pdfSignSingle2.VerifySignature("Signature1"));
                Console.Write("Signature 1 check result : " + pdfSignSingle2.VerifySignature("Signature1").ToString() + " " & vbLf)
            End If

            ' Test file with multiple signatures
            Dim inManySignedFile As String = "C:\pdftest\PDFNEWNET_34561_ManySigned.pdf"
            Dim outManyUnsignedFile As String = "C:\pdftest\PDFNEWNET_34561_ManyUnSigned.pdf"
            Dim inOutManyResignedFile As String = "C:\pdftest\PDFNEWNET_34561_ManyReSigned.pdf"
            Dim pdfSignMany As PdfFileSignature = New Aspose.Pdf.Facades.PdfFileSignature(inManySignedFile)

            Dim sigNames As IList = pdfSignMany.GetSignNames()
            For Each sigName As String In sigNames
                pdfSignMany.RemoveSignature(sigName, False)
            Next

            pdfSignMany.Save(outManyUnsignedFile)

            Dim pdfSignMany2 As New PdfFileSignature()
            pdfSignMany2.BindPdf(outManyUnsignedFile)
            pdfSignMany2.Sign("Signature1", pcks)
            pdfSignMany2.Save(inOutManyResignedFile)
            pdfSignMany2.BindPdf(inOutSingleResignedFile)
            ' Assert.IsTrue(pdfSignMany2.VerifySignature("Signature1"));
            Console.Write("Signature 2 check result : " + pdfSignMany2.VerifySignature("Signature1").ToString() + " ")
            ' ExEnd:Run_34561_tests
        End Sub
    End Class
End Namespace
