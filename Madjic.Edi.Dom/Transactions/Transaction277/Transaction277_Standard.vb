Namespace Transactions.Transaction277

    Partial Friend Class Standard_Obj
        Inherits TransactionSet
        Implements Standard, Transaction277_A1.TransactionSet
        Friend Sub New(versionCode As String)
            Me.New(String.Empty, versionCode)
        End Sub

        Friend Sub New(controlNumber As String, versionCode As String)
            MyBase.New("HN", versionCode)

            Children.AddRange({New Segments.ST_Obj,
                                                    CType(Nothing, Segments.BHT_Obj),
                                                    New SegmentContainer(Of Segments.REF)(10, 1, 300),
                                                    New LoopContainer(Of Loops.Loop1000)(0, 1, 400),
                                                    New LoopContainer(Of Loops.Loop2000)(0, 2, 100),
                                                    New Segments.SE_Obj})

            ST_Obj.ST01 = "277"
            ST_Obj.ST02 = controlNumber
            ST_Obj.ST03 = versionCode

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
                                    New ReaderState(1, "BHT", ReadAction.PopulateSegment, 2, False),
                                    New ReaderState(2, "REF", ReadAction.PopulateSegment, 3, False),
                                    New ReaderState(3, "REF", ReadAction.PopulateSegment, 3, False),
                                    New ReaderState(2, "NM1", ReadAction.PopulateLoop, 5, False),
                                    New ReaderState(3, "NM1", ReadAction.PopulateLoop, 5, False),
                                    New ReaderState(5, "NM1", ReadAction.PopulateLoop, 5, False),
                                    New ReaderState(2, "HL", ReadAction.PopulateLoop, 7, False),
                                    New ReaderState(3, "HL", ReadAction.PopulateLoop, 7, False),
                                    New ReaderState(5, "HL", ReadAction.PopulateLoop, 7, False),
                                    New ReaderState(7, "HL", ReadAction.PopulateLoop, 7, False),
                                    New ReaderState(7, "SE", ReadAction.PopulateSegment, 9, False)})

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
                If CompareKey(S2.ST01, ";277;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 1
                    Seg.SetSequence = 36
                End If
            ElseIf String.Compare(SegmentName, "BHT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.BHT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                BHT_Obj = Seg
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                SE_Obj = Seg
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop1000_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop1000_Obj.Add(NewLoop)
                Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
            ElseIf String.Compare(args.DataSegment.SegmentID, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2000_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(2)
                Loop2000_Obj.Add(NewLoop)
                If CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000A"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000B"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";19;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_277A1", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000E"
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

        Private Property ST_IFace_Transaction277_A1 As Transaction277_A1.Segments.ST Implements Transaction277_A1.TransactionSet.ST
            Get
                Return CType(Children(0), Transaction277_A1.Segments.ST)
            End Get
            Set(value As Transaction277_A1.Segments.ST)
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

        Private Property BHT_IFace_Transaction277_A1 As Transaction277_A1.Segments.BHT Implements Transaction277_A1.TransactionSet.BHT
            Get
                Return CType(Children(1), Transaction277_A1.Segments.BHT)
            End Get
            Set(value As Transaction277_A1.Segments.BHT)
                Children(1) = value
            End Set
        End Property
        Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Standard.REF
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.REF))
            End Get
        End Property

        Friend ReadOnly Property Loop1000_Obj As LoopContainer(Of Loops.Loop1000) Implements Standard.Loop1000
            Get
                Return CType(Children(3), LoopContainer(Of Loops.Loop1000))
            End Get
        End Property

        Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Loops.Loop2000) Implements Standard.Loop2000
            Get
                Return CType(Children(4), LoopContainer(Of Loops.Loop2000))
            End Get
        End Property

        Private Loop2000ASubset_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000A, Loops.Loop2000)
        Private ReadOnly Property Loop2000A_Obj_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000A, Loops.Loop2000) Implements Transaction277_A1.TransactionSet.Loop2000A
            Get
                If Loop2000ASubset_Transaction277_A1 Is Nothing Then
                    Loop2000ASubset_Transaction277_A1 = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000A, Loops.Loop2000)(Children(4), 0, 2, 36)
                End If

                Return Loop2000ASubset_Transaction277_A1
            End Get
        End Property
        Private Loop2000BSubset_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000B, Loops.Loop2000)
        Private ReadOnly Property Loop2000B_Obj_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000B, Loops.Loop2000) Implements Transaction277_A1.TransactionSet.Loop2000B
            Get
                If Loop2000BSubset_Transaction277_A1 Is Nothing Then
                    Loop2000BSubset_Transaction277_A1 = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000B, Loops.Loop2000)(Children(4), 0, 3, 36)
                End If

                Return Loop2000BSubset_Transaction277_A1
            End Get
        End Property
        Private Loop2000CSubset_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000C, Loops.Loop2000)
        Private ReadOnly Property Loop2000C_Obj_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000C, Loops.Loop2000) Implements Transaction277_A1.TransactionSet.Loop2000C
            Get
                If Loop2000CSubset_Transaction277_A1 Is Nothing Then
                    Loop2000CSubset_Transaction277_A1 = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000C, Loops.Loop2000)(Children(4), 0, 4, 36)
                End If

                Return Loop2000CSubset_Transaction277_A1
            End Get
        End Property
        Private Loop2000DSubset_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000D, Loops.Loop2000)
        Private ReadOnly Property Loop2000D_Obj_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000D, Loops.Loop2000) Implements Transaction277_A1.TransactionSet.Loop2000D
            Get
                If Loop2000DSubset_Transaction277_A1 Is Nothing Then
                    Loop2000DSubset_Transaction277_A1 = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000D, Loops.Loop2000)(Children(4), 0, 5, 36)
                End If

                Return Loop2000DSubset_Transaction277_A1
            End Get
        End Property
        Private Loop2000ESubset_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000E, Loops.Loop2000)
        Private ReadOnly Property Loop2000E_Obj_Transaction277_A1 As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000E, Loops.Loop2000) Implements Transaction277_A1.TransactionSet.Loop2000E
            Get
                If Loop2000ESubset_Transaction277_A1 Is Nothing Then
                    Loop2000ESubset_Transaction277_A1 = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2000E, Loops.Loop2000)(Children(4), 0, 6, 36)
                End If

                Return Loop2000ESubset_Transaction277_A1
            End Get
        End Property
        Friend Property SE_Obj As Segments.SE_Obj
            Get
                Return CType(Children(5), Segments.SE_Obj)
            End Get
            Set(value As Segments.SE_Obj)
                Children(5) = value
            End Set
        End Property

        Private Property SE_Std As Segments.SE Implements Standard.SE
            Get
                Return CType(Children(5), Segments.SE_Obj)
            End Get
            Set(value As Segments.SE)
                Children(5) = value
            End Set
        End Property

        Private Property SE_IFace_Transaction277_A1 As Transaction277_A1.Segments.SE Implements Transaction277_A1.TransactionSet.SE
            Get
                Return CType(Children(5), Transaction277_A1.Segments.SE)
            End Get
            Set(value As Transaction277_A1.Segments.SE)
                Children(5) = value
            End Set
        End Property
    End Class

    Partial Friend Class Loop1000_Obj
        Inherits LoopBase
        Implements Loops.Loop1000
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.NM1_Obj),
                                                        New SegmentContainer(Of Segments.N2)(2, 1, 500),
                                                        New SegmentContainer(Of Segments.N3)(2, 1, 600),
                                                        CType(Nothing, Segments.N4_Obj),
                                                        New SegmentContainer(Of Segments.REF)(2, 1, 800),
                                                        CType(Nothing, Segments.PER_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "N2", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "N2", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(1, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(4, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(1, "N4", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(2, "N4", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(4, "N4", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(1, "REF", ReadAction.PopulateSegment, 7, False),
                                        New ReaderState(2, "REF", ReadAction.PopulateSegment, 7, False),
                                        New ReaderState(4, "REF", ReadAction.PopulateSegment, 7, False),
                                        New ReaderState(6, "REF", ReadAction.PopulateSegment, 7, False),
                                        New ReaderState(7, "REF", ReadAction.PopulateSegment, 7, False),
                                        New ReaderState(1, "PER", ReadAction.PopulateSegment, 9, False),
                                        New ReaderState(2, "PER", ReadAction.PopulateSegment, 9, False),
                                        New ReaderState(4, "PER", ReadAction.PopulateSegment, 9, False),
                                        New ReaderState(6, "PER", ReadAction.PopulateSegment, 9, False),
                                        New ReaderState(7, "PER", ReadAction.PopulateSegment, 9, False)})

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
            ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N2_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj = Seg
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

        Private Property NM1_Std As Segments.NM1 Implements Loops.Loop1000.NM1
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1)
                Children(0) = value
            End Set
        End Property

        Friend ReadOnly Property N2_Obj As SegmentContainer(Of Segments.N2) Implements Loops.Loop1000.N2
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.N2))
            End Get
        End Property

        Friend ReadOnly Property N3_Obj As SegmentContainer(Of Segments.N3) Implements Loops.Loop1000.N3
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.N3))
            End Get
        End Property

        Friend Property N4_Obj As Segments.N4_Obj
            Get
                Return CType(Children(3), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property N4_Std As Segments.N4 Implements Loops.Loop1000.N4
            Get
                Return CType(Children(3), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(3) = value
            End Set
        End Property

        Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Loops.Loop1000.REF
            Get
                Return CType(Children(4), SegmentContainer(Of Segments.REF))
            End Get
        End Property

        Friend Property PER_Obj As Segments.PER_Obj
            Get
                Return CType(Children(5), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER_Obj)
                Children(5) = value
            End Set
        End Property

        Private Property PER_Std As Segments.PER Implements Loops.Loop1000.PER
            Get
                Return CType(Children(5), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER)
                Children(5) = value
            End Set
        End Property


    End Class
    Partial Friend Class Loop2000_Obj
        Inherits LoopBase
        Implements Loops.Loop2000,
                                            Transaction277_A1.Loops.Loop2000A,
                                            Transaction277_A1.Loops.Loop2000B,
                                            Transaction277_A1.Loops.Loop2000C,
                                            Transaction277_A1.Loops.Loop2000D,
                                            Transaction277_A1.Loops.Loop2000E
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.HL_Obj),
                                                        CType(Nothing, Segments.SBR_Obj),
                                                        CType(Nothing, Segments.PAT_Obj),
                                                        CType(Nothing, Segments.DMG_Obj),
                                                        New LoopContainer(Of Loops.Loop2100)(0, 2, 500),
                                                        New LoopContainer(Of Loops.Loop2200)(0, 2, 900)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "HL", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "SBR", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(1, "PAT", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(2, "PAT", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(1, "DMG", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "DMG", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(3, "DMG", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(1, "NM1", ReadAction.PopulateLoop, 5, False),
                                        New ReaderState(2, "NM1", ReadAction.PopulateLoop, 5, False),
                                        New ReaderState(3, "NM1", ReadAction.PopulateLoop, 5, False),
                                        New ReaderState(4, "NM1", ReadAction.PopulateLoop, 5, False),
                                        New ReaderState(5, "NM1", ReadAction.PopulateLoop, 5, False),
                                        New ReaderState(1, "TRN", ReadAction.PopulateLoop, 7, False),
                                        New ReaderState(2, "TRN", ReadAction.PopulateLoop, 7, False),
                                        New ReaderState(3, "TRN", ReadAction.PopulateLoop, 7, False),
                                        New ReaderState(4, "TRN", ReadAction.PopulateLoop, 7, False),
                                        New ReaderState(5, "TRN", ReadAction.PopulateLoop, 7, False),
                                        New ReaderState(7, "TRN", ReadAction.PopulateLoop, 7, False)})

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
                If CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_277A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 2
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_277A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";19;") AndAlso String.Compare(args.Implementation, "_277A1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_277A1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 36
                ElseIf CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_277A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 36
                End If
            ElseIf String.Compare(SegmentName, "SBR", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.SBR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                SBR_Obj = Seg
            ElseIf String.Compare(SegmentName, "PAT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PAT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PAT_Obj = Seg
            ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DMG_Obj = Seg
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
                If CompareKey(LoopKey, ";PR;") AndAlso String.Compare(args.Implementation, "_277A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000A__2100A"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";41;") AndAlso String.Compare(args.Implementation, "_277A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000B__2100B"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";1P;") AndAlso String.Compare(args.Implementation, "_277A1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000C__2100C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_277A1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000D__2100D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf CompareKey(LoopKey, ";QC;") AndAlso String.Compare(args.Implementation, "_277A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000E__2100E"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            ElseIf String.Compare(args.DataSegment.SegmentID, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2200_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2200_Obj.Add(NewLoop)
                If String.Compare(args.Implementation, "_277A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000B__2200B"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_277A1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000C__2200C"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_277A1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000D__2200D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_277A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000E__2200E"
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

        Private Property HL_IFace_Loop2000A_Obj As Transaction277_A1.Segments.Loop2000A.HL Implements Transaction277_A1.Loops.Loop2000A.HL
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2000A.HL)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2000A.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_1_Loop2000B_Obj As Transaction277_A1.Segments.Loop2000B.HL Implements Transaction277_A1.Loops.Loop2000B.HL
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2000B.HL)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2000B.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_2_Loop2000C_Obj As Transaction277_A1.Segments.Loop2000C.HL Implements Transaction277_A1.Loops.Loop2000C.HL
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2000C.HL)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2000C.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_3_Loop2000D_Obj As Transaction277_A1.Segments.Loop2000D.HL Implements Transaction277_A1.Loops.Loop2000D.HL
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2000D.HL)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2000D.HL)
                Children(0) = value
            End Set
        End Property
        Private Property HL_IFace_4_Loop2000E_Obj As Transaction277_A1.Segments.Loop2000E.HL Implements Transaction277_A1.Loops.Loop2000E.HL
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2000E.HL)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2000E.HL)
                Children(0) = value
            End Set
        End Property
        Friend Property SBR_Obj As Segments.SBR_Obj
            Get
                Return CType(Children(1), Segments.SBR_Obj)
            End Get
            Set(value As Segments.SBR_Obj)
                Children(1) = value
            End Set
        End Property

        Private Property SBR_Std As Segments.SBR Implements Loops.Loop2000.SBR
            Get
                Return CType(Children(1), Segments.SBR_Obj)
            End Get
            Set(value As Segments.SBR)
                Children(1) = value
            End Set
        End Property

        Friend Property PAT_Obj As Segments.PAT_Obj
            Get
                Return CType(Children(2), Segments.PAT_Obj)
            End Get
            Set(value As Segments.PAT_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property PAT_Std As Segments.PAT Implements Loops.Loop2000.PAT
            Get
                Return CType(Children(2), Segments.PAT_Obj)
            End Get
            Set(value As Segments.PAT)
                Children(2) = value
            End Set
        End Property

        Friend Property DMG_Obj As Segments.DMG_Obj
            Get
                Return CType(Children(3), Segments.DMG_Obj)
            End Get
            Set(value As Segments.DMG_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property DMG_Std As Segments.DMG Implements Loops.Loop2000.DMG
            Get
                Return CType(Children(3), Segments.DMG_Obj)
            End Get
            Set(value As Segments.DMG)
                Children(3) = value
            End Set
        End Property

        Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Loops.Loop2100) Implements Loops.Loop2000.Loop2100
            Get
                Return CType(Children(4), LoopContainer(Of Loops.Loop2100))
            End Get
        End Property

        Private Loop2100ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100A, Loops.Loop2100)
        Private Property Loop2100A_IFace_Loop2000A_Obj As Transaction277_A1.Loops.Loop2100A Implements Transaction277_A1.Loops.Loop2000A.Loop2100A
            Get
                If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                    Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100A, Loops.Loop2100)(Children(4), 1, 2, 180)
                End If

                If Loop2100ASubset_Loop2000A_Obj.Count > 0 Then
                    Return Loop2100ASubset_Loop2000A_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2100A)
                If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
                    Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100A, Loops.Loop2100)(Children(4), 1, 2, 180)
                End If

                If Loop2100ASubset_Loop2000A_Obj.Count = 0 Then
                    Loop2100ASubset_Loop2000A_Obj.Add(value)
                Else
                    Loop2100ASubset_Loop2000A_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100B, Loops.Loop2100)
        Private Property Loop2100B_IFace_Loop2000B_Obj As Transaction277_A1.Loops.Loop2100B Implements Transaction277_A1.Loops.Loop2000B.Loop2100B
            Get
                If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100B, Loops.Loop2100)(Children(4), 1, 3, 180)
                End If

                If Loop2100BSubset_Loop2000B_Obj.Count > 0 Then
                    Return Loop2100BSubset_Loop2000B_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2100B)
                If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100B, Loops.Loop2100)(Children(4), 1, 3, 180)
                End If

                If Loop2100BSubset_Loop2000B_Obj.Count = 0 Then
                    Loop2100BSubset_Loop2000B_Obj.Add(value)
                Else
                    Loop2100BSubset_Loop2000B_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100C, Loops.Loop2100)
        Private ReadOnly Property Loop2100C_Obj_Loop2000C_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100C, Loops.Loop2100) Implements Transaction277_A1.Loops.Loop2000C.Loop2100C
            Get
                If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
                    Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100C, Loops.Loop2100)(Children(4), 2, 4, 180)
                End If

                Return Loop2100CSubset_Loop2000C_Obj
            End Get
        End Property
        Private Loop2100DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100D, Loops.Loop2100)
        Private Property Loop2100D_IFace_Loop2000D_Obj As Transaction277_A1.Loops.Loop2100D Implements Transaction277_A1.Loops.Loop2000D.Loop2100D
            Get
                If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                    Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100D, Loops.Loop2100)(Children(4), 1, 5, 180)
                End If

                If Loop2100DSubset_Loop2000D_Obj.Count > 0 Then
                    Return Loop2100DSubset_Loop2000D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2100D)
                If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
                    Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100D, Loops.Loop2100)(Children(4), 1, 5, 180)
                End If

                If Loop2100DSubset_Loop2000D_Obj.Count = 0 Then
                    Loop2100DSubset_Loop2000D_Obj.Add(value)
                Else
                    Loop2100DSubset_Loop2000D_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2100ESubset_Loop2000E_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100E, Loops.Loop2100)
        Private Property Loop2100E_IFace_Loop2000E_Obj As Transaction277_A1.Loops.Loop2100E Implements Transaction277_A1.Loops.Loop2000E.Loop2100E
            Get
                If Loop2100ESubset_Loop2000E_Obj Is Nothing Then
                    Loop2100ESubset_Loop2000E_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100E, Loops.Loop2100)(Children(4), 1, 6, 180)
                End If

                If Loop2100ESubset_Loop2000E_Obj.Count > 0 Then
                    Return Loop2100ESubset_Loop2000E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2100E)
                If Loop2100ESubset_Loop2000E_Obj Is Nothing Then
                    Loop2100ESubset_Loop2000E_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2100E, Loops.Loop2100)(Children(4), 1, 6, 180)
                End If

                If Loop2100ESubset_Loop2000E_Obj.Count = 0 Then
                    Loop2100ESubset_Loop2000E_Obj.Add(value)
                Else
                    Loop2100ESubset_Loop2000E_Obj(0) = value
                End If
            End Set
        End Property
        Friend ReadOnly Property Loop2200_Obj As LoopContainer(Of Loops.Loop2200) Implements Loops.Loop2000.Loop2200
            Get
                Return CType(Children(5), LoopContainer(Of Loops.Loop2200))
            End Get
        End Property

        Private Loop2200BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200B, Loops.Loop2200)
        Private Property Loop2200B_IFace_Loop2000B_Obj As Transaction277_A1.Loops.Loop2200B Implements Transaction277_A1.Loops.Loop2000B.Loop2200B
            Get
                If Loop2200BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2200BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200B, Loops.Loop2200)(Children(5), 1, 3, 324)
                End If

                If Loop2200BSubset_Loop2000B_Obj.Count > 0 Then
                    Return Loop2200BSubset_Loop2000B_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2200B)
                If Loop2200BSubset_Loop2000B_Obj Is Nothing Then
                    Loop2200BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200B, Loops.Loop2200)(Children(5), 1, 3, 324)
                End If

                If Loop2200BSubset_Loop2000B_Obj.Count = 0 Then
                    Loop2200BSubset_Loop2000B_Obj.Add(value)
                Else
                    Loop2200BSubset_Loop2000B_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2200CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200C, Loops.Loop2200)
        Private Property Loop2200C_IFace_Loop2000C_Obj As Transaction277_A1.Loops.Loop2200C Implements Transaction277_A1.Loops.Loop2000C.Loop2200C
            Get
                If Loop2200CSubset_Loop2000C_Obj Is Nothing Then
                    Loop2200CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200C, Loops.Loop2200)(Children(5), 1, 4, 324)
                End If

                If Loop2200CSubset_Loop2000C_Obj.Count > 0 Then
                    Return Loop2200CSubset_Loop2000C_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Loops.Loop2200C)
                If Loop2200CSubset_Loop2000C_Obj Is Nothing Then
                    Loop2200CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200C, Loops.Loop2200)(Children(5), 1, 4, 324)
                End If

                If Loop2200CSubset_Loop2000C_Obj.Count = 0 Then
                    Loop2200CSubset_Loop2000C_Obj.Add(value)
                Else
                    Loop2200CSubset_Loop2000C_Obj(0) = value
                End If
            End Set
        End Property
        Private Loop2200DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200D, Loops.Loop2200)
        Private ReadOnly Property Loop2200D_Obj_Loop2000D_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200D, Loops.Loop2200) Implements Transaction277_A1.Loops.Loop2000D.Loop2200D
            Get
                If Loop2200DSubset_Loop2000D_Obj Is Nothing Then
                    Loop2200DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200D, Loops.Loop2200)(Children(5), 0, 5, 324)
                End If

                Return Loop2200DSubset_Loop2000D_Obj
            End Get
        End Property
        Private Loop2200ESubset_Loop2000E_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200E, Loops.Loop2200)
        Private ReadOnly Property Loop2200E_Obj_Loop2000E_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200E, Loops.Loop2200) Implements Transaction277_A1.Loops.Loop2000E.Loop2200E
            Get
                If Loop2200ESubset_Loop2000E_Obj Is Nothing Then
                    Loop2200ESubset_Loop2000E_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2200E, Loops.Loop2200)(Children(5), 0, 6, 324)
                End If

                Return Loop2200ESubset_Loop2000E_Obj
            End Get
        End Property

    End Class
    Partial Friend Class Loop2100_Obj
        Inherits LoopBase
        Implements Loops.Loop2100,
                                            Transaction277_A1.Loops.Loop2100A,
                                            Transaction277_A1.Loops.Loop2100B,
                                            Transaction277_A1.Loops.Loop2100C,
                                            Transaction277_A1.Loops.Loop2100D,
                                            Transaction277_A1.Loops.Loop2100E
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.NM1_Obj),
                                                        New SegmentContainer(Of Segments.N3)(2, 2, 600),
                                                        CType(Nothing, Segments.N4_Obj),
                                                        CType(Nothing, Segments.PER_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "N3", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "N3", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(1, "N4", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "N4", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(1, "PER", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(2, "PER", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(4, "PER", ReadAction.PopulateSegment, 5, False)})

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
                If CompareKey(S2.NM101, ";PR;") AndAlso String.Compare(args.Implementation, "_277A1__2000A__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 2
                    Seg.SetSequence = 180
                ElseIf CompareKey(S2.NM101, ";41;") AndAlso String.Compare(args.Implementation, "_277A1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 3
                    Seg.SetSequence = 180
                ElseIf CompareKey(S2.NM101, ";1P;") AndAlso String.Compare(args.Implementation, "_277A1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 4
                    Seg.SetSequence = 180
                ElseIf CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 180
                ElseIf CompareKey(S2.NM101, ";QC;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2100E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 180
                End If
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj = Seg
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

        Private Property NM1_Std As Segments.NM1 Implements Loops.Loop2100.NM1
            Get
                Return CType(Children(0), Segments.NM1_Obj)
            End Get
            Set(value As Segments.NM1)
                Children(0) = value
            End Set
        End Property

        Private Property NM1_IFace_Loop2100A_Obj As Transaction277_A1.Segments.Loop2100A.NM1 Implements Transaction277_A1.Loops.Loop2100A.NM1
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2100A.NM1)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100A.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_1_Loop2100B_Obj As Transaction277_A1.Segments.Loop2100B.NM1 Implements Transaction277_A1.Loops.Loop2100B.NM1
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2100B.NM1)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100B.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_2_Loop2100C_Obj As Transaction277_A1.Segments.Loop2100C.NM1 Implements Transaction277_A1.Loops.Loop2100C.NM1
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2100C.NM1)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100C.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_3_Loop2100D_Obj As Transaction277_A1.Segments.Loop2100D.NM1 Implements Transaction277_A1.Loops.Loop2100D.NM1
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2100D.NM1)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100D.NM1)
                Children(0) = value
            End Set
        End Property
        Private Property NM1_IFace_4_Loop2100E_Obj As Transaction277_A1.Segments.Loop2100E.NM1 Implements Transaction277_A1.Loops.Loop2100E.NM1
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2100E.NM1)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100E.NM1)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property N3_Obj As SegmentContainer(Of Segments.N3) Implements Loops.Loop2100.N3
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.N3))
            End Get
        End Property

        Friend Property N4_Obj As Segments.N4_Obj
            Get
                Return CType(Children(2), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property N4_Std As Segments.N4 Implements Loops.Loop2100.N4
            Get
                Return CType(Children(2), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(2) = value
            End Set
        End Property

        Friend Property PER_Obj As Segments.PER_Obj
            Get
                Return CType(Children(3), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property PER_Std As Segments.PER Implements Loops.Loop2100.PER
            Get
                Return CType(Children(3), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER)
                Children(3) = value
            End Set
        End Property

        Private Property PER_IFace_Loop2100A_Obj As Transaction277_A1.Segments.Loop2100A.PER Implements Transaction277_A1.Loops.Loop2100A.PER
            Get
                Return CType(Children(3), Transaction277_A1.Segments.Loop2100A.PER)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2100A.PER)
                Children(3) = value
            End Set
        End Property

    End Class
    Partial Friend Class Loop2200_Obj
        Inherits LoopBase
        Implements Loops.Loop2200,
                                            Transaction277_A1.Loops.Loop2200B,
                                            Transaction277_A1.Loops.Loop2200C,
                                            Transaction277_A1.Loops.Loop2200D,
                                            Transaction277_A1.Loops.Loop2200E
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.TRN_Obj),
                                                        New SegmentContainer(Of Segments.STC)(0, 2, 1000),
                                                        New SegmentContainer(Of Segments.REF)(9, 2, 1100),
                                                        New SegmentContainer(Of Segments.DTP)(2, 2, 1200),
                                                        New SegmentContainer(Of Segments.QTY)(5, 2, 1210),
                                                        New SegmentContainer(Of Segments.AMT)(5, 2, 1220),
                                                        New LoopContainer(Of Loops.Loop2210)(0, 2, 1300),
                                                        New LoopContainer(Of Loops.Loop2220)(0, 2, 1800)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "TRN", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "STC", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "STC", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(4, "REF", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "DTP", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(4, "DTP", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(6, "DTP", ReadAction.PopulateSegment, 6, False),
                                        New ReaderState(2, "QTY", ReadAction.PopulateSegment, 8, False),
                                        New ReaderState(4, "QTY", ReadAction.PopulateSegment, 8, False),
                                        New ReaderState(6, "QTY", ReadAction.PopulateSegment, 8, False),
                                        New ReaderState(8, "QTY", ReadAction.PopulateSegment, 8, False),
                                        New ReaderState(2, "AMT", ReadAction.PopulateSegment, 10, False),
                                        New ReaderState(4, "AMT", ReadAction.PopulateSegment, 10, False),
                                        New ReaderState(6, "AMT", ReadAction.PopulateSegment, 10, False),
                                        New ReaderState(8, "AMT", ReadAction.PopulateSegment, 10, False),
                                        New ReaderState(10, "AMT", ReadAction.PopulateSegment, 10, False),
                                        New ReaderState(2, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(4, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(6, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(8, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(10, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(12, "PWK", ReadAction.PopulateLoop, 12, False),
                                        New ReaderState(2, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(4, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(6, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(8, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(10, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(12, "SVC", ReadAction.PopulateLoop, 14, False),
                                        New ReaderState(14, "SVC", ReadAction.PopulateLoop, 14, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                TRN_Obj = Seg
            ElseIf String.Compare(SegmentName, "STC", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.STC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                STC_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.REF_Obj)
                If CompareKey(S2.REF01, ";1K;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 37
                ElseIf CompareKey(S2.REF01, ";BLT;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 2629
                ElseIf CompareKey(S2.REF01, ";EJ;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 238501
                ElseIf CompareKey(S2.REF01, ";XZ;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 6517
                ElseIf CompareKey(S2.REF01, ";VV;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 239797
                ElseIf CompareKey(S2.REF01, ";D9;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 7813
                ElseIf CompareKey(S2.REF01, ";1K;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 37
                ElseIf CompareKey(S2.REF01, ";BLT;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 2629
                ElseIf CompareKey(S2.REF01, ";EJ;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 238501
                ElseIf CompareKey(S2.REF01, ";XZ;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 6517
                ElseIf CompareKey(S2.REF01, ";VV;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 239797
                ElseIf CompareKey(S2.REF01, ";D9;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 7813
                End If
            ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DTP_Obj.Add(Seg)
                Dim S2 = CType(Seg, Segments.DTP_Obj)
                If CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 73
                ElseIf CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 73
                End If
            ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                QTY_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                AMT_Obj.Add(Seg)
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "PWK", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2210_Obj
                Dim LoopKey As String = String.Format("{0}:{1}", args.DataSegment.ToStringValue(0), args.DataSegment.ToStringValue(1))
                Loop2210_Obj.Add(NewLoop)
                Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
            ElseIf String.Compare(args.DataSegment.SegmentID, "SVC", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2220_Obj
                Dim LoopKey As String = args.DataSegment.ToStringValue(0)
                Loop2220_Obj.Add(NewLoop)
                If String.Compare(args.Implementation, "_277A1__2000D__2200D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000D__2200D__2220D"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                ElseIf String.Compare(args.Implementation, "_277A1__2000E__2200E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    args.Implementation = "_277A1__2000E__2200E__2220E"
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                Else
                    Await NewLoop.ReadAsync(args).ConfigureAwait(False)
                End If
            End If
            args.Implementation = Temp
        End Function
        Friend Property TRN_Obj As Segments.TRN_Obj
            Get
                Return CType(Children(0), Segments.TRN_Obj)
            End Get
            Set(value As Segments.TRN_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property TRN_Std As Segments.TRN Implements Loops.Loop2200.TRN
            Get
                Return CType(Children(0), Segments.TRN_Obj)
            End Get
            Set(value As Segments.TRN)
                Children(0) = value
            End Set
        End Property

        Private Property TRN_IFace_Loop2200B_Obj As Transaction277_A1.Segments.Loop2200B.TRN Implements Transaction277_A1.Loops.Loop2200B.TRN
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2200B.TRN)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200B.TRN)
                Children(0) = value
            End Set
        End Property
        Private Property TRN_IFace_1_Loop2200C_Obj As Transaction277_A1.Segments.Loop2200C.TRN Implements Transaction277_A1.Loops.Loop2200C.TRN
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2200C.TRN)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200C.TRN)
                Children(0) = value
            End Set
        End Property
        Private Property TRN_IFace_2_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.TRN Implements Transaction277_A1.Loops.Loop2200D.TRN
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2200D.TRN)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.TRN)
                Children(0) = value
            End Set
        End Property
        Private Property TRN_IFace_3_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.TRN Implements Transaction277_A1.Loops.Loop2200E.TRN
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2200E.TRN)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.TRN)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property STC_Obj As SegmentContainer(Of Segments.STC) Implements Loops.Loop2200.STC
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.STC))
            End Get
        End Property

        Private STCSubset_Loop2200B_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200B.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2200B_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200B.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2200B.STC
            Get
                If STCSubset_Loop2200B_Obj Is Nothing Then
                    STCSubset_Loop2200B_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200B.STC, Segments.STC)(Children(1), 0, 3, 1)
                End If

                Return STCSubset_Loop2200B_Obj
            End Get
        End Property
        Private STCSubset_1_Loop2200C_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200C.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2200C_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200C.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2200C.STC
            Get
                If STCSubset_1_Loop2200C_Obj Is Nothing Then
                    STCSubset_1_Loop2200C_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200C.STC, Segments.STC)(Children(1), 0, 4, 1)
                End If

                Return STCSubset_1_Loop2200C_Obj
            End Get
        End Property
        Private STCSubset_2_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2200D.STC
            Get
                If STCSubset_2_Loop2200D_Obj Is Nothing Then
                    STCSubset_2_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.STC, Segments.STC)(Children(1), 0, 5, 1)
                End If

                Return STCSubset_2_Loop2200D_Obj
            End Get
        End Property
        Private STCSubset_3_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2200E.STC
            Get
                If STCSubset_3_Loop2200E_Obj Is Nothing Then
                    STCSubset_3_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.STC, Segments.STC)(Children(1), 0, 6, 1)
                End If

                Return STCSubset_3_Loop2200E_Obj
            End Get
        End Property
        Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Loops.Loop2200.REF
            Get
                Return CType(Children(2), SegmentContainer(Of Segments.REF))
            End Get
        End Property

        Private REFSubset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF, Segments.REF)
        Private Property REF_IFace_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF Implements Transaction277_A1.Loops.Loop2200D.REF
            Get
                If REFSubset_Loop2200D_Obj Is Nothing Then
                    REFSubset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF, Segments.REF)(Children(2), 1, 5, 37)
                End If

                If REFSubset_Loop2200D_Obj.Count > 0 Then
                    Return REFSubset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF)
                If REFSubset_Loop2200D_Obj Is Nothing Then
                    REFSubset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF, Segments.REF)(Children(2), 1, 5, 37)
                End If

                If REFSubset_Loop2200D_Obj.Count = 0 Then
                    REFSubset_Loop2200D_Obj.Add(value)
                Else
                    REFSubset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_1Subset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_1, Segments.REF)
        Private Property REF_IFace_1_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF_1 Implements Transaction277_A1.Loops.Loop2200D.REF_1
            Get
                If REF_1Subset_Loop2200D_Obj Is Nothing Then
                    REF_1Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_1, Segments.REF)(Children(2), 1, 5, 2629)
                End If

                If REF_1Subset_Loop2200D_Obj.Count > 0 Then
                    Return REF_1Subset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF_1)
                If REF_1Subset_Loop2200D_Obj Is Nothing Then
                    REF_1Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_1, Segments.REF)(Children(2), 1, 5, 2629)
                End If

                If REF_1Subset_Loop2200D_Obj.Count = 0 Then
                    REF_1Subset_Loop2200D_Obj.Add(value)
                Else
                    REF_1Subset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_2Subset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_2, Segments.REF)
        Private Property REF_IFace_2_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF_2 Implements Transaction277_A1.Loops.Loop2200D.REF_2
            Get
                If REF_2Subset_Loop2200D_Obj Is Nothing Then
                    REF_2Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_2, Segments.REF)(Children(2), 1, 5, 238501)
                End If

                If REF_2Subset_Loop2200D_Obj.Count > 0 Then
                    Return REF_2Subset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF_2)
                If REF_2Subset_Loop2200D_Obj Is Nothing Then
                    REF_2Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_2, Segments.REF)(Children(2), 1, 5, 238501)
                End If

                If REF_2Subset_Loop2200D_Obj.Count = 0 Then
                    REF_2Subset_Loop2200D_Obj.Add(value)
                Else
                    REF_2Subset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_3Subset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_3, Segments.REF)
        Private Property REF_IFace_3_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF_3 Implements Transaction277_A1.Loops.Loop2200D.REF_3
            Get
                If REF_3Subset_Loop2200D_Obj Is Nothing Then
                    REF_3Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_3, Segments.REF)(Children(2), 1, 5, 6517)
                End If

                If REF_3Subset_Loop2200D_Obj.Count > 0 Then
                    Return REF_3Subset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF_3)
                If REF_3Subset_Loop2200D_Obj Is Nothing Then
                    REF_3Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_3, Segments.REF)(Children(2), 1, 5, 6517)
                End If

                If REF_3Subset_Loop2200D_Obj.Count = 0 Then
                    REF_3Subset_Loop2200D_Obj.Add(value)
                Else
                    REF_3Subset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_4Subset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_4, Segments.REF)
        Private Property REF_IFace_4_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF_4 Implements Transaction277_A1.Loops.Loop2200D.REF_4
            Get
                If REF_4Subset_Loop2200D_Obj Is Nothing Then
                    REF_4Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_4, Segments.REF)(Children(2), 1, 5, 239797)
                End If

                If REF_4Subset_Loop2200D_Obj.Count > 0 Then
                    Return REF_4Subset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF_4)
                If REF_4Subset_Loop2200D_Obj Is Nothing Then
                    REF_4Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_4, Segments.REF)(Children(2), 1, 5, 239797)
                End If

                If REF_4Subset_Loop2200D_Obj.Count = 0 Then
                    REF_4Subset_Loop2200D_Obj.Add(value)
                Else
                    REF_4Subset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_5Subset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_5, Segments.REF)
        Private Property REF_IFace_5_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.REF_5 Implements Transaction277_A1.Loops.Loop2200D.REF_5
            Get
                If REF_5Subset_Loop2200D_Obj Is Nothing Then
                    REF_5Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_5, Segments.REF)(Children(2), 1, 5, 7813)
                End If

                If REF_5Subset_Loop2200D_Obj.Count > 0 Then
                    Return REF_5Subset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.REF_5)
                If REF_5Subset_Loop2200D_Obj Is Nothing Then
                    REF_5Subset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.REF_5, Segments.REF)(Children(2), 1, 5, 7813)
                End If

                If REF_5Subset_Loop2200D_Obj.Count = 0 Then
                    REF_5Subset_Loop2200D_Obj.Add(value)
                Else
                    REF_5Subset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private REFSubset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF, Segments.REF)
        Private Property REF_IFace_6_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF Implements Transaction277_A1.Loops.Loop2200E.REF
            Get
                If REFSubset_1_Loop2200E_Obj Is Nothing Then
                    REFSubset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF, Segments.REF)(Children(2), 1, 6, 37)
                End If

                If REFSubset_1_Loop2200E_Obj.Count > 0 Then
                    Return REFSubset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF)
                If REFSubset_1_Loop2200E_Obj Is Nothing Then
                    REFSubset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF, Segments.REF)(Children(2), 1, 6, 37)
                End If

                If REFSubset_1_Loop2200E_Obj.Count = 0 Then
                    REFSubset_1_Loop2200E_Obj.Add(value)
                Else
                    REFSubset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_1Subset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_1, Segments.REF)
        Private Property REF_IFace_7_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF_1 Implements Transaction277_A1.Loops.Loop2200E.REF_1
            Get
                If REF_1Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_1Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_1, Segments.REF)(Children(2), 1, 6, 2629)
                End If

                If REF_1Subset_1_Loop2200E_Obj.Count > 0 Then
                    Return REF_1Subset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF_1)
                If REF_1Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_1Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_1, Segments.REF)(Children(2), 1, 6, 2629)
                End If

                If REF_1Subset_1_Loop2200E_Obj.Count = 0 Then
                    REF_1Subset_1_Loop2200E_Obj.Add(value)
                Else
                    REF_1Subset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_2Subset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_2, Segments.REF)
        Private Property REF_IFace_8_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF_2 Implements Transaction277_A1.Loops.Loop2200E.REF_2
            Get
                If REF_2Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_2Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_2, Segments.REF)(Children(2), 1, 6, 238501)
                End If

                If REF_2Subset_1_Loop2200E_Obj.Count > 0 Then
                    Return REF_2Subset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF_2)
                If REF_2Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_2Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_2, Segments.REF)(Children(2), 1, 6, 238501)
                End If

                If REF_2Subset_1_Loop2200E_Obj.Count = 0 Then
                    REF_2Subset_1_Loop2200E_Obj.Add(value)
                Else
                    REF_2Subset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_3Subset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_3, Segments.REF)
        Private Property REF_IFace_9_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF_3 Implements Transaction277_A1.Loops.Loop2200E.REF_3
            Get
                If REF_3Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_3Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_3, Segments.REF)(Children(2), 1, 6, 6517)
                End If

                If REF_3Subset_1_Loop2200E_Obj.Count > 0 Then
                    Return REF_3Subset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF_3)
                If REF_3Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_3Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_3, Segments.REF)(Children(2), 1, 6, 6517)
                End If

                If REF_3Subset_1_Loop2200E_Obj.Count = 0 Then
                    REF_3Subset_1_Loop2200E_Obj.Add(value)
                Else
                    REF_3Subset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_4Subset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_4, Segments.REF)
        Private Property REF_IFace_10_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF_4 Implements Transaction277_A1.Loops.Loop2200E.REF_4
            Get
                If REF_4Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_4Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_4, Segments.REF)(Children(2), 1, 6, 239797)
                End If

                If REF_4Subset_1_Loop2200E_Obj.Count > 0 Then
                    Return REF_4Subset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF_4)
                If REF_4Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_4Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_4, Segments.REF)(Children(2), 1, 6, 239797)
                End If

                If REF_4Subset_1_Loop2200E_Obj.Count = 0 Then
                    REF_4Subset_1_Loop2200E_Obj.Add(value)
                Else
                    REF_4Subset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Private REF_5Subset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_5, Segments.REF)
        Private Property REF_IFace_11_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.REF_5 Implements Transaction277_A1.Loops.Loop2200E.REF_5
            Get
                If REF_5Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_5Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_5, Segments.REF)(Children(2), 1, 6, 7813)
                End If

                If REF_5Subset_1_Loop2200E_Obj.Count > 0 Then
                    Return REF_5Subset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.REF_5)
                If REF_5Subset_1_Loop2200E_Obj Is Nothing Then
                    REF_5Subset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.REF_5, Segments.REF)(Children(2), 1, 6, 7813)
                End If

                If REF_5Subset_1_Loop2200E_Obj.Count = 0 Then
                    REF_5Subset_1_Loop2200E_Obj.Add(value)
                Else
                    REF_5Subset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2200.DTP
            Get
                Return CType(Children(3), SegmentContainer(Of Segments.DTP))
            End Get
        End Property

        Private DTPSubset_Loop2200D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.DTP, Segments.DTP)
        Private Property DTP_IFace_Loop2200D_Obj As Transaction277_A1.Segments.Loop2200D.DTP Implements Transaction277_A1.Loops.Loop2200D.DTP
            Get
                If DTPSubset_Loop2200D_Obj Is Nothing Then
                    DTPSubset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.DTP, Segments.DTP)(Children(3), 1, 5, 73)
                End If

                If DTPSubset_Loop2200D_Obj.Count > 0 Then
                    Return DTPSubset_Loop2200D_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200D.DTP)
                If DTPSubset_Loop2200D_Obj Is Nothing Then
                    DTPSubset_Loop2200D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200D.DTP, Segments.DTP)(Children(3), 1, 5, 73)
                End If

                If DTPSubset_Loop2200D_Obj.Count = 0 Then
                    DTPSubset_Loop2200D_Obj.Add(value)
                Else
                    DTPSubset_Loop2200D_Obj(0) = value
                End If
            End Set
        End Property
        Private DTPSubset_1_Loop2200E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.DTP, Segments.DTP)
        Private Property DTP_IFace_1_Loop2200E_Obj As Transaction277_A1.Segments.Loop2200E.DTP Implements Transaction277_A1.Loops.Loop2200E.DTP
            Get
                If DTPSubset_1_Loop2200E_Obj Is Nothing Then
                    DTPSubset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.DTP, Segments.DTP)(Children(3), 1, 6, 73)
                End If

                If DTPSubset_1_Loop2200E_Obj.Count > 0 Then
                    Return DTPSubset_1_Loop2200E_Obj(0)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Transaction277_A1.Segments.Loop2200E.DTP)
                If DTPSubset_1_Loop2200E_Obj Is Nothing Then
                    DTPSubset_1_Loop2200E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2200E.DTP, Segments.DTP)(Children(3), 1, 6, 73)
                End If

                If DTPSubset_1_Loop2200E_Obj.Count = 0 Then
                    DTPSubset_1_Loop2200E_Obj.Add(value)
                Else
                    DTPSubset_1_Loop2200E_Obj(0) = value
                End If
            End Set
        End Property
        Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Segments.QTY) Implements Loops.Loop2200.QTY
            Get
                Return CType(Children(4), SegmentContainer(Of Segments.QTY))
            End Get
        End Property

        Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Segments.AMT) Implements Loops.Loop2200.AMT
            Get
                Return CType(Children(5), SegmentContainer(Of Segments.AMT))
            End Get
        End Property

        Friend ReadOnly Property Loop2210_Obj As LoopContainer(Of Loops.Loop2210) Implements Loops.Loop2200.Loop2210
            Get
                Return CType(Children(6), LoopContainer(Of Loops.Loop2210))
            End Get
        End Property

        Friend ReadOnly Property Loop2220_Obj As LoopContainer(Of Loops.Loop2220) Implements Loops.Loop2200.Loop2220
            Get
                Return CType(Children(7), LoopContainer(Of Loops.Loop2220))
            End Get
        End Property

        Private Loop2220DSubset_Loop2200D_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220D, Loops.Loop2220)
        Private ReadOnly Property Loop2220D_Obj_Loop2200D_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220D, Loops.Loop2220) Implements Transaction277_A1.Loops.Loop2200D.Loop2220D
            Get
                If Loop2220DSubset_Loop2200D_Obj Is Nothing Then
                    Loop2220DSubset_Loop2200D_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220D, Loops.Loop2220)(Children(7), 0, 5, 289)
                End If

                Return Loop2220DSubset_Loop2200D_Obj
            End Get
        End Property
        Private Loop2220ESubset_Loop2200E_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220E, Loops.Loop2220)
        Private ReadOnly Property Loop2220E_Obj_Loop2200E_Obj As LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220E, Loops.Loop2220) Implements Transaction277_A1.Loops.Loop2200E.Loop2220E
            Get
                If Loop2220ESubset_Loop2200E_Obj Is Nothing Then
                    Loop2220ESubset_Loop2200E_Obj = New LoopSubsetContainer(Of Transaction277_A1.Loops.Loop2220E, Loops.Loop2220)(Children(7), 0, 6, 289)
                End If

                Return Loop2220ESubset_Loop2200E_Obj
            End Get
        End Property

    End Class
    Partial Friend Class Loop2210_Obj
        Inherits LoopBase
        Implements Loops.Loop2210
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.PWK_Obj),
                                                        CType(Nothing, Segments.PER_Obj),
                                                        CType(Nothing, Segments.N1_Obj),
                                                        CType(Nothing, Segments.N3_Obj),
                                                        CType(Nothing, Segments.N4_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "PWK", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "PER", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(1, "N1", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(2, "N1", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(1, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(3, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(1, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(2, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(3, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(4, "N4", ReadAction.PopulateSegment, 5, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "PWK", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PWK_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PWK_Obj = Seg
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj = Seg
            ElseIf String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N1_Obj = Seg
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj = Seg
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            End If
        End Sub

        Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Return Task.CompletedTask()
        End Function
        Friend Property PWK_Obj As Segments.PWK_Obj
            Get
                Return CType(Children(0), Segments.PWK_Obj)
            End Get
            Set(value As Segments.PWK_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property PWK_Std As Segments.PWK Implements Loops.Loop2210.PWK
            Get
                Return CType(Children(0), Segments.PWK_Obj)
            End Get
            Set(value As Segments.PWK)
                Children(0) = value
            End Set
        End Property

        Friend Property PER_Obj As Segments.PER_Obj
            Get
                Return CType(Children(1), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER_Obj)
                Children(1) = value
            End Set
        End Property

        Private Property PER_Std As Segments.PER Implements Loops.Loop2210.PER
            Get
                Return CType(Children(1), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER)
                Children(1) = value
            End Set
        End Property

        Friend Property N1_Obj As Segments.N1_Obj
            Get
                Return CType(Children(2), Segments.N1_Obj)
            End Get
            Set(value As Segments.N1_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property N1_Std As Segments.N1 Implements Loops.Loop2210.N1
            Get
                Return CType(Children(2), Segments.N1_Obj)
            End Get
            Set(value As Segments.N1)
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

        Private Property N3_Std As Segments.N3 Implements Loops.Loop2210.N3
            Get
                Return CType(Children(3), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3)
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

        Private Property N4_Std As Segments.N4 Implements Loops.Loop2210.N4
            Get
                Return CType(Children(4), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(4) = value
            End Set
        End Property


    End Class
    Partial Friend Class Loop2220_Obj
        Inherits LoopBase
        Implements Loops.Loop2220,
                                            Transaction277_A1.Loops.Loop2220D,
                                            Transaction277_A1.Loops.Loop2220E
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.SVC_Obj),
                                                        New SegmentContainer(Of Segments.STC)(0, 2, 1900),
                                                        CType(Nothing, Segments.REF_Obj),
                                                        CType(Nothing, Segments.DTP_Obj),
                                                        New LoopContainer(Of Loops.Loop2225)(0, 2, 2200)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "SVC", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "STC", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "STC", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "DTP", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(4, "DTP", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(2, "PWK", ReadAction.PopulateLoop, 6, False),
                                        New ReaderState(4, "PWK", ReadAction.PopulateLoop, 6, False),
                                        New ReaderState(5, "PWK", ReadAction.PopulateLoop, 6, False),
                                        New ReaderState(6, "PWK", ReadAction.PopulateLoop, 6, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "SVC", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.SVC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                SVC_Obj = Seg
            ElseIf String.Compare(SegmentName, "STC", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.STC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                STC_Obj.Add(Seg)
            ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                REF_Obj = Seg
                Dim S2 = CType(Seg, Segments.REF_Obj)
                If CompareKey(S2.REF01, ";FJ;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D__2220D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 2
                ElseIf CompareKey(S2.REF01, ";FJ;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E__2220E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 2
                End If
            ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                DTP_Obj = Seg
                Dim S2 = CType(Seg, Segments.DTP_Obj)
                If CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_277A1__2000D__2200D__2220D", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 5
                    Seg.SetSequence = 38
                ElseIf CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_277A1__2000E__2200E__2220E", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Seg.SetArea = 6
                    Seg.SetSequence = 38
                End If
            End If
        End Sub

        Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Dim LoopID As String = args.ParentLoopID
            Dim Implementation As String = args.Implementation
            Dim Temp = args.Implementation

            If String.Compare(args.DataSegment.SegmentID, "PWK", StringComparison.OrdinalIgnoreCase) = 0 Then
                Dim NewLoop As LoopBase = New Loop2225_Obj
                Dim LoopKey As String = String.Format("{0}:{1}", args.DataSegment.ToStringValue(0), args.DataSegment.ToStringValue(1))
                Loop2225_Obj.Add(NewLoop)
                Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
            End If
            args.Implementation = Temp
        End Function
        Friend Property SVC_Obj As Segments.SVC_Obj
            Get
                Return CType(Children(0), Segments.SVC_Obj)
            End Get
            Set(value As Segments.SVC_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property SVC_Std As Segments.SVC Implements Loops.Loop2220.SVC
            Get
                Return CType(Children(0), Segments.SVC_Obj)
            End Get
            Set(value As Segments.SVC)
                Children(0) = value
            End Set
        End Property

        Private Property SVC_IFace_Loop2220D_Obj As Transaction277_A1.Segments.Loop2220D.SVC Implements Transaction277_A1.Loops.Loop2220D.SVC
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2220D.SVC)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220D.SVC)
                Children(0) = value
            End Set
        End Property
        Private Property SVC_IFace_1_Loop2220E_Obj As Transaction277_A1.Segments.Loop2220E.SVC Implements Transaction277_A1.Loops.Loop2220E.SVC
            Get
                Return CType(Children(0), Transaction277_A1.Segments.Loop2220E.SVC)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220E.SVC)
                Children(0) = value
            End Set
        End Property
        Friend ReadOnly Property STC_Obj As SegmentContainer(Of Segments.STC) Implements Loops.Loop2220.STC
            Get
                Return CType(Children(1), SegmentContainer(Of Segments.STC))
            End Get
        End Property

        Private STCSubset_Loop2220D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220D.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2220D_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220D.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2220D.STC
            Get
                If STCSubset_Loop2220D_Obj Is Nothing Then
                    STCSubset_Loop2220D_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220D.STC, Segments.STC)(Children(1), 0, 5, 325)
                End If

                Return STCSubset_Loop2220D_Obj
            End Get
        End Property
        Private STCSubset_1_Loop2220E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220E.STC, Segments.STC)
        Private ReadOnly Property STC_Loop2220E_Obj As SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220E.STC, Segments.STC) Implements Transaction277_A1.Loops.Loop2220E.STC
            Get
                If STCSubset_1_Loop2220E_Obj Is Nothing Then
                    STCSubset_1_Loop2220E_Obj = New SegmentSubsetContainer(Of Transaction277_A1.Segments.Loop2220E.STC, Segments.STC)(Children(1), 0, 6, 325)
                End If

                Return STCSubset_1_Loop2220E_Obj
            End Get
        End Property
        Friend Property REF_Obj As Segments.REF_Obj
            Get
                Return CType(Children(2), Segments.REF_Obj)
            End Get
            Set(value As Segments.REF_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property REF_Std As Segments.REF Implements Loops.Loop2220.REF
            Get
                Return CType(Children(2), Segments.REF_Obj)
            End Get
            Set(value As Segments.REF)
                Children(2) = value
            End Set
        End Property

        Private Property REF_IFace_Loop2220D_Obj As Transaction277_A1.Segments.Loop2220D.REF Implements Transaction277_A1.Loops.Loop2220D.REF
            Get
                Return CType(Children(2), Transaction277_A1.Segments.Loop2220D.REF)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220D.REF)
                Children(2) = value
            End Set
        End Property
        Private Property REF_IFace_1_Loop2220E_Obj As Transaction277_A1.Segments.Loop2220E.REF Implements Transaction277_A1.Loops.Loop2220E.REF
            Get
                Return CType(Children(2), Transaction277_A1.Segments.Loop2220E.REF)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220E.REF)
                Children(2) = value
            End Set
        End Property
        Friend Property DTP_Obj As Segments.DTP_Obj
            Get
                Return CType(Children(3), Segments.DTP_Obj)
            End Get
            Set(value As Segments.DTP_Obj)
                Children(3) = value
            End Set
        End Property

        Private Property DTP_Std As Segments.DTP Implements Loops.Loop2220.DTP
            Get
                Return CType(Children(3), Segments.DTP_Obj)
            End Get
            Set(value As Segments.DTP)
                Children(3) = value
            End Set
        End Property

        Private Property DTP_IFace_Loop2220D_Obj As Transaction277_A1.Segments.Loop2220D.DTP Implements Transaction277_A1.Loops.Loop2220D.DTP
            Get
                Return CType(Children(3), Transaction277_A1.Segments.Loop2220D.DTP)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220D.DTP)
                Children(3) = value
            End Set
        End Property
        Private Property DTP_IFace_1_Loop2220E_Obj As Transaction277_A1.Segments.Loop2220E.DTP Implements Transaction277_A1.Loops.Loop2220E.DTP
            Get
                Return CType(Children(3), Transaction277_A1.Segments.Loop2220E.DTP)
            End Get
            Set(value As Transaction277_A1.Segments.Loop2220E.DTP)
                Children(3) = value
            End Set
        End Property
        Friend ReadOnly Property Loop2225_Obj As LoopContainer(Of Loops.Loop2225) Implements Loops.Loop2220.Loop2225
            Get
                Return CType(Children(4), LoopContainer(Of Loops.Loop2225))
            End Get
        End Property


    End Class
    Partial Friend Class Loop2225_Obj
        Inherits LoopBase
        Implements Loops.Loop2225
        Friend Sub New()
            MyBase.New

            Children.AddRange({CType(Nothing, Segments.PWK_Obj),
                                                        CType(Nothing, Segments.PER_Obj),
                                                        CType(Nothing, Segments.N1_Obj),
                                                        CType(Nothing, Segments.N3_Obj),
                                                        CType(Nothing, Segments.N4_Obj)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "PWK", ReadAction.PopulateSegment, 1, False),
                                        New ReaderState(1, "PER", ReadAction.PopulateSegment, 2, False),
                                        New ReaderState(1, "N1", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(2, "N1", ReadAction.PopulateSegment, 3, False),
                                        New ReaderState(1, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(2, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(3, "N3", ReadAction.PopulateSegment, 4, False),
                                        New ReaderState(1, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(2, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(3, "N4", ReadAction.PopulateSegment, 5, False),
                                        New ReaderState(4, "N4", ReadAction.PopulateSegment, 5, False)})

        Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
            Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
        End Function

        Private Sub PopulateSegment(ByVal args As ReaderArgs)
            Dim SegmentName As String = args.DataSegment.SegmentID
            Dim Implementation As String = args.Implementation
            Dim Seg As Segment
            If String.Compare(SegmentName, "PWK", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PWK_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PWK_Obj = Seg
            ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                PER_Obj = Seg
            ElseIf String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N1_Obj = Seg
            ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N3_Obj = Seg
            ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
                Seg = Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
                N4_Obj = Seg
            End If
        End Sub

        Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
            Return Task.CompletedTask()
        End Function

        Friend Property PWK_Obj As Segments.PWK_Obj
            Get
                Return CType(Children(0), Segments.PWK_Obj)
            End Get
            Set(value As Segments.PWK_Obj)
                Children(0) = value
            End Set
        End Property

        Private Property PWK_Std As Segments.PWK Implements Loops.Loop2225.PWK
            Get
                Return CType(Children(0), Segments.PWK_Obj)
            End Get
            Set(value As Segments.PWK)
                Children(0) = value
            End Set
        End Property

        Friend Property PER_Obj As Segments.PER_Obj
            Get
                Return CType(Children(1), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER_Obj)
                Children(1) = value
            End Set
        End Property

        Private Property PER_Std As Segments.PER Implements Loops.Loop2225.PER
            Get
                Return CType(Children(1), Segments.PER_Obj)
            End Get
            Set(value As Segments.PER)
                Children(1) = value
            End Set
        End Property

        Friend Property N1_Obj As Segments.N1_Obj
            Get
                Return CType(Children(2), Segments.N1_Obj)
            End Get
            Set(value As Segments.N1_Obj)
                Children(2) = value
            End Set
        End Property

        Private Property N1_Std As Segments.N1 Implements Loops.Loop2225.N1
            Get
                Return CType(Children(2), Segments.N1_Obj)
            End Get
            Set(value As Segments.N1)
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

        Private Property N3_Std As Segments.N3 Implements Loops.Loop2225.N3
            Get
                Return CType(Children(3), Segments.N3_Obj)
            End Get
            Set(value As Segments.N3)
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

        Private Property N4_Std As Segments.N4 Implements Loops.Loop2225.N4
            Get
                Return CType(Children(4), Segments.N4_Obj)
            End Get
            Set(value As Segments.N4)
                Children(4) = value
            End Set
        End Property


    End Class
    '''<summary>Health Care Information Status Notification</summary>
    '''<remarks></remarks>
    Public Interface Standard
        '''<summary>Transaction Set Header</summary>
        Property ST As Segments.ST
        '''<summary>Beginning of Hierarchical Transaction</summary>
        Property BHT As Segments.BHT
        '''<summary>Reference Information</summary>
        ReadOnly Property REF As SegmentContainer(Of Segments.REF)
        '''<summary>Individual or Organizational Name</summary>
        ReadOnly Property Loop1000 As LoopContainer(Of Loops.Loop1000)
        '''<summary>Hierarchical Level</summary>
        ReadOnly Property Loop2000 As LoopContainer(Of Loops.Loop2000)
        '''<summary>Transaction Set Trailer</summary>
        Property SE As Segments.SE
    End Interface
    Namespace Loops

        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop1000
            Inherits ILoop
            '''<summary>Individual or Organizational Name</summary>
            Property NM1 As Segments.NM1
            '''<summary>Additional Name Information</summary>
            ReadOnly Property N2 As SegmentContainer(Of Segments.N2)
            '''<summary>Party Location</summary>
            ReadOnly Property N3 As SegmentContainer(Of Segments.N3)
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
            '''<summary>Reference Information</summary>
            ReadOnly Property REF As SegmentContainer(Of Segments.REF)
            '''<summary>Administrative Communications Contact</summary>
            Property PER As Segments.PER
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2000
            Inherits ILoop
            '''<summary>Hierarchical Level</summary>
            Property HL As Segments.HL
            '''<summary>Subscriber Information</summary>
            Property SBR As Segments.SBR
            '''<summary>Patient Information</summary>
            Property PAT As Segments.PAT
            '''<summary>Demographic Information</summary>
            Property DMG As Segments.DMG
            '''<summary>Individual or Organizational Name</summary>
            ReadOnly Property Loop2100 As LoopContainer(Of Loop2100)
            '''<summary>Trace</summary>
            ReadOnly Property Loop2200 As LoopContainer(Of Loop2200)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2100
            Inherits ILoop
            '''<summary>Individual or Organizational Name</summary>
            Property NM1 As Segments.NM1
            '''<summary>Party Location</summary>
            ReadOnly Property N3 As SegmentContainer(Of Segments.N3)
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
            '''<summary>Administrative Communications Contact</summary>
            Property PER As Segments.PER
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2200
            Inherits ILoop
            '''<summary>Trace</summary>
            Property TRN As Segments.TRN
            '''<summary>Status Information</summary>
            ReadOnly Property STC As SegmentContainer(Of Segments.STC)
            '''<summary>Reference Information</summary>
            ReadOnly Property REF As SegmentContainer(Of Segments.REF)
            '''<summary>Date or Time or Period</summary>
            ReadOnly Property DTP As SegmentContainer(Of Segments.DTP)
            '''<summary>Quantity Information</summary>
            ReadOnly Property QTY As SegmentContainer(Of Segments.QTY)
            '''<summary>Monetary Amount Information</summary>
            ReadOnly Property AMT As SegmentContainer(Of Segments.AMT)
            '''<summary>Paperwork</summary>
            ReadOnly Property Loop2210 As LoopContainer(Of Loop2210)
            '''<summary>Service Information</summary>
            ReadOnly Property Loop2220 As LoopContainer(Of Loop2220)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2210
            Inherits ILoop
            '''<summary>Paperwork</summary>
            Property PWK As Segments.PWK
            '''<summary>Administrative Communications Contact</summary>
            Property PER As Segments.PER
            '''<summary>Party Identification</summary>
            Property N1 As Segments.N1
            '''<summary>Party Location</summary>
            Property N3 As Segments.N3
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2220
            Inherits ILoop
            '''<summary>Service Information</summary>
            Property SVC As Segments.SVC
            '''<summary>Status Information</summary>
            ReadOnly Property STC As SegmentContainer(Of Segments.STC)
            '''<summary>Reference Information</summary>
            Property REF As Segments.REF
            '''<summary>Date or Time or Period</summary>
            Property DTP As Segments.DTP
            '''<summary>Paperwork</summary>
            ReadOnly Property Loop2225 As LoopContainer(Of Loop2225)
        End Interface
        '''<summary></summary>
        '''<remarks></remarks>
        Public Interface Loop2225
            Inherits ILoop
            '''<summary>Paperwork</summary>
            Property PWK As Segments.PWK
            '''<summary>Administrative Communications Contact</summary>
            Property PER As Segments.PER
            '''<summary>Party Identification</summary>
            Property N1 As Segments.N1
            '''<summary>Party Location</summary>
            Property N3 As Segments.N3
            '''<summary>Geographic Location</summary>
            Property N4 As Segments.N4
        End Interface

    End Namespace 'Loops


    Namespace Transaction277_A1
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
            End Namespace 'Loop2000A

            Namespace Loop2100A

                '''<summary>Payer Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Payer Name</summary>
                    Property NM103 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Payer Identifier</summary>
                    Property NM109 As String
                End Interface
                '''<summary>Payer Contact Information</summary>
                Public Interface PER
                    Inherits ISegment

                    '''<summary>Contact Function Code</summary>
                    Property PER01 As String
                    '''<summary>Payer Contact Name</summary>
                    Property PER02 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER03 As String
                    '''<summary>Payer Contact Communication Number</summary>
                    Property PER04 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER05 As String
                    '''<summary>Payer Contact Communication Number</summary>
                    Property PER06 As String
                    '''<summary>Communication Number Qualifier</summary>
                    Property PER07 As String
                    '''<summary>Payer Contact Communication Number</summary>
                    Property PER08 As String
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
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Information Receiver Identification Number</summary>
                    Property NM109 As String
                End Interface
            End Namespace 'Loop2100B

            Namespace Loop2200B

                '''<summary>Information Receiver Trace Identifier</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Claim Transaction Batch Number</summary>
                    Property TRN02 As String
                End Interface
                '''<summary>Information Receiver Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As Composites.Loop2200B.STC.STC_01.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary></summary>
                    Property STC10 As Composites.Loop2200B.STC.STC_10.C043
                    '''<summary></summary>
                    Property STC11 As Composites.Loop2200B.STC.STC_11.C043
                End Interface
            End Namespace 'Loop2200B

            Namespace Loop2000C

                '''<summary>Service Provider Level</summary>
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
            End Namespace 'Loop2000C

            Namespace Loop2100C

                '''<summary>Provider Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Provider Last or Organization Name</summary>
                    Property NM103 As String
                    '''<summary>Provider First Name</summary>
                    Property NM104 As String
                    '''<summary>Provider Middle Name</summary>
                    Property NM105 As String
                    '''<summary>Provider Name Suffix</summary>
                    Property NM107 As String
                    '''<summary>Identification Code Qualifier</summary>
                    Property NM108 As String
                    '''<summary>Provider Identifier</summary>
                    Property NM109 As String
                End Interface
            End Namespace 'Loop2100C

            Namespace Loop2200C

                '''<summary>Provider of Service Trace Identifier</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Provider of Service Information Trace Identifier</summary>
                    Property TRN02 As String
                End Interface
                '''<summary>Provider Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As Composites.Loop2200C.STC.STC_01.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary></summary>
                    Property STC10 As Composites.Loop2200C.STC.STC_10.C043
                    '''<summary></summary>
                    Property STC11 As Composites.Loop2200C.STC.STC_11.C043
                End Interface
            End Namespace 'Loop2200C

            Namespace Loop2000D

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
            End Namespace 'Loop2000D

            Namespace Loop2100D

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
                    '''<summary>Subscriber Identifier</summary>
                    Property NM109 As String
                End Interface
            End Namespace 'Loop2100D

            Namespace Loop2200D

                '''<summary>Claim Status Tracking Number</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Referenced Transaction Trace Number</summary>
                    Property TRN02 As String
                End Interface
                '''<summary>Claim Level Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As DataElements.Composite.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary>Total Claim Charge Amount</summary>
                    Property STC04 As Decimal?
                    '''<summary>Claim Payment Amount</summary>
                    Property STC05 As Decimal?
                    '''<summary>Adjudication Finalized Date</summary>
                    Property STC06 As Date?
                    '''<summary>Remittance Date</summary>
                    Property STC08 As Date?
                    '''<summary>Remittance Trace Number</summary>
                    Property STC09 As String
                    '''<summary></summary>
                    Property STC10 As DataElements.Composite.C043
                    '''<summary></summary>
                    Property STC11 As DataElements.Composite.C043
                End Interface
                '''<summary>Payer Claim Control Number</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Payer Claim Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Institutional Bill Type Identification</summary>
                Public Interface REF_1
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Bill Type Identifier</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Patient Control Number</summary>
                Public Interface REF_2
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Patient Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Pharmacy Prescription Number</summary>
                Public Interface REF_3
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Pharmacy Prescription Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Voucher Identifier</summary>
                Public Interface REF_4
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Voucher Identifier</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Claim Identification Number For Clearinghouses and Other Transmission Intermediaries</summary>
                Public Interface REF_5
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Clearinghouse Trace Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Claim Service Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Claim Service Period</summary>
                    Property DTP03 As String
                End Interface
            End Namespace 'Loop2200D

            Namespace Loop2220D

                '''<summary>Service Line Information</summary>
                Public Interface SVC
                    Inherits ISegment

                    '''<summary></summary>
                    Property SVC01 As Composites.Loop2220D.SVC.SVC_01.C003
                    '''<summary>Line Item Charge Amount</summary>
                    Property SVC02 As Decimal?
                    '''<summary>Line Item Payment Amount</summary>
                    Property SVC03 As Decimal?
                    '''<summary>Revenue Code</summary>
                    Property SVC04 As String
                    '''<summary>Units of Service Count</summary>
                    Property SVC07 As Decimal?
                End Interface
                '''<summary>Service Line Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As DataElements.Composite.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary></summary>
                    Property STC10 As DataElements.Composite.C043
                    '''<summary></summary>
                    Property STC11 As DataElements.Composite.C043
                End Interface
                '''<summary>Service Line Item Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Line Item Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Service Line Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Service Line Date</summary>
                    Property DTP03 As String
                End Interface
            End Namespace 'Loop2220D

            Namespace Loop2000E

                '''<summary>Dependent Level</summary>
                Public Interface HL
                    Inherits ISegment

                    '''<summary>Hierarchical ID Number</summary>
                    Property HL01 As String
                    '''<summary>Hierarchical Parent ID Number</summary>
                    Property HL02 As String
                    '''<summary>Hierarchical Level Code</summary>
                    Property HL03 As String
                End Interface
            End Namespace 'Loop2000E

            Namespace Loop2100E

                '''<summary>Dependent Name</summary>
                Public Interface NM1
                    Inherits ISegment

                    '''<summary>Entity Identifier Code</summary>
                    Property NM101 As String
                    '''<summary>Entity Type Qualifier</summary>
                    Property NM102 As String
                    '''<summary>Patient Last Name</summary>
                    Property NM103 As String
                    '''<summary>Patient First Name</summary>
                    Property NM104 As String
                    '''<summary>Patient Middle Name or Initial</summary>
                    Property NM105 As String
                    '''<summary>Patient Name Suffix</summary>
                    Property NM107 As String
                End Interface
            End Namespace 'Loop2100E

            Namespace Loop2200E

                '''<summary>Claim Status Tracking Number</summary>
                Public Interface TRN
                    Inherits ISegment

                    '''<summary>Trace Type Code</summary>
                    Property TRN01 As String
                    '''<summary>Referenced Transaction Trace Number</summary>
                    Property TRN02 As String
                End Interface
                '''<summary>Claim Level Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As DataElements.Composite.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary>Total Claim Charge Amount</summary>
                    Property STC04 As Decimal?
                    '''<summary>Claim Payment Amount</summary>
                    Property STC05 As Decimal?
                    '''<summary>Adjudication Finalized Date</summary>
                    Property STC06 As Date?
                    '''<summary>Remittance Date</summary>
                    Property STC08 As Date?
                    '''<summary>Remittance Trace Number</summary>
                    Property STC09 As String
                    '''<summary></summary>
                    Property STC10 As DataElements.Composite.C043
                    '''<summary></summary>
                    Property STC11 As DataElements.Composite.C043
                End Interface
                '''<summary>Payer Claim Control Number</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Payer Claim Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Institutional Bill Type Identification</summary>
                Public Interface REF_1
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Bill Type Identifier</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Patient Control Number</summary>
                Public Interface REF_2
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Patient Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Pharmacy Prescription Number</summary>
                Public Interface REF_3
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Pharmacy Prescription Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Voucher Identifier</summary>
                Public Interface REF_4
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Voucher Identifier</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Claim Identification Number For Clearinghouses and Other Transmission Intermediaries</summary>
                Public Interface REF_5
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Clearinghouse Trace Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Claim Service Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Claim Service Period</summary>
                    Property DTP03 As String
                End Interface
            End Namespace 'Loop2200E

            Namespace Loop2220E

                '''<summary>Service Line Information</summary>
                Public Interface SVC
                    Inherits ISegment

                    '''<summary></summary>
                    Property SVC01 As Composites.Loop2220E.SVC.SVC_01.C003
                    '''<summary>Line Item Charge Amount</summary>
                    Property SVC02 As Decimal?
                    '''<summary>Line Item Payment Amount</summary>
                    Property SVC03 As Decimal?
                    '''<summary>Revenue Code</summary>
                    Property SVC04 As String
                    '''<summary>Units of Service Count</summary>
                    Property SVC07 As Decimal?
                End Interface
                '''<summary>Service Line Status Information</summary>
                Public Interface STC
                    Inherits ISegment

                    '''<summary></summary>
                    Property STC01 As DataElements.Composite.C043
                    '''<summary>Status Information Effective Date</summary>
                    Property STC02 As Date?
                    '''<summary></summary>
                    Property STC10 As DataElements.Composite.C043
                    '''<summary></summary>
                    Property STC11 As DataElements.Composite.C043
                End Interface
                '''<summary>Service Line Item Identification</summary>
                Public Interface REF
                    Inherits ISegment

                    '''<summary>Reference Identification Qualifier</summary>
                    Property REF01 As String
                    '''<summary>Line Item Control Number</summary>
                    Property REF02 As String
                End Interface
                '''<summary>Service Line Date</summary>
                Public Interface DTP
                    Inherits ISegment

                    '''<summary>Date Time Qualifier</summary>
                    Property DTP01 As String
                    '''<summary>Date Time Period Format Qualifier</summary>
                    Property DTP02 As String
                    '''<summary>Service Line Date</summary>
                    Property DTP03 As String
                End Interface
            End Namespace 'Loop2220E

            '''<summary>Transaction Set Header</summary>
            Public Interface ST
                Inherits ISegment

                '''<summary>Transaction Set Identifier Code</summary>
                Property ST01 As String
                '''<summary>Transaction Set Control Number</summary>
                Property ST02 As String
                '''<summary>Version, Release, or Industry Identifier</summary>
                Property ST03 As String
            End Interface
            '''<summary>Beginning of Hierarchical Transaction</summary>
            Public Interface BHT
                Inherits ISegment

                '''<summary>Hierarchical Structure Code</summary>
                Property BHT01 As String
                '''<summary>Transaction Set Purpose Code</summary>
                Property BHT02 As String
                '''<summary>Originator Application Transaction Identifier</summary>
                Property BHT03 As String
                '''<summary>Transaction Set Creation Date</summary>
                Property BHT04 As Date?
                '''<summary>Transaction Set Creation Time</summary>
                Property BHT05 As TimeSpan?
                '''<summary>Transaction Type Code</summary>
                Property BHT06 As String
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
            Namespace Loop2200B.STC.STC_01
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2200B.STC.STC_10
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2200B.STC.STC_11
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2200C.STC.STC_01
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2200C.STC.STC_10
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2200C.STC.STC_11
                '''<summary></summary>
                Public Interface C043
                    '''<summary>Health Care Claim Status Category Code</summary>
                    Property C043_01 As String
                    '''<summary>Status Code</summary>
                    Property C043_02 As String
                    '''<summary>Entity Identifier Code</summary>
                    Property C043_03 As String
                End Interface
            End Namespace
            Namespace Loop2220D.SVC.SVC_01
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
                End Interface
            End Namespace
            Namespace Loop2220E.SVC.SVC_01
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
                End Interface
            End Namespace
        End Namespace 'Composites

        Namespace Loops
            '''<summary>Information Source Level</summary>
            Public Interface Loop2000A
                Inherits ILoop


                '''<summary>Information Source Level</summary>
                Property HL As Segments.Loop2000A.HL

                '''<summary>Payer Name</summary>
                Property Loop2100A As Loop2100A
            End Interface
            '''<summary>Payer Name</summary>
            Public Interface Loop2100A
                Inherits ILoop


                '''<summary>Payer Name</summary>
                Property NM1 As Segments.Loop2100A.NM1

                '''<summary>Payer Contact Information</summary>
                Property PER As Segments.Loop2100A.PER
            End Interface
            '''<summary>Information Receiver Level</summary>
            Public Interface Loop2000B
                Inherits ILoop


                '''<summary>Information Receiver Level</summary>
                Property HL As Segments.Loop2000B.HL

                '''<summary>Information Receiver Name</summary>
                Property Loop2100B As Loop2100B

                '''<summary>Information Receiver Trace Identifier</summary>
                Property Loop2200B As Loop2200B
            End Interface
            '''<summary>Information Receiver Name</summary>
            Public Interface Loop2100B
                Inherits ILoop


                '''<summary>Information Receiver Name</summary>
                Property NM1 As Segments.Loop2100B.NM1
            End Interface
            '''<summary>Information Receiver Trace Identifier</summary>
            Public Interface Loop2200B
                Inherits ILoop


                '''<summary>Information Receiver Trace Identifier</summary>
                Property TRN As Segments.Loop2200B.TRN

                '''<summary>Information Receiver Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2200B.STC, Dom.Segments.STC)
            End Interface
            '''<summary>Service Provider Level</summary>
            Public Interface Loop2000C
                Inherits ILoop


                '''<summary>Service Provider Level</summary>
                Property HL As Segments.Loop2000C.HL

                '''<summary>Provider Name</summary>
                ReadOnly Property Loop2100C As LoopSubsetContainer(Of Loop2100C, Transaction277.Loops.Loop2100)

                '''<summary>Provider of Service Trace Identifier</summary>
                Property Loop2200C As Loop2200C
            End Interface
            '''<summary>Provider Name</summary>
            Public Interface Loop2100C
                Inherits ILoop


                '''<summary>Provider Name</summary>
                Property NM1 As Segments.Loop2100C.NM1
            End Interface
            '''<summary>Provider of Service Trace Identifier</summary>
            Public Interface Loop2200C
                Inherits ILoop


                '''<summary>Provider of Service Trace Identifier</summary>
                Property TRN As Segments.Loop2200C.TRN

                '''<summary>Provider Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2200C.STC, Dom.Segments.STC)
            End Interface
            '''<summary>Subscriber Level</summary>
            Public Interface Loop2000D
                Inherits ILoop


                '''<summary>Subscriber Level</summary>
                Property HL As Segments.Loop2000D.HL

                '''<summary>Subscriber Name</summary>
                Property Loop2100D As Loop2100D

                '''<summary>Claim Status Tracking Number</summary>
                ReadOnly Property Loop2200D As LoopSubsetContainer(Of Loop2200D, Transaction277.Loops.Loop2200)
            End Interface
            '''<summary>Subscriber Name</summary>
            Public Interface Loop2100D
                Inherits ILoop


                '''<summary>Subscriber Name</summary>
                Property NM1 As Segments.Loop2100D.NM1
            End Interface
            '''<summary>Claim Status Tracking Number</summary>
            Public Interface Loop2200D
                Inherits ILoop


                '''<summary>Claim Status Tracking Number</summary>
                Property TRN As Segments.Loop2200D.TRN

                '''<summary>Claim Level Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2200D.STC, Dom.Segments.STC)

                '''<summary>Payer Claim Control Number</summary>
                Property REF As Segments.Loop2200D.REF

                '''<summary>Institutional Bill Type Identification</summary>
                Property REF_1 As Segments.Loop2200D.REF_1

                '''<summary>Patient Control Number</summary>
                Property REF_2 As Segments.Loop2200D.REF_2

                '''<summary>Pharmacy Prescription Number</summary>
                Property REF_3 As Segments.Loop2200D.REF_3

                '''<summary>Voucher Identifier</summary>
                Property REF_4 As Segments.Loop2200D.REF_4

                '''<summary>Claim Identification Number For Clearinghouses and Other Transmission Intermediaries</summary>
                Property REF_5 As Segments.Loop2200D.REF_5

                '''<summary>Claim Service Date</summary>
                Property DTP As Segments.Loop2200D.DTP

                '''<summary>Service Line Information</summary>
                ReadOnly Property Loop2220D As LoopSubsetContainer(Of Loop2220D, Transaction277.Loops.Loop2220)
            End Interface
            '''<summary>Service Line Information</summary>
            Public Interface Loop2220D
                Inherits ILoop


                '''<summary>Service Line Information</summary>
                Property SVC As Segments.Loop2220D.SVC

                '''<summary>Service Line Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2220D.STC, Dom.Segments.STC)

                '''<summary>Service Line Item Identification</summary>
                Property REF As Segments.Loop2220D.REF

                '''<summary>Service Line Date</summary>
                Property DTP As Segments.Loop2220D.DTP
            End Interface
            '''<summary>Dependent Level</summary>
            Public Interface Loop2000E
                Inherits ILoop


                '''<summary>Dependent Level</summary>
                Property HL As Segments.Loop2000E.HL

                '''<summary>Dependent Name</summary>
                Property Loop2100E As Loop2100E

                '''<summary>Claim Status Tracking Number</summary>
                ReadOnly Property Loop2200E As LoopSubsetContainer(Of Loop2200E, Transaction277.Loops.Loop2200)
            End Interface
            '''<summary>Dependent Name</summary>
            Public Interface Loop2100E
                Inherits ILoop


                '''<summary>Dependent Name</summary>
                Property NM1 As Segments.Loop2100E.NM1
            End Interface
            '''<summary>Claim Status Tracking Number</summary>
            Public Interface Loop2200E
                Inherits ILoop


                '''<summary>Claim Status Tracking Number</summary>
                Property TRN As Segments.Loop2200E.TRN

                '''<summary>Claim Level Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2200E.STC, Dom.Segments.STC)

                '''<summary>Payer Claim Control Number</summary>
                Property REF As Segments.Loop2200E.REF

                '''<summary>Institutional Bill Type Identification</summary>
                Property REF_1 As Segments.Loop2200E.REF_1

                '''<summary>Patient Control Number</summary>
                Property REF_2 As Segments.Loop2200E.REF_2

                '''<summary>Pharmacy Prescription Number</summary>
                Property REF_3 As Segments.Loop2200E.REF_3

                '''<summary>Voucher Identifier</summary>
                Property REF_4 As Segments.Loop2200E.REF_4

                '''<summary>Claim Identification Number For Clearinghouses and Other Transmission Intermediaries</summary>
                Property REF_5 As Segments.Loop2200E.REF_5

                '''<summary>Claim Service Date</summary>
                Property DTP As Segments.Loop2200E.DTP

                '''<summary>Service Line Information</summary>
                ReadOnly Property Loop2220E As LoopSubsetContainer(Of Loop2220E, Transaction277.Loops.Loop2220)
            End Interface
            '''<summary>Service Line Information</summary>
            Public Interface Loop2220E
                Inherits ILoop


                '''<summary>Service Line Information</summary>
                Property SVC As Segments.Loop2220E.SVC

                '''<summary>Service Line Status Information</summary>
                ReadOnly Property STC As SegmentSubsetContainer(Of Segments.Loop2220E.STC, Dom.Segments.STC)

                '''<summary>Service Line Item Identification</summary>
                Property REF As Segments.Loop2220E.REF

                '''<summary>Service Line Date</summary>
                Property DTP As Segments.Loop2220E.DTP
            End Interface

        End Namespace 'Loops

        '''<summary>Health Care Information Status Notification</summary>
        '''<remarks>
        '''<para>This X12 Transaction Set contains the format and establishes the data contents of the Health Care Information Status Notification Transaction Set (277) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used by a health care payer or authorized agent to notify a provider, recipient, or authorized agent regarding the status of a health care claim or encounter or to request additional information from the provider regarding a health care claim or encounter, health care services review, or transactions related to the provisions of health care. This transaction set is not intended to replace the Health Care Claim Payment/Advice Transaction Set (835) and therefore, will not be used for account payment posting. The notification may be at a summary or service line detail level. The notification may be solicited or unsolicited.</para>
        '''</remarks>
        Public Interface TransactionSet

            '''<summary>Transaction Set Header</summary>
            Property ST As Segments.ST

            '''<summary>Beginning of Hierarchical Transaction</summary>
            Property BHT As Segments.BHT

            '''<summary>Information Source Level</summary>
            ReadOnly Property Loop2000A As LoopSubsetContainer(Of Loops.Loop2000A, Transaction277.Loops.Loop2000)

            '''<summary>Information Receiver Level</summary>
            ReadOnly Property Loop2000B As LoopSubsetContainer(Of Loops.Loop2000B, Transaction277.Loops.Loop2000)

            '''<summary>Service Provider Level</summary>
            ReadOnly Property Loop2000C As LoopSubsetContainer(Of Loops.Loop2000C, Transaction277.Loops.Loop2000)

            '''<summary>Subscriber Level</summary>
            ReadOnly Property Loop2000D As LoopSubsetContainer(Of Loops.Loop2000D, Transaction277.Loops.Loop2000)

            '''<summary>Dependent Level</summary>
            ReadOnly Property Loop2000E As LoopSubsetContainer(Of Loops.Loop2000E, Transaction277.Loops.Loop2000)

            '''<summary>Transaction Set Trailer</summary>
            Property SE As Segments.SE
        End Interface
    End Namespace 'Transaction277_A1
End Namespace 'Transaction277
