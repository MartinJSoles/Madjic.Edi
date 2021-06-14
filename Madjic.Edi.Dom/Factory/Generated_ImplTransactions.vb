Partial Friend NotInheritable Class ReaderFactory

    Private Sub New()

    End Sub

    '''<summary>Creates a transaction set object given the key information in the functional group (GS08/ST03)</summary>
    '''<param name="grp">The functional group that is examined for determining the type of transaction to return.</param>
    '''<param name="rdr">The transaction set reader that is examined for determining the type of transaction to return.</param>
    '''<returns>An object that inherits from TransactionSet or Nothing if the transaction set cannot be recognized.</returns>
    Friend Shared Function CreateTransaction(grp As FunctionalGroup, rdr As EdiReader.EdiTransactionSetReader) As TransactionSet
        If String.Compare(grp.VersionCode, rdr.Element(2), StringComparison.OrdinalIgnoreCase) = 0 Then
            If String.Compare(rdr.Element(2), "005010X279A1", StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(rdr.Element(0), "270", StringComparison.InvariantCultureIgnoreCase) = 0 Then
                Return New Transactions.Transaction270.Standard_Obj("005010X279A1")
            ElseIf String.Compare(rdr.Element(2), "005010X279A1", StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(rdr.Element(0), "271", StringComparison.InvariantCultureIgnoreCase) = 0 Then
                Return New Transactions.Transaction271.Standard_Obj("005010X279A1")
            ElseIf String.Compare(rdr.Element(2), "005010X212", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction277.Standard_Obj("005010X212")
            ElseIf String.Compare(rdr.Element(2), "005010X217", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction278.Standard_Obj("005010X217")
            ElseIf String.Compare(rdr.Element(2), "005010X217", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction278.Standard_Obj("005010X217")
            ElseIf String.Compare(rdr.Element(2), "005010X218", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction820.Standard_Obj("005010X218")
            ElseIf String.Compare(rdr.Element(2), "005010X220A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction834.Standard_Obj("005010X220A1")
            ElseIf String.Compare(rdr.Element(2), "005010X221A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction835.Standard_Obj("005010X221A1")
            ElseIf String.Compare(rdr.Element(2), "005010X222A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction837.Standard_Obj("005010X222A1")
            ElseIf String.Compare(rdr.Element(2), "005010X224A2", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction837.Standard_Obj("005010X224A2")
            ElseIf String.Compare(rdr.Element(2), "005010X223A2", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction837.Standard_Obj("005010X223A2")
            ElseIf String.Compare(rdr.Element(2), "005010X231", StringComparison.OrdinalIgnoreCase) = 0 Then
                Return New Transactions.Transaction999.Standard_Obj("005010X231")
            End If
        End If

        Return Nothing
    End Function

    Friend Shared Function GetImplementationKey(setCode As String, identifier As String) As String
        If String.Compare(setCode, "005010X279A1", StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(identifier, "270", StringComparison.InvariantCultureIgnoreCase) = 0 Then
            Return "_270B1"
        ElseIf String.Compare(setCode, "005010X279A1", StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(identifier, "271", StringComparison.InvariantCultureIgnoreCase) = 0 Then
            Return "_271B1"
        ElseIf String.Compare(setCode, "005010X212", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_277A1"
        ElseIf String.Compare(setCode, "005010X217", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_278A1"
        ElseIf String.Compare(setCode, "005010X217", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_278A3"
        ElseIf String.Compare(setCode, "005010X218", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_820A1"
        ElseIf String.Compare(setCode, "005010X220A1", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_834A1"
        ElseIf String.Compare(setCode, "005010X221A1", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_835W1"
        ElseIf String.Compare(setCode, "005010X222A1", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_837Q1"
        ElseIf String.Compare(setCode, "005010X224A2", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_837Q2"
        ElseIf String.Compare(setCode, "005010X223A2", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_837Q3"
        ElseIf String.Compare(setCode, "005010X231", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return "_999"
        End If
        Return Nothing
    End Function
End Class
