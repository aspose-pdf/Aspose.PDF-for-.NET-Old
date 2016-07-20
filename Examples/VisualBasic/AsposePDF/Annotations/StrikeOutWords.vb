Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Annotations
    Public Class StrikeOutWords
        Public Shared Sub Run()

            ' ExStart:StrikeOutWords
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Create TextFragment Absorber instance to search particular text fragment
            Dim textFragmentAbsorber As New TextFragmentAbsorber("Estoque")
            ' Iterate through pages of PDF document
            For i As Integer = 1 To document.Pages.Count
                ' Get first page of PDF document
                Dim page As Page = document.Pages(1)
                page.Accept(textFragmentAbsorber)
            Next

            ' Create a collection of Absorbed text
            Dim textFragmentCollection As TextFragmentCollection = textFragmentAbsorber.TextFragments

            ' Iterate on above collection
            For j As Integer = 1 To textFragmentCollection.Count
                Dim textFragment As TextFragment = textFragmentCollection(j)

                ' Get rectangular dimensions of TextFragment object  	
                Dim rect As New Rectangle(CSng(textFragment.Position.XIndent), CSng(textFragment.Position.YIndent), CSng(textFragment.Position.XIndent) + CSng(textFragment.Rectangle.Width), CSng(textFragment.Position.YIndent) + CSng(textFragment.Rectangle.Height))

                ' Instantiate StrikeOut Annotation instance
                Dim strikeOut As New StrikeOutAnnotation(textFragment.Page, rect)
                ' Set opacity for annotation
                strikeOut.Opacity = 0.8F
                ' Set the border for annotation instance
                strikeOut.Border = New Border(strikeOut)
                ' Set the color of annotation
                strikeOut.Color = Color.Red
                ' Add annotation to annotations collection of TextFragment
                textFragment.Page.Annotations.Add(strikeOut)
            Next
            dataDir = dataDir & Convert.ToString("StrikeOutWords_out_.pdf")
            document.Save(dataDir)
            ' ExEnd:StrikeOutWords    
            Console.WriteLine(Convert.ToString(vbLf & "Words strikeout successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace

