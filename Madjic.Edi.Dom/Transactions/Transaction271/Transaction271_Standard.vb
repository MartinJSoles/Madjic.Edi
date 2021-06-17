Namespace Transactions.Transaction271

    Partial Friend Class Standard_Obj
        Inherits TransactionSet
        Implements Standard, Transaction271_B1.TransactionSet
        Friend Sub New(versionCode As String)
            Me.New(String.Empty, versionCode)
        End Sub

        Friend Sub New(controlNumber As String, versionCode As String)
            MyBase.New("HB", versionCode)

            Children.AddRange({New Segments.ST_Obj,
                                        CType(Nothing, Segments.BHT_Obj),
                                        New LoopContainer(Of Loops.Loop2000)(0, 2, 100),
                                        New Segments.SE_Obj})

            ST_Obj.ST01 = "271"
            ST_Obj.ST02 = controlNumber
            ST_Obj.ST03 = versionCode

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
                        New ReaderState(1, "BHT", ReadAction.PopulateSegment, 2, False),
                        New ReaderState(2, "HL", ReadAction.PopulateLoop, 3, False),
                        New ReaderState(3, "HL", ReadAction.PopulateLoop, 3, False),
                        New ReaderState(3, "SE", ReadAction.PopulateSegment, 5, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                ST_Obj = Seg
                Dim S2 = CType(Seg, Segments.ST_Obj)
                If CompareKey(S2.ST01, ";271;") AndAlso String.Compare(args.Implementation, "_271B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 1
                    Seg.SetSequence = 36
                End If
            ElseIf String.Compare(SegmentName, "BHT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.BHT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                BHT_Obj = Seg
            ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                SE_Obj = Seg
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2000_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(2)
                Loop2000_Obj.Add(NewLoop)
                If CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_271B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000A"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_271B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000B"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_271B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_271B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            End If
            args.Implementation = Temp
        End Function
        Friend Property ST_Obj As Segments.ST_Obj
            Get
                Return CType(Children(0), Segments.ST_Obj)
            End Get
            Set(value As Segments.ST_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property ST_Std As Segments.ST Implements Standard.ST
            Get
                Return CType(Children(0), Segments.ST_Obj)
            End Get
            Set(value As Segments.ST)
                Children(0) = value
            End Set
        End Property

        Private Property ST_IFace_Transaction271_B1 As Transaction271_B1.Segments.ST Implements Transaction271_B1.TransactionSet.ST
            Get
                Return CType(Children(0), Transaction271_B1.Segments.ST)
            End Get
            Set(value As Transaction271_B1.Segments.ST)
                Children(0) = value
            End Set
        End Property
        Friend Property BHT_Obj As Segments.BHT_Obj
            Get
                Return CType(Children(1), Segments.BHT_Obj)
            End Get
            Set(value As Segments.BHT_Obj)
                Children(1) = value
            End Set
        End Property

        Private Property BHT_Std As Segments.BHT Implements Standard.BHT
            Get
                Return CType(Children(1), Segments.BHT_Obj)
            End Get
            Set(value As Segments.BHT)
                Children(1) = value
            End Set
        End Property

        Private Property BHT_IFace_Transaction271_B1 As Transaction271_B1.Segments.BHT Implements Transaction271_B1.TransactionSet.BHT
            Get
                Return CType(Children(1), Transaction271_B1.Segments.BHT)
            End Get
            Set(value As Transaction271_B1.Segments.BHT)
                Children(1) = value
            End Set
        End Property
        Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Loops.Loop2000) Implements Standard.Loop2000
            Get
                Return CType(Children(2), LoopContainer(Of Loops.Loop2000))
            End Get
        End Property

        Private Loop2000ASubset_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000A, Loops.Loop2000)
        Private ReadOnly Property Loop2000A_Obj_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000A, Loops.Loop2000) Implements Transaction271_B1.TransactionSet.Loop2000A
            Get
                If Loop2000ASubset_Transaction271_B1 Is Nothing Then
                    Loop2000ASubset_Transaction271_B1 = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000A, Loops.Loop2000)(Children(2), 0, 2, 36)
                End If

                Return Loop2000ASubset_Transaction271_B1
            End Get
        End Property
        Private Loop2000BSubset_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000B, Loops.Loop2000)
        Private ReadOnly Property Loop2000B_Obj_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000B, Loops.Loop2000) Implements Transaction271_B1.TransactionSet.Loop2000B
            Get
                If Loop2000BSubset_Transaction271_B1 Is Nothing Then
                    Loop2000BSubset_Transaction271_B1 = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000B, Loops.Loop2000)(Children(2), 0, 3, 36)
                End If

                Return Loop2000BSubset_Transaction271_B1
            End Get
        End Property
        Private Loop2000CSubset_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000C, Loops.Loop2000)
        Private ReadOnly Property Loop2000C_Obj_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000C, Loops.Loop2000) Implements Transaction271_B1.TransactionSet.Loop2000C
            Get
                If Loop2000CSubset_Transaction271_B1 Is Nothing Then
                    Loop2000CSubset_Transaction271_B1 = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000C, Loops.Loop2000)(Children(2), 0, 4, 36)
                End If

                Return Loop2000CSubset_Transaction271_B1
            End Get
        End Property
        Private Loop2000DSubset_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000D, Loops.Loop2000)
        Private ReadOnly Property Loop2000D_Obj_Transaction271_B1 As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000D, Loops.Loop2000) Implements Transaction271_B1.TransactionSet.Loop2000D
            Get
                If Loop2000DSubset_Transaction271_B1 Is Nothing Then
                    Loop2000DSubset_Transaction271_B1 = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2000D, Loops.Loop2000)(Children(2), 0, 5, 36)
                End If

                Return Loop2000DSubset_Transaction271_B1
            End Get
        End Property
        Friend Property SE_Obj As Segments.SE_Obj
            Get
                Return CType(Children(3), Segments.SE_Obj)
            End Get
            Set(value As Segments.SE_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property SE_Std As Segments.SE Implements Standard.SE
            Get
                Return CType(Children(3), Segments.SE_Obj)
            End Get
            Set(value As Segments.SE)
                Children(3) = value
            End Set
        End Property

        Private Property SE_IFace_Transaction271_B1 As Transaction271_B1.Segments.SE Implements Transaction271_B1.TransactionSet.SE
            Get
                Return CType(Children(3), Transaction271_B1.Segments.SE)
            End Get
            Set(value As Transaction271_B1.Segments.SE)
                Children(3) = value
            End Set
        End Property
    End Class

    Partial Friend Class Loop2000_Obj
        Inherits LoopBase
        Implements Loops.Loop2000,
                                Transaction271_B1.Loops.Loop2000A,
                                Transaction271_B1.Loops.Loop2000B,
                                Transaction271_B1.Loops.Loop2000C,
                                Transaction271_B1.Loops.Loop2000D
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.HL_Obj),
                                            New SegmentContainer(Of Segments.TRN)(2, 2, 200),
                                            New SegmentContainer(Of Segments.AAA)(9, 2, 250),
                                            New LoopContainer(Of Loops.Loop2100)(0, 2, 300)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "HL", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(1, "TRN", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(2, "TRN", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "AAA", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "AAA", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(4, "AAA", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(1, "NM1", ReadAction.PopulateLoop, 6, False),
                            New ReaderState(2, "NM1", ReadAction.PopulateLoop, 6, False),
                            New ReaderState(4, "NM1", ReadAction.PopulateLoop, 6, False),
                            New ReaderState(6, "NM1", ReadAction.PopulateLoop, 6, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.HL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                HL_Obj = Seg
                Dim S2 = CType(Seg, Segments.HL_Obj)
                If CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_271B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 2
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_271B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_271B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_271B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 36
                End If
            ElseIf String.Compare(SegmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                TRN_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "AAA", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AAA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AAA_Obj.Add(Seg)
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2100_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2100_Obj.Add(NewLoop)
                If CompareKey(LoopKey, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_271B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000A__2100A"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_271B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000B__2100B"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_271B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000C__2100C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";03;") AndAlso String.Compare(args.Implementation, "_271B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000D__2100D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            End If
            args.Implementation = Temp
        End Function
        Friend Property HL_Obj As Segments.HL_Obj
            Get
                Return CType(Children(0), Segments.HL_Obj)
            End Get
            Set(value As Segments.HL_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property HL_Std As Segments.HL Implements Loops.Loop2000.HL
            Get
                Return CType(Children(0), Segments.HL_Obj)
            End Get
            Set(value As Segments.HL)
                Children(0) = value
            End Set
        End Property

        Private Property HL_IFace_Loop2000A_Obj As Transaction271_B1.Segments.Loop2000A.HL Implements Transaction271_B1.Loops.Loop2000A.HL
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2000A.HL)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2000A.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_1_Loop2000B_Obj As Transaction271_B1.Segments.Loop2000B.HL Implements Transaction271_B1.Loops.Loop2000B.HL
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2000B.HL)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2000B.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_2_Loop2000C_Obj As Transaction271_B1.Segments.Loop2000C.HL Implements Transaction271_B1.Loops.Loop2000C.HL
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2000C.HL)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2000C.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_3_Loop2000D_Obj As Transaction271_B1.Segments.Loop2000D.HL Implements Transaction271_B1.Loops.Loop2000D.HL
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2000D.HL)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2000D.HL)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property TRN_Obj As SegmentContainer(Of Segments.TRN) Implements Loops.Loop2000.TRN
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.TRN))
            End Get
        End Property

        Private TRNSubset_Loop2000C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000C.TRN, Segments.TRN)
        Private ReadOnly Property TRN_Loop2000C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000C.TRN, Segments.TRN) Implements Transaction271_B1.Loops.Loop2000C.TRN
            Get
                If TRNSubset_Loop2000C_Obj Is Nothing Then
                    TRNSubset_Loop2000C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000C.TRN, Segments.TRN)(Children(1), 3, 4, 72)
                End If

                Return TRNSubset_Loop2000C_Obj
            End Get
        End Property
        Private TRNSubset_1_Loop2000D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000D.TRN, Segments.TRN)
        Private ReadOnly Property TRN_Loop2000D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000D.TRN, Segments.TRN) Implements Transaction271_B1.Loops.Loop2000D.TRN
            Get
                If TRNSubset_1_Loop2000D_Obj Is Nothing Then
                    TRNSubset_1_Loop2000D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000D.TRN, Segments.TRN)(Children(1), 3, 5, 72)
                End If

                Return TRNSubset_1_Loop2000D_Obj
            End Get
        End Property
        Friend ReadOnly Property AAA_Obj As SegmentContainer(Of Segments.AAA) Implements Loops.Loop2000.AAA
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.AAA))
            End Get
        End Property

        Private AAASubset_Loop2000A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000A.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2000A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000A.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2000A.AAA
            Get
                If AAASubset_Loop2000A_Obj Is Nothing Then
                    AAASubset_Loop2000A_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2000A.AAA, Segments.AAA)(Children(2), 9, 2, 6552)
                End If

                Return AAASubset_Loop2000A_Obj
            End Get
        End Property
        Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Loops.Loop2100) Implements Loops.Loop2000.Loop2100
            Get
                Return CType(Children(3), LoopContainer(Of Loops.Loop2100))
            End Get
        End Property

        Private Loop2100ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100A, Loops.Loop2100)
        Private Property Loop2100A_IFace_Loop2000A_Obj As Transaction271_B1.Loops.Loop2100A Implements Transaction271_B1.Loops.Loop2000A.Loop2100A
            Get
                If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                    Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100A, Loops.Loop2100)(Children(3), 1, 2, 108)
                End If

                If Loop2100ASubset_Loop2000A_Obj.Count > 0 Then
                    Return Loop2100ASubset_Loop2000A_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Loops.Loop2100A)
                If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                    Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100A, Loops.Loop2100)(Children(3), 1, 2, 108)
                End If

                If Loop2100ASubset_Loop2000A_Obj.Count = 0 Then
                    Loop2100ASubset_Loop2000A_Obj.Add(value)
                Else
                    Loop2100ASubset_Loop2000A_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100B, Loops.Loop2100)
        Private Property Loop2100B_IFace_Loop2000B_Obj As Transaction271_B1.Loops.Loop2100B Implements Transaction271_B1.Loops.Loop2000B.Loop2100B
            Get
                If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100B, Loops.Loop2100)(Children(3), 1, 3, 108)
                End If

                If Loop2100BSubset_Loop2000B_Obj.Count > 0 Then
                    Return Loop2100BSubset_Loop2000B_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Loops.Loop2100B)
                If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100B, Loops.Loop2100)(Children(3), 1, 3, 108)
                End If

                If Loop2100BSubset_Loop2000B_Obj.Count = 0 Then
                    Loop2100BSubset_Loop2000B_Obj.Add(value)
                Else
                    Loop2100BSubset_Loop2000B_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100C, Loops.Loop2100)
        Private Property Loop2100C_IFace_Loop2000C_Obj As Transaction271_B1.Loops.Loop2100C Implements Transaction271_B1.Loops.Loop2000C.Loop2100C
            Get
                If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
                    Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100C, Loops.Loop2100)(Children(3), 1, 4, 108)
                End If

                If Loop2100CSubset_Loop2000C_Obj.Count > 0 Then
                    Return Loop2100CSubset_Loop2000C_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Loops.Loop2100C)
                If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
                    Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100C, Loops.Loop2100)(Children(3), 1, 4, 108)
                End If

                If Loop2100CSubset_Loop2000C_Obj.Count = 0 Then
                    Loop2100CSubset_Loop2000C_Obj.Add(value)
                Else
                    Loop2100CSubset_Loop2000C_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100D, Loops.Loop2100)
        Private Property Loop2100D_IFace_Loop2000D_Obj As Transaction271_B1.Loops.Loop2100D Implements Transaction271_B1.Loops.Loop2000D.Loop2100D
            Get
                If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                    Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100D, Loops.Loop2100)(Children(3), 1, 5, 108)
                End If

                If Loop2100DSubset_Loop2000D_Obj.Count > 0 Then
                    Return Loop2100DSubset_Loop2000D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Loops.Loop2100D)
                If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                    Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2100D, Loops.Loop2100)(Children(3), 1, 5, 108)
                End If

                If Loop2100DSubset_Loop2000D_Obj.Count = 0 Then
                    Loop2100DSubset_Loop2000D_Obj.Add(value)
                Else
                    Loop2100DSubset_Loop2000D_Obj(0) = value
                End If
            End Set
        End Property

    End Class
    Partial Friend Class Loop2100_Obj
        Inherits LoopBase
        Implements Loops.Loop2100,
                                Transaction271_B1.Loops.Loop2100A,
                                Transaction271_B1.Loops.Loop2100B,
                                Transaction271_B1.Loops.Loop2100C,
                                Transaction271_B1.Loops.Loop2100D
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.NM1_Obj),
                                            New SegmentContainer(Of Segments.REF)(9, 2, 400),
                                            CType(Nothing, Segments.N2_Obj),
                                            CType(Nothing, Segments.N3_Obj),
                                            CType(Nothing, Segments.N4_Obj),
                                            New SegmentContainer(Of Segments.PER)(3, 2, 800),
                                            New SegmentContainer(Of Segments.AAA)(9, 2, 850),
                                            CType(Nothing, Segments.PRV_Obj),
                                            CType(Nothing, Segments.DMG_Obj),
                                            CType(Nothing, Segments.INS_Obj),
                                            CType(Nothing, Segments.HI_Obj),
                                            New SegmentContainer(Of Segments.DTP)(9, 2, 1200),
                                            New SegmentContainer(Of Segments.LUI)(9, 2, 1250),
                                            New SegmentContainer(Of Segments.MPI)(9, 2, 1275),
                                            New LoopContainer(Of Loops.Loop2110)(0, 2, 1300)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "N2", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "N2", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(1, "N3", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(2, "N3", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(4, "N3", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(1, "N4", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(2, "N4", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(4, "N4", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(5, "N4", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(1, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(2, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(4, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(5, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(6, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(7, "PER", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(1, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(2, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(4, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(5, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(6, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(7, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(9, "AAA", ReadAction.PopulateSegment, 9, False),
                            New ReaderState(1, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(2, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(4, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(5, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(6, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(7, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(9, "PRV", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(1, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(2, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(4, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(5, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(6, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(7, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(9, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(11, "DMG", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(1, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(2, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(4, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(5, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(6, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(7, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(9, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(11, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(12, "INS", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(1, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(2, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(4, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(5, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(6, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(7, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(9, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(11, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(12, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(13, "HI", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(1, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(2, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(4, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(5, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(6, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(7, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(9, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(11, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(12, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(13, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(14, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(15, "DTP", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(1, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(2, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(4, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(5, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(6, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(7, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(9, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(11, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(12, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(13, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(14, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(15, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(17, "LUI", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(1, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(2, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(4, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(5, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(6, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(7, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(9, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(11, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(12, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(13, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(14, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(15, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(17, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(19, "MPI", ReadAction.PopulateSegment, 19, False),
                            New ReaderState(1, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(2, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(4, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(5, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(6, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(7, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(9, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(11, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(12, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(13, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(14, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(15, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(17, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(19, "EB", ReadAction.PopulateLoop, 21, False),
                            New ReaderState(21, "EB", ReadAction.PopulateLoop, 21, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                NM1_Obj = Seg
                Dim S2 = CType(Seg, Segments.NM1_Obj)
                If CompareKey(S2.NM101, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_271B1__2000A__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 2
                    Seg.SetSequence = 108
                ElseIf CompareKey(S2.NM101, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_271B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 108
                ElseIf CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 108
                ElseIf CompareKey(S2.NM101, ";03;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 108
                End If
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.REF_Obj)
                If CompareKey(S2.REF01, ";0B;1C;1D;1J;4A;CT;EL;EO;HPI;JD;N5;N7;Q4;SY;TJ;") AndAlso String.Compare(args.Implementation, "_271B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 144
                ElseIf CompareKey(S2.REF01, ";18;1L;1W;3H;49;6P;CE;CT;EA;EJ;F6;GH;HJ;IF;IG;N6;NQ;Q4;SY;Y4;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 144
                ElseIf CompareKey(S2.REF01, ";18;1L;1W;49;6P;CE;CT;EA;EJ;F6;GH;HJ;IF;IG;MRC;N6;NQ;Q4;SY;Y4;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 144
                End If
            ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N2_Obj = Seg
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj = Seg
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "AAA", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AAA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AAA_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PRV_Obj = Seg
                Dim S2 = CType(Seg, Segments.PRV_Obj)
                If CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SB;SK;SU;") AndAlso String.Compare(args.Implementation, "_271B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 324
                ElseIf CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 324
                ElseIf CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 324
                End If
            ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DMG_Obj = Seg
            ElseIf String.Compare(SegmentName, "INS", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.INS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                INS_Obj = Seg
            ElseIf String.Compare(SegmentName, "HI", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.HI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                HI_Obj = Seg
                Dim S2 = CType(Seg, Segments.HI_Obj)
                If CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 6517
                ElseIf CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 6517
                End If
            ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DTP_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.DTP_Obj)
                If CompareKey(S2.DTP01, ";096;102;152;291;307;318;340;341;342;343;346;347;356;357;382;435;442;458;472;539;540;636;771;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 73
                ElseIf CompareKey(S2.DTP01, ";096;102;152;291;307;318;340;341;342;343;346;347;356;357;382;435;442;458;472;539;540;636;771;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 73
                End If
            ElseIf String.Compare(SegmentName, "LUI", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.LUI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                LUI_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "MPI", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.MPI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                MPI_Obj.Add(Seg)
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "EB", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2110_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2110_Obj.Add(NewLoop)
                If String.Compare(args.Implementation, "_271B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000C__2100C__2110C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_271B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000D__2100D__2110D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            End If
            args.Implementation = Temp
        End Function
        Friend Property NM1_Obj As Segments.NM1_Obj
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property NM1_Std As Segments.NM1 Implements Loops.Loop2100.NM1
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1)
                Children(0) = value
            End Set
        End Property

        Private Property NM1_IFace_Loop2100A_Obj As Transaction271_B1.Segments.Loop2100A.NM1 Implements Transaction271_B1.Loops.Loop2100A.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2100A.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100A.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_1_Loop2100B_Obj As Transaction271_B1.Segments.Loop2100B.NM1 Implements Transaction271_B1.Loops.Loop2100B.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2100B.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100B.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_2_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.NM1 Implements Transaction271_B1.Loops.Loop2100C.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2100C.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_3_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.NM1 Implements Transaction271_B1.Loops.Loop2100D.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2100D.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.NM1)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Loops.Loop2100.REF
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.REF))
            End Get
        End Property

        Private REFSubset_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.REF, Segments.REF)
        Private ReadOnly Property REF_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.REF, Segments.REF) Implements Transaction271_B1.Loops.Loop2100B.REF
            Get
                If REFSubset_Loop2100B_Obj Is Nothing Then
                    REFSubset_Loop2100B_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.REF, Segments.REF)(Children(1), 9, 3, 144)
                End If

                Return REFSubset_Loop2100B_Obj
            End Get
        End Property
        Private REFSubset_1_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.REF, Segments.REF)
        Private ReadOnly Property REF_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.REF, Segments.REF) Implements Transaction271_B1.Loops.Loop2100C.REF
            Get
                If REFSubset_1_Loop2100C_Obj Is Nothing Then
                    REFSubset_1_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.REF, Segments.REF)(Children(1), 9, 4, 144)
                End If

                Return REFSubset_1_Loop2100C_Obj
            End Get
        End Property
        Private REFSubset_2_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.REF, Segments.REF)
        Private ReadOnly Property REF_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.REF, Segments.REF) Implements Transaction271_B1.Loops.Loop2100D.REF
            Get
                If REFSubset_2_Loop2100D_Obj Is Nothing Then
                    REFSubset_2_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.REF, Segments.REF)(Children(1), 9, 5, 144)
                End If

                Return REFSubset_2_Loop2100D_Obj
            End Get
        End Property
        Friend Property N2_Obj As Segments.N2_Obj
            Get
                Return CType(Children(2), Segments.N2_Obj)
            End Get
            Set(value As Segments.N2_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property N2_Std As Segments.N2 Implements Loops.Loop2100.N2
            Get
                Return CType(Children(2), Segments.N2_Obj)
            End Get
            Set(value As Segments.N2)
                Children(2) = value
            End Set
        End Property

        Friend Property N3_Obj As Segments.N3_Obj
            Get
                Return CType(Children(3), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property N3_Std As Segments.N3 Implements Loops.Loop2100.N3
            Get
                Return CType(Children(3), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3)
                Children(3) = value
            End Set
        End Property

        Private Property N3_IFace_Loop2100B_Obj As Transaction271_B1.Segments.Loop2100B.N3 Implements Transaction271_B1.Loops.Loop2100B.N3
            Get
                Return CType(Children(3), Transaction271_B1.Segments.Loop2100B.N3)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100B.N3)
                Children(3) = value
            End Set
        End Property
        Private Property N3_IFace_1_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.N3 Implements Transaction271_B1.Loops.Loop2100C.N3
            Get
                Return CType(Children(3), Transaction271_B1.Segments.Loop2100C.N3)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.N3)
                Children(3) = value
            End Set
        End Property
        Private Property N3_IFace_2_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.N3 Implements Transaction271_B1.Loops.Loop2100D.N3
            Get
                Return CType(Children(3), Transaction271_B1.Segments.Loop2100D.N3)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.N3)
                Children(3) = value
            End Set
        End Property
        Friend Property N4_Obj As Segments.N4_Obj
            Get
                Return CType(Children(4), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4_Obj)
                Children(4) = value
            End Set
        End Property

        Private Property N4_Std As Segments.N4 Implements Loops.Loop2100.N4
            Get
                Return CType(Children(4), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(4) = value
            End Set
        End Property

        Private Property N4_IFace_Loop2100B_Obj As Transaction271_B1.Segments.Loop2100B.N4 Implements Transaction271_B1.Loops.Loop2100B.N4
            Get
                Return CType(Children(4), Transaction271_B1.Segments.Loop2100B.N4)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100B.N4)
                Children(4) = value
            End Set
        End Property
        Private Property N4_IFace_1_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.N4 Implements Transaction271_B1.Loops.Loop2100C.N4
            Get
                Return CType(Children(4), Transaction271_B1.Segments.Loop2100C.N4)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.N4)
                Children(4) = value
            End Set
        End Property
        Private Property N4_IFace_2_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.N4 Implements Transaction271_B1.Loops.Loop2100D.N4
            Get
                Return CType(Children(4), Transaction271_B1.Segments.Loop2100D.N4)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.N4)
                Children(4) = value
            End Set
        End Property
        Friend ReadOnly Property PER_Obj As SegmentContainer(Of Segments.PER) Implements Loops.Loop2100.PER
            Get
                Return CType(Children(5), SegmentContainer(Of Segments.PER))
            End Get
        End Property

        Private PERSubset_Loop2100A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.PER, Segments.PER)
        Private ReadOnly Property PER_Loop2100A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.PER, Segments.PER) Implements Transaction271_B1.Loops.Loop2100A.PER
            Get
                If PERSubset_Loop2100A_Obj Is Nothing Then
                    PERSubset_Loop2100A_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.PER, Segments.PER)(Children(5), 3, 2, 288)
                End If

                Return PERSubset_Loop2100A_Obj
            End Get
        End Property
        Friend ReadOnly Property AAA_Obj As SegmentContainer(Of Segments.AAA) Implements Loops.Loop2100.AAA
            Get
                Return CType(Children(6), SegmentContainer(Of Segments.AAA))
            End Get
        End Property

        Private AAASubset_Loop2100A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2100A_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2100A.AAA
            Get
                If AAASubset_Loop2100A_Obj Is Nothing Then
                    AAASubset_Loop2100A_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100A.AAA, Segments.AAA)(Children(6), 9, 2, 6768)
                End If

                Return AAASubset_Loop2100A_Obj
            End Get
        End Property
        Private AAASubset_1_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2100B.AAA
            Get
                If AAASubset_1_Loop2100B_Obj Is Nothing Then
                    AAASubset_1_Loop2100B_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100B.AAA, Segments.AAA)(Children(6), 9, 3, 6768)
                End If

                Return AAASubset_1_Loop2100B_Obj
            End Get
        End Property
        Private AAASubset_2_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2100C.AAA
            Get
                If AAASubset_2_Loop2100C_Obj Is Nothing Then
                    AAASubset_2_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.AAA, Segments.AAA)(Children(6), 9, 4, 6768)
                End If

                Return AAASubset_2_Loop2100C_Obj
            End Get
        End Property
        Private AAASubset_3_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2100D.AAA
            Get
                If AAASubset_3_Loop2100D_Obj Is Nothing Then
                    AAASubset_3_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.AAA, Segments.AAA)(Children(6), 9, 5, 6768)
                End If

                Return AAASubset_3_Loop2100D_Obj
            End Get
        End Property
        Friend Property PRV_Obj As Segments.PRV_Obj
            Get
                Return CType(Children(7), Segments.PRV_Obj)
            End Get
            Set(value As Segments.PRV_Obj)
                Children(7) = value
            End Set
        End Property

        Private Property PRV_Std As Segments.PRV Implements Loops.Loop2100.PRV
            Get
                Return CType(Children(7), Segments.PRV_Obj)
            End Get
            Set(value As Segments.PRV)
                Children(7) = value
            End Set
        End Property

        Private Property PRV_IFace_Loop2100B_Obj As Transaction271_B1.Segments.Loop2100B.PRV Implements Transaction271_B1.Loops.Loop2100B.PRV
            Get
                Return CType(Children(7), Transaction271_B1.Segments.Loop2100B.PRV)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100B.PRV)
                Children(7) = value
            End Set
        End Property
        Private Property PRV_IFace_1_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.PRV Implements Transaction271_B1.Loops.Loop2100C.PRV
            Get
                Return CType(Children(7), Transaction271_B1.Segments.Loop2100C.PRV)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.PRV)
                Children(7) = value
            End Set
        End Property
        Private Property PRV_IFace_2_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.PRV Implements Transaction271_B1.Loops.Loop2100D.PRV
            Get
                Return CType(Children(7), Transaction271_B1.Segments.Loop2100D.PRV)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.PRV)
                Children(7) = value
            End Set
        End Property
        Friend Property DMG_Obj As Segments.DMG_Obj
            Get
                Return CType(Children(8), Segments.DMG_Obj)
            End Get
            Set(value As Segments.DMG_Obj)
                Children(8) = value
            End Set
        End Property

        Private Property DMG_Std As Segments.DMG Implements Loops.Loop2100.DMG
            Get
                Return CType(Children(8), Segments.DMG_Obj)
            End Get
            Set(value As Segments.DMG)
                Children(8) = value
            End Set
        End Property

        Private Property DMG_IFace_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.DMG Implements Transaction271_B1.Loops.Loop2100C.DMG
            Get
                Return CType(Children(8), Transaction271_B1.Segments.Loop2100C.DMG)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.DMG)
                Children(8) = value
            End Set
        End Property
        Private Property DMG_IFace_1_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.DMG Implements Transaction271_B1.Loops.Loop2100D.DMG
            Get
                Return CType(Children(8), Transaction271_B1.Segments.Loop2100D.DMG)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.DMG)
                Children(8) = value
            End Set
        End Property
        Friend Property INS_Obj As Segments.INS_Obj
            Get
                Return CType(Children(9), Segments.INS_Obj)
            End Get
            Set(value As Segments.INS_Obj)
                Children(9) = value
            End Set
        End Property

        Private Property INS_Std As Segments.INS Implements Loops.Loop2100.INS
            Get
                Return CType(Children(9), Segments.INS_Obj)
            End Get
            Set(value As Segments.INS)
                Children(9) = value
            End Set
        End Property

        Private Property INS_IFace_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.INS Implements Transaction271_B1.Loops.Loop2100C.INS
            Get
                Return CType(Children(9), Transaction271_B1.Segments.Loop2100C.INS)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.INS)
                Children(9) = value
            End Set
        End Property
        Private Property INS_IFace_1_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.INS Implements Transaction271_B1.Loops.Loop2100D.INS
            Get
                Return CType(Children(9), Transaction271_B1.Segments.Loop2100D.INS)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.INS)
                Children(9) = value
            End Set
        End Property
        Friend Property HI_Obj As Segments.HI_Obj
            Get
                Return CType(Children(10), Segments.HI_Obj)
            End Get
            Set(value As Segments.HI_Obj)
                Children(10) = value
            End Set
        End Property

        Private Property HI_Std As Segments.HI Implements Loops.Loop2100.HI
            Get
                Return CType(Children(10), Segments.HI_Obj)
            End Get
            Set(value As Segments.HI)
                Children(10) = value
            End Set
        End Property

        Private Property HI_IFace_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.HI Implements Transaction271_B1.Loops.Loop2100C.HI
            Get
                Return CType(Children(10), Transaction271_B1.Segments.Loop2100C.HI)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.HI)
                Children(10) = value
            End Set
        End Property
        Private Property HI_IFace_1_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.HI Implements Transaction271_B1.Loops.Loop2100D.HI
            Get
                Return CType(Children(10), Transaction271_B1.Segments.Loop2100D.HI)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.HI)
                Children(10) = value
            End Set
        End Property
        Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2100.DTP
            Get
                Return CType(Children(11), SegmentContainer(Of Segments.DTP))
            End Get
        End Property

        Private DTPSubset_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.DTP, Segments.DTP)
        Private ReadOnly Property DTP_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.DTP, Segments.DTP) Implements Transaction271_B1.Loops.Loop2100C.DTP
            Get
                If DTPSubset_Loop2100C_Obj Is Nothing Then
                    DTPSubset_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.DTP, Segments.DTP)(Children(11), 9, 4, 73)
                End If

                Return DTPSubset_Loop2100C_Obj
            End Get
        End Property
        Private DTPSubset_1_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.DTP, Segments.DTP)
        Private ReadOnly Property DTP_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.DTP, Segments.DTP) Implements Transaction271_B1.Loops.Loop2100D.DTP
            Get
                If DTPSubset_1_Loop2100D_Obj Is Nothing Then
                    DTPSubset_1_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.DTP, Segments.DTP)(Children(11), 9, 5, 73)
                End If

                Return DTPSubset_1_Loop2100D_Obj
            End Get
        End Property
        Friend ReadOnly Property LUI_Obj As SegmentContainer(Of Segments.LUI) Implements Loops.Loop2100.LUI
            Get
                Return CType(Children(12), SegmentContainer(Of Segments.LUI))
            End Get
        End Property

        Friend ReadOnly Property MPI_Obj As SegmentContainer(Of Segments.MPI) Implements Loops.Loop2100.MPI
            Get
                Return CType(Children(13), SegmentContainer(Of Segments.MPI))
            End Get
        End Property

        Private MPISubset_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.MPI, Segments.MPI)
        Private Property MPI_IFace_Loop2100C_Obj As Transaction271_B1.Segments.Loop2100C.MPI Implements Transaction271_B1.Loops.Loop2100C.MPI
            Get
                If MPISubset_Loop2100C_Obj Is Nothing Then
                    MPISubset_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.MPI, Segments.MPI)(Children(13), 1, 4, 242425)
                End If

                If MPISubset_Loop2100C_Obj.Count > 0 Then
                    Return MPISubset_Loop2100C_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100C.MPI)
                If MPISubset_Loop2100C_Obj Is Nothing Then
                    MPISubset_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100C.MPI, Segments.MPI)(Children(13), 1, 4, 242425)
                End If

                If MPISubset_Loop2100C_Obj.Count = 0 Then
                    MPISubset_Loop2100C_Obj.Add(value)
                Else
                    MPISubset_Loop2100C_Obj(0) = value
                End If
            End Set
        End Property
        Private MPISubset_1_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.MPI, Segments.MPI)
        Private Property MPI_IFace_1_Loop2100D_Obj As Transaction271_B1.Segments.Loop2100D.MPI Implements Transaction271_B1.Loops.Loop2100D.MPI
            Get
                If MPISubset_1_Loop2100D_Obj Is Nothing Then
                    MPISubset_1_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.MPI, Segments.MPI)(Children(13), 1, 5, 242425)
                End If

                If MPISubset_1_Loop2100D_Obj.Count > 0 Then
                    Return MPISubset_1_Loop2100D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction271_B1.Segments.Loop2100D.MPI)
                If MPISubset_1_Loop2100D_Obj Is Nothing Then
                    MPISubset_1_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2100D.MPI, Segments.MPI)(Children(13), 1, 5, 242425)
                End If

                If MPISubset_1_Loop2100D_Obj.Count = 0 Then
                    MPISubset_1_Loop2100D_Obj.Add(value)
                Else
                    MPISubset_1_Loop2100D_Obj(0) = value
                End If
            End Set
        End Property
        Friend ReadOnly Property Loop2110_Obj As LoopContainer(Of Loops.Loop2110) Implements Loops.Loop2100.Loop2110
            Get
                Return CType(Children(14), LoopContainer(Of Loops.Loop2110))
            End Get
        End Property

        Private Loop2110CSubset_Loop2100C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110C, Loops.Loop2110)
        Private ReadOnly Property Loop2110C_Obj_Loop2100C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110C, Loops.Loop2110) Implements Transaction271_B1.Loops.Loop2100C.Loop2110C
            Get
                If Loop2110CSubset_Loop2100C_Obj Is Nothing Then
                    Loop2110CSubset_Loop2100C_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110C, Loops.Loop2110)(Children(14), 0, 4, 109)
                End If

                Return Loop2110CSubset_Loop2100C_Obj
            End Get
        End Property
        Private Loop2110DSubset_Loop2100D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110D, Loops.Loop2110)
        Private ReadOnly Property Loop2110D_Obj_Loop2100D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110D, Loops.Loop2110) Implements Transaction271_B1.Loops.Loop2100D.Loop2110D
            Get
                If Loop2110DSubset_Loop2100D_Obj Is Nothing Then
                    Loop2110DSubset_Loop2100D_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2110D, Loops.Loop2110)(Children(14), 0, 5, 109)
                End If

                Return Loop2110DSubset_Loop2100D_Obj
            End Get
        End Property

    End Class
    Partial Friend Class Loop2110_Obj
        Inherits LoopBase
        Implements Loops.Loop2110,
                                Transaction271_B1.Loops.Loop2110C,
                                Transaction271_B1.Loops.Loop2110D
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.EB_Obj),
                                            New SegmentContainer(Of Segments.HSD)(9, 2, 1350),
                                            New SegmentContainer(Of Segments.REF)(9, 2, 1400),
                                            New SegmentContainer(Of Segments.DTP)(20, 2, 1500),
                                            New SegmentContainer(Of Segments.AAA)(9, 2, 1600),
                                            CType(Nothing, Segments.VEH_Obj),
                                            CType(Nothing, Segments.PID_Obj),
                                            CType(Nothing, Segments.PDR_Obj),
                                            CType(Nothing, Segments.PDP_Obj),
                                            CType(Nothing, Segments.LIN_Obj),
                                            CType(Nothing, Segments.EM_Obj),
                                            CType(Nothing, Segments.SD1_Obj),
                                            CType(Nothing, Segments.PKD_Obj),
                                            New SegmentContainer(Of Segments.MSG)(10, 2, 2500),
                                            New LoopContainer(Of Loops.Loop2115)(0, 2, 2600),
                                            CType(Nothing, Segments.LS_Obj),
                                            New LoopContainer(Of Loops.Loop2120)(0, 2, 3400),
                                            CType(Nothing, Segments.LE_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "EB", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(1, "HSD", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(2, "HSD", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "REF", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(4, "REF", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(1, "DTP", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(2, "DTP", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(4, "DTP", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(6, "DTP", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(1, "AAA", ReadAction.PopulateSegment, 8, False),
                            New ReaderState(2, "AAA", ReadAction.PopulateSegment, 8, False),
                            New ReaderState(4, "AAA", ReadAction.PopulateSegment, 8, False),
                            New ReaderState(6, "AAA", ReadAction.PopulateSegment, 8, False),
                            New ReaderState(8, "AAA", ReadAction.PopulateSegment, 8, False),
                            New ReaderState(1, "VEH", ReadAction.PopulateSegment, 10, False),
                            New ReaderState(2, "VEH", ReadAction.PopulateSegment, 10, False),
                            New ReaderState(4, "VEH", ReadAction.PopulateSegment, 10, False),
                            New ReaderState(6, "VEH", ReadAction.PopulateSegment, 10, False),
                            New ReaderState(8, "VEH", ReadAction.PopulateSegment, 10, False),
                            New ReaderState(1, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(2, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(4, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(6, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(8, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(10, "PID", ReadAction.PopulateSegment, 11, False),
                            New ReaderState(1, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(2, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(4, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(6, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(8, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(10, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(11, "PDR", ReadAction.PopulateSegment, 12, False),
                            New ReaderState(1, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(2, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(4, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(6, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(8, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(10, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(11, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(12, "PDP", ReadAction.PopulateSegment, 13, False),
                            New ReaderState(1, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(2, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(4, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(6, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(8, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(10, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(11, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(12, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(13, "LIN", ReadAction.PopulateSegment, 14, False),
                            New ReaderState(1, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(2, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(4, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(6, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(8, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(10, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(11, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(12, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(13, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(14, "EM", ReadAction.PopulateSegment, 15, False),
                            New ReaderState(1, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(2, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(4, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(6, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(8, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(10, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(11, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(12, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(13, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(14, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(15, "SD1", ReadAction.PopulateSegment, 16, False),
                            New ReaderState(1, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(2, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(4, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(6, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(8, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(10, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(11, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(12, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(13, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(14, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(15, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(16, "PKD", ReadAction.PopulateSegment, 17, False),
                            New ReaderState(1, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(2, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(4, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(6, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(8, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(10, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(11, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(12, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(13, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(14, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(15, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(16, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(17, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(18, "MSG", ReadAction.PopulateSegment, 18, False),
                            New ReaderState(1, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(2, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(4, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(6, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(8, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(10, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(11, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(12, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(13, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(14, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(15, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(16, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(17, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(18, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(20, "III", ReadAction.PopulateLoop, 20, False),
                            New ReaderState(1, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(2, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(4, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(6, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(8, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(10, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(11, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(12, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(13, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(14, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(15, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(16, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(17, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(18, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(20, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 22, False),
                            New ReaderState(1, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(2, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(4, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(6, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(8, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(10, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(11, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(12, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(13, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(14, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(15, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(16, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(17, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(18, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(20, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(22, "LE", ReadAction.PopulateSegment, 25, False),
                            New ReaderState(23, "LE", ReadAction.PopulateSegment, 25, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "EB", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.EB_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                EB_Obj = Seg
            ElseIf String.Compare(SegmentName, "HSD", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.HSD_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                HSD_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.REF_Obj)
                If CompareKey(S2.REF01, ";18;1L;1W;49;6P;9F;ALS;CLI;F6;FO;G1;IG;M7;N6;NQ;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 145
                ElseIf CompareKey(S2.REF01, ";18;1L;1W;49;6P;9F;ALS;CLI;F6;FO;G1;IG;N6;NQ;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 145
                End If
            ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DTP_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.DTP_Obj)
                If CompareKey(S2.DTP01, ";096;193;194;198;290;291;292;295;304;307;318;346;348;349;356;357;435;472;636;771;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 181
                ElseIf CompareKey(S2.DTP01, ";096;193;194;198;290;291;292;295;304;307;318;346;348;349;356;357;435;472;636;771;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 181
                End If
            ElseIf String.Compare(SegmentName, "AAA", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AAA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AAA_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "VEH", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.VEH_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                VEH_Obj = Seg
            ElseIf String.Compare(SegmentName, "PID", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PID_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PID_Obj = Seg
            ElseIf String.Compare(SegmentName, "PDR", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PDR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PDR_Obj = Seg
            ElseIf String.Compare(SegmentName, "PDP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PDP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PDP_Obj = Seg
            ElseIf String.Compare(SegmentName, "LIN", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.LIN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                LIN_Obj = Seg
            ElseIf String.Compare(SegmentName, "EM", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.EM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                EM_Obj = Seg
            ElseIf String.Compare(SegmentName, "SD1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.SD1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                SD1_Obj = Seg
            ElseIf String.Compare(SegmentName, "PKD", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PKD_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PKD_Obj = Seg
            ElseIf String.Compare(SegmentName, "MSG", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.MSG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                MSG_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "LS", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.LS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                LS_Obj = Seg
                Dim S2 = CType(Seg, Segments.LS_Obj)
                If CompareKey(S2.LS01, ";") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 10621
                ElseIf CompareKey(S2.LS01, ";") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 10621
                End If
            ElseIf String.Compare(SegmentName, "LE", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.LE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                LE_Obj = Seg
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "III", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2115_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2115_Obj.Add(NewLoop)
                If String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000C__2100C__2110C__2115C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000D__2100D__2110D__2115D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            ElseIf String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 OrElse
                String.Compare(args.DataSegment.SegmentID, "N3", StringComparison.OrdinalIgnoreCase) = 0 OrElse
                String.Compare(args.DataSegment.SegmentID, "N4", StringComparison.OrdinalIgnoreCase) = 0 OrElse
                String.Compare(args.DataSegment.SegmentID, "PER", StringComparison.OrdinalIgnoreCase) = 0 OrElse
                String.Compare(args.DataSegment.SegmentID, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2120_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2120_Obj.Add(NewLoop)
                If CompareKey(LoopKey, ";13;1I;1P;2B;36;73;FA;GP;GW;I3;IL;LR;OC;P3;P4;P5;PR;PRP;SEP;TTP;VER;VN;VY;X3;Y2;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000C__2100C__2110C__2120C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";13;1I;1P;2B;36;73;FA;GP;GW;I3;IL;LR;OC;P3;P4;P5;PR;PRP;SEP;TTP;VER;VN;VY;X3;Y2;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_271B1__2000D__2100D__2110D__2120D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            End If
            args.Implementation = Temp
        End Function

        Friend Property EB_Obj As Segments.EB_Obj
            Get
                Return CType(Children(0), Segments.EB_Obj)
            End Get
            Set(value As Segments.EB_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property EB_Std As Segments.EB Implements Loops.Loop2110.EB
            Get
                Return CType(Children(0), Segments.EB_Obj)
            End Get
            Set(value As Segments.EB)
                Children(0) = value
            End Set
        End Property

        Private Property EB_IFace_Loop2110C_Obj As Transaction271_B1.Segments.Loop2110C.EB Implements Transaction271_B1.Loops.Loop2110C.EB
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2110C.EB)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110C.EB)
                Children(0) = value
            End Set
        End Property
        Private Property EB_IFace_1_Loop2110D_Obj As Transaction271_B1.Segments.Loop2110D.EB Implements Transaction271_B1.Loops.Loop2110D.EB
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2110D.EB)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110D.EB)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property HSD_Obj As SegmentContainer(Of Segments.HSD) Implements Loops.Loop2110.HSD
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.HSD))
            End Get
        End Property

        Private HSDSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.HSD, Segments.HSD)
        Private ReadOnly Property HSD_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.HSD, Segments.HSD) Implements Transaction271_B1.Loops.Loop2110C.HSD
            Get
                If HSDSubset_Loop2110C_Obj Is Nothing Then
                    HSDSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.HSD, Segments.HSD)(Children(1), 9, 4, 6589)
                End If

                Return HSDSubset_Loop2110C_Obj
            End Get
        End Property
        Private HSDSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.HSD, Segments.HSD)
        Private ReadOnly Property HSD_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.HSD, Segments.HSD) Implements Transaction271_B1.Loops.Loop2110D.HSD
            Get
                If HSDSubset_1_Loop2110D_Obj Is Nothing Then
                    HSDSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.HSD, Segments.HSD)(Children(1), 9, 5, 6589)
                End If

                Return HSDSubset_1_Loop2110D_Obj
            End Get
        End Property
        Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Loops.Loop2110.REF
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.REF))
            End Get
        End Property

        Private REFSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.REF, Segments.REF)
        Private ReadOnly Property REF_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.REF, Segments.REF) Implements Transaction271_B1.Loops.Loop2110C.REF
            Get
                If REFSubset_Loop2110C_Obj Is Nothing Then
                    REFSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.REF, Segments.REF)(Children(2), 9, 4, 145)
                End If

                Return REFSubset_Loop2110C_Obj
            End Get
        End Property
        Private REFSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.REF, Segments.REF)
        Private ReadOnly Property REF_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.REF, Segments.REF) Implements Transaction271_B1.Loops.Loop2110D.REF
            Get
                If REFSubset_1_Loop2110D_Obj Is Nothing Then
                    REFSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.REF, Segments.REF)(Children(2), 9, 5, 145)
                End If

                Return REFSubset_1_Loop2110D_Obj
            End Get
        End Property
        Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2110.DTP
            Get
                Return CType(Children(3), SegmentContainer(Of Segments.DTP))
            End Get
        End Property

        Private DTPSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.DTP, Segments.DTP)
        Private ReadOnly Property DTP_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.DTP, Segments.DTP) Implements Transaction271_B1.Loops.Loop2110C.DTP
            Get
                If DTPSubset_Loop2110C_Obj Is Nothing Then
                    DTPSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.DTP, Segments.DTP)(Children(3), 20, 4, 181)
                End If

                Return DTPSubset_Loop2110C_Obj
            End Get
        End Property
        Private DTPSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.DTP, Segments.DTP)
        Private ReadOnly Property DTP_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.DTP, Segments.DTP) Implements Transaction271_B1.Loops.Loop2110D.DTP
            Get
                If DTPSubset_1_Loop2110D_Obj Is Nothing Then
                    DTPSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.DTP, Segments.DTP)(Children(3), 20, 5, 181)
                End If

                Return DTPSubset_1_Loop2110D_Obj
            End Get
        End Property
        Friend ReadOnly Property AAA_Obj As SegmentContainer(Of Segments.AAA) Implements Loops.Loop2110.AAA
            Get
                Return CType(Children(4), SegmentContainer(Of Segments.AAA))
            End Get
        End Property

        Private AAASubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2110C.AAA
            Get
                If AAASubset_Loop2110C_Obj Is Nothing Then
                    AAASubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.AAA, Segments.AAA)(Children(4), 9, 4, 217)
                End If

                Return AAASubset_Loop2110C_Obj
            End Get
        End Property
        Private AAASubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.AAA, Segments.AAA)
        Private ReadOnly Property AAA_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.AAA, Segments.AAA) Implements Transaction271_B1.Loops.Loop2110D.AAA
            Get
                If AAASubset_1_Loop2110D_Obj Is Nothing Then
                    AAASubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.AAA, Segments.AAA)(Children(4), 9, 5, 217)
                End If

                Return AAASubset_1_Loop2110D_Obj
            End Get
        End Property
        Friend Property VEH_Obj As Segments.VEH_Obj
            Get
                Return CType(Children(5), Segments.VEH_Obj)
            End Get
            Set(value As Segments.VEH_Obj)
                Children(5) = value
            End Set
        End Property

        Private Property VEH_Std As Segments.VEH Implements Loops.Loop2110.VEH
            Get
                Return CType(Children(5), Segments.VEH_Obj)
            End Get
            Set(value As Segments.VEH)
                Children(5) = value
            End Set
        End Property

        Friend Property PID_Obj As Segments.PID_Obj
            Get
                Return CType(Children(6), Segments.PID_Obj)
            End Get
            Set(value As Segments.PID_Obj)
                Children(6) = value
            End Set
        End Property

        Private Property PID_Std As Segments.PID Implements Loops.Loop2110.PID
            Get
                Return CType(Children(6), Segments.PID_Obj)
            End Get
            Set(value As Segments.PID)
                Children(6) = value
            End Set
        End Property

        Friend Property PDR_Obj As Segments.PDR_Obj
            Get
                Return CType(Children(7), Segments.PDR_Obj)
            End Get
            Set(value As Segments.PDR_Obj)
                Children(7) = value
            End Set
        End Property

        Private Property PDR_Std As Segments.PDR Implements Loops.Loop2110.PDR
            Get
                Return CType(Children(7), Segments.PDR_Obj)
            End Get
            Set(value As Segments.PDR)
                Children(7) = value
            End Set
        End Property

        Friend Property PDP_Obj As Segments.PDP_Obj
            Get
                Return CType(Children(8), Segments.PDP_Obj)
            End Get
            Set(value As Segments.PDP_Obj)
                Children(8) = value
            End Set
        End Property

        Private Property PDP_Std As Segments.PDP Implements Loops.Loop2110.PDP
            Get
                Return CType(Children(8), Segments.PDP_Obj)
            End Get
            Set(value As Segments.PDP)
                Children(8) = value
            End Set
        End Property

        Friend Property LIN_Obj As Segments.LIN_Obj
            Get
                Return CType(Children(9), Segments.LIN_Obj)
            End Get
            Set(value As Segments.LIN_Obj)
                Children(9) = value
            End Set
        End Property

        Private Property LIN_Std As Segments.LIN Implements Loops.Loop2110.LIN
            Get
                Return CType(Children(9), Segments.LIN_Obj)
            End Get
            Set(value As Segments.LIN)
                Children(9) = value
            End Set
        End Property

        Friend Property EM_Obj As Segments.EM_Obj
            Get
                Return CType(Children(10), Segments.EM_Obj)
            End Get
            Set(value As Segments.EM_Obj)
                Children(10) = value
            End Set
        End Property

        Private Property EM_Std As Segments.EM Implements Loops.Loop2110.EM
            Get
                Return CType(Children(10), Segments.EM_Obj)
            End Get
            Set(value As Segments.EM)
                Children(10) = value
            End Set
        End Property

        Friend Property SD1_Obj As Segments.SD1_Obj
            Get
                Return CType(Children(11), Segments.SD1_Obj)
            End Get
            Set(value As Segments.SD1_Obj)
                Children(11) = value
            End Set
        End Property

        Private Property SD1_Std As Segments.SD1 Implements Loops.Loop2110.SD1
            Get
                Return CType(Children(11), Segments.SD1_Obj)
            End Get
            Set(value As Segments.SD1)
                Children(11) = value
            End Set
        End Property

        Friend Property PKD_Obj As Segments.PKD_Obj
            Get
                Return CType(Children(12), Segments.PKD_Obj)
            End Get
            Set(value As Segments.PKD_Obj)
                Children(12) = value
            End Set
        End Property

        Private Property PKD_Std As Segments.PKD Implements Loops.Loop2110.PKD
            Get
                Return CType(Children(12), Segments.PKD_Obj)
            End Get
            Set(value As Segments.PKD)
                Children(12) = value
            End Set
        End Property

        Friend ReadOnly Property MSG_Obj As SegmentContainer(Of Segments.MSG) Implements Loops.Loop2110.MSG
            Get
                Return CType(Children(13), SegmentContainer(Of Segments.MSG))
            End Get
        End Property

        Private MSGSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.MSG, Segments.MSG)
        Private ReadOnly Property MSG_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.MSG, Segments.MSG) Implements Transaction271_B1.Loops.Loop2110C.MSG
            Get
                If MSGSubset_Loop2110C_Obj Is Nothing Then
                    MSGSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110C.MSG, Segments.MSG)(Children(13), 10, 4, 253)
                End If

                Return MSGSubset_Loop2110C_Obj
            End Get
        End Property
        Private MSGSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.MSG, Segments.MSG)
        Private ReadOnly Property MSG_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.MSG, Segments.MSG) Implements Transaction271_B1.Loops.Loop2110D.MSG
            Get
                If MSGSubset_1_Loop2110D_Obj Is Nothing Then
                    MSGSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2110D.MSG, Segments.MSG)(Children(13), 10, 5, 253)
                End If

                Return MSGSubset_1_Loop2110D_Obj
            End Get
        End Property
        Friend ReadOnly Property Loop2115_Obj As LoopContainer(Of Loops.Loop2115) Implements Loops.Loop2110.Loop2115
            Get
                Return CType(Children(14), LoopContainer(Of Loops.Loop2115))
            End Get
        End Property

        Private Loop2115CSubset_Loop2110C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115C, Loops.Loop2115)
        Private ReadOnly Property Loop2115C_Obj_Loop2110C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115C, Loops.Loop2115) Implements Transaction271_B1.Loops.Loop2110C.Loop2115C
            Get
                If Loop2115CSubset_Loop2110C_Obj Is Nothing Then
                    Loop2115CSubset_Loop2110C_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115C, Loops.Loop2115)(Children(14), 10, 4, 1549)
                End If

                Return Loop2115CSubset_Loop2110C_Obj
            End Get
        End Property
        Private Loop2115DSubset_Loop2110D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115D, Loops.Loop2115)
        Private ReadOnly Property Loop2115D_Obj_Loop2110D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115D, Loops.Loop2115) Implements Transaction271_B1.Loops.Loop2110D.Loop2115D
            Get
                If Loop2115DSubset_Loop2110D_Obj Is Nothing Then
                    Loop2115DSubset_Loop2110D_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2115D, Loops.Loop2115)(Children(14), 10, 5, 1549)
                End If

                Return Loop2115DSubset_Loop2110D_Obj
            End Get
        End Property
        Friend Property LS_Obj As Segments.LS_Obj
            Get
                Return CType(Children(15), Segments.LS_Obj)
            End Get
            Set(value As Segments.LS_Obj)
                Children(15) = value
            End Set
        End Property

        Private Property LS_Std As Segments.LS Implements Loops.Loop2110.LS
            Get
                Return CType(Children(15), Segments.LS_Obj)
            End Get
            Set(value As Segments.LS)
                Children(15) = value
            End Set
        End Property

        Private Property LS_IFace_Loop2110C_Obj As Transaction271_B1.Segments.Loop2110C.LS Implements Transaction271_B1.Loops.Loop2110C.LS
            Get
                Return CType(Children(15), Transaction271_B1.Segments.Loop2110C.LS)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110C.LS)
                Children(15) = value
            End Set
        End Property
        Private Property LS_IFace_1_Loop2110D_Obj As Transaction271_B1.Segments.Loop2110D.LS Implements Transaction271_B1.Loops.Loop2110D.LS
            Get
                Return CType(Children(15), Transaction271_B1.Segments.Loop2110D.LS)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110D.LS)
                Children(15) = value
            End Set
        End Property
        Friend ReadOnly Property Loop2120_Obj As LoopContainer(Of Loops.Loop2120) Implements Loops.Loop2110.Loop2120
            Get
                Return CType(Children(16), LoopContainer(Of Loops.Loop2120))
            End Get
        End Property

        Private Loop2120CSubset_Loop2110C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120C, Loops.Loop2120)
        Private ReadOnly Property Loop2120C_Obj_Loop2110C_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120C, Loops.Loop2120) Implements Transaction271_B1.Loops.Loop2110C.Loop2120C
            Get
                If Loop2120CSubset_Loop2110C_Obj Is Nothing Then
                    Loop2120CSubset_Loop2110C_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120C, Loops.Loop2120)(Children(16), 23, 4, 289)
                End If

                Return Loop2120CSubset_Loop2110C_Obj
            End Get
        End Property
        Private Loop2120DSubset_Loop2110D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120D, Loops.Loop2120)
        Private ReadOnly Property Loop2120D_Obj_Loop2110D_Obj As LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120D, Loops.Loop2120) Implements Transaction271_B1.Loops.Loop2110D.Loop2120D
            Get
                If Loop2120DSubset_Loop2110D_Obj Is Nothing Then
                    Loop2120DSubset_Loop2110D_Obj = New LoopSubsetContainer(Of Transaction271_B1.Loops.Loop2120D, Loops.Loop2120)(Children(16), 23, 5, 289)
                End If

                Return Loop2120DSubset_Loop2110D_Obj
            End Get
        End Property
        Friend Property LE_Obj As Segments.LE_Obj
            Get
                Return CType(Children(17), Segments.LE_Obj)
            End Get
            Set(value As Segments.LE_Obj)
                Children(17) = value
            End Set
        End Property

        Private Property LE_Std As Segments.LE Implements Loops.Loop2110.LE
            Get
                Return CType(Children(17), Segments.LE_Obj)
            End Get
            Set(value As Segments.LE)
                Children(17) = value
            End Set
        End Property

        Private Property LE_IFace_Loop2110C_Obj As Transaction271_B1.Segments.Loop2110C.LE Implements Transaction271_B1.Loops.Loop2110C.LE
            Get
                Return CType(Children(17), Transaction271_B1.Segments.Loop2110C.LE)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110C.LE)
                Children(17) = value
            End Set
        End Property
        Private Property LE_IFace_1_Loop2110D_Obj As Transaction271_B1.Segments.Loop2110D.LE Implements Transaction271_B1.Loops.Loop2110D.LE
            Get
                Return CType(Children(17), Transaction271_B1.Segments.Loop2110D.LE)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2110D.LE)
                Children(17) = value
            End Set
        End Property

    End Class
    Partial Friend Class Loop2115_Obj
        Inherits LoopBase
        Implements Loops.Loop2115,
                                Transaction271_B1.Loops.Loop2115C,
                                Transaction271_B1.Loops.Loop2115D
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.III_Obj),
                                            New SegmentContainer(Of Segments.DTP)(5, 2, 2700),
                                            New SegmentContainer(Of Segments.AMT)(5, 2, 2800),
                                            New SegmentContainer(Of Segments.PCT)(5, 2, 2900),
                                            New LoopContainer(Of Loops.Loop2117)(0, 2, 3000)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "III", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "AMT", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "AMT", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(4, "AMT", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(1, "PCT", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(2, "PCT", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(4, "PCT", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(6, "PCT", ReadAction.PopulateSegment, 6, False),
                            New ReaderState(1, "LQ", ReadAction.PopulateLoop, 8, False),
                            New ReaderState(2, "LQ", ReadAction.PopulateLoop, 8, False),
                            New ReaderState(4, "LQ", ReadAction.PopulateLoop, 8, False),
                            New ReaderState(6, "LQ", ReadAction.PopulateLoop, 8, False),
                            New ReaderState(8, "LQ", ReadAction.PopulateLoop, 8, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "III", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.III_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                III_Obj = Seg
            ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DTP_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AMT_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "PCT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PCT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PCT_Obj.Add(Seg)
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "LQ", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2117_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2117_Obj.Add(NewLoop)
                Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
            End If
            args.Implementation = Temp
        End Function
        Friend Property III_Obj As Segments.III_Obj
            Get
                Return CType(Children(0), Segments.III_Obj)
            End Get
            Set(value As Segments.III_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property III_Std As Segments.III Implements Loops.Loop2115.III
            Get
                Return CType(Children(0), Segments.III_Obj)
            End Get
            Set(value As Segments.III)
                Children(0) = value
            End Set
        End Property

        Private Property III_IFace_Loop2115C_Obj As Transaction271_B1.Segments.Loop2115C.III Implements Transaction271_B1.Loops.Loop2115C.III
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2115C.III)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2115C.III)
                Children(0) = value
            End Set
        End Property
        Private Property III_IFace_1_Loop2115D_Obj As Transaction271_B1.Segments.Loop2115D.III Implements Transaction271_B1.Loops.Loop2115D.III
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2115D.III)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2115D.III)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2115.DTP
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.DTP))
            End Get
        End Property

        Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Segments.AMT) Implements Loops.Loop2115.AMT
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.AMT))
            End Get
        End Property

        Friend ReadOnly Property PCT_Obj As SegmentContainer(Of Segments.PCT) Implements Loops.Loop2115.PCT
            Get
                Return CType(Children(3), SegmentContainer(Of Segments.PCT))
            End Get
        End Property

        Friend ReadOnly Property Loop2117_Obj As LoopContainer(Of Loops.Loop2117) Implements Loops.Loop2115.Loop2117
            Get
                Return CType(Children(4), LoopContainer(Of Loops.Loop2117))
            End Get
        End Property


    End Class
    Partial Friend Class Loop2117_Obj
        Inherits LoopBase
        Implements Loops.Loop2117
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.LQ_Obj),
                                            New SegmentContainer(Of Segments.AMT)(5, 2, 3100),
                                            New SegmentContainer(Of Segments.PCT)(5, 2, 3200)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "LQ", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(1, "AMT", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(2, "AMT", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "PCT", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "PCT", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(4, "PCT", ReadAction.PopulateSegment, 4, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "LQ", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.LQ_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                LQ_Obj = Seg
            ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AMT_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "PCT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PCT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PCT_Obj.Add(Seg)
            End If
        End Sub

        Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Return Task.CompletedTask()
        End Function

        Friend Property LQ_Obj As Segments.LQ_Obj
            Get
                Return CType(Children(0), Segments.LQ_Obj)
            End Get
            Set(value As Segments.LQ_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property LQ_Std As Segments.LQ Implements Loops.Loop2117.LQ
            Get
                Return CType(Children(0), Segments.LQ_Obj)
            End Get
            Set(value As Segments.LQ)
                Children(0) = value
            End Set
        End Property

        Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Segments.AMT) Implements Loops.Loop2117.AMT
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.AMT))
            End Get
        End Property

        Friend ReadOnly Property PCT_Obj As SegmentContainer(Of Segments.PCT) Implements Loops.Loop2117.PCT
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.PCT))
            End Get
        End Property


    End Class
    Partial Friend Class Loop2120_Obj
        Inherits LoopBase
        Implements Loops.Loop2120,
                                Transaction271_B1.Loops.Loop2120C,
                                Transaction271_B1.Loops.Loop2120D
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.NM1_Obj),
                                            CType(Nothing, Segments.N2_Obj),
                                            CType(Nothing, Segments.N3_Obj),
                                            CType(Nothing, Segments.N4_Obj),
                                            New SegmentContainer(Of Segments.PER)(3, 2, 3800),
                                            CType(Nothing, Segments.PRV_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
                            New ReaderState(0, "N2", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(0, "N3", ReadAction.PopulateSegment, 3, False),
                            New ReaderState(0, "N4", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(0, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(0, "PRV", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(1, "N2", ReadAction.PopulateSegment, 2, False),
                            New ReaderState(1, "N3", ReadAction.PopulateSegment, 3, False),
                            New ReaderState(2, "N3", ReadAction.PopulateSegment, 3, False),
                            New ReaderState(1, "N4", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(2, "N4", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(3, "N4", ReadAction.PopulateSegment, 4, False),
                            New ReaderState(1, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(2, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(3, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(4, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(5, "PER", ReadAction.PopulateSegment, 5, False),
                            New ReaderState(1, "PRV", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(2, "PRV", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(3, "PRV", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(4, "PRV", ReadAction.PopulateSegment, 7, False),
                            New ReaderState(5, "PRV", ReadAction.PopulateSegment, 7, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                NM1_Obj = Seg
                Dim S2 = CType(Seg, Segments.NM1_Obj)
                If CompareKey(S2.NM101, ";13;1I;1P;2B;36;73;FA;GP;GW;I3;IL;LR;OC;P3;P4;P5;PR;PRP;SEP;TTP;VER;VN;VY;X3;Y2;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C__2120C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 289
                ElseIf CompareKey(S2.NM101, ";13;1I;1P;2B;36;73;FA;GP;GW;I3;IL;LR;OC;P3;P4;P5;PR;PRP;SEP;TTP;VER;VN;VY;X3;Y2;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D__2120D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 289
                End If
            ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N2_Obj = Seg
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj = Seg
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PRV_Obj = Seg
                Dim S2 = CType(Seg, Segments.PRV_Obj)
                If CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SB;SK;SU;") AndAlso String.Compare(args.Implementation, "_271B1__2000C__2100C__2110C__2120C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 3962
                ElseIf CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SB;SK;SU;") AndAlso String.Compare(args.Implementation, "_271B1__2000D__2100D__2110D__2120D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 3962
                End If
            End If
        End Sub

        Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Return Task.CompletedTask()
        End Function
        Friend Property NM1_Obj As Segments.NM1_Obj
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property NM1_Std As Segments.NM1 Implements Loops.Loop2120.NM1
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1)
                Children(0) = value
            End Set
        End Property

        Private Property NM1_IFace_Loop2120C_Obj As Transaction271_B1.Segments.Loop2120C.NM1 Implements Transaction271_B1.Loops.Loop2120C.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2120C.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120C.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_1_Loop2120D_Obj As Transaction271_B1.Segments.Loop2120D.NM1 Implements Transaction271_B1.Loops.Loop2120D.NM1
            Get
                Return CType(Children(0), Transaction271_B1.Segments.Loop2120D.NM1)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120D.NM1)
                Children(0) = value
            End Set
        End Property
        Friend Property N2_Obj As Segments.N2_Obj
            Get
                Return CType(Children(1), Segments.N2_Obj)
            End Get
            Set(value As Segments.N2_Obj)
                Children(1) = value
            End Set
        End Property

        Private Property N2_Std As Segments.N2 Implements Loops.Loop2120.N2
            Get
                Return CType(Children(1), Segments.N2_Obj)
            End Get
            Set(value As Segments.N2)
                Children(1) = value
            End Set
        End Property

        Friend Property N3_Obj As Segments.N3_Obj
            Get
                Return CType(Children(2), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property N3_Std As Segments.N3 Implements Loops.Loop2120.N3
            Get
                Return CType(Children(2), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3)
                Children(2) = value
            End Set
        End Property

        Private Property N3_IFace_Loop2120C_Obj As Transaction271_B1.Segments.Loop2120C.N3 Implements Transaction271_B1.Loops.Loop2120C.N3
            Get
                Return CType(Children(2), Transaction271_B1.Segments.Loop2120C.N3)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120C.N3)
                Children(2) = value
            End Set
        End Property
        Private Property N3_IFace_1_Loop2120D_Obj As Transaction271_B1.Segments.Loop2120D.N3 Implements Transaction271_B1.Loops.Loop2120D.N3
            Get
                Return CType(Children(2), Transaction271_B1.Segments.Loop2120D.N3)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120D.N3)
                Children(2) = value
            End Set
        End Property
        Friend Property N4_Obj As Segments.N4_Obj
            Get
                Return CType(Children(3), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property N4_Std As Segments.N4 Implements Loops.Loop2120.N4
            Get
                Return CType(Children(3), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(3) = value
            End Set
        End Property

        Private Property N4_IFace_Loop2120C_Obj As Transaction271_B1.Segments.Loop2120C.N4 Implements Transaction271_B1.Loops.Loop2120C.N4
            Get
                Return CType(Children(3), Transaction271_B1.Segments.Loop2120C.N4)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120C.N4)
                Children(3) = value
            End Set
        End Property
        Private Property N4_IFace_1_Loop2120D_Obj As Transaction271_B1.Segments.Loop2120D.N4 Implements Transaction271_B1.Loops.Loop2120D.N4
            Get
                Return CType(Children(3), Transaction271_B1.Segments.Loop2120D.N4)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120D.N4)
                Children(3) = value
            End Set
        End Property
        Friend ReadOnly Property PER_Obj As SegmentContainer(Of Segments.PER) Implements Loops.Loop2120.PER
            Get
                Return CType(Children(4), SegmentContainer(Of Segments.PER))
            End Get
        End Property

        Private PERSubset_Loop2120C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120C.PER, Segments.PER)
        Private ReadOnly Property PER_Loop2120C_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120C.PER, Segments.PER) Implements Transaction271_B1.Loops.Loop2120C.PER
            Get
                If PERSubset_Loop2120C_Obj Is Nothing Then
                    PERSubset_Loop2120C_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120C.PER, Segments.PER)(Children(4), 3, 4, 74)
                End If

                Return PERSubset_Loop2120C_Obj
            End Get
        End Property
        Private PERSubset_1_Loop2120D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120D.PER, Segments.PER)
        Private ReadOnly Property PER_Loop2120D_Obj As SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120D.PER, Segments.PER) Implements Transaction271_B1.Loops.Loop2120D.PER
            Get
                If PERSubset_1_Loop2120D_Obj Is Nothing Then
                    PERSubset_1_Loop2120D_Obj = New SegmentSubsetContainer(Of Transaction271_B1.Segments.Loop2120D.PER, Segments.PER)(Children(4), 3, 5, 74)
                End If

                Return PERSubset_1_Loop2120D_Obj
            End Get
        End Property
        Friend Property PRV_Obj As Segments.PRV_Obj
            Get
                Return CType(Children(5), Segments.PRV_Obj)
            End Get
            Set(value As Segments.PRV_Obj)
                Children(5) = value
            End Set
        End Property

        Private Property PRV_Std As Segments.PRV Implements Loops.Loop2120.PRV
            Get
                Return CType(Children(5), Segments.PRV_Obj)
            End Get
            Set(value As Segments.PRV)
                Children(5) = value
            End Set
        End Property

        Private Property PRV_IFace_Loop2120C_Obj As Transaction271_B1.Segments.Loop2120C.PRV Implements Transaction271_B1.Loops.Loop2120C.PRV
            Get
                Return CType(Children(5), Transaction271_B1.Segments.Loop2120C.PRV)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120C.PRV)
                Children(5) = value
            End Set
        End Property
        Private Property PRV_IFace_1_Loop2120D_Obj As Transaction271_B1.Segments.Loop2120D.PRV Implements Transaction271_B1.Loops.Loop2120D.PRV
            Get
                Return CType(Children(5), Transaction271_B1.Segments.Loop2120D.PRV)
            End Get
            Set(value As Transaction271_B1.Segments.Loop2120D.PRV)
                Children(5) = value
            End Set
        End Property

    End Class
    '''<summary>Health Care Eligibility Benefit Response</summary>
    '''<remarks></remarks>
    Public Interface Standard
        '''<summary>Transaction Set Header</summary>
        Property ST As Segments.ST
        '''<summary>Beginning of Hierarchical Transaction</summary>
        Property BHT As Segments.BHT
        '''<summary>Hierarchical Level</summary>
        ReadOnly Property Loop2000 As LoopContainer(Of Loops.Loop2000)
        '''<summary>Transaction Set Trailer</summary>
        Property SE As Segments.SE
    End Interface
    Namespace Loops

        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2000
            Inherits ILoop
            '''<summary>Hierarchical Level</summary>
            Property HL As Segments.HL
            '''<summary>Trace</summary>
            ReadOnly Property TRN As SegmentContainer(Of Segments.TRN)
            '''<summary>Request Validation</summary>
            ReadOnly Property AAA As SegmentContainer(Of Segments.AAA)
            '''<summary>Individual or Organizational Name</summary>
            ReadOnly Property Loop2100 As LoopContainer(Of Loop2100)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2100
            Inherits ILoop
            '''<summary>Individual or Organizational Name</summary>
            Property NM1 As Segments.NM1
            '''<summary>Reference Information</summary>
            ReadOnly Property REF As SegmentContainer(Of Segments.REF)
            '''<summary>Additional Name Information</summary>
            Property N2 As Segments.N2
            '''<summary>Party Location</summary>
            Property N3 As Segments.N3
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
            '''<summary>Administrative Communications Contact</summary>
            ReadOnly Property PER As SegmentContainer(Of Segments.PER)
            '''<summary>Request Validation</summary>
            ReadOnly Property AAA As SegmentContainer(Of Segments.AAA)
            '''<summary>Provider Information</summary>
            Property PRV As Segments.PRV
            '''<summary>Demographic Information</summary>
            Property DMG As Segments.DMG
            '''<summary>Insured Benefit</summary>
            Property INS As Segments.INS
            '''<summary>Health Care Information Codes</summary>
            Property HI As Segments.HI
            '''<summary>Date or Time or Period</summary>
            ReadOnly Property DTP As SegmentContainer(Of Segments.DTP)
            '''<summary>Language Use</summary>
            ReadOnly Property LUI As SegmentContainer(Of Segments.LUI)
            '''<summary>Military Personnel Information</summary>
            ReadOnly Property MPI As SegmentContainer(Of Segments.MPI)
            '''<summary>Eligibility or Benefit Information</summary>
            ReadOnly Property Loop2110 As LoopContainer(Of Loop2110)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2110
            Inherits ILoop
            '''<summary>Eligibility or Benefit Information</summary>
            Property EB As Segments.EB
            '''<summary>Health Care Services Delivery</summary>
            ReadOnly Property HSD As SegmentContainer(Of Segments.HSD)
            '''<summary>Reference Information</summary>
            ReadOnly Property REF As SegmentContainer(Of Segments.REF)
            '''<summary>Date or Time or Period</summary>
            ReadOnly Property DTP As SegmentContainer(Of Segments.DTP)
            '''<summary>Request Validation</summary>
            ReadOnly Property AAA As SegmentContainer(Of Segments.AAA)
            '''<summary>Vehicle Information</summary>
            Property VEH As Segments.VEH
            '''<summary>Product/Item Description</summary>
            Property PID As Segments.PID
            '''<summary>Property Description - Real</summary>
            Property PDR As Segments.PDR
            '''<summary>Property Description - Personal</summary>
            Property PDP As Segments.PDP
            '''<summary>Item Identification</summary>
            Property LIN As Segments.LIN
            '''<summary>Equipment Characteristics</summary>
            Property EM As Segments.EM
            '''<summary>Safety Data</summary>
            Property SD1 As Segments.SD1
            '''<summary>Packaging Description</summary>
            Property PKD As Segments.PKD
            '''<summary>Message Text</summary>
            ReadOnly Property MSG As SegmentContainer(Of Segments.MSG)
            '''<summary>Information</summary>
            ReadOnly Property Loop2115 As LoopContainer(Of Loop2115)
            '''<summary>Loop Header</summary>
            Property LS As Segments.LS
            '''<summary>Individual or Organizational Name</summary>
            ReadOnly Property Loop2120 As LoopContainer(Of Loop2120)
            '''<summary>Loop Trailer</summary>
            Property LE As Segments.LE
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2115
            Inherits ILoop
            '''<summary>Information</summary>
            Property III As Segments.III
            '''<summary>Date or Time or Period</summary>
            ReadOnly Property DTP As SegmentContainer(Of Segments.DTP)
            '''<summary>Monetary Amount Information</summary>
            ReadOnly Property AMT As SegmentContainer(Of Segments.AMT)
            '''<summary>Percent Amounts</summary>
            ReadOnly Property PCT As SegmentContainer(Of Segments.PCT)
            '''<summary>Industry Code Identification</summary>
            ReadOnly Property Loop2117 As LoopContainer(Of Loop2117)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2117
            Inherits ILoop
            '''<summary>Industry Code Identification</summary>
            Property LQ As Segments.LQ
            '''<summary>Monetary Amount Information</summary>
            ReadOnly Property AMT As SegmentContainer(Of Segments.AMT)
            '''<summary>Percent Amounts</summary>
            ReadOnly Property PCT As SegmentContainer(Of Segments.PCT)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2120
            Inherits ILoop
            '''<summary>Individual or Organizational Name</summary>
            Property NM1 As Segments.NM1
            '''<summary>Additional Name Information</summary>
            Property N2 As Segments.N2
            '''<summary>Party Location</summary>
            Property N3 As Segments.N3
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
            '''<summary>Administrative Communications Contact</summary>
            ReadOnly Property PER As SegmentContainer(Of Segments.PER)
            '''<summary>Provider Information</summary>
            Property PRV As Segments.PRV
        End Interface

    End Namespace 'Loops


    Namespace Transaction271_B1
        Namespace Segments

            Namespace Loop2000A

                '''<summary>Information Source Level</summary>
                Public Interface HL
                    Inherits ISegment

                    '''<summary>Hierarchical ID Number</summary>
                    Property HL01 As String
                    '''<summary>Hierarchical Level Code</summary>
                    Property HL03 As String
                    '''<summary>Hierarchical Child Code</summary>
                    Property HL04 As String
                End Interface
                '''<summary>Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
            End Namespace 'Loop2000A

            Namespace Loop2100A

                '''<summary>Information Source Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Information Source Last or Organization Name</summary>
                    Property NM103 As String
                    '''<summary>Information Source First Name</summary>
                    Property NM104 As String
                    '''<summary>Information Source Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Information Source Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Information Source Primary Identifier</summary>
                    Property NM109 As String
                End Interface
                '''<summary>Information Source Contact Information</summary>
                Public Interface PER
                    Inherits ISegment

                    '''<summary>Contact Function Code</summary>
                    Property PER01 As String
                    '''<summary>Information Source Contact Name</summary>
                    Property PER02 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER03 As String
                    '''<summary>Information Source Communication Number</summary>
                    Property PER04 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER05 As String
                    '''<summary>Information Source Communication Number</summary>
                    Property PER06 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER07 As String
                    '''<summary>Information Source Communication Number</summary>
                    Property PER08 As String
                End Interface
                '''<summary>Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
            End Namespace 'Loop2100A

            Namespace Loop2000B

                '''<summary>Information Receiver Level</summary>
                Public Interface HL
                    Inherits ISegment

                    '''<summary>Hierarchical ID Number</summary>
                    Property HL01 As String
                    '''<summary>Hierarchical Parent ID Number</summary>
                    Property HL02 As String
                    '''<summary>Hierarchical Level Code</summary>
                    Property HL03 As String
                    '''<summary>Hierarchical Child Code</summary>
                    Property HL04 As String
                End Interface
            End Namespace 'Loop2000B

            Namespace Loop2100B

                '''<summary>Information Receiver Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Information Receiver Last or Organization Name</summary>
                    Property NM103 As String
                    '''<summary>Information Receiver First Name</summary>
                    Property NM104 As String
                    '''<summary>Information Receiver Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Information Receiver Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Information Receiver Identification Number</summary>
                    Property NM109 As String
                End Interface
                '''<summary>Information Receiver Additional Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Information Receiver Additional Identifier</summary>
                    Property REF02 As String
                    '''<summary>Information Receiver Additional Identifier State</summary>
                    Property REF03 As String
                End Interface
                '''<summary>Information Receiver Address</summary>
                Public Interface N3
                    Inherits ISegment

                    '''<summary>Information Receiver Address Line</summary>
                    Property N301 As String
                    '''<summary>Information Receiver Additional Address Line</summary>
                    Property N302 As String
                End Interface
                '''<summary>Information Receiver City, State, ZIP Code</summary>
                Public Interface N4
                    Inherits ISegment

                    '''<summary>Information Receiver City Name</summary>
                    Property N401 As String
                    '''<summary>Information Receiver State Code</summary>
                    Property N402 As String
                    '''<summary>Information Receiver Postal Zone or ZIP Code</summary>
                    Property N403 As String
                    '''<summary>Country Code</summary>
                    Property N404 As String
                    '''<summary>Country Subdivision Code</summary>
                    Property N407 As String
                End Interface
                '''<summary>Information Receiver Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
                '''<summary>Information Receiver Provider Information</summary>
                Public Interface PRV
                    Inherits ISegment

                    '''<summary>Provider Code</summary>
                    Property PRV01 As String
                    '''<summary>Reference Identification Qualifier</summary>
                    Property PRV02 As String
                    '''<summary>Information Receiver Provider Taxonomy Code</summary>
                    Property PRV03 As String
                End Interface
            End Namespace 'Loop2100B

            Namespace Loop2000C

                '''<summary>Subscriber Level</summary>
                Public Interface HL
                    Inherits ISegment

                    '''<summary>Hierarchical ID Number</summary>
                    Property HL01 As String
                    '''<summary>Hierarchical Parent ID Number</summary>
                    Property HL02 As String
                    '''<summary>Hierarchical Level Code</summary>
                    Property HL03 As String
                    '''<summary>Hierarchical Child Code</summary>
                    Property HL04 As String
                End Interface
                '''<summary>Subscriber Trace Number</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Trace Number</summary>
                    Property TRN02 As String
                    '''<summary>Trace Assigning Entity Identifier</summary>
                    Property TRN03 As String
                    '''<summary>Trace Assigning Entity Additional Identifier</summary>
                    Property TRN04 As String
                End Interface
            End Namespace 'Loop2000C

            Namespace Loop2100C

                '''<summary>Subscriber Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Subscriber Last Name</summary>
                    Property NM103 As String
                    '''<summary>Subscriber First Name</summary>
                    Property NM104 As String
                    '''<summary>Subscriber Middle Name or Initial</summary>
                    Property NM105 As String
                    '''<summary>Subscriber Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Subscriber Primary Identifier</summary>
                    Property NM109 As String
                End Interface
                '''<summary>Subscriber Additional Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Subscriber Supplemental Identifier</summary>
                    Property REF02 As String
                    '''<summary>Plan, Group or Plan Network Name</summary>
                    Property REF03 As String
                End Interface
                '''<summary>Subscriber Address</summary>
                Public Interface N3
                    Inherits ISegment

                    '''<summary>Subscriber Address Line</summary>
                    Property N301 As String
                    '''<summary>Subscriber Address Line</summary>
                    Property N302 As String
                End Interface
                '''<summary>Subscriber City, State, ZIP Code</summary>
                Public Interface N4
                    Inherits ISegment

                    '''<summary>Subscriber City Name</summary>
                    Property N401 As String
                    '''<summary>Subscriber State Code</summary>
                    Property N402 As String
                    '''<summary>Subscriber Postal Zone or ZIP Code</summary>
                    Property N403 As String
                    '''<summary>Subscriber Country Code</summary>
                    Property N404 As String
                    '''<summary>Subscriber Country Subdivision Code</summary>
                    Property N407 As String
                End Interface
                '''<summary>Subscriber Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
                '''<summary>Provider Information</summary>
                Public Interface PRV
                    Inherits ISegment

                    '''<summary>Provider Code</summary>
                    Property PRV01 As String
                    '''<summary>Reference Identification Qualifier</summary>
                    Property PRV02 As String
                    '''<summary>Provider Identifier</summary>
                    Property PRV03 As String
                End Interface
                '''<summary>Subscriber Demographic Information</summary>
                Public Interface DMG
                    Inherits ISegment

                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DMG01 As String
                    '''<summary>Subscriber Birth Date</summary>
                    Property DMG02 As String
                    '''<summary>Subscriber Gender Code</summary>
                    Property DMG03 As String
                End Interface
                '''<summary>Subscriber Relationship</summary>
                Public Interface INS
                    Inherits ISegment

                    '''<summary>Insured Indicator</summary>
                    Property INS01 As String
                    '''<summary>Individual Relationship Code</summary>
                    Property INS02 As String
                    '''<summary>Maintenance Type Code</summary>
                    Property INS03 As String
                    '''<summary>Maintenance Reason Code</summary>
                    Property INS04 As String
                    '''<summary>Birth Sequence Number</summary>
                    Property INS17 As Decimal?
                End Interface
                '''<summary>Subscriber Health Care Diagnosis Code</summary>
                Public Interface HI
                    Inherits ISegment

                    '''<summary></summary>
                    Property HI01 As Composites.Loop2100C.HI.HI_01.C022
                    '''<summary></summary>
                    Property HI02 As Composites.Loop2100C.HI.HI_02.C022
                    '''<summary></summary>
                    Property HI03 As Composites.Loop2100C.HI.HI_03.C022
                    '''<summary></summary>
                    Property HI04 As Composites.Loop2100C.HI.HI_04.C022
                    '''<summary></summary>
                    Property HI05 As Composites.Loop2100C.HI.HI_05.C022
                    '''<summary></summary>
                    Property HI06 As Composites.Loop2100C.HI.HI_06.C022
                    '''<summary></summary>
                    Property HI07 As Composites.Loop2100C.HI.HI_07.C022
                    '''<summary></summary>
                    Property HI08 As Composites.Loop2100C.HI.HI_08.C022
                End Interface
                '''<summary>Subscriber Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Date Time Period</summary>
                    Property DTP03 As String
                End Interface
                '''<summary>Subscriber Military Personnel Information</summary>
                Public Interface MPI
                    Inherits ISegment

                    '''<summary>Information Status Code</summary>
                    Property MPI01 As String
                    '''<summary>Employment Status Code</summary>
                    Property MPI02 As String
                    '''<summary>Government Service Affiliation Code</summary>
                    Property MPI03 As String
                    '''<summary>Description</summary>
                    Property MPI04 As String
                    '''<summary>Military Service Rank Code</summary>
                    Property MPI05 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property MPI06 As String
                    '''<summary>Date Time Period</summary>
                    Property MPI07 As String
                End Interface
            End Namespace 'Loop2100C

            Namespace Loop2110C

                '''<summary>Subscriber Eligibility or Benefit Information</summary>
                Public Interface EB
                    Inherits ISegment

                    '''<summary>Eligibility or Benefit Information</summary>
                    Property EB01 As String
                    '''<summary>Benefit Coverage Level Code</summary>
                    Property EB02 As String
                    '''<summary>Service Type Code</summary>
                    Property EB03 As String
                    '''<summary>Insurance Type Code</summary>
                    Property EB04 As String
                    '''<summary>Plan Coverage Description</summary>
                    Property EB05 As String
                    '''<summary>Time Period Qualifier</summary>
                    Property EB06 As String
                    '''<summary>Benefit Amount</summary>
                    Property EB07 As Decimal?
                    '''<summary>Benefit Percent</summary>
                    Property EB08 As Decimal?
                    '''<summary>Quantity Qualifier</summary>
                    Property EB09 As String
                    '''<summary>Benefit Quantity</summary>
                    Property EB10 As Decimal?
                    '''<summary>Authorization or Certification Indicator</summary>
                    Property EB11 As String
                    '''<summary>In Plan Network Indicator</summary>
                    Property EB12 As String
                    '''<summary></summary>
                    Property EB13 As Composites.Loop2110C.EB.EB_13.C003
                    '''<summary></summary>
                    Property EB14 As DataElements.Composite.C004
                End Interface
                '''<summary>Health Care Services Delivery</summary>
                Public Interface HSD
                    Inherits ISegment

                    '''<summary>Quantity Qualifier</summary>
                    Property HSD01 As String
                    '''<summary>Benefit Quantity</summary>
                    Property HSD02 As Decimal?
                    '''<summary>Unit or Basis for Measurement Code</summary>
                    Property HSD03 As String
                    '''<summary>Sample Selection Modulus</summary>
                    Property HSD04 As Decimal?
                    '''<summary>Time Period Qualifier</summary>
                    Property HSD05 As String
                    '''<summary>Period Count</summary>
                    Property HSD06 As Decimal?
                    '''<summary>Delivery Frequency Code</summary>
                    Property HSD07 As String
                    '''<summary>Delivery Pattern Time Code</summary>
                    Property HSD08 As String
                End Interface
                '''<summary>Subscriber Additional Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Subscriber Eligibility or Benefit Identifier</summary>
                    Property REF02 As String
                    '''<summary>Plan, Group or Plan Network Name</summary>
                    Property REF03 As String
                End Interface
                '''<summary>Subscriber Eligibility/Benefit Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Eligibility or Benefit Date Time Period</summary>
                    Property DTP03 As String
                End Interface
                '''<summary>Subscriber Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
                '''<summary>Message Text</summary>
                Public Interface MSG
                    Inherits ISegment

                    '''<summary>Free Form Message Text</summary>
                    Property MSG01 As String
                End Interface
                '''<summary>Loop Header</summary>
                Public Interface LS
                    Inherits ISegment

                    '''<summary>Loop Identifier Code</summary>
                    Property LS01 As String
                End Interface
                '''<summary>Loop Trailer</summary>
                Public Interface LE
                    Inherits ISegment

                    '''<summary>Loop Identifier Code</summary>
                    Property LE01 As String
                End Interface
            End Namespace 'Loop2110C

            Namespace Loop2115C

                '''<summary>Subscriber Eligibility or Benefit Additional Information</summary>
                Public Interface III
                    Inherits ISegment

                    '''<summary>Code List Qualifier Code</summary>
                    Property III01 As String
                    '''<summary>Industry Code</summary>
                    Property III02 As String
                    '''<summary>Code Category</summary>
                    Property III03 As String
                    '''<summary>Injured Body Part Name</summary>
                    Property III04 As String
                End Interface
            End Namespace 'Loop2115C

            Namespace Loop2120C

                '''<summary>Subscriber Benefit Related Entity Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Benefit Related Entity Last or Organization Name</summary>
                    Property NM103 As String
                    '''<summary>Benefit Related Entity First Name</summary>
                    Property NM104 As String
                    '''<summary>Benefit Related Entity Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Benefit Related Entity Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Benefit Related Entity Identifier</summary>
                    Property NM109 As String
                    '''<summary>Benefit Related Entity Relationship Code</summary>
                    Property NM110 As String
                End Interface
                '''<summary>Subscriber Benefit Related Entity Address</summary>
                Public Interface N3
                    Inherits ISegment

                    '''<summary>Benefit Related Entity Address Line</summary>
                    Property N301 As String
                    '''<summary>Benefit Related Entity Address Line</summary>
                    Property N302 As String
                End Interface
                '''<summary>Subscriber Benefit Related Entity City, State, ZIP Code</summary>
                Public Interface N4
                    Inherits ISegment

                    '''<summary>Benefit Related Entity City Name</summary>
                    Property N401 As String
                    '''<summary>Benefit Related Entity State Code</summary>
                    Property N402 As String
                    '''<summary>Benefit Related Entity Postal Zone or ZIP Code</summary>
                    Property N403 As String
                    '''<summary>Benefit Related Entity Country Code</summary>
                    Property N404 As String
                    '''<summary>Benefit Related Entity Location Qualifier</summary>
                    Property N405 As String
                    '''<summary>Benefit Related Entity DOD Health Service Region</summary>
                    Property N406 As String
                    '''<summary>Benefit Related Entity Country Subdivision Code</summary>
                    Property N407 As String
                End Interface
                '''<summary>Subscriber Benefit Related Entity Contact Information</summary>
                Public Interface PER
                    Inherits ISegment

                    '''<summary>Contact Function Code</summary>
                    Property PER01 As String
                    '''<summary>Benefit Related Entity Contact Name</summary>
                    Property PER02 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER03 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER04 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER05 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER06 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER07 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER08 As String
                End Interface
                '''<summary>Subscriber Benefit Related Provider Information</summary>
                Public Interface PRV
                    Inherits ISegment

                    '''<summary>Provider Code</summary>
                    Property PRV01 As String
                    '''<summary>Reference Identification Qualifier</summary>
                    Property PRV02 As String
                    '''<summary>Benefit Related Entity Provider Taxonomy Code</summary>
                    Property PRV03 As String
                End Interface
            End Namespace 'Loop2120C

            Namespace Loop2000D

                '''<summary>Dependent Level</summary>
                Public Interface HL
                    Inherits ISegment

                    '''<summary>Hierarchical ID Number</summary>
                    Property HL01 As String
                    '''<summary>Hierarchical Parent ID Number</summary>
                    Property HL02 As String
                    '''<summary>Hierarchical Level Code</summary>
                    Property HL03 As String
                    '''<summary>Hierarchical Child Code</summary>
                    Property HL04 As String
                End Interface
                '''<summary>Dependent Trace Number</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Trace Number</summary>
                    Property TRN02 As String
                    '''<summary>Trace Assigning Entity Identifier</summary>
                    Property TRN03 As String
                    '''<summary>Trace Assigning Entity Additional Identifier</summary>
                    Property TRN04 As String
                End Interface
            End Namespace 'Loop2000D

            Namespace Loop2100D

                '''<summary>Dependent Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Dependent Last Name</summary>
                    Property NM103 As String
                    '''<summary>Dependent First Name</summary>
                    Property NM104 As String
                    '''<summary>Dependent Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Dependent Name Suffix</summary>
                    Property NM107 As String
                End Interface
                '''<summary>Dependent Additional Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Dependent Supplemental Identifier</summary>
                    Property REF02 As String
                    '''<summary>Plan, Group or Plan Network Name</summary>
                    Property REF03 As String
                End Interface
                '''<summary>Dependent Address</summary>
                Public Interface N3
                    Inherits ISegment

                    '''<summary>Dependent Address Line</summary>
                    Property N301 As String
                    '''<summary>Dependent Address Line</summary>
                    Property N302 As String
                End Interface
                '''<summary>Dependent City, State, ZIP Code</summary>
                Public Interface N4
                    Inherits ISegment

                    '''<summary>Dependent City Name</summary>
                    Property N401 As String
                    '''<summary>Dependent State Code</summary>
                    Property N402 As String
                    '''<summary>Dependent Postal Zone or ZIP Code</summary>
                    Property N403 As String
                    '''<summary>Dependent Country Code</summary>
                    Property N404 As String
                    '''<summary>Dependent Country Subdivision Code</summary>
                    Property N407 As String
                End Interface
                '''<summary>Dependent Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
                '''<summary>Provider Information</summary>
                Public Interface PRV
                    Inherits ISegment

                    '''<summary>Provider Code</summary>
                    Property PRV01 As String
                    '''<summary>Reference Identification Qualifier</summary>
                    Property PRV02 As String
                    '''<summary>Provider Identifier</summary>
                    Property PRV03 As String
                End Interface
                '''<summary>Dependent Demographic Information</summary>
                Public Interface DMG
                    Inherits ISegment

                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DMG01 As String
                    '''<summary>Dependent Birth Date</summary>
                    Property DMG02 As String
                    '''<summary>Dependent Gender Code</summary>
                    Property DMG03 As String
                End Interface
                '''<summary>Dependent Relationship</summary>
                Public Interface INS
                    Inherits ISegment

                    '''<summary>Insured Indicator</summary>
                    Property INS01 As String
                    '''<summary>Individual Relationship Code</summary>
                    Property INS02 As String
                    '''<summary>Maintenance Type Code</summary>
                    Property INS03 As String
                    '''<summary>Maintenance Reason Code</summary>
                    Property INS04 As String
                    '''<summary>Birth Sequence Number</summary>
                    Property INS17 As Decimal?
                End Interface
                '''<summary>Dependent Health Care Diagnosis Code</summary>
                Public Interface HI
                    Inherits ISegment

                    '''<summary></summary>
                    Property HI01 As Composites.Loop2100D.HI.HI_01.C022
                    '''<summary></summary>
                    Property HI02 As Composites.Loop2100D.HI.HI_02.C022
                    '''<summary></summary>
                    Property HI03 As Composites.Loop2100D.HI.HI_03.C022
                    '''<summary></summary>
                    Property HI04 As Composites.Loop2100D.HI.HI_04.C022
                    '''<summary></summary>
                    Property HI05 As Composites.Loop2100D.HI.HI_05.C022
                    '''<summary></summary>
                    Property HI06 As Composites.Loop2100D.HI.HI_06.C022
                    '''<summary></summary>
                    Property HI07 As Composites.Loop2100D.HI.HI_07.C022
                    '''<summary></summary>
                    Property HI08 As Composites.Loop2100D.HI.HI_08.C022
                End Interface
                '''<summary>Dependent Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Date Time Period</summary>
                    Property DTP03 As String
                End Interface
                '''<summary>Dependent Military Personnel Information</summary>
                Public Interface MPI
                    Inherits ISegment

                    '''<summary>Information Status Code</summary>
                    Property MPI01 As String
                    '''<summary>Employment Status Code</summary>
                    Property MPI02 As String
                    '''<summary>Government Service Affiliation Code</summary>
                    Property MPI03 As String
                    '''<summary>Description</summary>
                    Property MPI04 As String
                    '''<summary>Military Service Rank Code</summary>
                    Property MPI05 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property MPI06 As String
                    '''<summary>Date Time Period</summary>
                    Property MPI07 As String
                End Interface
            End Namespace 'Loop2100D

            Namespace Loop2110D

                '''<summary>Dependent Eligibility or Benefit Information</summary>
                Public Interface EB
                    Inherits ISegment

                    '''<summary>Eligibility or Benefit Information</summary>
                    Property EB01 As String
                    '''<summary>Benefit Coverage Level Code</summary>
                    Property EB02 As String
                    '''<summary>Service Type Code</summary>
                    Property EB03 As String
                    '''<summary>Insurance Type Code</summary>
                    Property EB04 As String
                    '''<summary>Plan Coverage Description</summary>
                    Property EB05 As String
                    '''<summary>Time Period Qualifier</summary>
                    Property EB06 As String
                    '''<summary>Benefit Amount</summary>
                    Property EB07 As Decimal?
                    '''<summary>Benefit Percent</summary>
                    Property EB08 As Decimal?
                    '''<summary>Quantity Qualifier</summary>
                    Property EB09 As String
                    '''<summary>Benefit Quantity</summary>
                    Property EB10 As Decimal?
                    '''<summary>Authorization or Certification Indicator</summary>
                    Property EB11 As String
                    '''<summary>In Plan Network Indicator</summary>
                    Property EB12 As String
                    '''<summary></summary>
                    Property EB13 As Composites.Loop2110D.EB.EB_13.C003
                    '''<summary></summary>
                    Property EB14 As DataElements.Composite.C004
                End Interface
                '''<summary>Health Care Services Delivery</summary>
                Public Interface HSD
                    Inherits ISegment

                    '''<summary>Quantity Qualifier</summary>
                    Property HSD01 As String
                    '''<summary>Benefit Quantity</summary>
                    Property HSD02 As Decimal?
                    '''<summary>Unit or Basis for Measurement Code</summary>
                    Property HSD03 As String
                    '''<summary>Sample Selection Modulus</summary>
                    Property HSD04 As Decimal?
                    '''<summary>Time Period Qualifier</summary>
                    Property HSD05 As String
                    '''<summary>Period Count</summary>
                    Property HSD06 As Decimal?
                    '''<summary>Delivery Frequency Code</summary>
                    Property HSD07 As String
                    '''<summary>Delivery Pattern Time Code</summary>
                    Property HSD08 As String
                End Interface
                '''<summary>Dependent Additional Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Dependent Eligibility or Benefit Identifier</summary>
                    Property REF02 As String
                    '''<summary>Plan, Group or Plan Network Name</summary>
                    Property REF03 As String
                End Interface
                '''<summary>Dependent Eligibility/Benefit Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Eligibility or Benefit Date Time Period</summary>
                    Property DTP03 As String
                End Interface
                '''<summary>Dependent Request Validation</summary>
                Public Interface AAA
                    Inherits ISegment

                    '''<summary>Valid Request Indicator</summary>
                    Property AAA01 As String
                    '''<summary>Reject Reason Code</summary>
                    Property AAA03 As String
                    '''<summary>Follow-up Action Code</summary>
                    Property AAA04 As String
                End Interface
                '''<summary>Message Text</summary>
                Public Interface MSG
                    Inherits ISegment

                    '''<summary>Free Form Message Text</summary>
                    Property MSG01 As String
                End Interface
                '''<summary>Loop Header</summary>
                Public Interface LS
                    Inherits ISegment

                    '''<summary>Loop Identifier Code</summary>
                    Property LS01 As String
                End Interface
                '''<summary>Loop Trailer</summary>
                Public Interface LE
                    Inherits ISegment

                    '''<summary>Loop Identifier Code</summary>
                    Property LE01 As String
                End Interface
            End Namespace 'Loop2110D

            Namespace Loop2115D

                '''<summary>Dependent Eligibility or Benefit Additional Information</summary>
                Public Interface III
                    Inherits ISegment

                    '''<summary>Code List Qualifier Code</summary>
                    Property III01 As String
                    '''<summary>Industry Code</summary>
                    Property III02 As String
                    '''<summary>Code Category</summary>
                    Property III03 As String
                    '''<summary>Injured Body Part Name</summary>
                    Property III04 As String
                End Interface
            End Namespace 'Loop2115D

            Namespace Loop2120D

                '''<summary>Dependent Benefit Related Entity Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Benefit Related Entity Last or Organization Name</summary>
                    Property NM103 As String
                    '''<summary>Benefit Related Entity First Name</summary>
                    Property NM104 As String
                    '''<summary>Benefit Related Entity Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Benefit Related Entity Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Benefit Related Entity Identifier</summary>
                    Property NM109 As String
                    '''<summary>Benefit Related Entity Relationship Code</summary>
                    Property NM110 As String
                End Interface
                '''<summary>Dependent Benefit Related Entity Address</summary>
                Public Interface N3
                    Inherits ISegment

                    '''<summary>Benefit Related Entity Address Line</summary>
                    Property N301 As String
                    '''<summary>Benefit Related Entity Address Line</summary>
                    Property N302 As String
                End Interface
                '''<summary>Dependent Benefit Related Entity City, State, ZIP Code</summary>
                Public Interface N4
                    Inherits ISegment

                    '''<summary>Benefit Related Entity City Name</summary>
                    Property N401 As String
                    '''<summary>Benefit Related Entity State Code</summary>
                    Property N402 As String
                    '''<summary>Benefit Related Entity Postal Zone or ZIP Code</summary>
                    Property N403 As String
                    '''<summary>Benefit Related Entity Country Code</summary>
                    Property N404 As String
                    '''<summary>Benefit Related Entity Location Qualifier</summary>
                    Property N405 As String
                    '''<summary>Benefit Related Entity DOD Health Service Region</summary>
                    Property N406 As String
                    '''<summary>Benefit Related Entity Country Subdivision Code</summary>
                    Property N407 As String
                End Interface
                '''<summary>Dependent Benefit Related Entity Contact Information</summary>
                Public Interface PER
                    Inherits ISegment

                    '''<summary>Contact Function Code</summary>
                    Property PER01 As String
                    '''<summary>Benefit Related Entity Contact Name</summary>
                    Property PER02 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER03 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER04 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER05 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER06 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER07 As String
                    '''<summary>Benefit Related Entity Communication Number</summary>
                    Property PER08 As String
                End Interface
                '''<summary>Dependent Benefit Related Provider Information</summary>
                Public Interface PRV
                    Inherits ISegment

                    '''<summary>Provider Code</summary>
                    Property PRV01 As String
                    '''<summary>Reference Identification Qualifier</summary>
                    Property PRV02 As String
                    '''<summary>Benefit Related Entity Provider Taxonomy Code</summary>
                    Property PRV03 As String
                End Interface
            End Namespace 'Loop2120D

            '''<summary>Transaction Set Header</summary>
            Public Interface ST
                Inherits ISegment

                '''<summary>Transaction Set Identifier Code</summary>
                Property ST01 As String
                '''<summary>Transaction Set Control Number</summary>
                Property ST02 As String
                '''<summary>Implementation Convention Reference</summary>
                Property ST03 As String
            End Interface
            '''<summary>Beginning of Hierarchical Transaction</summary>
            Public Interface BHT
                Inherits ISegment

                '''<summary>Hierarchical Structure Code</summary>
                Property BHT01 As String
                '''<summary>Transaction Set Purpose Code</summary>
                Property BHT02 As String
                '''<summary>Submitter Transaction Identifier</summary>
                Property BHT03 As String
                '''<summary>Transaction Set Creation Date</summary>
                Property BHT04 As Date?
                '''<summary>Transaction Set Creation Time</summary>
                Property BHT05 As TimeSpan?
            End Interface
            '''<summary>Transaction Set Trailer</summary>
            Public Interface SE
                Inherits ISegment

                '''<summary>Transaction Segment Count</summary>
                Property SE01 As Decimal?
                '''<summary>Transaction Set Control Number</summary>
                Property SE02 As String
            End Interface
        End Namespace 'Segments

        Namespace Composites
            Namespace Loop2100C.HI.HI_01
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_02
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_03
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_04
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_05
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_06
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_07
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100C.HI.HI_08
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2110C.EB.EB_13
                '''<summary></summary>
                Public Interface C003
                    '''<summary>Product or Service ID Qualifier</summary>
                    Property C003_01 As String
                    '''<summary>Procedure Code</summary>
                    Property C003_02 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_03 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_04 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_05 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_06 As String
                    '''<summary>Product or Service ID</summary>
                    Property C003_08 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_01
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_02
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_03
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_04
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_05
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_06
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_07
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2100D.HI.HI_08
                '''<summary></summary>
                Public Interface C022
                    '''<summary>Diagnosis Type Code</summary>
                    Property C022_01 As String
                    '''<summary>Diagnosis Code</summary>
                    Property C022_02 As String
                End Interface
            End Namespace
            Namespace Loop2110D.EB.EB_13
                '''<summary></summary>
                Public Interface C003
                    '''<summary>Product or Service ID Qualifier</summary>
                    Property C003_01 As String
                    '''<summary>Procedure Code</summary>
                    Property C003_02 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_03 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_04 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_05 As String
                    '''<summary>Procedure Modifier</summary>
                    Property C003_06 As String
                    '''<summary>Product or Service ID</summary>
                    Property C003_08 As String
                End Interface
            End Namespace
        End Namespace 'Composites

        Namespace Loops
            '''<summary>Information Source Level</summary>
            Public Interface Loop2000A
                Inherits ILoop


                '''<summary>Information Source Level</summary>
                Property HL As Segments.Loop2000A.HL

                '''<summary>Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2000A.AAA, Dom.Segments.AAA)

                '''<summary>Information Source Name</summary>
                Property Loop2100A As Loop2100A
            End Interface
            '''<summary>Information Source Name</summary>
            Public Interface Loop2100A
                Inherits ILoop


                '''<summary>Information Source Name</summary>
                Property NM1 As Segments.Loop2100A.NM1

                '''<summary>Information Source Contact Information</summary>
                ReadOnly Property PER As SegmentSubsetContainer(Of Segments.Loop2100A.PER, Dom.Segments.PER)

                '''<summary>Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2100A.AAA, Dom.Segments.AAA)
            End Interface
            '''<summary>Information Receiver Level</summary>
            Public Interface Loop2000B
                Inherits ILoop


                '''<summary>Information Receiver Level</summary>
                Property HL As Segments.Loop2000B.HL

                '''<summary>Information Receiver Name</summary>
                Property Loop2100B As Loop2100B
            End Interface
            '''<summary>Information Receiver Name</summary>
            Public Interface Loop2100B
                Inherits ILoop


                '''<summary>Information Receiver Name</summary>
                Property NM1 As Segments.Loop2100B.NM1

                '''<summary>Information Receiver Additional Identification</summary>
                ReadOnly Property REF As SegmentSubsetContainer(Of Segments.Loop2100B.REF, Dom.Segments.REF)

                '''<summary>Information Receiver Address</summary>
                Property N3 As Segments.Loop2100B.N3

                '''<summary>Information Receiver City, State, ZIP Code</summary>
                Property N4 As Segments.Loop2100B.N4

                '''<summary>Information Receiver Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2100B.AAA, Dom.Segments.AAA)

                '''<summary>Information Receiver Provider Information</summary>
                Property PRV As Segments.Loop2100B.PRV
            End Interface
            '''<summary>Subscriber Level</summary>
            Public Interface Loop2000C
                Inherits ILoop


                '''<summary>Subscriber Level</summary>
                Property HL As Segments.Loop2000C.HL

                '''<summary>Subscriber Trace Number</summary>
                ReadOnly Property TRN As SegmentSubsetContainer(Of Segments.Loop2000C.TRN, Dom.Segments.TRN)

                '''<summary>Subscriber Name</summary>
                Property Loop2100C As Loop2100C
            End Interface
            '''<summary>Subscriber Name</summary>
            Public Interface Loop2100C
                Inherits ILoop


                '''<summary>Subscriber Name</summary>
                Property NM1 As Segments.Loop2100C.NM1

                '''<summary>Subscriber Additional Identification</summary>
                ReadOnly Property REF As SegmentSubsetContainer(Of Segments.Loop2100C.REF, Dom.Segments.REF)

                '''<summary>Subscriber Address</summary>
                Property N3 As Segments.Loop2100C.N3

                '''<summary>Subscriber City, State, ZIP Code</summary>
                Property N4 As Segments.Loop2100C.N4

                '''<summary>Subscriber Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2100C.AAA, Dom.Segments.AAA)

                '''<summary>Provider Information</summary>
                Property PRV As Segments.Loop2100C.PRV

                '''<summary>Subscriber Demographic Information</summary>
                Property DMG As Segments.Loop2100C.DMG

                '''<summary>Subscriber Relationship</summary>
                Property INS As Segments.Loop2100C.INS

                '''<summary>Subscriber Health Care Diagnosis Code</summary>
                Property HI As Segments.Loop2100C.HI

                '''<summary>Subscriber Date</summary>
                ReadOnly Property DTP As SegmentSubsetContainer(Of Segments.Loop2100C.DTP, Dom.Segments.DTP)

                '''<summary>Subscriber Military Personnel Information</summary>
                Property MPI As Segments.Loop2100C.MPI

                '''<summary>Subscriber Eligibility or Benefit Information</summary>
                ReadOnly Property Loop2110C As LoopSubsetContainer(Of Loop2110C, Transaction271.Loops.Loop2110)
            End Interface
            '''<summary>Subscriber Eligibility or Benefit Information</summary>
            Public Interface Loop2110C
                Inherits ILoop


                '''<summary>Subscriber Eligibility or Benefit Information</summary>
                Property EB As Segments.Loop2110C.EB

                '''<summary>Health Care Services Delivery</summary>
                ReadOnly Property HSD As SegmentSubsetContainer(Of Segments.Loop2110C.HSD, Dom.Segments.HSD)

                '''<summary>Subscriber Additional Identification</summary>
                ReadOnly Property REF As SegmentSubsetContainer(Of Segments.Loop2110C.REF, Dom.Segments.REF)

                '''<summary>Subscriber Eligibility/Benefit Date</summary>
                ReadOnly Property DTP As SegmentSubsetContainer(Of Segments.Loop2110C.DTP, Dom.Segments.DTP)

                '''<summary>Subscriber Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2110C.AAA, Dom.Segments.AAA)

                '''<summary>Message Text</summary>
                ReadOnly Property MSG As SegmentSubsetContainer(Of Segments.Loop2110C.MSG, Dom.Segments.MSG)

                '''<summary>Subscriber Eligibility or Benefit Additional Information</summary>
                ReadOnly Property Loop2115C As LoopSubsetContainer(Of Loop2115C, Transaction271.Loops.Loop2115)

                '''<summary>Loop Header</summary>
                Property LS As Segments.Loop2110C.LS

                '''<summary>Subscriber Benefit Related Entity Name</summary>
                ReadOnly Property Loop2120C As LoopSubsetContainer(Of Loop2120C, Transaction271.Loops.Loop2120)

                '''<summary>Loop Trailer</summary>
                Property LE As Segments.Loop2110C.LE
            End Interface
            '''<summary>Subscriber Eligibility or Benefit Additional Information</summary>
            Public Interface Loop2115C
                Inherits ILoop


                '''<summary>Subscriber Eligibility or Benefit Additional Information</summary>
                Property III As Segments.Loop2115C.III
            End Interface
            '''<summary>Subscriber Benefit Related Entity Name</summary>
            Public Interface Loop2120C
                Inherits ILoop


                '''<summary>Subscriber Benefit Related Entity Name</summary>
                Property NM1 As Segments.Loop2120C.NM1

                '''<summary>Subscriber Benefit Related Entity Address</summary>
                Property N3 As Segments.Loop2120C.N3

                '''<summary>Subscriber Benefit Related Entity City, State, ZIP Code</summary>
                Property N4 As Segments.Loop2120C.N4

                '''<summary>Subscriber Benefit Related Entity Contact Information</summary>
                ReadOnly Property PER As SegmentSubsetContainer(Of Segments.Loop2120C.PER, Dom.Segments.PER)

                '''<summary>Subscriber Benefit Related Provider Information</summary>
                Property PRV As Segments.Loop2120C.PRV
            End Interface
            '''<summary>Dependent Level</summary>
            Public Interface Loop2000D
                Inherits ILoop


                '''<summary>Dependent Level</summary>
                Property HL As Segments.Loop2000D.HL

                '''<summary>Dependent Trace Number</summary>
                ReadOnly Property TRN As SegmentSubsetContainer(Of Segments.Loop2000D.TRN, Dom.Segments.TRN)

                '''<summary>Dependent Name</summary>
                Property Loop2100D As Loop2100D
            End Interface
            '''<summary>Dependent Name</summary>
            Public Interface Loop2100D
                Inherits ILoop


                '''<summary>Dependent Name</summary>
                Property NM1 As Segments.Loop2100D.NM1

                '''<summary>Dependent Additional Identification</summary>
                ReadOnly Property REF As SegmentSubsetContainer(Of Segments.Loop2100D.REF, Dom.Segments.REF)

                '''<summary>Dependent Address</summary>
                Property N3 As Segments.Loop2100D.N3

                '''<summary>Dependent City, State, ZIP Code</summary>
                Property N4 As Segments.Loop2100D.N4

                '''<summary>Dependent Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2100D.AAA, Dom.Segments.AAA)

                '''<summary>Provider Information</summary>
                Property PRV As Segments.Loop2100D.PRV

                '''<summary>Dependent Demographic Information</summary>
                Property DMG As Segments.Loop2100D.DMG

                '''<summary>Dependent Relationship</summary>
                Property INS As Segments.Loop2100D.INS

                '''<summary>Dependent Health Care Diagnosis Code</summary>
                Property HI As Segments.Loop2100D.HI

                '''<summary>Dependent Date</summary>
                ReadOnly Property DTP As SegmentSubsetContainer(Of Segments.Loop2100D.DTP, Dom.Segments.DTP)

                '''<summary>Dependent Military Personnel Information</summary>
                Property MPI As Segments.Loop2100D.MPI

                '''<summary>Dependent Eligibility or Benefit Information</summary>
                ReadOnly Property Loop2110D As LoopSubsetContainer(Of Loop2110D, Transaction271.Loops.Loop2110)
            End Interface
            '''<summary>Dependent Eligibility or Benefit Information</summary>
            Public Interface Loop2110D
                Inherits ILoop


                '''<summary>Dependent Eligibility or Benefit Information</summary>
                Property EB As Segments.Loop2110D.EB

                '''<summary>Health Care Services Delivery</summary>
                ReadOnly Property HSD As SegmentSubsetContainer(Of Segments.Loop2110D.HSD, Dom.Segments.HSD)

                '''<summary>Dependent Additional Identification</summary>
                ReadOnly Property REF As SegmentSubsetContainer(Of Segments.Loop2110D.REF, Dom.Segments.REF)

                '''<summary>Dependent Eligibility/Benefit Date</summary>
                ReadOnly Property DTP As SegmentSubsetContainer(Of Segments.Loop2110D.DTP, Dom.Segments.DTP)

                '''<summary>Dependent Request Validation</summary>
                ReadOnly Property AAA As SegmentSubsetContainer(Of Segments.Loop2110D.AAA, Dom.Segments.AAA)

                '''<summary>Message Text</summary>
                ReadOnly Property MSG As SegmentSubsetContainer(Of Segments.Loop2110D.MSG, Dom.Segments.MSG)

                '''<summary>Dependent Eligibility or Benefit Additional Information</summary>
                ReadOnly Property Loop2115D As LoopSubsetContainer(Of Loop2115D, Transaction271.Loops.Loop2115)

                '''<summary>Loop Header</summary>
                Property LS As Segments.Loop2110D.LS

                '''<summary>Dependent Benefit Related Entity Name</summary>
                ReadOnly Property Loop2120D As LoopSubsetContainer(Of Loop2120D, Transaction271.Loops.Loop2120)

                '''<summary>Loop Trailer</summary>
                Property LE As Segments.Loop2110D.LE
            End Interface
            '''<summary>Dependent Eligibility or Benefit Additional Information</summary>
            Public Interface Loop2115D
                Inherits ILoop


                '''<summary>Dependent Eligibility or Benefit Additional Information</summary>
                Property III As Segments.Loop2115D.III
            End Interface
            '''<summary>Dependent Benefit Related Entity Name</summary>
            Public Interface Loop2120D
                Inherits ILoop


                '''<summary>Dependent Benefit Related Entity Name</summary>
                Property NM1 As Segments.Loop2120D.NM1

                '''<summary>Dependent Benefit Related Entity Address</summary>
                Property N3 As Segments.Loop2120D.N3

                '''<summary>Dependent Benefit Related Entity City, State, ZIP Code</summary>
                Property N4 As Segments.Loop2120D.N4

                '''<summary>Dependent Benefit Related Entity Contact Information</summary>
                ReadOnly Property PER As SegmentSubsetContainer(Of Segments.Loop2120D.PER, Dom.Segments.PER)

                '''<summary>Dependent Benefit Related Provider Information</summary>
                Property PRV As Segments.Loop2120D.PRV
            End Interface

        End Namespace 'Loops

        '''<summary>Health Care Eligibility Benefit Response</summary>
        '''<remarks>
        '''<para>This X12 Transaction Set contains the format and establishes the data contents of the Eligibility, Coverage or Benefit Information Transaction Set (271) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to communicate information about or changes to eligibility, coverage or benefits from information sources (such as - insurers, sponsors, payors) to information receivers (such as - physicians, hospitals, repair facilities, third party administrators, governmental agencies). This information includes but is not limited to: benefit status, explanation of benefits, coverages, dependent coverage level, effective dates, amounts for co-insurance, co-pays, deductibles, exclusions and limitations.</para>
        '''</remarks>
        Public Interface TransactionSet

            '''<summary>Transaction Set Header</summary>
            Property ST As Segments.ST

            '''<summary>Beginning of Hierarchical Transaction</summary>
            Property BHT As Segments.BHT

            '''<summary>Information Source Level</summary>
            ReadOnly Property Loop2000A As LoopSubsetContainer(Of Loops.Loop2000A, Transaction271.Loops.Loop2000)

            '''<summary>Information Receiver Level</summary>
            ReadOnly Property Loop2000B As LoopSubsetContainer(Of Loops.Loop2000B, Transaction271.Loops.Loop2000)

            '''<summary>Subscriber Level</summary>
            ReadOnly Property Loop2000C As LoopSubsetContainer(Of Loops.Loop2000C, Transaction271.Loops.Loop2000)

            '''<summary>Dependent Level</summary>
            ReadOnly Property Loop2000D As LoopSubsetContainer(Of Loops.Loop2000D, Transaction271.Loops.Loop2000)

            '''<summary>Transaction Set Trailer</summary>
            Property SE As Segments.SE
        End Interface
    End Namespace 'Transaction271_B1
End Namespace 'Transaction271
