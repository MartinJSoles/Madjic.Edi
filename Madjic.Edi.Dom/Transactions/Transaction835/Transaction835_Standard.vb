Namespace Transactions
	Namespace Transaction835

		Partial Friend Class Standard_Obj
			Inherits TransactionSet
			Implements Standard, Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet
			Friend Sub New(versionCode As String)
				Me.New(String.Empty, versionCode)
			End Sub

			Friend Sub New(controlNumber As String, versionCode As String)
				MyBase.New("HP", versionCode)

				Children.AddRange({New Dom.Segments.ST_Obj,
															CType(Nothing, Dom.Segments.BPR_Obj),
															New SegmentContainer(Of Dom.Segments.NTE)(0, 1, 300),
															CType(Nothing, Dom.Segments.TRN_Obj),
															CType(Nothing, Dom.Segments.CUR_Obj),
															New SegmentContainer(Of Dom.Segments.REF)(0, 1, 600),
															New SegmentContainer(Of Dom.Segments.DTM)(0, 1, 700),
															New LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop1000)(200, 1, 800),
															New LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2000)(0, 2, 30),
															New SegmentContainer(Of Dom.Segments.PLB)(0, 3, 100),
															New Dom.Segments.SE_Obj})

				ST_Obj.ST01 = "835"
				ST_Obj.ST02 = controlNumber
				ST_Obj.ST03 = versionCode

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
											New ReaderState(1, "BPR", ReadAction.PopulateSegment, 2, False),
											New ReaderState(2, "NTE", ReadAction.PopulateSegment, 3, False),
											New ReaderState(3, "NTE", ReadAction.PopulateSegment, 3, False),
											New ReaderState(2, "TRN", ReadAction.PopulateSegment, 5, False),
											New ReaderState(3, "TRN", ReadAction.PopulateSegment, 5, False),
											New ReaderState(2, "CUR", ReadAction.PopulateSegment, 6, False),
											New ReaderState(3, "CUR", ReadAction.PopulateSegment, 6, False),
											New ReaderState(5, "CUR", ReadAction.PopulateSegment, 6, False),
											New ReaderState(2, "REF", ReadAction.PopulateSegment, 7, False),
											New ReaderState(3, "REF", ReadAction.PopulateSegment, 7, False),
											New ReaderState(5, "REF", ReadAction.PopulateSegment, 7, False),
											New ReaderState(6, "REF", ReadAction.PopulateSegment, 7, False),
											New ReaderState(7, "REF", ReadAction.PopulateSegment, 7, False),
											New ReaderState(2, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(3, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(5, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(6, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(7, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(9, "DTM", ReadAction.PopulateSegment, 9, False),
											New ReaderState(2, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(3, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(5, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(6, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(7, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(9, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(11, "N1", ReadAction.PopulateLoop, 11, False),
											New ReaderState(2, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(3, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(5, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(6, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(7, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(9, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(11, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(13, "LX", ReadAction.PopulateLoop, 13, False),
											New ReaderState(2, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(3, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(5, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(6, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(7, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(9, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(11, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(13, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(15, "PLB", ReadAction.PopulateSegment, 15, False),
											New ReaderState(2, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(3, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(5, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(6, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(7, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(9, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(11, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(13, "SE", ReadAction.PopulateSegment, 17, False),
											New ReaderState(15, "SE", ReadAction.PopulateSegment, 17, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ST_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.ST_Obj)
					If MyBase.CompareKey(S2.ST01, ";835;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 36
					End If
				ElseIf String.Compare(SegmentName, "BPR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.BPR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BPR_Obj = Seg
				ElseIf String.Compare(SegmentName, "NTE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.NTE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NTE_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TRN_Obj = Seg
				ElseIf String.Compare(SegmentName, "CUR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CUR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CUR_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";EV;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 11844
					ElseIf MyBase.CompareKey(S2.REF01, ";F2;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 216
					End If
				ElseIf String.Compare(SegmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.DTM_Obj)
					If MyBase.CompareKey(S2.DTM01, ";405;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 252
					End If
				ElseIf String.Compare(SegmentName, "PLB", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PLB_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PLB_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction835.Loop1000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop1000_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";PR;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_835W1__1000A"
						NewLoop.SetArea = 1
						NewLoop.SetSequence = 288
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";PE;") AndAlso String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_835W1__1000B"
						NewLoop.SetArea = 1
						NewLoop.SetSequence = 145
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction835.Loop2000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2000_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_835W1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_835W1__2000"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property ST_Obj As Dom.Segments.ST_Obj
				Get
					Return CType(Children(0), Dom.Segments.ST_Obj)
				End Get
				Set(value As Dom.Segments.ST_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ST_Std As Dom.Segments.ST Implements Dom.Transactions.Transaction835.Standard.ST
				Get
					Return CType(Children(0), Dom.Segments.ST_Obj)
				End Get
				Set(value As Dom.Segments.ST)
					Children(0) = value
				End Set
			End Property

			Private Property ST_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.ST
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Friend Property BPR_Obj As Dom.Segments.BPR_Obj
				Get
					Return CType(Children(1), Dom.Segments.BPR_Obj)
				End Get
				Set(value As Dom.Segments.BPR_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property BPR_Std As Dom.Segments.BPR Implements Dom.Transactions.Transaction835.Standard.BPR
				Get
					Return CType(Children(1), Dom.Segments.BPR_Obj)
				End Get
				Set(value As Dom.Segments.BPR)
					Children(1) = value
				End Set
			End Property

			Private Property BPR_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.BPR
				Get
					Return CType(Children(1), Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property NTE_Obj As SegmentContainer(Of Dom.Segments.NTE) Implements Dom.Transactions.Transaction835.Standard.NTE
				Get
					Return CType(Children(2), SegmentContainer(Of Dom.Segments.NTE))
				End Get
			End Property

			Friend Property TRN_Obj As Dom.Segments.TRN_Obj
				Get
					Return CType(Children(3), Dom.Segments.TRN_Obj)
				End Get
				Set(value As Dom.Segments.TRN_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property TRN_Std As Dom.Segments.TRN Implements Dom.Transactions.Transaction835.Standard.TRN
				Get
					Return CType(Children(3), Dom.Segments.TRN_Obj)
				End Get
				Set(value As Dom.Segments.TRN)
					Children(3) = value
				End Set
			End Property

			Private Property TRN_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.TRN
				Get
					Return CType(Children(3), Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN)
					Children(3) = value
				End Set
			End Property
			Friend Property CUR_Obj As Dom.Segments.CUR_Obj
				Get
					Return CType(Children(4), Dom.Segments.CUR_Obj)
				End Get
				Set(value As Dom.Segments.CUR_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property CUR_Std As Dom.Segments.CUR Implements Dom.Transactions.Transaction835.Standard.CUR
				Get
					Return CType(Children(4), Dom.Segments.CUR_Obj)
				End Get
				Set(value As Dom.Segments.CUR)
					Children(4) = value
				End Set
			End Property

			Private Property CUR_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.CUR
				Get
					Return CType(Children(4), Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR)
					Children(4) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Standard.REF
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Transaction835_W1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF, Dom.Segments.REF)
			Private Property REF_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.REF
				Get
					If REFSubset_Transaction835_W1 Is Nothing Then
						REFSubset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF, Dom.Segments.REF)(Children(5), 1, 1, 11844)
					End If

					If REFSubset_Transaction835_W1.Count > 0 Then
						Return REFSubset_Transaction835_W1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF)
					If REFSubset_Transaction835_W1 Is Nothing Then
						REFSubset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF, Dom.Segments.REF)(Children(5), 1, 1, 11844)
					End If

					If REFSubset_Transaction835_W1.Count = 0 Then
						REFSubset_Transaction835_W1.Add(value)
					Else
						REFSubset_Transaction835_W1(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_Transaction835_W1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_1_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1 Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.REF_1
				Get
					If REF_1Subset_Transaction835_W1 Is Nothing Then
						REF_1Subset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1, Dom.Segments.REF)(Children(5), 1, 1, 216)
					End If

					If REF_1Subset_Transaction835_W1.Count > 0 Then
						Return REF_1Subset_Transaction835_W1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1)
					If REF_1Subset_Transaction835_W1 Is Nothing Then
						REF_1Subset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1, Dom.Segments.REF)(Children(5), 1, 1, 216)
					End If

					If REF_1Subset_Transaction835_W1.Count = 0 Then
						REF_1Subset_Transaction835_W1.Add(value)
					Else
						REF_1Subset_Transaction835_W1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Dom.Segments.DTM) Implements Dom.Transactions.Transaction835.Standard.DTM
				Get
					Return CType(Children(6), SegmentContainer(Of Dom.Segments.DTM))
				End Get
			End Property

			Private DTMSubset_Transaction835_W1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM, Dom.Segments.DTM)
			Private Property DTM_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.DTM
				Get
					If DTMSubset_Transaction835_W1 Is Nothing Then
						DTMSubset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM, Dom.Segments.DTM)(Children(6), 1, 1, 252)
					End If

					If DTMSubset_Transaction835_W1.Count > 0 Then
						Return DTMSubset_Transaction835_W1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM)
					If DTMSubset_Transaction835_W1 Is Nothing Then
						DTMSubset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM, Dom.Segments.DTM)(Children(6), 1, 1, 252)
					End If

					If DTMSubset_Transaction835_W1.Count = 0 Then
						DTMSubset_Transaction835_W1.Add(value)
					Else
						DTMSubset_Transaction835_W1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property Loop1000_Obj As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop1000) Implements Dom.Transactions.Transaction835.Standard.Loop1000
				Get
					Return CType(Children(7), LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop1000))
				End Get
			End Property

			Private Loop1000ASubset_Transaction835_W1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A, Dom.Transactions.Transaction835.Loops.Loop1000)
			Private Property Loop1000A_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.Loop1000A
				Get
					If Loop1000ASubset_Transaction835_W1 Is Nothing Then
						Loop1000ASubset_Transaction835_W1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A, Dom.Transactions.Transaction835.Loops.Loop1000)(Children(7), 1, 1, 288)
					End If

					If Loop1000ASubset_Transaction835_W1.Count > 0 Then
						Return Loop1000ASubset_Transaction835_W1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A)
					If Loop1000ASubset_Transaction835_W1 Is Nothing Then
						Loop1000ASubset_Transaction835_W1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A, Dom.Transactions.Transaction835.Loops.Loop1000)(Children(7), 1, 1, 288)
					End If

					If Loop1000ASubset_Transaction835_W1.Count = 0 Then
						Loop1000ASubset_Transaction835_W1.Add(value)
					Else
						Loop1000ASubset_Transaction835_W1(0) = value
					End If
				End Set
			End Property
			Private Loop1000BSubset_Transaction835_W1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B, Dom.Transactions.Transaction835.Loops.Loop1000)
			Private Property Loop1000B_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.Loop1000B
				Get
					If Loop1000BSubset_Transaction835_W1 Is Nothing Then
						Loop1000BSubset_Transaction835_W1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B, Dom.Transactions.Transaction835.Loops.Loop1000)(Children(7), 1, 1, 145)
					End If

					If Loop1000BSubset_Transaction835_W1.Count > 0 Then
						Return Loop1000BSubset_Transaction835_W1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B)
					If Loop1000BSubset_Transaction835_W1 Is Nothing Then
						Loop1000BSubset_Transaction835_W1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B, Dom.Transactions.Transaction835.Loops.Loop1000)(Children(7), 1, 1, 145)
					End If

					If Loop1000BSubset_Transaction835_W1.Count = 0 Then
						Loop1000BSubset_Transaction835_W1.Add(value)
					Else
						Loop1000BSubset_Transaction835_W1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2000) Implements Dom.Transactions.Transaction835.Standard.Loop2000
				Get
					Return CType(Children(8), LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2000))
				End Get
			End Property

			Private Loop2000Subset_Transaction835_W1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000, Dom.Transactions.Transaction835.Loops.Loop2000)
			Private ReadOnly Property Loop2000_Obj_1_Transaction835_W1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000, Dom.Transactions.Transaction835.Loops.Loop2000) Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.Loop2000
				Get
					If Loop2000Subset_Transaction835_W1 Is Nothing Then
						Loop2000Subset_Transaction835_W1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000, Dom.Transactions.Transaction835.Loops.Loop2000)(Children(8), 0, 2, 3888)
					End If

					Return Loop2000Subset_Transaction835_W1
				End Get
			End Property
			Friend ReadOnly Property PLB_Obj As SegmentContainer(Of Dom.Segments.PLB) Implements Dom.Transactions.Transaction835.Standard.PLB
				Get
					Return CType(Children(9), SegmentContainer(Of Dom.Segments.PLB))
				End Get
			End Property

			Private PLBSubset_Transaction835_W1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB, Dom.Segments.PLB)
			Private ReadOnly Property PLB_Transaction835_W1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB, Dom.Segments.PLB) Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.PLB
				Get
					If PLBSubset_Transaction835_W1 Is Nothing Then
						PLBSubset_Transaction835_W1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB, Dom.Segments.PLB)(Children(9), 0, 3, 36)
					End If

					Return PLBSubset_Transaction835_W1
				End Get
			End Property
			Friend Property SE_Obj As Dom.Segments.SE_Obj
				Get
					Return CType(Children(10), Dom.Segments.SE_Obj)
				End Get
				Set(value As Dom.Segments.SE_Obj)
					Children(10) = value
				End Set
			End Property

			Private Property SE_Std As Dom.Segments.SE Implements Dom.Transactions.Transaction835.Standard.SE
				Get
					Return CType(Children(10), Dom.Segments.SE_Obj)
				End Get
				Set(value As Dom.Segments.SE)
					Children(10) = value
				End Set
			End Property

			Private Property SE_IFace_Transaction835_W1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE Implements Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet.SE
				Get
					Return CType(Children(10), Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE)
					Children(10) = value
				End Set
			End Property
		End Class

		Partial Friend Class Loop1000_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction835.Loops.Loop1000,
													Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A,
													Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.N1_Obj),
																New SegmentContainer(Of Dom.Segments.N2)(0, 1, 900),
																New SegmentContainer(Of Dom.Segments.N3)(0, 1, 1000),
																CType(Nothing, Dom.Segments.N4_Obj),
																New SegmentContainer(Of Dom.Segments.REF)(0, 1, 1200),
																New SegmentContainer(Of Dom.Segments.PER)(0, 1, 1300),
																CType(Nothing, Dom.Segments.RDM_Obj),
																CType(Nothing, Dom.Segments.DTM_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "N1", ReadAction.PopulateSegment, 1, False),
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
												New ReaderState(7, "PER", ReadAction.PopulateSegment, 9, False),
												New ReaderState(9, "PER", ReadAction.PopulateSegment, 9, False),
												New ReaderState(1, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(2, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(4, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(6, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(7, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(9, "RDM", ReadAction.PopulateSegment, 11, False),
												New ReaderState(1, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(2, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(4, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(6, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(7, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(9, "DTM", ReadAction.PopulateSegment, 12, False),
												New ReaderState(11, "DTM", ReadAction.PopulateSegment, 12, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.N1_Obj)
					If MyBase.CompareKey(S2.N101, ";PR;") AndAlso String.Compare(args.Implementation, "_835W1__1000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 288
					ElseIf MyBase.CompareKey(S2.N101, ";PE;") AndAlso String.Compare(args.Implementation, "_835W1__1000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 145
					End If
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";2U;EO;HI;NF;") AndAlso String.Compare(args.Implementation, "_835W1__1000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 73
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;D3;PQ;TJ;") AndAlso String.Compare(args.Implementation, "_835W1__1000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 289
					End If
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "RDM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.RDM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RDM_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				args.Implementation = Temp

				Return Task.CompletedTask
			End Function
			Friend Property N1_Obj As Dom.Segments.N1_Obj
				Get
					Return CType(Children(0), Dom.Segments.N1_Obj)
				End Get
				Set(value As Dom.Segments.N1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property N1_Std As Dom.Segments.N1 Implements Dom.Transactions.Transaction835.Loops.Loop1000.N1
				Get
					Return CType(Children(0), Dom.Segments.N1_Obj)
				End Get
				Set(value As Dom.Segments.N1)
					Children(0) = value
				End Set
			End Property

			Private Property N1_IFace_Loop1000A_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.N1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1)
					Children(0) = value
				End Set
			End Property
			Private Property N1_IFace_1_Loop1000B_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B.N1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property N2_Obj As SegmentContainer(Of Dom.Segments.N2) Implements Dom.Transactions.Transaction835.Loops.Loop1000.N2
				Get
					Return CType(Children(1), SegmentContainer(Of Dom.Segments.N2))
				End Get
			End Property

			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Dom.Segments.N3) Implements Dom.Transactions.Transaction835.Loops.Loop1000.N3
				Get
					Return CType(Children(2), SegmentContainer(Of Dom.Segments.N3))
				End Get
			End Property

			Private N3Subset_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3, Dom.Segments.N3)
			Private Property N3_IFace_Loop1000A_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.N3
				Get
					If N3Subset_Loop1000A_Obj Is Nothing Then
						N3Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3, Dom.Segments.N3)(Children(2), 1, 1, 1)
					End If

					If N3Subset_Loop1000A_Obj.Count > 0 Then
						Return N3Subset_Loop1000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3)
					If N3Subset_Loop1000A_Obj Is Nothing Then
						N3Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3, Dom.Segments.N3)(Children(2), 1, 1, 1)
					End If

					If N3Subset_Loop1000A_Obj.Count = 0 Then
						N3Subset_Loop1000A_Obj.Add(value)
					Else
						N3Subset_Loop1000A_Obj(0) = value
					End If
				End Set
			End Property
			Private N3Subset_1_Loop1000B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3, Dom.Segments.N3)
			Private Property N3_IFace_1_Loop1000B_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B.N3
				Get
					If N3Subset_1_Loop1000B_Obj Is Nothing Then
						N3Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3, Dom.Segments.N3)(Children(2), 1, 1, 217)
					End If

					If N3Subset_1_Loop1000B_Obj.Count > 0 Then
						Return N3Subset_1_Loop1000B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3)
					If N3Subset_1_Loop1000B_Obj Is Nothing Then
						N3Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3, Dom.Segments.N3)(Children(2), 1, 1, 217)
					End If

					If N3Subset_1_Loop1000B_Obj.Count = 0 Then
						N3Subset_1_Loop1000B_Obj.Add(value)
					Else
						N3Subset_1_Loop1000B_Obj(0) = value
					End If
				End Set
			End Property
			Friend Property N4_Obj As Dom.Segments.N4_Obj
				Get
					Return CType(Children(3), Dom.Segments.N4_Obj)
				End Get
				Set(value As Dom.Segments.N4_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N4_Std As Dom.Segments.N4 Implements Dom.Transactions.Transaction835.Loops.Loop1000.N4
				Get
					Return CType(Children(3), Dom.Segments.N4_Obj)
				End Get
				Set(value As Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Private Property N4_IFace_Loop1000A_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.N4
				Get
					Return CType(Children(3), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_1_Loop1000B_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B.N4
				Get
					Return CType(Children(3), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4)
					Children(3) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Loops.Loop1000.REF
				Get
					Return CType(Children(4), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.REF
				Get
					If REFSubset_Loop1000A_Obj Is Nothing Then
						REFSubset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF, Dom.Segments.REF)(Children(4), 4, 1, 73)
					End If

					Return REFSubset_Loop1000A_Obj
				End Get
			End Property
			Private REFSubset_1_Loop1000B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop1000B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B.REF
				Get
					If REFSubset_1_Loop1000B_Obj Is Nothing Then
						REFSubset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF, Dom.Segments.REF)(Children(4), 0, 1, 289)
					End If

					Return REFSubset_1_Loop1000B_Obj
				End Get
			End Property
			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Dom.Segments.PER) Implements Dom.Transactions.Transaction835.Loops.Loop1000.PER
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.PER))
				End Get
			End Property

			Private PERSubset_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER, Dom.Segments.PER)
			Private Property PER_IFace_Loop1000A_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.PER
				Get
					If PERSubset_Loop1000A_Obj Is Nothing Then
						PERSubset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER, Dom.Segments.PER)(Children(5), 1, 1, 109)
					End If

					If PERSubset_Loop1000A_Obj.Count > 0 Then
						Return PERSubset_Loop1000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER)
					If PERSubset_Loop1000A_Obj Is Nothing Then
						PERSubset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER, Dom.Segments.PER)(Children(5), 1, 1, 109)
					End If

					If PERSubset_Loop1000A_Obj.Count = 0 Then
						PERSubset_Loop1000A_Obj.Add(value)
					Else
						PERSubset_Loop1000A_Obj(0) = value
					End If
				End Set
			End Property
			Private PER_1Subset_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1, Dom.Segments.PER)
			Private ReadOnly Property PER_1_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1, Dom.Segments.PER) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.PER_1
				Get
					If PER_1Subset_Loop1000A_Obj Is Nothing Then
						PER_1Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1, Dom.Segments.PER)(Children(5), 0, 1, 140077)
					End If

					Return PER_1Subset_Loop1000A_Obj
				End Get
			End Property
			Private PER_2Subset_Loop1000A_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2, Dom.Segments.PER)
			Private Property PER_IFace_2_Loop1000A_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A.PER_2
				Get
					If PER_2Subset_Loop1000A_Obj Is Nothing Then
						PER_2Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2, Dom.Segments.PER)(Children(5), 1, 1, 233389)
					End If

					If PER_2Subset_Loop1000A_Obj.Count > 0 Then
						Return PER_2Subset_Loop1000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2)
					If PER_2Subset_Loop1000A_Obj Is Nothing Then
						PER_2Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2, Dom.Segments.PER)(Children(5), 1, 1, 233389)
					End If

					If PER_2Subset_Loop1000A_Obj.Count = 0 Then
						PER_2Subset_Loop1000A_Obj.Add(value)
					Else
						PER_2Subset_Loop1000A_Obj(0) = value
					End If
				End Set
			End Property
			Friend Property RDM_Obj As Dom.Segments.RDM_Obj
				Get
					Return CType(Children(6), Dom.Segments.RDM_Obj)
				End Get
				Set(value As Dom.Segments.RDM_Obj)
					Children(6) = value
				End Set
			End Property

			Private Property RDM_Std As Dom.Segments.RDM Implements Dom.Transactions.Transaction835.Loops.Loop1000.RDM
				Get
					Return CType(Children(6), Dom.Segments.RDM_Obj)
				End Get
				Set(value As Dom.Segments.RDM)
					Children(6) = value
				End Set
			End Property

			Private Property RDM_IFace_Loop1000B_Obj As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B.RDM
				Get
					Return CType(Children(6), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM)
					Children(6) = value
				End Set
			End Property
			Friend Property DTM_Obj As Dom.Segments.DTM_Obj
				Get
					Return CType(Children(7), Dom.Segments.DTM_Obj)
				End Get
				Set(value As Dom.Segments.DTM_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property DTM_Std As Dom.Segments.DTM Implements Dom.Transactions.Transaction835.Loops.Loop1000.DTM
				Get
					Return CType(Children(7), Dom.Segments.DTM_Obj)
				End Get
				Set(value As Dom.Segments.DTM)
					Children(7) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2000_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction835.Loops.Loop2000,
													Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.LX_Obj),
																CType(Nothing, Dom.Segments.TS3_Obj),
																CType(Nothing, Dom.Segments.TS2_Obj),
																New LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2100)(0, 2, 100)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LX", ReadAction.PopulateSegment, 1, False),
												New ReaderState(1, "TS3", ReadAction.PopulateSegment, 2, False),
												New ReaderState(1, "TS2", ReadAction.PopulateSegment, 3, False),
												New ReaderState(2, "TS2", ReadAction.PopulateSegment, 3, False),
												New ReaderState(1, "CLP", ReadAction.PopulateLoop, 4, False),
												New ReaderState(2, "CLP", ReadAction.PopulateLoop, 4, False),
												New ReaderState(3, "CLP", ReadAction.PopulateLoop, 4, False),
												New ReaderState(4, "CLP", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.LX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LX_Obj = Seg
				ElseIf String.Compare(SegmentName, "TS3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.TS3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TS3_Obj = Seg
				ElseIf String.Compare(SegmentName, "TS2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.TS2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TS2_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "CLP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction835.Loop2100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2100_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_835W1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_835W1__2000__2100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property LX_Obj As Dom.Segments.LX_Obj
				Get
					Return CType(Children(0), Dom.Segments.LX_Obj)
				End Get
				Set(value As Dom.Segments.LX_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property LX_Std As Dom.Segments.LX Implements Dom.Transactions.Transaction835.Loops.Loop2000.LX
				Get
					Return CType(Children(0), Dom.Segments.LX_Obj)
				End Get
				Set(value As Dom.Segments.LX)
					Children(0) = value
				End Set
			End Property

			Private Property LX_IFace_Loop2000_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000.LX
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX)
					Children(0) = value
				End Set
			End Property
			Friend Property TS3_Obj As Dom.Segments.TS3_Obj
				Get
					Return CType(Children(1), Dom.Segments.TS3_Obj)
				End Get
				Set(value As Dom.Segments.TS3_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property TS3_Std As Dom.Segments.TS3 Implements Dom.Transactions.Transaction835.Loops.Loop2000.TS3
				Get
					Return CType(Children(1), Dom.Segments.TS3_Obj)
				End Get
				Set(value As Dom.Segments.TS3)
					Children(1) = value
				End Set
			End Property

			Private Property TS3_IFace_Loop2000_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000.TS3
				Get
					Return CType(Children(1), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3)
					Children(1) = value
				End Set
			End Property
			Friend Property TS2_Obj As Dom.Segments.TS2_Obj
				Get
					Return CType(Children(2), Dom.Segments.TS2_Obj)
				End Get
				Set(value As Dom.Segments.TS2_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property TS2_Std As Dom.Segments.TS2 Implements Dom.Transactions.Transaction835.Loops.Loop2000.TS2
				Get
					Return CType(Children(2), Dom.Segments.TS2_Obj)
				End Get
				Set(value As Dom.Segments.TS2)
					Children(2) = value
				End Set
			End Property

			Private Property TS2_IFace_Loop2000_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000.TS2
				Get
					Return CType(Children(2), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2)
					Children(2) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2100) Implements Dom.Transactions.Transaction835.Loops.Loop2000.Loop2100
				Get
					Return CType(Children(3), LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2100))
				End Get
			End Property

			Private Loop2100Subset_Loop2000_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100, Dom.Transactions.Transaction835.Loops.Loop2100)
			Private ReadOnly Property Loop2100_Obj_1_Loop2000_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100, Dom.Transactions.Transaction835.Loops.Loop2100) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000.Loop2100
				Get
					If Loop2100Subset_Loop2000_Obj_1 Is Nothing Then
						Loop2100Subset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100, Dom.Transactions.Transaction835.Loops.Loop2100)(Children(3), 0, 2, 36)
					End If

					Return Loop2100Subset_Loop2000_Obj_1
				End Get
			End Property

		End Class
		Partial Friend Class Loop2100_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction835.Loops.Loop2100,
													Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.CLP_Obj),
																New SegmentContainer(Of Dom.Segments.CAS)(99, 2, 200),
																New SegmentContainer(Of Dom.Segments.NM1)(9, 2, 300),
																CType(Nothing, Dom.Segments.MIA_Obj),
																CType(Nothing, Dom.Segments.MOA_Obj),
																New SegmentContainer(Of Dom.Segments.REF)(99, 2, 400),
																New SegmentContainer(Of Dom.Segments.DTM)(9, 2, 500),
																New SegmentContainer(Of Dom.Segments.PER)(3, 2, 600),
																New SegmentContainer(Of Dom.Segments.AMT)(20, 2, 620),
																New SegmentContainer(Of Dom.Segments.QTY)(20, 2, 640),
																New LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2110)(999, 2, 700)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "CLP", ReadAction.PopulateSegment, 1, False),
												New ReaderState(1, "CAS", ReadAction.PopulateSegment, 2, False),
												New ReaderState(2, "CAS", ReadAction.PopulateSegment, 2, False),
												New ReaderState(1, "NM1", ReadAction.PopulateSegment, 4, False),
												New ReaderState(2, "NM1", ReadAction.PopulateSegment, 4, False),
												New ReaderState(4, "NM1", ReadAction.PopulateSegment, 4, False),
												New ReaderState(4, "MIA", ReadAction.PopulateSegment, 6, False),
												New ReaderState(4, "MOA", ReadAction.PopulateSegment, 7, False),
												New ReaderState(6, "MOA", ReadAction.PopulateSegment, 7, False),
												New ReaderState(4, "REF", ReadAction.PopulateSegment, 8, False),
												New ReaderState(6, "REF", ReadAction.PopulateSegment, 8, False),
												New ReaderState(7, "REF", ReadAction.PopulateSegment, 8, False),
												New ReaderState(8, "REF", ReadAction.PopulateSegment, 8, False),
												New ReaderState(4, "DTM", ReadAction.PopulateSegment, 10, False),
												New ReaderState(6, "DTM", ReadAction.PopulateSegment, 10, False),
												New ReaderState(7, "DTM", ReadAction.PopulateSegment, 10, False),
												New ReaderState(8, "DTM", ReadAction.PopulateSegment, 10, False),
												New ReaderState(10, "DTM", ReadAction.PopulateSegment, 10, False),
												New ReaderState(4, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(6, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(7, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(8, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(10, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(12, "PER", ReadAction.PopulateSegment, 12, False),
												New ReaderState(4, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(6, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(7, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(8, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(10, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(12, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(14, "AMT", ReadAction.PopulateSegment, 14, False),
												New ReaderState(4, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(6, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(7, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(8, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(10, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(12, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(14, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(16, "QTY", ReadAction.PopulateSegment, 16, False),
												New ReaderState(4, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(6, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(7, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(8, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(10, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(12, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(14, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(16, "SVC", ReadAction.PopulateLoop, 18, False),
												New ReaderState(18, "SVC", ReadAction.PopulateLoop, 18, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "CLP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CLP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CLP_Obj = Seg
				ElseIf String.Compare(SegmentName, "CAS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CAS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CAS_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";QC;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 11736
					ElseIf MyBase.CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 108
					ElseIf MyBase.CompareKey(S2.NM101, ";74;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 1404
					ElseIf MyBase.CompareKey(S2.NM101, ";82;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 2700
					ElseIf MyBase.CompareKey(S2.NM101, ";TT;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 3996
					ElseIf MyBase.CompareKey(S2.NM101, ";PR;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 5292
					ElseIf MyBase.CompareKey(S2.NM101, ";GB;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 6588
					End If
				ElseIf String.Compare(SegmentName, "MIA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.MIA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					MIA_Obj = Seg
				ElseIf String.Compare(SegmentName, "MOA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.MOA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					MOA_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";1L;1W;28;6P;9A;9C;BB;CE;EA;F8;G1;G3;IG;SY;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 144
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1A;1B;1C;1D;1G;1H;1J;D3;G2;LU;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 6624
					End If
				ElseIf String.Compare(SegmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.DTM_Obj)
					If MyBase.CompareKey(S2.DTM01, ";232;233;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 180
					ElseIf MyBase.CompareKey(S2.DTM01, ";036;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 233460
					ElseIf MyBase.CompareKey(S2.DTM01, ";050;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 1476
					End If
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.AMT_Obj)
					If MyBase.CompareKey(S2.AMT01, ";AU;D8;DY;F5;I;NL;T;T2;ZK;ZL;ZM;ZN;ZO;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 2808
					End If
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.QTY_Obj)
					If MyBase.CompareKey(S2.QTY01, ";CA;CD;LA;LE;NE;NR;OU;PS;VS;ZK;ZL;ZM;ZN;ZO;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 5400
					End If
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "SVC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction835.Loop2110_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2110_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_835W1__2000__2100", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_835W1__2000__2100__2110"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property CLP_Obj As Dom.Segments.CLP_Obj
				Get
					Return CType(Children(0), Dom.Segments.CLP_Obj)
				End Get
				Set(value As Dom.Segments.CLP_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property CLP_Std As Dom.Segments.CLP Implements Dom.Transactions.Transaction835.Loops.Loop2100.CLP
				Get
					Return CType(Children(0), Dom.Segments.CLP_Obj)
				End Get
				Set(value As Dom.Segments.CLP)
					Children(0) = value
				End Set
			End Property

			Private Property CLP_IFace_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.CLP
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property CAS_Obj As SegmentContainer(Of Dom.Segments.CAS) Implements Dom.Transactions.Transaction835.Loops.Loop2100.CAS
				Get
					Return CType(Children(1), SegmentContainer(Of Dom.Segments.CAS))
				End Get
			End Property

			Private CASSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS, Dom.Segments.CAS)
			Private ReadOnly Property CAS_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS, Dom.Segments.CAS) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.CAS
				Get
					If CASSubset_Loop2100_Obj_1 Is Nothing Then
						CASSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS, Dom.Segments.CAS)(Children(1), 99, 2, 72)
					End If

					Return CASSubset_Loop2100_Obj_1
				End Get
			End Property
			Friend ReadOnly Property NM1_Obj As SegmentContainer(Of Dom.Segments.NM1) Implements Dom.Transactions.Transaction835.Loops.Loop2100.NM1
				Get
					Return CType(Children(2), SegmentContainer(Of Dom.Segments.NM1))
				End Get
			End Property

			Private NM1Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1, Dom.Segments.NM1)
			Private Property NM1_IFace_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1
				Get
					If NM1Subset_Loop2100_Obj_1 Is Nothing Then
						NM1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1, Dom.Segments.NM1)(Children(2), 1, 2, 11736)
					End If

					If NM1Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1)
					If NM1Subset_Loop2100_Obj_1 Is Nothing Then
						NM1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1, Dom.Segments.NM1)(Children(2), 1, 2, 11736)
					End If

					If NM1Subset_Loop2100_Obj_1.Count = 0 Then
						NM1Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_1Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1, Dom.Segments.NM1)
			Private Property NM1_IFace_1_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_1
				Get
					If NM1_1Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1, Dom.Segments.NM1)(Children(2), 1, 2, 108)
					End If

					If NM1_1Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_1Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1)
					If NM1_1Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1, Dom.Segments.NM1)(Children(2), 1, 2, 108)
					End If

					If NM1_1Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_1Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_1Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_2Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2, Dom.Segments.NM1)
			Private Property NM1_IFace_2_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_2
				Get
					If NM1_2Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_2Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2, Dom.Segments.NM1)(Children(2), 1, 2, 1404)
					End If

					If NM1_2Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_2Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2)
					If NM1_2Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_2Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2, Dom.Segments.NM1)(Children(2), 1, 2, 1404)
					End If

					If NM1_2Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_2Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_2Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_3Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3, Dom.Segments.NM1)
			Private Property NM1_IFace_3_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_3
				Get
					If NM1_3Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_3Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3, Dom.Segments.NM1)(Children(2), 1, 2, 2700)
					End If

					If NM1_3Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_3Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3)
					If NM1_3Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_3Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3, Dom.Segments.NM1)(Children(2), 1, 2, 2700)
					End If

					If NM1_3Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_3Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_3Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_4Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4, Dom.Segments.NM1)
			Private Property NM1_IFace_4_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_4
				Get
					If NM1_4Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_4Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4, Dom.Segments.NM1)(Children(2), 1, 2, 3996)
					End If

					If NM1_4Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_4Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4)
					If NM1_4Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_4Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4, Dom.Segments.NM1)(Children(2), 1, 2, 3996)
					End If

					If NM1_4Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_4Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_4Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_5Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5, Dom.Segments.NM1)
			Private Property NM1_IFace_5_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_5
				Get
					If NM1_5Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_5Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5, Dom.Segments.NM1)(Children(2), 1, 2, 5292)
					End If

					If NM1_5Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_5Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5)
					If NM1_5Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_5Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5, Dom.Segments.NM1)(Children(2), 1, 2, 5292)
					End If

					If NM1_5Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_5Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_5Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private NM1_6Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6, Dom.Segments.NM1)
			Private Property NM1_IFace_6_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.NM1_6
				Get
					If NM1_6Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_6Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6, Dom.Segments.NM1)(Children(2), 1, 2, 6588)
					End If

					If NM1_6Subset_Loop2100_Obj_1.Count > 0 Then
						Return NM1_6Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6)
					If NM1_6Subset_Loop2100_Obj_1 Is Nothing Then
						NM1_6Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6, Dom.Segments.NM1)(Children(2), 1, 2, 6588)
					End If

					If NM1_6Subset_Loop2100_Obj_1.Count = 0 Then
						NM1_6Subset_Loop2100_Obj_1.Add(value)
					Else
						NM1_6Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend Property MIA_Obj As Dom.Segments.MIA_Obj
				Get
					Return CType(Children(3), Dom.Segments.MIA_Obj)
				End Get
				Set(value As Dom.Segments.MIA_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property MIA_Std As Dom.Segments.MIA Implements Dom.Transactions.Transaction835.Loops.Loop2100.MIA
				Get
					Return CType(Children(3), Dom.Segments.MIA_Obj)
				End Get
				Set(value As Dom.Segments.MIA)
					Children(3) = value
				End Set
			End Property

			Private Property MIA_IFace_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.MIA
				Get
					Return CType(Children(3), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA)
					Children(3) = value
				End Set
			End Property
			Friend Property MOA_Obj As Dom.Segments.MOA_Obj
				Get
					Return CType(Children(4), Dom.Segments.MOA_Obj)
				End Get
				Set(value As Dom.Segments.MOA_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property MOA_Std As Dom.Segments.MOA Implements Dom.Transactions.Transaction835.Loops.Loop2100.MOA
				Get
					Return CType(Children(4), Dom.Segments.MOA_Obj)
				End Get
				Set(value As Dom.Segments.MOA)
					Children(4) = value
				End Set
			End Property

			Private Property MOA_IFace_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.MOA
				Get
					Return CType(Children(4), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA)
					Children(4) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Loops.Loop2100.REF
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.REF
				Get
					If REFSubset_Loop2100_Obj_1 Is Nothing Then
						REFSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF, Dom.Segments.REF)(Children(5), 5, 2, 144)
					End If

					Return REFSubset_Loop2100_Obj_1
				End Get
			End Property
			Private REF_1Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1, Dom.Segments.REF)
			Private ReadOnly Property REF_1_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.REF_1
				Get
					If REF_1Subset_Loop2100_Obj_1 Is Nothing Then
						REF_1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1, Dom.Segments.REF)(Children(5), 10, 2, 6624)
					End If

					Return REF_1Subset_Loop2100_Obj_1
				End Get
			End Property
			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Dom.Segments.DTM) Implements Dom.Transactions.Transaction835.Loops.Loop2100.DTM
				Get
					Return CType(Children(6), SegmentContainer(Of Dom.Segments.DTM))
				End Get
			End Property

			Private DTMSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM, Dom.Segments.DTM)
			Private ReadOnly Property DTM_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM, Dom.Segments.DTM) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.DTM
				Get
					If DTMSubset_Loop2100_Obj_1 Is Nothing Then
						DTMSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM, Dom.Segments.DTM)(Children(6), 2, 2, 180)
					End If

					Return DTMSubset_Loop2100_Obj_1
				End Get
			End Property
			Private DTM_1Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1, Dom.Segments.DTM)
			Private Property DTM_IFace_1_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.DTM_1
				Get
					If DTM_1Subset_Loop2100_Obj_1 Is Nothing Then
						DTM_1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1, Dom.Segments.DTM)(Children(6), 1, 2, 233460)
					End If

					If DTM_1Subset_Loop2100_Obj_1.Count > 0 Then
						Return DTM_1Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1)
					If DTM_1Subset_Loop2100_Obj_1 Is Nothing Then
						DTM_1Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1, Dom.Segments.DTM)(Children(6), 1, 2, 233460)
					End If

					If DTM_1Subset_Loop2100_Obj_1.Count = 0 Then
						DTM_1Subset_Loop2100_Obj_1.Add(value)
					Else
						DTM_1Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTM_2Subset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2, Dom.Segments.DTM)
			Private Property DTM_IFace_2_Loop2100_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.DTM_2
				Get
					If DTM_2Subset_Loop2100_Obj_1 Is Nothing Then
						DTM_2Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2, Dom.Segments.DTM)(Children(6), 1, 2, 1476)
					End If

					If DTM_2Subset_Loop2100_Obj_1.Count > 0 Then
						Return DTM_2Subset_Loop2100_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2)
					If DTM_2Subset_Loop2100_Obj_1 Is Nothing Then
						DTM_2Subset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2, Dom.Segments.DTM)(Children(6), 1, 2, 1476)
					End If

					If DTM_2Subset_Loop2100_Obj_1.Count = 0 Then
						DTM_2Subset_Loop2100_Obj_1.Add(value)
					Else
						DTM_2Subset_Loop2100_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Dom.Segments.PER) Implements Dom.Transactions.Transaction835.Loops.Loop2100.PER
				Get
					Return CType(Children(7), SegmentContainer(Of Dom.Segments.PER))
				End Get
			End Property

			Private PERSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER, Dom.Segments.PER)
			Private ReadOnly Property PER_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER, Dom.Segments.PER) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.PER
				Get
					If PERSubset_Loop2100_Obj_1 Is Nothing Then
						PERSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER, Dom.Segments.PER)(Children(7), 2, 2, 216)
					End If

					Return PERSubset_Loop2100_Obj_1
				End Get
			End Property
			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Dom.Segments.AMT) Implements Dom.Transactions.Transaction835.Loops.Loop2100.AMT
				Get
					Return CType(Children(8), SegmentContainer(Of Dom.Segments.AMT))
				End Get
			End Property

			Private AMTSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT, Dom.Segments.AMT)
			Private ReadOnly Property AMT_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT, Dom.Segments.AMT) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.AMT
				Get
					If AMTSubset_Loop2100_Obj_1 Is Nothing Then
						AMTSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT, Dom.Segments.AMT)(Children(8), 13, 2, 2808)
					End If

					Return AMTSubset_Loop2100_Obj_1
				End Get
			End Property
			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Dom.Segments.QTY) Implements Dom.Transactions.Transaction835.Loops.Loop2100.QTY
				Get
					Return CType(Children(9), SegmentContainer(Of Dom.Segments.QTY))
				End Get
			End Property

			Private QTYSubset_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY, Dom.Segments.QTY)
			Private ReadOnly Property QTY_Loop2100_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY, Dom.Segments.QTY) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.QTY
				Get
					If QTYSubset_Loop2100_Obj_1 Is Nothing Then
						QTYSubset_Loop2100_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY, Dom.Segments.QTY)(Children(9), 14, 2, 5400)
					End If

					Return QTYSubset_Loop2100_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2110_Obj As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2110) Implements Dom.Transactions.Transaction835.Loops.Loop2100.Loop2110
				Get
					Return CType(Children(10), LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2110))
				End Get
			End Property

			Private Loop2110Subset_Loop2100_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110, Dom.Transactions.Transaction835.Loops.Loop2110)
			Private ReadOnly Property Loop2110_Obj_1_Loop2100_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110, Dom.Transactions.Transaction835.Loops.Loop2110) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100.Loop2110
				Get
					If Loop2110Subset_Loop2100_Obj_1 Is Nothing Then
						Loop2110Subset_Loop2100_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110, Dom.Transactions.Transaction835.Loops.Loop2110)(Children(10), 999, 2, 252)
					End If

					Return Loop2110Subset_Loop2100_Obj_1
				End Get
			End Property

		End Class
		Partial Friend Class Loop2110_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction835.Loops.Loop2110,
													Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.SVC_Obj),
																New SegmentContainer(Of Dom.Segments.DTM)(9, 2, 800),
																New SegmentContainer(Of Dom.Segments.CAS)(99, 2, 900),
																New SegmentContainer(Of Dom.Segments.REF)(99, 2, 1000),
																New SegmentContainer(Of Dom.Segments.AMT)(20, 2, 1100),
																New SegmentContainer(Of Dom.Segments.QTY)(20, 2, 1200),
																New SegmentContainer(Of Dom.Segments.LQ)(99, 2, 1300)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SVC", ReadAction.PopulateSegment, 1, False),
												New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
												New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False),
												New ReaderState(1, "CAS", ReadAction.PopulateSegment, 4, False),
												New ReaderState(2, "CAS", ReadAction.PopulateSegment, 4, False),
												New ReaderState(4, "CAS", ReadAction.PopulateSegment, 4, False),
												New ReaderState(1, "REF", ReadAction.PopulateSegment, 6, False),
												New ReaderState(2, "REF", ReadAction.PopulateSegment, 6, False),
												New ReaderState(4, "REF", ReadAction.PopulateSegment, 6, False),
												New ReaderState(6, "REF", ReadAction.PopulateSegment, 6, False),
												New ReaderState(1, "AMT", ReadAction.PopulateSegment, 8, False),
												New ReaderState(2, "AMT", ReadAction.PopulateSegment, 8, False),
												New ReaderState(4, "AMT", ReadAction.PopulateSegment, 8, False),
												New ReaderState(6, "AMT", ReadAction.PopulateSegment, 8, False),
												New ReaderState(8, "AMT", ReadAction.PopulateSegment, 8, False),
												New ReaderState(1, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(2, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(4, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(6, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(8, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(10, "QTY", ReadAction.PopulateSegment, 10, False),
												New ReaderState(1, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(2, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(4, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(6, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(8, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(10, "LQ", ReadAction.PopulateSegment, 12, False),
												New ReaderState(12, "LQ", ReadAction.PopulateSegment, 12, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "SVC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SVC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SVC_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.DTM_Obj)
					If MyBase.CompareKey(S2.DTM01, ";150;151;472;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 288
					End If
				ElseIf String.Compare(SegmentName, "CAS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CAS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CAS_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";1S;APC;BB;E9;G1;G3;LU;RB;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 1
					ElseIf MyBase.CompareKey(S2.REF01, ";6R;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 1297
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1A;1B;1C;1D;1G;1H;1J;D3;G2;HPI;SY;TJ;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 6481
					ElseIf MyBase.CompareKey(S2.REF01, ";0K;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 7777
					End If
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.AMT_Obj)
					If MyBase.CompareKey(S2.AMT01, ";B6;KH;T;T2;ZK;ZL;ZM;ZN;ZO;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 37
					End If
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.QTY_Obj)
					If MyBase.CompareKey(S2.QTY01, ";ZK;ZL;ZM;ZN;ZO;") AndAlso String.Compare(args.Implementation, "_835W1__2000__2100__2110", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 73
					End If
				ElseIf String.Compare(SegmentName, "LQ", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.LQ_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LQ_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				args.Implementation = Temp

				Return Task.CompletedTask
			End Function
			Friend Property SVC_Obj As Dom.Segments.SVC_Obj
				Get
					Return CType(Children(0), Dom.Segments.SVC_Obj)
				End Get
				Set(value As Dom.Segments.SVC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SVC_Std As Dom.Segments.SVC Implements Dom.Transactions.Transaction835.Loops.Loop2110.SVC
				Get
					Return CType(Children(0), Dom.Segments.SVC_Obj)
				End Get
				Set(value As Dom.Segments.SVC)
					Children(0) = value
				End Set
			End Property

			Private Property SVC_IFace_Loop2110_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.SVC
				Get
					Return CType(Children(0), Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC)
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Dom.Segments.DTM) Implements Dom.Transactions.Transaction835.Loops.Loop2110.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Dom.Segments.DTM))
				End Get
			End Property

			Private DTMSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM, Dom.Segments.DTM)
			Private ReadOnly Property DTM_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM, Dom.Segments.DTM) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.DTM
				Get
					If DTMSubset_Loop2110_Obj_1 Is Nothing Then
						DTMSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM, Dom.Segments.DTM)(Children(1), 2, 2, 288)
					End If

					Return DTMSubset_Loop2110_Obj_1
				End Get
			End Property
			Friend ReadOnly Property CAS_Obj As SegmentContainer(Of Dom.Segments.CAS) Implements Dom.Transactions.Transaction835.Loops.Loop2110.CAS
				Get
					Return CType(Children(2), SegmentContainer(Of Dom.Segments.CAS))
				End Get
			End Property

			Private CASSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS, Dom.Segments.CAS)
			Private ReadOnly Property CAS_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS, Dom.Segments.CAS) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.CAS
				Get
					If CASSubset_Loop2110_Obj_1 Is Nothing Then
						CASSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS, Dom.Segments.CAS)(Children(2), 99, 2, 324)
					End If

					Return CASSubset_Loop2110_Obj_1
				End Get
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Loops.Loop2110.REF
				Get
					Return CType(Children(3), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.REF
				Get
					If REFSubset_Loop2110_Obj_1 Is Nothing Then
						REFSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF, Dom.Segments.REF)(Children(3), 8, 2, 1)
					End If

					Return REFSubset_Loop2110_Obj_1
				End Get
			End Property
			Private REF_1Subset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_1_Loop2110_Obj_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1 Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.REF_1
				Get
					If REF_1Subset_Loop2110_Obj_1 Is Nothing Then
						REF_1Subset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1, Dom.Segments.REF)(Children(3), 1, 2, 1297)
					End If

					If REF_1Subset_Loop2110_Obj_1.Count > 0 Then
						Return REF_1Subset_Loop2110_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1)
					If REF_1Subset_Loop2110_Obj_1 Is Nothing Then
						REF_1Subset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1, Dom.Segments.REF)(Children(3), 1, 2, 1297)
					End If

					If REF_1Subset_Loop2110_Obj_1.Count = 0 Then
						REF_1Subset_Loop2110_Obj_1.Add(value)
					Else
						REF_1Subset_Loop2110_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REF_2Subset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2, Dom.Segments.REF)
			Private ReadOnly Property REF_2_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.REF_2
				Get
					If REF_2Subset_Loop2110_Obj_1 Is Nothing Then
						REF_2Subset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2, Dom.Segments.REF)(Children(3), 10, 2, 6481)
					End If

					Return REF_2Subset_Loop2110_Obj_1
				End Get
			End Property
			Private REF_3Subset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3, Dom.Segments.REF)
			Private ReadOnly Property REF_3_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3, Dom.Segments.REF) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.REF_3
				Get
					If REF_3Subset_Loop2110_Obj_1 Is Nothing Then
						REF_3Subset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3, Dom.Segments.REF)(Children(3), 5, 2, 7777)
					End If

					Return REF_3Subset_Loop2110_Obj_1
				End Get
			End Property
			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Dom.Segments.AMT) Implements Dom.Transactions.Transaction835.Loops.Loop2110.AMT
				Get
					Return CType(Children(4), SegmentContainer(Of Dom.Segments.AMT))
				End Get
			End Property

			Private AMTSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT, Dom.Segments.AMT)
			Private ReadOnly Property AMT_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT, Dom.Segments.AMT) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.AMT
				Get
					If AMTSubset_Loop2110_Obj_1 Is Nothing Then
						AMTSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT, Dom.Segments.AMT)(Children(4), 9, 2, 37)
					End If

					Return AMTSubset_Loop2110_Obj_1
				End Get
			End Property
			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Dom.Segments.QTY) Implements Dom.Transactions.Transaction835.Loops.Loop2110.QTY
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.QTY))
				End Get
			End Property

			Private QTYSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY, Dom.Segments.QTY)
			Private ReadOnly Property QTY_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY, Dom.Segments.QTY) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.QTY
				Get
					If QTYSubset_Loop2110_Obj_1 Is Nothing Then
						QTYSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY, Dom.Segments.QTY)(Children(5), 6, 2, 73)
					End If

					Return QTYSubset_Loop2110_Obj_1
				End Get
			End Property
			Friend ReadOnly Property LQ_Obj As SegmentContainer(Of Dom.Segments.LQ) Implements Dom.Transactions.Transaction835.Loops.Loop2110.LQ
				Get
					Return CType(Children(6), SegmentContainer(Of Dom.Segments.LQ))
				End Get
			End Property

			Private LQSubset_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ, Dom.Segments.LQ)
			Private ReadOnly Property LQ_Loop2110_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ, Dom.Segments.LQ) Implements Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110.LQ
				Get
					If LQSubset_Loop2110_Obj_1 Is Nothing Then
						LQSubset_Loop2110_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ, Dom.Segments.LQ)(Children(6), 99, 2, 109)
					End If

					Return LQSubset_Loop2110_Obj_1
				End Get
			End Property

		End Class
		'''<summary>Health Care Claim Payment/Advice</summary>
		'''<remarks></remarks>
		Public Interface Standard
			'''<summary>Transaction Set Header</summary>
			Property ST As Dom.Segments.ST
			'''<summary>Beginning Segment for Payment Order/Remittance Advice</summary>
			Property BPR As Dom.Segments.BPR
			'''<summary>Note/Special Instruction</summary>
			ReadOnly Property NTE As SegmentContainer(Of Dom.Segments.NTE)
			'''<summary>Trace</summary>
			Property TRN As Dom.Segments.TRN
			'''<summary>Currency</summary>
			Property CUR As Dom.Segments.CUR
			'''<summary>Reference Information</summary>
			ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
			'''<summary>Date/Time Reference</summary>
			ReadOnly Property DTM As SegmentContainer(Of Dom.Segments.DTM)
			'''<summary>Party Identification</summary>
			ReadOnly Property Loop1000 As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop1000)
			'''<summary>Transaction Set Line Number</summary>
			ReadOnly Property Loop2000 As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2000)
			'''<summary>Provider Level Adjustment</summary>
			ReadOnly Property PLB As SegmentContainer(Of Dom.Segments.PLB)
			'''<summary>Transaction Set Trailer</summary>
			Property SE As Dom.Segments.SE
		End Interface
		Namespace Loops

			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop1000
				Inherits ILoop
				'''<summary>Party Identification</summary>
				Property N1 As Dom.Segments.N1
				'''<summary>Additional Name Information</summary>
				ReadOnly Property N2 As SegmentContainer(Of Dom.Segments.N2)
				'''<summary>Party Location</summary>
				ReadOnly Property N3 As SegmentContainer(Of Dom.Segments.N3)
				'''<summary>Geographic Location</summary>
				Property N4 As Dom.Segments.N4
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Dom.Segments.PER)
				'''<summary>Remittance Delivery Method</summary>
				Property RDM As Dom.Segments.RDM
				'''<summary>Date/Time Reference</summary>
				Property DTM As Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2000
				Inherits ILoop
				'''<summary>Transaction Set Line Number</summary>
				Property LX As Dom.Segments.LX
				'''<summary>Transaction Statistics</summary>
				Property TS3 As Dom.Segments.TS3
				'''<summary>Transaction Supplemental Statistics</summary>
				Property TS2 As Dom.Segments.TS2
				'''<summary>Claim Level Data</summary>
				ReadOnly Property Loop2100 As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2100)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2100
				Inherits ILoop
				'''<summary>Claim Level Data</summary>
				Property CLP As Dom.Segments.CLP
				'''<summary>Claims Adjustment</summary>
				ReadOnly Property CAS As SegmentContainer(Of Dom.Segments.CAS)
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property NM1 As SegmentContainer(Of Dom.Segments.NM1)
				'''<summary>Medicare Inpatient Adjudication</summary>
				Property MIA As Dom.Segments.MIA
				'''<summary>Medicare Outpatient Adjudication</summary>
				Property MOA As Dom.Segments.MOA
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Dom.Segments.DTM)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Dom.Segments.PER)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Dom.Segments.AMT)
				'''<summary>Quantity Information</summary>
				ReadOnly Property QTY As SegmentContainer(Of Dom.Segments.QTY)
				'''<summary>Service Information</summary>
				ReadOnly Property Loop2110 As LoopContainer(Of Dom.Transactions.Transaction835.Loops.Loop2110)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2110
				Inherits ILoop
				'''<summary>Service Information</summary>
				Property SVC As Dom.Segments.SVC
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Dom.Segments.DTM)
				'''<summary>Claims Adjustment</summary>
				ReadOnly Property CAS As SegmentContainer(Of Dom.Segments.CAS)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Dom.Segments.AMT)
				'''<summary>Quantity Information</summary>
				ReadOnly Property QTY As SegmentContainer(Of Dom.Segments.QTY)
				'''<summary>Industry Code Identification</summary>
				ReadOnly Property LQ As SegmentContainer(Of Dom.Segments.LQ)
			End Interface

		End Namespace 'Loops


		Namespace Transaction835_W1
			Namespace Segments

				Namespace Loop1000A

					'''<summary>Payer Identification</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Payer Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Payer Identifier</summary>
						Property N104 As String
					End Interface
					'''<summary>Payer Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Payer Address Line</summary>
						Property N301 As String
						'''<summary>Payer Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Payer City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Payer City Name</summary>
						Property N401 As String
						'''<summary>Payer State Code</summary>
						Property N402 As String
						'''<summary>Payer Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Additional Payer Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Additional Payer Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Payer Business Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Use this data element when the name of the individual to contact is not already defined or is different than the name within the prior name segment (e.g. N1 or NM1).</summary>
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
					'''<summary>Payer Technical Contact Information</summary>
					Public Interface PER_1
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Payer Technical Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Payer Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Payer Technical Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Payer Contact Communication Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Payer WEB Site</summary>
					Public Interface PER_2
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>This is the payer's WEB site URL where providers can find policy and other related information.</summary>
						Property PER04 As String
					End Interface
				End Namespace 'Loop1000A

				Namespace Loop1000B

					'''<summary>Payee Identification</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Payee Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Payee Identification Code</summary>
						Property N104 As String
					End Interface
					'''<summary>Payee Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Payee Address Line</summary>
						Property N301 As String
						'''<summary>Payee Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Payee City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Payee City Name</summary>
						Property N401 As String
						'''<summary>Payee State Code</summary>
						Property N402 As String
						'''<summary>Payee Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Payee Additional Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Additional Payee Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Remittance Delivery Method</summary>
					Public Interface RDM
						Inherits ISegment

						'''<summary>Report Transmission Code</summary>
						Property RDM01 As String
						'''<summary>Name</summary>
						Property RDM02 As String
						'''<summary>Communication Number</summary>
						Property RDM03 As String
					End Interface
				End Namespace 'Loop1000B

				Namespace Loop2000

					'''<summary>Header Number</summary>
					Public Interface LX
						Inherits ISegment

						'''<summary>Assigned Number</summary>
						Property LX01 As Decimal?
					End Interface
					'''<summary>Provider Summary Information</summary>
					Public Interface TS3
						Inherits ISegment

						'''<summary>Provider Identifier</summary>
						Property TS301 As String
						'''<summary>When reporting a TS3 segment for professional claims and the claims are not all for the same place of service, report a place of service of 11 (Office) as the default value. When reporting a TS3 segment for pharmaceutical claims and the claims are not all for the same place of service, report a place of service of 99 (Other unlisted facility) as the default value.</summary>
						Property TS302 As String
						'''<summary>Use this date for the last day of the provider's fiscal year. If the end of the provider's fiscal year is not known, use December 31st of the current year.</summary>
						Property TS303 As Date?
						'''<summary>This is the total number of claims.</summary>
						Property TS304 As Decimal?
						'''<summary>This is the total reported charges for all claims.</summary>
						Property TS305 As Decimal?
						'''<summary>Total MSP Payer Amount</summary>
						Property TS313 As Decimal?
						'''<summary>Total Non-Lab Charge Amount</summary>
						Property TS315 As Decimal?
						'''<summary>Total HCPCS Reported Charge Amount</summary>
						Property TS317 As Decimal?
						'''<summary>Total HCPCS Payable Amount</summary>
						Property TS318 As Decimal?
						'''<summary>The professional component amount must also be reported in the CAS segment with a Claim Adjustment Reason Code value of 89.</summary>
						Property TS320 As Decimal?
						'''<summary>Total MSP Patient Liability Met Amount</summary>
						Property TS321 As Decimal?
						'''<summary>Total Patient Reimbursement Amount</summary>
						Property TS322 As Decimal?
						'''<summary>Total PIP Claim Count</summary>
						Property TS323 As Decimal?
						'''<summary>Total PIP Adjustment Amount</summary>
						Property TS324 As Decimal?
					End Interface
					'''<summary>Provider Supplemental Summary Information</summary>
					Public Interface TS2
						Inherits ISegment

						'''<summary>Total DRG Amount</summary>
						Property TS201 As Decimal?
						'''<summary>Total Federal Specific Amount</summary>
						Property TS202 As Decimal?
						'''<summary>Total Hospital Specific Amount</summary>
						Property TS203 As Decimal?
						'''<summary>Total Disproportionate Share Amount</summary>
						Property TS204 As Decimal?
						'''<summary>Total Capital Amount</summary>
						Property TS205 As Decimal?
						'''<summary>Total Indirect Medical Education Amount</summary>
						Property TS206 As Decimal?
						'''<summary>Total Outlier Day Count</summary>
						Property TS207 As Decimal?
						'''<summary>Total Day Outlier Amount</summary>
						Property TS208 As Decimal?
						'''<summary>Total Cost Outlier Amount</summary>
						Property TS209 As Decimal?
						'''<summary>Average DRG Length of Stay</summary>
						Property TS210 As Decimal?
						'''<summary>Total Discharge Count</summary>
						Property TS211 As Decimal?
						'''<summary>Total Cost Report Day Count</summary>
						Property TS212 As Decimal?
						'''<summary>Total Covered Day Count</summary>
						Property TS213 As Decimal?
						'''<summary>Total Noncovered Day Count</summary>
						Property TS214 As Decimal?
						'''<summary>Total MSP Pass-Through Amount</summary>
						Property TS215 As Decimal?
						'''<summary>Average DRG weight</summary>
						Property TS216 As Decimal?
						'''<summary>Total PPS Capital FSP DRG Amount</summary>
						Property TS217 As Decimal?
						'''<summary>Total PPS Capital HSP DRG Amount</summary>
						Property TS218 As Decimal?
						'''<summary>Total PPS DSH DRG Amount</summary>
						Property TS219 As Decimal?
					End Interface
				End Namespace 'Loop2000

				Namespace Loop2100

					'''<summary>Claim Payment Information</summary>
					Public Interface CLP
						Inherits ISegment

						'''<summary>Patient Control Number</summary>
						Property CLP01 As String
						'''<summary>To determine the full claim status reference Claim adjustment reason codes in the CAS segment in conjunction with this claim status code.</summary>
						Property CLP02 As String
						'''<summary>See 1.10.2.1, Balancing, in this implementation guide for additional information.</summary>
						Property CLP03 As Decimal?
						'''<summary>See 1.10.2.1, Balancing, in this implementation guide for additional information. See section 1.10.2.9 for information about interest considerations.</summary>
						Property CLP04 As Decimal?
						'''<summary>Amounts in CLP05 must have supporting adjustments reflected in CAS segments at the 2100 (CLP) or 2110 (SVC) loop level with a Claim Adjustment Group (CAS01) code of PR (Patient Responsibility).</summary>
						Property CLP05 As Decimal?
						'''<summary>For many providers to electronically post the 835 remittance data to their patient accounting systems without human intervention, a unique, provider-specific insurance plan code is needed. This code allows the provider to separately identify and manage the different product lines or contractual arrangements between the payer and the provider. Because most payers maintain the same Originating Company Identifier in the TRN03 or BPR10 for all product lines or contractual relationships, the CLP06 is used by the provider as a table pointer in combination with the TRN03 or BPR10 to identify the unique, provider-specific insurance plan code needed to post the payment without human intervention. The value should mirror the value received in the original claim (2-005 SBR09 of the 837), if applicable, or provide the value as assigned or edited by the payer. For example the BL from the SBR09 in the 837 would be returned as 12, 13, 15, in the 835 when more details are known. The 837 SBR09 code CI (Commercial Insurance) is generic, if through adjudication the specific type of plan is obtained a more specific code must be returned in the 835.</summary>
						Property CLP06 As String
						'''<summary>Use this number for the payer's internal control number. This number must apply to the entire claim.</summary>
						Property CLP07 As String
						'''<summary>Since professional or dental claims can have different place of service codes for services within a single claim, default to the place of service of the first service line when the service lines are not all for the same place of service.</summary>
						Property CLP08 As String
						'''<summary>This number was received in CLM05-3 of the 837 Claim.</summary>
						Property CLP09 As String
						'''<summary>Diagnosis Related Group (DRG) Code</summary>
						Property CLP11 As String
						'''<summary>This is the adjudicated DRG Weight.</summary>
						Property CLP12 As Decimal?
						'''<summary>This is the adjudicated discharge fraction.</summary>
						Property CLP13 As Decimal?
					End Interface
					'''<summary>Claim Adjustment</summary>
					Public Interface CAS
						Inherits ISegment

						'''<summary>Claim Adjustment Group Code</summary>
						Property CAS01 As String
						'''<summary>Required to report a non-zero adjustment applied at the claim level for the claim adjustment group code reported in CAS01.</summary>
						Property CAS02 As String
						'''<summary>Use this monetary amount for the adjustment amount. A negative amount increases the payment, and a positive amount decreases the payment contained in CLP04.</summary>
						Property CAS03 As Decimal?
						'''<summary>See section 1.10.2.4.1 for additional information.</summary>
						Property CAS04 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property CAS05 As String
						'''<summary>See CAS03.</summary>
						Property CAS06 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS07 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property CAS08 As String
						'''<summary>See CAS03.</summary>
						Property CAS09 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS10 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property CAS11 As String
						'''<summary>See CAS03.</summary>
						Property CAS12 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS13 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property CAS14 As String
						'''<summary>See CAS03.</summary>
						Property CAS15 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS16 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property CAS17 As String
						'''<summary>See CAS03.</summary>
						Property CAS18 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS19 As Decimal?
					End Interface
					'''<summary>Patient Name</summary>
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
						'''<summary>If this data element is used and contains only one character, it is assumed to represent the middle initial.</summary>
						Property NM105 As String
						'''<summary>An example of this is when a Junior and Senior are covered under the same subscriber.</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Patient Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Insured Name</summary>
					Public Interface NM1_1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Subscriber Last Name</summary>
						Property NM103 As String
						'''<summary>Subscriber First Name</summary>
						Property NM104 As String
						'''<summary>If this data element is used and contains only one character, it is assumed to represent the middle initial.</summary>
						Property NM105 As String
						'''<summary>For example, use when necessary to differentiate between a Junior and Senior under the same contract.</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Subscriber Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Corrected Patient/Insured Name</summary>
					Public Interface NM1_2
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Corrected Patient or Insured Last Name</summary>
						Property NM103 As String
						'''<summary>Corrected Patient or Insured First Name</summary>
						Property NM104 As String
						'''<summary>If this data element is used and contains only one character, it is assumed to represent the middle initial.</summary>
						Property NM105 As String
						'''<summary>Corrected Patient or Insured Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Corrected Insured Identification Indicator</summary>
						Property NM109 As String
					End Interface
					'''<summary>Service Provider Name</summary>
					Public Interface NM1_3
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Rendering Provider Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Rendering Provider First Name</summary>
						Property NM104 As String
						'''<summary>If this data element is used and contains only one character, it represents the middle initial.</summary>
						Property NM105 As String
						'''<summary>Rendering Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Rendering Provider Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Crossover Carrier Name</summary>
					Public Interface NM1_4
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Name of the crossover carrier associated with this claim.</summary>
						Property NM103 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Coordination of Benefits Carrier Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Corrected Priority Payer Name</summary>
					Public Interface NM1_5
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Corrected Priority Payer Name</summary>
						Property NM103 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Corrected Priority Payer Identification Number</summary>
						Property NM109 As String
					End Interface
					'''<summary>Other Subscriber Name</summary>
					Public Interface NM1_6
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>At least one of NM103 or NM109 must be present.</summary>
						Property NM103 As String
						'''<summary>Other Subscriber First Name</summary>
						Property NM104 As String
						'''<summary>When only one character is present this is assumed to be the middle initial.</summary>
						Property NM105 As String
						'''<summary>Other Subscriber Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>At least one of NM103 or NM109 must be present.</summary>
						Property NM109 As String
					End Interface
					'''<summary>Inpatient Adjudication Information</summary>
					Public Interface MIA
						Inherits ISegment

						'''<summary>Covered Days or Visits Count</summary>
						Property MIA01 As Decimal?
						'''<summary>See TR3 note 4.</summary>
						Property MIA02 As Decimal?
						'''<summary>Lifetime Psychiatric Days Count</summary>
						Property MIA03 As Decimal?
						'''<summary>Claim DRG Amount</summary>
						Property MIA04 As Decimal?
						'''<summary>Claim Payment Remark Code</summary>
						Property MIA05 As String
						'''<summary>Claim Disproportionate Share Amount</summary>
						Property MIA06 As Decimal?
						'''<summary>Claim MSP Pass-through Amount</summary>
						Property MIA07 As Decimal?
						'''<summary>Claim PPS Capital Amount</summary>
						Property MIA08 As Decimal?
						'''<summary>PPS-Capital FSP DRG Amount</summary>
						Property MIA09 As Decimal?
						'''<summary>PPS-Capital HSP DRG Amount</summary>
						Property MIA10 As Decimal?
						'''<summary>PPS-Capital DSH DRG Amount</summary>
						Property MIA11 As Decimal?
						'''<summary>Old Capital Amount</summary>
						Property MIA12 As Decimal?
						'''<summary>PPS-Capital IME amount</summary>
						Property MIA13 As Decimal?
						'''<summary>PPS-Operating Hospital Specific DRG Amount</summary>
						Property MIA14 As Decimal?
						'''<summary>Cost Report Day Count</summary>
						Property MIA15 As Decimal?
						'''<summary>PPS-Operating Federal Specific DRG Amount</summary>
						Property MIA16 As Decimal?
						'''<summary>Claim PPS Capital Outlier Amount</summary>
						Property MIA17 As Decimal?
						'''<summary>Claim Indirect Teaching Amount</summary>
						Property MIA18 As Decimal?
						'''<summary>Nonpayable Professional Component Amount</summary>
						Property MIA19 As Decimal?
						'''<summary>Claim Payment Remark Code</summary>
						Property MIA20 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MIA21 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MIA22 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MIA23 As String
						'''<summary>PPS-Capital Exception Amount</summary>
						Property MIA24 As Decimal?
					End Interface
					'''<summary>Outpatient Adjudication Information</summary>
					Public Interface MOA
						Inherits ISegment

						'''<summary>Reimbursement Rate</summary>
						Property MOA01 As Decimal?
						'''<summary>Claim HCPCS Payable Amount</summary>
						Property MOA02 As Decimal?
						'''<summary>Claim Payment Remark Code</summary>
						Property MOA03 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MOA04 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MOA05 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MOA06 As String
						'''<summary>Claim Payment Remark Code</summary>
						Property MOA07 As String
						'''<summary>Claim ESRD Payment Amount</summary>
						Property MOA08 As Decimal?
						'''<summary>Nonpayable Professional Component Amount</summary>
						Property MOA09 As Decimal?
					End Interface
					'''<summary>Other Claim Related Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Other Claim Related Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Rendering Provider Identification</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Rendering Provider Secondary Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Statement From or To Date</summary>
					Public Interface DTM
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>Claim Date</summary>
						Property DTM02 As Date?
					End Interface
					'''<summary>Coverage Expiration Date</summary>
					Public Interface DTM_1
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>This is the expiration date of the patient's coverage.</summary>
						Property DTM02 As Date?
					End Interface
					'''<summary>Claim Received Date</summary>
					Public Interface DTM_2
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>This is the date that the claim was received by the payer.</summary>
						Property DTM02 As Date?
					End Interface
					'''<summary>Claim Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Claim Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Claim Contact Communications Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Claim Contact Communications Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Communication Number Extension</summary>
						Property PER08 As String
					End Interface
					'''<summary>Claim Supplemental Information</summary>
					Public Interface AMT
						Inherits ISegment

						'''<summary>Amount Qualifier Code</summary>
						Property AMT01 As String
						'''<summary>Decimal elements will be limited to a maximum length of 10 characters including reported or implied places for cents (implied value of 00 after the decimal point). This applies to all subsequent 782 elements.</summary>
						Property AMT02 As Decimal?
					End Interface
					'''<summary>Claim Supplemental Information Quantity</summary>
					Public Interface QTY
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property QTY01 As String
						'''<summary>Claim Supplemental Information Quantity</summary>
						Property QTY02 As Decimal?
					End Interface
				End Namespace 'Loop2100

				Namespace Loop2110

					'''<summary>Service Payment Information</summary>
					Public Interface SVC
						Inherits ISegment

						'''<summary></summary>
						Property SVC01 As Dom.Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_01.C003
						'''<summary>Use this monetary amount for the submitted service charge amount.</summary>
						Property SVC02 As Decimal?
						'''<summary>Use this number for the service amount paid. The value in SVC03 must equal the value in SVC02 minus all monetary amounts in the subsequent CAS segments of this loop. See 1.10.2.1, Balancing, for additional information.</summary>
						Property SVC03 As Decimal?
						'''<summary>If the original claim and adjudication only referenced an NUBC revenue code, that is supplied in SVC01 and this element is not used.</summary>
						Property SVC04 As String
						'''<summary>If not present, the value is assumed to be one.</summary>
						Property SVC05 As Decimal?
						'''<summary>This code is a composite data structure.</summary>
						Property SVC06 As Dom.Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_06.C003
						'''<summary>Original Units of Service Count</summary>
						Property SVC07 As Decimal?
					End Interface
					'''<summary>Service Date</summary>
					Public Interface DTM
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>Service Date</summary>
						Property DTM02 As Date?
					End Interface
					'''<summary>Service Adjustment</summary>
					Public Interface CAS
						Inherits ISegment

						'''<summary>Claim Adjustment Group Code</summary>
						Property CAS01 As String
						'''<summary>Required to report a non-zero adjustment applied at the service level for the claim adjustment group code reported in CAS01.</summary>
						Property CAS02 As String
						'''<summary>Use this monetary amount for the adjustment amount. A negative amount increases the payment, and a positive amount decreases the payment contained in SVC03 and CLP04.</summary>
						Property CAS03 As Decimal?
						'''<summary>Adjustment Quantity</summary>
						Property CAS04 As Decimal?
						'''<summary>See CAS02.</summary>
						Property CAS05 As String
						'''<summary>See CAS03.</summary>
						Property CAS06 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS07 As Decimal?
						'''<summary>See CAS02.</summary>
						Property CAS08 As String
						'''<summary>See CAS03.</summary>
						Property CAS09 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS10 As Decimal?
						'''<summary>See CAS02.</summary>
						Property CAS11 As String
						'''<summary>See CAS03.</summary>
						Property CAS12 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS13 As Decimal?
						'''<summary>See CAS02.</summary>
						Property CAS14 As String
						'''<summary>See CAS03.</summary>
						Property CAS15 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS16 As Decimal?
						'''<summary>See CAS02.</summary>
						Property CAS17 As String
						'''<summary>See CAS03.</summary>
						Property CAS18 As Decimal?
						'''<summary>See CAS04.</summary>
						Property CAS19 As Decimal?
					End Interface
					'''<summary>Service Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Provider Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Line Item Control Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Line Item Control Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Rendering Provider Information</summary>
					Public Interface REF_2
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Rendering Provider Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>HealthCare Policy Identification</summary>
					Public Interface REF_3
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Healthcare Policy Identification</summary>
						Property REF02 As String
					End Interface
					'''<summary>Service Supplemental Amount</summary>
					Public Interface AMT
						Inherits ISegment

						'''<summary>Amount Qualifier Code</summary>
						Property AMT01 As String
						'''<summary>Decimal elements will be limited to a maximum length of 10 characters including reported or implied places for cents (implied value of 00 after the decimal point). This applies to all subsequent 782 elements.</summary>
						Property AMT02 As Decimal?
					End Interface
					'''<summary>Service Supplemental Quantity</summary>
					Public Interface QTY
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property QTY01 As String
						'''<summary>Service Supplemental Quantity Count</summary>
						Property QTY02 As Decimal?
					End Interface
					'''<summary>Health Care Remark Codes</summary>
					Public Interface LQ
						Inherits ISegment

						'''<summary>Code List Qualifier Code</summary>
						Property LQ01 As String
						'''<summary>Remark Code</summary>
						Property LQ02 As String
					End Interface
				End Namespace 'Loop2110

				'''<summary>Transaction Set Header</summary>
				Public Interface ST
					Inherits ISegment

					'''<summary>Transaction Set Identifier Code</summary>
					Property ST01 As String
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. This unique number also aids in error resolution research. Start with a number, for example 0001, and increment from there. This number must be unique within a specific group and interchange, but it can be repeated in other groups and interchanges.</summary>
					Property ST02 As String
				End Interface
				'''<summary>Financial Information</summary>
				Public Interface BPR
					Inherits ISegment

					'''<summary>Transaction Handling Code</summary>
					Property BPR01 As String
					'''<summary>Use BPR02 for the total payment amount for this 835. The total payment amount for this 835 cannot exceed eleven characters, including decimals (99999999.99). Although the value can be zero, the 835 cannot be issued for less than zero dollars.</summary>
					Property BPR02 As Decimal?
					'''<summary>Credit or Debit Flag Code</summary>
					Property BPR03 As String
					'''<summary>Payment Method Code</summary>
					Property BPR04 As String
					'''<summary>Payment Format Code</summary>
					Property BPR05 As String
					'''<summary>BPR06 through BPR09 relate to the originating financial institution and the originator's account (payer).</summary>
					Property BPR06 As String
					'''<summary>Use this number for the identifying number of the financial institution sending the transaction into the applicable network.</summary>
					Property BPR07 As String
					'''<summary>Use this code to identify the type of account in BPR09.</summary>
					Property BPR08 As String
					'''<summary>Use this number for the originator's account number at the financial institution.</summary>
					Property BPR09 As String
					'''<summary>Payer Identifier</summary>
					Property BPR10 As String
					'''<summary>Use this code to further identify the payer by division or region. The element must be left justified and space filled to meet the minimum element size requirements. If used, this code must be identical to TRN04, excluding trailing spaces.</summary>
					Property BPR11 As String
					'''<summary>BPR12 through BPR15 relate to the receiving financial institution and the receiver's account.</summary>
					Property BPR12 As String
					'''<summary>Use this number for the identifying number of the financial institution receiving the transaction from the applicable network.</summary>
					Property BPR13 As String
					'''<summary>Use this code to identify the type of account in BPR15.</summary>
					Property BPR14 As String
					'''<summary>Use this number for the receiver's account number at the financial institution.</summary>
					Property BPR15 As String
					'''<summary>Use this for the effective entry date. If BPR04 is ACH, this is the date that the money moves from the payer and is available to the payee. If BPR04 is CHK, this is the check issuance date. If BPR04 is FWT, this is the date that the payer anticipates the money to move. As long as the effective date is a business day, this is the settlement date. If BPR04 is `NON', enter the date of the 835.</summary>
					Property BPR16 As Date?
				End Interface
				'''<summary>Reassociation Trace Number</summary>
				Public Interface TRN
					Inherits ISegment

					'''<summary>Trace Type Code</summary>
					Property TRN01 As String
					'''<summary>This number must be unique within the sender/receiver relationship. The number is assigned by the sender. If payment is made by check, this must be the check number. If payment is made by EFT, this must be the EFT reference number. If this is a non-payment 835, this must be a unique remittance advice identification number.</summary>
					Property TRN02 As String
					'''<summary>This must be a 1 followed by the payer's EIN (or TIN).</summary>
					Property TRN03 As String
					'''<summary>If both TRN04 and BPR11 are used, they must be identical, excluding trailing spaces. Since BPR11 has a min/max value of 9/9, whenever both are used, this element is restricted to a maximum size of 9.</summary>
					Property TRN04 As String
				End Interface
				'''<summary>Foreign Currency Information</summary>
				Public Interface CUR
					Inherits ISegment

					'''<summary>Entity Identifier Code</summary>
					Property CUR01 As String
					'''<summary>This is the currency code for the payment currency.</summary>
					Property CUR02 As String
				End Interface
				'''<summary>Receiver Identification</summary>
				Public Interface REF
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>Receiver Identifier</summary>
					Property REF02 As String
				End Interface
				'''<summary>Version Identification</summary>
				Public Interface REF_1
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>Version Identification Code</summary>
					Property REF02 As String
				End Interface
				'''<summary>Production Date</summary>
				Public Interface DTM
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTM01 As String
					'''<summary>Report the end date for the adjudication production cycle for claims included in this 835.</summary>
					Property DTM02 As Date?
				End Interface
				'''<summary>Provider Adjustment</summary>
				Public Interface PLB
					Inherits ISegment

					'''<summary>Provider Identifier</summary>
					Property PLB01 As String
					'''<summary>This is the last day of the provider's fiscal year. If the end of the provider's fiscal year is not known by the payer, use December 31st of the current year.</summary>
					Property PLB02 As Date?
					'''<summary>This identifier is a composite data structure. The composite identifies the reason and identifying information for the related adjustment dollar amount (PLB04 for PLB03).</summary>
					Property PLB03 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB04 As Decimal?
					'''<summary>See PLB03 for details.</summary>
					Property PLB05 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB06 As Decimal?
					'''<summary>See PLB03 for details.</summary>
					Property PLB07 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB08 As Decimal?
					'''<summary>See PLB03 for details.</summary>
					Property PLB09 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB10 As Decimal?
					'''<summary>See PLB03 for details.</summary>
					Property PLB11 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB12 As Decimal?
					'''<summary>See PLB03 for details.</summary>
					Property PLB13 As Dom.DataElements.Composite.C042
					'''<summary>This is the adjustment amount for the preceding adjustment reason.</summary>
					Property PLB14 As Decimal?
				End Interface
				'''<summary>Transaction Set Trailer</summary>
				Public Interface SE
					Inherits ISegment

					'''<summary>Transaction Segment Count</summary>
					Property SE01 As Decimal?
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. The originator assigns the Transaction Set Control Number, which must be unique within a functional group (GS-GE). This unique number also aids in error resolution research.</summary>
					Property SE02 As String
				End Interface
			End Namespace 'Segments

			Namespace Composites
				Namespace Loop2110.SVC.SVC_01
					'''<summary></summary>
					Public Interface C003
						'''<summary>Product or Service ID Qualifier</summary>
						Property C003_01 As String
						'''<summary>This is the adjudicated procedure code or revenue code as identified by the qualifier in SVC01-1.</summary>
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
				Namespace Loop2110.SVC.SVC_06
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
						'''<summary>Procedure Code Description</summary>
						Property C003_07 As String
					End Interface
				End Namespace
			End Namespace 'Composites

			Namespace Loops
				'''<summary>Payer Identification</summary>
				Public Interface Loop1000A
					Inherits ILoop


					'''<summary>Payer Identification</summary>
					Property N1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1

					'''<summary>Payer Address</summary>
					Property N3 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3

					'''<summary>Payer City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4

					'''<summary>Additional Payer Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF, Dom.Segments.REF)

					'''<summary>Payer Business Contact Information</summary>
					Property PER As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER

					'''<summary>Payer Technical Contact Information</summary>
					ReadOnly Property PER_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1, Dom.Segments.PER)

					'''<summary>Payer WEB Site</summary>
					Property PER_2 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2
				End Interface
				'''<summary>Payee Identification</summary>
				Public Interface Loop1000B
					Inherits ILoop


					'''<summary>Payee Identification</summary>
					Property N1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1

					'''<summary>Payee Address</summary>
					Property N3 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3

					'''<summary>Payee City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4

					'''<summary>Payee Additional Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF, Dom.Segments.REF)

					'''<summary>Remittance Delivery Method</summary>
					Property RDM As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM
				End Interface
				'''<summary>Header Number</summary>
				Public Interface Loop2000
					Inherits ILoop


					'''<summary>Header Number</summary>
					Property LX As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX

					'''<summary>Provider Summary Information</summary>
					Property TS3 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3

					'''<summary>Provider Supplemental Summary Information</summary>
					Property TS2 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2

					'''<summary>Claim Payment Information</summary>
					ReadOnly Property Loop2100 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100, Dom.Transactions.Transaction835.Loops.Loop2100)
				End Interface
				'''<summary>Claim Payment Information</summary>
				Public Interface Loop2100
					Inherits ILoop


					'''<summary>Claim Payment Information</summary>
					Property CLP As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP

					'''<summary>Claim Adjustment</summary>
					ReadOnly Property CAS As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS, Dom.Segments.CAS)

					'''<summary>Patient Name</summary>
					Property NM1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1

					'''<summary>Insured Name</summary>
					Property NM1_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1

					'''<summary>Corrected Patient/Insured Name</summary>
					Property NM1_2 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2

					'''<summary>Service Provider Name</summary>
					Property NM1_3 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3

					'''<summary>Crossover Carrier Name</summary>
					Property NM1_4 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4

					'''<summary>Corrected Priority Payer Name</summary>
					Property NM1_5 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5

					'''<summary>Other Subscriber Name</summary>
					Property NM1_6 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6

					'''<summary>Inpatient Adjudication Information</summary>
					Property MIA As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA

					'''<summary>Outpatient Adjudication Information</summary>
					Property MOA As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA

					'''<summary>Other Claim Related Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF, Dom.Segments.REF)

					'''<summary>Rendering Provider Identification</summary>
					ReadOnly Property REF_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1, Dom.Segments.REF)

					'''<summary>Statement From or To Date</summary>
					ReadOnly Property DTM As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM, Dom.Segments.DTM)

					'''<summary>Coverage Expiration Date</summary>
					Property DTM_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1

					'''<summary>Claim Received Date</summary>
					Property DTM_2 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2

					'''<summary>Claim Contact Information</summary>
					ReadOnly Property PER As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER, Dom.Segments.PER)

					'''<summary>Claim Supplemental Information</summary>
					ReadOnly Property AMT As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT, Dom.Segments.AMT)

					'''<summary>Claim Supplemental Information Quantity</summary>
					ReadOnly Property QTY As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY, Dom.Segments.QTY)

					'''<summary>Service Payment Information</summary>
					ReadOnly Property Loop2110 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110, Dom.Transactions.Transaction835.Loops.Loop2110)
				End Interface
				'''<summary>Service Payment Information</summary>
				Public Interface Loop2110
					Inherits ILoop


					'''<summary>Service Payment Information</summary>
					Property SVC As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC

					'''<summary>Service Date</summary>
					ReadOnly Property DTM As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM, Dom.Segments.DTM)

					'''<summary>Service Adjustment</summary>
					ReadOnly Property CAS As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS, Dom.Segments.CAS)

					'''<summary>Service Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF, Dom.Segments.REF)

					'''<summary>Line Item Control Number</summary>
					Property REF_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1

					'''<summary>Rendering Provider Information</summary>
					ReadOnly Property REF_2 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2, Dom.Segments.REF)

					'''<summary>HealthCare Policy Identification</summary>
					ReadOnly Property REF_3 As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3, Dom.Segments.REF)

					'''<summary>Service Supplemental Amount</summary>
					ReadOnly Property AMT As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT, Dom.Segments.AMT)

					'''<summary>Service Supplemental Quantity</summary>
					ReadOnly Property QTY As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY, Dom.Segments.QTY)

					'''<summary>Health Care Remark Codes</summary>
					ReadOnly Property LQ As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ, Dom.Segments.LQ)
				End Interface

			End Namespace 'Loops

			'''<summary>Health Care Claim Payment/Advice</summary>
			'''<remarks>
			'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Health Care Claim Payment/Advice Transaction Set (835) for use within the context of the Electronic Data Interchange (EDI) environment. This transaction set can be used to make a payment, send an Explanation of Benefits (EOB) remittance advice, or make a payment and send an EOB remittance advice only from a health insurer to a health care provider either directly or via a financial institution.</para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary>Transaction Set Header</summary>
				Property ST As Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST

				'''<summary>Financial Information</summary>
				Property BPR As Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR

				'''<summary>Reassociation Trace Number</summary>
				Property TRN As Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN

				'''<summary>Foreign Currency Information</summary>
				Property CUR As Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR

				'''<summary>Receiver Identification</summary>
				Property REF As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF

				'''<summary>Version Identification</summary>
				Property REF_1 As Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1

				'''<summary>Production Date</summary>
				Property DTM As Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM

				'''<summary>Payer Identification</summary>
				Property Loop1000A As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A

				'''<summary>Payee Identification</summary>
				Property Loop1000B As Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B

				'''<summary>Header Number</summary>
				ReadOnly Property Loop2000 As LoopSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000, Dom.Transactions.Transaction835.Loops.Loop2000)

				'''<summary>Provider Adjustment</summary>
				ReadOnly Property PLB As SegmentSubsetContainer(Of Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB, Dom.Segments.PLB)

				'''<summary>Transaction Set Trailer</summary>
				Property SE As Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE
			End Interface
		End Namespace 'Transaction835_W1
	End Namespace 'Transaction835
End Namespace 'Transaction835
