Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text

Namespace AsposePDF.WorkingDocuments
    Public Class SetExpiryDate
        Public Shared Sub Run()
            ' ExStart:SetExpiryDate 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            ' Instantiate Document object
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            doc.Pages.Add()
            ' Add text fragment to paragraphs collection of page object
            doc.Pages(1).Paragraphs.Add(New TextFragment("Hello World..."))
            ' Create JavaScript object to set PDF expiry date
            Dim javaScript As New JavascriptAction("var year=2017;" + "var month=5;" + "today = new Date(); today = new Date(today.getFullYear(), today.getMonth());" + "expiry = new Date(year, month);" + "if (today.getTime() > expiry.getTime())" + "app.alert(' The file is expired. You need a new one.');")
            ' Set JavaScript as PDF open action
            doc.OpenAction = javaScript

            dataDir = dataDir & Convert.ToString("SetExpiryDate_out_.pdf")
            ' Save PDF Document
            doc.Save(dataDir)
            ' ExEnd:SetExpiryDate 
            Console.WriteLine(Convert.ToString(vbLf & "PDF expiry date setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
