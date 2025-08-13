Public Class RTBmain
    Const RBUFSIZE As Integer = 30000   ' read buffer in byte

    Const WRITETIMEOUT As Integer = 500 ' serial write timeout in ms
    Const READTIMEOUT As Integer = 3000 ' serial read timeout in ms
    Const DATAPOINTS As Integer = 10000 ' max number of waveform data points
    Const DATALENGTH As Integer = 20007 ' max number of returning bytes by CHANm:DATA?

    Const CURAVGWAIT As Integer = 20

    Dim ComP As IO.Ports.SerialPort = Nothing

    Dim DataPath As String = Nothing

    Dim VchStr As String = "1"
    Dim IchStr As String = "2"

    Dim FreqStr As String

    Dim G As Graphics
    Dim P(4) As Pen

    Public Structure WaveDataScale
        Public pos As Double
        Public xorigin As Double
        Public xinc As Double
        Public yorigin As Double
        Public yinc As Double
    End Structure

    Dim LeftVPoint(DATAPOINTS) As UInt16
    Dim LeftIPoint(DATAPOINTS) As UInt16

    Dim wdpnumber As Integer
    Dim wdporder As Integer
    Dim wdlength As Integer

    Dim LeftVScale As WaveDataScale
    Dim LeftIscale As WaveDataScale

    Dim LeftIOFS As Double = Nothing

    Dim dataseq As Integer = 0

    Dim comPask As COMportASK

    Private Sub RTBmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Show()

        ' confirm comport and oscillo channels

        comPask = New COMportASK
        comPask.ShowDialog()

        VchStr = comPask.TextBoxLeftVCh.Text
        IchStr = comPask.TextBoxLeftICh.Text

        ' open COM ports
        Dim ComPtext As String
        Dim readstr As String = ""

        ComPtext = comPask.TextBoxLeftCOsc.Text
        FreqStr = Me.TextBoxFreq.Text

        ComP = New IO.Ports.SerialPort()
        Try
            ComP.PortName = ComPtext
            ComP.BaudRate = 9600
            ComP.Parity = IO.Ports.Parity.None
            ComP.DataBits = 8
            ComP.StopBits = IO.Ports.StopBits.One
            ComP.Handshake = IO.Ports.Handshake.RequestToSend
            ComP.ReadBufferSize = RBUFSIZE

            ComP.Open()

            ComP.WriteTimeout = WRITETIMEOUT
            ComP.ReadTimeout = READTIMEOUT

            ComP.WriteLine("*idn?")
            readstr = ComP.ReadLine()
            StatusLabelL.Text = readstr

            ' waveform data settings
            ComP.WriteLine("form uint,16")
            ComP.WriteLine("form:bord lsbf")

            ComP.WriteLine("acq:hres")
            ComP.WriteLine("acq:poin:10kSa")
            ComP.WriteLine("chan:data:poin dmax")

            ComP.WriteLine("chan:data:poin?")
            readstr = ComP.ReadLine()

            wdpnumber = Integer.Parse(readstr)
            wdporder = readstr.Length()
            wdlength = 2 + wdporder + wdpnumber * 2
            If wdpnumber > DATAPOINTS Then
                MsgBox("Load: wdpnumber exceed DATAPOINTS.")
            End If

            'ComP.WriteLine("calc:math1:expr:def?")
            'readstr = ComP.ReadLine()
            'ComP.WriteLine("calc:math2:expr:def?")
            'readstr = ComP.ReadLine()
            'ComP.WriteLine("calc:math3:expr:def?")
            'readstr = ComP.ReadLine()
            'ComP.WriteLine("calc:math4:expr:def?")
            'readstr = ComP.ReadLine()

            ButtonLeftCurOFSRst.Enabled = True

        Catch ex As UnauthorizedAccessException
            readstr = "Error: Cannot open " & ComPtext & "."
            ComP = Nothing
        Catch ex As TimeoutException
            readstr = "Error: " & ComPtext & " read timed out."
        Catch ex As Exception
            readstr = "Error: " & ComPtext & " is not connected"
            ComP = Nothing
        End Try


        ButtonGetWaveData.Enabled = ButtonLeftCurOFSRst.Enabled

        ' Initialize Graphic screens & pens

        G = PictureBox1.CreateGraphics

        G.ScaleTransform(PictureBox1.Width / wdpnumber, PictureBox1.Height / 65535)

        Dim dashValues() As Single = {80, 40, 80, 40}
        P(0) = New Pen(Color.Red, 1)
        P(0).DashStyle = Drawing2D.DashStyle.Dash
        P(0).DashPattern = dashValues
        P(1) = New Pen(Color.Red, 1)

        P(2) = New Pen(Color.Blue, 1)
        P(2).DashStyle = Drawing2D.DashStyle.Dash
        P(2).DashPattern = dashValues
        P(3) = New Pen(Color.Blue, 1)

    End Sub

    Private Sub GetWaveData(comport As IO.Ports.SerialPort, ch As String, xpoint As Integer, ypoint As UInt16(), ByRef waveScale As WaveDataScale)
        Dim rBuf(RBUFSIZE) As Byte

        Dim nData As Integer

        comport.DiscardInBuffer()
        comport.DiscardOutBuffer()

        Try
            Dim sendcmd As String = "chan" & ch & ":data:head?"

            comport.WriteLine(sendcmd)
            Dim readstr As String = comport.ReadLine()

            ' data:head? return is "XS,XE,DL,SI". we need DataLen
            Dim pos0 As Integer = 0, posE As Integer
            pos0 = readstr.IndexOf(",", pos0)
            pos0 = readstr.IndexOf(",", pos0 + 1)
            posE = readstr.IndexOf(",", pos0 + 1)

            Dim ndText As String = readstr.Substring(pos0 + 1, posE - pos0 - 1)
            nData = Integer.Parse(ndText)

            If nData <> wdpnumber Then
                MsgBox("GetWaveData: xpoint and wdpnumber differs.")
            End If

            sendcmd = "chan" & ch & ":pos?"
            comport.WriteLine(sendcmd)
            readstr = comport.ReadLine()
            waveScale.pos = Convert.ToDouble(readstr)

            sendcmd = "chan" & ch & ":data:xor?"
            comport.WriteLine(sendcmd)
            readstr = comport.ReadLine()
            waveScale.xorigin = Convert.ToDouble(readstr)

            sendcmd = "chan" & ch & ":data:xinc?"
            comport.WriteLine(sendcmd)
            readstr = comport.ReadLine()
            waveScale.xinc = Convert.ToDouble(readstr)

            sendcmd = "chan" & ch & ":data:yor?"
            comport.WriteLine(sendcmd)
            readstr = comport.ReadLine()
            waveScale.yorigin = Convert.ToDouble(readstr)

            sendcmd = "chan" & ch & ":data:yinc?"
            comport.WriteLine(sendcmd)
            readstr = comport.ReadLine()
            waveScale.yinc = Convert.ToDouble(readstr)

            comport.DiscardInBuffer()
            comport.DiscardOutBuffer()

            sendcmd = "CHAN" & ch & ":DATA?"
            comport.WriteLine(sendcmd)

            Dim rbtotal As Integer = 0
            While rbtotal < wdlength
                Dim rbyte As Integer = comport.Read(rBuf, rbtotal, wdlength - rbtotal)
                If rbyte <= 0 Then
                    Throw New TimeoutException("The read does Not exceed")
                End If
                rbtotal += rbyte
            End While
            ' Threading.Thread.Sleep(SERIALWAIT)
            ' StatusLabelL.Text = rbtotal.ToString()


        Catch ex As TimeoutException
            StatusLabelL.Text = "command timed out."
        Catch ex As FormatException
            StatusLabelL.Text = "Read buffer format error."
        Finally
            comport.DiscardInBuffer()
            comport.DiscardOutBuffer()
        End Try

        ' confirm if the 1st byte is '#'
        Dim rChar As Char = Convert.ToChar(rBuf(0))
        If rChar <> "#"c Then
            MsgBox("1st Char is not # in WF data.")
        End If

        ' eval num of bytes to follow
        rChar = Convert.ToChar(rBuf(1))
        Dim nDig As Integer = Integer.Parse(rChar)
        Dim nByte As Integer = 0
        For i As Integer = 1 To nDig
            rChar = Convert.ToChar(rBuf(1 + i))
            Dim k As Integer = Integer.Parse(rChar)
            nByte = nByte + k * 10 ^ (nDig - i)
        Next

        For i As Integer = 0 To xpoint - 1
            ypoint(i) = BitConverter.ToUInt16(rBuf, 2 + nDig + 2 * i)
        Next

    End Sub

    Private Sub ButtonLeftCurOFSRst_Click(sender As Object, e As EventArgs) Handles ButtonLeftCurOFSRst.Click
        SetCurrentBase(ComP, LeftIOFS, LabelLeftCurOFS, ButtonLeftRunStop)
    End Sub

    Private Sub SetCurrentBase(comport As IO.Ports.SerialPort, ByRef curOFS As Double,
                               ByRef labelCurOFS As Windows.Forms.Label, ByRef buttonRunstop As Windows.Forms.Button)
        Dim readstr As String = ""
        Try
            comport.WriteLine("meas2:sour ch" & IchStr)
            comport.WriteLine("meas2:main mean")
            comport.WriteLine("meas2:enab on")

            labelCurOFS.Text = "Getting..."

            curOFS = 0
            For i As Integer = 1 To 10
                comport.WriteLine("meas2:res:act?")
                readstr = comport.ReadLine()
                curOFS += Convert.ToDouble(readstr)
                Threading.Thread.Sleep(CURAVGWAIT)
            Next i
            curOFS /= 10
            comport.WriteLine("meas2:enab off")

            Dim iAvg As String = curOFS.ToString

            ' math settings
            comport.WriteLine("calc:math1:expr:def ""SUB(CH" & IchStr & "," & iAvg & ") in A""")
            comport.WriteLine("calc:math2:expr:def ""MUL(CH" & VchStr & ",MA1) in W""")
            comport.WriteLine("calc:math3:expr:def ""INT(MA2) in J""")
            comport.WriteLine("calc:math4:expr:def ""MUL(MA3," & Me.FreqStr & ") in W""")
            comport.WriteLine("calc:math1:lab SubCur")
            comport.WriteLine("calc:math2:lab InstPow")
            comport.WriteLine("calc:math3:lab Epulse")
            comport.WriteLine("calc:math4:lab AvgPow")
            comport.WriteLine("calc:math4:stat ON")
            comport.WriteLine("calc:math4:lab ON")

            'comport.WriteLine("calc:math2:lab?")
            'readstr = comport.ReadLine()

            comport.WriteLine("meas1:sour MA4")
            comport.WriteLine("meas1:main peak")
            comport.WriteLine("meas1:enab on")

            labelCurOFS.Text = curOFS.ToString("0.00E0") & " A"

            If IsNothing(comport) = False Then
                buttonRunstop.Enabled = True
            End If

        Catch ex As TimeoutException
            comport.DiscardInBuffer()
            comport.DiscardOutBuffer()
        End Try
    End Sub

    Private Sub ButtonLeftRunStop_Click(sender As Object, e As EventArgs) Handles ButtonLeftRunStop.Click
        If ButtonLeftRunStop.Text = "Waiting" Then
            ButtonLeftRunStop.Text = "Running"
            LabelLeftCPower.ForeColor = Color.Red
            Timer1.Enabled = True
        Else
            ButtonLeftRunStop.Text = "Waiting"
            LabelLeftCPower.ForeColor = Color.Blue
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub TextBoxFreq_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFreq.TextChanged
        Dim freq As Integer
        If Not Integer.TryParse(Me.TextBoxFreq.Text, freq) Then
            Me.TextBoxFreq.Text = FreqStr
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim readstr As String = ""
        If FreqStr <> Me.TextBoxFreq.Text Then
            FreqStr = Me.TextBoxFreq.Text
            ComP.WriteLine("calc:math4:expr:def ""MUL(MA3," & FreqStr & ") in W""")
        End If

        If ButtonLeftRunStop.Text = "Running" Then
            ComP.WriteLine("meas1:res?")
            readstr = ComP.ReadLine()

            Dim avgLPower As Double = Convert.ToDouble(readstr) * (-1)
            LabelLeftCPower.Text = avgLPower.ToString("0.0") & " W"
        End If
    End Sub

    Private Sub ButtonGetWaveData_Click(sender As Object, e As EventArgs) Handles ButtonGetWaveData.Click
        Dim xPoints As Integer = wdpnumber

        ButtonGetWaveData.Text = "Obtaining..."

        If ButtonLeftCurOFSRst.Enabled = True Then
            Array.Clear(LeftVPoint, 0, xPoints)
            Array.Clear(LeftIPoint, 0, xPoints)

            Call GetWaveData(ComP, comPask.TextBoxLeftVCh.Text, xPoints, LeftVPoint, LeftVScale)
            Call GetWaveData(ComP, comPask.TextBoxLeftICh.Text, xPoints, LeftIPoint, LeftIscale)

            Call DrawWaveForm(G, LeftVPoint, LeftVScale, LeftIPoint, LeftIscale)
        End If

        ButtonGetWaveData.Text = "GetWaveData"
        ButtonClrWaveData.Enabled = True

        If DataPath <> Nothing Then
            ButtonDataSave.Enabled = True
        End If

    End Sub

    Private Sub DrawWaveForm(gScr As Graphics, vWV() As UInt16, vPara As WaveDataScale, iWV() As UInt16, iPara As WaveDataScale)
        Dim xPoints As Integer = wdpnumber

        Dim vScrP(xPoints - 1) As Drawing.Point
        Dim iScrP(xPoints - 1) As Drawing.Point

        For i As Integer = 0 To xPoints - 1
            vScrP(i) = New Point(i, 65535 - vWV(i))
            iScrP(i) = New Point(i, 65535 - iWV(i))
        Next

        gScr.Clear(Color.White)

        Dim vLev As Integer = CUInt(32767 - vPara.pos * 6554)
        gScr.DrawLine(P(0), 0, vLev, wdpnumber, vLev)

        gScr.DrawLines(P(1), vScrP)

        Dim iLev As Integer = CUInt(32767 - iPara.pos * 6554)
        gScr.DrawLine(P(2), 0, iLev, wdpnumber, iLev)

        gScr.DrawLines(P(3), iScrP)

    End Sub

    Private Sub ButtonClrWaveData_Click(sender As Object, e As EventArgs) Handles ButtonClrWaveData.Click
        Call ClearWaveData()
        ButtonClrWaveData.Enabled = False
        ButtonDataSave.Enabled = False
    End Sub

    Private Sub ButtonSelFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelFolder.Click
        FolderBrowserDialog1.ShowDialog()

        DataPath = FolderBrowserDialog1.SelectedPath

        If DataPath <> Nothing Then
            ChDir(DataPath)
        End If
    End Sub

    Private Sub ButtonDataSave_Click(sender As Object, e As EventArgs) Handles ButtonDataSave.Click
        Dim fNo As Integer
        Dim filename As String = TextBoxFilePrefix.Text & LabelFileSeqExt.Text
        Dim textline As String

        If LeftVScale.xorigin <> LeftIscale.xorigin Or LeftVScale.xinc <> LeftIscale.xinc Then
            MsgBox("Time scale differs between channels in left Oscillo.")
        End If

        Try
            Dim leftCurOfs As Double = 0
            Dim rightCurOfs As Double = 0

            fNo = FreeFile()
            FileOpen(fNo, filename, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)

            textline = "# RTB200X Control Data obtained at " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            PrintLine(fNo, textline)

            PrintLine(fNo, "# " & TextBoxFileComment.Text)
            PrintLine(fNo, "# ")

            textline = "# " & "Curent Offset:  "
            If LeftIOFS = Nothing Then
                textline &= "NOT AVAILABLE"
            Else
                textline &= LeftIOFS.ToString("E") & " A, Subtracted"
                leftCurOfs = LeftIOFS
            End If
            PrintLine(fNo, textline)

            PrintLine(fNo, "# ")


            PrintLine(fNo, "# Time(s), Voltage(V), Current(A)")

            For i As Integer = 0 To wdpnumber - 1
                Dim val As Double

                val = LeftVScale.xorigin + i * LeftVScale.xinc
                textline = val.ToString("E")

                val = LeftVScale.yorigin + LeftVPoint(i) * LeftVScale.yinc
                textline &= vbTab & val.ToString("E")

                val = LeftIscale.yorigin + LeftIPoint(i) * LeftIscale.yinc - leftCurOfs
                textline &= vbTab & val.ToString("E")

                PrintLine(fNo, textline)
            Next

            FileClose(fNo)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Cannot Open " & filename & "for Writing!")
        End Try

        dataseq += 1
        LabelFileSeqExt.Text = dataseq.ToString("000") & ".DAT"

        Call ClearWaveData()
        ButtonDataSave.Enabled = False
        ButtonClrWaveData.Enabled = False
    End Sub

    Private Sub ClearWaveData()
        Dim xPoints As Integer = wdpnumber

        Array.Clear(LeftVPoint, 0, xPoints)
        Array.Clear(LeftIPoint, 0, xPoints)
        G.Clear(Color.White)

    End Sub
End Class