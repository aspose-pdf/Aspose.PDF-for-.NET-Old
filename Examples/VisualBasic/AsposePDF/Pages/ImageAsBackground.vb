Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Pages
    Public Class ImageAsBackground
        Public Shared Sub Run()
            ' ExStart:ImageAsBackground
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Pages()

            ' Create a new Document object
            Dim doc As New Document()

            ' Add a new page to document object
            Dim page As Page = doc.Pages.Add()

            ' Create Background Artifact object
            Dim background As New BackgroundArtifact()

            ' Specify the image for backgroundartifact object
            background.BackgroundImage = File.OpenRead(dataDir & Convert.ToString("aspose-total-for-net.jpg"))

            ' Add backgroundartifact to artifacts collection of page
            page.Artifacts.Add(background)

            dataDir = dataDir & Convert.ToString("ImageAsBackground_out_.pdf")
            ' Save the document
            doc.Save(dataDir)
            ' ExEnd:ImageAsBackground
            System.Console.WriteLine(Convert.ToString(vbLf & "Image as page background added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

