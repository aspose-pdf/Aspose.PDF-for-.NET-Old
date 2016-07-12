Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Attachments
    Public Class GetAlltheAttachments
        Public Shared Sub Run()
            ' ExStart:GetAlltheAttachments
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Attachments()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetAlltheAttachments.pdf"))

            ' Get embedded files collection
            Dim embeddedFiles As EmbeddedFileCollection = pdfDocument.EmbeddedFiles

            ' Get count of the embedded files
            Console.WriteLine("Total files : {0}", embeddedFiles.Count)

            Dim count As Integer = 1

            ' Loop through the collection to get all the attachments
            For Each fileSpecification As FileSpecification In embeddedFiles
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
                Dim fileContent As Byte() = New Byte(fileSpecification.Contents.Length - 1) {}
                fileSpecification.Contents.Read(fileContent, 0, fileContent.Length)
                Dim fileStream As New FileStream((dataDir & count) + "_out_" + ".txt", FileMode.Create)
                fileStream.Write(fileContent, 0, fileContent.Length)
                fileStream.Close()
                count += 1
            Next
            ' ExEnd:GetAlltheAttachments
        End Sub
    End Class
End Namespace
