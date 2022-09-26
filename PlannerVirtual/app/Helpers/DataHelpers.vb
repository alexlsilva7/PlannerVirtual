Public Class DataHelpers
    Public Shared Function stringToData(ByVal data As String) As Date
        Return Convert.ToDateTime(data)
    End Function

    Public Shared Function dataToString(ByVal data As String) As String
        Return data.ToString
    End Function

End Class
