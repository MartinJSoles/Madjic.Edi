Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Reference Identifier</summary>
    '''<remarks>To identify one or more reference numbers or identification numbers as specified by the Reference Qualifier</remarks>
    Partial Friend Class C040_Obj
        Inherits CompositeElement
        Implements C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_2.
            REF_2_04.C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_8.
            REF_8_04.C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420A.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420B.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420C.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420D.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420E.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420F.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_1.
            REF_1_04.C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_5.
            REF_5_04.C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420A.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420B.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420C.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420D.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420A.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420B.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420C.REF.REF_04.
            C040,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420D.REF.REF_04.
            C040

        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                          New SyntaxRulePaired({5, 6}),
                                                          New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element128),
                                         CType(Nothing, Element127),
                                         CType(Nothing, Element128),
                                         CType(Nothing, Element127),
                                         CType(Nothing, Element128),
                                         CType(Nothing, Element127)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C040_01 As String _
            Implements C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_2.
                REF_2_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_8.
                REF_8_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420A.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420B.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420C.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420D.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420E.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420F.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_1.
                REF_1_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_5.
                REF_5_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420A.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420B.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420C.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420D.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420A.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420B.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420C.REF.
                REF_04.C040.C040_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420D.REF.
                REF_04.C040.C040_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element128).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element128
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element128).Value = value
                End If
            End Set
        End Property

        Friend Property C040_02 As String _
            Implements C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_2.
                REF_2_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.REF_8.
                REF_8_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420A.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420B.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420C.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420D.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420E.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2420F.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_1.
                REF_1_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_5.
                REF_5_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420A.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420B.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420C.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420D.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420A.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420B.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420C.REF.
                REF_04.C040.C040_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2420D.REF.
                REF_04.C040.C040_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element127).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element127
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element127).Value = value
                End If
            End Set
        End Property

        Friend Property C040_03 As String Implements C040.C040_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element128).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element128
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element128).Value = value
                End If
            End Set
        End Property

        Friend Property C040_04 As String Implements C040.C040_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element127).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element127
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element127).Value = value
                End If
            End Set
        End Property

        Friend Property C040_05 As String Implements C040.C040_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element128).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element128
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element128).Value = value
                End If
            End Set
        End Property

        Friend Property C040_06 As String Implements C040.C040_06
            Get
                Return If(SubElements(5) IsNot Nothing, CType(SubElements(5), Element127).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(5) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(5) = New Element127
                End If

                If SubElements(5) IsNot Nothing Then
                    CType(SubElements(5), Element127).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C040_01 = values(0)
            End If
            If values.Length > 1 Then
                C040_02 = values(1)
            End If
            If values.Length > 2 Then
                C040_03 = values(2)
            End If
            If values.Length > 3 Then
                C040_04 = values(3)
            End If
            If values.Length > 4 Then
                C040_05 = values(4)
            End If
            If values.Length > 5 Then
                C040_06 = values(5)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C040_Obj
            Dim rval As New C040_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Reference Identifier</summary>
    '''<remarks>To identify one or more reference numbers or identification numbers as specified by the Reference Qualifier</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C040
        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks> 
        '''<para>Code qualifying the Reference Identification</para>
        '''</remarks>
        Property C040_01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks> 
        '''<para>Reference information as defined for a particular Transaction Set or as specified by the Reference Identification Qualifier</para>
        '''</remarks>
        Property C040_02 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks> 
        '''<para>Code qualifying the Reference Identification</para>
        '''</remarks>
        Property C040_03 As String

        '''<summary>Reference Identification</summary>
        '''<remarks> 
        '''<para>Reference information as defined for a particular Transaction Set or as specified by the Reference Identification Qualifier</para>
        '''</remarks>
        Property C040_04 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks> 
        '''<para>Code qualifying the Reference Identification</para>
        '''</remarks>
        Property C040_05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks> 
        '''<para>Reference information as defined for a particular Transaction Set or as specified by the Reference Identification Qualifier</para>
        '''</remarks>
        Property C040_06 As String
    End Interface
End Namespace