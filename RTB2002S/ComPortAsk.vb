Imports Microsoft.Win32

Public Class COMportASK
    Const MyRegistryKey As String = "software\\RTB2002S"

    Private Sub COMportASK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim key = Registry.CurrentUser
        key = key.OpenSubKey(MyRegistryKey)

        If Not IsNothing(key) Then
            Dim comLstr As String = DirectCast(key.GetValue("COML"), String)

            Dim VChLstr As String = DirectCast(key.GetValue("VCHL"), String)
            Dim IChLstr As String = DirectCast(key.GetValue("ICHL"), String)

            TextBoxLeftCOsc.Text = comLstr
            TextBoxLeftVCh.Text = VChLstr
            TextBoxLeftICh.Text = IChLstr

            key.Close()
        End If

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim key = Registry.CurrentUser
        key = key.CreateSubKey(MyRegistryKey)

        key.setValue("COML", TextBoxLeftCOsc.Text)

        key.SetValue("VCHL", TextBoxLeftVCh.Text)
        key.SetValue("ICHL", TextBoxLeftICh.Text)

        key.Close()

        Me.Close()
    End Sub

End Class