<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtSource = New System.Windows.Forms.TextBox()
        Me.TxtDestination = New System.Windows.Forms.TextBox()
        Me.BtnSearchSource = New System.Windows.Forms.Button()
        Me.BtnSeachnDestination = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRunSync = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtSource
        '
        Me.TxtSource.Enabled = False
        Me.TxtSource.Location = New System.Drawing.Point(12, 46)
        Me.TxtSource.Name = "TxtSource"
        Me.TxtSource.Size = New System.Drawing.Size(261, 20)
        Me.TxtSource.TabIndex = 0
        '
        'TxtDestination
        '
        Me.TxtDestination.Enabled = False
        Me.TxtDestination.Location = New System.Drawing.Point(12, 90)
        Me.TxtDestination.Name = "TxtDestination"
        Me.TxtDestination.Size = New System.Drawing.Size(261, 20)
        Me.TxtDestination.TabIndex = 1
        '
        'BtnSearchSource
        '
        Me.BtnSearchSource.Location = New System.Drawing.Point(279, 44)
        Me.BtnSearchSource.Name = "BtnSearchSource"
        Me.BtnSearchSource.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchSource.TabIndex = 2
        Me.BtnSearchSource.Text = "Search"
        Me.BtnSearchSource.UseVisualStyleBackColor = True
        '
        'BtnSeachnDestination
        '
        Me.BtnSeachnDestination.Location = New System.Drawing.Point(279, 88)
        Me.BtnSeachnDestination.Name = "BtnSeachnDestination"
        Me.BtnSeachnDestination.Size = New System.Drawing.Size(75, 23)
        Me.BtnSeachnDestination.TabIndex = 3
        Me.BtnSeachnDestination.Text = "Search"
        Me.BtnSeachnDestination.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source Folder:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Destination Folder:"
        '
        'BtnRunSync
        '
        Me.BtnRunSync.Enabled = False
        Me.BtnRunSync.Location = New System.Drawing.Point(279, 133)
        Me.BtnRunSync.Name = "BtnRunSync"
        Me.BtnRunSync.Size = New System.Drawing.Size(75, 23)
        Me.BtnRunSync.TabIndex = 6
        Me.BtnRunSync.Text = "Run"
        Me.BtnRunSync.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 303)
        Me.Controls.Add(Me.BtnRunSync)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSeachnDestination)
        Me.Controls.Add(Me.BtnSearchSource)
        Me.Controls.Add(Me.TxtDestination)
        Me.Controls.Add(Me.TxtSource)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSource As TextBox
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents BtnSearchSource As Button
    Friend WithEvents BtnSeachnDestination As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnRunSync As Button
End Class
