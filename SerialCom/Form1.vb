Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    '------------------------------------------------
    Private elapsedTime As Integer
    Dim myPort As Array
    Dim val1 As Double
    Dim rtxt As String
    Dim trac1 As Double
    Dim countt As Double
    Dim refch0 As Double
    Dim refch1 As Double
    Dim tmp1 As Double
    Dim tmp2 As Double
    ' Dim strWords As String
    '  Dim part As String
    Dim i As Integer
    Dim sidex As Integer

    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)
        RadioButton2.Checked = True


        Button2.Enabled = False
        RichTextBox2.Focus()
        chart.Series.Clear()
        rtxt = ""
        trac1 = 0
        sidex = 1
        chart.Series.Add("eeg1")
        chart.Series(0).ChartType = SeriesChartType.FastLine
        chart.Series.Add("eeg2")
        chart.Series(1).ChartType = SeriesChartType.FastLine
        ' chart.Series.Add("eeg3")
        ' chart.Series(2).ChartType = SeriesChartType.FastLine
        ' chart.Titles.Clear()
        chart.Titles.Add(New Title("eeg Graph..", Docking.Top, New Font(Font, FontStyle.Bold), Color.Black))
        chart.ChartAreas(0).AxisY.IsStartedFromZero = 0
        chart.ChartAreas(0).AxisY.Maximum = Double.NaN
        chart.ChartAreas(0).AxisY.Minimum = Double.NaN
        RichTextBox2.Visible = True 'False
        chart.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        chart.ChartAreas(0).AxisY.MajorGrid.LineWidth = 0
        refch0 = 0
        refch1 = 4100


        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.SelectedIndex = 0
        End If

        If ComboBox2.SelectedIndex = -1 Then
            ComboBox2.SelectedIndex = 3
        End If

        If ComboBox3.SelectedIndex = -1 Then
            ComboBox3.SelectedIndex = 0
        End If


    End Sub
    '------------------------------------------------

    '------------------------------------------------
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text  ' con button
        SerialPort1.BaudRate = ComboBox2.Text
        '  SerialPort1.StopBits = StopBits.None
        ' SerialPort1.ReadBufferSize = AutoSize

        SerialPort1.Parity = Parity.None
        SerialPort1.Encoding = Encoding.ASCII
        SerialPort1.Open()
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True

    End Sub
    '------------------------------------------------
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        SerialPort1.Write("t") 'concatenate with \n  start button
        chart.Series(0).Points.Clear()
        chart.Series(1).Points.Clear()
        'chart.Series(2).Points.Clear()
        Timer1.Start()
        elapsedTime = 0
        countt = 0
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Timer1.Stop()
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting

        If Me.RichTextBox2.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else


            Me.RichTextBox2.Text &= [text] 'append text
            ' Me.RichTextBox2.Text = Me.RichTextBox2.Text.Insert(0, text)

            Me.RichTextBox2.Select(RichTextBox2.Text.Length, 0)
            Me.RichTextBox2.ScrollToCaret()


            rtxt &= [text]

            If rtxt.Contains(vbLf) Then


                ' Dim part As String() = rtxt.Split(New String() {Environment.NewLine},
                ' StringSplitOptions.None)

                i = rtxt.IndexOf(vbLf)
                Dim f As String = rtxt.Substring(i + 1, rtxt.IndexOf(vbLf, i + 1) - i - 1)
                '  sidex = i + 1 + sidex



                Dim strWords As String() = f.Split(" ")


                trac1 = trac1 + 1
                'And (Math.Abs(CInt(strWords(0)) - tmp1) < 1000)
                If IsInteger(strWords(0)) Then
                    chart.Series(0).Points.AddXY(elapsedTime, CInt(strWords(0)) + refch0)
                    tmp1 = CInt(strWords(0))
                Else
                    chart.Series(0).Points.AddXY(elapsedTime, tmp1 + refch0)
                End If
                'And (Math.Abs(CInt(strWords(1)) - tmp2) < 1000)
                If IsInteger(strWords(1)) Then
                    chart.Series(1).Points.AddXY(elapsedTime, CInt(strWords(1)) + refch1)
                    tmp2 = CInt(strWords(1))
                Else
                    chart.Series(1).Points.AddXY(elapsedTime, tmp2 + refch1)
                End If

                elapsedTime = elapsedTime + 1
                'text = ""
                rtxt = ""
            End If
        End If
        'chart.Series(2).Points.AddXY(elapsedTime, CInt(strWords(2)) + 2000)
        'PeltierCellValue = PeltierCellValue + 2



    End Sub

    Public Function IsInteger(value As Object) As Boolean
        Dim output As Integer ' I am not using this by intent it is needed by the TryParse Method
        If (Integer.TryParse(value.ToString(), output)) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        RichTextBox2.ScrollToCaret()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialPort1.Write("s") 'concatenate with \n
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'SerialPort1.Write("s") 'concatenate with \n
        countt = countt + 1
        RichTextBox1.Text = countt.ToString

        If ComboBox3.SelectedIndex < 3 Then

            If countt >= CInt(ComboBox3.Text) Then

                Timer1.Stop()
                SerialPort1.Write("s")
                MsgBox("Log time reach ! " & ControlChars.NewLine & " You can save it ")

            End If

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim sfd As New SaveFileDialog() ' this creates an instance of the SaveFileDialog called "sfd"
        sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        sfd.FilterIndex = 1
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim FileName As String = sfd.FileName ' retrieve the full path to the file selected by the user
            Dim sw As New System.IO.StreamWriter(FileName, False) ' create a StreamWriter with the FileName selected by the User
            sw.WriteLine(RichTextBox2.Text) ' Write the contents of TextBox to the file
            sw.Close() ' close the file
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        refch0 = 0
        refch1 = 1100
        RadioButton2.Checked = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        refch0 = 0
        refch1 = 4100
        RadioButton1.Checked = False
    End Sub

End Class
