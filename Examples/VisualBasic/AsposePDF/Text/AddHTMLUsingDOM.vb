Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Microsoft.VisualBasic

Namespace AsposePDF.Text
    Public Class AddHTMLUsingDOM
        Public Shared Sub Run()
            ' ExStart:AddHTMLUsingDOM
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Instantiate Document object
            Dim doc As New Document()
            ' Add a page to pages collection of PDF file
            Dim page As Page = doc.Pages.Add()
            ' Instantiate HtmlFragment with HTML contnets
            Dim titel As New HtmlFragment("<fontsize=10><b><i>Table</i></b></fontsize>")
            ' Set bottom margin information
            titel.Margin.Bottom = 10
            ' Set top margin information
            titel.Margin.Top = 200
            ' Add HTML Fragment to paragraphs collection of page
            page.Paragraphs.Add(titel)

            dataDir = dataDir & "AddHTMLUsingDOM_out_.pdf"
            ' Save PDF file
            doc.Save(dataDir)
            ' ExEnd:AddHTMLUsingDOM  
            Console.WriteLine(Convert.ToString(vbLf & "HTML using DOM added successfully." & vbLf & "File saved at ") + dataDir)
        End Sub
    End Class
End Namespace