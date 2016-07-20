Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Attachments
    Public Class AttachAnyFile
        Public Shared Sub Run()
            ' ExStart:AttachAnyFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Attachments()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate attachment instance by calling its empty constructor
            Dim fileAttachment As New Aspose.Pdf.Generator.Attachment()

            ' Add attachment in the paragraphs collection of the section
            sec1.Paragraphs.Add(fileAttachment)

            ' Set attachment type to File using AttachmentType enumeration
            fileAttachment.AttachmentType = Aspose.Pdf.Generator.AttachmentType.File

            ' Set the path of the attachment file. This could be any file like doc, tif etc
            fileAttachment.AttachedFileName = dataDir & Convert.ToString("input.pdf")

            ' Set the type of the file to be attached
            fileAttachment.AttachedFileType = "pdf"

            ' Set the file icon type to Graph
            fileAttachment.FileIconType = Aspose.Pdf.Generator.FileIconType.Graph

            ' Set the color of the icon to Brown
            fileAttachment.IconColor = New Aspose.Pdf.Generator.Color("Brown")

            dataDir = dataDir & Convert.ToString("AttachAnyFile_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:AttachAnyFile           
        End Sub
    End Class
End Namespace