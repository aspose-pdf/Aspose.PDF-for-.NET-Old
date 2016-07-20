Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Operator
Imports APO = Aspose.Pdf.Operator

Namespace AsposePDF.Images
    Public Class ImageInformation
        Public Shared Sub Run()
            ' ExStart:ImageInformation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            ' Load the source PDF file
            Dim doc As New Document(dataDir & Convert.ToString("ImageInformation.pdf"))

            ' Define the default resolution for image
            Dim defaultResolution As Integer = 72
            Dim graphicsState As New System.Collections.Stack()
            ' Define array list object which will hold image names
            Dim imageNames As New System.Collections.ArrayList(doc.Pages(1).Resources.Images.Names)
            ' Insert an object to stack
            graphicsState.Push(New System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 0, 0))

            ' Get all the operators on first page of document
            For Each op As [Operator] In doc.Pages(1).Contents
                ' Use GSave/GRestore operators to revert the transformations back to previously set
                Dim opSaveState As GSave = TryCast(op, GSave)
                Dim opRestoreState As GRestore = TryCast(op, GRestore)
                ' Instantiate ConcatenateMatrix object as it defines current transformation matrix.
                Dim opCtm As ConcatenateMatrix = TryCast(op, ConcatenateMatrix)
                ' Create Do operator which draws objects from resources. It draws Form objects and Image objects
                Dim opDo As APO.Do = TryCast(op, APO.Do)

                If opSaveState IsNot Nothing Then
                    ' Save previous state and push current state to the top of the stack
                    graphicsState.Push(DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix).Clone())
                ElseIf opRestoreState IsNot Nothing Then
                    ' Throw away current state and restore previous one
                    graphicsState.Pop()
                ElseIf opCtm IsNot Nothing Then
                    Dim cm As New System.Drawing.Drawing2D.Matrix(CSng(opCtm.Matrix.A), CSng(opCtm.Matrix.B), CSng(opCtm.Matrix.C), CSng(opCtm.Matrix.D), CSng(opCtm.Matrix.E), CSng(opCtm.Matrix.F))

                    ' Multiply current matrix with the state matrix
                    DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix).Multiply(cm)

                    Continue For
                ElseIf opDo IsNot Nothing Then
                    ' In case this is an image drawing operator
                    If imageNames.Contains(opDo.Name) Then
                        Dim lastCTM As System.Drawing.Drawing2D.Matrix = DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix)
                        ' Create XImage object to hold images of first pdf page
                        Dim image As XImage = doc.Pages(1).Resources.Images(opDo.Name)

                        ' Get image dimensions
                        Dim scaledWidth As Double = Math.Sqrt(Math.Pow(lastCTM.Elements(0), 2) + Math.Pow(lastCTM.Elements(1), 2))
                        Dim scaledHeight As Double = Math.Sqrt(Math.Pow(lastCTM.Elements(2), 2) + Math.Pow(lastCTM.Elements(3), 2))
                        ' Get Height and Width information of image
                        Dim originalWidth As Double = image.Width
                        Dim originalHeight As Double = image.Height

                        ' Compute resolution based on above information
                        Dim resHorizontal As Double = originalWidth * defaultResolution / scaledWidth
                        Dim resVertical As Double = originalHeight * defaultResolution / scaledHeight

                        ' Display Dimension and Resolution information of each image
                        Console.Out.WriteLine(String.Format(dataDir & Convert.ToString("image {0} ({1:.##}:{2:.##}): res {3:.##} x {4:.##}"), opDo.Name, scaledWidth, scaledHeight, resHorizontal, resVertical))
                    End If
                End If
            Next
            ' ExEnd:ImageInformation

        End Sub
    End Class
End Namespace