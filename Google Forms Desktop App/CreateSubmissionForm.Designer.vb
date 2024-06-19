<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        labelname = New Label()
        lblemail = New Label()
        lblphone = New Label()
        lblgithublink = New Label()
        txtName = New TextBox()
        txtemail = New TextBox()
        txtphone = New TextBox()
        txtgithublink = New TextBox()
        btnToogleStopWatch = New Button()
        btnSubmit = New Button()
        txttogglestopwatch = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(126, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(547, 26)
        Label1.TabIndex = 0
        Label1.Text = "Rachana Mangalaram, Slidely Task 2 - Create Submission"
        ' 
        ' labelname
        ' 
        labelname.AutoSize = True
        labelname.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelname.Location = New Point(101, 119)
        labelname.Name = "labelname"
        labelname.Size = New Size(56, 22)
        labelname.TabIndex = 1
        labelname.Text = "Name"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblemail.Location = New Point(101, 195)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(57, 22)
        lblemail.TabIndex = 2
        lblemail.Text = "Email"
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblphone.Location = New Point(101, 277)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(100, 22)
        lblphone.TabIndex = 3
        lblphone.Text = "Phone Num"
        ' 
        ' lblgithublink
        ' 
        lblgithublink.AutoSize = True
        lblgithublink.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblgithublink.Location = New Point(101, 356)
        lblgithublink.Name = "lblgithublink"
        lblgithublink.Size = New Size(193, 22)
        lblgithublink.TabIndex = 4
        lblgithublink.Text = "Github Link For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(379, 114)
        txtName.Name = "txtName"
        txtName.Size = New Size(321, 27)
        txtName.TabIndex = 5
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(379, 193)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(321, 27)
        txtemail.TabIndex = 6
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(379, 272)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(321, 27)
        txtphone.TabIndex = 7
        ' 
        ' txtgithublink
        ' 
        txtgithublink.Location = New Point(379, 351)
        txtgithublink.Name = "txtgithublink"
        txtgithublink.Size = New Size(321, 27)
        txtgithublink.TabIndex = 8
        ' 
        ' btnToogleStopWatch
        ' 
        btnToogleStopWatch.BackColor = Color.Khaki
        btnToogleStopWatch.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToogleStopWatch.Location = New Point(101, 426)
        btnToogleStopWatch.Name = "btnToogleStopWatch"
        btnToogleStopWatch.Size = New Size(255, 37)
        btnToogleStopWatch.TabIndex = 9
        btnToogleStopWatch.Text = "TOGGLE STOPWATCH"
        btnToogleStopWatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.PaleTurquoise
        btnSubmit.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(101, 507)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(599, 37)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txttogglestopwatch
        ' 
        txttogglestopwatch.Location = New Point(379, 426)
        txttogglestopwatch.Name = "txttogglestopwatch"
        txttogglestopwatch.ReadOnly = True
        txttogglestopwatch.Size = New Size(321, 27)
        txttogglestopwatch.TabIndex = 11
        txttogglestopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 590)
        Controls.Add(txttogglestopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnToogleStopWatch)
        Controls.Add(txtgithublink)
        Controls.Add(txtphone)
        Controls.Add(txtemail)
        Controls.Add(txtName)
        Controls.Add(lblgithublink)
        Controls.Add(lblphone)
        Controls.Add(lblemail)
        Controls.Add(labelname)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "CreateSubmissionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelname As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblgithublink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtgithublink As TextBox
    Friend WithEvents btnToogleStopWatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txttogglestopwatch As TextBox
End Class
