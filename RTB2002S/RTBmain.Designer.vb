<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RTBmain
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ButtonLeftRunStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonGetWaveData = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonLeftCurOFSRst = New System.Windows.Forms.Button()
        Me.LabelLeftC = New System.Windows.Forms.Label()
        Me.LabelLeftCPower = New System.Windows.Forms.Label()
        Me.LabelLeftCurOFS = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonClrWaveData = New System.Windows.Forms.Button()
        Me.ButtonSelFolder = New System.Windows.Forms.Button()
        Me.TextBoxFilePrefix = New System.Windows.Forms.TextBox()
        Me.LabelFName = New System.Windows.Forms.Label()
        Me.LabelFileSeqExt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFileComment = New System.Windows.Forms.TextBox()
        Me.ButtonDataSave = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabelL, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 629)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1112, 24)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabelL
        '
        Me.StatusLabelL.AutoSize = False
        Me.StatusLabelL.Name = "StatusLabelL"
        Me.StatusLabelL.Size = New System.Drawing.Size(400, 18)
        Me.StatusLabelL.Text = "Connecting Oscillo."
        Me.StatusLabelL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 16)
        '
        'ButtonLeftRunStop
        '
        Me.ButtonLeftRunStop.Enabled = False
        Me.ButtonLeftRunStop.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonLeftRunStop.Location = New System.Drawing.Point(20, 150)
        Me.ButtonLeftRunStop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLeftRunStop.Name = "ButtonLeftRunStop"
        Me.ButtonLeftRunStop.Size = New System.Drawing.Size(167, 31)
        Me.ButtonLeftRunStop.TabIndex = 1
        Me.ButtonLeftRunStop.Text = "Waiting"
        Me.ButtonLeftRunStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonGetWaveData
        '
        Me.ButtonGetWaveData.Enabled = False
        Me.ButtonGetWaveData.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonGetWaveData.Location = New System.Drawing.Point(687, 19)
        Me.ButtonGetWaveData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGetWaveData.Name = "ButtonGetWaveData"
        Me.ButtonGetWaveData.Size = New System.Drawing.Size(167, 31)
        Me.ButtonGetWaveData.TabIndex = 6
        Me.ButtonGetWaveData.Text = "GetWaveData"
        Me.ButtonGetWaveData.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Location = New System.Drawing.Point(400, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(667, 344)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ButtonLeftCurOFSRst
        '
        Me.ButtonLeftCurOFSRst.Enabled = False
        Me.ButtonLeftCurOFSRst.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonLeftCurOFSRst.Location = New System.Drawing.Point(20, 350)
        Me.ButtonLeftCurOFSRst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLeftCurOFSRst.Name = "ButtonLeftCurOFSRst"
        Me.ButtonLeftCurOFSRst.Size = New System.Drawing.Size(167, 31)
        Me.ButtonLeftCurOFSRst.TabIndex = 9
        Me.ButtonLeftCurOFSRst.Text = "GetCurOFS(L)"
        Me.ButtonLeftCurOFSRst.UseVisualStyleBackColor = True
        '
        'LabelLeftC
        '
        Me.LabelLeftC.AutoSize = True
        Me.LabelLeftC.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftC.Location = New System.Drawing.Point(20, 69)
        Me.LabelLeftC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLeftC.Name = "LabelLeftC"
        Me.LabelLeftC.Size = New System.Drawing.Size(291, 53)
        Me.LabelLeftC.TabIndex = 11
        Me.LabelLeftC.Text = "Left Cathode"
        '
        'LabelLeftCPower
        '
        Me.LabelLeftCPower.Font = New System.Drawing.Font("MS UI Gothic", 54.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelLeftCPower.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftCPower.Location = New System.Drawing.Point(27, 200)
        Me.LabelLeftCPower.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLeftCPower.Name = "LabelLeftCPower"
        Me.LabelLeftCPower.Size = New System.Drawing.Size(360, 100)
        Me.LabelLeftCPower.TabIndex = 13
        Me.LabelLeftCPower.Text = "0.0 W"
        Me.LabelLeftCPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelLeftCurOFS
        '
        Me.LabelLeftCurOFS.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelLeftCurOFS.Location = New System.Drawing.Point(240, 350)
        Me.LabelLeftCurOFS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLeftCurOFS.Name = "LabelLeftCurOFS"
        Me.LabelLeftCurOFS.Size = New System.Drawing.Size(133, 31)
        Me.LabelLeftCurOFS.TabIndex = 15
        Me.LabelLeftCurOFS.Text = "N/A"
        Me.LabelLeftCurOFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonClrWaveData
        '
        Me.ButtonClrWaveData.Enabled = False
        Me.ButtonClrWaveData.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonClrWaveData.Location = New System.Drawing.Point(900, 19)
        Me.ButtonClrWaveData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonClrWaveData.Name = "ButtonClrWaveData"
        Me.ButtonClrWaveData.Size = New System.Drawing.Size(167, 31)
        Me.ButtonClrWaveData.TabIndex = 19
        Me.ButtonClrWaveData.Text = "ClearWaveData"
        Me.ButtonClrWaveData.UseVisualStyleBackColor = True
        '
        'ButtonSelFolder
        '
        Me.ButtonSelFolder.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonSelFolder.Location = New System.Drawing.Point(20, 462)
        Me.ButtonSelFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSelFolder.Name = "ButtonSelFolder"
        Me.ButtonSelFolder.Size = New System.Drawing.Size(167, 31)
        Me.ButtonSelFolder.TabIndex = 20
        Me.ButtonSelFolder.Text = "Select Folder"
        Me.ButtonSelFolder.UseVisualStyleBackColor = True
        '
        'TextBoxFilePrefix
        '
        Me.TextBoxFilePrefix.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxFilePrefix.Location = New System.Drawing.Point(358, 466)
        Me.TextBoxFilePrefix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxFilePrefix.MaxLength = 12
        Me.TextBoxFilePrefix.Name = "TextBoxFilePrefix"
        Me.TextBoxFilePrefix.Size = New System.Drawing.Size(165, 27)
        Me.TextBoxFilePrefix.TabIndex = 21
        Me.TextBoxFilePrefix.Text = "FilePrefix"
        Me.TextBoxFilePrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelFName
        '
        Me.LabelFName.AutoSize = True
        Me.LabelFName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelFName.Location = New System.Drawing.Point(240, 467)
        Me.LabelFName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFName.Name = "LabelFName"
        Me.LabelFName.Size = New System.Drawing.Size(99, 20)
        Me.LabelFName.TabIndex = 22
        Me.LabelFName.Text = "FileName:"
        '
        'LabelFileSeqExt
        '
        Me.LabelFileSeqExt.AutoSize = True
        Me.LabelFileSeqExt.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelFileSeqExt.Location = New System.Drawing.Point(531, 469)
        Me.LabelFileSeqExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFileSeqExt.Name = "LabelFileSeqExt"
        Me.LabelFileSeqExt.Size = New System.Drawing.Size(88, 20)
        Me.LabelFileSeqExt.TabIndex = 23
        Me.LabelFileSeqExt.Text = "000.DAT"
        Me.LabelFileSeqExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 510)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Comment:"
        '
        'TextBoxFileComment
        '
        Me.TextBoxFileComment.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxFileComment.Location = New System.Drawing.Point(115, 507)
        Me.TextBoxFileComment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxFileComment.MaxLength = 80
        Me.TextBoxFileComment.Name = "TextBoxFileComment"
        Me.TextBoxFileComment.Size = New System.Drawing.Size(757, 27)
        Me.TextBoxFileComment.TabIndex = 25
        '
        'ButtonDataSave
        '
        Me.ButtonDataSave.Enabled = False
        Me.ButtonDataSave.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButtonDataSave.Location = New System.Drawing.Point(932, 455)
        Me.ButtonDataSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDataSave.Name = "ButtonDataSave"
        Me.ButtonDataSave.Size = New System.Drawing.Size(135, 75)
        Me.ButtonDataSave.TabIndex = 26
        Me.ButtonDataSave.Text = "Data Save"
        Me.ButtonDataSave.UseVisualStyleBackColor = True
        '
        'RTBmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 653)
        Me.Controls.Add(Me.ButtonDataSave)
        Me.Controls.Add(Me.TextBoxFileComment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelFileSeqExt)
        Me.Controls.Add(Me.LabelFName)
        Me.Controls.Add(Me.TextBoxFilePrefix)
        Me.Controls.Add(Me.ButtonSelFolder)
        Me.Controls.Add(Me.ButtonClrWaveData)
        Me.Controls.Add(Me.LabelLeftCurOFS)
        Me.Controls.Add(Me.LabelLeftCPower)
        Me.Controls.Add(Me.LabelLeftC)
        Me.Controls.Add(Me.ButtonLeftCurOFSRst)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonGetWaveData)
        Me.Controls.Add(Me.ButtonLeftRunStop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RTBmain"
        Me.Text = "RTB2002S"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabelL As ToolStripStatusLabel
    Friend WithEvents ButtonLeftRunStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonGetWaveData As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonLeftCurOFSRst As Button
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents LabelLeftC As Label
    Friend WithEvents LabelLeftCPower As Label
    Friend WithEvents LabelLeftCurOFS As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonClrWaveData As Button
    Friend WithEvents ButtonSelFolder As Button
    Friend WithEvents TextBoxFilePrefix As TextBox
    Friend WithEvents LabelFName As Label
    Friend WithEvents LabelFileSeqExt As Label
    Protected Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxFileComment As TextBox
    Friend WithEvents ButtonDataSave As Button
End Class
