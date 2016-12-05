Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Text
Imports System.Collections

Namespace AsposePDF.WorkingDocuments
    Public Class AddRemoveJavascriptToDoc
        Public Shared Sub Run()
            ' ExStart:AddRemoveJavascriptToDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_WorkingDocuments()

            Dim doc As New Document()
            doc.Pages.Add()
            doc.JavaScript("func1") = "function func1() { hello(); }"
            doc.JavaScript("func2") = "function func2() { hello(); }"
            doc.Save(dataDir & Convert.ToString("AddJavascript.pdf"))

            ' Remove Document level JavaScript
            Dim doc1 As New Document(dataDir & Convert.ToString("AddJavascript.pdf"))
            Dim keys As IList = DirectCast(doc1.JavaScript.Keys, System.Collections.IList)
            Console.WriteLine("=============================== ")
            For Each key As String In keys
                Console.WriteLine((key & Convert.ToString(" ==> ")) + doc1.JavaScript(key))
            Next

            doc1.JavaScript.Remove("func1")
            Console.WriteLine("Key ' Func1' Removed ")
            Console.WriteLine("=============================== ")
            ' ExEnd:AddRemoveJavascriptToDoc
            Console.WriteLine(vbLf & "Javascript added/removed successfully to a document.")
        End Sub
    End Class
End Namespace
