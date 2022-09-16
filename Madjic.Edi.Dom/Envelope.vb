Public Class Envelope
    Implements IValidate

    Private ReadOnly mGroups As New List(Of FunctionalGroup)

    ''' <summary>
    ''' Gets the set of functional groups contained within this envelope.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FunctionalGroups() As IEnumerable(Of FunctionalGroup)
        Get
            EnsureEdiVersionIsCorrect()

            If Not IsIterator Then
                Return mGroups
            Else
                Throw New NotImplementedException("Forward Only Enumeration has not been implemented with the Async/Await pattern yet.")
            End If
        End Get
    End Property

    Public Sub AddFunctionalGroup(fg As FunctionalGroup)
        EnsureEdiVersionIsCorrect()

        If Not IsIterator Then
            mGroups.Add(fg)
        Else
            Throw New NotSupportedException("You cannot add a FunctionalGroup object when useForwardOnlyEnumeration is set to true from the Document.")
        End If
    End Sub

    Private Sub EnsureEdiVersionIsCorrect()
        If Not IsEdiVersionCorrect() Then
            Throw New EdiException("The EdiVersion must be ""00501"" for this version of the EDI Standards.")
        End If
    End Sub

    Friend Function IsEdiVersionCorrect() As Boolean
        Return String.Compare(EdiVersion, "00501", StringComparison.InvariantCultureIgnoreCase) = 0
    End Function

    Friend Property IsIterator As Boolean


    'Private Quals As String() = {"01", "14", "20", "27", "28", "29", "30", "33", "ZZ"}
    Private mTail As String 'segment terminator
    Private mSep As Char = "*"c 'segment separator
    Private mComp As Char = ">"c 'composite separator

    Public Property ISB As Segments.ISB

    Public Property ISE As Segments.ISE

    Public ReadOnly Property TA1 As New List(Of Segments.TA1)

    Public Property AuthorizationInformationQualifier As String

    Public Property ComponentElementSeparator() As Char
        Get
            Return mComp
        End Get
        Set(ByVal value As Char)
            mComp = value
        End Set
    End Property

    Public Property ElementSeparator() As Char
        Get
            Return mSep
        End Get
        Set(ByVal value As Char)
            mSep = value
        End Set
    End Property

    Public Property SegmentTerminator() As String
        Get
            Return mTail
        End Get
        Set(ByVal value As String)
            mTail = value
        End Set
    End Property

    Public Property IsTest() As Boolean

    Public Property RepetitionSeparator() As Char = "^"c

    Private _EdiVersion As String = "00501"
    Public Property EdiVersion() As String
        Get
            Return _EdiVersion
        End Get
        Friend Set(value As String)
            _EdiVersion = value
        End Set
    End Property

    Public Property AcknowledgementRequested() As Boolean

    Public Property InterchangeControlNumber() As Integer

    Public Property InterchangeDateTime() As Date

    Public ReadOnly Property InterchangeTime() As TimeSpan
        Get
            Return InterchangeDateTime.TimeOfDay
        End Get
    End Property

    Public ReadOnly Property InterchangeDate() As Date
        Get
            Return InterchangeDateTime.Date
        End Get
    End Property

    Public Property InterchangeReceiverID() As String

    Public Property InterchangeReceiverIdQualifier() As String

    Public Property InterchangeSenderID() As String

    Public Property InterchangeSenderIdQualifier() As String

    Public Property SecurityInformationQualifier As String

    Public Property SecurityInfo() As String

    Public Property AuthorizationInfo() As String

    Friend Async Function WriteAsync(ByVal writer As IO.TextWriter, clearAfterWriting As Boolean) As Task
        With writer
            'Write Header
            Await .WriteAsync("ISA").ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)

            If (AuthorizationInfo Is Nothing) OrElse AuthorizationInfo.Length = 0 Then
                Await .WriteAsync("00").ConfigureAwait(False)
                Await .WriteAsync(mSep).ConfigureAwait(False)
                Await .WriteAsync(" ".PadRight(10)).ConfigureAwait(False)
            Else
                Await .WriteAsync(BoundedString(AuthorizationInformationQualifier, 2, 2)).ConfigureAwait(False)
                Await .WriteAsync(mSep).ConfigureAwait(False)
                Await .WriteAsync(BoundedString(AuthorizationInfo, 10, 10)).ConfigureAwait(False)
            End If
            Await .WriteAsync(mSep).ConfigureAwait(False)

            If (SecurityInfo Is Nothing) OrElse SecurityInfo.Length = 0 Then
                Await .WriteAsync("00").ConfigureAwait(False)
                Await .WriteAsync(mSep).ConfigureAwait(False)
                Await .WriteAsync(" ".PadRight(10)).ConfigureAwait(False)
            Else
                Await .WriteAsync(BoundedString(SecurityInformationQualifier, 2, 2)).ConfigureAwait(False)
                Await .WriteAsync(mSep).ConfigureAwait(False)
                Await .WriteAsync(BoundedString(SecurityInfo, 10, 10)).ConfigureAwait(False)
            End If
            Await .WriteAsync(mSep).ConfigureAwait(False)

            Await .WriteAsync(BoundedString(InterchangeSenderIdQualifier, 2, 2)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(InterchangeSenderID, 15, 15)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(InterchangeReceiverIdQualifier, 2, 2)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(InterchangeReceiverID, 15, 15)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(InterchangeDateTime.ToString("yyMMdd")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(InterchangeDateTime.ToString("HHmm")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(RepetitionSeparator).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(BoundedString(EdiVersion, 5, 5)).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(InterchangeControlNumber.ToString("000000000")).ConfigureAwait(False)
            Await .WriteAsync(mSep).ConfigureAwait(False)

            If AcknowledgementRequested Then
                Await .WriteAsync("1").ConfigureAwait(False)
            Else
                Await .WriteAsync("0").ConfigureAwait(False)
            End If
            Await .WriteAsync(mSep).ConfigureAwait(False)

            If IsTest Then
                Await .WriteAsync("T").ConfigureAwait(False)
            Else
                Await .WriteAsync("P").ConfigureAwait(False)
            End If
            Await .WriteAsync(mSep).ConfigureAwait(False)
            Await .WriteAsync(mComp).ConfigureAwait(False)
            Await .WriteAsync(mTail).ConfigureAwait(False)

            If ISB IsNot Nothing Then
                Await CType(ISB, Segments.ISB_Obj).WriteAsync(writer, Me).ConfigureAwait(False)
            End If

            If ISE IsNot Nothing Then
                Await CType(ISE, Segments.ISE_Obj).WriteAsync(writer, Me).ConfigureAwait(False)
            End If

            If TA1.Count > 0 Then
                For Each seg In TA1
                    Await CType(seg, Segments.TA1_Obj).WriteAsync(writer, Me).ConfigureAwait(False)

                Next
            End If

            'Write Contents
            For Each Item As FunctionalGroup In mGroups
                Await Item.WriteAsync(writer, clearAfterWriting, Me)
            Next

            'Write Tail
            Await .WriteAsync("IEA")
            Await .WriteAsync(mSep)
            Await .WriteAsync(mGroups.Count.ToString("0"))
            Await .WriteAsync(mSep)
            Await .WriteAsync(InterchangeControlNumber.ToString("000000000"))
            Await .WriteAsync(mTail)

        End With

        If clearAfterWriting Then
            mGroups.Clear()
        End If
    End Function

    Public Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim w As New ValidationWarning With {.Source = Me}
        Dim e As New ValidationFailureResult With {.Source = Me}

        If AuthorizationInfo Is Nothing OrElse AuthorizationInfo.Length = 0 Then
            If String.Compare(AuthorizationInformationQualifier, "00", StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("There is no authorization information and the qualifier is not '00'.")
            End If
        Else
            If String.Compare(AuthorizationInformationQualifier, "03", StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("There is authorization information and the qualifier is not '03'.")
            End If

            If AuthorizationInfo.Length > 10 Then
                e.Errors.Add("The authorization information cannot be more than 10 characters in length.")
            End If
        End If

        If SecurityInfo Is Nothing OrElse SecurityInfo.Length = 0 Then
            If String.Compare(SecurityInformationQualifier, "00", StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("There is no security information and the qualifier is not '00'.")
            End If
        Else
            If String.Compare(SecurityInformationQualifier, "01", StringComparison.OrdinalIgnoreCase) <> 0 Then
                w.Warnings.Add("There is security information and the qualifier is not '01'.")
            End If

            If SecurityInfo.Length > 10 Then
                e.Errors.Add("The security information cannot be more than 10 characters in length.")
            End If
        End If

        If InterchangeSenderID Is Nothing OrElse InterchangeSenderID.Length = 0 OrElse InterchangeSenderID.Length > 15 Then
            w.Warnings.Add("The sender ID must be 1 - 15 characters in length.")
        End If

        If InterchangeReceiverID Is Nothing OrElse InterchangeReceiverID.Length = 0 OrElse InterchangeReceiverID.Length > 15 Then
            w.Warnings.Add("The receiver ID must be 1 - 15 characters in length.")
        End If

        If InterchangeReceiverIdQualifier Is Nothing OrElse InterchangeReceiverIdQualifier.Length <> 2 Then
            e.Errors.Add("The receiver ID qualifier must be 2 characters in length.")
        ElseIf "00:01:14:20:27:28:29:30:33:ZZ:".IndexOf(InterchangeReceiverIdQualifier & ":", StringComparison.OrdinalIgnoreCase) < 0 Then
            e.Errors.Add("The receiver ID qualifier is not in the list of allowed values.")
        End If

        If InterchangeSenderIdQualifier Is Nothing OrElse InterchangeSenderIdQualifier.Length <> 2 Then
            e.Errors.Add("The sender ID qualifier must be 2 characters in length.")
        ElseIf "00:01:14:20:27:28:29:30:33:ZZ:".IndexOf(InterchangeSenderIdQualifier & ":", StringComparison.OrdinalIgnoreCase) < 0 Then
            e.Errors.Add("The sender ID qualifier is not in the list of allowed values.")
        End If

        If InterchangeDateTime > Date.Today.AddDays(15) Then
            w.Warnings.Add("The Timestamp should not be in the future more than 15 days.")
        End If

        If InterchangeDateTime < Date.Today.AddYears(-2) Then
            w.Warnings.Add("The Timestamp should not be more than 2 years in the past.")
        End If

        If EdiVersion Is Nothing OrElse EdiVersion.Length <> 5 Then
            w.Warnings.Add("The Version property must be 5 characters in length.")
        End If

        If w.Warnings.Count > 0 Then
            results.Warnings.Add(w)
        End If

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Public Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each item In mGroups
            item.Validate(results)
            item.ValidateChildren(results)
        Next
    End Sub

    Friend Property BaseReader As EdiReader.EdiEnvelopeReader

End Class
