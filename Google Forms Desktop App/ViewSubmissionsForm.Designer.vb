<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        titleViewSubmissions = New Label()
        nameLabel = New Label()
        email = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        phone = New Label()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        githublink = New Label()
        stopwatch = New Label()
        txtStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' titleViewSubmissions
        ' 
        titleViewSubmissions.AutoSize = True
        titleViewSubmissions.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        titleViewSubmissions.Location = New Point(117, 22)
        titleViewSubmissions.Name = "titleViewSubmissions"
        titleViewSubmissions.Size = New Size(545, 26)
        titleViewSubmissions.TabIndex = 0
        titleViewSubmissions.Text = "Rachana Mangalaram, Slidely Task 2 - View Submissions"
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(72, 92)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(56, 22)
        nameLabel.TabIndex = 1
        nameLabel.Text = "Name"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(71, 164)
        email.Name = "email"
        email.Size = New Size(57, 22)
        email.TabIndex = 2
        email.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(306, 87)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(345, 30)
        txtName.TabIndex = 3
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = Color.Black
        txtEmail.Location = New Point(306, 159)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(345, 30)
        txtEmail.TabIndex = 4
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' phone
        ' 
        phone.AutoSize = True
        phone.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        phone.Location = New Point(71, 239)
        phone.Name = "phone"
        phone.Size = New Size(100, 22)
        phone.TabIndex = 5
        phone.Text = "Phone Num"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.ForeColor = Color.Black
        txtPhone.Location = New Point(306, 237)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(345, 30)
        txtPhone.TabIndex = 6
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGithubLink.ForeColor = Color.Black
        txtGithubLink.Location = New Point(306, 313)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(345, 30)
        txtGithubLink.TabIndex = 7
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' githublink
        ' 
        githublink.AutoSize = True
        githublink.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        githublink.Location = New Point(71, 316)
        githublink.Name = "githublink"
        githublink.Size = New Size(193, 22)
        githublink.TabIndex = 8
        githublink.Text = "Github Link For Task 2"
        ' 
        ' stopwatch
        ' 
        stopwatch.AutoSize = True
        stopwatch.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stopwatch.Location = New Point(72, 379)
        stopwatch.Name = "stopwatch"
        stopwatch.Size = New Size(132, 22)
        stopwatch.TabIndex = 9
        stopwatch.Text = "Stopwatch time"
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStopwatch.ForeColor = Color.Black
        txtStopwatch.Location = New Point(306, 377)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(345, 30)
        txtStopwatch.TabIndex = 10
        txtStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(71, 487)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(263, 42)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.PaleTurquoise
        btnNext.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(373, 487)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(278, 42)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 624)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(stopwatch)
        Controls.Add(githublink)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(phone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(email)
        Controls.Add(nameLabel)
        Controls.Add(titleViewSubmissions)
        MaximizeBox = False
        Name = "ViewSubmissionsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titleViewSubmissions As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents phone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Friend WithEvents githublink As System.Windows.Forms.Label
    Friend WithEvents stopwatch As System.Windows.Forms.Label
    Friend WithEvents txtStopwatch As System.Windows.Forms.TextBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class