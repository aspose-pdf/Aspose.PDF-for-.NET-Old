Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Forms
Imports Aspose.Pdf
Namespace AsposePDF.Forms
    Public Class GetCoordinates
        Public Shared Sub Run()
            Try
                ' ExStart:GetCoordinates
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Forms()

                ' Load the output document 
                Dim doc1 As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Find added fields
                Dim field0 As RadioButtonField = TryCast(doc1.Form("Item1"), RadioButtonField)
                Dim field1 As RadioButtonField = TryCast(doc1.Form("Item2"), RadioButtonField)
                Dim field2 As RadioButtonField = TryCast(doc1.Form("Item3"), RadioButtonField)

                ' And show positions of sub items for each of them. 
                For Each [option] As RadioButtonOptionField In field0
                    Console.WriteLine([option].Rect)
                Next
                For Each [option] As RadioButtonOptionField In field1
                    Console.WriteLine([option].Rect)
                Next
                For Each [option] As RadioButtonOptionField In field2
                    Console.WriteLine([option].Rect)
                    ' ExEnd:GetCoordinates                
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub
    End Class
End Namespace
