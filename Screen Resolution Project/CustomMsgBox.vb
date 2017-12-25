Public Class CustomMsgBox
    Inherits System.Windows.Forms.Form
    Friend WithEvents btn As New Windows.Forms.Button
    Friend WithEvents btnReport As New Windows.Forms.Button
    Friend WithEvents rtb As New Windows.Forms.RichTextBox

    Dim TXNTYPE As String
    Dim buttonClicked As Boolean = False
    Public Property TXN_TYPE() As String
        Get
            Return TXNTYPE
        End Get
        Set(ByVal value As String)
            TXNTYPE = value
        End Set
    End Property

    Public Sub New()
        Me.SuspendLayout()
        Me.ControlBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim aPoint As Point
        Me.Width = 300
        Me.Height = 150
        Me.Text = "POS Information!"
        aPoint.X = 5
        aPoint.Y = 5

        Dim lbl As New Label

        With lbl
            .Location = New Point(25, 10)
            .Size = New Size(250, 25)
            .Text = "Transaction Completed Successfully!"
            .Name = "lblTransMessage"
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Times New Roman", 9, FontStyle.Bold)
        End With
        Me.Controls.Add(lbl)

        btn.Width = 90
        btn.Height = 25
        btn.Location = New Point(45, 70)
        btn.Text = "Print"
        Me.Controls.Add(btn)

        btnReport.Width = 90
        btnReport.Height = 25
        btnReport.Location = New Point(145, 70)
        btnReport.Text = "View && Print"
        btnReport.Focus()
        Me.Controls.Add(btnReport)

        btn.Select()
        Me.ResumeLayout(False)
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.Click
        If Not buttonClicked Then
            buttonClicked = True
            Transactions.btnCancelInvoice.Enabled = False
            Me.Hide()
            If TXN_TYPE = "Sales Return" Then

                Transactions.PrintSRReport()
                'MsgBox("Kindly use the option - 'View && Print")
            Else
                'MsgBox("Kindly use the option - 'View && Print")
                Transactions.PrintDINVReport()
            End If
        End If

        Me.Close()
    End Sub

    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Transactions.ViewReport()
        Me.Close()
    End Sub

    Public Overrides Property Text() As String
        Get
            If Me.rtb Is Nothing Then
                Return ""
            Else
                Return Me.rtb.Text
            End If
        End Get
        Set(ByVal value As String)
            Me.rtb.Text = value
        End Set
    End Property

    Private Sub CustomMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CustomMsgBox
        '
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "CustomMsgBox"
        Me.ResumeLayout(False)

    End Sub
End Class