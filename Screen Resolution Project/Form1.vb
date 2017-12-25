
Public Class Form1

    Dim db As SQLiteDatabase

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            db = New SQLiteDatabase()
            Dim recipe As DataTable
            Dim query As [String] = "select * from OM_LOCATION" '"select NAME ""Name"", DESCRIPTION ""Description"","
            'query += "PREP_TIME ""Prep Time"", COOKING_TIME ""Cooking Time"""
            'query += "from RECIPE;"
            recipe = db.GetDataTable(query)
            For Each row As DataRow In recipe.Rows
                MsgBox(row("LOCN_NAME_ARAB"))
            Next row


            'db = New SQLiteDatabase()
            'Dim data As New Dictionary(Of [String], [String])()
            'data.Add("LOCN_CODE", "008")
            'data.Add("LOCN_NAME", "GALLERY MUSEUM")
            'data.Add("LOCN_NAME_ARAB", "كريم")

            'Try
            '    db.Insert("OM_LOCATION", data)
            'Catch crap As Exception
            '    MessageBox.Show(crap.Message)
            'End Try

        Catch fail As Exception
            Dim [error] As [String] = "The following error has occurred:" & vbLf & vbLf
            [error] += fail.Message.ToString() & vbLf & vbLf
            MessageBox.Show([error])
            Me.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dbc As New DBConnection
        Dim stQuery As String
        stQuery = "select USER_GROUP_ID,USER_LOGIN_COUNT from menu_user"
        Dim ds As DataSet

    End Sub

End Class