Module RoundShapeMod

    Public Sub RoundShapeTop(ByVal ctl As System.Windows.Forms.Control, Optional ByVal CirRay As Single = 20)
        Dim gr As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
        gr.AddPie(0, 0, CirRay, CirRay, 180.0!, 90.0!)
        gr.AddPie(ctl.Width - CirRay, 0, CirRay, CirRay, 270.0!, 90.0!)
        'gr.AddPie(0, ctl.Height - CirRay, CirRay, CirRay, 90.0!, 90.0!)
        'gr.AddPie(ctl.Width - CirRay, 0, ctl.Height - CirRay, CirRay, 0.0!, 90.0!)

        gr.AddRectangle(New System.Drawing.Rectangle(CirRay / 2, 0, ctl.Width - CirRay, ctl.Height))
        gr.AddRectangle(New System.Drawing.Rectangle(0, CirRay / 2, CirRay / 2, ctl.Height - (CirRay / 2)))
        gr.AddRectangle(New System.Drawing.Rectangle(ctl.Width - CirRay / 2, CirRay / 2, CirRay / 2, ctl.Height - (CirRay / 2)))
        'gr.AddRectangle(New System.Drawing.Rectangle(ctl.Width - CirRay, CirRay / 2, CirRay / 2, ctl.Height - CirRay))

        ctl.Region = New System.Drawing.Region(gr)
    End Sub

    Public Sub RoundShapeBottom(ByVal ctl As System.Windows.Forms.Control, Optional ByVal CirRay As Single = 20)
        Dim gr As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
        'gr.AddPie(0, 0, CirRay, CirRay, 180.0!, 90.0!)
        'gr.AddPie(ctl.Width - CirRay, 0, CirRay, CirRay, 270.0!, 90.0!)
        gr.AddPie(0, ctl.Height - CirRay, CirRay, CirRay, 90.0!, 90.0!)
        gr.AddPie(ctl.Width - CirRay, ctl.Height - CirRay, CirRay, CirRay, 0.0!, 90.0!)

        gr.AddRectangle(New System.Drawing.Rectangle(CirRay / 2, 0, ctl.Width - CirRay, ctl.Height))
        gr.AddRectangle(New System.Drawing.Rectangle(0, 0, CirRay / 2, ctl.Height - (CirRay / 2)))
        gr.AddRectangle(New System.Drawing.Rectangle(ctl.Width - CirRay / 2, 0, CirRay / 2, ctl.Height - (CirRay / 2)))

        ctl.Region = New System.Drawing.Region(gr)
    End Sub

    Public Sub RoundShapeAll(ByVal ctl As System.Windows.Forms.Control, Optional ByVal CirRay As Single = 20)
        Dim gr As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
        gr.AddPie(0, 0, CirRay, CirRay, 180.0!, 90.0!)
        gr.AddPie(ctl.Width - CirRay, 0, CirRay, CirRay, 270.0!, 90.0!)
        gr.AddPie(0, ctl.Height - CirRay, CirRay, CirRay, 90.0!, 90.0!)
        gr.AddPie(ctl.Width - CirRay, ctl.Height - CirRay, CirRay, CirRay, 0.0!, 90.0!)

        gr.AddRectangle(New System.Drawing.Rectangle(CirRay / 2, 0, ctl.Width - CirRay, ctl.Height))
        gr.AddRectangle(New System.Drawing.Rectangle(0, CirRay / 2, CirRay / 2, ctl.Height - CirRay))
        gr.AddRectangle(New System.Drawing.Rectangle(ctl.Width - CirRay / 2, CirRay / 2, CirRay / 2, ctl.Height - CirRay))

        ctl.Region = New System.Drawing.Region(gr)
    End Sub
End Module
