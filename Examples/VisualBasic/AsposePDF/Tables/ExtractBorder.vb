Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Collections
Imports Aspose.Pdf
Imports AP = Aspose.Pdf
Imports Aspose.Pdf.Annotations

Namespace AsposePDF.Tables
    Public Class ExtractBorder
        Public Shared Sub Run()
            ' ExStart:ExtractBorder
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            Dim graphicsState As New Stack()
            Dim bitmap As New System.Drawing.Bitmap(CInt(doc.Pages(1).PageInfo.Width), CInt(doc.Pages(1).PageInfo.Height))
            Dim graphicsPath As New System.Drawing.Drawing2D.GraphicsPath()
            ' Default ctm matrix value is 1,0,0,1,0,0
            Dim lastCTM As New System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 0, 0)
            ' System.Drawing coordinate system is top left based, while pdf coordinate system is low left based, so we have to apply the inversion matrix
            Dim inversionMatrix As New System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 0, CSng(doc.Pages(1).PageInfo.Height))
            Dim lastPoint As New System.Drawing.PointF(0, 0)
            Dim fillColor As System.Drawing.Color = System.Drawing.Color.FromArgb(0, 0, 0)
            Dim strokeColor As System.Drawing.Color = System.Drawing.Color.FromArgb(0, 0, 0)

            Using gr As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bitmap)
                gr.SmoothingMode = SmoothingMode.HighQuality
                graphicsState.Push(New System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 0, 0))

                ' Process all the contents commands
                For Each op As [Operator] In doc.Pages(1).Contents
                    Dim opSaveState As AP.Operator.GSave = TryCast(op, AP.Operator.GSave)
                    Dim opRestoreState As AP.Operator.GRestore = TryCast(op, AP.Operator.GRestore)
                    Dim opCtm As AP.Operator.ConcatenateMatrix = TryCast(op, AP.Operator.ConcatenateMatrix)
                    Dim opMoveTo As AP.Operator.MoveTo = TryCast(op, AP.Operator.MoveTo)
                    Dim opLineTo As AP.Operator.LineTo = TryCast(op, AP.Operator.LineTo)
                    Dim opRe As AP.Operator.Re = TryCast(op, AP.Operator.Re)
                    Dim opEndPath As AP.Operator.EndPath = TryCast(op, AP.Operator.EndPath)
                    Dim opStroke As AP.Operator.Stroke = TryCast(op, AP.Operator.Stroke)
                    Dim opFill As AP.Operator.Fill = TryCast(op, AP.Operator.Fill)
                    Dim opEOFill As AP.Operator.EOFill = TryCast(op, AP.Operator.EOFill)
                    Dim opRGBFillColor As AP.Operator.SetRGBColor = TryCast(op, AP.Operator.SetRGBColor)
                    Dim opRGBStrokeColor As AP.Operator.SetRGBColorStroke = TryCast(op, AP.Operator.SetRGBColorStroke)

                    If opSaveState IsNot Nothing Then
                        ' Save previous state and push current state to the top of the stack
                        graphicsState.Push(DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix).Clone())
                        lastCTM = DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix)
                    ElseIf opRestoreState IsNot Nothing Then
                        ' Throw away current state and restore previous one
                        graphicsState.Pop()
                        lastCTM = DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix)
                    ElseIf opCtm IsNot Nothing Then
                        Dim cm As New System.Drawing.Drawing2D.Matrix(CSng(opCtm.Matrix.A), CSng(opCtm.Matrix.B), CSng(opCtm.Matrix.C), CSng(opCtm.Matrix.D), CSng(opCtm.Matrix.E), CSng(opCtm.Matrix.F))

                        ' Multiply current matrix with the state matrix
                        DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix).Multiply(cm)
                        lastCTM = DirectCast(graphicsState.Peek(), System.Drawing.Drawing2D.Matrix)
                    ElseIf opMoveTo IsNot Nothing Then
                        lastPoint = New System.Drawing.PointF(CSng(opMoveTo.X), CSng(opMoveTo.Y))
                    ElseIf opLineTo IsNot Nothing Then
                        Dim linePoint As New System.Drawing.PointF(CSng(opLineTo.X), CSng(opLineTo.Y))
                        graphicsPath.AddLine(lastPoint, linePoint)

                        lastPoint = linePoint
                    ElseIf opRe IsNot Nothing Then
                        Dim re As New System.Drawing.RectangleF(CSng(opRe.X), CSng(opRe.Y), CSng(opRe.Width), CSng(opRe.Height))
                        graphicsPath.AddRectangle(re)
                    ElseIf opEndPath IsNot Nothing Then
                        graphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                    ElseIf opRGBFillColor IsNot Nothing Then
                        fillColor = opRGBFillColor.getColor()
                    ElseIf opRGBStrokeColor IsNot Nothing Then
                        strokeColor = opRGBStrokeColor.getColor()
                    ElseIf opStroke IsNot Nothing Then
                        graphicsPath.Transform(lastCTM)
                        graphicsPath.Transform(inversionMatrix)
                        gr.DrawPath(New System.Drawing.Pen(strokeColor), graphicsPath)
                        graphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                    ElseIf opFill IsNot Nothing Then
                        graphicsPath.FillMode = FillMode.Winding
                        graphicsPath.Transform(lastCTM)
                        graphicsPath.Transform(inversionMatrix)
                        gr.FillPath(New System.Drawing.SolidBrush(fillColor), graphicsPath)
                        graphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                    ElseIf opEOFill IsNot Nothing Then
                        graphicsPath.FillMode = FillMode.Alternate
                        graphicsPath.Transform(lastCTM)
                        graphicsPath.Transform(inversionMatrix)
                        gr.FillPath(New System.Drawing.SolidBrush(fillColor), graphicsPath)
                        graphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                    End If
                Next
            End Using
            dataDir = dataDir & Convert.ToString("ExtractBorder_out_.png")
            bitmap.Save(dataDir, ImageFormat.Png)
            ' ExEnd:ExtractBorder
            Console.WriteLine(Convert.ToString(vbLf & "Border extracted successfully as image." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace