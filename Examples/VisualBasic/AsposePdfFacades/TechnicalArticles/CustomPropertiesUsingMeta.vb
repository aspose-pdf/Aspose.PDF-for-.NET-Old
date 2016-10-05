Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class CustomPropertiesUsingMeta
        Public Shared Sub Run()
            ' ExStart:CustomPropertiesUsingMeta
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create instance of PdfFileInfo object
            Dim fInfo As New Aspose.Pdf.Facades.PdfFileInfo(dataDir & Convert.ToString("inFile1.pdf"))

            ' Retrieve all existing custom attributes
            Dim hTable As System.Collections.Hashtable = New Hashtable(fInfo.Header)

            Dim enumerator As IDictionaryEnumerator = hTable.GetEnumerator()
            While enumerator.MoveNext()
                Dim output As String = enumerator.Key.ToString() + " " + enumerator.Value.ToString()
            End While

            ' Set new customer attribute as meta info
            fInfo.SetMetaInfo("CustomAttribute", "test value")

            ' Get custom attribute from meta info by specifying attribute/property name
            Dim value As String = fInfo.GetMetaInfo("CustomAttribute")
            ' ExEnd:CustomPropertiesUsingMeta                      
        End Sub
    End Class
End Namespace
