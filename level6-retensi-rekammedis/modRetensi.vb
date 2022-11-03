Imports System.Data.OleDb

Module modRetensi
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public str As String
    Public Function app_path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
    Public Sub koneksi()
        str = "provider=microsoft.jet.OLEDB.4.0;Data Source=dbRetensi.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
