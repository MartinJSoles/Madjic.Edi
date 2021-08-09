Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Composite Medical Procedure Identifier</summary>
    '''<remarks>To identify a medical procedure by its standardized codes and applicable modifiers</remarks>
    Partial Friend Class C003_Obj
        Inherits CompositeElement
        Implements C003,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02.
            C003, Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02.C003,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13.
            C003, Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13.C003,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.
            C003,
                   Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.
            C003,
                   Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_01.
            C003,
                   Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_06.
            C003,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.SV1_01.
            C003,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.SV5_01.
            C003,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.SVD_03.
            C003,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.
            C003,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.
            C003,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.SV2_02.
            C003,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.SVD_03.
            C003
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element235),
                                         CType(Nothing, Element234),
                                         CType(Nothing, Element1339),
                                         CType(Nothing, Element1339),
                                         CType(Nothing, Element1339),
                                         CType(Nothing, Element1339),
                                         CType(Nothing, Element352),
                                         CType(Nothing, Element234)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C003_01 As String _
            Implements C003.C003_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_01,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_01,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_01,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.
                SV5_01.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element235).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element235
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element235).Value = value
                End If
            End Set
        End Property

        Friend Property C003_02 As String _
            Implements C003.C003_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_02,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_02,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_02,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.
                SV5_01.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element234).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element234
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element234).Value = value
                End If
            End Set
        End Property

        Friend Property C003_03 As String _
            Implements C003.C003_03,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_03,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_03,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_03,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_03,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_03,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_03,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1339).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1339
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1339).Value = value
                End If
            End Set
        End Property

        Friend Property C003_04 As String _
            Implements C003.C003_04,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_04,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_04,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_04,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_04,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_04,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_04,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_04,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1339).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1339
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1339).Value = value
                End If
            End Set
        End Property

        Friend Property C003_05 As String _
            Implements C003.C003_05,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_05,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_05,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_05,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_05,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_05,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_05,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_05,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element1339).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element1339
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element1339).Value = value
                End If
            End Set
        End Property

        Friend Property C003_06 As String _
            Implements C003.C003_06,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02 _
                .C003.C003_06,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02 _
                .C003.C003_06,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_06,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_06,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.
                SVC_01.C003.C003_06,
                       Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.
                SVC_01.C003.C003_06,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_01.C003.C003_06,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_06,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_06
            Get
                Return If(SubElements(5) IsNot Nothing, CType(SubElements(5), Element1339).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(5) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(5) = New Element1339
                End If

                If SubElements(5) IsNot Nothing Then
                    CType(SubElements(5), Element1339).Value = value
                End If
            End Set
        End Property

        Friend Property C003_07 As String _
            Implements C003.C003_07,
                       Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.
                SVC_06.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.
                SV1_01.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.
                SVD_03.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.
                SV3_01.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.
                SVD_03.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.
                SV2_02.C003.C003_07,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.
                SVD_03.C003.C003_07
            Get
                Return If(SubElements(6) IsNot Nothing, CType(SubElements(6), Element352).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(6) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(6) = New Element352
                End If

                If SubElements(6) IsNot Nothing Then
                    CType(SubElements(6), Element352).Value = value
                End If
            End Set
        End Property

        Friend Property C003_08 As String _
            Implements C003.C003_08,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13 _
                .C003.C003_08,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13 _
                .C003.C003_08
            Get
                Return If(SubElements(7) IsNot Nothing, CType(SubElements(7), Element234).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(7) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(7) = New Element234
                End If

                If SubElements(7) IsNot Nothing Then
                    CType(SubElements(7), Element234).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C003_01 = values(0)
            End If
            If values.Length > 1 Then
                C003_02 = values(1)
            End If
            If values.Length > 2 Then
                C003_03 = values(2)
            End If
            If values.Length > 3 Then
                C003_04 = values(3)
            End If
            If values.Length > 4 Then
                C003_05 = values(4)
            End If
            If values.Length > 5 Then
                C003_06 = values(5)
            End If
            If values.Length > 6 Then
                C003_07 = values(6)
            End If
            If values.Length > 7 Then
                C003_08 = values(7)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C003_Obj
            Dim rval As New C003_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Composite Medical Procedure Identifier</summary>
    '''<remarks>To identify a medical procedure by its standardized codes and applicable modifiers</remarks>
    Public Interface C003
        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks> 
        '''<para>Code identifying the type/source of the descriptive number used in Product/Service ID (234)</para>
        '''</remarks>
        Property C003_01 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks> 
        '''<para>Identifying number for a product or service</para>
        '''</remarks>
        Property C003_02 As String

        '''<summary>Procedure Modifier</summary>
        '''<remarks> 
        '''<para>This identifies special circumstances related to the performance of the service, as defined by trading partners</para>
        '''</remarks>
        Property C003_03 As String

        '''<summary>Procedure Modifier</summary>
        '''<remarks> 
        '''<para>This identifies special circumstances related to the performance of the service, as defined by trading partners</para>
        '''</remarks>
        Property C003_04 As String

        '''<summary>Procedure Modifier</summary>
        '''<remarks> 
        '''<para>This identifies special circumstances related to the performance of the service, as defined by trading partners</para>
        '''</remarks>
        Property C003_05 As String

        '''<summary>Procedure Modifier</summary>
        '''<remarks> 
        '''<para>This identifies special circumstances related to the performance of the service, as defined by trading partners</para>
        '''</remarks>
        Property C003_06 As String

        '''<summary>Description</summary>
        '''<remarks> 
        '''<para>A free-form description to clarify the related data elements and their content</para>
        '''</remarks>
        Property C003_07 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks> 
        '''<para>Identifying number for a product or service</para>
        '''</remarks>
        Property C003_08 As String
    End Interface
End Namespace