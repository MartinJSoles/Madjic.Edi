Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Health Care Claim Status</summary>
    '''<remarks>Used to convey status of the entire claim or a specific service line</remarks>
    Partial Friend Class C043_Obj
        Inherits CompositeElement
        Implements C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.
            C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.
            C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.
            C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.
            C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.
            C043,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.
            C043
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1271),
                                         CType(Nothing, Element1271),
                                         CType(Nothing, Element98),
                                         CType(Nothing, Element1270)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C043_01 As String _
            Implements C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_01.C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_10.C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_11.C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_01.C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_10.C043.C043_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_11.C043.C043_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1271
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property C043_02 As String _
            Implements C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_01.C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_10.C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_11.C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_01.C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_10.C043.C043_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_11.C043.C043_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1271
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property C043_03 As String _
            Implements C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_01.C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_10.C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.
                STC_11.C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_01.C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_10.C043.C043_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.
                STC_11.C043.C043_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element98).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element98
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element98).Value = value
                End If
            End Set
        End Property

        Friend Property C043_04 As String Implements C043.C043_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1270
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1270).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C043_01 = values(0)
            End If
            If values.Length > 1 Then
                C043_02 = values(1)
            End If
            If values.Length > 2 Then
                C043_03 = values(2)
            End If
            If values.Length > 3 Then
                C043_04 = values(3)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C043_Obj
            Dim rval As New C043_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Health Care Claim Status</summary>
    '''<remarks>Used to convey status of the entire claim or a specific service line</remarks>
    Public Interface C043
        '''<summary>Industry Code</summary>
        '''<remarks> 
        '''<para>Code indicating a code from a specific industry code list</para>
        '''</remarks>
        Property C043_01 As String

        '''<summary>Industry Code</summary>
        '''<remarks> 
        '''<para>Code indicating a code from a specific industry code list</para>
        '''</remarks>
        Property C043_02 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks> 
        '''<para>Code identifying an organizational entity, a physical location, property or an individual</para>
        '''</remarks>
        Property C043_03 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks> 
        '''<para>Code identifying a specific industry code list</para>
        '''</remarks>
        Property C043_04 As String
    End Interface
End Namespace