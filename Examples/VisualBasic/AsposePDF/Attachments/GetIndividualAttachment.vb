Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.Attachments
    Public Class GetIndividualAttachment
        Public Shared Sub Run()
            ' ExStart:GetIndividualAttachment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Attachments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetIndividualAttachment.pdf"))

            ' Get particular embedded file
            Dim fileSpecification As FileSpecification = pdfDocument.EmbeddedFiles(1)

            ' Get the file properties
            Console.WriteLine("Name: {0}", fileSpecification.Name)
            Console.WriteLine("Description: {0}", fileSpecification.Description)
            Console.WriteLine("Mime Type: {0}", fileSpecification.MIMEType)

            ' Check if parameter object contains the parameters
            If fileSpecification.Params IsNot Nothing Then
                Console.WriteLine("CheckSum: {0}", fileSpecification.Params.CheckSum)
                Console.WriteLine("Creation Date: {0}", fileSpecification.Params.CreationDate)
                Console.WriteLine("Modification Date: {0}", fileSpecification.Params.ModDate)
                Console.WriteLine("Size: {0}", fileSpecification.Params.Size)
            End If


            ' Get the attachment and write to file or stream
            Dim fileContent(Convert.ToInt32(fileSpecification.Contents.Length - 1)) As Byte
            fileSpecification.Contents.Read(fileContent, 0, fileContent.Length)

            Dim fileStream As New FileStream((dataDir & Convert.ToString("test_out_")) + ".txt", FileMode.Create)
            fileStream.Write(fileContent, 0, fileContent.Length)
            fileStream.Close()
            ' ExEnd:GetIndividualAttachment
        End Sub
    End Class
End Namespace
