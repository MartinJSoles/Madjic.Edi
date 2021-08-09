Imports System.Diagnostics.CodeAnalysis
Imports Madjic.Edi.Dom.EdiReader

Namespace DataElements.Composite
    '''<summary>Composite Unit of Measure</summary>
    '''<remarks>To identify a composite unit of measure<br /><br />(See Figures Appendix for examples of use)</remarks>
    Partial Friend Class C001_Obj
        Inherits CompositeElement
        Implements C001,
                   Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2410.CTP.CTP_05.C001,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2410.CTP.CTP_05.C001
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element355),
                                         CType(Nothing, Element1018),
                                         CType(Nothing, Element649),
                                         CType(Nothing, Element355),
                                         CType(Nothing, Element1018),
                                         CType(Nothing, Element649),
                                         CType(Nothing, Element355),
                                         CType(Nothing, Element1018),
                                         CType(Nothing, Element649),
                                         CType(Nothing, Element355),
                                         CType(Nothing, Element1018),
                                         CType(Nothing, Element649),
                                         CType(Nothing, Element355),
                                         CType(Nothing, Element1018),
                                         CType(Nothing, Element649)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C001_01 As String _
            Implements C001.C001_01,
                       Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001.C001_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2410.CTP.CTP_05.C001.C001_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2410.CTP.CTP_05.C001.C001_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element355).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element355
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element355).Value = value
                End If
            End Set
        End Property

        Friend Property C001_02 As Decimal? Implements C001.C001_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1018).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1018
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1018).Value = value
                End If
            End Set
        End Property

        Friend Property C001_03 As Decimal? Implements C001.C001_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element649
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element649).Value = value
                End If
            End Set
        End Property

        Friend Property C001_04 As String Implements C001.C001_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element355).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element355
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element355).Value = value
                End If
            End Set
        End Property

        Friend Property C001_05 As Decimal? Implements C001.C001_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element1018).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element1018
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element1018).Value = value
                End If
            End Set
        End Property

        Friend Property C001_06 As Decimal? Implements C001.C001_06
            Get
                Return If(SubElements(5) IsNot Nothing, CType(SubElements(5), Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(5) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(5) = New Element649
                End If

                If SubElements(5) IsNot Nothing Then
                    CType(SubElements(5), Element649).Value = value
                End If
            End Set
        End Property

        Friend Property C001_07 As String Implements C001.C001_07
            Get
                Return If(SubElements(6) IsNot Nothing, CType(SubElements(6), Element355).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(6) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(6) = New Element355
                End If

                If SubElements(6) IsNot Nothing Then
                    CType(SubElements(6), Element355).Value = value
                End If
            End Set
        End Property

        Friend Property C001_08 As Decimal? Implements C001.C001_08
            Get
                Return If(SubElements(7) IsNot Nothing, CType(SubElements(7), Element1018).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(7) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(7) = New Element1018
                End If

                If SubElements(7) IsNot Nothing Then
                    CType(SubElements(7), Element1018).Value = value
                End If
            End Set
        End Property

        Friend Property C001_09 As Decimal? Implements C001.C001_09
            Get
                Return If(SubElements(8) IsNot Nothing, CType(SubElements(8), Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(8) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(8) = New Element649
                End If

                If SubElements(8) IsNot Nothing Then
                    CType(SubElements(8), Element649).Value = value
                End If
            End Set
        End Property

        Friend Property C001_10 As String Implements C001.C001_10
            Get
                Return If(SubElements(9) IsNot Nothing, CType(SubElements(9), Element355).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(9) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(9) = New Element355
                End If

                If SubElements(9) IsNot Nothing Then
                    CType(SubElements(9), Element355).Value = value
                End If
            End Set
        End Property

        Friend Property C001_11 As Decimal? Implements C001.C001_11
            Get
                Return If(SubElements(10) IsNot Nothing, CType(SubElements(10), Element1018).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(10) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(10) = New Element1018
                End If

                If SubElements(10) IsNot Nothing Then
                    CType(SubElements(10), Element1018).Value = value
                End If
            End Set
        End Property

        Friend Property C001_12 As Decimal? Implements C001.C001_12
            Get
                Return If(SubElements(11) IsNot Nothing, CType(SubElements(11), Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(11) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(11) = New Element649
                End If

                If SubElements(11) IsNot Nothing Then
                    CType(SubElements(11), Element649).Value = value
                End If
            End Set
        End Property

        Friend Property C001_13 As String Implements C001.C001_13
            Get
                Return If(SubElements(12) IsNot Nothing, CType(SubElements(12), Element355).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(12) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(12) = New Element355
                End If

                If SubElements(12) IsNot Nothing Then
                    CType(SubElements(12), Element355).Value = value
                End If
            End Set
        End Property

        Friend Property C001_14 As Decimal? Implements C001.C001_14
            Get
                Return If(SubElements(13) IsNot Nothing, CType(SubElements(13), Element1018).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(13) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(13) = New Element1018
                End If

                If SubElements(13) IsNot Nothing Then
                    CType(SubElements(13), Element1018).Value = value
                End If
            End Set
        End Property

        Friend Property C001_15 As Decimal? Implements C001.C001_15
            Get
                Return If(SubElements(14) IsNot Nothing, CType(SubElements(14), Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(14) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(14) = New Element649
                End If

                If SubElements(14) IsNot Nothing Then
                    CType(SubElements(14), Element649).Value = value
                End If
            End Set
        End Property

#End Region


        Friend Shared Function FromReader(fullElement As String, reader As SegmentReader) As C001_Obj
            Dim rval As New C001_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C001_01 = values(0)
            End If
            If values.Length > 1 Then
                C001_02 = values(1).ToFloat
            End If
            If values.Length > 2 Then
                C001_03 = values(2).ToFloat
            End If
            If values.Length > 3 Then
                C001_04 = values(3)
            End If
            If values.Length > 4 Then
                C001_05 = values(4).ToFloat
            End If
            If values.Length > 5 Then
                C001_06 = values(5).ToFloat
            End If
            If values.Length > 6 Then
                C001_07 = values(6)
            End If
            If values.Length > 7 Then
                C001_08 = values(7).ToFloat
            End If
            If values.Length > 8 Then
                C001_09 = values(8).ToFloat
            End If
            If values.Length > 9 Then
                C001_10 = values(9)
            End If
            If values.Length > 10 Then
                C001_11 = values(10).ToFloat
            End If
            If values.Length > 11 Then
                C001_12 = values(11).ToFloat
            End If
            If values.Length > 12 Then
                C001_13 = values(12)
            End If
            If values.Length > 13 Then
                C001_14 = values(13).ToFloat
            End If
            If values.Length > 14 Then
                C001_15 = values(14).ToFloat
            End If
        End Sub
    End Class

    '''<summary>Composite Unit of Measure</summary>
    '''<remarks>To identify a composite unit of measure<br /><br />(See Figures Appendix for examples of use)</remarks>
    Public Interface C001
        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks> 
        '''<para>Code specifying the units in which a value is being expressed, or manner in which a measurement has been taken</para>
        '''</remarks>
        Property C001_01 As String

        '''<summary>Exponent</summary>
        '''<remarks> 
        '''<para>Power to which a unit is raised</para>
        '''</remarks>
        Property C001_02 As Decimal?

        '''<summary>Multiplier</summary>
        '''<remarks> 
        '''<para>Value to be used as a multiplier to obtain a new value</para>
        '''</remarks>
        Property C001_03 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks> 
        '''<para>Code specifying the units in which a value is being expressed, or manner in which a measurement has been taken</para>
        '''</remarks>
        Property C001_04 As String

        '''<summary>Exponent</summary>
        '''<remarks> 
        '''<para>Power to which a unit is raised</para>
        '''</remarks>
        Property C001_05 As Decimal?

        '''<summary>Multiplier</summary>
        '''<remarks> 
        '''<para>Value to be used as a multiplier to obtain a new value</para>
        '''</remarks>
        Property C001_06 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks> 
        '''<para>Code specifying the units in which a value is being expressed, or manner in which a measurement has been taken</para>
        '''</remarks>
        Property C001_07 As String

        '''<summary>Exponent</summary>
        '''<remarks> 
        '''<para>Power to which a unit is raised</para>
        '''</remarks>
        Property C001_08 As Decimal?

        '''<summary>Multiplier</summary>
        '''<remarks> 
        '''<para>Value to be used as a multiplier to obtain a new value</para>
        '''</remarks>
        Property C001_09 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks> 
        '''<para>Code specifying the units in which a value is being expressed, or manner in which a measurement has been taken</para>
        '''</remarks>
        Property C001_10 As String

        '''<summary>Exponent</summary>
        '''<remarks> 
        '''<para>Power to which a unit is raised</para>
        '''</remarks>
        Property C001_11 As Decimal?

        '''<summary>Multiplier</summary>
        '''<remarks> 
        '''<para>Value to be used as a multiplier to obtain a new value</para>
        '''</remarks>
        Property C001_12 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks> 
        '''<para>Code specifying the units in which a value is being expressed, or manner in which a measurement has been taken</para>
        '''</remarks>
        Property C001_13 As String

        '''<summary>Exponent</summary>
        '''<remarks> 
        '''<para>Power to which a unit is raised</para>
        '''</remarks>
        Property C001_14 As Decimal?

        '''<summary>Multiplier</summary>
        '''<remarks> 
        '''<para>Value to be used as a multiplier to obtain a new value</para>
        '''</remarks>
        Property C001_15 As Decimal?
    End Interface
End Namespace
