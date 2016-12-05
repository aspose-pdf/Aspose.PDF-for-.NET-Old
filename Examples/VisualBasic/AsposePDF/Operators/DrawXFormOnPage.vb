Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports AP = Aspose.Pdf

Namespace AsposePDF.Operators
    Public Class DrawXFormOnPage
        Public Shared Sub Run()
            ' ExStart:DrawXFormOnPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Operators()


            Dim imageFile As String = dataDir & Convert.ToString("aspose-logo.jpg")
            Dim inFile As String = dataDir & Convert.ToString("DrawXFormOnPage.pdf")
            Dim outFile As String = dataDir & Convert.ToString("blank-sample2_out_.pdf")

            Using doc As New Document(inFile)
                Dim pageContents As OperatorCollection = doc.Pages(1).Contents

                ' The sample demonstrates 
                ' GSave/GRestore operators usage
                ' ContatenateMatrix operator usage to position xForm
                ' Do operator usage to draw xForm on page

                ' Wrap existing contents with GSave/GRestore operators pair
                '        this is to get initial graphics state at the and of existing contents
                '        otherwise there might remain some undesirable transformations at the end of existing operators chain
                pageContents.Insert(1, New AP.Operator.GSave())
                pageContents.Add(New AP.Operator.GRestore())

                ' Add save graphics state operator to properly clear graphics state after new commands
                pageContents.Add(New AP.Operator.GSave())

                '#Region "create xForm"

                ' Create xForm
                Dim form As XForm = XForm.CreateNewForm(doc.Pages(1), doc)
                doc.Pages(1).Resources.Forms.Add(form)
                form.Contents.Add(New AP.Operator.GSave())
                ' Define image width and heigh
                form.Contents.Add(New AP.Operator.ConcatenateMatrix(200, 0, 0, 200, 0, 0))
                ' Load image into stream
                Dim imageStream As Stream = New FileStream(imageFile, FileMode.Open)
                ' Add image to Images collection of the XForm Resources
                form.Resources.Images.Add(imageStream)
                Dim ximage As XImage = form.Resources.Images(form.Resources.Images.Count)
                ' Using Do operator: this operator draws image
                form.Contents.Add(New AP.Operator.Do(ximage.Name))
                form.Contents.Add(New AP.Operator.GRestore())

                '#End Region

                pageContents.Add(New AP.Operator.GSave())
                ' Place form to the x=100 y=500 coordinates
                pageContents.Add(New AP.Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 500))
                ' Draw form with Do operator
                pageContents.Add(New AP.Operator.Do(form.Name))
                pageContents.Add(New AP.Operator.GRestore())

                pageContents.Add(New AP.Operator.GSave())
                ' Place form to the x=100 y=300 coordinates
                pageContents.Add(New AP.Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 300))
                ' Draw form with Do operator
                pageContents.Add(New AP.Operator.Do(form.Name))
                pageContents.Add(New AP.Operator.GRestore())

                ' Restore grahics state with GRestore after the GSave
                pageContents.Add(New AP.Operator.GRestore())
                doc.Save(outFile)
            End Using
            ' ExEnd:DrawXFormOnPage
        End Sub
    End Class
End Namespace