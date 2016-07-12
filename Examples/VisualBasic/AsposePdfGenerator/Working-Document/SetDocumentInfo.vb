Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.WorkingDocuments
    Public Class SetDocumentInfo
        Public Shared Sub Run()
            ' ExStart:SetDocumentInfo
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Set the properties of Pdf instance
            pdf1.Author = "Naeem Akram"
            pdf1.Creator = "Aspose.Pdf"
            pdf1.Keywords = "Hello World"
            pdf1.Subject = "Example"
            pdf1.Title = "Example"
            dataDir = dataDir & Convert.ToString("DocInfo_out_.pdf")
            pdf1.Save(dataDir)
            ' ExEnd:SetDocumentInfo 
            Console.WriteLine(Convert.ToString(vbLf & "Document Info setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
