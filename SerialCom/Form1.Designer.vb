<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend17 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend18 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(1224, 130)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1224, 382)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "START"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1224, 29)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.HideSelection = False
        Me.RichTextBox2.Location = New System.Drawing.Point(13, 12)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(210, 479)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(1224, 197)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "DISCONN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        Me.SerialPort1.ReadBufferSize = 2048
        Me.SerialPort1.ReceivedBytesThreshold = 40
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.ComboBox2.Location = New System.Drawing.Point(1224, 80)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 33)
        Me.ComboBox2.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1224, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 43)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "STOP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chart
        '
        ChartArea9.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea9.AxisY.Maximum = 60.0R
        ChartArea9.AxisY.Minimum = 0R
        ChartArea9.AxisY2.Maximum = 60.0R
        ChartArea9.AxisY2.Minimum = 0R
        ChartArea9.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea9)
        Legend17.Name = "eeg1"
        Legend18.Name = "eeg2"
        Me.chart.Legends.Add(Legend17)
        Me.chart.Legends.Add(Legend18)
        Me.chart.Location = New System.Drawing.Point(227, 9)
        Me.chart.Margin = New System.Windows.Forms.Padding(0)
        Me.chart.Name = "chart"
        Me.chart.Size = New System.Drawing.Size(955, 574)
        Me.chart.TabIndex = 31
        Me.chart.Text = "Chart1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1224, 544)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 42)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"5", "10", "15", "continue"})
        Me.ComboBox3.Location = New System.Drawing.Point(1224, 256)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(140, 33)
        Me.ComboBox3.TabIndex = 33
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(1227, 495)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(127, 31)
        Me.RichTextBox1.TabIndex = 34
        Me.RichTextBox1.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(1239, 305)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 30)
        Me.RadioButton1.TabIndex = 35
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "10bit"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(1239, 341)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 30)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "12bit"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1366, 595)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.chart)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents chart As DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
