Namespace Transactions
	Namespace Transaction820

		Partial Friend Class Standard_Obj
			Inherits TransactionSet
			Implements Standard, Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet
			Friend Sub New(versionCode As String)
				Me.New(String.Empty, versionCode)
			End Sub

			Friend Sub New(controlNumber As String, versionCode As String)
				MyBase.New("RA", versionCode)

				Children.AddRange({New Edi.Dom.Segments.ST_Obj,
																	CType(Nothing, Edi.Dom.Segments.BPR_Obj),
																	New SegmentContainer(Of Edi.Dom.Segments.NTE)(0, "1", "0300"),
																	CType(Nothing, Edi.Dom.Segments.TRN_Obj),
																	CType(Nothing, Edi.Dom.Segments.CUR_Obj),
																	New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "1", "0500"),
																	New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "1", "0600"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(0, "1", "0700"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2000)(0, "2", "0100"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3000)(0, "2", "2800"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3100)(0, "2", "2870"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3200)(0, "2", "2900"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4000)(0, "2", "3600"),
																	New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5000)(0, "2", "4500"),
																	New Edi.Dom.Segments.SE_Obj})

				ST_Obj.ST01 = "820"
				ST_Obj.ST02 = controlNumber
				ST_Obj.ST03 = VersionCode

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
													New ReaderState(2, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(3, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(5, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(6, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(7, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(9, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(11, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(13, "ENT", ReadAction.PopulateLoop, 13, False),
													New ReaderState(2, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(3, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(5, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(6, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(7, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(9, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(11, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(13, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(15, "TXP", ReadAction.PopulateLoop, 15, False),
													New ReaderState(2, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(3, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(5, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(6, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(7, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(9, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(11, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(13, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(15, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(17, "DED", ReadAction.PopulateLoop, 17, False),
													New ReaderState(2, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(3, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(5, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(6, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(7, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(9, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(11, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(13, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(15, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(17, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(19, "LX", ReadAction.PopulateLoop, 19, False),
													New ReaderState(2, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(3, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(5, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(6, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(7, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(9, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(11, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(13, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(15, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(17, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(19, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(21, "N9", ReadAction.PopulateLoop, 21, False),
													New ReaderState(2, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(3, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(5, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(6, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(7, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(9, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(11, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(13, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(15, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(17, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(19, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(21, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(23, "RYL", ReadAction.PopulateLoop, 23, False),
													New ReaderState(2, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(3, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(5, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(6, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(7, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(9, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(11, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(13, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(15, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(17, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(19, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(21, "SE", ReadAction.PopulateSegment, 25, False),
													New ReaderState(23, "SE", ReadAction.PopulateSegment, 25, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ST_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.ST_Obj)
					If MyBase.CompareKey(S2.ST01, ";820;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0100"
					End If
				ElseIf String.Compare(segmentName, "BPR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.BPR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BPR_Obj = Seg
				ElseIf String.Compare(segmentName, "NTE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NTE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NTE_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TRN_Obj = Seg
				ElseIf String.Compare(segmentName, "CUR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.CUR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CUR_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";14;17;18;2F;38;72;LB;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0500"
					End If
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTM_Obj)
					If MyBase.CompareKey(S2.DTM01, ";009;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0600"
					ElseIf MyBase.CompareKey(S2.DTM01, ";035;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0610"
					ElseIf MyBase.CompareKey(S2.DTM01, ";582;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0620"
					ElseIf MyBase.CompareKey(S2.DTM01, ";097;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0630"
					End If
				ElseIf String.Compare(segmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop1000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop1000_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";PE;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__1000A"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "0700"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";PR;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__1000B"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "1500"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";04;0B;8W;AK;BE;BK;C1;C2;IAT;MJ;RB;Z6;ZB;ZL;") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__1000C"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "2300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "ENT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2000_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "0100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";") AndAlso String.Compare(args.Implementation, "_820A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "0100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "TXP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3000_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "DED", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3100_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3200_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3200_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "N9", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop4000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop4000_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "RYL", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5000_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property ST_Obj As Edi.Dom.Segments.ST_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ST_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ST_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ST_Std As Edi.Dom.Segments.ST Implements Edi.Dom.Transactions.Transaction820.Standard.ST
				Get
					Return CType(Children(0), Edi.Dom.Segments.ST_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ST)
					Children(0) = value
				End Set
			End Property

			Private Property ST_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.ST
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Friend Property BPR_Obj As Edi.Dom.Segments.BPR_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.BPR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BPR_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property BPR_Std As Edi.Dom.Segments.BPR Implements Edi.Dom.Transactions.Transaction820.Standard.BPR
				Get
					Return CType(Children(1), Edi.Dom.Segments.BPR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BPR)
					Children(1) = value
				End Set
			End Property

			Private Property BPR_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.BPR
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property NTE_Obj As SegmentContainer(Of Edi.Dom.Segments.NTE) Implements Edi.Dom.Transactions.Transaction820.Standard.NTE
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.NTE))
				End Get
			End Property

			Friend Property TRN_Obj As Edi.Dom.Segments.TRN_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.TRN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.TRN_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property TRN_Std As Edi.Dom.Segments.TRN Implements Edi.Dom.Transactions.Transaction820.Standard.TRN
				Get
					Return CType(Children(3), Edi.Dom.Segments.TRN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.TRN)
					Children(3) = value
				End Set
			End Property

			Private Property TRN_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.TRN
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN)
					Children(3) = value
				End Set
			End Property
			Friend Property CUR_Obj As Edi.Dom.Segments.CUR_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.CUR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.CUR_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property CUR_Std As Edi.Dom.Segments.CUR Implements Edi.Dom.Transactions.Transaction820.Standard.CUR
				Get
					Return CType(Children(4), Edi.Dom.Segments.CUR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.CUR)
					Children(4) = value
				End Set
			End Property

			Private Property CUR_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.CUR
				Get
					Return CType(Children(4), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR)
					Children(4) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Standard.REF
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.REF
				Get
					If REFSubset_Transaction820_A1 Is Nothing Then
						REFSubset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF, Edi.Dom.Segments.REF)(Children(5), 0, "1", "0500")
					End If

					Return REFSubset_Transaction820_A1
				End Get
			End Property
			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Standard.DTM
				Get
					Return CType(Children(6), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property

			Private DTMSubset_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.DTM
				Get
					If DTMSubset_Transaction820_A1 Is Nothing Then
						DTMSubset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0600")
					End If

					If DTMSubset_Transaction820_A1.Count > 0 Then
						Return DTMSubset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM)
					If DTMSubset_Transaction820_A1 Is Nothing Then
						DTMSubset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0600")
					End If

					If DTMSubset_Transaction820_A1.Count = 0 Then
						DTMSubset_Transaction820_A1.Add(value)
					Else
						DTMSubset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private DTM_1Subset_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_1_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.DTM_1
				Get
					If DTM_1Subset_Transaction820_A1 Is Nothing Then
						DTM_1Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0610")
					End If

					If DTM_1Subset_Transaction820_A1.Count > 0 Then
						Return DTM_1Subset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1)
					If DTM_1Subset_Transaction820_A1 Is Nothing Then
						DTM_1Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0610")
					End If

					If DTM_1Subset_Transaction820_A1.Count = 0 Then
						DTM_1Subset_Transaction820_A1.Add(value)
					Else
						DTM_1Subset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private DTM_2Subset_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_2_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.DTM_2
				Get
					If DTM_2Subset_Transaction820_A1 Is Nothing Then
						DTM_2Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0620")
					End If

					If DTM_2Subset_Transaction820_A1.Count > 0 Then
						Return DTM_2Subset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2)
					If DTM_2Subset_Transaction820_A1 Is Nothing Then
						DTM_2Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0620")
					End If

					If DTM_2Subset_Transaction820_A1.Count = 0 Then
						DTM_2Subset_Transaction820_A1.Add(value)
					Else
						DTM_2Subset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private DTM_3Subset_Transaction820_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_3_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.DTM_3
				Get
					If DTM_3Subset_Transaction820_A1 Is Nothing Then
						DTM_3Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0630")
					End If

					If DTM_3Subset_Transaction820_A1.Count > 0 Then
						Return DTM_3Subset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3)
					If DTM_3Subset_Transaction820_A1 Is Nothing Then
						DTM_3Subset_Transaction820_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3, Edi.Dom.Segments.DTM)(Children(6), 1, "1", "0630")
					End If

					If DTM_3Subset_Transaction820_A1.Count = 0 Then
						DTM_3Subset_Transaction820_A1.Add(value)
					Else
						DTM_3Subset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property Loop1000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop1000
				Get
					Return CType(Children(7), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop1000))
				End Get
			End Property

			Private Loop1000ASubset_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)
			Private Property Loop1000A_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.Loop1000A
				Get
					If Loop1000ASubset_Transaction820_A1 Is Nothing Then
						Loop1000ASubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(Children(7), 1, "1", "0700")
					End If

					If Loop1000ASubset_Transaction820_A1.Count > 0 Then
						Return Loop1000ASubset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A)
					If Loop1000ASubset_Transaction820_A1 Is Nothing Then
						Loop1000ASubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(Children(7), 1, "1", "0700")
					End If

					If Loop1000ASubset_Transaction820_A1.Count = 0 Then
						Loop1000ASubset_Transaction820_A1.Add(value)
					Else
						Loop1000ASubset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private Loop1000BSubset_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)
			Private Property Loop1000B_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.Loop1000B
				Get
					If Loop1000BSubset_Transaction820_A1 Is Nothing Then
						Loop1000BSubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(Children(7), 1, "1", "1500")
					End If

					If Loop1000BSubset_Transaction820_A1.Count > 0 Then
						Return Loop1000BSubset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B)
					If Loop1000BSubset_Transaction820_A1 Is Nothing Then
						Loop1000BSubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(Children(7), 1, "1", "1500")
					End If

					If Loop1000BSubset_Transaction820_A1.Count = 0 Then
						Loop1000BSubset_Transaction820_A1.Add(value)
					Else
						Loop1000BSubset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private Loop1000CSubset_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)
			Private ReadOnly Property Loop1000C_Obj_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction820.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.Loop1000C
				Get
					If Loop1000CSubset_Transaction820_A1 Is Nothing Then
						Loop1000CSubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)(Children(7), 14, "1", "2300")
					End If

					Return Loop1000CSubset_Transaction820_A1
				End Get
			End Property
			Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop2000
				Get
					Return CType(Children(8), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2000))
				End Get
			End Property

			Private Loop2000ASubset_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)
			Private Property Loop2000A_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.Loop2000A
				Get
					If Loop2000ASubset_Transaction820_A1 Is Nothing Then
						Loop2000ASubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)(Children(8), 1, "2", "0100")
					End If

					If Loop2000ASubset_Transaction820_A1.Count > 0 Then
						Return Loop2000ASubset_Transaction820_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A)
					If Loop2000ASubset_Transaction820_A1 Is Nothing Then
						Loop2000ASubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)(Children(8), 1, "2", "0100")
					End If

					If Loop2000ASubset_Transaction820_A1.Count = 0 Then
						Loop2000ASubset_Transaction820_A1.Add(value)
					Else
						Loop2000ASubset_Transaction820_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000BSubset_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)
			Private ReadOnly Property Loop2000B_Obj_Transaction820_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B, Edi.Dom.Transactions.Transaction820.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.Loop2000B
				Get
					If Loop2000BSubset_Transaction820_A1 Is Nothing Then
						Loop2000BSubset_Transaction820_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)(Children(8), 0, "3", "0100")
					End If

					Return Loop2000BSubset_Transaction820_A1
				End Get
			End Property
			Friend ReadOnly Property Loop3000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3000) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop3000
				Get
					Return CType(Children(9), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3000))
				End Get
			End Property

			Friend ReadOnly Property Loop3100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3100) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop3100
				Get
					Return CType(Children(10), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3100))
				End Get
			End Property

			Friend ReadOnly Property Loop3200_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3200) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop3200
				Get
					Return CType(Children(11), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3200))
				End Get
			End Property

			Friend ReadOnly Property Loop4000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4000) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop4000
				Get
					Return CType(Children(12), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4000))
				End Get
			End Property

			Friend ReadOnly Property Loop5000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5000) Implements Edi.Dom.Transactions.Transaction820.Standard.Loop5000
				Get
					Return CType(Children(13), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5000))
				End Get
			End Property

			Friend Property SE_Obj As Edi.Dom.Segments.SE_Obj
				Get
					Return CType(Children(14), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE_Obj)
					Children(14) = value
				End Set
			End Property

			Private Property SE_Std As Edi.Dom.Segments.SE Implements Edi.Dom.Transactions.Transaction820.Standard.SE
				Get
					Return CType(Children(14), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE)
					Children(14) = value
				End Set
			End Property

			Private Property SE_IFace_Transaction820_A1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet.SE
				Get
					Return CType(Children(14), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE)
					Children(14) = value
				End Set
			End Property
		End Class

		Partial Friend Class Loop1000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.N1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.N2)(0, "1", "0800"),
																		New SegmentContainer(Of Edi.Dom.Segments.N3)(0, "1", "0900"),
																		CType(Nothing, Edi.Dom.Segments.N4_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "1", "1100"),
																		New SegmentContainer(Of Edi.Dom.Segments.PER)(0, "1", "1200"),
																		CType(Nothing, Edi.Dom.Segments.RDM_Obj),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj)})

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
				If String.Compare(segmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.N1_Obj)
					If MyBase.CompareKey(S2.N101, ";PE;") AndAlso String.Compare(args.Implementation, "_820A1__1000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0700"
					ElseIf MyBase.CompareKey(S2.N101, ";PR;") AndAlso String.Compare(args.Implementation, "_820A1__1000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "1500"
					ElseIf MyBase.CompareKey(S2.N101, ";04;0B;8W;AK;BE;BK;C1;C2;IAT;MJ;RB;Z6;ZB;ZL;") AndAlso String.Compare(args.Implementation, "_820A1__1000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "2300"
					End If
				ElseIf String.Compare(segmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "RDM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RDM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RDM_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property N1_Obj As Edi.Dom.Segments.N1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property N1_Std As Edi.Dom.Segments.N1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.N1
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1)
					Children(0) = value
				End Set
			End Property

			Private Property N1_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1)
					Children(0) = value
				End Set
			End Property
			Private Property N1_IFace_1_Loop1000B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1)
					Children(0) = value
				End Set
			End Property
			Private Property N1_IFace_2_Loop1000C_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property N2_Obj As SegmentContainer(Of Edi.Dom.Segments.N2) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.N2
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.N2))
				End Get
			End Property

			Private N2Subset_Loop1000A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2, Edi.Dom.Segments.N2)
			Private Property N2_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A.N2
				Get
					If N2Subset_Loop1000A_Obj Is Nothing Then
						N2Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "0800")
					End If

					If N2Subset_Loop1000A_Obj.Count > 0 Then
						Return N2Subset_Loop1000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2)
					If N2Subset_Loop1000A_Obj Is Nothing Then
						N2Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "0800")
					End If

					If N2Subset_Loop1000A_Obj.Count = 0 Then
						N2Subset_Loop1000A_Obj.Add(value)
					Else
						N2Subset_Loop1000A_Obj(0) = value
					End If
				End Set
			End Property
			Private N2Subset_1_Loop1000B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2, Edi.Dom.Segments.N2)
			Private Property N2_IFace_1_Loop1000B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B.N2
				Get
					If N2Subset_1_Loop1000B_Obj Is Nothing Then
						N2Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "1600")
					End If

					If N2Subset_1_Loop1000B_Obj.Count > 0 Then
						Return N2Subset_1_Loop1000B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2)
					If N2Subset_1_Loop1000B_Obj Is Nothing Then
						N2Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "1600")
					End If

					If N2Subset_1_Loop1000B_Obj.Count = 0 Then
						N2Subset_1_Loop1000B_Obj.Add(value)
					Else
						N2Subset_1_Loop1000B_Obj(0) = value
					End If
				End Set
			End Property
			Private N2Subset_2_Loop1000C_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2, Edi.Dom.Segments.N2)
			Private Property N2_IFace_2_Loop1000C_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C.N2
				Get
					If N2Subset_2_Loop1000C_Obj Is Nothing Then
						N2Subset_2_Loop1000C_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "2400")
					End If

					If N2Subset_2_Loop1000C_Obj.Count > 0 Then
						Return N2Subset_2_Loop1000C_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2)
					If N2Subset_2_Loop1000C_Obj Is Nothing Then
						N2Subset_2_Loop1000C_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2, Edi.Dom.Segments.N2)(Children(1), 1, "1", "2400")
					End If

					If N2Subset_2_Loop1000C_Obj.Count = 0 Then
						N2Subset_2_Loop1000C_Obj.Add(value)
					Else
						N2Subset_2_Loop1000C_Obj(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.N3
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.N3))
				End Get
			End Property

			Private N3Subset_Loop1000A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3, Edi.Dom.Segments.N3)
			Private Property N3_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A.N3
				Get
					If N3Subset_Loop1000A_Obj Is Nothing Then
						N3Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "0900")
					End If

					If N3Subset_Loop1000A_Obj.Count > 0 Then
						Return N3Subset_Loop1000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3)
					If N3Subset_Loop1000A_Obj Is Nothing Then
						N3Subset_Loop1000A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "0900")
					End If

					If N3Subset_Loop1000A_Obj.Count = 0 Then
						N3Subset_Loop1000A_Obj.Add(value)
					Else
						N3Subset_Loop1000A_Obj(0) = value
					End If
				End Set
			End Property
			Private N3Subset_1_Loop1000B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3, Edi.Dom.Segments.N3)
			Private Property N3_IFace_1_Loop1000B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B.N3
				Get
					If N3Subset_1_Loop1000B_Obj Is Nothing Then
						N3Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "1700")
					End If

					If N3Subset_1_Loop1000B_Obj.Count > 0 Then
						Return N3Subset_1_Loop1000B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3)
					If N3Subset_1_Loop1000B_Obj Is Nothing Then
						N3Subset_1_Loop1000B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "1700")
					End If

					If N3Subset_1_Loop1000B_Obj.Count = 0 Then
						N3Subset_1_Loop1000B_Obj.Add(value)
					Else
						N3Subset_1_Loop1000B_Obj(0) = value
					End If
				End Set
			End Property
			Private N3Subset_2_Loop1000C_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3, Edi.Dom.Segments.N3)
			Private Property N3_IFace_2_Loop1000C_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C.N3
				Get
					If N3Subset_2_Loop1000C_Obj Is Nothing Then
						N3Subset_2_Loop1000C_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "2500")
					End If

					If N3Subset_2_Loop1000C_Obj.Count > 0 Then
						Return N3Subset_2_Loop1000C_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3)
					If N3Subset_2_Loop1000C_Obj Is Nothing Then
						N3Subset_2_Loop1000C_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3, Edi.Dom.Segments.N3)(Children(2), 1, "1", "2500")
					End If

					If N3Subset_2_Loop1000C_Obj.Count = 0 Then
						N3Subset_2_Loop1000C_Obj.Add(value)
					Else
						N3Subset_2_Loop1000C_Obj(0) = value
					End If
				End Set
			End Property
			Friend Property N4_Obj As Edi.Dom.Segments.N4_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Private Property N4_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_1_Loop1000B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_2_Loop1000C_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4)
					Children(3) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.REF
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.PER
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Private PERSubset_Loop1000B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER, Edi.Dom.Segments.PER)
			Private ReadOnly Property PER_Loop1000B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER, Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B.PER
				Get
					If PERSubset_Loop1000B_Obj Is Nothing Then
						PERSubset_Loop1000B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER, Edi.Dom.Segments.PER)(Children(5), 0, "1", "1850")
					End If

					Return PERSubset_Loop1000B_Obj
				End Get
			End Property
			Private PERSubset_1_Loop1000C_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER, Edi.Dom.Segments.PER)
			Private ReadOnly Property PER_Loop1000C_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER, Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C.PER
				Get
					If PERSubset_1_Loop1000C_Obj Is Nothing Then
						PERSubset_1_Loop1000C_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER, Edi.Dom.Segments.PER)(Children(5), 0, "1", "2800")
					End If

					Return PERSubset_1_Loop1000C_Obj
				End Get
			End Property
			Friend Property RDM_Obj As Edi.Dom.Segments.RDM_Obj
				Get
					Return CType(Children(6), Edi.Dom.Segments.RDM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RDM_Obj)
					Children(6) = value
				End Set
			End Property

			Private Property RDM_Std As Edi.Dom.Segments.RDM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.RDM
				Get
					Return CType(Children(6), Edi.Dom.Segments.RDM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RDM)
					Children(6) = value
				End Set
			End Property

			Private Property RDM_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A.RDM
				Get
					Return CType(Children(6), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM)
					Children(6) = value
				End Set
			End Property
			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(7), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop1000.DTM
				Get
					Return CType(Children(7), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(7) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.ENT_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2050)(0, "2", "0150"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2100)(0, "2", "0200"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2200)(0, "2", "0800"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2300)(0, "2", "1500")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ENT", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "FA1", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "FA1", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "NM1", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "NM1", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "NM1", ReadAction.PopulateLoop, 4, False),
														New ReaderState(1, "ADX", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "ADX", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "ADX", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "ADX", ReadAction.PopulateLoop, 6, False),
														New ReaderState(1, "RMR", ReadAction.PopulateLoop, 8, False),
														New ReaderState(2, "RMR", ReadAction.PopulateLoop, 8, False),
														New ReaderState(4, "RMR", ReadAction.PopulateLoop, 8, False),
														New ReaderState(6, "RMR", ReadAction.PopulateLoop, 8, False),
														New ReaderState(8, "RMR", ReadAction.PopulateLoop, 8, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "ENT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ENT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ENT_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.ENT_Obj)
					If MyBase.CompareKey(S2.ENT01, ";") AndAlso String.Compare(args.Implementation, "_820A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0100"
					ElseIf MyBase.CompareKey(S2.ENT01, ";") AndAlso String.Compare(args.Implementation, "_820A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "3"
						Seg.SetSequence = "0100"
					End If
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2050_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2050_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2100_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";DO;EY;IL;QE;") AndAlso String.Compare(args.Implementation, "_820A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000B__2100B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "0200"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2200_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2200_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2200A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "0800"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf String.Compare(args.Implementation, "_820A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000B__2200B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "0800"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "RMR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2300_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2300_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2300A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "1500"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf String.Compare(args.Implementation, "_820A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000B__2300B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "1500"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property ENT_Obj As Edi.Dom.Segments.ENT_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ENT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ENT_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ENT_Std As Edi.Dom.Segments.ENT Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000.ENT
				Get
					Return CType(Children(0), Edi.Dom.Segments.ENT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ENT)
					Children(0) = value
				End Set
			End Property

			Private Property ENT_IFace_Loop2000A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A.ENT
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT)
					Children(0) = value
				End Set
			End Property
			Private Property ENT_IFace_1_Loop2000B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B.ENT
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2050_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2050) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000.Loop2050
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2050))
				End Get
			End Property

			Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000.Loop2100
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2100))
				End Get
			End Property

			Private Loop2100BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction820.Loops.Loop2100)
			Private ReadOnly Property Loop2100B_Obj_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction820.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B.Loop2100B
				Get
					If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
						Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction820.Loops.Loop2100)(Children(2), 0, "3", "0200")
					End If

					Return Loop2100BSubset_Loop2000B_Obj
				End Get
			End Property
			Friend ReadOnly Property Loop2200_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2200) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000.Loop2200
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2200))
				End Get
			End Property

			Private Loop2200ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)
			Private ReadOnly Property Loop2200A_Obj_Loop2000A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A, Edi.Dom.Transactions.Transaction820.Loops.Loop2200) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A.Loop2200A
				Get
					If Loop2200ASubset_Loop2000A_Obj Is Nothing Then
						Loop2200ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)(Children(3), 0, "2", "0800")
					End If

					Return Loop2200ASubset_Loop2000A_Obj
				End Get
			End Property
			Private Loop2200BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)
			Private ReadOnly Property Loop2200B_Obj_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B, Edi.Dom.Transactions.Transaction820.Loops.Loop2200) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B.Loop2200B
				Get
					If Loop2200BSubset_Loop2000B_Obj Is Nothing Then
						Loop2200BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)(Children(3), 0, "3", "0800")
					End If

					Return Loop2200BSubset_Loop2000B_Obj
				End Get
			End Property
			Friend ReadOnly Property Loop2300_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2300) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2000.Loop2300
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2300))
				End Get
			End Property

			Private Loop2300ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)
			Private ReadOnly Property Loop2300A_Obj_Loop2000A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A, Edi.Dom.Transactions.Transaction820.Loops.Loop2300) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A.Loop2300A
				Get
					If Loop2300ASubset_Loop2000A_Obj Is Nothing Then
						Loop2300ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)(Children(4), 0, "2", "1500")
					End If

					Return Loop2300ASubset_Loop2000A_Obj
				End Get
			End Property
			Private Loop2300BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)
			Private ReadOnly Property Loop2300B_Obj_Loop2000B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B, Edi.Dom.Transactions.Transaction820.Loops.Loop2300) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B.Loop2300B
				Get
					If Loop2300BSubset_Loop2000B_Obj Is Nothing Then
						Loop2300BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)(Children(4), 0, "3", "1500")
					End If

					Return Loop2300BSubset_Loop2000B_Obj
				End Get
			End Property

		End Class
		Partial Friend Class Loop2050_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2050
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.FA1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.FA2)(0, "2", "0160")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "FA1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "FA2", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "FA2", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA1_Obj = Seg
				ElseIf String.Compare(segmentName, "FA2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA2_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property FA1_Obj As Edi.Dom.Segments.FA1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property FA1_Std As Edi.Dom.Segments.FA1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2050.FA1
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property FA2_Obj As SegmentContainer(Of Edi.Dom.Segments.FA2) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2050.FA2
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.FA2))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.N2)(0, "2", "0300"),
																		New SegmentContainer(Of Edi.Dom.Segments.N3)(0, "2", "0400"),
																		CType(Nothing, Edi.Dom.Segments.N4_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "0600"),
																		New SegmentContainer(Of Edi.Dom.Segments.PER)(0, "2", "0700")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
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
														New ReaderState(9, "PER", ReadAction.PopulateSegment, 9, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";DO;EY;IL;QE;") AndAlso String.Compare(args.Implementation, "_820A1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "3"
						Seg.SetSequence = "0200"
					End If
				ElseIf String.Compare(segmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property NM1_Obj As Edi.Dom.Segments.NM1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_IFace_Loop2100B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property N2_Obj As SegmentContainer(Of Edi.Dom.Segments.N2) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.N2
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.N2))
				End Get
			End Property

			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.N3
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.N3))
				End Get
			End Property

			Friend Property N4_Obj As Edi.Dom.Segments.N4_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.REF
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2100.PER
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2200_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.ADX_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.NTE)(0, "2", "0900"),
																		New SegmentContainer(Of Edi.Dom.Segments.PER)(0, "2", "1000"),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2210)(0, "2", "1100"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2220)(0, "2", "1300"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2230)(0, "2", "1400"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2240)(0, "2", "1420"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2250)(0, "2", "1450"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2260)(0, "2", "1495")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ADX", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(4, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 7, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 7, False),
														New ReaderState(4, "REF", ReadAction.PopulateLoop, 7, False),
														New ReaderState(6, "REF", ReadAction.PopulateLoop, 7, False),
														New ReaderState(7, "REF", ReadAction.PopulateLoop, 7, False),
														New ReaderState(1, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(2, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(4, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(6, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(7, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(9, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(4, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(6, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(7, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(9, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(11, "REF", ReadAction.PopulateLoop, 11, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(6, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(7, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(9, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(11, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(13, "SAC", ReadAction.PopulateLoop, 13, False),
														New ReaderState(1, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(2, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(4, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(6, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(7, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(9, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(11, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(13, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(15, "SLN", ReadAction.PopulateLoop, 15, False),
														New ReaderState(1, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(2, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(4, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(6, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(7, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(9, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(11, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(13, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(15, "FA1", ReadAction.PopulateLoop, 17, False),
														New ReaderState(17, "FA1", ReadAction.PopulateLoop, 17, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ADX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ADX_Obj = Seg
				ElseIf String.Compare(segmentName, "NTE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NTE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NTE_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2210_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2210_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2220_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2220_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2230_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2230_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2240_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2240_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2250_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2250_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2260_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2260_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property ADX_Obj As Edi.Dom.Segments.ADX_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ADX_Std As Edi.Dom.Segments.ADX Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.ADX
				Get
					Return CType(Children(0), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX)
					Children(0) = value
				End Set
			End Property

			Private Property ADX_IFace_Loop2200A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A.ADX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX)
					Children(0) = value
				End Set
			End Property
			Private Property ADX_IFace_1_Loop2200B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B.ADX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property NTE_Obj As SegmentContainer(Of Edi.Dom.Segments.NTE) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.NTE
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.NTE))
				End Get
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.PER
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.DTM
				Get
					Return CType(Children(3), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2210_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2210) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2210
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2210))
				End Get
			End Property

			Friend ReadOnly Property Loop2220_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2220) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2220
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2220))
				End Get
			End Property

			Friend ReadOnly Property Loop2230_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2230) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2230
				Get
					Return CType(Children(6), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2230))
				End Get
			End Property

			Friend ReadOnly Property Loop2240_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2240) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2240
				Get
					Return CType(Children(7), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2240))
				End Get
			End Property

			Friend ReadOnly Property Loop2250_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2250) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2250
				Get
					Return CType(Children(8), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2250))
				End Get
			End Property

			Friend ReadOnly Property Loop2260_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2260) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2200.Loop2260
				Get
					Return CType(Children(9), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2260))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2210_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2210
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "1200")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2210.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2210.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2220_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2220
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.IT1_Obj),
																		CType(Nothing, Edi.Dom.Segments.RPA_Obj),
																		CType(Nothing, Edi.Dom.Segments.QTY_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "IT1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "RPA", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "QTY", ReadAction.PopulateSegment, 3, False),
														New ReaderState(2, "QTY", ReadAction.PopulateSegment, 3, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IT1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IT1_Obj = Seg
				ElseIf String.Compare(segmentName, "RPA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RPA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RPA_Obj = Seg
				ElseIf String.Compare(segmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property IT1_Obj As Edi.Dom.Segments.IT1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property IT1_Std As Edi.Dom.Segments.IT1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2220.IT1
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1)
					Children(0) = value
				End Set
			End Property

			Friend Property RPA_Obj As Edi.Dom.Segments.RPA_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property RPA_Std As Edi.Dom.Segments.RPA Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2220.RPA
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA)
					Children(1) = value
				End Set
			End Property

			Friend Property QTY_Obj As Edi.Dom.Segments.QTY_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property QTY_Std As Edi.Dom.Segments.QTY Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2220.QTY
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY)
					Children(2) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2230_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2230
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2230.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2230.DTM
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2240_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2240
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "1430"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(10, "2", "1440")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "DTM", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2240.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2240.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2240.DTM
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2250_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2250
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SLN_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2255)(0, "2", "1460"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2258)(0, "2", "1480")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SLN", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SLN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SLN_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2255_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2255_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2258_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2258_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property SLN_Obj As Edi.Dom.Segments.SLN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SLN_Std As Edi.Dom.Segments.SLN Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2250.SLN
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2255_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2255) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2250.Loop2255
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2255))
				End Get
			End Property

			Friend ReadOnly Property Loop2258_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2258) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2250.Loop2258
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2258))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2255_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2255
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "1470")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2255.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2255.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2258_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2258
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "1490")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2258.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2258.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2260_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2260
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.FA1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.FA2)(0, "2", "1496")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "FA1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "FA2", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "FA2", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA1_Obj = Seg
				ElseIf String.Compare(segmentName, "FA2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA2_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property FA1_Obj As Edi.Dom.Segments.FA1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property FA1_Std As Edi.Dom.Segments.FA1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2260.FA1
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property FA2_Obj As SegmentContainer(Of Edi.Dom.Segments.FA2) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2260.FA2
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.FA2))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2300_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.RMR_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.NTE)(0, "2", "1600"),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "1700"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "1800"),
																		CType(Nothing, Edi.Dom.Segments.VEH_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2310)(0, "2", "1900"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2320)(0, "2", "2100")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "RMR", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(4, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(6, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(1, "VEH", ReadAction.PopulateSegment, 8, False),
														New ReaderState(2, "VEH", ReadAction.PopulateSegment, 8, False),
														New ReaderState(4, "VEH", ReadAction.PopulateSegment, 8, False),
														New ReaderState(6, "VEH", ReadAction.PopulateSegment, 8, False),
														New ReaderState(1, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(2, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(4, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(6, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(8, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(9, "IT1", ReadAction.PopulateLoop, 9, False),
														New ReaderState(1, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(2, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(4, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(6, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(8, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(9, "ADX", ReadAction.PopulateLoop, 11, False),
														New ReaderState(11, "ADX", ReadAction.PopulateLoop, 11, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "RMR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RMR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RMR_Obj = Seg
				ElseIf String.Compare(segmentName, "NTE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NTE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NTE_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";14;17;18;2F;38;E9;LB;LU;ZZ;") AndAlso String.Compare(args.Implementation, "_820A1__2000A__2300A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "1700"
					ElseIf MyBase.CompareKey(S2.REF01, ";14;18;2F;38;E9;LU;ZZ;") AndAlso String.Compare(args.Implementation, "_820A1__2000B__2300B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "3"
						Seg.SetSequence = "1700"
					End If
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTM_Obj)
					If MyBase.CompareKey(S2.DTM01, ";582;AAG;") AndAlso String.Compare(args.Implementation, "_820A1__2000A__2300A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "1800"
					ElseIf MyBase.CompareKey(S2.DTM01, ";582;AAG;") AndAlso String.Compare(args.Implementation, "_820A1__2000B__2300B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "3"
						Seg.SetSequence = "1800"
					End If
				ElseIf String.Compare(segmentName, "VEH", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.VEH_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					VEH_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2310_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2310_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A__2300A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2300A__2310A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "1900"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2320_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2320_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A__2300A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2300A__2320A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "2100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf String.Compare(args.Implementation, "_820A1__2000B__2300B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000B__2300B__2320B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "2100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property RMR_Obj As Edi.Dom.Segments.RMR_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.RMR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RMR_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property RMR_Std As Edi.Dom.Segments.RMR Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.RMR
				Get
					Return CType(Children(0), Edi.Dom.Segments.RMR_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RMR)
					Children(0) = value
				End Set
			End Property

			Private Property RMR_IFace_Loop2300A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A.RMR
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR)
					Children(0) = value
				End Set
			End Property
			Private Property RMR_IFace_1_Loop2300B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B.RMR
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property NTE_Obj As SegmentContainer(Of Edi.Dom.Segments.NTE) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.NTE
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.NTE))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.REF
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2300A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2300A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A.REF
				Get
					If REFSubset_Loop2300A_Obj Is Nothing Then
						REFSubset_Loop2300A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF, Edi.Dom.Segments.REF)(Children(2), 0, "2", "1700")
					End If

					Return REFSubset_Loop2300A_Obj
				End Get
			End Property
			Private REFSubset_1_Loop2300B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2300B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B.REF
				Get
					If REFSubset_1_Loop2300B_Obj Is Nothing Then
						REFSubset_1_Loop2300B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF, Edi.Dom.Segments.REF)(Children(2), 0, "3", "1700")
					End If

					Return REFSubset_1_Loop2300B_Obj
				End Get
			End Property
			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.DTM
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property

			Private DTMSubset_Loop2300A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_Loop2300A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A.DTM
				Get
					If DTMSubset_Loop2300A_Obj Is Nothing Then
						DTMSubset_Loop2300A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM, Edi.Dom.Segments.DTM)(Children(3), 1, "2", "1800")
					End If

					If DTMSubset_Loop2300A_Obj.Count > 0 Then
						Return DTMSubset_Loop2300A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM)
					If DTMSubset_Loop2300A_Obj Is Nothing Then
						DTMSubset_Loop2300A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM, Edi.Dom.Segments.DTM)(Children(3), 1, "2", "1800")
					End If

					If DTMSubset_Loop2300A_Obj.Count = 0 Then
						DTMSubset_Loop2300A_Obj.Add(value)
					Else
						DTMSubset_Loop2300A_Obj(0) = value
					End If
				End Set
			End Property
			Private DTMSubset_1_Loop2300B_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM, Edi.Dom.Segments.DTM)
			Private Property DTM_IFace_1_Loop2300B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B.DTM
				Get
					If DTMSubset_1_Loop2300B_Obj Is Nothing Then
						DTMSubset_1_Loop2300B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM, Edi.Dom.Segments.DTM)(Children(3), 1, "3", "1800")
					End If

					If DTMSubset_1_Loop2300B_Obj.Count > 0 Then
						Return DTMSubset_1_Loop2300B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM)
					If DTMSubset_1_Loop2300B_Obj Is Nothing Then
						DTMSubset_1_Loop2300B_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM, Edi.Dom.Segments.DTM)(Children(3), 1, "3", "1800")
					End If

					If DTMSubset_1_Loop2300B_Obj.Count = 0 Then
						DTMSubset_1_Loop2300B_Obj.Add(value)
					Else
						DTMSubset_1_Loop2300B_Obj(0) = value
					End If
				End Set
			End Property
			Friend Property VEH_Obj As Edi.Dom.Segments.VEH_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.VEH_Obj)
				End Get
				Set(value As Edi.Dom.Segments.VEH_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property VEH_Std As Edi.Dom.Segments.VEH Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.VEH
				Get
					Return CType(Children(4), Edi.Dom.Segments.VEH_Obj)
				End Get
				Set(value As Edi.Dom.Segments.VEH)
					Children(4) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2310_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2310) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.Loop2310
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2310))
				End Get
			End Property

			Private Loop2310ASubset_Loop2300A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A, Edi.Dom.Transactions.Transaction820.Loops.Loop2310)
			Private Property Loop2310A_IFace_Loop2300A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A.Loop2310A
				Get
					If Loop2310ASubset_Loop2300A_Obj Is Nothing Then
						Loop2310ASubset_Loop2300A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A, Edi.Dom.Transactions.Transaction820.Loops.Loop2310)(Children(5), 1, "2", "1900")
					End If

					If Loop2310ASubset_Loop2300A_Obj.Count > 0 Then
						Return Loop2310ASubset_Loop2300A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A)
					If Loop2310ASubset_Loop2300A_Obj Is Nothing Then
						Loop2310ASubset_Loop2300A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A, Edi.Dom.Transactions.Transaction820.Loops.Loop2310)(Children(5), 1, "2", "1900")
					End If

					If Loop2310ASubset_Loop2300A_Obj.Count = 0 Then
						Loop2310ASubset_Loop2300A_Obj.Add(value)
					Else
						Loop2310ASubset_Loop2300A_Obj(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property Loop2320_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2320) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2300.Loop2320
				Get
					Return CType(Children(6), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2320))
				End Get
			End Property

			Private Loop2320ASubset_Loop2300A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)
			Private ReadOnly Property Loop2320A_Obj_Loop2300A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A, Edi.Dom.Transactions.Transaction820.Loops.Loop2320) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A.Loop2320A
				Get
					If Loop2320ASubset_Loop2300A_Obj Is Nothing Then
						Loop2320ASubset_Loop2300A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)(Children(6), 0, "2", "2100")
					End If

					Return Loop2320ASubset_Loop2300A_Obj
				End Get
			End Property
			Private Loop2320BSubset_Loop2300B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)
			Private ReadOnly Property Loop2320B_Obj_Loop2300B_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B, Edi.Dom.Transactions.Transaction820.Loops.Loop2320) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B.Loop2320B
				Get
					If Loop2320BSubset_Loop2300B_Obj Is Nothing Then
						Loop2320BSubset_Loop2300B_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)(Children(6), 0, "3", "2100")
					End If

					Return Loop2320BSubset_Loop2300B_Obj
				End Get
			End Property

		End Class
		Partial Friend Class Loop2310_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.IT1_Obj),
																		CType(Nothing, Edi.Dom.Segments.RPA_Obj),
																		CType(Nothing, Edi.Dom.Segments.QTY_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2311)(0, "2", "2000"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2312)(0, "2", "2020"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2315)(0, "2", "2040")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "IT1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "RPA", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "QTY", ReadAction.PopulateSegment, 3, False),
														New ReaderState(2, "QTY", ReadAction.PopulateSegment, 3, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(3, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(3, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(1, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(2, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(3, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(4, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(6, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(8, "SLN", ReadAction.PopulateLoop, 8, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IT1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IT1_Obj = Seg
				ElseIf String.Compare(segmentName, "RPA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RPA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RPA_Obj = Seg
				ElseIf String.Compare(segmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2311_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2311_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2312_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2312_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A__2300A__2310A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2300A__2310A__2312A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "2020"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2315_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2315_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_820A1__2000A__2300A__2310A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_820A1__2000A__2300A__2310A__2315A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "2040"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property IT1_Obj As Edi.Dom.Segments.IT1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property IT1_Std As Edi.Dom.Segments.IT1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.IT1
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1)
					Children(0) = value
				End Set
			End Property

			Private Property IT1_IFace_Loop2310A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1 Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A.IT1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1)
					Children(0) = value
				End Set
			End Property
			Friend Property RPA_Obj As Edi.Dom.Segments.RPA_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property RPA_Std As Edi.Dom.Segments.RPA Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.RPA
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA)
					Children(1) = value
				End Set
			End Property

			Friend Property QTY_Obj As Edi.Dom.Segments.QTY_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property QTY_Std As Edi.Dom.Segments.QTY Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.QTY
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY)
					Children(2) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2311_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2311) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.Loop2311
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2311))
				End Get
			End Property

			Friend ReadOnly Property Loop2312_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2312) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.Loop2312
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2312))
				End Get
			End Property

			Private Loop2312ASubset_Loop2310A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A, Edi.Dom.Transactions.Transaction820.Loops.Loop2312)
			Private ReadOnly Property Loop2312A_Obj_Loop2310A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A, Edi.Dom.Transactions.Transaction820.Loops.Loop2312) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A.Loop2312A
				Get
					If Loop2312ASubset_Loop2310A_Obj Is Nothing Then
						Loop2312ASubset_Loop2310A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A, Edi.Dom.Transactions.Transaction820.Loops.Loop2312)(Children(4), 4, "2", "2020")
					End If

					Return Loop2312ASubset_Loop2310A_Obj
				End Get
			End Property
			Friend ReadOnly Property Loop2315_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2315) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2310.Loop2315
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2315))
				End Get
			End Property

			Private Loop2315ASubset_Loop2310A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A, Edi.Dom.Transactions.Transaction820.Loops.Loop2315)
			Private ReadOnly Property Loop2315A_Obj_Loop2310A_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A, Edi.Dom.Transactions.Transaction820.Loops.Loop2315) Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A.Loop2315A
				Get
					If Loop2315ASubset_Loop2310A_Obj Is Nothing Then
						Loop2315ASubset_Loop2310A_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A, Edi.Dom.Transactions.Transaction820.Loops.Loop2315)(Children(5), 3, "2", "2040")
					End If

					Return Loop2315ASubset_Loop2310A_Obj
				End Get
			End Property

		End Class
		Partial Friend Class Loop2311_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2311
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2311.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2311.DTM
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2312_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2312,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "2030")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2312.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_IFace_Loop2312A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A.SAC
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2312.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2315_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2315,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SLN_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2316)(0, "2", "2050"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2317)(0, "2", "2070")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SLN", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SLN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SLN_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2316_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2316_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2317_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2317_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property SLN_Obj As Edi.Dom.Segments.SLN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SLN_Std As Edi.Dom.Segments.SLN Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2315.SLN
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN)
					Children(0) = value
				End Set
			End Property

			Private Property SLN_IFace_Loop2315A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A.SLN
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2316_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2316) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2315.Loop2316
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2316))
				End Get
			End Property

			Friend ReadOnly Property Loop2317_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2317) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2315.Loop2317
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2317))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2316_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2316
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "2060")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2316.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2316.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2317_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2317
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "2080")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2317.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2317.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2320_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A,
															Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.ADX_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.NTE)(0, "2", "2200"),
																		New SegmentContainer(Of Edi.Dom.Segments.PER)(0, "2", "2300"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2400)(0, "2", "2400"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2410)(0, "2", "2600")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ADX", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "NTE", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "PER", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "REF", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "REF", ReadAction.PopulateLoop, 6, False),
														New ReaderState(1, "IT1", ReadAction.PopulateLoop, 8, False),
														New ReaderState(2, "IT1", ReadAction.PopulateLoop, 8, False),
														New ReaderState(4, "IT1", ReadAction.PopulateLoop, 8, False),
														New ReaderState(6, "IT1", ReadAction.PopulateLoop, 8, False),
														New ReaderState(8, "IT1", ReadAction.PopulateLoop, 8, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ADX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ADX_Obj = Seg
				ElseIf String.Compare(segmentName, "NTE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NTE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NTE_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2400_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2400_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2410_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2410_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property ADX_Obj As Edi.Dom.Segments.ADX_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ADX_Std As Edi.Dom.Segments.ADX Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320.ADX
				Get
					Return CType(Children(0), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX)
					Children(0) = value
				End Set
			End Property

			Private Property ADX_IFace_Loop2320A_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A.ADX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX)
					Children(0) = value
				End Set
			End Property
			Private Property ADX_IFace_1_Loop2320B_Obj As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX Implements Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B.ADX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property NTE_Obj As SegmentContainer(Of Edi.Dom.Segments.NTE) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320.NTE
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.NTE))
				End Get
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320.PER
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Friend ReadOnly Property Loop2400_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2400) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320.Loop2400
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2400))
				End Get
			End Property

			Friend ReadOnly Property Loop2410_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2410) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2320.Loop2410
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2410))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2400_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2400
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "2500")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2400.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2400.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2410_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.IT1_Obj),
																		CType(Nothing, Edi.Dom.Segments.RPA_Obj),
																		CType(Nothing, Edi.Dom.Segments.QTY_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2415)(0, "2", "2700"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2416)(0, "2", "2720"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2420)(0, "2", "2750")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "IT1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "RPA", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "QTY", ReadAction.PopulateSegment, 3, False),
														New ReaderState(2, "QTY", ReadAction.PopulateSegment, 3, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(3, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "REF", ReadAction.PopulateLoop, 4, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(3, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "SAC", ReadAction.PopulateLoop, 6, False),
														New ReaderState(1, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(2, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(3, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(4, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(6, "SLN", ReadAction.PopulateLoop, 8, False),
														New ReaderState(8, "SLN", ReadAction.PopulateLoop, 8, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "IT1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IT1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IT1_Obj = Seg
				ElseIf String.Compare(segmentName, "RPA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RPA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RPA_Obj = Seg
				ElseIf String.Compare(segmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2415_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2415_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2416_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2416_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2420_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2420_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property IT1_Obj As Edi.Dom.Segments.IT1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property IT1_Std As Edi.Dom.Segments.IT1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.IT1
				Get
					Return CType(Children(0), Edi.Dom.Segments.IT1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IT1)
					Children(0) = value
				End Set
			End Property

			Friend Property RPA_Obj As Edi.Dom.Segments.RPA_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property RPA_Std As Edi.Dom.Segments.RPA Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.RPA
				Get
					Return CType(Children(1), Edi.Dom.Segments.RPA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RPA)
					Children(1) = value
				End Set
			End Property

			Friend Property QTY_Obj As Edi.Dom.Segments.QTY_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property QTY_Std As Edi.Dom.Segments.QTY Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.QTY
				Get
					Return CType(Children(2), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY)
					Children(2) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2415_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2415) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.Loop2415
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2415))
				End Get
			End Property

			Friend ReadOnly Property Loop2416_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2416) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.Loop2416
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2416))
				End Get
			End Property

			Friend ReadOnly Property Loop2420_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2420) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2410.Loop2420
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2420))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2415_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2415
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2415.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2415.DTM
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2416_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2416
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "2730"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(10, "2", "2740")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "DTM", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2416.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2416.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2416.DTM
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2420_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2420
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SLN_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2425)(0, "2", "2760"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2427)(0, "2", "2780")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SLN", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "SAC", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "SAC", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SLN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SLN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SLN_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2425_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2425_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2427_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2427_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property SLN_Obj As Edi.Dom.Segments.SLN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SLN_Std As Edi.Dom.Segments.SLN Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2420.SLN
				Get
					Return CType(Children(0), Edi.Dom.Segments.SLN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SLN)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2425_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2425) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2420.Loop2425
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2425))
				End Get
			End Property

			Friend ReadOnly Property Loop2427_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2427) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2420.Loop2427
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2427))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2425_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2425
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.REF_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "2770")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "REF", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2425.REF
				Get
					Return CType(Children(0), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2425.DTM
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2427_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2427
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.SAC_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "2790"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2428)(0, "2", "2795")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "SAC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "FA1", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "FA1", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "FA1", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "SAC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SAC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SAC_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop2428_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2428_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property SAC_Obj As Edi.Dom.Segments.SAC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property SAC_Std As Edi.Dom.Segments.SAC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2427.SAC
				Get
					Return CType(Children(0), Edi.Dom.Segments.SAC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SAC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2427.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property

			Friend ReadOnly Property Loop2428_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2428) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2427.Loop2428
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2428))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2428_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2428
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.FA1_Obj),
																		CType(Nothing, Edi.Dom.Segments.FA2_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "FA1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "FA2", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "FA1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA1_Obj = Seg
				ElseIf String.Compare(segmentName, "FA2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FA2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FA2_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property FA1_Obj As Edi.Dom.Segments.FA1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property FA1_Std As Edi.Dom.Segments.FA1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2428.FA1
				Get
					Return CType(Children(0), Edi.Dom.Segments.FA1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA1)
					Children(0) = value
				End Set
			End Property

			Friend Property FA2_Obj As Edi.Dom.Segments.FA2_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.FA2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA2_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property FA2_Std As Edi.Dom.Segments.FA2 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop2428.FA2
				Get
					Return CType(Children(1), Edi.Dom.Segments.FA2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FA2)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop3000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.TXP_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.TXI)(0, "2", "2850"),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "2855"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTM)(0, "2", "2860")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "TXP", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "TXI", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "REF", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(2, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(4, "DTM", ReadAction.PopulateSegment, 6, False),
														New ReaderState(6, "DTM", ReadAction.PopulateSegment, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "TXP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXP_Obj = Seg
				ElseIf String.Compare(segmentName, "TXI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TXI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TXI_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property TXP_Obj As Edi.Dom.Segments.TXP_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.TXP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.TXP_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property TXP_Std As Edi.Dom.Segments.TXP Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3000.TXP
				Get
					Return CType(Children(0), Edi.Dom.Segments.TXP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.TXP)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property TXI_Obj As SegmentContainer(Of Edi.Dom.Segments.TXI) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3000.TXI
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.TXI))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3000.REF
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property DTM_Obj As SegmentContainer(Of Edi.Dom.Segments.DTM) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3000.DTM
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.DTM))
				End Get
			End Property


		End Class
		Partial Friend Class Loop3100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3100
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.DED_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "DED", ReadAction.PopulateSegment, 1, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "DED", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DED_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DED_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property DED_Obj As Edi.Dom.Segments.DED_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.DED_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DED_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property DED_Std As Edi.Dom.Segments.DED Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3100.DED
				Get
					Return CType(Children(0), Edi.Dom.Segments.DED_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DED)
					Children(0) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop3200_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3200
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.LX_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "2950"),
																		New SegmentContainer(Of Edi.Dom.Segments.TRN)(0, "2", "3000"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3210)(0, "2", "3050")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LX", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "TRN", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "TRN", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "TRN", ReadAction.PopulateSegment, 4, False),
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
				If String.Compare(segmentName, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LX_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TRN_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3210_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3210_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property LX_Obj As Edi.Dom.Segments.LX_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.LX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LX_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property LX_Std As Edi.Dom.Segments.LX Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3200.LX
				Get
					Return CType(Children(0), Edi.Dom.Segments.LX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LX)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3200.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property TRN_Obj As SegmentContainer(Of Edi.Dom.Segments.TRN) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3200.TRN
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.TRN))
				End Get
			End Property

			Friend ReadOnly Property Loop3210_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3210) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3200.Loop3210
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3210))
				End Get
			End Property


		End Class
		Partial Friend Class Loop3210_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "3100"),
																		CType(Nothing, Edi.Dom.Segments.G53_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3215)(0, "2", "3200"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3217)(0, "2", "3350")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "G53", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "G53", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "AIN", ReadAction.PopulateLoop, 5, False),
														New ReaderState(2, "AIN", ReadAction.PopulateLoop, 5, False),
														New ReaderState(4, "AIN", ReadAction.PopulateLoop, 5, False),
														New ReaderState(5, "AIN", ReadAction.PopulateLoop, 5, False),
														New ReaderState(1, "PEN", ReadAction.PopulateLoop, 7, False),
														New ReaderState(2, "PEN", ReadAction.PopulateLoop, 7, False),
														New ReaderState(4, "PEN", ReadAction.PopulateLoop, 7, False),
														New ReaderState(5, "PEN", ReadAction.PopulateLoop, 7, False),
														New ReaderState(7, "PEN", ReadAction.PopulateLoop, 7, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "G53", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.G53_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					G53_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "AIN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3215_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3215_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "PEN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3217_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3217_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property NM1_Obj As Edi.Dom.Segments.NM1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend Property G53_Obj As Edi.Dom.Segments.G53_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.G53_Obj)
				End Get
				Set(value As Edi.Dom.Segments.G53_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property G53_Std As Edi.Dom.Segments.G53 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210.G53
				Get
					Return CType(Children(2), Edi.Dom.Segments.G53_Obj)
				End Get
				Set(value As Edi.Dom.Segments.G53)
					Children(2) = value
				End Set
			End Property

			Friend ReadOnly Property Loop3215_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3215) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210.Loop3215
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3215))
				End Get
			End Property

			Friend ReadOnly Property Loop3217_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3217) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3210.Loop3217
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3217))
				End Get
			End Property


		End Class
		Partial Friend Class Loop3215_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3215
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.AIN_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.QTY)(0, "2", "3250"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "3300")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "AIN", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "QTY", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "QTY", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "AIN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AIN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AIN_Obj = Seg
				ElseIf String.Compare(segmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property AIN_Obj As Edi.Dom.Segments.AIN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.AIN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AIN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property AIN_Std As Edi.Dom.Segments.AIN Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3215.AIN
				Get
					Return CType(Children(0), Edi.Dom.Segments.AIN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AIN)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3215.QTY
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.QTY))
				End Get
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3215.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property


		End Class
		Partial Friend Class Loop3217_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3217
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.PEN_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.AMT)(0, "2", "3400"),
																		New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "3450"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3219)(0, "2", "3500")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "PEN", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "AMT", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "AMT", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "INV", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "INV", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "INV", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "INV", ReadAction.PopulateLoop, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "PEN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PEN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PEN_Obj = Seg
				ElseIf String.Compare(segmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "INV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3219_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3219_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property PEN_Obj As Edi.Dom.Segments.PEN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.PEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PEN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property PEN_Std As Edi.Dom.Segments.PEN Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3217.PEN
				Get
					Return CType(Children(0), Edi.Dom.Segments.PEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PEN)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3217.AMT
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3217.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property Loop3219_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3219) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3217.Loop3219
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3219))
				End Get
			End Property


		End Class
		Partial Friend Class Loop3219_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3219
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.INV_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "3550")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "INV", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "INV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.INV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					INV_Obj = Seg
				ElseIf String.Compare(segmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property INV_Obj As Edi.Dom.Segments.INV_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.INV_Obj)
				End Get
				Set(value As Edi.Dom.Segments.INV_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property INV_Std As Edi.Dom.Segments.INV Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3219.INV
				Get
					Return CType(Children(0), Edi.Dom.Segments.INV_Obj)
				End Get
				Set(value As Edi.Dom.Segments.INV)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3219.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property


		End Class
		Partial Friend Class Loop4000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.N9_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "3650"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4100)(0, "2", "3700"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4200)(0, "2", "3900")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "N9", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "AMT", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "AMT", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "AMT", ReadAction.PopulateLoop, 4, False),
														New ReaderState(1, "N1", ReadAction.PopulateLoop, 6, False),
														New ReaderState(2, "N1", ReadAction.PopulateLoop, 6, False),
														New ReaderState(4, "N1", ReadAction.PopulateLoop, 6, False),
														New ReaderState(6, "N1", ReadAction.PopulateLoop, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "N9", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N9_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N9_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop4100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop4100_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop4200_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop4200_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property N9_Obj As Edi.Dom.Segments.N9_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.N9_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N9_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property N9_Std As Edi.Dom.Segments.N9 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4000.N9
				Get
					Return CType(Children(0), Edi.Dom.Segments.N9_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N9)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4000.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property Loop4100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4100) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4000.Loop4100
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4100))
				End Get
			End Property

			Friend ReadOnly Property Loop4200_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4200) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4000.Loop4200
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4200))
				End Get
			End Property


		End Class
		Partial Friend Class Loop4100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4100
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.AMT_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "3800")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "AMT", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property AMT_Obj As Edi.Dom.Segments.AMT_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property AMT_Std As Edi.Dom.Segments.AMT Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4100.AMT
				Get
					Return CType(Children(0), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4100.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property


		End Class
		Partial Friend Class Loop4200_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4200
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.N1_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "4000"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4250)(0, "2", "4100")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "N1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "EMS", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "EMS", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "EMS", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "EMS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop4250_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop4250_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property N1_Obj As Edi.Dom.Segments.N1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property N1_Std As Edi.Dom.Segments.N1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4200.N1
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4200.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property Loop4250_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4250) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4200.Loop4250
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4250))
				End Get
			End Property


		End Class
		Partial Friend Class Loop4250_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4250
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.EMS_Obj),
																		New SegmentContainer(Of Edi.Dom.Segments.ATN)(0, "2", "4200"),
																		New SegmentContainer(Of Edi.Dom.Segments.AIN)(0, "2", "4300"),
																		New SegmentContainer(Of Edi.Dom.Segments.PYD)(0, "2", "4400")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "EMS", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "ATN", ReadAction.PopulateSegment, 2, False),
														New ReaderState(2, "ATN", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "AIN", ReadAction.PopulateSegment, 4, False),
														New ReaderState(2, "AIN", ReadAction.PopulateSegment, 4, False),
														New ReaderState(4, "AIN", ReadAction.PopulateSegment, 4, False),
														New ReaderState(1, "PYD", ReadAction.PopulateSegment, 6, False),
														New ReaderState(2, "PYD", ReadAction.PopulateSegment, 6, False),
														New ReaderState(4, "PYD", ReadAction.PopulateSegment, 6, False),
														New ReaderState(6, "PYD", ReadAction.PopulateSegment, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "EMS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.EMS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					EMS_Obj = Seg
				ElseIf String.Compare(segmentName, "ATN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ATN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ATN_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "AIN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AIN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AIN_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PYD", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PYD_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PYD_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property EMS_Obj As Edi.Dom.Segments.EMS_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.EMS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.EMS_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property EMS_Std As Edi.Dom.Segments.EMS Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4250.EMS
				Get
					Return CType(Children(0), Edi.Dom.Segments.EMS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.EMS)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property ATN_Obj As SegmentContainer(Of Edi.Dom.Segments.ATN) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4250.ATN
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.ATN))
				End Get
			End Property

			Friend ReadOnly Property AIN_Obj As SegmentContainer(Of Edi.Dom.Segments.AIN) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4250.AIN
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.AIN))
				End Get
			End Property

			Friend ReadOnly Property PYD_Obj As SegmentContainer(Of Edi.Dom.Segments.PYD) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop4250.PYD
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.PYD))
				End Get
			End Property


		End Class
		Partial Friend Class Loop5000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.RYL_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5100)(0, "2", "4600")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "RYL", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "NM1", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "NM1", ReadAction.PopulateLoop, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "RYL", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RYL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RYL_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5100_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property RYL_Obj As Edi.Dom.Segments.RYL_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.RYL_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RYL_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property RYL_Std As Edi.Dom.Segments.RYL Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5000.RYL
				Get
					Return CType(Children(0), Edi.Dom.Segments.RYL_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RYL)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property Loop5100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5100) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5000.Loop5100
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5100))
				End Get
			End Property


		End Class
		Partial Friend Class Loop5100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5100
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5150)(0, "2", "4700"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3300)(0, "2", "5400")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "LOC", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "LOC", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "ASM", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "ASM", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "ASM", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "LOC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5150_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5150_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "ASM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop3300_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3300_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property NM1_Obj As Edi.Dom.Segments.NM1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5100.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property Loop5150_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5150) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5100.Loop5150
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5150))
				End Get
			End Property

			Friend ReadOnly Property Loop3300_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3300) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5100.Loop3300
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3300))
				End Get
			End Property


		End Class
		Partial Friend Class Loop5150_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5150
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.LOC_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5155)(0, "2", "4800"),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5157)(0, "2", "5000")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LOC", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "PID", ReadAction.PopulateLoop, 2, False),
														New ReaderState(2, "PID", ReadAction.PopulateLoop, 2, False),
														New ReaderState(1, "PCT", ReadAction.PopulateLoop, 4, False),
														New ReaderState(2, "PCT", ReadAction.PopulateLoop, 4, False),
														New ReaderState(4, "PCT", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "LOC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LOC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LOC_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "PID", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5155_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5155_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "PCT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5157_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5157_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property LOC_Obj As Edi.Dom.Segments.LOC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.LOC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LOC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property LOC_Std As Edi.Dom.Segments.LOC Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5150.LOC
				Get
					Return CType(Children(0), Edi.Dom.Segments.LOC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LOC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property Loop5155_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5155) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5150.Loop5155
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5155))
				End Get
			End Property

			Friend ReadOnly Property Loop5157_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5157) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5150.Loop5157
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5157))
				End Get
			End Property


		End Class
		Partial Friend Class Loop5155_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5155
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.PID_Obj),
																		CType(Nothing, Edi.Dom.Segments.DTM_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "PID", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "DTM", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "PID", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PID_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PID_Obj = Seg
				ElseIf String.Compare(segmentName, "DTM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTM_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property PID_Obj As Edi.Dom.Segments.PID_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.PID_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PID_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property PID_Std As Edi.Dom.Segments.PID Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5155.PID
				Get
					Return CType(Children(0), Edi.Dom.Segments.PID_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PID)
					Children(0) = value
				End Set
			End Property

			Friend Property DTM_Obj As Edi.Dom.Segments.DTM_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property DTM_Std As Edi.Dom.Segments.DTM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5155.DTM
				Get
					Return CType(Children(1), Edi.Dom.Segments.DTM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTM)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop5157_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5157
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.PCT_Obj),
																		CType(Nothing, Edi.Dom.Segments.QTY_Obj),
																		New LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5159)(0, "2", "5200")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "PCT", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "QTY", ReadAction.PopulateSegment, 2, False),
														New ReaderState(1, "AMT", ReadAction.PopulateLoop, 3, False),
														New ReaderState(2, "AMT", ReadAction.PopulateLoop, 3, False),
														New ReaderState(3, "AMT", ReadAction.PopulateLoop, 3, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "PCT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PCT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PCT_Obj = Seg
				ElseIf String.Compare(segmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction820.Loop5159_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop5159_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property PCT_Obj As Edi.Dom.Segments.PCT_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.PCT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PCT_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property PCT_Std As Edi.Dom.Segments.PCT Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5157.PCT
				Get
					Return CType(Children(0), Edi.Dom.Segments.PCT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PCT)
					Children(0) = value
				End Set
			End Property

			Friend Property QTY_Obj As Edi.Dom.Segments.QTY_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property QTY_Std As Edi.Dom.Segments.QTY Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5157.QTY
				Get
					Return CType(Children(1), Edi.Dom.Segments.QTY_Obj)
				End Get
				Set(value As Edi.Dom.Segments.QTY)
					Children(1) = value
				End Set
			End Property

			Friend ReadOnly Property Loop5159_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5159) Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5157.Loop5159
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5159))
				End Get
			End Property


		End Class
		Partial Friend Class Loop5159_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5159
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.AMT_Obj),
																		CType(Nothing, Edi.Dom.Segments.ADX_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "AMT", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "ADX", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj = Seg
				ElseIf String.Compare(segmentName, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ADX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ADX_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property AMT_Obj As Edi.Dom.Segments.AMT_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property AMT_Std As Edi.Dom.Segments.AMT Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5159.AMT
				Get
					Return CType(Children(0), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT)
					Children(0) = value
				End Set
			End Property

			Friend Property ADX_Obj As Edi.Dom.Segments.ADX_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property ADX_Std As Edi.Dom.Segments.ADX Implements Edi.Dom.Transactions.Transaction820.Loops.Loop5159.ADX
				Get
					Return CType(Children(1), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX)
					Children(1) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop3300_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3300
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.ASM_Obj),
																		CType(Nothing, Edi.Dom.Segments.ADX_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ASM", ReadAction.PopulateSegment, 1, False),
														New ReaderState(1, "ADX", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "ASM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ASM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ASM_Obj = Seg
				ElseIf String.Compare(segmentName, "ADX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ADX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ADX_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property ASM_Obj As Edi.Dom.Segments.ASM_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ASM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ASM_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ASM_Std As Edi.Dom.Segments.ASM Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3300.ASM
				Get
					Return CType(Children(0), Edi.Dom.Segments.ASM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ASM)
					Children(0) = value
				End Set
			End Property

			Friend Property ADX_Obj As Edi.Dom.Segments.ADX_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property ADX_Std As Edi.Dom.Segments.ADX Implements Edi.Dom.Transactions.Transaction820.Loops.Loop3300.ADX
				Get
					Return CType(Children(1), Edi.Dom.Segments.ADX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ADX)
					Children(1) = value
				End Set
			End Property


		End Class
		'''<summary>Payment Order/Remittance Advice</summary>
		'''<remarks></remarks>
		Public Interface Standard
			'''<summary>Transaction Set Header</summary>
			Property ST As Edi.Dom.Segments.ST
			'''<summary>Beginning Segment for Payment Order/Remittance Advice</summary>
			Property BPR As Edi.Dom.Segments.BPR
			'''<summary>Note/Special Instruction</summary>
			ReadOnly Property NTE As SegmentContainer(Of Edi.Dom.Segments.NTE)
			'''<summary>Trace</summary>
			Property TRN As Edi.Dom.Segments.TRN
			'''<summary>Currency</summary>
			Property CUR As Edi.Dom.Segments.CUR
			'''<summary>Reference Information</summary>
			ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
			'''<summary>Date/Time Reference</summary>
			ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			'''<summary>Party Identification</summary>
			ReadOnly Property Loop1000 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop1000)
			'''<summary>Entity</summary>
			ReadOnly Property Loop2000 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2000)
			'''<summary>Tax Payment</summary>
			ReadOnly Property Loop3000 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3000)
			'''<summary>Deductions</summary>
			ReadOnly Property Loop3100 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3100)
			'''<summary>Transaction Set Line Number</summary>
			ReadOnly Property Loop3200 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3200)
			'''<summary>Extended Reference Information</summary>
			ReadOnly Property Loop4000 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4000)
			'''<summary>Royalty Payment</summary>
			ReadOnly Property Loop5000 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5000)
			'''<summary>Transaction Set Trailer</summary>
			Property SE As Edi.Dom.Segments.SE
		End Interface
		Namespace Loops

			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop1000
				Inherits ILoop
				'''<summary>Party Identification</summary>
				Property N1 As Edi.Dom.Segments.N1
				'''<summary>Additional Name Information</summary>
				ReadOnly Property N2 As SegmentContainer(Of Edi.Dom.Segments.N2)
				'''<summary>Party Location</summary>
				ReadOnly Property N3 As SegmentContainer(Of Edi.Dom.Segments.N3)
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Remittance Delivery Method</summary>
				Property RDM As Edi.Dom.Segments.RDM
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2000
				Inherits ILoop
				'''<summary>Entity</summary>
				Property ENT As Edi.Dom.Segments.ENT
				'''<summary>Type of Financial Accounting Data</summary>
				ReadOnly Property Loop2050 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2050)
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop2100 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2100)
				'''<summary>Adjustment</summary>
				ReadOnly Property Loop2200 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2200)
				'''<summary>Remittance Advice Accounts Receivable Open Item Reference</summary>
				ReadOnly Property Loop2300 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2300)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2050
				Inherits ILoop
				'''<summary>Type of Financial Accounting Data</summary>
				Property FA1 As Edi.Dom.Segments.FA1
				'''<summary>Accounting Data</summary>
				ReadOnly Property FA2 As SegmentContainer(Of Edi.Dom.Segments.FA2)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2100
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Additional Name Information</summary>
				ReadOnly Property N2 As SegmentContainer(Of Edi.Dom.Segments.N2)
				'''<summary>Party Location</summary>
				ReadOnly Property N3 As SegmentContainer(Of Edi.Dom.Segments.N3)
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2200
				Inherits ILoop
				'''<summary>Adjustment</summary>
				Property ADX As Edi.Dom.Segments.ADX
				'''<summary>Note/Special Instruction</summary>
				ReadOnly Property NTE As SegmentContainer(Of Edi.Dom.Segments.NTE)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2210 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2210)
				'''<summary>Baseline Item Data (Invoice)</summary>
				ReadOnly Property Loop2220 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2220)
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2230 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2230)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2240 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2240)
				'''<summary>Subline Item Detail</summary>
				ReadOnly Property Loop2250 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2250)
				'''<summary>Type of Financial Accounting Data</summary>
				ReadOnly Property Loop2260 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2260)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2210
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2220
				Inherits ILoop
				'''<summary>Baseline Item Data (Invoice)</summary>
				Property IT1 As Edi.Dom.Segments.IT1
				'''<summary>Rate Amounts or Percents</summary>
				Property RPA As Edi.Dom.Segments.RPA
				'''<summary>Quantity Information</summary>
				Property QTY As Edi.Dom.Segments.QTY
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2230
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2240
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2250
				Inherits ILoop
				'''<summary>Subline Item Detail</summary>
				Property SLN As Edi.Dom.Segments.SLN
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2255 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2255)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2258 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2258)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2255
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2258
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2260
				Inherits ILoop
				'''<summary>Type of Financial Accounting Data</summary>
				Property FA1 As Edi.Dom.Segments.FA1
				'''<summary>Accounting Data</summary>
				ReadOnly Property FA2 As SegmentContainer(Of Edi.Dom.Segments.FA2)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2300
				Inherits ILoop
				'''<summary>Remittance Advice Accounts Receivable Open Item Reference</summary>
				Property RMR As Edi.Dom.Segments.RMR
				'''<summary>Note/Special Instruction</summary>
				ReadOnly Property NTE As SegmentContainer(Of Edi.Dom.Segments.NTE)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
				'''<summary>Vehicle Information</summary>
				Property VEH As Edi.Dom.Segments.VEH
				'''<summary>Baseline Item Data (Invoice)</summary>
				ReadOnly Property Loop2310 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2310)
				'''<summary>Adjustment</summary>
				ReadOnly Property Loop2320 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2320)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2310
				Inherits ILoop
				'''<summary>Baseline Item Data (Invoice)</summary>
				Property IT1 As Edi.Dom.Segments.IT1
				'''<summary>Rate Amounts or Percents</summary>
				Property RPA As Edi.Dom.Segments.RPA
				'''<summary>Quantity Information</summary>
				Property QTY As Edi.Dom.Segments.QTY
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2311 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2311)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2312 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2312)
				'''<summary>Subline Item Detail</summary>
				ReadOnly Property Loop2315 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2315)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2311
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2312
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2315
				Inherits ILoop
				'''<summary>Subline Item Detail</summary>
				Property SLN As Edi.Dom.Segments.SLN
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2316 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2316)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2317 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2317)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2316
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2317
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2320
				Inherits ILoop
				'''<summary>Adjustment</summary>
				Property ADX As Edi.Dom.Segments.ADX
				'''<summary>Note/Special Instruction</summary>
				ReadOnly Property NTE As SegmentContainer(Of Edi.Dom.Segments.NTE)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2400 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2400)
				'''<summary>Baseline Item Data (Invoice)</summary>
				ReadOnly Property Loop2410 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2410)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2400
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2410
				Inherits ILoop
				'''<summary>Baseline Item Data (Invoice)</summary>
				Property IT1 As Edi.Dom.Segments.IT1
				'''<summary>Rate Amounts or Percents</summary>
				Property RPA As Edi.Dom.Segments.RPA
				'''<summary>Quantity Information</summary>
				Property QTY As Edi.Dom.Segments.QTY
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2415 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2415)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2416 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2416)
				'''<summary>Subline Item Detail</summary>
				ReadOnly Property Loop2420 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2420)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2415
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2416
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2420
				Inherits ILoop
				'''<summary>Subline Item Detail</summary>
				Property SLN As Edi.Dom.Segments.SLN
				'''<summary>Reference Information</summary>
				ReadOnly Property Loop2425 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2425)
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				ReadOnly Property Loop2427 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2427)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2425
				Inherits ILoop
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2427
				Inherits ILoop
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Property SAC As Edi.Dom.Segments.SAC
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
				'''<summary>Type of Financial Accounting Data</summary>
				ReadOnly Property Loop2428 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop2428)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2428
				Inherits ILoop
				'''<summary>Type of Financial Accounting Data</summary>
				Property FA1 As Edi.Dom.Segments.FA1
				'''<summary>Accounting Data</summary>
				Property FA2 As Edi.Dom.Segments.FA2
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3000
				Inherits ILoop
				'''<summary>Tax Payment</summary>
				Property TXP As Edi.Dom.Segments.TXP
				'''<summary>Tax Information</summary>
				ReadOnly Property TXI As SegmentContainer(Of Edi.Dom.Segments.TXI)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Date/Time Reference</summary>
				ReadOnly Property DTM As SegmentContainer(Of Edi.Dom.Segments.DTM)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3100
				Inherits ILoop
				'''<summary>Deductions</summary>
				Property DED As Edi.Dom.Segments.DED
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3200
				Inherits ILoop
				'''<summary>Transaction Set Line Number</summary>
				Property LX As Edi.Dom.Segments.LX
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Trace</summary>
				ReadOnly Property TRN As SegmentContainer(Of Edi.Dom.Segments.TRN)
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop3210 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3210)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3210
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Maintenance Type</summary>
				Property G53 As Edi.Dom.Segments.G53
				'''<summary>Income</summary>
				ReadOnly Property Loop3215 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3215)
				'''<summary>Pension Information</summary>
				ReadOnly Property Loop3217 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3217)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3215
				Inherits ILoop
				'''<summary>Income</summary>
				Property AIN As Edi.Dom.Segments.AIN
				'''<summary>Quantity Information</summary>
				ReadOnly Property QTY As SegmentContainer(Of Edi.Dom.Segments.QTY)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3217
				Inherits ILoop
				'''<summary>Pension Information</summary>
				Property PEN As Edi.Dom.Segments.PEN
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Investment Vehicle Selection</summary>
				ReadOnly Property Loop3219 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3219)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3219
				Inherits ILoop
				'''<summary>Investment Vehicle Selection</summary>
				Property INV As Edi.Dom.Segments.INV
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop4000
				Inherits ILoop
				'''<summary>Extended Reference Information</summary>
				Property N9 As Edi.Dom.Segments.N9
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property Loop4100 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4100)
				'''<summary>Party Identification</summary>
				ReadOnly Property Loop4200 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4200)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop4100
				Inherits ILoop
				'''<summary>Monetary Amount Information</summary>
				Property AMT As Edi.Dom.Segments.AMT
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop4200
				Inherits ILoop
				'''<summary>Party Identification</summary>
				Property N1 As Edi.Dom.Segments.N1
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Employment Position</summary>
				ReadOnly Property Loop4250 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop4250)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop4250
				Inherits ILoop
				'''<summary>Employment Position</summary>
				Property EMS As Edi.Dom.Segments.EMS
				'''<summary>Attendance</summary>
				ReadOnly Property ATN As SegmentContainer(Of Edi.Dom.Segments.ATN)
				'''<summary>Income</summary>
				ReadOnly Property AIN As SegmentContainer(Of Edi.Dom.Segments.AIN)
				'''<summary>Payroll Deduction</summary>
				ReadOnly Property PYD As SegmentContainer(Of Edi.Dom.Segments.PYD)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5000
				Inherits ILoop
				'''<summary>Royalty Payment</summary>
				Property RYL As Edi.Dom.Segments.RYL
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop5100 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5100)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5100
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Location</summary>
				ReadOnly Property Loop5150 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5150)
				'''<summary>Amount and Settlement Method</summary>
				ReadOnly Property Loop3300 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop3300)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5150
				Inherits ILoop
				'''<summary>Location</summary>
				Property LOC As Edi.Dom.Segments.LOC
				'''<summary>Product/Item Description</summary>
				ReadOnly Property Loop5155 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5155)
				'''<summary>Percent Amounts</summary>
				ReadOnly Property Loop5157 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5157)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5155
				Inherits ILoop
				'''<summary>Product/Item Description</summary>
				Property PID As Edi.Dom.Segments.PID
				'''<summary>Date/Time Reference</summary>
				Property DTM As Edi.Dom.Segments.DTM
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5157
				Inherits ILoop
				'''<summary>Percent Amounts</summary>
				Property PCT As Edi.Dom.Segments.PCT
				'''<summary>Quantity Information</summary>
				Property QTY As Edi.Dom.Segments.QTY
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property Loop5159 As LoopContainer(Of Edi.Dom.Transactions.Transaction820.Loops.Loop5159)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop5159
				Inherits ILoop
				'''<summary>Monetary Amount Information</summary>
				Property AMT As Edi.Dom.Segments.AMT
				'''<summary>Adjustment</summary>
				Property ADX As Edi.Dom.Segments.ADX
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3300
				Inherits ILoop
				'''<summary>Amount and Settlement Method</summary>
				Property ASM As Edi.Dom.Segments.ASM
				'''<summary>Adjustment</summary>
				Property ADX As Edi.Dom.Segments.ADX
			End Interface

		End Namespace 'Loops


		Namespace Transaction820_A1
			Namespace Segments

				Namespace Loop1000A

					'''<summary>Premium Receiver's Name</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Premium Receiver's Last or Organization Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Premium Receiver's Identification Code</summary>
						Property N104 As String
					End Interface
					'''<summary>Premium Receiver Additional Name</summary>
					Public Interface N2
						Inherits ISegment

						'''<summary>Premium Receiver's Additional Name</summary>
						Property N201 As String
					End Interface
					'''<summary>Premium Receiver's Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Premium Receiver's Address Line</summary>
						Property N301 As String
						'''<summary>Premium Receiver's Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Premium Receiver's City, State, and ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Premium Receiver's City Name</summary>
						Property N401 As String
						'''<summary>Premium Receiver's State Code</summary>
						Property N402 As String
						'''<summary>Premium Receiver's Postal Zone or Zip Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Premium Receiver's Remittance Delivery Method</summary>
					Public Interface RDM
						Inherits ISegment

						'''<summary>Remittance Delivery Method Code</summary>
						Property RDM01 As String
						'''<summary>Premium Receiver's Last or Organization Name</summary>
						Property RDM02 As String
						'''<summary>Premium Receiver's Communication Number</summary>
						Property RDM03 As String
					End Interface
				End Namespace 'Loop1000A

				Namespace Loop1000B

					'''<summary>Premium Payer's Name</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Premium Payer Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Premium Payer Identifier</summary>
						Property N104 As String
					End Interface
					'''<summary>Premium Payer Additional Name</summary>
					Public Interface N2
						Inherits ISegment

						'''<summary>Premium Payer Additional Name</summary>
						Property N201 As String
					End Interface
					'''<summary>Premium Payer's Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Premium Payer Address Line</summary>
						Property N301 As String
						'''<summary>Premium Payer Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Premium Payer's City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Premium Payer City Name</summary>
						Property N401 As String
						'''<summary>Premium Payer State Code</summary>
						Property N402 As String
						'''<summary>Premium Payer Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Premium Payer's Administrative Contact</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Premium Payer Contact Name</summary>
						Property PER02 As String
						'''<summary>This is required when the sender needs to relay communication information.</summary>
						Property PER03 As String
						'''<summary>Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Communication Number</summary>
						Property PER08 As String
					End Interface
				End Namespace 'Loop1000B

				Namespace Loop1000C

					'''<summary>Intermediary Bank Information</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Intermediary Bank Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Intermediary Bank Identifier</summary>
						Property N104 As String
					End Interface
					'''<summary>Intermediary Bank Additional Name</summary>
					Public Interface N2
						Inherits ISegment

						'''<summary>Intermediary Bank Additional Name</summary>
						Property N201 As String
					End Interface
					'''<summary>Intermediary Bank's Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Intermediary Bank Address Line</summary>
						Property N301 As String
						'''<summary>Intermediary Bank Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Intermediary Bank's City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Intermediary Bank City Name</summary>
						Property N401 As String
						'''<summary>Intermediary Bank State Code</summary>
						Property N402 As String
						'''<summary>Intermediary Bank Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Intermediary Bank's Administrative Contact</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Intermediary Bank Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Communication Number</summary>
						Property PER08 As String
					End Interface
				End Namespace 'Loop1000C

				Namespace Loop2000A

					'''<summary>Organization Summary Remittance</summary>
					Public Interface ENT
						Inherits ISegment

						'''<summary>Assigned Number</summary>
						Property ENT01 As Decimal?
						'''<summary>Entity Identifier Code</summary>
						Property ENT02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property ENT03 As String
						'''<summary>Organization Identification Code</summary>
						Property ENT04 As String
					End Interface
				End Namespace 'Loop2000A

				Namespace Loop2200A

					'''<summary>Organization Summary Remittance Level Adjustment for Previous Payment</summary>
					Public Interface ADX
						Inherits ISegment

						'''<summary>Premium Payment Adjustment Amount</summary>
						Property ADX01 As Decimal?
						'''<summary>Premium Payment Adjustment Reason</summary>
						Property ADX02 As String
					End Interface
				End Namespace 'Loop2200A

				Namespace Loop2300A

					'''<summary>Organization Summary Remittance Detail</summary>
					Public Interface RMR
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property RMR01 As String
						'''<summary>Contract, Invoice, Account, Group, or Policy Number</summary>
						Property RMR02 As String
						'''<summary>Payment Action Code</summary>
						Property RMR03 As String
						'''<summary>The amount being paid on this remittance item.</summary>
						Property RMR04 As Decimal?
						'''<summary>Billed Premium Amount</summary>
						Property RMR05 As Decimal?
					End Interface
					'''<summary>Reference Information</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Organizational Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Organizational Reference Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Organizational Coverage Period</summary>
					Public Interface DTM
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>Date</summary>
						Property DTM02 As Date?
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTM05 As String
						'''<summary>Coverage Period</summary>
						Property DTM06 As String
					End Interface
				End Namespace 'Loop2300A

				Namespace Loop2310A

					'''<summary>Summary Line Item</summary>
					Public Interface IT1
						Inherits ISegment

						'''<summary>Line Item Control Number</summary>
						Property IT101 As String
					End Interface
				End Namespace 'Loop2310A

				Namespace Loop2312A

					'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
					Public Interface SAC
						Inherits ISegment

						'''<summary>Allowance or Charge Indicator</summary>
						Property SAC01 As String
						'''<summary>Service, Promotion, Allowance, or Charge Code</summary>
						Property SAC02 As String
						'''<summary>Amount</summary>
						Property SAC05 As Decimal?
					End Interface
				End Namespace 'Loop2312A

				Namespace Loop2315A

					'''<summary>Member Count</summary>
					Public Interface SLN
						Inherits ISegment

						'''<summary>Line Item Control Number</summary>
						Property SLN01 As String
						'''<summary>Information Only Indicator</summary>
						Property SLN03 As String
						'''<summary>This is the number of contract holders with the type of coverage identified in SLN05-1.</summary>
						Property SLN04 As Decimal?
						'''<summary></summary>
						Property SLN05 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001
					End Interface
				End Namespace 'Loop2315A

				Namespace Loop2320A

					'''<summary>Organization Summary Remittance Level Adjustment for Current Payment</summary>
					Public Interface ADX
						Inherits ISegment

						'''<summary>Adjustment Amount</summary>
						Property ADX01 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property ADX02 As String
					End Interface
				End Namespace 'Loop2320A

				Namespace Loop2000B

					'''<summary>Individual Remittance</summary>
					Public Interface ENT
						Inherits ISegment

						'''<summary>Assigned Number</summary>
						Property ENT01 As Decimal?
						'''<summary>Entity Identifier Code</summary>
						Property ENT02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property ENT03 As String
						'''<summary>This is the identification number of the individual used by the receiver.</summary>
						Property ENT04 As String
					End Interface
				End Namespace 'Loop2000B

				Namespace Loop2100B

					'''<summary>Individual Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Individual Last Name</summary>
						Property NM103 As String
						'''<summary>Individual First Name</summary>
						Property NM104 As String
						'''<summary>Individual Middle Name</summary>
						Property NM105 As String
						'''<summary>Individual Name Prefix</summary>
						Property NM106 As String
						'''<summary>Individual Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Individual Identifier</summary>
						Property NM109 As String
					End Interface
				End Namespace 'Loop2100B

				Namespace Loop2200B

					'''<summary>Individual Premium Adjustment for Previous Payment</summary>
					Public Interface ADX
						Inherits ISegment

						'''<summary>Premium Payment Adjustment Amount</summary>
						Property ADX01 As Decimal?
						'''<summary>Premium Payment Adjustment Reason</summary>
						Property ADX02 As String
					End Interface
				End Namespace 'Loop2200B

				Namespace Loop2300B

					'''<summary>Individual Premium Remittance Detail</summary>
					Public Interface RMR
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property RMR01 As String
						'''<summary>Insurance Remittance Reference Number</summary>
						Property RMR02 As String
						'''<summary>This is the amount being paid on this remittance item.</summary>
						Property RMR04 As Decimal?
						'''<summary>Billed Premium Amount</summary>
						Property RMR05 As Decimal?
					End Interface
					'''<summary>Reference Information</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Organizational Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Organizational Reference Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Individual Coverage Period</summary>
					Public Interface DTM
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTM01 As String
						'''<summary>Date</summary>
						Property DTM02 As Date?
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTM05 As String
						'''<summary>Coverage Period</summary>
						Property DTM06 As String
					End Interface
				End Namespace 'Loop2300B

				Namespace Loop2320B

					'''<summary>Individual Premium Adjustment for Current Payment</summary>
					Public Interface ADX
						Inherits ISegment

						'''<summary>Adjustment Amount</summary>
						Property ADX01 As Decimal?
						'''<summary>Adjustment Reason Code</summary>
						Property ADX02 As String
					End Interface
				End Namespace 'Loop2320B

				'''<summary>820 Header</summary>
				Public Interface ST
					Inherits ISegment

					'''<summary>Transaction Set Identifier Code</summary>
					Property ST01 As String
					'''<summary>Transaction Set Control Number</summary>
					Property ST02 As String
					'''<summary>The value in ST03 must be the same as the value in GS08.</summary>
					Property ST03 As String
				End Interface
				'''<summary>Financial Information</summary>
				Public Interface BPR
					Inherits ISegment

					'''<summary>Transaction Handling Code</summary>
					Property BPR01 As String
					'''<summary>The ACH system can not support dollar amounts greater than 11 characters (including the decimal point). This provides an ACH limit of $99,999,999.99. for the 820. Dollar limits vary by the clearing system used, e.g ACH vs. wire. Contact your ODFI for information.</summary>
					Property BPR02 As Decimal?
					'''<summary>This indicates a credit to the payee's account, and a debit to the Payer's account.</summary>
					Property BPR03 As String
					'''<summary>Payment Method Code</summary>
					Property BPR04 As String
					'''<summary>Payment Format Code</summary>
					Property BPR05 As String
					'''<summary>BPR06 THROUGH BPR09 relate to the Originating Depository Financial Institution and the premium payer's bank account.</summary>
					Property BPR06 As String
					'''<summary>This is the identifying number of the Originating Depository Financial Institution sending the transaction into the ACH network.</summary>
					Property BPR07 As String
					'''<summary>Account Number Qualifier</summary>
					Property BPR08 As String
					'''<summary>This is the premium payer's bank account at the Originating Depository Financial Institution.</summary>
					Property BPR09 As String
					'''<summary>Payer Identifier</summary>
					Property BPR10 As String
					'''<summary>Originating Company Supplemental Code</summary>
					Property BPR11 As String
					'''<summary>BPR12 THROUGH BPR15 relate to the Receiving Depository Financial Institution and the premium receiver's bank account. BPR12 - BPR15 are required if the 820 transaction set initiates a funds transfer.</summary>
					Property BPR12 As String
					'''<summary>This is the identifying number of the Receiving Depository Financial Institution receiving the transaction into the ACH network.</summary>
					Property BPR13 As String
					'''<summary>BPR14 identifies the type of account in BPR15.</summary>
					Property BPR14 As String
					'''<summary>This is the premium receiver's bank account at the Receiving Depository Financial Institution.</summary>
					Property BPR15 As String
					'''<summary>For check payment, this data element specifies the check issuance date.</summary>
					Property BPR16 As Date?
				End Interface
				'''<summary>Reassociation Trace Number</summary>
				Public Interface TRN
					Inherits ISegment

					'''<summary>Trace Type Code</summary>
					Property TRN01 As String
					'''<summary>This field is used to re-associate the payment with the remittance information.</summary>
					Property TRN02 As String
					'''<summary>Originating Company Identifier</summary>
					Property TRN03 As String
					'''<summary>If provided, TRN04 and BPR11 must be identical.</summary>
					Property TRN04 As String
				End Interface
				'''<summary>Foreign Currency Information</summary>
				Public Interface CUR
					Inherits ISegment

					'''<summary>Entity Identifier Code</summary>
					Property CUR01 As String
					'''<summary>&lt;T&gt;MXP&lt;T&gt;Mexican Pesos<br />&lt;T&gt;CAD&lt;T&gt;Canadian Dollars</summary>
					Property CUR02 As String
				End Interface
				'''<summary>Premium Receivers Identification Key</summary>
				Public Interface REF
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>For Treasury Department Financial Management Service Disbursed payments, this data field is schedule number (11 Characters) submitted by the agency authorizing the payment.</summary>
					Property REF02 As String
				End Interface
				'''<summary>Process Date</summary>
				Public Interface DTM
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTM01 As String
					'''<summary>Payer Process Date</summary>
					Property DTM02 As Date?
				End Interface
				'''<summary>Delivery Date</summary>
				Public Interface DTM_1
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTM01 As String
					'''<summary>Premium Delivery Date</summary>
					Property DTM02 As Date?
				End Interface
				'''<summary>Coverage Period</summary>
				Public Interface DTM_2
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTM01 As String
					'''<summary>Date Time Period Format Qualifier</summary>
					Property DTM05 As String
					'''<summary>Coverage Period</summary>
					Property DTM06 As String
				End Interface
				'''<summary>Creation Date</summary>
				Public Interface DTM_3
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTM01 As String
					'''<summary>Date</summary>
					Property DTM02 As Date?
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
				Namespace Loop2315A.SLN.SLN_05
					'''<summary></summary>
					Public Interface C001
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property C001_01 As String
					End Interface
				End Namespace
			End Namespace 'Composites

			Namespace Loops
				'''<summary>Premium Receiver's Name</summary>
				Public Interface Loop1000A
					Inherits ILoop


					'''<summary>Premium Receiver's Name</summary>
					Property N1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1

					'''<summary>Premium Receiver Additional Name</summary>
					Property N2 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2

					'''<summary>Premium Receiver's Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3

					'''<summary>Premium Receiver's City, State, and ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4

					'''<summary>Premium Receiver's Remittance Delivery Method</summary>
					Property RDM As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM
				End Interface
				'''<summary>Premium Payer's Name</summary>
				Public Interface Loop1000B
					Inherits ILoop


					'''<summary>Premium Payer's Name</summary>
					Property N1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1

					'''<summary>Premium Payer Additional Name</summary>
					Property N2 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2

					'''<summary>Premium Payer's Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3

					'''<summary>Premium Payer's City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4

					'''<summary>Premium Payer's Administrative Contact</summary>
					ReadOnly Property PER As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER, Edi.Dom.Segments.PER)
				End Interface
				'''<summary>Intermediary Bank Information</summary>
				Public Interface Loop1000C
					Inherits ILoop


					'''<summary>Intermediary Bank Information</summary>
					Property N1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1

					'''<summary>Intermediary Bank Additional Name</summary>
					Property N2 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2

					'''<summary>Intermediary Bank's Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3

					'''<summary>Intermediary Bank's City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4

					'''<summary>Intermediary Bank's Administrative Contact</summary>
					ReadOnly Property PER As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER, Edi.Dom.Segments.PER)
				End Interface
				'''<summary>Organization Summary Remittance</summary>
				Public Interface Loop2000A
					Inherits ILoop


					'''<summary>Organization Summary Remittance</summary>
					Property ENT As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT

					'''<summary>Organization Summary Remittance Level Adjustment for Previous Payment</summary>
					ReadOnly Property Loop2200A As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)

					'''<summary>Organization Summary Remittance Detail</summary>
					ReadOnly Property Loop2300A As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)
				End Interface
				'''<summary>Organization Summary Remittance Level Adjustment for Previous Payment</summary>
				Public Interface Loop2200A
					Inherits ILoop


					'''<summary>Organization Summary Remittance Level Adjustment for Previous Payment</summary>
					Property ADX As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX
				End Interface
				'''<summary>Organization Summary Remittance Detail</summary>
				Public Interface Loop2300A
					Inherits ILoop


					'''<summary>Organization Summary Remittance Detail</summary>
					Property RMR As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR

					'''<summary>Reference Information</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF, Edi.Dom.Segments.REF)

					'''<summary>Organizational Coverage Period</summary>
					Property DTM As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM

					'''<summary>Summary Line Item</summary>
					Property Loop2310A As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A

					'''<summary>Organization Summary Remittance Level Adjustment for Current Payment</summary>
					ReadOnly Property Loop2320A As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)
				End Interface
				'''<summary>Summary Line Item</summary>
				Public Interface Loop2310A
					Inherits ILoop


					'''<summary>Summary Line Item</summary>
					Property IT1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1

					'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
					ReadOnly Property Loop2312A As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A, Edi.Dom.Transactions.Transaction820.Loops.Loop2312)

					'''<summary>Member Count</summary>
					ReadOnly Property Loop2315A As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A, Edi.Dom.Transactions.Transaction820.Loops.Loop2315)
				End Interface
				'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
				Public Interface Loop2312A
					Inherits ILoop


					'''<summary>Service, Promotion, Allowance, or Charge Information</summary>
					Property SAC As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC
				End Interface
				'''<summary>Member Count</summary>
				Public Interface Loop2315A
					Inherits ILoop


					'''<summary>Member Count</summary>
					Property SLN As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN
				End Interface
				'''<summary>Organization Summary Remittance Level Adjustment for Current Payment</summary>
				Public Interface Loop2320A
					Inherits ILoop


					'''<summary>Organization Summary Remittance Level Adjustment for Current Payment</summary>
					Property ADX As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX
				End Interface
				'''<summary>Individual Remittance</summary>
				Public Interface Loop2000B
					Inherits ILoop


					'''<summary>Individual Remittance</summary>
					Property ENT As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT

					'''<summary>Individual Name</summary>
					ReadOnly Property Loop2100B As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction820.Loops.Loop2100)

					'''<summary>Individual Premium Adjustment for Previous Payment</summary>
					ReadOnly Property Loop2200B As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B, Edi.Dom.Transactions.Transaction820.Loops.Loop2200)

					'''<summary>Individual Premium Remittance Detail</summary>
					ReadOnly Property Loop2300B As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B, Edi.Dom.Transactions.Transaction820.Loops.Loop2300)
				End Interface
				'''<summary>Individual Name</summary>
				Public Interface Loop2100B
					Inherits ILoop


					'''<summary>Individual Name</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1
				End Interface
				'''<summary>Individual Premium Adjustment for Previous Payment</summary>
				Public Interface Loop2200B
					Inherits ILoop


					'''<summary>Individual Premium Adjustment for Previous Payment</summary>
					Property ADX As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX
				End Interface
				'''<summary>Individual Premium Remittance Detail</summary>
				Public Interface Loop2300B
					Inherits ILoop


					'''<summary>Individual Premium Remittance Detail</summary>
					Property RMR As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR

					'''<summary>Reference Information</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF, Edi.Dom.Segments.REF)

					'''<summary>Individual Coverage Period</summary>
					Property DTM As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM

					'''<summary>Individual Premium Adjustment for Current Payment</summary>
					ReadOnly Property Loop2320B As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B, Edi.Dom.Transactions.Transaction820.Loops.Loop2320)
				End Interface
				'''<summary>Individual Premium Adjustment for Current Payment</summary>
				Public Interface Loop2320B
					Inherits ILoop


					'''<summary>Individual Premium Adjustment for Current Payment</summary>
					Property ADX As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX
				End Interface

			End Namespace 'Loops

			'''<summary>Payment Order/Remittance Advice</summary>
			'''<remarks>
			'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Payment Order/Remittance Advice Transaction Set (820) for use within the context of an Electronic Data Interchange (EDI) environment. The transaction set can be used to make a payment, send a remittance advice, or make a payment and send a remittance advice.<br /><br />This transaction set can be an order to a financial institution to make a payment to a payee. It can also be a remittance advice identifying the detail needed to perform cash application to the payee's accounts receivable system. The remittance advice can go directly from payer to payee, through a financial institution, or through a third party agent.</para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary>820 Header</summary>
				Property ST As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST

				'''<summary>Financial Information</summary>
				Property BPR As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR

				'''<summary>Reassociation Trace Number</summary>
				Property TRN As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN

				'''<summary>Foreign Currency Information</summary>
				Property CUR As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR

				'''<summary>Premium Receivers Identification Key</summary>
				ReadOnly Property REF As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF, Edi.Dom.Segments.REF)

				'''<summary>Process Date</summary>
				Property DTM As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM

				'''<summary>Delivery Date</summary>
				Property DTM_1 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1

				'''<summary>Coverage Period</summary>
				Property DTM_2 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2

				'''<summary>Creation Date</summary>
				Property DTM_3 As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3

				'''<summary>Premium Receiver's Name</summary>
				Property Loop1000A As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A

				'''<summary>Premium Payer's Name</summary>
				Property Loop1000B As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B

				'''<summary>Intermediary Bank Information</summary>
				ReadOnly Property Loop1000C As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction820.Loops.Loop1000)

				'''<summary>Organization Summary Remittance</summary>
				Property Loop2000A As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A

				'''<summary>Individual Remittance</summary>
				ReadOnly Property Loop2000B As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B, Edi.Dom.Transactions.Transaction820.Loops.Loop2000)

				'''<summary>Transaction Set Trailer</summary>
				Property SE As Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE
			End Interface
		End Namespace 'Transaction820_A1
	End Namespace 'Transaction820
End Namespace 'Transaction820
