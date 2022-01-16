Namespace Transactions
    Namespace Transaction270

        Partial Friend Class Standard_Obj
            Inherits TransactionSet
            Implements Standard, Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet
            Friend Sub New(versionCode As String)
                Me.New(String.Empty, versionCode)
            End Sub

            Friend Sub New(controlNumber As String, versionCode As String)
                MyBase.New("HS", versionCode)

                Children.AddRange({New Madjic.Edi.Dom.Segments.ST_Obj,
                                    CType(Nothing, Madjic.Edi.Dom.Segments.BHT_Obj),
                                    New LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)(0, "2", "0100"),
                                    New Madjic.Edi.Dom.Segments.SE_Obj})

                ST_Obj.ST01 = "270"
                ST_Obj.ST02 = controlNumber
                ST_Obj.ST03 = versionCode

                Initialize()
            End Sub

            Partial Private Sub Initialize()

            End Sub

            Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
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
                    Seg = Madjic.Edi.Dom.Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    ST_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.ST_Obj)
                    If MyBase.CompareKey(S2.ST01, ";270;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "1"
                        Seg.SetSequence = "0100"
                    End If
                ElseIf String.Compare(SegmentName, "BHT", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.BHT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    BHT_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "1"
                        Seg.SetSequence = "0200"
                    End If
                ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    SE_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "6"
                        Seg.SetSequence = "1600"
                    End If
                End If
            End Sub

            Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
                Dim LoopID As String = args.ParentLoopID
                Dim Implementation As String = args.Implementation
                Dim Temp = args.Implementation

                If String.Compare(args.DataSegment.SegmentID, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Dim NewLoop As LoopBase = New Madjic.Edi.Dom.Transactions.Transaction270.Loop2000_Obj
                    Dim LoopKey As String = args.DataSegment.ToStringValue(2)
                    Loop2000_Obj.Add(NewLoop)
                    If MyBase.CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000A"
                        NewLoop.SetArea = "2"
                        NewLoop.SetSequence = "0100"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000B"
                        NewLoop.SetArea = "3"
                        NewLoop.SetSequence = "0100"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000C"
                        NewLoop.SetArea = "4"
                        NewLoop.SetSequence = "0100"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000D"
                        NewLoop.SetArea = "5"
                        NewLoop.SetSequence = "0100"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    Else
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    End If
                End If
                args.Implementation = Temp
            End Function
            Friend Property ST_Obj As Madjic.Edi.Dom.Segments.ST_Obj
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.ST_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.ST_Obj)
                    Children(0) = value
                End Set
            End Property

            Private Property ST_Std As Madjic.Edi.Dom.Segments.ST Implements Madjic.Edi.Dom.Transactions.Transaction270.Standard.ST
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.ST_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.ST)
                    Children(0) = value
                End Set
            End Property

            Private Property ST_IFace_Transaction270_B1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.ST
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST)
                    Children(0) = value
                End Set
            End Property
            Friend Property BHT_Obj As Madjic.Edi.Dom.Segments.BHT_Obj
                Get
                    Return CType(Children(1), Madjic.Edi.Dom.Segments.BHT_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.BHT_Obj)
                    Children(1) = value
                End Set
            End Property

            Private Property BHT_Std As Madjic.Edi.Dom.Segments.BHT Implements Madjic.Edi.Dom.Transactions.Transaction270.Standard.BHT
                Get
                    Return CType(Children(1), Madjic.Edi.Dom.Segments.BHT_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.BHT)
                    Children(1) = value
                End Set
            End Property

            Private Property BHT_IFace_Transaction270_B1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.BHT
                Get
                    Return CType(Children(1), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT)
                    Children(1) = value
                End Set
            End Property
            Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000) Implements Madjic.Edi.Dom.Transactions.Transaction270.Standard.Loop2000
                Get
                    Return CType(Children(2), LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000))
                End Get
            End Property

            Private Loop2000ASubset_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)
            Private ReadOnly Property Loop2000A_Obj_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.Loop2000A
                Get
                    If Loop2000ASubset_Transaction270_B1 Is Nothing Then
                        Loop2000ASubset_Transaction270_B1 = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)(Children(2), 0, "2", "0100")
                    End If

                    Return Loop2000ASubset_Transaction270_B1
                End Get
            End Property
            Private Loop2000BSubset_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)
            Private ReadOnly Property Loop2000B_Obj_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.Loop2000B
                Get
                    If Loop2000BSubset_Transaction270_B1 Is Nothing Then
                        Loop2000BSubset_Transaction270_B1 = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)(Children(2), 0, "3", "0100")
                    End If

                    Return Loop2000BSubset_Transaction270_B1
                End Get
            End Property
            Private Loop2000CSubset_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)
            Private ReadOnly Property Loop2000C_Obj_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.Loop2000C
                Get
                    If Loop2000CSubset_Transaction270_B1 Is Nothing Then
                        Loop2000CSubset_Transaction270_B1 = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)(Children(2), 0, "4", "0100")
                    End If

                    Return Loop2000CSubset_Transaction270_B1
                End Get
            End Property
            Private Loop2000DSubset_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)
            Private ReadOnly Property Loop2000D_Obj_Transaction270_B1 As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.Loop2000D
                Get
                    If Loop2000DSubset_Transaction270_B1 Is Nothing Then
                        Loop2000DSubset_Transaction270_B1 = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)(Children(2), 0, "5", "0100")
                    End If

                    Return Loop2000DSubset_Transaction270_B1
                End Get
            End Property
            Friend Property SE_Obj As Madjic.Edi.Dom.Segments.SE_Obj
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.SE_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.SE_Obj)
                    Children(3) = value
                End Set
            End Property

            Private Property SE_Std As Madjic.Edi.Dom.Segments.SE Implements Madjic.Edi.Dom.Transactions.Transaction270.Standard.SE
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.SE_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.SE)
                    Children(3) = value
                End Set
            End Property

            Private Property SE_IFace_Transaction270_B1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet.SE
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE)
                    Children(3) = value
                End Set
            End Property
        End Class

        Partial Friend Class Loop2000_Obj
            Inherits LoopBase
            Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D
            Friend Sub New()
                MyBase.New

                Children.AddRange({CType(Nothing, Madjic.Edi.Dom.Segments.HL_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.TRN)(9, "2", "0200"),
                                    New LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(0, "2", "0300")})

                Initialize()
            End Sub

            Partial Private Sub Initialize()

            End Sub

            Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "HL", ReadAction.PopulateSegment, 1, False),
                    New ReaderState(1, "TRN", ReadAction.PopulateSegment, 2, False),
                    New ReaderState(2, "TRN", ReadAction.PopulateSegment, 2, False),
                    New ReaderState(1, "NM1", ReadAction.PopulateLoop, 4, False),
                    New ReaderState(2, "NM1", ReadAction.PopulateLoop, 4, False),
                    New ReaderState(4, "NM1", ReadAction.PopulateLoop, 4, False)})

            Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
                Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
            End Function

            Private Sub PopulateSegment(ByVal args As ReaderArgs)
                Dim SegmentName As String = args.DataSegment.SegmentID
                Dim Implementation As String = args.Implementation
                Dim Seg As Segment
                If String.Compare(SegmentName, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.HL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    HL_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.HL_Obj)
                    If MyBase.CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_270B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "2"
                        Seg.SetSequence = "0100"
                    ElseIf MyBase.CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_270B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0100"
                    ElseIf MyBase.CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_270B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0100"
                    ElseIf MyBase.CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_270B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0100"
                    End If
                ElseIf String.Compare(SegmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    TRN_Obj.Add(Seg)
                    If String.Compare(args.Implementation, "_270B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0200"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0200"
                    End If
                End If
            End Sub

            Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
                Dim LoopID As String = args.ParentLoopID
                Dim Implementation As String = args.Implementation
                Dim Temp = args.Implementation

                If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Dim NewLoop As LoopBase = New Madjic.Edi.Dom.Transactions.Transaction270.Loop2100_Obj
                    Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                    Loop2100_Obj.Add(NewLoop)
                    If MyBase.CompareKey(LoopKey, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000A__2100A"
                        NewLoop.SetArea = "2"
                        NewLoop.SetSequence = "0300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000B__2100B"
                        NewLoop.SetArea = "3"
                        NewLoop.SetSequence = "0300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_270B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000C__2100C"
                        NewLoop.SetArea = "4"
                        NewLoop.SetSequence = "0300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf MyBase.CompareKey(LoopKey, ";03;") AndAlso String.Compare(args.Implementation, "_270B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000D__2100D"
                        NewLoop.SetArea = "5"
                        NewLoop.SetSequence = "0300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    Else
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    End If
                End If
                args.Implementation = Temp
            End Function
            Friend Property HL_Obj As Madjic.Edi.Dom.Segments.HL_Obj
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.HL_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.HL_Obj)
                    Children(0) = value
                End Set
            End Property

            Private Property HL_Std As Madjic.Edi.Dom.Segments.HL Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000.HL
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.HL_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.HL)
                    Children(0) = value
                End Set
            End Property

            Private Property HL_IFace_Loop2000A_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A.HL
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL)
                    Children(0) = value
                End Set
            End Property
            Private Property HL_IFace_1_Loop2000B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B.HL
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL)
                    Children(0) = value
                End Set
            End Property
            Private Property HL_IFace_2_Loop2000C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C.HL
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL)
                    Children(0) = value
                End Set
            End Property
            Private Property HL_IFace_3_Loop2000D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D.HL
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL)
                    Children(0) = value
                End Set
            End Property
            Friend ReadOnly Property TRN_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.TRN) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000.TRN
                Get
                    Return CType(Children(1), SegmentContainer(Of Madjic.Edi.Dom.Segments.TRN))
                End Get
            End Property

            Private TRNSubset_Loop2000C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN, Madjic.Edi.Dom.Segments.TRN)
            Private ReadOnly Property TRN_Loop2000C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN, Madjic.Edi.Dom.Segments.TRN) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C.TRN
                Get
                    If TRNSubset_Loop2000C_Obj Is Nothing Then
                        TRNSubset_Loop2000C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN, Madjic.Edi.Dom.Segments.TRN)(Children(1), 2, "4", "0200")
                    End If

                    Return TRNSubset_Loop2000C_Obj
                End Get
            End Property
            Private TRNSubset_1_Loop2000D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN, Madjic.Edi.Dom.Segments.TRN)
            Private ReadOnly Property TRN_Loop2000D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN, Madjic.Edi.Dom.Segments.TRN) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D.TRN
                Get
                    If TRNSubset_1_Loop2000D_Obj Is Nothing Then
                        TRNSubset_1_Loop2000D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN, Madjic.Edi.Dom.Segments.TRN)(Children(1), 2, "5", "0200")
                    End If

                    Return TRNSubset_1_Loop2000D_Obj
                End Get
            End Property
            Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000.Loop2100
                Get
                    Return CType(Children(2), LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100))
                End Get
            End Property

            Private Loop2100ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)
            Private Property Loop2100A_IFace_Loop2000A_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A.Loop2100A
                Get
                    If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                        Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "2", "0300")
                    End If

                    If Loop2100ASubset_Loop2000A_Obj.Count > 0 Then
                        Return Loop2100ASubset_Loop2000A_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A)
                    If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                        Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "2", "0300")
                    End If

                    If Loop2100ASubset_Loop2000A_Obj.Count = 0 Then
                        Loop2100ASubset_Loop2000A_Obj.Add(value)
                    Else
                        Loop2100ASubset_Loop2000A_Obj(0) = value
                    End If
                End Set
            End Property
            Private Loop2100BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)
            Private Property Loop2100B_IFace_Loop2000B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B.Loop2100B
                Get
                    If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                        Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "3", "0300")
                    End If

                    If Loop2100BSubset_Loop2000B_Obj.Count > 0 Then
                        Return Loop2100BSubset_Loop2000B_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B)
                    If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                        Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "3", "0300")
                    End If

                    If Loop2100BSubset_Loop2000B_Obj.Count = 0 Then
                        Loop2100BSubset_Loop2000B_Obj.Add(value)
                    Else
                        Loop2100BSubset_Loop2000B_Obj(0) = value
                    End If
                End Set
            End Property
            Private Loop2100CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)
            Private Property Loop2100C_IFace_Loop2000C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C.Loop2100C
                Get
                    If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
                        Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "4", "0300")
                    End If

                    If Loop2100CSubset_Loop2000C_Obj.Count > 0 Then
                        Return Loop2100CSubset_Loop2000C_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C)
                    If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
                        Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "4", "0300")
                    End If

                    If Loop2100CSubset_Loop2000C_Obj.Count = 0 Then
                        Loop2100CSubset_Loop2000C_Obj.Add(value)
                    Else
                        Loop2100CSubset_Loop2000C_Obj(0) = value
                    End If
                End Set
            End Property
            Private Loop2100DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)
            Private Property Loop2100D_IFace_Loop2000D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D.Loop2100D
                Get
                    If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                        Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "5", "0300")
                    End If

                    If Loop2100DSubset_Loop2000D_Obj.Count > 0 Then
                        Return Loop2100DSubset_Loop2000D_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D)
                    If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                        Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)(Children(2), 1, "5", "0300")
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
            Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D
            Friend Sub New()
                MyBase.New

                Children.AddRange({CType(Nothing, Madjic.Edi.Dom.Segments.NM1_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.REF)(9, "2", "0400"),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.N2_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.N3_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.N4_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.PER)(3, "2", "0800"),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.PRV_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.DMG_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.INS_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.HI_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP)(9, "2", "1200"),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.MPI)(9, "2", "1250"),
                                    New LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)(99, "2", "1300")})

                Initialize()
            End Sub

            Partial Private Sub Initialize()

            End Sub

            Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
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
                    New ReaderState(1, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(2, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(4, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(5, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(6, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(7, "PRV", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(1, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(2, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(4, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(5, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(6, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(7, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(9, "DMG", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(1, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(2, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(4, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(5, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(6, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(7, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(9, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(10, "INS", ReadAction.PopulateSegment, 11, False),
                    New ReaderState(1, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(2, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(4, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(5, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(6, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(7, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(9, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(10, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(11, "HI", ReadAction.PopulateSegment, 12, False),
                    New ReaderState(1, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(2, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(4, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(5, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(6, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(7, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(9, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(10, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(11, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(12, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(13, "DTP", ReadAction.PopulateSegment, 13, False),
                    New ReaderState(1, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(2, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(4, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(5, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(6, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(7, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(9, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(10, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(11, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(12, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(13, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(15, "MPI", ReadAction.PopulateSegment, 15, False),
                    New ReaderState(1, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(2, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(4, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(5, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(6, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(7, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(9, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(10, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(11, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(12, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(13, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(15, "EQ", ReadAction.PopulateLoop, 17, False),
                    New ReaderState(17, "EQ", ReadAction.PopulateLoop, 17, False)})

            Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
                Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
            End Function

            Private Sub PopulateSegment(ByVal args As ReaderArgs)
                Dim SegmentName As String = args.DataSegment.SegmentID
                Dim Implementation As String = args.Implementation
                Dim Seg As Segment
                If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    NM1_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.NM1_Obj)
                    If MyBase.CompareKey(S2.NM101, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000A__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "2"
                        Seg.SetSequence = "0300"
                    ElseIf MyBase.CompareKey(S2.NM101, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0300"
                    ElseIf MyBase.CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0300"
                    ElseIf MyBase.CompareKey(S2.NM101, ";03;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0300"
                    End If
                ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    REF_Obj.Add(Seg)
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.REF_Obj)
                    If MyBase.CompareKey(S2.REF01, ";0B;1C;1D;1J;4A;CT;EL;EO;HPI;JD;N5;N7;Q4;SY;TJ;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0400"
                    ElseIf MyBase.CompareKey(S2.REF01, ";18;1L;1W;3H;6P;CT;EA;EJ;F6;GH;HJ;IG;N6;NQ;SY;Y4;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0400"
                    ElseIf MyBase.CompareKey(S2.REF01, ";18;1L;1W;6P;CT;EA;EJ;F6;GH;HJ;IF;IG;MRC;N6;SY;Y4;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0400"
                    End If
                ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    N2_Obj = Seg
                ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    N3_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0600"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0600"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0600"
                    End If
                ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    N4_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0700"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0700"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0700"
                    End If
                ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    PER_Obj.Add(Seg)
                ElseIf String.Compare(SegmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    PRV_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.PRV_Obj)
                    If MyBase.CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SB;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "3"
                        Seg.SetSequence = "0900"
                    ElseIf MyBase.CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "0900"
                    ElseIf MyBase.CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "0900"
                    End If
                ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    DMG_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1000"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1000"
                    End If
                ElseIf String.Compare(SegmentName, "INS", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.INS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    INS_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1100"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1100"
                    End If
                ElseIf String.Compare(SegmentName, "HI", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.HI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    HI_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.HI_Obj)
                    If MyBase.CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1150"
                    ElseIf MyBase.CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1150"
                    End If
                ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    DTP_Obj.Add(Seg)
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.DTP_Obj)
                    If MyBase.CompareKey(S2.DTP01, ";102;291;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1200"
                    ElseIf MyBase.CompareKey(S2.DTP01, ";102;291;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1200"
                    End If
                ElseIf String.Compare(SegmentName, "MPI", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.MPI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    MPI_Obj.Add(Seg)
                End If
            End Sub

            Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
                Dim LoopID As String = args.ParentLoopID
                Dim Implementation As String = args.Implementation
                Dim Temp = args.Implementation

                If String.Compare(args.DataSegment.SegmentID, "EQ", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Dim NewLoop As LoopBase = New Madjic.Edi.Dom.Transactions.Transaction270.Loop2110_Obj
                    Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                    Loop2110_Obj.Add(NewLoop)
                    If String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000C__2100C__2110C"
                        NewLoop.SetArea = "4"
                        NewLoop.SetSequence = "1300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        args.Implementation = "_270B1__2000D__2100D__2110D"
                        NewLoop.SetArea = "5"
                        NewLoop.SetSequence = "1300"
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    Else
                        Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                    End If
                End If
                args.Implementation = Temp
            End Function
            Friend Property NM1_Obj As Madjic.Edi.Dom.Segments.NM1_Obj
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.NM1_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.NM1_Obj)
                    Children(0) = value
                End Set
            End Property

            Private Property NM1_Std As Madjic.Edi.Dom.Segments.NM1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.NM1
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.NM1_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.NM1)
                    Children(0) = value
                End Set
            End Property

            Private Property NM1_IFace_Loop2100A_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A.NM1
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1)
                    Children(0) = value
                End Set
            End Property
            Private Property NM1_IFace_1_Loop2100B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B.NM1
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1)
                    Children(0) = value
                End Set
            End Property
            Private Property NM1_IFace_2_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.NM1
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1)
                    Children(0) = value
                End Set
            End Property
            Private Property NM1_IFace_3_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.NM1
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1)
                    Children(0) = value
                End Set
            End Property
            Friend ReadOnly Property REF_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.REF) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.REF
                Get
                    Return CType(Children(1), SegmentContainer(Of Madjic.Edi.Dom.Segments.REF))
                End Get
            End Property

            Private REFSubset_Loop2100B_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF, Madjic.Edi.Dom.Segments.REF)
            Private ReadOnly Property REF_Loop2100B_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF, Madjic.Edi.Dom.Segments.REF) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B.REF
                Get
                    If REFSubset_Loop2100B_Obj Is Nothing Then
                        REFSubset_Loop2100B_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF, Madjic.Edi.Dom.Segments.REF)(Children(1), 9, "3", "0400")
                    End If

                    Return REFSubset_Loop2100B_Obj
                End Get
            End Property
            Private REFSubset_1_Loop2100C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF, Madjic.Edi.Dom.Segments.REF)
            Private ReadOnly Property REF_Loop2100C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF, Madjic.Edi.Dom.Segments.REF) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.REF
                Get
                    If REFSubset_1_Loop2100C_Obj Is Nothing Then
                        REFSubset_1_Loop2100C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF, Madjic.Edi.Dom.Segments.REF)(Children(1), 9, "4", "0400")
                    End If

                    Return REFSubset_1_Loop2100C_Obj
                End Get
            End Property
            Private REFSubset_2_Loop2100D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF, Madjic.Edi.Dom.Segments.REF)
            Private ReadOnly Property REF_Loop2100D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF, Madjic.Edi.Dom.Segments.REF) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.REF
                Get
                    If REFSubset_2_Loop2100D_Obj Is Nothing Then
                        REFSubset_2_Loop2100D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF, Madjic.Edi.Dom.Segments.REF)(Children(1), 9, "5", "0400")
                    End If

                    Return REFSubset_2_Loop2100D_Obj
                End Get
            End Property
            Friend Property N2_Obj As Madjic.Edi.Dom.Segments.N2_Obj
                Get
                    Return CType(Children(2), Madjic.Edi.Dom.Segments.N2_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N2_Obj)
                    Children(2) = value
                End Set
            End Property

            Private Property N2_Std As Madjic.Edi.Dom.Segments.N2 Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.N2
                Get
                    Return CType(Children(2), Madjic.Edi.Dom.Segments.N2_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N2)
                    Children(2) = value
                End Set
            End Property

            Friend Property N3_Obj As Madjic.Edi.Dom.Segments.N3_Obj
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.N3_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N3_Obj)
                    Children(3) = value
                End Set
            End Property

            Private Property N3_Std As Madjic.Edi.Dom.Segments.N3 Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.N3
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.N3_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N3)
                    Children(3) = value
                End Set
            End Property

            Private Property N3_IFace_Loop2100B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B.N3
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3)
                    Children(3) = value
                End Set
            End Property
            Private Property N3_IFace_1_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.N3
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3)
                    Children(3) = value
                End Set
            End Property
            Private Property N3_IFace_2_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.N3
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3)
                    Children(3) = value
                End Set
            End Property
            Friend Property N4_Obj As Madjic.Edi.Dom.Segments.N4_Obj
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Segments.N4_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N4_Obj)
                    Children(4) = value
                End Set
            End Property

            Private Property N4_Std As Madjic.Edi.Dom.Segments.N4 Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.N4
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Segments.N4_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.N4)
                    Children(4) = value
                End Set
            End Property

            Private Property N4_IFace_Loop2100B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B.N4
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4)
                    Children(4) = value
                End Set
            End Property
            Private Property N4_IFace_1_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.N4
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4)
                    Children(4) = value
                End Set
            End Property
            Private Property N4_IFace_2_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.N4
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4)
                    Children(4) = value
                End Set
            End Property
            Friend ReadOnly Property PER_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.PER) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.PER
                Get
                    Return CType(Children(5), SegmentContainer(Of Madjic.Edi.Dom.Segments.PER))
                End Get
            End Property

            Friend Property PRV_Obj As Madjic.Edi.Dom.Segments.PRV_Obj
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Segments.PRV_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PRV_Obj)
                    Children(6) = value
                End Set
            End Property

            Private Property PRV_Std As Madjic.Edi.Dom.Segments.PRV Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.PRV
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Segments.PRV_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PRV)
                    Children(6) = value
                End Set
            End Property

            Private Property PRV_IFace_Loop2100B_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B.PRV
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV)
                    Children(6) = value
                End Set
            End Property
            Private Property PRV_IFace_1_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.PRV
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV)
                    Children(6) = value
                End Set
            End Property
            Private Property PRV_IFace_2_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.PRV
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV)
                    Children(6) = value
                End Set
            End Property
            Friend Property DMG_Obj As Madjic.Edi.Dom.Segments.DMG_Obj
                Get
                    Return CType(Children(7), Madjic.Edi.Dom.Segments.DMG_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.DMG_Obj)
                    Children(7) = value
                End Set
            End Property

            Private Property DMG_Std As Madjic.Edi.Dom.Segments.DMG Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.DMG
                Get
                    Return CType(Children(7), Madjic.Edi.Dom.Segments.DMG_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.DMG)
                    Children(7) = value
                End Set
            End Property

            Private Property DMG_IFace_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.DMG
                Get
                    Return CType(Children(7), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG)
                    Children(7) = value
                End Set
            End Property
            Private Property DMG_IFace_1_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.DMG
                Get
                    Return CType(Children(7), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG)
                    Children(7) = value
                End Set
            End Property
            Friend Property INS_Obj As Madjic.Edi.Dom.Segments.INS_Obj
                Get
                    Return CType(Children(8), Madjic.Edi.Dom.Segments.INS_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.INS_Obj)
                    Children(8) = value
                End Set
            End Property

            Private Property INS_Std As Madjic.Edi.Dom.Segments.INS Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.INS
                Get
                    Return CType(Children(8), Madjic.Edi.Dom.Segments.INS_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.INS)
                    Children(8) = value
                End Set
            End Property

            Private Property INS_IFace_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.INS
                Get
                    Return CType(Children(8), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS)
                    Children(8) = value
                End Set
            End Property
            Private Property INS_IFace_1_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.INS
                Get
                    Return CType(Children(8), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS)
                    Children(8) = value
                End Set
            End Property
            Friend Property HI_Obj As Madjic.Edi.Dom.Segments.HI_Obj
                Get
                    Return CType(Children(9), Madjic.Edi.Dom.Segments.HI_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.HI_Obj)
                    Children(9) = value
                End Set
            End Property

            Private Property HI_Std As Madjic.Edi.Dom.Segments.HI Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.HI
                Get
                    Return CType(Children(9), Madjic.Edi.Dom.Segments.HI_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.HI)
                    Children(9) = value
                End Set
            End Property

            Private Property HI_IFace_Loop2100C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.HI
                Get
                    Return CType(Children(9), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI)
                    Children(9) = value
                End Set
            End Property
            Private Property HI_IFace_1_Loop2100D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.HI
                Get
                    Return CType(Children(9), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI)
                    Children(9) = value
                End Set
            End Property
            Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.DTP
                Get
                    Return CType(Children(10), SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP))
                End Get
            End Property

            Private DTPSubset_Loop2100C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP, Madjic.Edi.Dom.Segments.DTP)
            Private ReadOnly Property DTP_Loop2100C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP, Madjic.Edi.Dom.Segments.DTP) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.DTP
                Get
                    If DTPSubset_Loop2100C_Obj Is Nothing Then
                        DTPSubset_Loop2100C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(10), 2, "4", "1200")
                    End If

                    Return DTPSubset_Loop2100C_Obj
                End Get
            End Property
            Private DTPSubset_1_Loop2100D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP, Madjic.Edi.Dom.Segments.DTP)
            Private ReadOnly Property DTP_Loop2100D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP, Madjic.Edi.Dom.Segments.DTP) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.DTP
                Get
                    If DTPSubset_1_Loop2100D_Obj Is Nothing Then
                        DTPSubset_1_Loop2100D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(10), 2, "5", "1200")
                    End If

                    Return DTPSubset_1_Loop2100D_Obj
                End Get
            End Property
            Friend ReadOnly Property MPI_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.MPI) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.MPI
                Get
                    Return CType(Children(11), SegmentContainer(Of Madjic.Edi.Dom.Segments.MPI))
                End Get
            End Property

            Friend ReadOnly Property Loop2110_Obj As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100.Loop2110
                Get
                    Return CType(Children(12), LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110))
                End Get
            End Property

            Private Loop2110CSubset_Loop2100C_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)
            Private ReadOnly Property Loop2110C_Obj_Loop2100C_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C.Loop2110C
                Get
                    If Loop2110CSubset_Loop2100C_Obj Is Nothing Then
                        Loop2110CSubset_Loop2100C_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)(Children(12), 99, "4", "1300")
                    End If

                    Return Loop2110CSubset_Loop2100C_Obj
                End Get
            End Property
            Private Loop2110DSubset_Loop2100D_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)
            Private ReadOnly Property Loop2110D_Obj_Loop2100D_Obj As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110) Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D.Loop2110D
                Get
                    If Loop2110DSubset_Loop2100D_Obj Is Nothing Then
                        Loop2110DSubset_Loop2100D_Obj = New LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)(Children(12), 99, "5", "1300")
                    End If

                    Return Loop2110DSubset_Loop2100D_Obj
                End Get
            End Property

        End Class
        Partial Friend Class Loop2110_Obj
            Inherits LoopBase
            Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C,
                        Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D
            Friend Sub New()
                MyBase.New

                Children.AddRange({CType(Nothing, Madjic.Edi.Dom.Segments.EQ_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.AMT)(2, "2", "1350"),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.VEH_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.PDR_Obj),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.PDP_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.III)(10, "2", "1700"),
                                    CType(Nothing, Madjic.Edi.Dom.Segments.REF_Obj),
                                    New SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP)(9, "2", "2000")})

                Initialize()
            End Sub

            Partial Private Sub Initialize()

            End Sub

            Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "EQ", ReadAction.PopulateSegment, 1, False),
                    New ReaderState(1, "AMT", ReadAction.PopulateSegment, 2, False),
                    New ReaderState(2, "AMT", ReadAction.PopulateSegment, 2, False),
                    New ReaderState(1, "VEH", ReadAction.PopulateSegment, 4, False),
                    New ReaderState(2, "VEH", ReadAction.PopulateSegment, 4, False),
                    New ReaderState(1, "PDR", ReadAction.PopulateSegment, 5, False),
                    New ReaderState(2, "PDR", ReadAction.PopulateSegment, 5, False),
                    New ReaderState(4, "PDR", ReadAction.PopulateSegment, 5, False),
                    New ReaderState(1, "PDP", ReadAction.PopulateSegment, 6, False),
                    New ReaderState(2, "PDP", ReadAction.PopulateSegment, 6, False),
                    New ReaderState(4, "PDP", ReadAction.PopulateSegment, 6, False),
                    New ReaderState(5, "PDP", ReadAction.PopulateSegment, 6, False),
                    New ReaderState(1, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(2, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(4, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(5, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(6, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(7, "III", ReadAction.PopulateSegment, 7, False),
                    New ReaderState(1, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(2, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(4, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(5, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(6, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(7, "REF", ReadAction.PopulateSegment, 9, False),
                    New ReaderState(1, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(2, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(4, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(5, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(6, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(7, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(9, "DTP", ReadAction.PopulateSegment, 10, False),
                    New ReaderState(10, "DTP", ReadAction.PopulateSegment, 10, False)})

            Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
                Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
            End Function

            Private Sub PopulateSegment(ByVal args As ReaderArgs)
                Dim SegmentName As String = args.DataSegment.SegmentID
                Dim Implementation As String = args.Implementation
                Dim Seg As Segment
                If String.Compare(SegmentName, "EQ", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.EQ_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    EQ_Obj = Seg
                    If String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1300"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1300"
                    End If
                ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    AMT_Obj.Add(Seg)
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.AMT_Obj)
                    If MyBase.CompareKey(S2.AMT01, ";R;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1350"
                    ElseIf MyBase.CompareKey(S2.AMT01, ";PB;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1355"
                    End If
                ElseIf String.Compare(SegmentName, "VEH", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.VEH_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    VEH_Obj = Seg
                ElseIf String.Compare(SegmentName, "PDR", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.PDR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    PDR_Obj = Seg
                ElseIf String.Compare(SegmentName, "PDP", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.PDP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    PDP_Obj = Seg
                ElseIf String.Compare(SegmentName, "III", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.III_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    III_Obj.Add(Seg)
                    If String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1390"
                    ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1390"
                    End If
                ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    REF_Obj = Seg
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.REF_Obj)
                    If MyBase.CompareKey(S2.REF01, ";9F;G1;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1400"
                    ElseIf MyBase.CompareKey(S2.REF01, ";9F;G1;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1400"
                    End If
                ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg = Madjic.Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                    DTP_Obj.Add(Seg)
                    Dim S2 = CType(Seg, Madjic.Edi.Dom.Segments.DTP_Obj)
                    If MyBase.CompareKey(S2.DTP01, ";291;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "4"
                        Seg.SetSequence = "1500"
                    ElseIf MyBase.CompareKey(S2.DTP01, ";291;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
                        Seg.SetArea = "5"
                        Seg.SetSequence = "1500"
                    End If
                End If
            End Sub

            Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
                Return Task.CompletedTask
            End Function
            Friend Property EQ_Obj As Madjic.Edi.Dom.Segments.EQ_Obj
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.EQ_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.EQ_Obj)
                    Children(0) = value
                End Set
            End Property

            Private Property EQ_Std As Madjic.Edi.Dom.Segments.EQ Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.EQ
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Segments.EQ_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.EQ)
                    Children(0) = value
                End Set
            End Property

            Private Property EQ_IFace_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.EQ
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ)
                    Children(0) = value
                End Set
            End Property
            Private Property EQ_IFace_1_Loop2110D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D.EQ
                Get
                    Return CType(Children(0), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ)
                    Children(0) = value
                End Set
            End Property
            Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.AMT) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.AMT
                Get
                    Return CType(Children(1), SegmentContainer(Of Madjic.Edi.Dom.Segments.AMT))
                End Get
            End Property

            Private AMTSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT, Madjic.Edi.Dom.Segments.AMT)
            Private Property AMT_IFace_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.AMT
                Get
                    If AMTSubset_Loop2110C_Obj Is Nothing Then
                        AMTSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT, Madjic.Edi.Dom.Segments.AMT)(Children(1), 1, "4", "1350")
                    End If

                    If AMTSubset_Loop2110C_Obj.Count > 0 Then
                        Return AMTSubset_Loop2110C_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT)
                    If AMTSubset_Loop2110C_Obj Is Nothing Then
                        AMTSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT, Madjic.Edi.Dom.Segments.AMT)(Children(1), 1, "4", "1350")
                    End If

                    If AMTSubset_Loop2110C_Obj.Count = 0 Then
                        AMTSubset_Loop2110C_Obj.Add(value)
                    Else
                        AMTSubset_Loop2110C_Obj(0) = value
                    End If
                End Set
            End Property
            Private AMT_1Subset_Loop2110C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1, Madjic.Edi.Dom.Segments.AMT)
            Private Property AMT_IFace_1_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1 Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.AMT_1
                Get
                    If AMT_1Subset_Loop2110C_Obj Is Nothing Then
                        AMT_1Subset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1, Madjic.Edi.Dom.Segments.AMT)(Children(1), 1, "4", "1355")
                    End If

                    If AMT_1Subset_Loop2110C_Obj.Count > 0 Then
                        Return AMT_1Subset_Loop2110C_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1)
                    If AMT_1Subset_Loop2110C_Obj Is Nothing Then
                        AMT_1Subset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1, Madjic.Edi.Dom.Segments.AMT)(Children(1), 1, "4", "1355")
                    End If

                    If AMT_1Subset_Loop2110C_Obj.Count = 0 Then
                        AMT_1Subset_Loop2110C_Obj.Add(value)
                    Else
                        AMT_1Subset_Loop2110C_Obj(0) = value
                    End If
                End Set
            End Property
            Friend Property VEH_Obj As Madjic.Edi.Dom.Segments.VEH_Obj
                Get
                    Return CType(Children(2), Madjic.Edi.Dom.Segments.VEH_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.VEH_Obj)
                    Children(2) = value
                End Set
            End Property

            Private Property VEH_Std As Madjic.Edi.Dom.Segments.VEH Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.VEH
                Get
                    Return CType(Children(2), Madjic.Edi.Dom.Segments.VEH_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.VEH)
                    Children(2) = value
                End Set
            End Property

            Friend Property PDR_Obj As Madjic.Edi.Dom.Segments.PDR_Obj
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.PDR_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PDR_Obj)
                    Children(3) = value
                End Set
            End Property

            Private Property PDR_Std As Madjic.Edi.Dom.Segments.PDR Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.PDR
                Get
                    Return CType(Children(3), Madjic.Edi.Dom.Segments.PDR_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PDR)
                    Children(3) = value
                End Set
            End Property

            Friend Property PDP_Obj As Madjic.Edi.Dom.Segments.PDP_Obj
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Segments.PDP_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PDP_Obj)
                    Children(4) = value
                End Set
            End Property

            Private Property PDP_Std As Madjic.Edi.Dom.Segments.PDP Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.PDP
                Get
                    Return CType(Children(4), Madjic.Edi.Dom.Segments.PDP_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.PDP)
                    Children(4) = value
                End Set
            End Property

            Friend ReadOnly Property III_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.III) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.III
                Get
                    Return CType(Children(5), SegmentContainer(Of Madjic.Edi.Dom.Segments.III))
                End Get
            End Property

            Private IIISubset_Loop2110C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III, Madjic.Edi.Dom.Segments.III)
            Private Property III_IFace_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.III
                Get
                    If IIISubset_Loop2110C_Obj Is Nothing Then
                        IIISubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III, Madjic.Edi.Dom.Segments.III)(Children(5), 1, "4", "1390")
                    End If

                    If IIISubset_Loop2110C_Obj.Count > 0 Then
                        Return IIISubset_Loop2110C_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III)
                    If IIISubset_Loop2110C_Obj Is Nothing Then
                        IIISubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III, Madjic.Edi.Dom.Segments.III)(Children(5), 1, "4", "1390")
                    End If

                    If IIISubset_Loop2110C_Obj.Count = 0 Then
                        IIISubset_Loop2110C_Obj.Add(value)
                    Else
                        IIISubset_Loop2110C_Obj(0) = value
                    End If
                End Set
            End Property
            Private IIISubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III, Madjic.Edi.Dom.Segments.III)
            Private Property III_IFace_1_Loop2110D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D.III
                Get
                    If IIISubset_1_Loop2110D_Obj Is Nothing Then
                        IIISubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III, Madjic.Edi.Dom.Segments.III)(Children(5), 1, "5", "1390")
                    End If

                    If IIISubset_1_Loop2110D_Obj.Count > 0 Then
                        Return IIISubset_1_Loop2110D_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III)
                    If IIISubset_1_Loop2110D_Obj Is Nothing Then
                        IIISubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III, Madjic.Edi.Dom.Segments.III)(Children(5), 1, "5", "1390")
                    End If

                    If IIISubset_1_Loop2110D_Obj.Count = 0 Then
                        IIISubset_1_Loop2110D_Obj.Add(value)
                    Else
                        IIISubset_1_Loop2110D_Obj(0) = value
                    End If
                End Set
            End Property
            Friend Property REF_Obj As Madjic.Edi.Dom.Segments.REF_Obj
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Segments.REF_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.REF_Obj)
                    Children(6) = value
                End Set
            End Property

            Private Property REF_Std As Madjic.Edi.Dom.Segments.REF Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.REF
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Segments.REF_Obj)
                End Get
                Set(value As Madjic.Edi.Dom.Segments.REF)
                    Children(6) = value
                End Set
            End Property

            Private Property REF_IFace_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.REF
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF)
                    Children(6) = value
                End Set
            End Property
            Private Property REF_IFace_1_Loop2110D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D.REF
                Get
                    Return CType(Children(6), Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF)
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF)
                    Children(6) = value
                End Set
            End Property
            Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP) Implements Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110.DTP
                Get
                    Return CType(Children(7), SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP))
                End Get
            End Property

            Private DTPSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP, Madjic.Edi.Dom.Segments.DTP)
            Private Property DTP_IFace_Loop2110C_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C.DTP
                Get
                    If DTPSubset_Loop2110C_Obj Is Nothing Then
                        DTPSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(7), 1, "4", "1500")
                    End If

                    If DTPSubset_Loop2110C_Obj.Count > 0 Then
                        Return DTPSubset_Loop2110C_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP)
                    If DTPSubset_Loop2110C_Obj Is Nothing Then
                        DTPSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(7), 1, "4", "1500")
                    End If

                    If DTPSubset_Loop2110C_Obj.Count = 0 Then
                        DTPSubset_Loop2110C_Obj.Add(value)
                    Else
                        DTPSubset_Loop2110C_Obj(0) = value
                    End If
                End Set
            End Property
            Private DTPSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP, Madjic.Edi.Dom.Segments.DTP)
            Private Property DTP_IFace_1_Loop2110D_Obj As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP Implements Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D.DTP
                Get
                    If DTPSubset_1_Loop2110D_Obj Is Nothing Then
                        DTPSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(7), 1, "5", "1500")
                    End If

                    If DTPSubset_1_Loop2110D_Obj.Count > 0 Then
                        Return DTPSubset_1_Loop2110D_Obj(0)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(value As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP)
                    If DTPSubset_1_Loop2110D_Obj Is Nothing Then
                        DTPSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP, Madjic.Edi.Dom.Segments.DTP)(Children(7), 1, "5", "1500")
                    End If

                    If DTPSubset_1_Loop2110D_Obj.Count = 0 Then
                        DTPSubset_1_Loop2110D_Obj.Add(value)
                    Else
                        DTPSubset_1_Loop2110D_Obj(0) = value
                    End If
                End Set
            End Property

        End Class
        '''<summary>Health Care Eligibility Benefit Inquiry</summary>
        '''<remarks></remarks>
        Public Interface Standard
            '''<summary>Transaction Set Header</summary>
            Property ST As Madjic.Edi.Dom.Segments.ST
            '''<summary>Beginning of Hierarchical Transaction</summary>
            Property BHT As Madjic.Edi.Dom.Segments.BHT
            '''<summary>Hierarchical Level</summary>
            ReadOnly Property Loop2000 As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)
            '''<summary>Transaction Set Trailer</summary>
            Property SE As Madjic.Edi.Dom.Segments.SE
        End Interface
        Namespace Loops

            '''<summary></summary>
            '''<remarks></remarks>
            Public Interface Loop2000
                Inherits ILoop
                '''<summary>Hierarchical Level</summary>
                Property HL As Madjic.Edi.Dom.Segments.HL
                '''<summary>Trace</summary>
                ReadOnly Property TRN As SegmentContainer(Of Madjic.Edi.Dom.Segments.TRN)
                '''<summary>Individual or Organizational Name</summary>
                ReadOnly Property Loop2100 As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2100)
            End Interface
            '''<summary></summary>
            '''<remarks></remarks>
            Public Interface Loop2100
                Inherits ILoop
                '''<summary>Individual or Organizational Name</summary>
                Property NM1 As Madjic.Edi.Dom.Segments.NM1
                '''<summary>Reference Information</summary>
                ReadOnly Property REF As SegmentContainer(Of Madjic.Edi.Dom.Segments.REF)
                '''<summary>Additional Name Information</summary>
                Property N2 As Madjic.Edi.Dom.Segments.N2
                '''<summary>Party Location</summary>
                Property N3 As Madjic.Edi.Dom.Segments.N3
                '''<summary>Geographic Location</summary>
                Property N4 As Madjic.Edi.Dom.Segments.N4
                '''<summary>Administrative Communications Contact</summary>
                ReadOnly Property PER As SegmentContainer(Of Madjic.Edi.Dom.Segments.PER)
                '''<summary>Provider Information</summary>
                Property PRV As Madjic.Edi.Dom.Segments.PRV
                '''<summary>Demographic Information</summary>
                Property DMG As Madjic.Edi.Dom.Segments.DMG
                '''<summary>Insured Benefit</summary>
                Property INS As Madjic.Edi.Dom.Segments.INS
                '''<summary>Health Care Information Codes</summary>
                Property HI As Madjic.Edi.Dom.Segments.HI
                '''<summary>Date or Time or Period</summary>
                ReadOnly Property DTP As SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP)
                '''<summary>Military Personnel Information</summary>
                ReadOnly Property MPI As SegmentContainer(Of Madjic.Edi.Dom.Segments.MPI)
                '''<summary>Eligibility or Benefit Inquiry</summary>
                ReadOnly Property Loop2110 As LoopContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)
            End Interface
            '''<summary></summary>
            '''<remarks></remarks>
            Public Interface Loop2110
                Inherits ILoop
                '''<summary>Eligibility or Benefit Inquiry</summary>
                Property EQ As Madjic.Edi.Dom.Segments.EQ
                '''<summary>Monetary Amount Information</summary>
                ReadOnly Property AMT As SegmentContainer(Of Madjic.Edi.Dom.Segments.AMT)
                '''<summary>Vehicle Information</summary>
                Property VEH As Madjic.Edi.Dom.Segments.VEH
                '''<summary>Property Description - Real</summary>
                Property PDR As Madjic.Edi.Dom.Segments.PDR
                '''<summary>Property Description - Personal</summary>
                Property PDP As Madjic.Edi.Dom.Segments.PDP
                '''<summary>Information</summary>
                ReadOnly Property III As SegmentContainer(Of Madjic.Edi.Dom.Segments.III)
                '''<summary>Reference Information</summary>
                Property REF As Madjic.Edi.Dom.Segments.REF
                '''<summary>Date or Time or Period</summary>
                ReadOnly Property DTP As SegmentContainer(Of Madjic.Edi.Dom.Segments.DTP)
            End Interface

        End Namespace 'Loops


        Namespace Transaction270_B1
            Namespace Segments

                Namespace Loop2000A

                    '''<summary>Information Source Level</summary>
                    Public Interface HL
                        Inherits ISegment

                        '''<summary>Hierarchical ID Number</summary>
                        Property HL01 As String
                        '''<summary>All data that follows this HL segment is associated with the Information Source identified by the level code. This association continues until the next occurrence of an HL segment.</summary>
                        Property HL03 As String
                        '''<summary>Because of the hierarchical structure, and there will always be an Information Receiver HL subordinate to this Information Source HL the code value in the HL04 at the Loop 2000A level must always be "1".</summary>
                        Property HL04 As String
                    End Interface
                End Namespace 'Loop2000A

                Namespace Loop2100A

                    '''<summary>Information Source Name</summary>
                    Public Interface NM1
                        Inherits ISegment

                        '''<summary>Entity Identifier Code</summary>
                        Property NM101 As String
                        '''<summary>Use this code to indicate whether the entity is an individual person or an organization.</summary>
                        Property NM102 As String
                        '''<summary>Information Source Last or Organization Name</summary>
                        Property NM103 As String
                        '''<summary>Information Source First Name</summary>
                        Property NM104 As String
                        '''<summary>Information Source Middle Name</summary>
                        Property NM105 As String
                        '''<summary>Information Source Name Suffix</summary>
                        Property NM107 As String
                        '''<summary>Use code value "XV" if the Information Source is a Payer and the National PlanID is mandated for use. Use code value "XX" if the information source is a provider and the CMS National Provider Identifier is mandated for use. Otherwise one of the other appropriate code values may be used.</summary>
                        Property NM108 As String
                        '''<summary>Information Source Primary Identifier</summary>
                        Property NM109 As String
                    End Interface
                End Namespace 'Loop2100A

                Namespace Loop2000B

                    '''<summary>Information Receiver Level</summary>
                    Public Interface HL
                        Inherits ISegment

                        '''<summary>Hierarchical ID Number</summary>
                        Property HL01 As String
                        '''<summary>Use this code to identify the specific Information Source to which this Information Receiver is subordinate.</summary>
                        Property HL02 As String
                        '''<summary>All data that follows this HL segment is associated with the Information Receiver identified by the level code. This association continues until the next occurrence of an HL segment.</summary>
                        Property HL03 As String
                        '''<summary>Because of the hierarchical structure, and there will always be a Subscriber HL subordinate to this Information Receiver HL, the code value in the HL04 at the Loop 2000B level must always be "1".</summary>
                        Property HL04 As String
                    End Interface
                End Namespace 'Loop2000B

                Namespace Loop2100B

                    '''<summary>Information Receiver Name</summary>
                    Public Interface NM1
                        Inherits ISegment

                        '''<summary>Entity Identifier Code</summary>
                        Property NM101 As String
                        '''<summary>Use this code to indicate whether the entity is an individual person or an organization.</summary>
                        Property NM102 As String
                        '''<summary>Information Receiver Last or Organization Name</summary>
                        Property NM103 As String
                        '''<summary>Information Receiver First Name</summary>
                        Property NM104 As String
                        '''<summary>Information Receiver Middle Name</summary>
                        Property NM105 As String
                        '''<summary>Information Receiver Name Suffix</summary>
                        Property NM107 As String
                        '''<summary>Use this element to qualify the identification number submitted in NM109. This is the number that the information source associates with the information receiver. Because only one number can be submitted in NM109, the following hierarchy must be used. Additional identifiers are to be placed in the REF segment. If the information receiver is a provider and the National Provider ID is mandated for use and the provider is a covered health care provider under the mandate, code value "XX" must be used. Otherwise, one of the following codes may be used with the following hierarchy applied: Use the first code that applies: "SV", "PP", "FI", "34". The code "SV" is recommended to be used prior to the mandated use of the National Provider ID. If the information receiver is a payer and the CMS National PlanID is mandated for use, code value "XV" must be used, otherwise, use code value "PI". If the information receiver is an employer, use code value "24".</summary>
                        Property NM108 As String
                        '''<summary>Information Receiver Identification Number</summary>
                        Property NM109 As String
                    End Interface
                    '''<summary>Information Receiver Additional Identification</summary>
                    Public Interface REF
                        Inherits ISegment

                        '''<summary>Reference Identification Qualifier</summary>
                        Property REF01 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (REF01).;</summary>
                        Property REF02 As String
                        '''<summary>Use this element for the two character state ID of the state assigning the identifier supplied in REF02. See Code source 22: States and Outlying Areas of the U.S.</summary>
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
                        '''<summary>Use this code to identify the specific Information Receiver to which this Subscriber is subordinate.</summary>
                        Property HL02 As String
                        '''<summary>All data that follows this HL segment is associated with the Subscriber identified by the level code. This association continues until the next occurrence of an HL segment.</summary>
                        Property HL03 As String
                        '''<summary>If there is a Loop 2000D (Dependent) level subordinate to the current Loop 2000C, the value must be "1". If there is no Loop 2000D (Dependent) level subordinate to the current Loop 2000C, the value must be "0" (zero).</summary>
                        Property HL04 As String
                    End Interface
                    '''<summary>Subscriber Trace Number</summary>
                    Public Interface TRN
                        Inherits ISegment

                        '''<summary>Trace Type Code</summary>
                        Property TRN01 As String
                        '''<summary>Use this number for the trace or reference number assigned by the information receiver or clearinghouse.</summary>
                        Property TRN02 As String
                        '''<summary>Use this number for the identification number of the company that assigned the trace or reference number specified in the previous data element (TRN02).</summary>
                        Property TRN03 As String
                        '''<summary>This information allows the originating company to further identify a specific division or group within that organization that was responsible for assigning the trace or reference number.</summary>
                        Property TRN04 As String
                    End Interface
                End Namespace 'Loop2000C

                Namespace Loop2100C

                    '''<summary>Subscriber Name</summary>
                    Public Interface NM1
                        Inherits ISegment

                        '''<summary>Entity Identifier Code</summary>
                        Property NM101 As String
                        '''<summary>Use this code to indicate whether the entity is an individual person or an organization.</summary>
                        Property NM102 As String
                        '''<summary>Use this name for the subscriber's last name.</summary>
                        Property NM103 As String
                        '''<summary>Use this name for the subscriber's first name.</summary>
                        Property NM104 As String
                        '''<summary>Use this name for the subscriber's middle name or initial.</summary>
                        Property NM105 As String
                        '''<summary>Use this for the suffix to an individual's name; e.g., Sr., Jr. or III.</summary>
                        Property NM107 As String
                        '''<summary>Use this element to qualify the identification number submitted in;NM109. This is the primary number that the information source associates with the subscriber.</summary>
                        Property NM108 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (NM108).</summary>
                        Property NM109 As String
                    End Interface
                    '''<summary>Subscriber Additional Identification</summary>
                    Public Interface REF
                        Inherits ISegment

                        '''<summary>Reference Identification Qualifier</summary>
                        Property REF01 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (REF01).;</summary>
                        Property REF02 As String
                    End Interface
                    '''<summary>Subscriber Address</summary>
                    Public Interface N3
                        Inherits ISegment

                        '''<summary>Subscriber Address Line</summary>
                        Property N301 As String
                        '''<summary>Use this information for the second line of the address information.</summary>
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
                        '''<summary>Country Code</summary>
                        Property N404 As String
                        '''<summary>Country Subdivision Code</summary>
                        Property N407 As String
                    End Interface
                    '''<summary>Provider Information</summary>
                    Public Interface PRV
                        Inherits ISegment

                        '''<summary>Provider Code</summary>
                        Property PRV01 As String
                        '''<summary>If this segment is used to identify a specific provider and the National Provider ID is mandated for use, code value "HPI" must be used, otherwise one of the other code values may be used.</summary>
                        Property PRV02 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (PRV02).</summary>
                        Property PRV03 As String
                    End Interface
                    '''<summary>Subscriber Demographic Information</summary>
                    Public Interface DMG
                        Inherits ISegment

                        '''<summary>Date Time Period Format Qualifier</summary>
                        Property DMG01 As String
                        '''<summary>Use this date for the date of birth of the subscriber.</summary>
                        Property DMG02 As String
                        '''<summary>Use this code to indicate the subscriber's gender.</summary>
                        Property DMG03 As String
                    End Interface
                    '''<summary>Multiple Birth Sequence Number</summary>
                    Public Interface INS
                        Inherits ISegment

                        '''<summary>Insured Indicator</summary>
                        Property INS01 As String
                        '''<summary>The value 18 is used only to satisfy X12 syntax.</summary>
                        Property INS02 As String
                        '''<summary>Use to indicate the birth order in the event of multiple births in association with the birth date supplied in DMG02.</summary>
                        Property INS17 As Decimal?
                    End Interface
                    '''<summary>Subscriber Health Care Diagnosis Code</summary>
                    Public Interface HI
                        Inherits ISegment

                        '''<summary></summary>
                        Property HI01 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01.C022
                        '''<summary></summary>
                        Property HI02 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02.C022
                        '''<summary></summary>
                        Property HI03 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03.C022
                        '''<summary></summary>
                        Property HI04 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04.C022
                        '''<summary></summary>
                        Property HI05 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05.C022
                        '''<summary></summary>
                        Property HI06 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06.C022
                        '''<summary></summary>
                        Property HI07 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07.C022
                        '''<summary></summary>
                        Property HI08 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08.C022
                    End Interface
                    '''<summary>Subscriber Date</summary>
                    Public Interface DTP
                        Inherits ISegment

                        '''<summary>Date Time Qualifier</summary>
                        Property DTP01 As String
                        '''<summary>Date Time Period Format Qualifier</summary>
                        Property DTP02 As String
                        '''<summary>Use this date for the date(s) as qualified by the preceding data elements.</summary>
                        Property DTP03 As String
                    End Interface
                End Namespace 'Loop2100C

                Namespace Loop2110C

                    '''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
                    Public Interface EQ
                        Inherits ISegment

                        '''<summary>Service Type Code</summary>
                        ReadOnly Property EQ01 As RepeatingSimpleElementList
                        '''<summary>An information source may support the use of EQ02 - Composite Medical Procedure Identifier at their discretion. The EQ02 allows for a very specific inquiry, such as one based on a procedure code. Additional information such as diagnosis codes can be supplied in the 2100C HI segment and place of service can be supplied in the 2110C III segment.</summary>
                        Property EQ02 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02.C003
                        '''<summary>Coverage Level Code</summary>
                        Property EQ03 As String
                        '''<summary></summary>
                        Property EQ05 As Madjic.Edi.Dom.DataElements.Composite.C004
                    End Interface
                    '''<summary>Subscriber Spend Down Amount</summary>
                    Public Interface AMT
                        Inherits ISegment

                        '''<summary>Amount Qualifier Code</summary>
                        Property AMT01 As String
                        '''<summary>Use this monetary amount to specify the dollar amount associated with this inquiry.</summary>
                        Property AMT02 As Decimal?
                    End Interface
                    '''<summary>Subscriber Spend Down Total Billed Amount</summary>
                    Public Interface AMT_1
                        Inherits ISegment

                        '''<summary>Amount Qualifier Code</summary>
                        Property AMT01 As String
                        '''<summary>Use this monetary amount to specify the dollar amount associated with this inquiry.</summary>
                        Property AMT02 As Decimal?
                    End Interface
                    '''<summary>Subscriber Eligibility or Benefit Additional Inquiry Information</summary>
                    Public Interface III
                        Inherits ISegment

                        '''<summary>Code List Qualifier Code</summary>
                        Property III01 As String
                        '''<summary>Use this element for codes identifying a place of service from code source 237. As a courtesy, the codes are listed below; however, the code list is thought to be complete at the time of publication of this implementation guideline. Since this list is subject to change, only codes contained in the document available from code source 237 are to be supported in this transaction and take precedence over any and all codes listed here.<br />&lt;T&gt;01&lt;T&gt;Pharmacy<br />&lt;T&gt;03&lt;T&gt;School<br />&lt;T&gt;04&lt;T&gt;Homeless Shelter<br />&lt;T&gt;05&lt;T&gt;Indian Health Service Free-standing Facility<br />&lt;T&gt;06&lt;T&gt;Indian Health Service Provider-based Facility<br />&lt;T&gt;07&lt;T&gt;Tribal 638 Free-standing Facility<br />&lt;T&gt;08&lt;T&gt;Tribal 638 Provider-based Facility<br />&lt;T&gt;11&lt;T&gt;Office<br />&lt;T&gt;12&lt;T&gt;Home<br />&lt;T&gt;13&lt;T&gt;Assisted Living Facility<br />&lt;T&gt;14&lt;T&gt;Group Home<br />&lt;T&gt;15&lt;T&gt;Mobile Unit<br />&lt;T&gt;20&lt;T&gt;Urgent Care Facility<br />&lt;T&gt;21&lt;T&gt;Inpatient Hospital<br />&lt;T&gt;22&lt;T&gt;Outpatient Hospital<br />&lt;T&gt;23&lt;T&gt;Emergency Room - Hospital<br />&lt;T&gt;24&lt;T&gt;Ambulatory Surgical Center<br />&lt;T&gt;25&lt;T&gt;Birthing Center<br />&lt;T&gt;26&lt;T&gt;Military Treatment Facility<br />&lt;T&gt;31&lt;T&gt;Skilled Nursing Facility<br />&lt;T&gt;32&lt;T&gt;Nursing Facility<br />&lt;T&gt;33&lt;T&gt;Custodial Care Facility<br />&lt;T&gt;34&lt;T&gt;Hospice<br />&lt;T&gt;41&lt;T&gt;Ambulance - Land<br />&lt;T&gt;42&lt;T&gt;Ambulance - Air or Water<br />&lt;T&gt;49&lt;T&gt;Independent Clinic<br />&lt;T&gt;50&lt;T&gt;Federally Qualified Health Center<br />&lt;T&gt;51&lt;T&gt;Inpatient Psychiatric Facility<br />&lt;T&gt;52&lt;T&gt;Psychiatric Facility - Partial Hospitalization<br />&lt;T&gt;53&lt;T&gt;Community Mental Health Center<br />&lt;T&gt;54&lt;T&gt;Intermediate Care Facility/Mentally Retarded<br />&lt;T&gt;55&lt;T&gt;Residential Substance Abuse Treatment Facility<br />&lt;T&gt;56&lt;T&gt;Psychiatric Residential Treatment Center<br />&lt;T&gt;57&lt;T&gt;Non-residential Substance Abuse Treatment Facility<br />&lt;T&gt;60&lt;T&gt;Mass Immunization Center<br />&lt;T&gt;61&lt;T&gt;Comprehensive Inpatient Rehabilitation Facility<br />&lt;T&gt;62&lt;T&gt;Comprehensive Outpatient Rehabilitation Facility<br />&lt;T&gt;65&lt;T&gt;End-Stage Renal Disease Treatment Facility<br />&lt;T&gt;71&lt;T&gt;Public Health Clinic<br />&lt;T&gt;72&lt;T&gt;Rural Health Clinic<br />&lt;T&gt;81&lt;T&gt;Independent Laboratory<br />&lt;T&gt;99&lt;T&gt;Other Place of Service</summary>
                        Property III02 As String
                    End Interface
                    '''<summary>Subscriber Additional Information</summary>
                    Public Interface REF
                        Inherits ISegment

                        '''<summary>Reference Identification Qualifier</summary>
                        Property REF01 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (REF01).;</summary>
                        Property REF02 As String
                    End Interface
                    '''<summary>Subscriber Eligibility/Benefit Date</summary>
                    Public Interface DTP
                        Inherits ISegment

                        '''<summary>Date Time Qualifier</summary>
                        Property DTP01 As String
                        '''<summary>Use this code to specify the format of the date(s) or time(s) that follow in the next data element.</summary>
                        Property DTP02 As String
                        '''<summary>Use this date for the date(s) as qualified by the preceding data elements.</summary>
                        Property DTP03 As String
                    End Interface
                End Namespace 'Loop2110C

                Namespace Loop2000D

                    '''<summary>Dependent Level</summary>
                    Public Interface HL
                        Inherits ISegment

                        '''<summary>Hierarchical ID Number</summary>
                        Property HL01 As String
                        '''<summary>Use this code to identify the specific Subscriber to which this level is subordinate.</summary>
                        Property HL02 As String
                        '''<summary>All data that follows this HL segment is associated with the Dependent identified by the level code. This association continues until the next occurrence of an HL segment.</summary>
                        Property HL03 As String
                        '''<summary>Because of the hierarchical structure, and because no HL level is subordinate to this level, the code value in the HL04 at the Loop 2000D level must always be "0" (zero).</summary>
                        Property HL04 As String
                    End Interface
                    '''<summary>Dependent Trace Number</summary>
                    Public Interface TRN
                        Inherits ISegment

                        '''<summary>Trace Type Code</summary>
                        Property TRN01 As String
                        '''<summary>Use this number for the trace or reference number assigned by the information receiver or clearinghouse.</summary>
                        Property TRN02 As String
                        '''<summary>Use this number for the identification number of the company that assigned the trace or reference number specified in the previous data element (TRN02).</summary>
                        Property TRN03 As String
                        '''<summary>This information allows the originating company to further identify a specific division or group within that organization that was responsible for assigning the trace or reference number.</summary>
                        Property TRN04 As String
                    End Interface
                End Namespace 'Loop2000D

                Namespace Loop2100D

                    '''<summary>Dependent Name</summary>
                    Public Interface NM1
                        Inherits ISegment

                        '''<summary>Entity Identifier Code</summary>
                        Property NM101 As String
                        '''<summary>Use this code to indicate whether the entity is an individual person or an organization.</summary>
                        Property NM102 As String
                        '''<summary>Use this name for the dependent's last name.</summary>
                        Property NM103 As String
                        '''<summary>Use this name for the dependent's first name.</summary>
                        Property NM104 As String
                        '''<summary>Use this name for the dependent's middle name or initial.</summary>
                        Property NM105 As String
                        '''<summary>Use this for the suffix to an individual's name; e.g., Sr., Jr. or III.</summary>
                        Property NM107 As String
                    End Interface
                    '''<summary>Dependent Additional Identification</summary>
                    Public Interface REF
                        Inherits ISegment

                        '''<summary>Reference Identification Qualifier</summary>
                        Property REF01 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (REF01).;</summary>
                        Property REF02 As String
                    End Interface
                    '''<summary>Dependent Address</summary>
                    Public Interface N3
                        Inherits ISegment

                        '''<summary>Dependent Address Line</summary>
                        Property N301 As String
                        '''<summary>Use this information for the second line of the address information.</summary>
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
                        '''<summary>Country Code</summary>
                        Property N404 As String
                        '''<summary>Country Subdivision Code</summary>
                        Property N407 As String
                    End Interface
                    '''<summary>Provider Information</summary>
                    Public Interface PRV
                        Inherits ISegment

                        '''<summary>Provider Code</summary>
                        Property PRV01 As String
                        '''<summary>If this segment is used to identify a specific provider and the National Provider ID is mandated for use, code value "HPI" must be used, otherwise one of the other code values may be used.</summary>
                        Property PRV02 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (PRV02).</summary>
                        Property PRV03 As String
                    End Interface
                    '''<summary>Dependent Demographic Information</summary>
                    Public Interface DMG
                        Inherits ISegment

                        '''<summary>Date Time Period Format Qualifier</summary>
                        Property DMG01 As String
                        '''<summary>Use this date for the date of birth of the individual.;</summary>
                        Property DMG02 As String
                        '''<summary>Use this code to indicate the dependent's gender.</summary>
                        Property DMG03 As String
                    End Interface
                    '''<summary>Dependent Relationship</summary>
                    Public Interface INS
                        Inherits ISegment

                        '''<summary>Insured Indicator</summary>
                        Property INS01 As String
                        '''<summary>Individual Relationship Code</summary>
                        Property INS02 As String
                        '''<summary>Birth Sequence Number</summary>
                        Property INS17 As Decimal?
                    End Interface
                    '''<summary>Dependent Health Care Diagnosis Code</summary>
                    Public Interface HI
                        Inherits ISegment

                        '''<summary></summary>
                        Property HI01 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01.C022
                        '''<summary></summary>
                        Property HI02 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02.C022
                        '''<summary></summary>
                        Property HI03 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03.C022
                        '''<summary></summary>
                        Property HI04 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04.C022
                        '''<summary></summary>
                        Property HI05 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05.C022
                        '''<summary></summary>
                        Property HI06 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06.C022
                        '''<summary></summary>
                        Property HI07 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07.C022
                        '''<summary></summary>
                        Property HI08 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08.C022
                    End Interface
                    '''<summary>Dependent Date</summary>
                    Public Interface DTP
                        Inherits ISegment

                        '''<summary>Date Time Qualifier</summary>
                        Property DTP01 As String
                        '''<summary>Use this code to specify the format of the date(s) or time(s) that follow in the next data element.</summary>
                        Property DTP02 As String
                        '''<summary>Use this date for the date(s) as qualified by the preceding data elements.</summary>
                        Property DTP03 As String
                    End Interface
                End Namespace 'Loop2100D

                Namespace Loop2110D

                    '''<summary>Dependent Eligibility or Benefit Inquiry</summary>
                    Public Interface EQ
                        Inherits ISegment

                        '''<summary>Service Type Code</summary>
                        ReadOnly Property EQ01 As RepeatingSimpleElementList
                        '''<summary></summary>
                        Property EQ02 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02.C003
                        '''<summary></summary>
                        Property EQ05 As Madjic.Edi.Dom.DataElements.Composite.C004
                    End Interface
                    '''<summary>Dependent Eligibility or Benefit Additional Inquiry Information</summary>
                    Public Interface III
                        Inherits ISegment

                        '''<summary>Code List Qualifier Code</summary>
                        Property III01 As String
                        '''<summary>Use this element for codes identifying a place of service from code source 237. As a courtesy, the codes are listed below; however, the code list is thought to be complete at the time of publication of this implementation guideline. Since this list is subject to change, only codes contained in the document available from code source 237 are to be supported in this transaction and take precedence over any and all codes listed here.<br />&lt;T&gt;01&lt;T&gt;Pharmacy<br />&lt;T&gt;03&lt;T&gt;School<br />&lt;T&gt;04&lt;T&gt;Homeless Shelter<br />&lt;T&gt;05&lt;T&gt;Indian Health Service Free-standing Facility<br />&lt;T&gt;06&lt;T&gt;Indian Health Service Provider-based Facility<br />&lt;T&gt;07&lt;T&gt;Tribal 638 Free-standing Facility<br />&lt;T&gt;08&lt;T&gt;Tribal 638 Provider-based Facility<br />&lt;T&gt;11&lt;T&gt;Office<br />&lt;T&gt;12&lt;T&gt;Home<br />&lt;T&gt;13&lt;T&gt;Assisted Living Facility<br />&lt;T&gt;14&lt;T&gt;Group Home<br />&lt;T&gt;15&lt;T&gt;Mobile Unit<br />&lt;T&gt;20&lt;T&gt;Urgent Care Facility<br />&lt;T&gt;21&lt;T&gt;Inpatient Hospital<br />&lt;T&gt;22&lt;T&gt;Outpatient Hospital<br />&lt;T&gt;23&lt;T&gt;Emergency Room - Hospital<br />&lt;T&gt;24&lt;T&gt;Ambulatory Surgical Center<br />&lt;T&gt;25&lt;T&gt;Birthing Center<br />&lt;T&gt;26&lt;T&gt;Military Treatment Facility<br />&lt;T&gt;31&lt;T&gt;Skilled Nursing Facility<br />&lt;T&gt;32&lt;T&gt;Nursing Facility<br />&lt;T&gt;33&lt;T&gt;Custodial Care Facility<br />&lt;T&gt;34&lt;T&gt;Hospice<br />&lt;T&gt;41&lt;T&gt;Ambulance - Land<br />&lt;T&gt;42&lt;T&gt;Ambulance - Air or Water<br />&lt;T&gt;49&lt;T&gt;Independent Clinic<br />&lt;T&gt;50&lt;T&gt;Federally Qualified Health Center<br />&lt;T&gt;51&lt;T&gt;Inpatient Psychiatric Facility<br />&lt;T&gt;52&lt;T&gt;Psychiatric Facility - Partial Hospitalization<br />&lt;T&gt;53&lt;T&gt;Community Mental Health Center<br />&lt;T&gt;54&lt;T&gt;Intermediate Care Facility/Mentally Retarded<br />&lt;T&gt;55&lt;T&gt;Residential Substance Abuse Treatment Facility<br />&lt;T&gt;56&lt;T&gt;Psychiatric Residential Treatment Center<br />&lt;T&gt;57&lt;T&gt;Non-residential Substance Abuse Treatment Facility<br />&lt;T&gt;60&lt;T&gt;Mass Immunization Center<br />&lt;T&gt;61&lt;T&gt;Comprehensive Inpatient Rehabilitation Facility<br />&lt;T&gt;62&lt;T&gt;Comprehensive Outpatient Rehabilitation Facility<br />&lt;T&gt;65&lt;T&gt;End-Stage Renal Disease Treatment Facility<br />&lt;T&gt;71&lt;T&gt;Public Health Clinic<br />&lt;T&gt;72&lt;T&gt;Rural Health Clinic<br />&lt;T&gt;81&lt;T&gt;Independent Laboratory<br />&lt;T&gt;99&lt;T&gt;Other Place of Service</summary>
                        Property III02 As String
                    End Interface
                    '''<summary>Dependent Additional Information</summary>
                    Public Interface REF
                        Inherits ISegment

                        '''<summary>Reference Identification Qualifier</summary>
                        Property REF01 As String
                        '''<summary>Use this reference number as qualified by the preceding data element (REF01).;</summary>
                        Property REF02 As String
                    End Interface
                    '''<summary>Dependent Eligibility/Benefit Date</summary>
                    Public Interface DTP
                        Inherits ISegment

                        '''<summary>Date Time Qualifier</summary>
                        Property DTP01 As String
                        '''<summary>Use this code to specify the format of the date(s) or time(s) that follow in the next data element.</summary>
                        Property DTP02 As String
                        '''<summary>Use this date for the date(s) as qualified by the preceding data elements.</summary>
                        Property DTP03 As String
                    End Interface
                End Namespace 'Loop2110D

                '''<summary>Transaction Set Header</summary>
                Public Interface ST
                    Inherits ISegment

                    '''<summary>Transaction Set Identifier Code</summary>
                    Property ST01 As String
                    '''<summary>The transaction set control numbers in ST02 and SE02 must be identical. This unique number also aids in error resolution research. Start with the number, for example "0001", and increment from there. This number must be unique within a specific group and interchange, but can repeat in other groups and interchanges.</summary>
                    Property ST02 As String
                    '''<summary>This element must be populated with 005010X279A1.</summary>
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
                    '''<summary>Use this date for the date the transaction set was generated.</summary>
                    Property BHT04 As Date?
                    '''<summary>Use this time for the time the transaction set was generated.</summary>
                    Property BHT05 As TimeSpan?
                    '''<summary>Certain Medicaid programs support additional functionality for Spend Down. Use this code when necessary to further specify the type of transaction to a Medicaid program that supports this functionality.</summary>
                    Property BHT06 As String
                End Interface
                '''<summary>Transaction Set Trailer</summary>
                Public Interface SE
                    Inherits ISegment

                    '''<summary>Transaction Segment Count</summary>
                    Property SE01 As Decimal?
                    '''<summary>The transaction set control numbers in ST02 and SE02 must be identical. This unique number also aids in error resolution research. Start with a number, for example "0001", and increment from there. This number must be unique within a specific functional group (segments GS through GE) and interchange, but can repeat in other groups and interchanges.</summary>
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
                Namespace Loop2110C.EQ.EQ_02
                    '''<summary></summary>
                    Public Interface C003
                        '''<summary>Product or Service ID Qualifier</summary>
                        Property C003_01 As String
                        '''<summary>Use this number for the product/service ID as identified by the preceding data element (EQ02-1).</summary>
                        Property C003_02 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_03 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_04 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_05 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_06 As String
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
                Namespace Loop2110D.EQ.EQ_02
                    '''<summary></summary>
                    Public Interface C003
                        '''<summary>Product or Service ID Qualifier</summary>
                        Property C003_01 As String
                        '''<summary>Use this number for the product/service ID as identified by the preceding data element (EQ02-1).</summary>
                        Property C003_02 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_03 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_04 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_05 As String
                        '''<summary>Used when an information source supports or may be thought to support this high level of functionality if modifiers are required to further specify the service. If not supported, information source will process without this data element.</summary>
                        Property C003_06 As String
                    End Interface
                End Namespace
            End Namespace 'Composites

            Namespace Loops
                '''<summary>Information Source Level</summary>
                Public Interface Loop2000A
                    Inherits ILoop


                    '''<summary>Information Source Level</summary>
                    Property HL As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL

                    '''<summary>Information Source Name</summary>
                    Property Loop2100A As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A
                End Interface
                '''<summary>Information Source Name</summary>
                Public Interface Loop2100A
                    Inherits ILoop


                    '''<summary>Information Source Name</summary>
                    Property NM1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1
                End Interface
                '''<summary>Information Receiver Level</summary>
                Public Interface Loop2000B
                    Inherits ILoop


                    '''<summary>Information Receiver Level</summary>
                    Property HL As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL

                    '''<summary>Information Receiver Name</summary>
                    Property Loop2100B As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B
                End Interface
                '''<summary>Information Receiver Name</summary>
                Public Interface Loop2100B
                    Inherits ILoop


                    '''<summary>Information Receiver Name</summary>
                    Property NM1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1

                    '''<summary>Information Receiver Additional Identification</summary>
                    ReadOnly Property REF As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF, Madjic.Edi.Dom.Segments.REF)

                    '''<summary>Information Receiver Address</summary>
                    Property N3 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3

                    '''<summary>Information Receiver City, State, ZIP Code</summary>
                    Property N4 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4

                    '''<summary>Information Receiver Provider Information</summary>
                    Property PRV As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV
                End Interface
                '''<summary>Subscriber Level</summary>
                Public Interface Loop2000C
                    Inherits ILoop


                    '''<summary>Subscriber Level</summary>
                    Property HL As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL

                    '''<summary>Subscriber Trace Number</summary>
                    ReadOnly Property TRN As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN, Madjic.Edi.Dom.Segments.TRN)

                    '''<summary>Subscriber Name</summary>
                    Property Loop2100C As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C
                End Interface
                '''<summary>Subscriber Name</summary>
                Public Interface Loop2100C
                    Inherits ILoop


                    '''<summary>Subscriber Name</summary>
                    Property NM1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1

                    '''<summary>Subscriber Additional Identification</summary>
                    ReadOnly Property REF As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF, Madjic.Edi.Dom.Segments.REF)

                    '''<summary>Subscriber Address</summary>
                    Property N3 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3

                    '''<summary>Subscriber City, State, ZIP Code</summary>
                    Property N4 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4

                    '''<summary>Provider Information</summary>
                    Property PRV As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV

                    '''<summary>Subscriber Demographic Information</summary>
                    Property DMG As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG

                    '''<summary>Multiple Birth Sequence Number</summary>
                    Property INS As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS

                    '''<summary>Subscriber Health Care Diagnosis Code</summary>
                    Property HI As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI

                    '''<summary>Subscriber Date</summary>
                    ReadOnly Property DTP As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP, Madjic.Edi.Dom.Segments.DTP)

                    '''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
                    ReadOnly Property Loop2110C As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)
                End Interface
                '''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
                Public Interface Loop2110C
                    Inherits ILoop


                    '''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
                    Property EQ As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ

                    '''<summary>Subscriber Spend Down Amount</summary>
                    Property AMT As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT

                    '''<summary>Subscriber Spend Down Total Billed Amount</summary>
                    Property AMT_1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1

                    '''<summary>Subscriber Eligibility or Benefit Additional Inquiry Information</summary>
                    Property III As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III

                    '''<summary>Subscriber Additional Information</summary>
                    Property REF As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF

                    '''<summary>Subscriber Eligibility/Benefit Date</summary>
                    Property DTP As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP
                End Interface
                '''<summary>Dependent Level</summary>
                Public Interface Loop2000D
                    Inherits ILoop


                    '''<summary>Dependent Level</summary>
                    Property HL As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL

                    '''<summary>Dependent Trace Number</summary>
                    ReadOnly Property TRN As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN, Madjic.Edi.Dom.Segments.TRN)

                    '''<summary>Dependent Name</summary>
                    Property Loop2100D As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D
                End Interface
                '''<summary>Dependent Name</summary>
                Public Interface Loop2100D
                    Inherits ILoop


                    '''<summary>Dependent Name</summary>
                    Property NM1 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1

                    '''<summary>Dependent Additional Identification</summary>
                    ReadOnly Property REF As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF, Madjic.Edi.Dom.Segments.REF)

                    '''<summary>Dependent Address</summary>
                    Property N3 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3

                    '''<summary>Dependent City, State, ZIP Code</summary>
                    Property N4 As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4

                    '''<summary>Provider Information</summary>
                    Property PRV As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV

                    '''<summary>Dependent Demographic Information</summary>
                    Property DMG As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG

                    '''<summary>Dependent Relationship</summary>
                    Property INS As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS

                    '''<summary>Dependent Health Care Diagnosis Code</summary>
                    Property HI As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI

                    '''<summary>Dependent Date</summary>
                    ReadOnly Property DTP As SegmentSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP, Madjic.Edi.Dom.Segments.DTP)

                    '''<summary>Dependent Eligibility or Benefit Inquiry</summary>
                    ReadOnly Property Loop2110D As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2110)
                End Interface
                '''<summary>Dependent Eligibility or Benefit Inquiry</summary>
                Public Interface Loop2110D
                    Inherits ILoop


                    '''<summary>Dependent Eligibility or Benefit Inquiry</summary>
                    Property EQ As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ

                    '''<summary>Dependent Eligibility or Benefit Additional Inquiry Information</summary>
                    Property III As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III

                    '''<summary>Dependent Additional Information</summary>
                    Property REF As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF

                    '''<summary>Dependent Eligibility/Benefit Date</summary>
                    Property DTP As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP
                End Interface

            End Namespace 'Loops

            '''<summary>Health Care Eligibility Benefit Inquiry</summary>
            '''<remarks>
            '''<para>This X12 Transaction Set contains the format and establishes the data contents of the Eligibility, Coverage or Benefit Inquiry Transaction Set (270) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to inquire about the eligibility, coverages or benefits associated with a benefit plan, employer, plan sponsor, subscriber or a dependent under the subscriber's policy. The transaction set is intended to be used by all lines of insurance such as Health, Life, and Property and Casualty.</para>
            '''</remarks>
            Public Interface TransactionSet

                '''<summary>Transaction Set Header</summary>
                Property ST As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST

                '''<summary>Beginning of Hierarchical Transaction</summary>
                Property BHT As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT

                '''<summary>Information Source Level</summary>
                ReadOnly Property Loop2000A As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)

                '''<summary>Information Receiver Level</summary>
                ReadOnly Property Loop2000B As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)

                '''<summary>Subscriber Level</summary>
                ReadOnly Property Loop2000C As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)

                '''<summary>Dependent Level</summary>
                ReadOnly Property Loop2000D As LoopSubsetContainer(Of Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D, Madjic.Edi.Dom.Transactions.Transaction270.Loops.Loop2000)

                '''<summary>Transaction Set Trailer</summary>
                Property SE As Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE
            End Interface
        End Namespace 'Transaction270_B1
    End Namespace 'Transaction270
End Namespace
