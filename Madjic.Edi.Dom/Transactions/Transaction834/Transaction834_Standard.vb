Namespace Transactions
	Namespace Transaction834

		Partial Friend Class Standard_Obj
			Inherits TransactionSet
			Implements Standard, Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet
			Friend Sub New(versionCode As String)
				Me.New(String.Empty, versionCode)
			End Sub

			Friend Sub New(controlNumber As String, versionCode As String)
				MyBase.New("BE", versionCode)

				Children.AddRange({New Edi.Dom.Segments.ST_Obj,
									CType(Nothing, Edi.Dom.Segments.BGN_Obj),
									New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "1", "0300"),
									New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "1", "0400"),
									New SegmentContainer(Of Edi.Dom.Segments.AMT)(0, "1", "0500"),
									New SegmentContainer(Of Edi.Dom.Segments.QTY)(0, "1", "0600"),
									New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(0, "1", "0700"),
									New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2000)(0, "2", "0100"),
									New Edi.Dom.Segments.SE_Obj})

				ST_Obj.ST01 = "834"
				ST_Obj.ST02 = controlNumber
				ST_Obj.ST03 = versionCode

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
					New ReaderState(1, "BGN", ReadAction.PopulateSegment, 2, False),
					New ReaderState(2, "REF", ReadAction.PopulateSegment, 3, False),
					New ReaderState(3, "REF", ReadAction.PopulateSegment, 3, False),
					New ReaderState(2, "DTP", ReadAction.PopulateSegment, 5, False),
					New ReaderState(3, "DTP", ReadAction.PopulateSegment, 5, False),
					New ReaderState(5, "DTP", ReadAction.PopulateSegment, 5, False),
					New ReaderState(2, "AMT", ReadAction.PopulateSegment, 7, False),
					New ReaderState(3, "AMT", ReadAction.PopulateSegment, 7, False),
					New ReaderState(5, "AMT", ReadAction.PopulateSegment, 7, False),
					New ReaderState(7, "AMT", ReadAction.PopulateSegment, 7, False),
					New ReaderState(2, "QTY", ReadAction.PopulateSegment, 9, False),
					New ReaderState(3, "QTY", ReadAction.PopulateSegment, 9, False),
					New ReaderState(5, "QTY", ReadAction.PopulateSegment, 9, False),
					New ReaderState(7, "QTY", ReadAction.PopulateSegment, 9, False),
					New ReaderState(9, "QTY", ReadAction.PopulateSegment, 9, False),
					New ReaderState(2, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(3, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(5, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(7, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(9, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(11, "N1", ReadAction.PopulateLoop, 11, False),
					New ReaderState(11, "INS", ReadAction.PopulateLoop, 13, False),
					New ReaderState(13, "INS", ReadAction.PopulateLoop, 13, False),
					New ReaderState(11, "SE", ReadAction.PopulateSegment, 15, False),
					New ReaderState(13, "SE", ReadAction.PopulateSegment, 15, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ST_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.ST_Obj)
					If MyBase.CompareKey(S2.ST01, ";834;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0100"
					End If
				ElseIf String.Compare(SegmentName, "BGN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.BGN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BGN_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";38;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0300"
					End If
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";007;090;091;303;382;388;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0400"
					End If
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.QTY_Obj)
					If MyBase.CompareKey(S2.QTY01, ";DT;ET;TO;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0600"
					End If
				ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop1000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop1000_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";P5;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__1000A"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "0700"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";IN;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__1000B"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "1900"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";BO;TV;") AndAlso String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__1000C"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "3100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "INS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2000_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "0100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
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

			Private Property ST_Std As Edi.Dom.Segments.ST Implements Edi.Dom.Transactions.Transaction834.Standard.ST
				Get
					Return CType(Children(0), Edi.Dom.Segments.ST_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ST)
					Children(0) = value
				End Set
			End Property

			Private Property ST_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.ST
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Friend Property BGN_Obj As Edi.Dom.Segments.BGN_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.BGN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BGN_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property BGN_Std As Edi.Dom.Segments.BGN Implements Edi.Dom.Transactions.Transaction834.Standard.BGN
				Get
					Return CType(Children(1), Edi.Dom.Segments.BGN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BGN)
					Children(1) = value
				End Set
			End Property

			Private Property BGN_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.BGN
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Standard.REF
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Transaction834_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF, Edi.Dom.Segments.REF)
			Private Property REF_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.REF
				Get
					If REFSubset_Transaction834_A1 Is Nothing Then
						REFSubset_Transaction834_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF, Edi.Dom.Segments.REF)(Children(2), 1, "1", "0300")
					End If

					If REFSubset_Transaction834_A1.Count > 0 Then
						Return REFSubset_Transaction834_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF)
					If REFSubset_Transaction834_A1 Is Nothing Then
						REFSubset_Transaction834_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF, Edi.Dom.Segments.REF)(Children(2), 1, "1", "0300")
					End If

					If REFSubset_Transaction834_A1.Count = 0 Then
						REFSubset_Transaction834_A1.Add(value)
					Else
						REFSubset_Transaction834_A1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Standard.DTP
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Transaction834_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP, Edi.Dom.Segments.DTP)
			Private ReadOnly Property DTP_Transaction834_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP, Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.DTP
				Get
					If DTPSubset_Transaction834_A1 Is Nothing Then
						DTPSubset_Transaction834_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP, Edi.Dom.Segments.DTP)(Children(3), 0, "1", "0400")
					End If

					Return DTPSubset_Transaction834_A1
				End Get
			End Property
			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Standard.AMT
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction834.Standard.QTY
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.QTY))
				End Get
			End Property

			Private QTYSubset_Transaction834_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY, Edi.Dom.Segments.QTY)
			Private ReadOnly Property QTY_Transaction834_A1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY, Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.QTY
				Get
					If QTYSubset_Transaction834_A1 Is Nothing Then
						QTYSubset_Transaction834_A1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY, Edi.Dom.Segments.QTY)(Children(5), 3, "1", "0600")
					End If

					Return QTYSubset_Transaction834_A1
				End Get
			End Property
			Friend ReadOnly Property Loop1000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction834.Standard.Loop1000
				Get
					Return CType(Children(6), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1000))
				End Get
			End Property

			Private Loop1000ASubset_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)
			Private Property Loop1000A_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.Loop1000A
				Get
					If Loop1000ASubset_Transaction834_A1 Is Nothing Then
						Loop1000ASubset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(Children(6), 1, "1", "0700")
					End If

					If Loop1000ASubset_Transaction834_A1.Count > 0 Then
						Return Loop1000ASubset_Transaction834_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A)
					If Loop1000ASubset_Transaction834_A1 Is Nothing Then
						Loop1000ASubset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(Children(6), 1, "1", "0700")
					End If

					If Loop1000ASubset_Transaction834_A1.Count = 0 Then
						Loop1000ASubset_Transaction834_A1.Add(value)
					Else
						Loop1000ASubset_Transaction834_A1(0) = value
					End If
				End Set
			End Property
			Private Loop1000BSubset_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)
			Private Property Loop1000B_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.Loop1000B
				Get
					If Loop1000BSubset_Transaction834_A1 Is Nothing Then
						Loop1000BSubset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(Children(6), 1, "1", "1900")
					End If

					If Loop1000BSubset_Transaction834_A1.Count > 0 Then
						Return Loop1000BSubset_Transaction834_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B)
					If Loop1000BSubset_Transaction834_A1 Is Nothing Then
						Loop1000BSubset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(Children(6), 1, "1", "1900")
					End If

					If Loop1000BSubset_Transaction834_A1.Count = 0 Then
						Loop1000BSubset_Transaction834_A1.Add(value)
					Else
						Loop1000BSubset_Transaction834_A1(0) = value
					End If
				End Set
			End Property
			Private Loop1000CSubset_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)
			Private ReadOnly Property Loop1000C_Obj_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction834.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.Loop1000C
				Get
					If Loop1000CSubset_Transaction834_A1 Is Nothing Then
						Loop1000CSubset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)(Children(6), 2, "1", "3100")
					End If

					Return Loop1000CSubset_Transaction834_A1
				End Get
			End Property
			Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction834.Standard.Loop2000
				Get
					Return CType(Children(7), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2000))
				End Get
			End Property

			Private Loop2000Subset_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000, Edi.Dom.Transactions.Transaction834.Loops.Loop2000)
			Private ReadOnly Property Loop2000_Obj_1_Transaction834_A1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000, Edi.Dom.Transactions.Transaction834.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.Loop2000
				Get
					If Loop2000Subset_Transaction834_A1 Is Nothing Then
						Loop2000Subset_Transaction834_A1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000, Edi.Dom.Transactions.Transaction834.Loops.Loop2000)(Children(7), 0, "2", "0100")
					End If

					Return Loop2000Subset_Transaction834_A1
				End Get
			End Property
			Friend Property SE_Obj As Edi.Dom.Segments.SE_Obj
				Get
					Return CType(Children(8), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE_Obj)
					Children(8) = value
				End Set
			End Property

			Private Property SE_Std As Edi.Dom.Segments.SE Implements Edi.Dom.Transactions.Transaction834.Standard.SE
				Get
					Return CType(Children(8), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE)
					Children(8) = value
				End Set
			End Property

			Private Property SE_IFace_Transaction834_A1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet.SE
				Get
					Return CType(Children(8), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE)
					Children(8) = value
				End Set
			End Property
		End Class

		Partial Friend Class Loop1000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.N1_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.N2)(2, "1", "0800"),
										New SegmentContainer(Of Edi.Dom.Segments.N3)(2, "1", "0900"),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.PER)(3, "1", "1100"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1100)(10, "1", "1200")})

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
						New ReaderState(1, "PER", ReadAction.PopulateSegment, 7, False),
						New ReaderState(2, "PER", ReadAction.PopulateSegment, 7, False),
						New ReaderState(4, "PER", ReadAction.PopulateSegment, 7, False),
						New ReaderState(6, "PER", ReadAction.PopulateSegment, 7, False),
						New ReaderState(7, "PER", ReadAction.PopulateSegment, 7, False),
						New ReaderState(1, "ACT", ReadAction.PopulateLoop, 9, False),
						New ReaderState(2, "ACT", ReadAction.PopulateLoop, 9, False),
						New ReaderState(4, "ACT", ReadAction.PopulateLoop, 9, False),
						New ReaderState(6, "ACT", ReadAction.PopulateLoop, 9, False),
						New ReaderState(7, "ACT", ReadAction.PopulateLoop, 9, False),
						New ReaderState(9, "ACT", ReadAction.PopulateLoop, 9, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.N1_Obj)
					If MyBase.CompareKey(S2.N101, ";P5;") AndAlso String.Compare(args.Implementation, "_834A1__1000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0700"
					ElseIf MyBase.CompareKey(S2.N101, ";IN;") AndAlso String.Compare(args.Implementation, "_834A1__1000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "1900"
					ElseIf MyBase.CompareKey(S2.N101, ";BO;TV;") AndAlso String.Compare(args.Implementation, "_834A1__1000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "3100"
					End If
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "ACT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop1100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop1100_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__1000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__1000C__1100C"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "3600"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
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

			Private Property N1_Std As Edi.Dom.Segments.N1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.N1
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1)
					Children(0) = value
				End Set
			End Property

			Private Property N1_IFace_Loop1000A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1)
					Children(0) = value
				End Set
			End Property
			Private Property N1_IFace_1_Loop1000B_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1)
					Children(0) = value
				End Set
			End Property
			Private Property N1_IFace_2_Loop1000C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property N2_Obj As SegmentContainer(Of Edi.Dom.Segments.N2) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.N2
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.N2))
				End Get
			End Property

			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.N3
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

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.PER
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Friend ReadOnly Property Loop1100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1100) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1000.Loop1100
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1100))
				End Get
			End Property

			Private Loop1100CSubset_Loop1000C_Obj As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C, Edi.Dom.Transactions.Transaction834.Loops.Loop1100)
			Private Property Loop1100C_IFace_Loop1000C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C.Loop1100C
				Get
					If Loop1100CSubset_Loop1000C_Obj Is Nothing Then
						Loop1100CSubset_Loop1000C_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C, Edi.Dom.Transactions.Transaction834.Loops.Loop1100)(Children(5), 1, "1", "3600")
					End If

					If Loop1100CSubset_Loop1000C_Obj.Count > 0 Then
						Return Loop1100CSubset_Loop1000C_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C)
					If Loop1100CSubset_Loop1000C_Obj Is Nothing Then
						Loop1100CSubset_Loop1000C_Obj = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C, Edi.Dom.Transactions.Transaction834.Loops.Loop1100)(Children(5), 1, "1", "3600")
					End If

					If Loop1100CSubset_Loop1000C_Obj.Count = 0 Then
						Loop1100CSubset_Loop1000C_Obj.Add(value)
					Else
						Loop1100CSubset_Loop1000C_Obj(0) = value
					End If
				End Set
			End Property

		End Class
		Partial Friend Class Loop1100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.ACT_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(5, "1", "1300"),
										CType(Nothing, Edi.Dom.Segments.N3_Obj),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.PER)(5, "1", "1600"),
										CType(Nothing, Edi.Dom.Segments.DTP_Obj),
										CType(Nothing, Edi.Dom.Segments.AMT_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ACT", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "N3", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(4, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(5, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 8, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 8, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 8, False),
						New ReaderState(5, "DTP", ReadAction.PopulateSegment, 8, False),
						New ReaderState(6, "DTP", ReadAction.PopulateSegment, 8, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 9, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 9, False),
						New ReaderState(4, "AMT", ReadAction.PopulateSegment, 9, False),
						New ReaderState(5, "AMT", ReadAction.PopulateSegment, 9, False),
						New ReaderState(6, "AMT", ReadAction.PopulateSegment, 9, False),
						New ReaderState(8, "AMT", ReadAction.PopulateSegment, 9, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "ACT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ACT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ACT_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj = Seg
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj = Seg
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property ACT_Obj As Edi.Dom.Segments.ACT_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.ACT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ACT_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property ACT_Std As Edi.Dom.Segments.ACT Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.ACT
				Get
					Return CType(Children(0), Edi.Dom.Segments.ACT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ACT)
					Children(0) = value
				End Set
			End Property

			Private Property ACT_IFace_Loop1100C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C.ACT
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend Property N3_Obj As Edi.Dom.Segments.N3_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property N3_Std As Edi.Dom.Segments.N3 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.N3
				Get
					Return CType(Children(2), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3)
					Children(2) = value
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

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.PER
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Friend Property DTP_Obj As Edi.Dom.Segments.DTP_Obj
				Get
					Return CType(Children(5), Edi.Dom.Segments.DTP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTP_Obj)
					Children(5) = value
				End Set
			End Property

			Private Property DTP_Std As Edi.Dom.Segments.DTP Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.DTP
				Get
					Return CType(Children(5), Edi.Dom.Segments.DTP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTP)
					Children(5) = value
				End Set
			End Property

			Friend Property AMT_Obj As Edi.Dom.Segments.AMT_Obj
				Get
					Return CType(Children(6), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT_Obj)
					Children(6) = value
				End Set
			End Property

			Private Property AMT_Std As Edi.Dom.Segments.AMT Implements Edi.Dom.Transactions.Transaction834.Loops.Loop1100.AMT
				Get
					Return CType(Children(6), Edi.Dom.Segments.AMT_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AMT)
					Children(6) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.INS_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "0200"),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "0250"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(0, "2", "0300"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2200)(4, "2", "2000"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2300)(99, "2", "2600"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2400)(10, "2", "4600"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2500)(5, "2", "5500"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2600)(0, "2", "5800"),
										CType(Nothing, Edi.Dom.Segments.LS_Obj),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2700)(0, "2", "6881"),
										CType(Nothing, Edi.Dom.Segments.LE_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "INS", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "NM1", ReadAction.PopulateLoop, 6, False),
						New ReaderState(4, "NM1", ReadAction.PopulateLoop, 6, False),
						New ReaderState(6, "NM1", ReadAction.PopulateLoop, 6, False),
						New ReaderState(2, "DSB", ReadAction.PopulateLoop, 8, False),
						New ReaderState(4, "DSB", ReadAction.PopulateLoop, 8, False),
						New ReaderState(6, "DSB", ReadAction.PopulateLoop, 8, False),
						New ReaderState(8, "DSB", ReadAction.PopulateLoop, 8, False),
						New ReaderState(2, "HD", ReadAction.PopulateLoop, 10, False),
						New ReaderState(4, "HD", ReadAction.PopulateLoop, 10, False),
						New ReaderState(6, "HD", ReadAction.PopulateLoop, 10, False),
						New ReaderState(8, "HD", ReadAction.PopulateLoop, 10, False),
						New ReaderState(10, "HD", ReadAction.PopulateLoop, 10, False),
						New ReaderState(2, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(4, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(6, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(8, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(10, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(12, "LC", ReadAction.PopulateLoop, 12, False),
						New ReaderState(2, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(4, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(6, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(8, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(10, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(12, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(14, "FSA", ReadAction.PopulateLoop, 14, False),
						New ReaderState(2, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(4, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(6, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(8, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(10, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(12, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(14, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(16, "RP", ReadAction.PopulateLoop, 16, False),
						New ReaderState(2, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(4, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(6, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(8, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(10, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(12, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(14, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(16, "LS", ReadAction.PopulateSegmentAndStartBoundedLoop, 18, False),
						New ReaderState(18, "LX", ReadAction.PopulateLoop, 19, False),
						New ReaderState(19, "LX", ReadAction.PopulateLoop, 19, False),
						New ReaderState(2, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(4, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(6, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(8, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(10, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(12, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(14, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(16, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(18, "LE", ReadAction.PopulateSegment, 21, False),
						New ReaderState(19, "LE", ReadAction.PopulateSegment, 21, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "INS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.INS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					INS_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";0F;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0200"
					ElseIf MyBase.CompareKey(S2.REF01, ";1L;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0220"
					ElseIf MyBase.CompareKey(S2.REF01, ";17;23;3H;4A;6O;ABB;D3;DX;F6;P5;Q4;QQ;ZZ;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0240"
					End If
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";050;286;296;297;300;301;303;336;337;338;339;340;341;350;351;356;357;383;385;386;393;394;473;474;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0290"
					End If
				ElseIf String.Compare(SegmentName, "LS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LS_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.LS_Obj)
					If MyBase.CompareKey(S2.LS01, ";") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "6800"
					End If
				ElseIf String.Compare(SegmentName, "LE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2100_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2100_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";74;IL;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100A"
						NewLoop.SetArea = "2"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";70;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100B"
						NewLoop.SetArea = "3"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";31;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100C"
						NewLoop.SetArea = "4"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";36;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100D"
						NewLoop.SetArea = "5"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";M8;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100E"
						NewLoop.SetArea = "6"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";S3;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100F"
						NewLoop.SetArea = "7"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";6Y;9K;E1;EI;EXS;GB;GD;J6;LR;QD;S1;TZ;X4;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100G"
						NewLoop.SetArea = "8"
						NewLoop.SetSequence = "0300"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";45;") AndAlso String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2100H"
						NewLoop.SetArea = "8"
						NewLoop.SetSequence = "0700"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "DSB", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2200_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2200_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2200"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "2000"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "HD", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2300_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2300_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2300"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "2600"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "LC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2400_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2400_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "FSA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2500_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2500_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "RP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2600_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2600_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2700_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2700_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2700"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "6801"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property INS_Obj As Edi.Dom.Segments.INS_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.INS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.INS_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property INS_Std As Edi.Dom.Segments.INS Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.INS
				Get
					Return CType(Children(0), Edi.Dom.Segments.INS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.INS)
					Children(0) = value
				End Set
			End Property

			Private Property INS_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.INS
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF, Edi.Dom.Segments.REF)
			Private Property REF_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.REF
				Get
					If REFSubset_Loop2000_Obj_1 Is Nothing Then
						REFSubset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF, Edi.Dom.Segments.REF)(Children(1), 1, "2", "0200")
					End If

					If REFSubset_Loop2000_Obj_1.Count > 0 Then
						Return REFSubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF)
					If REFSubset_Loop2000_Obj_1 Is Nothing Then
						REFSubset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF, Edi.Dom.Segments.REF)(Children(1), 1, "2", "0200")
					End If

					If REFSubset_Loop2000_Obj_1.Count = 0 Then
						REFSubset_Loop2000_Obj_1.Add(value)
					Else
						REFSubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1, Edi.Dom.Segments.REF)
			Private Property REF_IFace_1_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.REF_1
				Get
					If REF_1Subset_Loop2000_Obj_1 Is Nothing Then
						REF_1Subset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1, Edi.Dom.Segments.REF)(Children(1), 1, "2", "0220")
					End If

					If REF_1Subset_Loop2000_Obj_1.Count > 0 Then
						Return REF_1Subset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1)
					If REF_1Subset_Loop2000_Obj_1 Is Nothing Then
						REF_1Subset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1, Edi.Dom.Segments.REF)(Children(1), 1, "2", "0220")
					End If

					If REF_1Subset_Loop2000_Obj_1.Count = 0 Then
						REF_1Subset_Loop2000_Obj_1.Add(value)
					Else
						REF_1Subset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REF_2Subset_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_2_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.REF_2
				Get
					If REF_2Subset_Loop2000_Obj_1 Is Nothing Then
						REF_2Subset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2, Edi.Dom.Segments.REF)(Children(1), 13, "2", "0240")
					End If

					Return REF_2Subset_Loop2000_Obj_1
				End Get
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP, Edi.Dom.Segments.DTP)
			Private ReadOnly Property DTP_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP, Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.DTP
				Get
					If DTPSubset_Loop2000_Obj_1 Is Nothing Then
						DTPSubset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP, Edi.Dom.Segments.DTP)(Children(2), 24, "2", "0290")
					End If

					Return DTPSubset_Loop2000_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2100
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2100))
				End Get
			End Property

			Private Loop2100ASubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private Property Loop2100A_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100A
				Get
					If Loop2100ASubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100ASubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "2", "0300")
					End If

					If Loop2100ASubset_Loop2000_Obj_1.Count > 0 Then
						Return Loop2100ASubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A)
					If Loop2100ASubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100ASubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "2", "0300")
					End If

					If Loop2100ASubset_Loop2000_Obj_1.Count = 0 Then
						Loop2100ASubset_Loop2000_Obj_1.Add(value)
					Else
						Loop2100ASubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2100BSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private Property Loop2100B_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100B
				Get
					If Loop2100BSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100BSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "3", "0300")
					End If

					If Loop2100BSubset_Loop2000_Obj_1.Count > 0 Then
						Return Loop2100BSubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B)
					If Loop2100BSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100BSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "3", "0300")
					End If

					If Loop2100BSubset_Loop2000_Obj_1.Count = 0 Then
						Loop2100BSubset_Loop2000_Obj_1.Add(value)
					Else
						Loop2100BSubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2100CSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private Property Loop2100C_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100C
				Get
					If Loop2100CSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100CSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "4", "0300")
					End If

					If Loop2100CSubset_Loop2000_Obj_1.Count > 0 Then
						Return Loop2100CSubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C)
					If Loop2100CSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100CSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "4", "0300")
					End If

					If Loop2100CSubset_Loop2000_Obj_1.Count = 0 Then
						Loop2100CSubset_Loop2000_Obj_1.Add(value)
					Else
						Loop2100CSubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2100DSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private ReadOnly Property Loop2100D_Obj_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D, Edi.Dom.Transactions.Transaction834.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100D
				Get
					If Loop2100DSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100DSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 3, "5", "0300")
					End If

					Return Loop2100DSubset_Loop2000_Obj_1
				End Get
			End Property
			Private Loop2100ESubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private ReadOnly Property Loop2100E_Obj_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E, Edi.Dom.Transactions.Transaction834.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100E
				Get
					If Loop2100ESubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100ESubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 3, "6", "0300")
					End If

					Return Loop2100ESubset_Loop2000_Obj_1
				End Get
			End Property
			Private Loop2100FSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private Property Loop2100F_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100F
				Get
					If Loop2100FSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100FSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "7", "0300")
					End If

					If Loop2100FSubset_Loop2000_Obj_1.Count > 0 Then
						Return Loop2100FSubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F)
					If Loop2100FSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100FSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "7", "0300")
					End If

					If Loop2100FSubset_Loop2000_Obj_1.Count = 0 Then
						Loop2100FSubset_Loop2000_Obj_1.Add(value)
					Else
						Loop2100FSubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2100GSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private ReadOnly Property Loop2100G_Obj_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G, Edi.Dom.Transactions.Transaction834.Loops.Loop2100) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100G
				Get
					If Loop2100GSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100GSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 13, "8", "0300")
					End If

					Return Loop2100GSubset_Loop2000_Obj_1
				End Get
			End Property
			Private Loop2100HSubset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
			Private Property Loop2100H_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2100H
				Get
					If Loop2100HSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100HSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "8", "0700")
					End If

					If Loop2100HSubset_Loop2000_Obj_1.Count > 0 Then
						Return Loop2100HSubset_Loop2000_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H)
					If Loop2100HSubset_Loop2000_Obj_1 Is Nothing Then
						Loop2100HSubset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)(Children(3), 1, "8", "0700")
					End If

					If Loop2100HSubset_Loop2000_Obj_1.Count = 0 Then
						Loop2100HSubset_Loop2000_Obj_1.Add(value)
					Else
						Loop2100HSubset_Loop2000_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property Loop2200_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2200) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2200
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2200))
				End Get
			End Property

			Private Loop2200Subset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200, Edi.Dom.Transactions.Transaction834.Loops.Loop2200)
			Private ReadOnly Property Loop2200_Obj_1_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200, Edi.Dom.Transactions.Transaction834.Loops.Loop2200) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2200
				Get
					If Loop2200Subset_Loop2000_Obj_1 Is Nothing Then
						Loop2200Subset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200, Edi.Dom.Transactions.Transaction834.Loops.Loop2200)(Children(4), 0, "9", "2000")
					End If

					Return Loop2200Subset_Loop2000_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2300_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2300) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2300
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2300))
				End Get
			End Property

			Private Loop2300Subset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300, Edi.Dom.Transactions.Transaction834.Loops.Loop2300)
			Private ReadOnly Property Loop2300_Obj_1_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300, Edi.Dom.Transactions.Transaction834.Loops.Loop2300) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2300
				Get
					If Loop2300Subset_Loop2000_Obj_1 Is Nothing Then
						Loop2300Subset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300, Edi.Dom.Transactions.Transaction834.Loops.Loop2300)(Children(5), 99, "9", "2600")
					End If

					Return Loop2300Subset_Loop2000_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2400_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2400) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2400
				Get
					Return CType(Children(6), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2400))
				End Get
			End Property

			Friend ReadOnly Property Loop2500_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2500) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2500
				Get
					Return CType(Children(7), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2500))
				End Get
			End Property

			Friend ReadOnly Property Loop2600_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2600) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2600
				Get
					Return CType(Children(8), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2600))
				End Get
			End Property

			Friend Property LS_Obj As Edi.Dom.Segments.LS_Obj
				Get
					Return CType(Children(9), Edi.Dom.Segments.LS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LS_Obj)
					Children(9) = value
				End Set
			End Property

			Private Property LS_Std As Edi.Dom.Segments.LS Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.LS
				Get
					Return CType(Children(9), Edi.Dom.Segments.LS_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LS)
					Children(9) = value
				End Set
			End Property

			Private Property LS_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.LS
				Get
					Return CType(Children(9), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS)
					Children(9) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2700_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2700) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.Loop2700
				Get
					Return CType(Children(10), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2700))
				End Get
			End Property

			Private Loop2700Subset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700, Edi.Dom.Transactions.Transaction834.Loops.Loop2700)
			Private ReadOnly Property Loop2700_Obj_1_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700, Edi.Dom.Transactions.Transaction834.Loops.Loop2700) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.Loop2700
				Get
					If Loop2700Subset_Loop2000_Obj_1 Is Nothing Then
						Loop2700Subset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700, Edi.Dom.Transactions.Transaction834.Loops.Loop2700)(Children(10), 0, "9", "6801")
					End If

					Return Loop2700Subset_Loop2000_Obj_1
				End Get
			End Property
			Friend Property LE_Obj As Edi.Dom.Segments.LE_Obj
				Get
					Return CType(Children(11), Edi.Dom.Segments.LE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LE_Obj)
					Children(11) = value
				End Set
			End Property

			Private Property LE_Std As Edi.Dom.Segments.LE Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2000.LE
				Get
					Return CType(Children(11), Edi.Dom.Segments.LE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LE)
					Children(11) = value
				End Set
			End Property

			Private Property LE_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000.LE
				Get
					Return CType(Children(11), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE)
					Children(11) = value
				End Set
			End Property

		End Class
		Partial Friend Class Loop2100_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
										CType(Nothing, Edi.Dom.Segments.PER_Obj),
										CType(Nothing, Edi.Dom.Segments.N3_Obj),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										CType(Nothing, Edi.Dom.Segments.DMG_Obj),
										CType(Nothing, Edi.Dom.Segments.PM_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.EC)(0, "2", "1000"),
										CType(Nothing, Edi.Dom.Segments.ICM_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(10, "2", "1200"),
										CType(Nothing, Edi.Dom.Segments.HLH_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.HI)(10, "2", "1400"),
										New SegmentContainer(Of Edi.Dom.Segments.LUI)(0, "2", "1500")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "PER", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "N3", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 4, False),
						New ReaderState(3, "N4", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "DMG", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "DMG", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "DMG", ReadAction.PopulateSegment, 5, False),
						New ReaderState(4, "DMG", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "PM", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "PM", ReadAction.PopulateSegment, 6, False),
						New ReaderState(3, "PM", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "PM", ReadAction.PopulateSegment, 6, False),
						New ReaderState(5, "PM", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(2, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(3, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(4, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(5, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(6, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(7, "EC", ReadAction.PopulateSegment, 7, False),
						New ReaderState(1, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(2, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(3, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(4, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(5, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(6, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(7, "ICM", ReadAction.PopulateSegment, 9, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(3, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(4, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(5, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(6, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(7, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(9, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(10, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(1, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(2, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(3, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(4, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(5, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(6, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(7, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(9, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(10, "HLH", ReadAction.PopulateSegment, 12, False),
						New ReaderState(1, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(2, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(3, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(4, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(5, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(6, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(7, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(9, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(10, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(12, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(13, "HI", ReadAction.PopulateSegment, 13, False),
						New ReaderState(1, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(2, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(3, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(4, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(5, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(6, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(7, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(9, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(10, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(12, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(13, "LUI", ReadAction.PopulateSegment, 15, False),
						New ReaderState(15, "LUI", ReadAction.PopulateSegment, 15, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";74;IL;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";70;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "3"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";31;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "4"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";36;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "5"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";M8;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "6"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";S3;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "7"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";6Y;9K;E1;EI;EXS;GB;GD;J6;LR;QD;S1;TZ;X4;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100G", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "8"
						Seg.SetSequence = "0300"
					ElseIf MyBase.CompareKey(S2.NM101, ";45;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100H", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "8"
						Seg.SetSequence = "0700"
					End If
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj = Seg
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj = Seg
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DMG_Obj = Seg
				ElseIf String.Compare(SegmentName, "PM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PM_Obj = Seg
				ElseIf String.Compare(SegmentName, "EC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.EC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					EC_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "ICM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ICM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ICM_Obj = Seg
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.AMT_Obj)
					If MyBase.CompareKey(S2.AMT01, ";B9;C1;D2;EBA;FK;P3;R;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "2"
						Seg.SetSequence = "1200"
					End If
				ElseIf String.Compare(SegmentName, "HLH", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.HLH_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HLH_Obj = Seg
				ElseIf String.Compare(SegmentName, "HI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.HI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HI_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "LUI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LUI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LUI_Obj.Add(Seg)
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

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_1_Loop2100B_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_2_Loop2100C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_3_Loop2100D_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_4_Loop2100E_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_5_Loop2100F_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_6_Loop2100G_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_7_Loop2100H_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1)
					Children(0) = value
				End Set
			End Property
			Friend Property PER_Obj As Edi.Dom.Segments.PER_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.PER_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PER_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property PER_Std As Edi.Dom.Segments.PER Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.PER
				Get
					Return CType(Children(1), Edi.Dom.Segments.PER_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PER)
					Children(1) = value
				End Set
			End Property

			Private Property PER_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.PER
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER)
					Children(1) = value
				End Set
			End Property
			Private Property PER_IFace_1_Loop2100D_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D.PER
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER)
					Children(1) = value
				End Set
			End Property
			Private Property PER_IFace_2_Loop2100E_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E.PER
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER)
					Children(1) = value
				End Set
			End Property
			Private Property PER_IFace_3_Loop2100F_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F.PER
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER)
					Children(1) = value
				End Set
			End Property
			Private Property PER_IFace_4_Loop2100G_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G.PER
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER)
					Children(1) = value
				End Set
			End Property
			Friend Property N3_Obj As Edi.Dom.Segments.N3_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property N3_Std As Edi.Dom.Segments.N3 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.N3
				Get
					Return CType(Children(2), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3)
					Children(2) = value
				End Set
			End Property

			Private Property N3_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_1_Loop2100C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_2_Loop2100D_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_3_Loop2100E_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_4_Loop2100F_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_5_Loop2100G_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3)
					Children(2) = value
				End Set
			End Property
			Private Property N3_IFace_6_Loop2100H_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H.N3
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3)
					Children(2) = value
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

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Private Property N4_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_1_Loop2100C_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_2_Loop2100D_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_3_Loop2100E_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_4_Loop2100F_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_5_Loop2100G_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4)
					Children(3) = value
				End Set
			End Property
			Private Property N4_IFace_6_Loop2100H_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4)
					Children(3) = value
				End Set
			End Property
			Friend Property DMG_Obj As Edi.Dom.Segments.DMG_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property DMG_Std As Edi.Dom.Segments.DMG Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.DMG
				Get
					Return CType(Children(4), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG)
					Children(4) = value
				End Set
			End Property

			Private Property DMG_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.DMG
				Get
					Return CType(Children(4), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG)
					Children(4) = value
				End Set
			End Property
			Private Property DMG_IFace_1_Loop2100B_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B.DMG
				Get
					Return CType(Children(4), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG)
					Children(4) = value
				End Set
			End Property
			Friend Property PM_Obj As Edi.Dom.Segments.PM_Obj
				Get
					Return CType(Children(5), Edi.Dom.Segments.PM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PM_Obj)
					Children(5) = value
				End Set
			End Property

			Private Property PM_Std As Edi.Dom.Segments.PM Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.PM
				Get
					Return CType(Children(5), Edi.Dom.Segments.PM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PM)
					Children(5) = value
				End Set
			End Property

			Friend ReadOnly Property EC_Obj As SegmentContainer(Of Edi.Dom.Segments.EC) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.EC
				Get
					Return CType(Children(6), SegmentContainer(Of Edi.Dom.Segments.EC))
				End Get
			End Property

			Private ECSubset_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC, Edi.Dom.Segments.EC)
			Private ReadOnly Property EC_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC, Edi.Dom.Segments.EC) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.EC
				Get
					If ECSubset_Loop2100A_Obj Is Nothing Then
						ECSubset_Loop2100A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC, Edi.Dom.Segments.EC)(Children(6), 0, "2", "1000")
					End If

					Return ECSubset_Loop2100A_Obj
				End Get
			End Property
			Friend Property ICM_Obj As Edi.Dom.Segments.ICM_Obj
				Get
					Return CType(Children(7), Edi.Dom.Segments.ICM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ICM_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property ICM_Std As Edi.Dom.Segments.ICM Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.ICM
				Get
					Return CType(Children(7), Edi.Dom.Segments.ICM_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ICM)
					Children(7) = value
				End Set
			End Property

			Private Property ICM_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.ICM
				Get
					Return CType(Children(7), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM)
					Children(7) = value
				End Set
			End Property
			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.AMT
				Get
					Return CType(Children(8), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Private AMTSubset_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT, Edi.Dom.Segments.AMT)
			Private ReadOnly Property AMT_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT, Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.AMT
				Get
					If AMTSubset_Loop2100A_Obj Is Nothing Then
						AMTSubset_Loop2100A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT, Edi.Dom.Segments.AMT)(Children(8), 7, "2", "1200")
					End If

					Return AMTSubset_Loop2100A_Obj
				End Get
			End Property
			Friend Property HLH_Obj As Edi.Dom.Segments.HLH_Obj
				Get
					Return CType(Children(9), Edi.Dom.Segments.HLH_Obj)
				End Get
				Set(value As Edi.Dom.Segments.HLH_Obj)
					Children(9) = value
				End Set
			End Property

			Private Property HLH_Std As Edi.Dom.Segments.HLH Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.HLH
				Get
					Return CType(Children(9), Edi.Dom.Segments.HLH_Obj)
				End Get
				Set(value As Edi.Dom.Segments.HLH)
					Children(9) = value
				End Set
			End Property

			Private Property HLH_IFace_Loop2100A_Obj As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.HLH
				Get
					Return CType(Children(9), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH)
					Children(9) = value
				End Set
			End Property
			Friend ReadOnly Property HI_Obj As SegmentContainer(Of Edi.Dom.Segments.HI) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.HI
				Get
					Return CType(Children(10), SegmentContainer(Of Edi.Dom.Segments.HI))
				End Get
			End Property

			Friend ReadOnly Property LUI_Obj As SegmentContainer(Of Edi.Dom.Segments.LUI) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2100.LUI
				Get
					Return CType(Children(11), SegmentContainer(Of Edi.Dom.Segments.LUI))
				End Get
			End Property

			Private LUISubset_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI, Edi.Dom.Segments.LUI)
			Private ReadOnly Property LUI_Loop2100A_Obj As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI, Edi.Dom.Segments.LUI) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A.LUI
				Get
					If LUISubset_Loop2100A_Obj Is Nothing Then
						LUISubset_Loop2100A_Obj = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI, Edi.Dom.Segments.LUI)(Children(11), 0, "2", "1500")
					End If

					Return LUISubset_Loop2100A_Obj
				End Get
			End Property

		End Class
		Partial Friend Class Loop2200_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2200,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.DSB_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(10, "2", "2100"),
										New SegmentContainer(Of Edi.Dom.Segments.AD1)(10, "2", "2200")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "DSB", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "AD1", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "AD1", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "AD1", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "DSB", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DSB_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DSB_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";360;361;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2200", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "2100"
					End If
				ElseIf String.Compare(SegmentName, "AD1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AD1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AD1_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property DSB_Obj As Edi.Dom.Segments.DSB_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.DSB_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DSB_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property DSB_Std As Edi.Dom.Segments.DSB Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2200.DSB
				Get
					Return CType(Children(0), Edi.Dom.Segments.DSB_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DSB)
					Children(0) = value
				End Set
			End Property

			Private Property DSB_IFace_Loop2200_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200.DSB
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2200.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2200_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP, Edi.Dom.Segments.DTP)
			Private ReadOnly Property DTP_Loop2200_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP, Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200.DTP
				Get
					If DTPSubset_Loop2200_Obj_1 Is Nothing Then
						DTPSubset_Loop2200_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP, Edi.Dom.Segments.DTP)(Children(1), 2, "9", "2100")
					End If

					Return DTPSubset_Loop2200_Obj_1
				End Get
			End Property
			Friend ReadOnly Property AD1_Obj As SegmentContainer(Of Edi.Dom.Segments.AD1) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2200.AD1
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.AD1))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2300_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.HD_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(10, "2", "2700"),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(3, "2", "2800"),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(5, "2", "2900"),
										New SegmentContainer(Of Edi.Dom.Segments.IDC)(0, "2", "3000"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2310)(30, "2", "3100"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2320)(5, "2", "4000")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "HD", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "AMT", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "IDC", ReadAction.PopulateSegment, 8, False),
						New ReaderState(2, "IDC", ReadAction.PopulateSegment, 8, False),
						New ReaderState(4, "IDC", ReadAction.PopulateSegment, 8, False),
						New ReaderState(6, "IDC", ReadAction.PopulateSegment, 8, False),
						New ReaderState(8, "IDC", ReadAction.PopulateSegment, 8, False),
						New ReaderState(1, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(2, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(4, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(6, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(8, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(10, "LX", ReadAction.PopulateLoop, 10, False),
						New ReaderState(1, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(2, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(4, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(6, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(8, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(10, "COB", ReadAction.PopulateLoop, 12, False),
						New ReaderState(12, "COB", ReadAction.PopulateLoop, 12, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "HD", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.HD_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HD_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";300;303;343;348;349;543;695;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "2700"
					End If
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.AMT_Obj)
					If MyBase.CompareKey(S2.AMT01, ";B9;C1;D2;EBA;FK;P3;R;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "2800"
					End If
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";17;1L;9V;CE;E8;M7;PID;RB;X9;XM;XX1;XX2;ZX;ZZ;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "2900"
					ElseIf MyBase.CompareKey(S2.REF01, ";QQ;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "2905"
					End If
				ElseIf String.Compare(SegmentName, "IDC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IDC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IDC_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2310_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2310_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2300__2310"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "3100"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				ElseIf String.Compare(args.DataSegment.SegmentID, "COB", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2320_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2320_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_834A1__2000__2300", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2300__2320"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "4000"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property HD_Obj As Edi.Dom.Segments.HD_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.HD_Obj)
				End Get
				Set(value As Edi.Dom.Segments.HD_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property HD_Std As Edi.Dom.Segments.HD Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.HD
				Get
					Return CType(Children(0), Edi.Dom.Segments.HD_Obj)
				End Get
				Set(value As Edi.Dom.Segments.HD)
					Children(0) = value
				End Set
			End Property

			Private Property HD_IFace_Loop2300_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.HD
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP, Edi.Dom.Segments.DTP)
			Private ReadOnly Property DTP_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP, Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.DTP
				Get
					If DTPSubset_Loop2300_Obj_1 Is Nothing Then
						DTPSubset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP, Edi.Dom.Segments.DTP)(Children(1), 6, "9", "2700")
					End If

					Return DTPSubset_Loop2300_Obj_1
				End Get
			End Property
			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.AMT
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Private AMTSubset_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT, Edi.Dom.Segments.AMT)
			Private ReadOnly Property AMT_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT, Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.AMT
				Get
					If AMTSubset_Loop2300_Obj_1 Is Nothing Then
						AMTSubset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT, Edi.Dom.Segments.AMT)(Children(2), 9, "9", "2800")
					End If

					Return AMTSubset_Loop2300_Obj_1
				End Get
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.REF
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.REF
				Get
					If REFSubset_Loop2300_Obj_1 Is Nothing Then
						REFSubset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF, Edi.Dom.Segments.REF)(Children(3), 14, "9", "2900")
					End If

					Return REFSubset_Loop2300_Obj_1
				End Get
			End Property
			Private REF_1Subset_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1, Edi.Dom.Segments.REF)
			Private Property REF_IFace_1_Loop2300_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.REF_1
				Get
					If REF_1Subset_Loop2300_Obj_1 Is Nothing Then
						REF_1Subset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1, Edi.Dom.Segments.REF)(Children(3), 1, "9", "2905")
					End If

					If REF_1Subset_Loop2300_Obj_1.Count > 0 Then
						Return REF_1Subset_Loop2300_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1)
					If REF_1Subset_Loop2300_Obj_1 Is Nothing Then
						REF_1Subset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1, Edi.Dom.Segments.REF)(Children(3), 1, "9", "2905")
					End If

					If REF_1Subset_Loop2300_Obj_1.Count = 0 Then
						REF_1Subset_Loop2300_Obj_1.Add(value)
					Else
						REF_1Subset_Loop2300_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property IDC_Obj As SegmentContainer(Of Edi.Dom.Segments.IDC) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.IDC
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.IDC))
				End Get
			End Property

			Private IDCSubset_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC, Edi.Dom.Segments.IDC)
			Private ReadOnly Property IDC_Loop2300_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC, Edi.Dom.Segments.IDC) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.IDC
				Get
					If IDCSubset_Loop2300_Obj_1 Is Nothing Then
						IDCSubset_Loop2300_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC, Edi.Dom.Segments.IDC)(Children(4), 3, "9", "3000")
					End If

					Return IDCSubset_Loop2300_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2310_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2310) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.Loop2310
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2310))
				End Get
			End Property

			Private Loop2310Subset_Loop2300_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310, Edi.Dom.Transactions.Transaction834.Loops.Loop2310)
			Private ReadOnly Property Loop2310_Obj_1_Loop2300_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310, Edi.Dom.Transactions.Transaction834.Loops.Loop2310) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.Loop2310
				Get
					If Loop2310Subset_Loop2300_Obj_1 Is Nothing Then
						Loop2310Subset_Loop2300_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310, Edi.Dom.Transactions.Transaction834.Loops.Loop2310)(Children(5), 30, "9", "3100")
					End If

					Return Loop2310Subset_Loop2300_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2320_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2320) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2300.Loop2320
				Get
					Return CType(Children(6), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2320))
				End Get
			End Property

			Private Loop2320Subset_Loop2300_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320, Edi.Dom.Transactions.Transaction834.Loops.Loop2320)
			Private ReadOnly Property Loop2320_Obj_1_Loop2300_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320, Edi.Dom.Transactions.Transaction834.Loops.Loop2320) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300.Loop2320
				Get
					If Loop2320Subset_Loop2300_Obj_1 Is Nothing Then
						Loop2320Subset_Loop2300_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320, Edi.Dom.Transactions.Transaction834.Loops.Loop2320)(Children(6), 5, "9", "4000")
					End If

					Return Loop2320Subset_Loop2300_Obj_1
				End Get
			End Property

		End Class
		Partial Friend Class Loop2310_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.LX_Obj),
										CType(Nothing, Edi.Dom.Segments.NM1_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.N1)(3, "2", "3300"),
										CType(Nothing, Edi.Dom.Segments.N2_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.N3)(2, "2", "3500"),
										New SegmentContainer(Of Edi.Dom.Segments.N4)(2, "2", "3600"),
										New SegmentContainer(Of Edi.Dom.Segments.PER)(2, "2", "3700"),
										CType(Nothing, Edi.Dom.Segments.PRV_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(6, "2", "3900"),
										CType(Nothing, Edi.Dom.Segments.PLA_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LX", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "NM1", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N1", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "N1", ReadAction.PopulateSegment, 3, False),
						New ReaderState(3, "N1", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "N2", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "N2", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "N2", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "N3", ReadAction.PopulateSegment, 6, False),
						New ReaderState(3, "N3", ReadAction.PopulateSegment, 6, False),
						New ReaderState(5, "N3", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "N3", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(3, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(5, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(6, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(8, "N4", ReadAction.PopulateSegment, 8, False),
						New ReaderState(1, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(2, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(3, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(5, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(6, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(8, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(10, "PER", ReadAction.PopulateSegment, 10, False),
						New ReaderState(1, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(2, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(3, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(5, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(6, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(8, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(10, "PRV", ReadAction.PopulateSegment, 12, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(3, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(5, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(6, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(8, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(10, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(12, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(13, "DTP", ReadAction.PopulateSegment, 13, False),
						New ReaderState(1, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(2, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(3, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(5, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(6, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(8, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(10, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(12, "PLA", ReadAction.PopulateSegment, 15, False),
						New ReaderState(13, "PLA", ReadAction.PopulateSegment, 15, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LX_Obj = Seg
				ElseIf String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";1X;3D;80;FA;OD;P3;QA;QN;Y2;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300__2310", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "3200"
					End If
				ElseIf String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj = Seg
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PRV_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "PLA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PLA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PLA_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property LX_Obj As Edi.Dom.Segments.LX_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.LX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LX_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property LX_Std As Edi.Dom.Segments.LX Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.LX
				Get
					Return CType(Children(0), Edi.Dom.Segments.LX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LX)
					Children(0) = value
				End Set
			End Property

			Private Property LX_IFace_Loop2310_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.LX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX)
					Children(0) = value
				End Set
			End Property
			Friend Property NM1_Obj As Edi.Dom.Segments.NM1_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.NM1
				Get
					Return CType(Children(1), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(1) = value
				End Set
			End Property

			Private Property NM1_IFace_Loop2310_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.NM1
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property N1_Obj As SegmentContainer(Of Edi.Dom.Segments.N1) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.N1
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.N1))
				End Get
			End Property

			Friend Property N2_Obj As Edi.Dom.Segments.N2_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N2_Std As Edi.Dom.Segments.N2 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.N2
				Get
					Return CType(Children(3), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.N3
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.N3))
				End Get
			End Property

			Private N3Subset_Loop2310_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3, Edi.Dom.Segments.N3)
			Private ReadOnly Property N3_Loop2310_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3, Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.N3
				Get
					If N3Subset_Loop2310_Obj_1 Is Nothing Then
						N3Subset_Loop2310_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3, Edi.Dom.Segments.N3)(Children(4), 2, "9", "3500")
					End If

					Return N3Subset_Loop2310_Obj_1
				End Get
			End Property
			Friend ReadOnly Property N4_Obj As SegmentContainer(Of Edi.Dom.Segments.N4) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.N4
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.N4))
				End Get
			End Property

			Private N4Subset_Loop2310_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4, Edi.Dom.Segments.N4)
			Private Property N4_IFace_Loop2310_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.N4
				Get
					If N4Subset_Loop2310_Obj_1 Is Nothing Then
						N4Subset_Loop2310_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4, Edi.Dom.Segments.N4)(Children(5), 1, "9", "3600")
					End If

					If N4Subset_Loop2310_Obj_1.Count > 0 Then
						Return N4Subset_Loop2310_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4)
					If N4Subset_Loop2310_Obj_1 Is Nothing Then
						N4Subset_Loop2310_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4, Edi.Dom.Segments.N4)(Children(5), 1, "9", "3600")
					End If

					If N4Subset_Loop2310_Obj_1.Count = 0 Then
						N4Subset_Loop2310_Obj_1.Add(value)
					Else
						N4Subset_Loop2310_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.PER
				Get
					Return CType(Children(6), SegmentContainer(Of Edi.Dom.Segments.PER))
				End Get
			End Property

			Private PERSubset_Loop2310_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER, Edi.Dom.Segments.PER)
			Private ReadOnly Property PER_Loop2310_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER, Edi.Dom.Segments.PER) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.PER
				Get
					If PERSubset_Loop2310_Obj_1 Is Nothing Then
						PERSubset_Loop2310_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER, Edi.Dom.Segments.PER)(Children(6), 2, "9", "3700")
					End If

					Return PERSubset_Loop2310_Obj_1
				End Get
			End Property
			Friend Property PRV_Obj As Edi.Dom.Segments.PRV_Obj
				Get
					Return CType(Children(7), Edi.Dom.Segments.PRV_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PRV_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property PRV_Std As Edi.Dom.Segments.PRV Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.PRV
				Get
					Return CType(Children(7), Edi.Dom.Segments.PRV_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PRV)
					Children(7) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.DTP
				Get
					Return CType(Children(8), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend Property PLA_Obj As Edi.Dom.Segments.PLA_Obj
				Get
					Return CType(Children(9), Edi.Dom.Segments.PLA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PLA_Obj)
					Children(9) = value
				End Set
			End Property

			Private Property PLA_Std As Edi.Dom.Segments.PLA Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2310.PLA
				Get
					Return CType(Children(9), Edi.Dom.Segments.PLA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PLA)
					Children(9) = value
				End Set
			End Property

			Private Property PLA_IFace_Loop2310_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310.PLA
				Get
					Return CType(Children(9), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA)
					Children(9) = value
				End Set
			End Property

		End Class
		Partial Friend Class Loop2320_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2320,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.COB_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "4050"),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(2, "2", "4070"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2330)(3, "2", "4100")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "COB", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False),
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
				If String.Compare(SegmentName, "COB", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.COB_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					COB_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";60;6P;SY;ZZ;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300__2320", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "4050"
					End If
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";344;345;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300__2320", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "4500"
					End If
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2330_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2330_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";36;GW;IN;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300__2320", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2300__2320__2330"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "4510"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property COB_Obj As Edi.Dom.Segments.COB_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.COB_Obj)
				End Get
				Set(value As Edi.Dom.Segments.COB_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property COB_Std As Edi.Dom.Segments.COB Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2320.COB
				Get
					Return CType(Children(0), Edi.Dom.Segments.COB_Obj)
				End Get
				Set(value As Edi.Dom.Segments.COB)
					Children(0) = value
				End Set
			End Property

			Private Property COB_IFace_Loop2320_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320.COB
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2320.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2320_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF, Edi.Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2320_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF, Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320.REF
				Get
					If REFSubset_Loop2320_Obj_1 Is Nothing Then
						REFSubset_Loop2320_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF, Edi.Dom.Segments.REF)(Children(1), 4, "9", "4050")
					End If

					Return REFSubset_Loop2320_Obj_1
				End Get
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2320.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2320_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP, Edi.Dom.Segments.DTP)
			Private ReadOnly Property DTP_Loop2320_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP, Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320.DTP
				Get
					If DTPSubset_Loop2320_Obj_1 Is Nothing Then
						DTPSubset_Loop2320_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP, Edi.Dom.Segments.DTP)(Children(2), 2, "9", "4500")
					End If

					Return DTPSubset_Loop2320_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop2330_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2330) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2320.Loop2330
				Get
					Return CType(Children(3), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2330))
				End Get
			End Property

			Private Loop2330Subset_Loop2320_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330, Edi.Dom.Transactions.Transaction834.Loops.Loop2330)
			Private ReadOnly Property Loop2330_Obj_1_Loop2320_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330, Edi.Dom.Transactions.Transaction834.Loops.Loop2330) Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320.Loop2330
				Get
					If Loop2330Subset_Loop2320_Obj_1 Is Nothing Then
						Loop2330Subset_Loop2320_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330, Edi.Dom.Transactions.Transaction834.Loops.Loop2330)(Children(3), 3, "9", "4510")
					End If

					Return Loop2330Subset_Loop2320_Obj_1
				End Get
			End Property

		End Class
		Partial Friend Class Loop2330_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
										CType(Nothing, Edi.Dom.Segments.N2_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.N3)(2, "2", "4300"),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										CType(Nothing, Edi.Dom.Segments.PER_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "N2", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "N3", ReadAction.PopulateSegment, 3, False),
						New ReaderState(3, "N3", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "N4", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(3, "PER", ReadAction.PopulateSegment, 6, False),
						New ReaderState(5, "PER", ReadAction.PopulateSegment, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";36;GW;IN;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2300__2320__2330", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "4510"
					End If
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj = Seg
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj = Seg
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

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_IFace_Loop2330_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330.NM1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1)
					Children(0) = value
				End Set
			End Property
			Friend Property N2_Obj As Edi.Dom.Segments.N2_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property N2_Std As Edi.Dom.Segments.N2 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330.N2
				Get
					Return CType(Children(1), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2)
					Children(1) = value
				End Set
			End Property

			Friend ReadOnly Property N3_Obj As SegmentContainer(Of Edi.Dom.Segments.N3) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330.N3
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.N3))
				End Get
			End Property

			Private N3Subset_Loop2330_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3, Edi.Dom.Segments.N3)
			Private Property N3_IFace_Loop2330_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330.N3
				Get
					If N3Subset_Loop2330_Obj_1 Is Nothing Then
						N3Subset_Loop2330_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3, Edi.Dom.Segments.N3)(Children(2), 1, "9", "4520")
					End If

					If N3Subset_Loop2330_Obj_1.Count > 0 Then
						Return N3Subset_Loop2330_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3)
					If N3Subset_Loop2330_Obj_1 Is Nothing Then
						N3Subset_Loop2330_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3, Edi.Dom.Segments.N3)(Children(2), 1, "9", "4520")
					End If

					If N3Subset_Loop2330_Obj_1.Count = 0 Then
						N3Subset_Loop2330_Obj_1.Add(value)
					Else
						N3Subset_Loop2330_Obj_1(0) = value
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

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330.N4
				Get
					Return CType(Children(3), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(3) = value
				End Set
			End Property

			Private Property N4_IFace_Loop2330_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330.N4
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4)
					Children(3) = value
				End Set
			End Property
			Friend Property PER_Obj As Edi.Dom.Segments.PER_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.PER_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PER_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property PER_Std As Edi.Dom.Segments.PER Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2330.PER
				Get
					Return CType(Children(4), Edi.Dom.Segments.PER_Obj)
				End Get
				Set(value As Edi.Dom.Segments.PER)
					Children(4) = value
				End Set
			End Property

			Private Property PER_IFace_Loop2330_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330.PER
				Get
					Return CType(Children(4), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER)
					Children(4) = value
				End Set
			End Property

		End Class
		Partial Friend Class Loop2400_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.LC_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(5, "2", "4700"),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(2, "2", "4800"),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "4850"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2410)(20, "2", "4900")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LC", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "BEN", ReadAction.PopulateLoop, 8, False),
						New ReaderState(2, "BEN", ReadAction.PopulateLoop, 8, False),
						New ReaderState(4, "BEN", ReadAction.PopulateLoop, 8, False),
						New ReaderState(6, "BEN", ReadAction.PopulateLoop, 8, False),
						New ReaderState(8, "BEN", ReadAction.PopulateLoop, 8, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "LC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LC_Obj = Seg
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "BEN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2410_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2410_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property LC_Obj As Edi.Dom.Segments.LC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.LC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property LC_Std As Edi.Dom.Segments.LC Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400.LC
				Get
					Return CType(Children(0), Edi.Dom.Segments.LC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400.AMT
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400.REF
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property Loop2410_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2410) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2400.Loop2410
				Get
					Return CType(Children(4), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2410))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2410_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.BEN_Obj),
										CType(Nothing, Edi.Dom.Segments.NM1_Obj),
										CType(Nothing, Edi.Dom.Segments.N1_Obj),
										CType(Nothing, Edi.Dom.Segments.N2_Obj),
										CType(Nothing, Edi.Dom.Segments.N3_Obj),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										CType(Nothing, Edi.Dom.Segments.DMG_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "BEN", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "NM1", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N1", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "N1", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "N2", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "N2", ReadAction.PopulateSegment, 4, False),
						New ReaderState(3, "N2", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "N3", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "N3", ReadAction.PopulateSegment, 5, False),
						New ReaderState(4, "N3", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 6, False),
						New ReaderState(3, "N4", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "N4", ReadAction.PopulateSegment, 6, False),
						New ReaderState(5, "N4", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "DMG", ReadAction.PopulateSegment, 7, False),
						New ReaderState(2, "DMG", ReadAction.PopulateSegment, 7, False),
						New ReaderState(3, "DMG", ReadAction.PopulateSegment, 7, False),
						New ReaderState(4, "DMG", ReadAction.PopulateSegment, 7, False),
						New ReaderState(5, "DMG", ReadAction.PopulateSegment, 7, False),
						New ReaderState(6, "DMG", ReadAction.PopulateSegment, 7, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "BEN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.BEN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BEN_Obj = Seg
				ElseIf String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
				ElseIf String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj = Seg
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj = Seg
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DMG_Obj = Seg
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property BEN_Obj As Edi.Dom.Segments.BEN_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.BEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BEN_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property BEN_Std As Edi.Dom.Segments.BEN Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.BEN
				Get
					Return CType(Children(0), Edi.Dom.Segments.BEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BEN)
					Children(0) = value
				End Set
			End Property

			Friend Property NM1_Obj As Edi.Dom.Segments.NM1_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.NM1
				Get
					Return CType(Children(1), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(1) = value
				End Set
			End Property

			Friend Property N1_Obj As Edi.Dom.Segments.N1_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property N1_Std As Edi.Dom.Segments.N1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.N1
				Get
					Return CType(Children(2), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1)
					Children(2) = value
				End Set
			End Property

			Friend Property N2_Obj As Edi.Dom.Segments.N2_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N2_Std As Edi.Dom.Segments.N2 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.N2
				Get
					Return CType(Children(3), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2)
					Children(3) = value
				End Set
			End Property

			Friend Property N3_Obj As Edi.Dom.Segments.N3_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property N3_Std As Edi.Dom.Segments.N3 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.N3
				Get
					Return CType(Children(4), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3)
					Children(4) = value
				End Set
			End Property

			Friend Property N4_Obj As Edi.Dom.Segments.N4_Obj
				Get
					Return CType(Children(5), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4_Obj)
					Children(5) = value
				End Set
			End Property

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.N4
				Get
					Return CType(Children(5), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(5) = value
				End Set
			End Property

			Friend Property DMG_Obj As Edi.Dom.Segments.DMG_Obj
				Get
					Return CType(Children(6), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG_Obj)
					Children(6) = value
				End Set
			End Property

			Private Property DMG_Std As Edi.Dom.Segments.DMG Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2410.DMG
				Get
					Return CType(Children(6), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG)
					Children(6) = value
				End Set
			End Property


		End Class
		Partial Friend Class Loop2500_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2500
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.FSA_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(10, "2", "5600"),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(10, "2", "5700"),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "5750")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "FSA", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "REF", ReadAction.PopulateSegment, 6, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "FSA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FSA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FSA_Obj = Seg
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property FSA_Obj As Edi.Dom.Segments.FSA_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.FSA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FSA_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property FSA_Std As Edi.Dom.Segments.FSA Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2500.FSA
				Get
					Return CType(Children(0), Edi.Dom.Segments.FSA_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FSA)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2500.AMT
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2500.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2500.REF
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2600_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.RP_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "5900"),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "5920"),
										New SegmentContainer(Of Edi.Dom.Segments.INV)(0, "2", "5940"),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(20, "2", "5960"),
										New SegmentContainer(Of Edi.Dom.Segments.QTY)(20, "2", "5970"),
										New SegmentContainer(Of Edi.Dom.Segments.K3)(3, "2", "5980"),
										CType(Nothing, Edi.Dom.Segments.REL_Obj),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2610)(0, "2", "6100"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2630)(0, "2", "6600"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2650)(0, "2", "6850")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "RP", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "INV", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "INV", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "INV", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "INV", ReadAction.PopulateSegment, 6, False),
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
						New ReaderState(1, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(2, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(4, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(6, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(8, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(10, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(12, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(1, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(2, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(4, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(6, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(8, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(10, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(12, "REL", ReadAction.PopulateSegment, 14, False),
						New ReaderState(1, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(2, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(4, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(6, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(8, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(10, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(12, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(14, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(15, "NM1", ReadAction.PopulateLoop, 15, False),
						New ReaderState(1, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(2, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(4, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(6, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(8, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(10, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(12, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(14, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(15, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(17, "FC", ReadAction.PopulateLoop, 17, False),
						New ReaderState(1, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(2, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(4, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(6, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(8, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(10, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(12, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(14, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(15, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(17, "AIN", ReadAction.PopulateLoop, 19, False),
						New ReaderState(19, "AIN", ReadAction.PopulateLoop, 19, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "RP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.RP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					RP_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "INV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.INV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					INV_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "K3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.K3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					K3_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REL", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REL_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2610_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2610_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "FC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2630_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2630_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				ElseIf String.Compare(args.DataSegment.SegmentID, "AIN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2650_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2650_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property RP_Obj As Edi.Dom.Segments.RP_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.RP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RP_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property RP_Std As Edi.Dom.Segments.RP Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.RP
				Get
					Return CType(Children(0), Edi.Dom.Segments.RP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.RP)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.REF
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property INV_Obj As SegmentContainer(Of Edi.Dom.Segments.INV) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.INV
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.INV))
				End Get
			End Property

			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.AMT
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.QTY
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.QTY))
				End Get
			End Property

			Friend ReadOnly Property K3_Obj As SegmentContainer(Of Edi.Dom.Segments.K3) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.K3
				Get
					Return CType(Children(6), SegmentContainer(Of Edi.Dom.Segments.K3))
				End Get
			End Property

			Friend Property REL_Obj As Edi.Dom.Segments.REL_Obj
				Get
					Return CType(Children(7), Edi.Dom.Segments.REL_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REL_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property REL_Std As Edi.Dom.Segments.REL Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.REL
				Get
					Return CType(Children(7), Edi.Dom.Segments.REL_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REL)
					Children(7) = value
				End Set
			End Property

			Friend ReadOnly Property Loop2610_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2610) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.Loop2610
				Get
					Return CType(Children(8), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2610))
				End Get
			End Property

			Friend ReadOnly Property Loop2630_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2630) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.Loop2630
				Get
					Return CType(Children(9), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2630))
				End Get
			End Property

			Friend ReadOnly Property Loop2650_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2650) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2600.Loop2650
				Get
					Return CType(Children(10), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2650))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2610_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NM1_Obj),
										CType(Nothing, Edi.Dom.Segments.N2_Obj),
										CType(Nothing, Edi.Dom.Segments.DMG_Obj),
										CType(Nothing, Edi.Dom.Segments.BEN_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "6530"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2620)(0, "2", "6540")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NM1", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "N2", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "DMG", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "DMG", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "BEN", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "BEN", ReadAction.PopulateSegment, 4, False),
						New ReaderState(3, "BEN", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 5, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "REF", ReadAction.PopulateSegment, 5, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 5, False),
						New ReaderState(5, "REF", ReadAction.PopulateSegment, 5, False),
						New ReaderState(1, "NX1", ReadAction.PopulateLoop, 7, False),
						New ReaderState(2, "NX1", ReadAction.PopulateLoop, 7, False),
						New ReaderState(3, "NX1", ReadAction.PopulateLoop, 7, False),
						New ReaderState(4, "NX1", ReadAction.PopulateLoop, 7, False),
						New ReaderState(5, "NX1", ReadAction.PopulateLoop, 7, False),
						New ReaderState(7, "NX1", ReadAction.PopulateLoop, 7, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
				ElseIf String.Compare(SegmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj = Seg
				ElseIf String.Compare(SegmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DMG_Obj = Seg
				ElseIf String.Compare(SegmentName, "BEN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.BEN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BEN_Obj = Seg
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NX1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2620_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2620_Obj.Add(NewLoop)
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

			Private Property NM1_Std As Edi.Dom.Segments.NM1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.NM1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NM1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Friend Property N2_Obj As Edi.Dom.Segments.N2_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property N2_Std As Edi.Dom.Segments.N2 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.N2
				Get
					Return CType(Children(1), Edi.Dom.Segments.N2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N2)
					Children(1) = value
				End Set
			End Property

			Friend Property DMG_Obj As Edi.Dom.Segments.DMG_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property DMG_Std As Edi.Dom.Segments.DMG Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.DMG
				Get
					Return CType(Children(2), Edi.Dom.Segments.DMG_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DMG)
					Children(2) = value
				End Set
			End Property

			Friend Property BEN_Obj As Edi.Dom.Segments.BEN_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.BEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BEN_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property BEN_Std As Edi.Dom.Segments.BEN Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.BEN
				Get
					Return CType(Children(3), Edi.Dom.Segments.BEN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.BEN)
					Children(3) = value
				End Set
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.REF
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property Loop2620_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2620) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2610.Loop2620
				Get
					Return CType(Children(5), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2620))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2620_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2620
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.NX1_Obj),
										CType(Nothing, Edi.Dom.Segments.N3_Obj),
										CType(Nothing, Edi.Dom.Segments.N4_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "6570")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "NX1", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "N3", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "N4", ReadAction.PopulateSegment, 3, False),
						New ReaderState(2, "N4", ReadAction.PopulateSegment, 3, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(3, "DTP", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "DTP", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "NX1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.NX1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NX1_Obj = Seg
				ElseIf String.Compare(SegmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj = Seg
				ElseIf String.Compare(SegmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property NX1_Obj As Edi.Dom.Segments.NX1_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.NX1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NX1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property NX1_Std As Edi.Dom.Segments.NX1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2620.NX1
				Get
					Return CType(Children(0), Edi.Dom.Segments.NX1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.NX1)
					Children(0) = value
				End Set
			End Property

			Friend Property N3_Obj As Edi.Dom.Segments.N3_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property N3_Std As Edi.Dom.Segments.N3 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2620.N3
				Get
					Return CType(Children(1), Edi.Dom.Segments.N3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N3)
					Children(1) = value
				End Set
			End Property

			Friend Property N4_Obj As Edi.Dom.Segments.N4_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property N4_Std As Edi.Dom.Segments.N4 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2620.N4
				Get
					Return CType(Children(2), Edi.Dom.Segments.N4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N4)
					Children(2) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2620.DTP
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2630_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2630
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.FC_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "6700"),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2640)(0, "2", "6780")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "FC", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "INV", ReadAction.PopulateLoop, 4, False),
						New ReaderState(2, "INV", ReadAction.PopulateLoop, 4, False),
						New ReaderState(4, "INV", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "FC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.FC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					FC_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "INV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2640_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2640_Obj.Add(NewLoop)
					Await NewLoop.ReadAsync(args).ConfigureAwait(False) 'TODO: this code should not be reached as this is for a loop not represented by any implementation (and should cause some kind of validation error).
				End If
				args.Implementation = Temp
			End Function
			Friend Property FC_Obj As Edi.Dom.Segments.FC_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.FC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FC_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property FC_Std As Edi.Dom.Segments.FC Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2630.FC
				Get
					Return CType(Children(0), Edi.Dom.Segments.FC_Obj)
				End Get
				Set(value As Edi.Dom.Segments.FC)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2630.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property Loop2640_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2640) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2630.Loop2640
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2640))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2640_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.INV_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "6790"),
										New SegmentContainer(Of Edi.Dom.Segments.QTY)(0, "2", "6800"),
										New SegmentContainer(Of Edi.Dom.Segments.ENT)(0, "2", "6810"),
										New SegmentContainer(Of Edi.Dom.Segments.REF)(0, "2", "6820"),
										New SegmentContainer(Of Edi.Dom.Segments.AMT)(20, "2", "6830"),
										New SegmentContainer(Of Edi.Dom.Segments.K3)(3, "2", "6840")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "INV", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 2, False),
						New ReaderState(1, "QTY", ReadAction.PopulateSegment, 4, False),
						New ReaderState(2, "QTY", ReadAction.PopulateSegment, 4, False),
						New ReaderState(4, "QTY", ReadAction.PopulateSegment, 4, False),
						New ReaderState(1, "ENT", ReadAction.PopulateSegment, 6, False),
						New ReaderState(2, "ENT", ReadAction.PopulateSegment, 6, False),
						New ReaderState(4, "ENT", ReadAction.PopulateSegment, 6, False),
						New ReaderState(6, "ENT", ReadAction.PopulateSegment, 6, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 8, False),
						New ReaderState(2, "REF", ReadAction.PopulateSegment, 8, False),
						New ReaderState(4, "REF", ReadAction.PopulateSegment, 8, False),
						New ReaderState(6, "REF", ReadAction.PopulateSegment, 8, False),
						New ReaderState(8, "REF", ReadAction.PopulateSegment, 8, False),
						New ReaderState(1, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(2, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(4, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(6, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(8, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(10, "AMT", ReadAction.PopulateSegment, 10, False),
						New ReaderState(1, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(2, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(4, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(6, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(8, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(10, "K3", ReadAction.PopulateSegment, 12, False),
						New ReaderState(12, "K3", ReadAction.PopulateSegment, 12, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "INV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.INV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					INV_Obj = Seg
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "ENT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.ENT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ENT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AMT_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "K3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.K3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					K3_Obj.Add(Seg)
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

			Private Property INV_Std As Edi.Dom.Segments.INV Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.INV
				Get
					Return CType(Children(0), Edi.Dom.Segments.INV_Obj)
				End Get
				Set(value As Edi.Dom.Segments.INV)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.DTP
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property

			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.QTY
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.QTY))
				End Get
			End Property

			Friend ReadOnly Property ENT_Obj As SegmentContainer(Of Edi.Dom.Segments.ENT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.ENT
				Get
					Return CType(Children(3), SegmentContainer(Of Edi.Dom.Segments.ENT))
				End Get
			End Property

			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Edi.Dom.Segments.REF) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.REF
				Get
					Return CType(Children(4), SegmentContainer(Of Edi.Dom.Segments.REF))
				End Get
			End Property

			Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Edi.Dom.Segments.AMT) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.AMT
				Get
					Return CType(Children(5), SegmentContainer(Of Edi.Dom.Segments.AMT))
				End Get
			End Property

			Friend ReadOnly Property K3_Obj As SegmentContainer(Of Edi.Dom.Segments.K3) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2640.K3
				Get
					Return CType(Children(6), SegmentContainer(Of Edi.Dom.Segments.K3))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2650_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2650
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.AIN_Obj),
										New SegmentContainer(Of Edi.Dom.Segments.QTY)(0, "2", "6860"),
										New SegmentContainer(Of Edi.Dom.Segments.DTP)(0, "2", "6870")})

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
				If String.Compare(SegmentName, "AIN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AIN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AIN_Obj = Seg
				ElseIf String.Compare(SegmentName, "QTY", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.QTY_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					QTY_Obj.Add(Seg)
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
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

			Private Property AIN_Std As Edi.Dom.Segments.AIN Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2650.AIN
				Get
					Return CType(Children(0), Edi.Dom.Segments.AIN_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AIN)
					Children(0) = value
				End Set
			End Property

			Friend ReadOnly Property QTY_Obj As SegmentContainer(Of Edi.Dom.Segments.QTY) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2650.QTY
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.QTY))
				End Get
			End Property

			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Edi.Dom.Segments.DTP) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2650.DTP
				Get
					Return CType(Children(2), SegmentContainer(Of Edi.Dom.Segments.DTP))
				End Get
			End Property


		End Class
		Partial Friend Class Loop2700_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2700,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.LX_Obj),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2750)(0, "2", "6882")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "LX", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "N1", ReadAction.PopulateLoop, 1, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "LX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.LX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					LX_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction834.Loop2750_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2750_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";75;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2700", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_834A1__2000__2700__2750"
						NewLoop.SetArea = "9"
						NewLoop.SetSequence = "6802"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
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

			Private Property LX_Std As Edi.Dom.Segments.LX Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2700.LX
				Get
					Return CType(Children(0), Edi.Dom.Segments.LX_Obj)
				End Get
				Set(value As Edi.Dom.Segments.LX)
					Children(0) = value
				End Set
			End Property

			Private Property LX_IFace_Loop2700_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700.LX
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2750_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2750) Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2700.Loop2750
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2750))
				End Get
			End Property

			Private Loop2750Subset_Loop2700_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750, Edi.Dom.Transactions.Transaction834.Loops.Loop2750)
			Private Property Loop2750_IFace_Loop2700_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700.Loop2750
				Get
					If Loop2750Subset_Loop2700_Obj_1 Is Nothing Then
						Loop2750Subset_Loop2700_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750, Edi.Dom.Transactions.Transaction834.Loops.Loop2750)(Children(1), 1, "9", "6802")
					End If

					If Loop2750Subset_Loop2700_Obj_1.Count > 0 Then
						Return Loop2750Subset_Loop2700_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750)
					If Loop2750Subset_Loop2700_Obj_1 Is Nothing Then
						Loop2750Subset_Loop2700_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750, Edi.Dom.Transactions.Transaction834.Loops.Loop2750)(Children(1), 1, "9", "6802")
					End If

					If Loop2750Subset_Loop2700_Obj_1.Count = 0 Then
						Loop2750Subset_Loop2700_Obj_1.Add(value)
					Else
						Loop2750Subset_Loop2700_Obj_1(0) = value
					End If
				End Set
			End Property

		End Class
		Partial Friend Class Loop2750_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2750,
							Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.N1_Obj),
										CType(Nothing, Edi.Dom.Segments.REF_Obj),
										CType(Nothing, Edi.Dom.Segments.DTP_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "N1", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "REF", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "DTP", ReadAction.PopulateSegment, 3, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "N1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.N1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N1_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.N1_Obj)
					If MyBase.CompareKey(S2.N101, ";75;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2700__2750", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "6802"
					End If
				ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";00;17;18;19;26;3L;6M;9V;9X;GE;LU;PID;XX1;XX2;YY;ZZ;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2700__2750", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "6803"
					End If
				ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj = Seg
					Dim S2 = CType(Seg, Edi.Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";007;") AndAlso String.Compare(args.Implementation, "_834A1__2000__2700__2750", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "9"
						Seg.SetSequence = "6804"
					End If
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

			Private Property N1_Std As Edi.Dom.Segments.N1 Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2750.N1
				Get
					Return CType(Children(0), Edi.Dom.Segments.N1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.N1)
					Children(0) = value
				End Set
			End Property

			Private Property N1_IFace_Loop2750_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1 Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750.N1
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1)
					Children(0) = value
				End Set
			End Property
			Friend Property REF_Obj As Edi.Dom.Segments.REF_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property REF_Std As Edi.Dom.Segments.REF Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2750.REF
				Get
					Return CType(Children(1), Edi.Dom.Segments.REF_Obj)
				End Get
				Set(value As Edi.Dom.Segments.REF)
					Children(1) = value
				End Set
			End Property

			Private Property REF_IFace_Loop2750_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750.REF
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF)
					Children(1) = value
				End Set
			End Property
			Friend Property DTP_Obj As Edi.Dom.Segments.DTP_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.DTP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTP_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property DTP_Std As Edi.Dom.Segments.DTP Implements Edi.Dom.Transactions.Transaction834.Loops.Loop2750.DTP
				Get
					Return CType(Children(2), Edi.Dom.Segments.DTP_Obj)
				End Get
				Set(value As Edi.Dom.Segments.DTP)
					Children(2) = value
				End Set
			End Property

			Private Property DTP_IFace_Loop2750_Obj_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP Implements Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750.DTP
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP)
					Children(2) = value
				End Set
			End Property

		End Class
		'''<summary>Benefit Enrollment and Maintenance</summary>
		'''<remarks></remarks>
		Public Interface Standard
			'''<summary>Transaction Set Header</summary>
			Property ST As Edi.Dom.Segments.ST
			'''<summary>Beginning Segment</summary>
			Property BGN As Edi.Dom.Segments.BGN
			'''<summary>Reference Information</summary>
			ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
			'''<summary>Date or Time or Period</summary>
			ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
			'''<summary>Monetary Amount Information</summary>
			ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
			'''<summary>Quantity Information</summary>
			ReadOnly Property QTY As SegmentContainer(Of Edi.Dom.Segments.QTY)
			'''<summary>Party Identification</summary>
			ReadOnly Property Loop1000 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1000)
			'''<summary>Insured Benefit</summary>
			ReadOnly Property Loop2000 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2000)
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
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Account Identification</summary>
				ReadOnly Property Loop1100 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop1100)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop1100
				Inherits ILoop
				'''<summary>Account Identification</summary>
				Property ACT As Edi.Dom.Segments.ACT
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Party Location</summary>
				Property N3 As Edi.Dom.Segments.N3
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Date or Time or Period</summary>
				Property DTP As Edi.Dom.Segments.DTP
				'''<summary>Monetary Amount Information</summary>
				Property AMT As Edi.Dom.Segments.AMT
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2000
				Inherits ILoop
				'''<summary>Insured Benefit</summary>
				Property INS As Edi.Dom.Segments.INS
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop2100 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2100)
				'''<summary>Disability Information</summary>
				ReadOnly Property Loop2200 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2200)
				'''<summary>Health Coverage</summary>
				ReadOnly Property Loop2300 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2300)
				'''<summary>Life Coverage</summary>
				ReadOnly Property Loop2400 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2400)
				'''<summary>Flexible Spending Account</summary>
				ReadOnly Property Loop2500 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2500)
				'''<summary>Retirement Product</summary>
				ReadOnly Property Loop2600 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2600)
				'''<summary>Loop Header</summary>
				Property LS As Edi.Dom.Segments.LS
				'''<summary>Transaction Set Line Number</summary>
				ReadOnly Property Loop2700 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2700)
				'''<summary>Loop Trailer</summary>
				Property LE As Edi.Dom.Segments.LE
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2100
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Administrative Communications Contact</summary>
				Property PER As Edi.Dom.Segments.PER
				'''<summary>Party Location</summary>
				Property N3 As Edi.Dom.Segments.N3
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Demographic Information</summary>
				Property DMG As Edi.Dom.Segments.DMG
				'''<summary>Electronic Funds Transfer Information</summary>
				Property PM As Edi.Dom.Segments.PM
				'''<summary>Employment Class</summary>
				ReadOnly Property EC As SegmentContainer(Of Edi.Dom.Segments.EC)
				'''<summary>Individual Income</summary>
				Property ICM As Edi.Dom.Segments.ICM
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Health Information</summary>
				Property HLH As Edi.Dom.Segments.HLH
				'''<summary>Health Care Information Codes</summary>
				ReadOnly Property HI As SegmentContainer(Of Edi.Dom.Segments.HI)
				'''<summary>Language Use</summary>
				ReadOnly Property LUI As SegmentContainer(Of Edi.Dom.Segments.LUI)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2200
				Inherits ILoop
				'''<summary>Disability Information</summary>
				Property DSB As Edi.Dom.Segments.DSB
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Adjustment Amount</summary>
				ReadOnly Property AD1 As SegmentContainer(Of Edi.Dom.Segments.AD1)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2300
				Inherits ILoop
				'''<summary>Health Coverage</summary>
				Property HD As Edi.Dom.Segments.HD
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Identification Card</summary>
				ReadOnly Property IDC As SegmentContainer(Of Edi.Dom.Segments.IDC)
				'''<summary>Transaction Set Line Number</summary>
				ReadOnly Property Loop2310 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2310)
				'''<summary>Coordination of Benefits</summary>
				ReadOnly Property Loop2320 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2320)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2310
				Inherits ILoop
				'''<summary>Transaction Set Line Number</summary>
				Property LX As Edi.Dom.Segments.LX
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Party Identification</summary>
				ReadOnly Property N1 As SegmentContainer(Of Edi.Dom.Segments.N1)
				'''<summary>Additional Name Information</summary>
				Property N2 As Edi.Dom.Segments.N2
				'''<summary>Party Location</summary>
				ReadOnly Property N3 As SegmentContainer(Of Edi.Dom.Segments.N3)
				'''<summary>Geographic Location</summary>
				ReadOnly Property N4 As SegmentContainer(Of Edi.Dom.Segments.N4)
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Edi.Dom.Segments.PER)
				'''<summary>Provider Information</summary>
				Property PRV As Edi.Dom.Segments.PRV
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Place or Location</summary>
				Property PLA As Edi.Dom.Segments.PLA
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2320
				Inherits ILoop
				'''<summary>Coordination of Benefits</summary>
				Property COB As Edi.Dom.Segments.COB
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop2330 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2330)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2330
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Additional Name Information</summary>
				Property N2 As Edi.Dom.Segments.N2
				'''<summary>Party Location</summary>
				ReadOnly Property N3 As SegmentContainer(Of Edi.Dom.Segments.N3)
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Administrative Communications Contact</summary>
				Property PER As Edi.Dom.Segments.PER
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2400
				Inherits ILoop
				'''<summary>Life Coverage</summary>
				Property LC As Edi.Dom.Segments.LC
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Beneficiary or Owner Information</summary>
				ReadOnly Property Loop2410 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2410)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2410
				Inherits ILoop
				'''<summary>Beneficiary or Owner Information</summary>
				Property BEN As Edi.Dom.Segments.BEN
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Party Identification</summary>
				Property N1 As Edi.Dom.Segments.N1
				'''<summary>Additional Name Information</summary>
				Property N2 As Edi.Dom.Segments.N2
				'''<summary>Party Location</summary>
				Property N3 As Edi.Dom.Segments.N3
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Demographic Information</summary>
				Property DMG As Edi.Dom.Segments.DMG
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2500
				Inherits ILoop
				'''<summary>Flexible Spending Account</summary>
				Property FSA As Edi.Dom.Segments.FSA
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2600
				Inherits ILoop
				'''<summary>Retirement Product</summary>
				Property RP As Edi.Dom.Segments.RP
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Investment Vehicle Selection</summary>
				ReadOnly Property INV As SegmentContainer(Of Edi.Dom.Segments.INV)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>Quantity Information</summary>
				ReadOnly Property QTY As SegmentContainer(Of Edi.Dom.Segments.QTY)
				'''<summary>File Information</summary>
				ReadOnly Property K3 As SegmentContainer(Of Edi.Dom.Segments.K3)
				'''<summary>Relationship</summary>
				Property REL As Edi.Dom.Segments.REL
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop2610 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2610)
				'''<summary>Financial Contribution</summary>
				ReadOnly Property Loop2630 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2630)
				'''<summary>Income</summary>
				ReadOnly Property Loop2650 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2650)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2610
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Edi.Dom.Segments.NM1
				'''<summary>Additional Name Information</summary>
				Property N2 As Edi.Dom.Segments.N2
				'''<summary>Demographic Information</summary>
				Property DMG As Edi.Dom.Segments.DMG
				'''<summary>Beneficiary or Owner Information</summary>
				Property BEN As Edi.Dom.Segments.BEN
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Property or Entity Identification</summary>
				ReadOnly Property Loop2620 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2620)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2620
				Inherits ILoop
				'''<summary>Property or Entity Identification</summary>
				Property NX1 As Edi.Dom.Segments.NX1
				'''<summary>Party Location</summary>
				Property N3 As Edi.Dom.Segments.N3
				'''<summary>Geographic Location</summary>
				Property N4 As Edi.Dom.Segments.N4
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2630
				Inherits ILoop
				'''<summary>Financial Contribution</summary>
				Property FC As Edi.Dom.Segments.FC
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Investment Vehicle Selection</summary>
				ReadOnly Property Loop2640 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2640)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2640
				Inherits ILoop
				'''<summary>Investment Vehicle Selection</summary>
				Property INV As Edi.Dom.Segments.INV
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Edi.Dom.Segments.DTP)
				'''<summary>Quantity Information</summary>
				ReadOnly Property QTY As SegmentContainer(Of Edi.Dom.Segments.QTY)
				'''<summary>Entity</summary>
				ReadOnly Property ENT As SegmentContainer(Of Edi.Dom.Segments.ENT)
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Edi.Dom.Segments.REF)
				'''<summary>Monetary Amount Information</summary>
				ReadOnly Property AMT As SegmentContainer(Of Edi.Dom.Segments.AMT)
				'''<summary>File Information</summary>
				ReadOnly Property K3 As SegmentContainer(Of Edi.Dom.Segments.K3)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2650
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
			Public Interface Loop2700
				Inherits ILoop
				'''<summary>Transaction Set Line Number</summary>
				Property LX As Edi.Dom.Segments.LX
				'''<summary>Party Identification</summary>
				ReadOnly Property Loop2750 As LoopContainer(Of Edi.Dom.Transactions.Transaction834.Loops.Loop2750)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2750
				Inherits ILoop
				'''<summary>Party Identification</summary>
				Property N1 As Edi.Dom.Segments.N1
				'''<summary>Reference Information</summary>
				Property REF As Edi.Dom.Segments.REF
				'''<summary>Date or Time or Period</summary>
				Property DTP As Edi.Dom.Segments.DTP
			End Interface

		End Namespace 'Loops


		Namespace Transaction834_A1
			Namespace Segments

				Namespace Loop1000A

					'''<summary>Sponsor Name</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Plan Sponsor Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Sponsor Identifier</summary>
						Property N104 As String
					End Interface
				End Namespace 'Loop1000A

				Namespace Loop1000B

					'''<summary>Payer</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Insurer Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>Insurer Identification Code</summary>
						Property N104 As String
					End Interface
				End Namespace 'Loop1000B

				Namespace Loop1000C

					'''<summary>TPA/Broker Name</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>TPA or Broker Name</summary>
						Property N102 As String
						'''<summary>Identification Code Qualifier</summary>
						Property N103 As String
						'''<summary>TPA or Broker Identification Code</summary>
						Property N104 As String
					End Interface
				End Namespace 'Loop1000C

				Namespace Loop1100C

					'''<summary>TPA/Broker Account Information</summary>
					Public Interface ACT
						Inherits ISegment

						'''<summary>TPA or Broker Account Number</summary>
						Property ACT01 As String
						'''<summary>TPA or Broker Account Number</summary>
						Property ACT06 As String
					End Interface
				End Namespace 'Loop1100C

				Namespace Loop2000

					'''<summary>Member Level Detail</summary>
					Public Interface INS
						Inherits ISegment

						'''<summary>Member Indicator</summary>
						Property INS01 As String
						'''<summary>The value 18 must be used for the subscriber.;</summary>
						Property INS02 As String
						'''<summary>Maintenance Type Code</summary>
						Property INS03 As String
						'''<summary>Maintenance Reason Code</summary>
						Property INS04 As String
						'''<summary>Benefit Status Code</summary>
						Property INS05 As String
						'''<summary></summary>
						Property INS06 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052
						'''<summary>Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code</summary>
						Property INS07 As String
						'''<summary>Employment Status Code</summary>
						Property INS08 As String
						'''<summary>Student Status Code</summary>
						Property INS09 As String
						'''<summary>Handicap Indicator</summary>
						Property INS10 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property INS11 As String
						'''<summary>Member Individual Death Date</summary>
						Property INS12 As String
						'''<summary>Confidentiality Code</summary>
						Property INS13 As String
						'''<summary>Birth Sequence Number</summary>
						Property INS17 As Decimal?
					End Interface
					'''<summary>Subscriber Identifier</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Subscriber Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Member Policy Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Member Group or Policy Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Member Supplemental Identifier</summary>
					Public Interface REF_2
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Member Supplemental Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Member Level Dates</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Status Information Effective Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Additional Reporting Categories</summary>
					Public Interface LS
						Inherits ISegment

						'''<summary>Loop Identifier Code</summary>
						Property LS01 As String
					End Interface
					'''<summary>Additional Reporting Categories Loop Termination</summary>
					Public Interface LE
						Inherits ISegment

						'''<summary>Loop Identifier Code</summary>
						Property LE01 As String
					End Interface
				End Namespace 'Loop2000

				Namespace Loop2100A

					'''<summary>Member Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Member Last Name</summary>
						Property NM103 As String
						'''<summary>Member First Name</summary>
						Property NM104 As String
						'''<summary>Member Middle Name</summary>
						Property NM105 As String
						'''<summary>Member Name Prefix</summary>
						Property NM106 As String
						'''<summary>Member Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Member Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Member Communications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
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
					'''<summary>Member Residence Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Member Address Line</summary>
						Property N301 As String
						'''<summary>Member Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Member City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Member City Name</summary>
						Property N401 As String
						'''<summary>Member State Code</summary>
						Property N402 As String
						'''<summary>Member Postal Zone or Zip Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Location Qualifier</summary>
						Property N405 As String
						'''<summary>Location Identifier</summary>
						Property N406 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Member Demographics</summary>
					Public Interface DMG
						Inherits ISegment

						'''<summary>Date Time Period Format Qualifier</summary>
						Property DMG01 As String
						'''<summary>Member Birth Date</summary>
						Property DMG02 As String
						'''<summary>Gender Code</summary>
						Property DMG03 As String
						'''<summary>Marital Status Code</summary>
						Property DMG04 As String
						'''<summary></summary>
						Property DMG05 As Edi.Dom.DataElements.Composite.C056
						'''<summary>Citizenship Status Code</summary>
						Property DMG06 As String
						'''<summary>Code List Qualifier Code</summary>
						Property DMG10 As String
						'''<summary>Race or Ethnicity Collection Code</summary>
						Property DMG11 As String
					End Interface
					'''<summary>Employment Class</summary>
					Public Interface EC
						Inherits ISegment

						'''<summary>Employment Class Code</summary>
						Property EC01 As String
						'''<summary>Employment Class Code</summary>
						Property EC02 As String
						'''<summary>Employment Class Code</summary>
						Property EC03 As String
					End Interface
					'''<summary>Member Income</summary>
					Public Interface ICM
						Inherits ISegment

						'''<summary>Frequency Code</summary>
						Property ICM01 As String
						'''<summary>Wage Amount</summary>
						Property ICM02 As Decimal?
						'''<summary>Work Hours Count</summary>
						Property ICM03 As Decimal?
						'''<summary>Location Identification Code</summary>
						Property ICM04 As String
						'''<summary>Salary Grade Code</summary>
						Property ICM05 As String
					End Interface
					'''<summary>Member Policy Amounts</summary>
					Public Interface AMT
						Inherits ISegment

						'''<summary>Amount Qualifier Code</summary>
						Property AMT01 As String
						'''<summary>Contract Amount</summary>
						Property AMT02 As Decimal?
					End Interface
					'''<summary>Member Health Information</summary>
					Public Interface HLH
						Inherits ISegment

						'''<summary>Health Related Code</summary>
						Property HLH01 As String
						'''<summary>Member Height</summary>
						Property HLH02 As Decimal?
						'''<summary>Member Weight</summary>
						Property HLH03 As Decimal?
					End Interface
					'''<summary>Member Language</summary>
					Public Interface LUI
						Inherits ISegment

						'''<summary>Identification Code Qualifier</summary>
						Property LUI01 As String
						'''<summary>Language Code</summary>
						Property LUI02 As String
						'''<summary>Language Description</summary>
						Property LUI03 As String
						'''<summary>Language Use Indicator</summary>
						Property LUI04 As String
					End Interface
				End Namespace 'Loop2100A

				Namespace Loop2100B

					'''<summary>Incorrect Member Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Prior Incorrect Member Last Name</summary>
						Property NM103 As String
						'''<summary>Prior Incorrect Member First Name</summary>
						Property NM104 As String
						'''<summary>Prior Incorrect Member Middle Name</summary>
						Property NM105 As String
						'''<summary>Prior Incorrect Member Name Prefix</summary>
						Property NM106 As String
						'''<summary>Prior Incorrect Member Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Prior Incorrect Insured Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Incorrect Member Demographics</summary>
					Public Interface DMG
						Inherits ISegment

						'''<summary>Date Time Period Format Qualifier</summary>
						Property DMG01 As String
						'''<summary>Prior Incorrect Insured Birth Date</summary>
						Property DMG02 As String
						'''<summary>Prior Incorrect Insured Gender Code</summary>
						Property DMG03 As String
						'''<summary>Marital Status Code</summary>
						Property DMG04 As String
						'''<summary></summary>
						Property DMG05 As Edi.Dom.DataElements.Composite.C056
						'''<summary>Citizenship Status Code</summary>
						Property DMG06 As String
						'''<summary>Code List Qualifier Code</summary>
						Property DMG10 As String
						'''<summary>Race or Ethnicity Collection Code</summary>
						Property DMG11 As String
					End Interface
				End Namespace 'Loop2100B

				Namespace Loop2100C

					'''<summary>Member Mailing Address</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
					End Interface
					'''<summary>Member Mail Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Member Address Line</summary>
						Property N301 As String
						'''<summary>Member Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Member Mail City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Member Mail City Name</summary>
						Property N401 As String
						'''<summary>Member Mail State Code</summary>
						Property N402 As String
						'''<summary>Member Mail Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100C

				Namespace Loop2100D

					'''<summary>Member Employer</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Member Employer Name</summary>
						Property NM103 As String
						'''<summary>Member Employer First Name</summary>
						Property NM104 As String
						'''<summary>Member Employer Middle Name</summary>
						Property NM105 As String
						'''<summary>Member Employer Name Prefix</summary>
						Property NM106 As String
						'''<summary>Member Employer Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Member Employer Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Member Employer Communications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Member Employer Communications Contact Name</summary>
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
					'''<summary>Member Employer Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Member Employer Address Line</summary>
						Property N301 As String
						'''<summary>Member Employer Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Member Employer City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Member Employer City Name</summary>
						Property N401 As String
						'''<summary>Member Employer State Code</summary>
						Property N402 As String
						'''<summary>Member Employer Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100D

				Namespace Loop2100E

					'''<summary>Member School</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>School Name</summary>
						Property NM103 As String
					End Interface
					'''<summary>Member School Commmunications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Member School Communications Contact Name</summary>
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
					'''<summary>Member School Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>School Address Line</summary>
						Property N301 As String
						'''<summary>School Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Member School City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Member School City Name</summary>
						Property N401 As String
						'''<summary>Member School State Code</summary>
						Property N402 As String
						'''<summary>Member School Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100E

				Namespace Loop2100F

					'''<summary>Custodial Parent</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Custodial Parent Last Name</summary>
						Property NM103 As String
						'''<summary>Custodial Parent First Name</summary>
						Property NM104 As String
						'''<summary>Custodial Parent Middle Name</summary>
						Property NM105 As String
						'''<summary>Custodial Parent Name Prefix</summary>
						Property NM106 As String
						'''<summary>Custodial Parent Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Custodial Parent Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Custodial Parent Communications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
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
					'''<summary>Custodial Parent Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Custodial Parent Address Line</summary>
						Property N301 As String
						'''<summary>Custodial Parent Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Custodial Parent City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Custodial Parent City Name</summary>
						Property N401 As String
						'''<summary>Custodial Parent State Code</summary>
						Property N402 As String
						'''<summary>Custodial Parent Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100F

				Namespace Loop2100G

					'''<summary>Responsible Person</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Responsible Party Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Responsible Party First Name</summary>
						Property NM104 As String
						'''<summary>Responsible Party Middle Name</summary>
						Property NM105 As String
						'''<summary>Responsible Party Name Prefix</summary>
						Property NM106 As String
						'''<summary>Responsible Party Suffix Name</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Responsible Party Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Responsible Person Communications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
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
					'''<summary>Responsible Person Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Responsible Party Address Line</summary>
						Property N301 As String
						'''<summary>Responsible Party Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Responsible Person City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Responsible Person City Name</summary>
						Property N401 As String
						'''<summary>Responsible Person State Code</summary>
						Property N402 As String
						'''<summary>Responsible Person Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100G

				Namespace Loop2100H

					'''<summary>Drop Off Location</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Name Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Name First</summary>
						Property NM104 As String
						'''<summary>Name Middle</summary>
						Property NM105 As String
						'''<summary>Name Prefix</summary>
						Property NM106 As String
						'''<summary>Name Suffix</summary>
						Property NM107 As String
					End Interface
					'''<summary>Drop Off Location Street Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Drop Off Location Address Line</summary>
						Property N301 As String
						'''<summary>Drop Off Location Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Drop Off Location City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Drop Off Location City Name</summary>
						Property N401 As String
						'''<summary>Drop Off Location State Code</summary>
						Property N402 As String
						'''<summary>Drop Off Location Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
				End Namespace 'Loop2100H

				Namespace Loop2200

					'''<summary>Disability Information</summary>
					Public Interface DSB
						Inherits ISegment

						'''<summary>Disability Type Code</summary>
						Property DSB01 As String
						'''<summary>Product or Service ID Qualifier</summary>
						Property DSB07 As String
						'''<summary>Diagnosis Code</summary>
						Property DSB08 As String
					End Interface
					'''<summary>Disability Eligibility Dates</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Disability Eligibility Date</summary>
						Property DTP03 As String
					End Interface
				End Namespace 'Loop2200

				Namespace Loop2300

					'''<summary>Health Coverage</summary>
					Public Interface HD
						Inherits ISegment

						'''<summary>Maintenance Type Code</summary>
						Property HD01 As String
						'''<summary>Insurance Line Code</summary>
						Property HD03 As String
						'''<summary>Plan Coverage Description</summary>
						Property HD04 As String
						'''<summary>Coverage Level Code</summary>
						Property HD05 As String
						'''<summary>Late Enrollment Indicator</summary>
						Property HD09 As String
					End Interface
					'''<summary>Health Coverage Dates</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Coverage Period</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Health Coverage Policy</summary>
					Public Interface AMT
						Inherits ISegment

						'''<summary>Amount Qualifier Code</summary>
						Property AMT01 As String
						'''<summary>Contract Amount</summary>
						Property AMT02 As Decimal?
					End Interface
					'''<summary>Health Coverage Policy Number</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Member Group or Policy Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Prior Coverage Months</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Indicator identifying the number of prior months insurance coverage that may apply under the portability provisions of the Health Insurance Portability and Accountability Act.</summary>
						Property REF02 As String
					End Interface
					'''<summary>Identification Card</summary>
					Public Interface IDC
						Inherits ISegment

						'''<summary>Plan Coverage Description</summary>
						Property IDC01 As String
						'''<summary>This code is used to identify that the card issued will be specific to the coverage identified in the related HD segment.</summary>
						Property IDC02 As String
						'''<summary>Identification Card Count</summary>
						Property IDC03 As Decimal?
						'''<summary>Action Code</summary>
						Property IDC04 As String
					End Interface
				End Namespace 'Loop2300

				Namespace Loop2310

					'''<summary>Provider Information</summary>
					Public Interface LX
						Inherits ISegment

						'''<summary>Assigned Number</summary>
						Property LX01 As Decimal?
					End Interface
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
						'''<summary>Provider Name Prefix</summary>
						Property NM106 As String
						'''<summary>Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Provider Identifier</summary>
						Property NM109 As String
						'''<summary>This element indicates whether or not the member is an existing patient of the provider.</summary>
						Property NM110 As String
					End Interface
					'''<summary>Provider Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Provider Address Line</summary>
						Property N301 As String
						'''<summary>Provider Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Provider City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Provider City Name</summary>
						Property N401 As String
						'''<summary>Provider State Code</summary>
						Property N402 As String
						'''<summary>Provider Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Provider Communications Numbers</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
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
					'''<summary>Provider Change Reason</summary>
					Public Interface PLA
						Inherits ISegment

						'''<summary>Action Code</summary>
						Property PLA01 As String
						'''<summary>Entity Identifier Code</summary>
						Property PLA02 As String
						'''<summary>This is the effective date of the change of PCP.</summary>
						Property PLA03 As Date?
						'''<summary>If none of the specific Maintenance Reasons apply, send 'AI', No Reason Given.</summary>
						Property PLA05 As String
					End Interface
				End Namespace 'Loop2310

				Namespace Loop2320

					'''<summary>Coordination of Benefits</summary>
					Public Interface COB
						Inherits ISegment

						'''<summary>Payer Responsibility Sequence Number Code</summary>
						Property COB01 As String
						'''<summary>Member Group or Policy Number</summary>
						Property COB02 As String
						'''<summary>Coordination of Benefits Code</summary>
						Property COB03 As String
						'''<summary>Service Type Code</summary>
						Property COB04 As String
					End Interface
					'''<summary>Additional Coordination of Benefits Identifiers</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Member Group or Policy Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Coordination of Benefits Eligibility Dates</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Coordination of Benefits Date</summary>
						Property DTP03 As String
					End Interface
				End Namespace 'Loop2320

				Namespace Loop2330

					'''<summary>Coordination of Benefits Related Entity</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Coordination of Benefits Insurer Name</summary>
						Property NM103 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Coordination of Benefits Insurer Identification Code</summary>
						Property NM109 As String
					End Interface
					'''<summary>Coordination of Benefits Related Entity Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Address Information</summary>
						Property N301 As String
						'''<summary>Address Information</summary>
						Property N302 As String
					End Interface
					'''<summary>Coordination of Benefits Other Insurance Company City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Coordination of Benefits Other Insurance Company City Name</summary>
						Property N401 As String
						'''<summary>Coordination of Benefits Other Insurance Company State Code</summary>
						Property N402 As String
						'''<summary>Coordination of Benefits Other Insurance Company Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Administrative Communications Contact</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Communication Number</summary>
						Property PER04 As String
					End Interface
				End Namespace 'Loop2330

				Namespace Loop2700

					'''<summary>Member Reporting Categories</summary>
					Public Interface LX
						Inherits ISegment

						'''<summary>Assigned Number</summary>
						Property LX01 As Decimal?
					End Interface
				End Namespace 'Loop2700

				Namespace Loop2750

					'''<summary>Reporting Category</summary>
					Public Interface N1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property N101 As String
						'''<summary>Member Reporting Category Name</summary>
						Property N102 As String
					End Interface
					'''<summary>Reporting Category Reference</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Member Reporting Category Reference ID</summary>
						Property REF02 As String
					End Interface
					'''<summary>Reporting Category Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Member Reporting Category Effective Date(s)</summary>
						Property DTP03 As String
					End Interface
				End Namespace 'Loop2750

				'''<summary>Transaction Set Header</summary>
				Public Interface ST
					Inherits ISegment

					'''<summary>Transaction Set Identifier Code</summary>
					Property ST01 As String
					'''<summary>The Transaction Set Control Number in ST02 and SE02 must be identical. The number must be unique within a specific interchange (ISA-IEA), but can repeat in other interchanges.</summary>
					Property ST02 As String
					'''<summary>This element must be populated with the guide identifier named in Section 1.2.</summary>
					Property ST03 As String
				End Interface
				'''<summary>Beginning Segment</summary>
				Public Interface BGN
					Inherits ISegment

					'''<summary>Transaction Set Purpose Code</summary>
					Property BGN01 As String
					'''<summary>This element is the transaction set reference number assigned by the sender's application. It uniquely identifies this occurrence of the transaction for future reference.</summary>
					Property BGN02 As String
					'''<summary>This element identifies the date that the submitter created the file.</summary>
					Property BGN03 As Date?
					'''<summary>This element is used as a time stamp to uniquely identify the transmission.</summary>
					Property BGN04 As TimeSpan?
					'''<summary>Time Zone Code</summary>
					Property BGN05 As String
					'''<summary>Original Transaction Set Reference Number</summary>
					Property BGN06 As String
					'''<summary>Action Code</summary>
					Property BGN08 As String
				End Interface
				'''<summary>Transaction Set Policy Number</summary>
				Public Interface REF
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>Master Policy Number</summary>
					Property REF02 As String
				End Interface
				'''<summary>File Effective Date</summary>
				Public Interface DTP
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTP01 As String
					'''<summary>Date Time Period Format Qualifier</summary>
					Property DTP02 As String
					'''<summary>Date Time Period</summary>
					Property DTP03 As String
				End Interface
				'''<summary>Transaction Set Control Totals</summary>
				Public Interface QTY
					Inherits ISegment

					'''<summary>Quantity Qualifier</summary>
					Property QTY01 As String
					'''<summary>Record Totals</summary>
					Property QTY02 As Decimal?
				End Interface
				'''<summary>Transaction Set Trailer</summary>
				Public Interface SE
					Inherits ISegment

					'''<summary>Transaction Segment Count</summary>
					Property SE01 As Decimal?
					'''<summary>The transaction set control numbers in ST02 and SE02 must be identical. This unique number also aids in error resolution research. For example, start with the number 0001 and increment from there. This number must be unique within a specific group and interchange, but the number can repeat in other groups and interchanges.</summary>
					Property SE02 As String
				End Interface
			End Namespace 'Segments

			Namespace Composites
				Namespace Loop2000.INS.INS_06
					'''<summary></summary>
					Public Interface C052
						'''<summary>Medicare Plan Code</summary>
						Property C052_01 As String
						'''<summary>Medicare Eligibility Reason Code</summary>
						Property C052_02 As String
					End Interface
				End Namespace
			End Namespace 'Composites

			Namespace Loops
				'''<summary>Sponsor Name</summary>
				Public Interface Loop1000A
					Inherits ILoop


					'''<summary>Sponsor Name</summary>
					Property N1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1
				End Interface
				'''<summary>Payer</summary>
				Public Interface Loop1000B
					Inherits ILoop


					'''<summary>Payer</summary>
					Property N1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1
				End Interface
				'''<summary>TPA/Broker Name</summary>
				Public Interface Loop1000C
					Inherits ILoop


					'''<summary>TPA/Broker Name</summary>
					Property N1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1

					'''<summary>TPA/Broker Account Information</summary>
					Property Loop1100C As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C
				End Interface
				'''<summary>TPA/Broker Account Information</summary>
				Public Interface Loop1100C
					Inherits ILoop


					'''<summary>TPA/Broker Account Information</summary>
					Property ACT As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT
				End Interface
				'''<summary>Member Level Detail</summary>
				Public Interface Loop2000
					Inherits ILoop


					'''<summary>Member Level Detail</summary>
					Property INS As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS

					'''<summary>Subscriber Identifier</summary>
					Property REF As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF

					'''<summary>Member Policy Number</summary>
					Property REF_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1

					'''<summary>Member Supplemental Identifier</summary>
					ReadOnly Property REF_2 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2, Edi.Dom.Segments.REF)

					'''<summary>Member Level Dates</summary>
					ReadOnly Property DTP As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP, Edi.Dom.Segments.DTP)

					'''<summary>Member Name</summary>
					Property Loop2100A As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A

					'''<summary>Incorrect Member Name</summary>
					Property Loop2100B As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B

					'''<summary>Member Mailing Address</summary>
					Property Loop2100C As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C

					'''<summary>Member Employer</summary>
					ReadOnly Property Loop2100D As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)

					'''<summary>Member School</summary>
					ReadOnly Property Loop2100E As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)

					'''<summary>Custodial Parent</summary>
					Property Loop2100F As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F

					'''<summary>Responsible Person</summary>
					ReadOnly Property Loop2100G As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G, Edi.Dom.Transactions.Transaction834.Loops.Loop2100)

					'''<summary>Drop Off Location</summary>
					Property Loop2100H As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H

					'''<summary>Disability Information</summary>
					ReadOnly Property Loop2200 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200, Edi.Dom.Transactions.Transaction834.Loops.Loop2200)

					'''<summary>Health Coverage</summary>
					ReadOnly Property Loop2300 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300, Edi.Dom.Transactions.Transaction834.Loops.Loop2300)

					'''<summary>Additional Reporting Categories</summary>
					Property LS As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS

					'''<summary>Member Reporting Categories</summary>
					ReadOnly Property Loop2700 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700, Edi.Dom.Transactions.Transaction834.Loops.Loop2700)

					'''<summary>Additional Reporting Categories Loop Termination</summary>
					Property LE As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE
				End Interface
				'''<summary>Member Name</summary>
				Public Interface Loop2100A
					Inherits ILoop


					'''<summary>Member Name</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1

					'''<summary>Member Communications Numbers</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER

					'''<summary>Member Residence Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3

					'''<summary>Member City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4

					'''<summary>Member Demographics</summary>
					Property DMG As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG

					'''<summary>Employment Class</summary>
					ReadOnly Property EC As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC, Edi.Dom.Segments.EC)

					'''<summary>Member Income</summary>
					Property ICM As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM

					'''<summary>Member Policy Amounts</summary>
					ReadOnly Property AMT As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT, Edi.Dom.Segments.AMT)

					'''<summary>Member Health Information</summary>
					Property HLH As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH

					'''<summary>Member Language</summary>
					ReadOnly Property LUI As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI, Edi.Dom.Segments.LUI)
				End Interface
				'''<summary>Incorrect Member Name</summary>
				Public Interface Loop2100B
					Inherits ILoop


					'''<summary>Incorrect Member Name</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1

					'''<summary>Incorrect Member Demographics</summary>
					Property DMG As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG
				End Interface
				'''<summary>Member Mailing Address</summary>
				Public Interface Loop2100C
					Inherits ILoop


					'''<summary>Member Mailing Address</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1

					'''<summary>Member Mail Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3

					'''<summary>Member Mail City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4
				End Interface
				'''<summary>Member Employer</summary>
				Public Interface Loop2100D
					Inherits ILoop


					'''<summary>Member Employer</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1

					'''<summary>Member Employer Communications Numbers</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER

					'''<summary>Member Employer Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3

					'''<summary>Member Employer City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4
				End Interface
				'''<summary>Member School</summary>
				Public Interface Loop2100E
					Inherits ILoop


					'''<summary>Member School</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1

					'''<summary>Member School Commmunications Numbers</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER

					'''<summary>Member School Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3

					'''<summary>Member School City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4
				End Interface
				'''<summary>Custodial Parent</summary>
				Public Interface Loop2100F
					Inherits ILoop


					'''<summary>Custodial Parent</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1

					'''<summary>Custodial Parent Communications Numbers</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER

					'''<summary>Custodial Parent Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3

					'''<summary>Custodial Parent City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4
				End Interface
				'''<summary>Responsible Person</summary>
				Public Interface Loop2100G
					Inherits ILoop


					'''<summary>Responsible Person</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1

					'''<summary>Responsible Person Communications Numbers</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER

					'''<summary>Responsible Person Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3

					'''<summary>Responsible Person City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4
				End Interface
				'''<summary>Drop Off Location</summary>
				Public Interface Loop2100H
					Inherits ILoop


					'''<summary>Drop Off Location</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1

					'''<summary>Drop Off Location Street Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3

					'''<summary>Drop Off Location City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4
				End Interface
				'''<summary>Disability Information</summary>
				Public Interface Loop2200
					Inherits ILoop


					'''<summary>Disability Information</summary>
					Property DSB As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB

					'''<summary>Disability Eligibility Dates</summary>
					ReadOnly Property DTP As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP, Edi.Dom.Segments.DTP)
				End Interface
				'''<summary>Health Coverage</summary>
				Public Interface Loop2300
					Inherits ILoop


					'''<summary>Health Coverage</summary>
					Property HD As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD

					'''<summary>Health Coverage Dates</summary>
					ReadOnly Property DTP As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP, Edi.Dom.Segments.DTP)

					'''<summary>Health Coverage Policy</summary>
					ReadOnly Property AMT As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT, Edi.Dom.Segments.AMT)

					'''<summary>Health Coverage Policy Number</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF, Edi.Dom.Segments.REF)

					'''<summary>Prior Coverage Months</summary>
					Property REF_1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1

					'''<summary>Identification Card</summary>
					ReadOnly Property IDC As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC, Edi.Dom.Segments.IDC)

					'''<summary>Provider Information</summary>
					ReadOnly Property Loop2310 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310, Edi.Dom.Transactions.Transaction834.Loops.Loop2310)

					'''<summary>Coordination of Benefits</summary>
					ReadOnly Property Loop2320 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320, Edi.Dom.Transactions.Transaction834.Loops.Loop2320)
				End Interface
				'''<summary>Provider Information</summary>
				Public Interface Loop2310
					Inherits ILoop


					'''<summary>Provider Information</summary>
					Property LX As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX

					'''<summary>Provider Name</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1

					'''<summary>Provider Address</summary>
					ReadOnly Property N3 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3, Edi.Dom.Segments.N3)

					'''<summary>Provider City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4

					'''<summary>Provider Communications Numbers</summary>
					ReadOnly Property PER As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER, Edi.Dom.Segments.PER)

					'''<summary>Provider Change Reason</summary>
					Property PLA As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA
				End Interface
				'''<summary>Coordination of Benefits</summary>
				Public Interface Loop2320
					Inherits ILoop


					'''<summary>Coordination of Benefits</summary>
					Property COB As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB

					'''<summary>Additional Coordination of Benefits Identifiers</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF, Edi.Dom.Segments.REF)

					'''<summary>Coordination of Benefits Eligibility Dates</summary>
					ReadOnly Property DTP As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP, Edi.Dom.Segments.DTP)

					'''<summary>Coordination of Benefits Related Entity</summary>
					ReadOnly Property Loop2330 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330, Edi.Dom.Transactions.Transaction834.Loops.Loop2330)
				End Interface
				'''<summary>Coordination of Benefits Related Entity</summary>
				Public Interface Loop2330
					Inherits ILoop


					'''<summary>Coordination of Benefits Related Entity</summary>
					Property NM1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1

					'''<summary>Coordination of Benefits Related Entity Address</summary>
					Property N3 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3

					'''<summary>Coordination of Benefits Other Insurance Company City, State, ZIP Code</summary>
					Property N4 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4

					'''<summary>Administrative Communications Contact</summary>
					Property PER As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER
				End Interface
				'''<summary>Member Reporting Categories</summary>
				Public Interface Loop2700
					Inherits ILoop


					'''<summary>Member Reporting Categories</summary>
					Property LX As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX

					'''<summary>Reporting Category</summary>
					Property Loop2750 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750
				End Interface
				'''<summary>Reporting Category</summary>
				Public Interface Loop2750
					Inherits ILoop


					'''<summary>Reporting Category</summary>
					Property N1 As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1

					'''<summary>Reporting Category Reference</summary>
					Property REF As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF

					'''<summary>Reporting Category Date</summary>
					Property DTP As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP
				End Interface

			End Namespace 'Loops

			'''<summary>Benefit Enrollment and Maintenance</summary>
			'''<remarks>
			'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Benefit Enrollment and Maintenance Transaction Set (834) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to establish communication between the sponsor of the insurance product and the payer. Such transaction(s) may or may not take place through a third party administrator (TPA).<br /><br />For the purpose of this standard, the sponsor is the party or entity that ultimately pays for the coverage, benefit or product. A sponsor can be an employer, union, government agency, association, or insurance agency.<br /><br />The payer refers to an entity that pays claims, administers the insurance product or benefit, or both. A payer can be an insurance company, health maintenance organization (HMO), preferred provider organization (PPO), government agency (Medicare, Medicaid, Champus, etc.), or an entity that may be contracted by one of these former groups. For the purpose of the 834 transaction set, a third party administrator (TPA) can be contracted by a sponsor to handle data gathering from those covered by the sponsor if the sponsor does not elect to perform this function itself.</para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary>Transaction Set Header</summary>
				Property ST As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST

				'''<summary>Beginning Segment</summary>
				Property BGN As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN

				'''<summary>Transaction Set Policy Number</summary>
				Property REF As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF

				'''<summary>File Effective Date</summary>
				ReadOnly Property DTP As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP, Edi.Dom.Segments.DTP)

				'''<summary>Transaction Set Control Totals</summary>
				ReadOnly Property QTY As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY, Edi.Dom.Segments.QTY)

				'''<summary>Sponsor Name</summary>
				Property Loop1000A As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A

				'''<summary>Payer</summary>
				Property Loop1000B As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B

				'''<summary>TPA/Broker Name</summary>
				ReadOnly Property Loop1000C As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C, Edi.Dom.Transactions.Transaction834.Loops.Loop1000)

				'''<summary>Member Level Detail</summary>
				ReadOnly Property Loop2000 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000, Edi.Dom.Transactions.Transaction834.Loops.Loop2000)

				'''<summary>Transaction Set Trailer</summary>
				Property SE As Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE
			End Interface
		End Namespace 'Transaction834_A1
	End Namespace 'Transaction834
End Namespace 'Transaction834
