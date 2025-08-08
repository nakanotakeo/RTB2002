<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMportASK
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelLeftCCOsc = New System.Windows.Forms.Label()
        Me.TextBoxLeftCOsc = New System.Windows.Forms.TextBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextBoxLeftVCh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLeftICh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelLeftCCOsc
        '
        Me.LabelLeftCCOsc.AutoSize = True
        Me.LabelLeftCCOsc.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftCCOsc.Location = New System.Drawing.Point(40, 38)
        Me.LabelLeftCCOsc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLeftCCOsc.Name = "LabelLeftCCOsc"
        Me.LabelLeftCCOsc.Size = New System.Drawing.Size(240, 31)
        Me.LabelLeftCCOsc.TabIndex = 0
        Me.LabelLeftCCOsc.Text = "Oscillo USB Serial Port"
        Me.LabelLeftCCOsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxLeftCOsc
        '
        Me.TextBoxLeftCOsc.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxLeftCOsc.Location = New System.Drawing.Point(333, 36)
        Me.TextBoxLeftCOsc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLeftCOsc.Name = "TextBoxLeftCOsc"
        Me.TextBoxLeftCOsc.Size = New System.Drawing.Size(132, 34)
        Me.TextBoxLeftCOsc.TabIndex = 0
        Me.TextBoxLeftCOsc.Text = "COM5"
        Me.TextBoxLeftCOsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonOK
        '
        Me.ButtonOK.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(205, 170)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(107, 44)
        Me.ButtonOK.TabIndex = 6
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextBoxLeftVCh
        '
        Me.TextBoxLeftVCh.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxLeftVCh.Location = New System.Drawing.Point(200, 94)
        Me.TextBoxLeftVCh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLeftVCh.Name = "TextBoxLeftVCh"
        Me.TextBoxLeftVCh.Size = New System.Drawing.Size(65, 31)
        Me.TextBoxLeftVCh.TabIndex = 1
        Me.TextBoxLeftVCh.Text = "1"
        Me.TextBoxLeftVCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Volt.=Ch"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cur.=Ch"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxLeftICh
        '
        Me.TextBoxLeftICh.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxLeftICh.Location = New System.Drawing.Point(400, 94)
        Me.TextBoxLeftICh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLeftICh.Name = "TextBoxLeftICh"
        Me.TextBoxLeftICh.Size = New System.Drawing.Size(65, 31)
        Me.TextBoxLeftICh.TabIndex = 2
        Me.TextBoxLeftICh.Text = "2"
        Me.TextBoxLeftICh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'COMportASK
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 253)
        Me.Controls.Add(Me.TextBoxLeftICh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxLeftVCh)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxLeftCOsc)
        Me.Controls.Add(Me.LabelLeftCCOsc)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "COMportASK"
        Me.Text = "Oscillo COM ports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLeftCCOsc As Label
    Friend WithEvents TextBoxLeftCOsc As TextBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents TextBoxLeftVCh As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLeftICh As TextBox
End Class
