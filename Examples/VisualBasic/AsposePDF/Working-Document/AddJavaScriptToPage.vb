Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class AddJavaScriptToPage
        Public Shared Sub Run()
            ' ExStart:AddJavaScriptToPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Load an existing PDF files
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Adding JavaScript at Document Level
            ' Instantiate JavascriptAction with desried JavaScript statement
            Dim javaScript As New JavascriptAction("this.print({bUI:true,bSilent:false,bShrinkToFit:true});")

            ' Assign JavascriptAction object to desired action of Document
            doc.OpenAction = javaScript

            ' Adding JavaScript at Page Level
            doc.Pages(2).Actions.OnOpen = New JavascriptAction("app.alert(' Page 1 opened')")
            doc.Pages(2).Actions.OnClose = New JavascriptAction("app.alert(' Page 1 closed')")

            dataDir = dataDir & Convert.ToString("JavaScript-Added_out_.pdf")
            ' Save PDF Document
            doc.Save(dataDir)
            ' ExEnd:AddJavaScriptToPage
            Console.WriteLine(Convert.ToString(vbLf & "Javascript added successfully to a page." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

