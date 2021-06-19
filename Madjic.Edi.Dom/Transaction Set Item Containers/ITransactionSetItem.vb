Public Interface ITransactionSetItem

    ''' <summary>
    ''' Async Write the transaction set item and any child items it may contain.
    ''' </summary>
    ''' <param name="writer">A <see cref="IO.TextWriter">TextWriter</see> object that the transaction set item and any child items it contains will write to.</param>
    ''' <param name="clearAfterWrite">True, if the child items should be deleted after writing. False, to preserve the child items.</param>
    ''' <param name="envelope">The <see cref="Envelope">Envelope</see> object to use for writing separators and terminators.</param>
    ''' <returns></returns>
    Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task

    Function WriteCount() As Integer

    ReadOnly Property Children As IList(Of ITransactionSetItem)
End Interface
