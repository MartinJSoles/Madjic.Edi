Public Class FunctionalGroup
    Implements IValidate

    Private ReadOnly mTransactions As New List(Of TransactionSet)

    Friend Property IsIterator As Boolean

    ''' <summary>
    ''' Gets the set of transactions contained in this functional group.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Transactions() As IEnumerable(Of TransactionSet)
        Get
            If Not IsIterator Then
                Return mTransactions
            Else
                Throw New NotImplementedException("Forward Only Enumeration has not been implemented with the Async/Await pattern yet.")
            End If
        End Get
    End Property

    Public Sub AddTransactionSet(item As TransactionSet)
        If Not IsIterator Then
            If mTransactions.Count = 0 Then
                mTransactions.Add(item)
                mID = item.ParentFunctionGroupCode
            ElseIf String.Compare(FunctionalIdCode, item.ParentFunctionGroupCode, StringComparison.Ordinal) = 0 Then
                mTransactions.Add(item)
            Else
                Throw New NotSupportedException($"The transaction set requires the FuntionalGroup.FunctionalIdCode to match. Expected is '{FunctionalIdCode}', received '{item.ParentFunctionGroupCode}'.")
            End If
        Else
                Throw New NotSupportedException("You cannot add a TransactionSet object when useForwardOnlyEnumeration is set to true from the Document.")
        End If
    End Sub

    Friend Property Reader As EdiReader.EdiGroupReader

    Private mID As String
    Private mSender As String
    Private mReceiver As String
    Private mTimestamp As Date
    Private mInstance As Integer
    Private mVersion As String

    Public Property VersionCode() As String
        Get
            Return mVersion
        End Get
        Set(ByVal value As String)
            mVersion = value
        End Set
    End Property

    Public Property ControlNumber() As Integer
        Get
            Return mInstance
        End Get
        Set(ByVal value As Integer)
            mInstance = value
        End Set
    End Property

    Public Property DateTime() As Date
        Get
            Return mTimestamp
        End Get
        Set(ByVal value As Date)
            mTimestamp = value
        End Set
    End Property

    Public ReadOnly Property Time() As TimeSpan
        Get
            Return mTimestamp.TimeOfDay
        End Get
    End Property

    Public ReadOnly Property [Date]() As Date
        Get
            Return mTimestamp.Date
        End Get
    End Property

    Public Property ApplicationReceiverCode() As String
        Get
            Return mReceiver
        End Get
        Set(ByVal value As String)
            mReceiver = value
        End Set
    End Property

    Public Property ApplicationSenderCode() As String
        Get
            Return mSender
        End Get
        Set(ByVal value As String)
            mSender = value
        End Set
    End Property

    Public Property FunctionalIdCode() As String
        Get
            Return mID
        End Get
        Set(ByVal value As String)
            If mTransactions.Count = 0 Then
                mID = value
            Else
                Throw New NotSupportedException("Cannot change the FunctionalIdCode once a transaction set has been added.")
            End If
        End Set
    End Property

    Friend Async Function WriteAsync(ByVal writer As IO.TextWriter, clearAfterWriting As Boolean, envelope As Envelope) As Task
        Dim mTail As String 'segment terminator
        Dim mSep As String 'segment separator
        Dim mComp As String 'composite separator

        mSep = envelope.ElementSeparator
        mTail = envelope.SegmentTerminator
        mComp = envelope.ComponentElementSeparator

        With writer
            'Write Header
            Await .WriteAsync("GS").ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(mID, 2, 2)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(mSender, 2, 15)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(mReceiver, 2, 15)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(mTimestamp.ToString("yyyyMMdd")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(mTimestamp.ToString("HHmm")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(mInstance.ToString("0")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync("X").ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(mVersion, 1, 12)).ConfigureAwait(False)
            Await .WriteAsync(mTail).ConfigureAwait(False)

            'Write Contents
            For Each item As TransactionSet In mTransactions
                Await item.WriteAsync(writer, clearAfterWriting, envelope).ConfigureAwait(False)
            Next

            'Write Tail
            Await .WriteAsync("GE").ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(mTransactions.Count.ToString("0")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(ControlNumber.ToString("0")).ConfigureAwait(False)
            Await .WriteAsync(mTail).ConfigureAwait(False)
        End With

        If clearAfterWriting Then
            mTransactions.Clear()
        End If
    End Function

    Public Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim e As New ValidationFailureResult With {.Source = Me}
        Dim w As New ValidationWarning With {.Source = Me}

        If mID Is Nothing OrElse mID.Length <> 2 Then
            e.Errors.Add("The FunctionalIdCode property must be a 2 character length value.")
        End If

        If mSender Is Nothing OrElse mSender.Length < 2 OrElse mSender.Length > 15 Then
            e.Errors.Add("The SenderID property must be 2 - 15 characters in length.")
        End If

        If mReceiver Is Nothing OrElse mReceiver.Length < 2 OrElse mReceiver.Length > 15 Then
            e.Errors.Add("The ReceiverID property must be 2 - 15 characters in length.")
        End If

        If mVersion Is Nothing OrElse mVersion.Length < 1 OrElse mVersion.Length > 12 Then
            e.Errors.Add("The VersionCode property must be 1 - 12 characters in length.")
        End If

        If mTransactions.Count = 0 Then
            w.Warnings.Add("This functional group contains no transactions and should be removed from the containing Envelope object.")
        End If

        If mTimestamp > Date.Today.AddDays(15) Then
            w.Warnings.Add("The Date property should not be set in the future.")
        End If

        If mTimestamp < Date.Today.AddYears(-2) Then
            w.Warnings.Add("The Date property should not be set more than 2 years in the past.")
        End If

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If

        If w.Warnings.Count > 0 Then
            results.Warnings.Add(w)
        End If
    End Sub

    Public Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each item In mTransactions
            item.Validate(results)
            item.ValidateChildren(results)

            Dim w As New ValidationWarning With {.Source = item}
            Dim e As New ValidationFailureResult With {.Source = item}

            If String.Compare(mVersion, item.VersionCode, StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("The transaction set does not have the same VersionCode as the Functional Group.")
            End If

            If String.Compare(mID, item.ParentFunctionGroupCode, StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("The transaction set does not have the same value for ParentFunctionalGroupCode as the Functional Group's FunctionalIdCode.")
            End If

            If w.Warnings.Count > 0 Then
                results.Warnings.Add(w)
            End If

            If e.Errors.Count > 0 Then
                results.Failures.Add(e)
            End If
        Next
    End Sub
End Class
