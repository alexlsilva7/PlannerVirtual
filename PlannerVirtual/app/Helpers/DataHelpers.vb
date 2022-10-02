Public Class DataHelpers
    Public Shared Function stringToData(ByVal dataString As String) As Date
        Dim dataSplit = dataString.Split("/")
        Dim dia = dataSplit(0)
        Dim mes = dataSplit(1)
        Dim ano = dataSplit(2)
        Return New Date(ano, mes, dia)
    End Function

    Public Shared Function dataToString(ByVal data As Date) As String
        Return data.ToString("dd'/'MM'/'yyyy")
    End Function

End Class
