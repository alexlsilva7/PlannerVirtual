Public Class DataHelpers
    Public Shared Function stringToData(ByVal data As String) As Date
        Return Convert.ToDateTime(data)
    End Function

    Public Shared Function dataToString(ByVal data As String) As String
        Return data.ToString("dd'/'MM'/'yyyy")
    End Function

End Class
