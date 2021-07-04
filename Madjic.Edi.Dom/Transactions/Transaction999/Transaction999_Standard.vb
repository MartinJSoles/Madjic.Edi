Namespace Transactions
	Namespace Transaction999

		Partial Friend Class Standard_Obj
			Inherits TransactionSet
			Implements Standard, Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet
			Friend Sub New(versionCode As String)
				Me.New(String.Empty, versionCode)
			End Sub

			Friend Sub New(controlNumber As String, versionCode As String)
				MyBase.New("FA", versionCode)

				Children.AddRange({New Edi.Dom.Segments.ST_Obj,
										CType(Nothing, Edi.Dom.Segments.AK1_Obj),
										New LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop1000)(0, "1", "0300"),
										CType(Nothing, Edi.Dom.Segments.AK9_Obj),
										New Edi.Dom.Segments.SE_Obj})

				ST_Obj.ST01 = "999"
				ST_Obj.ST02 = controlNumber
				ST_Obj.ST03 = versionCode

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "ST", ReadAction.PopulateSegment, 1, False),
						New ReaderState(1, "AK1", ReadAction.PopulateSegment, 2, False),
						New ReaderState(2, "AK2", ReadAction.PopulateLoop, 3, False),
						New ReaderState(3, "AK2", ReadAction.PopulateLoop, 3, False),
						New ReaderState(2, "AK9", ReadAction.PopulateSegment, 5, False),
						New ReaderState(3, "AK9", ReadAction.PopulateSegment, 5, False),
						New ReaderState(5, "SE", ReadAction.PopulateSegment, 6, False)})

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
					If MyBase.CompareKey(S2.ST01, ";999;") AndAlso String.Compare(args.Implementation, "_999", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = "1"
						Seg.SetSequence = "0100"
					End If
				ElseIf String.Compare(SegmentName, "AK1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AK1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AK1_Obj = Seg
				ElseIf String.Compare(SegmentName, "AK9", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AK9_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AK9_Obj = Seg
				ElseIf String.Compare(SegmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "AK2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction999.Loop1000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop1000_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_999", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_999__1000"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "0300"
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

			Private Property ST_Std As Edi.Dom.Segments.ST Implements Edi.Dom.Transactions.Transaction999.Standard.ST
				Get
					Return CType(Children(0), Edi.Dom.Segments.ST_Obj)
				End Get
				Set(value As Edi.Dom.Segments.ST)
					Children(0) = value
				End Set
			End Property

			Private Property ST_IFace_Transaction999 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST Implements Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet.ST
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Friend Property AK1_Obj As Edi.Dom.Segments.AK1_Obj
				Get
					Return CType(Children(1), Edi.Dom.Segments.AK1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK1_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property AK1_Std As Edi.Dom.Segments.AK1 Implements Edi.Dom.Transactions.Transaction999.Standard.AK1
				Get
					Return CType(Children(1), Edi.Dom.Segments.AK1_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK1)
					Children(1) = value
				End Set
			End Property

			Private Property AK1_IFace_Transaction999 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1 Implements Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet.AK1
				Get
					Return CType(Children(1), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property Loop1000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction999.Standard.Loop1000
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop1000))
				End Get
			End Property

			Private Loop1000Subset_Transaction999 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000, Edi.Dom.Transactions.Transaction999.Loops.Loop1000)
			Private ReadOnly Property Loop1000_Obj_1_Transaction999 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000, Edi.Dom.Transactions.Transaction999.Loops.Loop1000) Implements Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet.Loop1000
				Get
					If Loop1000Subset_Transaction999 Is Nothing Then
						Loop1000Subset_Transaction999 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000, Edi.Dom.Transactions.Transaction999.Loops.Loop1000)(Children(2), 0, "1", "0300")
					End If

					Return Loop1000Subset_Transaction999
				End Get
			End Property
			Friend Property AK9_Obj As Edi.Dom.Segments.AK9_Obj
				Get
					Return CType(Children(3), Edi.Dom.Segments.AK9_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK9_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property AK9_Std As Edi.Dom.Segments.AK9 Implements Edi.Dom.Transactions.Transaction999.Standard.AK9
				Get
					Return CType(Children(3), Edi.Dom.Segments.AK9_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK9)
					Children(3) = value
				End Set
			End Property

			Private Property AK9_IFace_Transaction999 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9 Implements Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet.AK9
				Get
					Return CType(Children(3), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9)
					Children(3) = value
				End Set
			End Property
			Friend Property SE_Obj As Edi.Dom.Segments.SE_Obj
				Get
					Return CType(Children(4), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property SE_Std As Edi.Dom.Segments.SE Implements Edi.Dom.Transactions.Transaction999.Standard.SE
				Get
					Return CType(Children(4), Edi.Dom.Segments.SE_Obj)
				End Get
				Set(value As Edi.Dom.Segments.SE)
					Children(4) = value
				End Set
			End Property

			Private Property SE_IFace_Transaction999 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE Implements Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet.SE
				Get
					Return CType(Children(4), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE)
					Children(4) = value
				End Set
			End Property
		End Class

		Partial Friend Class Loop1000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction999.Loops.Loop1000,
								Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.AK2_Obj),
											New LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop2000)(0, "1", "0400"),
											CType(Nothing, Edi.Dom.Segments.IK5_Obj)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "AK2", ReadAction.PopulateSegment, 1, False),
							New ReaderState(1, "IK3", ReadAction.PopulateLoop, 2, False),
							New ReaderState(2, "IK3", ReadAction.PopulateLoop, 2, False),
							New ReaderState(1, "IK5", ReadAction.PopulateSegment, 4, False),
							New ReaderState(2, "IK5", ReadAction.PopulateSegment, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "AK2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.AK2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AK2_Obj = Seg
				ElseIf String.Compare(SegmentName, "IK5", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IK5_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IK5_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "IK3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction999.Loop2000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2000_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_999__1000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_999__1000__2000"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "0400"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property AK2_Obj As Edi.Dom.Segments.AK2_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.AK2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK2_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property AK2_Std As Edi.Dom.Segments.AK2 Implements Edi.Dom.Transactions.Transaction999.Loops.Loop1000.AK2
				Get
					Return CType(Children(0), Edi.Dom.Segments.AK2_Obj)
				End Get
				Set(value As Edi.Dom.Segments.AK2)
					Children(0) = value
				End Set
			End Property

			Private Property AK2_IFace_Loop1000_Obj_1 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2 Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000.AK2
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction999.Loops.Loop1000.Loop2000
				Get
					Return CType(Children(1), LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop2000))
				End Get
			End Property

			Private Loop2000Subset_Loop1000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000, Edi.Dom.Transactions.Transaction999.Loops.Loop2000)
			Private ReadOnly Property Loop2000_Obj_1_Loop1000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000, Edi.Dom.Transactions.Transaction999.Loops.Loop2000) Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000.Loop2000
				Get
					If Loop2000Subset_Loop1000_Obj_1 Is Nothing Then
						Loop2000Subset_Loop1000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000, Edi.Dom.Transactions.Transaction999.Loops.Loop2000)(Children(1), 0, "1", "0400")
					End If

					Return Loop2000Subset_Loop1000_Obj_1
				End Get
			End Property
			Friend Property IK5_Obj As Edi.Dom.Segments.IK5_Obj
				Get
					Return CType(Children(2), Edi.Dom.Segments.IK5_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK5_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property IK5_Std As Edi.Dom.Segments.IK5 Implements Edi.Dom.Transactions.Transaction999.Loops.Loop1000.IK5
				Get
					Return CType(Children(2), Edi.Dom.Segments.IK5_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK5)
					Children(2) = value
				End Set
			End Property

			Private Property IK5_IFace_Loop1000_Obj_1 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5 Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000.IK5
				Get
					Return CType(Children(2), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5)
					Children(2) = value
				End Set
			End Property

		End Class
		Partial Friend Class Loop2000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction999.Loops.Loop2000,
								Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.IK3_Obj),
											New SegmentContainer(Of Edi.Dom.Segments.CTX)(10, "1", "0500"),
											New LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop3000)(0, "1", "0600")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "IK3", ReadAction.PopulateSegment, 1, False),
							New ReaderState(1, "CTX", ReadAction.PopulateSegment, 2, False),
							New ReaderState(2, "CTX", ReadAction.PopulateSegment, 2, False),
							New ReaderState(1, "IK4", ReadAction.PopulateLoop, 4, False),
							New ReaderState(2, "IK4", ReadAction.PopulateLoop, 4, False),
							New ReaderState(4, "IK4", ReadAction.PopulateLoop, 4, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "IK3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IK3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IK3_Obj = Seg
				ElseIf String.Compare(SegmentName, "CTX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.CTX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CTX_Obj.Add(Seg)
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "IK4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Edi.Dom.Transactions.Transaction999.Loop3000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop3000_Obj.Add(NewLoop)
					If String.Compare(args.Implementation, "_999__1000__2000", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_999__1000__2000__3000"
						NewLoop.SetArea = "1"
						NewLoop.SetSequence = "0600"
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property IK3_Obj As Edi.Dom.Segments.IK3_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.IK3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK3_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property IK3_Std As Edi.Dom.Segments.IK3 Implements Edi.Dom.Transactions.Transaction999.Loops.Loop2000.IK3
				Get
					Return CType(Children(0), Edi.Dom.Segments.IK3_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK3)
					Children(0) = value
				End Set
			End Property

			Private Property IK3_IFace_Loop2000_Obj_1 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3 Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000.IK3
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property CTX_Obj As SegmentContainer(Of Edi.Dom.Segments.CTX) Implements Edi.Dom.Transactions.Transaction999.Loops.Loop2000.CTX
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.CTX))
				End Get
			End Property

			Private CTXSubset_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX, Edi.Dom.Segments.CTX)
			Private ReadOnly Property CTX_Loop2000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX, Edi.Dom.Segments.CTX) Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000.CTX
				Get
					If CTXSubset_Loop2000_Obj_1 Is Nothing Then
						CTXSubset_Loop2000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX, Edi.Dom.Segments.CTX)(Children(1), 10, "1", "0500")
					End If

					Return CTXSubset_Loop2000_Obj_1
				End Get
			End Property
			Friend ReadOnly Property Loop3000_Obj As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop3000) Implements Edi.Dom.Transactions.Transaction999.Loops.Loop2000.Loop3000
				Get
					Return CType(Children(2), LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop3000))
				End Get
			End Property

			Private Loop3000Subset_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000, Edi.Dom.Transactions.Transaction999.Loops.Loop3000)
			Private ReadOnly Property Loop3000_Obj_1_Loop2000_Obj_1 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000, Edi.Dom.Transactions.Transaction999.Loops.Loop3000) Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000.Loop3000
				Get
					If Loop3000Subset_Loop2000_Obj_1 Is Nothing Then
						Loop3000Subset_Loop2000_Obj_1 = New LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000, Edi.Dom.Transactions.Transaction999.Loops.Loop3000)(Children(2), 0, "1", "0600")
					End If

					Return Loop3000Subset_Loop2000_Obj_1
				End Get
			End Property

		End Class
		Partial Friend Class Loop3000_Obj
			Inherits LoopBase
			Implements Edi.Dom.Transactions.Transaction999.Loops.Loop3000,
								Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Edi.Dom.Segments.IK4_Obj),
											New SegmentContainer(Of Edi.Dom.Segments.CTX)(10, "1", "0700")})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "IK4", ReadAction.PopulateSegment, 1, False),
							New ReaderState(1, "CTX", ReadAction.PopulateSegment, 2, False),
							New ReaderState(2, "CTX", ReadAction.PopulateSegment, 2, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(SegmentName, "IK4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.IK4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					IK4_Obj = Seg
				ElseIf String.Compare(SegmentName, "CTX", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Edi.Dom.Segments.CTX_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CTX_Obj.Add(Seg)
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Return Task.CompletedTask
			End Function
			Friend Property IK4_Obj As Edi.Dom.Segments.IK4_Obj
				Get
					Return CType(Children(0), Edi.Dom.Segments.IK4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK4_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property IK4_Std As Edi.Dom.Segments.IK4 Implements Edi.Dom.Transactions.Transaction999.Loops.Loop3000.IK4
				Get
					Return CType(Children(0), Edi.Dom.Segments.IK4_Obj)
				End Get
				Set(value As Edi.Dom.Segments.IK4)
					Children(0) = value
				End Set
			End Property

			Private Property IK4_IFace_Loop3000_Obj_1 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4 Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000.IK4
				Get
					Return CType(Children(0), Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4)
				End Get
				Set(value As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property CTX_Obj As SegmentContainer(Of Edi.Dom.Segments.CTX) Implements Edi.Dom.Transactions.Transaction999.Loops.Loop3000.CTX
				Get
					Return CType(Children(1), SegmentContainer(Of Edi.Dom.Segments.CTX))
				End Get
			End Property

			Private CTXSubset_Loop3000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX, Edi.Dom.Segments.CTX)
			Private ReadOnly Property CTX_Loop3000_Obj_1 As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX, Edi.Dom.Segments.CTX) Implements Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000.CTX
				Get
					If CTXSubset_Loop3000_Obj_1 Is Nothing Then
						CTXSubset_Loop3000_Obj_1 = New SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX, Edi.Dom.Segments.CTX)(Children(1), 10, "1", "0700")
					End If

					Return CTXSubset_Loop3000_Obj_1
				End Get
			End Property

		End Class
		'''<summary>Implementation Acknowledgment</summary>
		'''<remarks></remarks>
		Public Interface Standard
			'''<summary>Transaction Set Header</summary>
			Property ST As Edi.Dom.Segments.ST
			'''<summary>Function Group Response Header</summary>
			Property AK1 As Edi.Dom.Segments.AK1
			'''<summary>Transaction Set Response Header</summary>
			ReadOnly Property Loop1000 As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop1000)
			'''<summary>Functional Group Response Trailer</summary>
			Property AK9 As Edi.Dom.Segments.AK9
			'''<summary>Transaction Set Trailer</summary>
			Property SE As Edi.Dom.Segments.SE
		End Interface
		Namespace Loops

			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop1000
				Inherits ILoop
				'''<summary>Transaction Set Response Header</summary>
				Property AK2 As Edi.Dom.Segments.AK2
				'''<summary>Implementation Data Segment Note</summary>
				ReadOnly Property Loop2000 As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop2000)
				'''<summary>Implementation Transaction Set Response Trailer</summary>
				Property IK5 As Edi.Dom.Segments.IK5
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2000
				Inherits ILoop
				'''<summary>Implementation Data Segment Note</summary>
				Property IK3 As Edi.Dom.Segments.IK3
				'''<summary>Context</summary>
				ReadOnly Property CTX As SegmentContainer(Of Edi.Dom.Segments.CTX)
				'''<summary>Implementation Data Element Note</summary>
				ReadOnly Property Loop3000 As LoopContainer(Of Edi.Dom.Transactions.Transaction999.Loops.Loop3000)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop3000
				Inherits ILoop
				'''<summary>Implementation Data Element Note</summary>
				Property IK4 As Edi.Dom.Segments.IK4
				'''<summary>Context</summary>
				ReadOnly Property CTX As SegmentContainer(Of Edi.Dom.Segments.CTX)
			End Interface

		End Namespace 'Loops


		Namespace Transaction999
			Namespace Segments

				Namespace Loop1000

					'''<summary></summary>
					Public Interface AK2
						Inherits ISegment

						'''<summary></summary>
						Property AK201 As String
						'''<summary></summary>
						Property AK202 As String
						'''<summary></summary>
						Property AK203 As String
					End Interface
					'''<summary></summary>
					Public Interface IK5
						Inherits ISegment

						'''<summary></summary>
						Property IK501 As String
						'''<summary></summary>
						Property IK502 As String
						'''<summary></summary>
						Property IK503 As String
						'''<summary></summary>
						Property IK504 As String
						'''<summary></summary>
						Property IK505 As String
						'''<summary></summary>
						Property IK506 As String
					End Interface
				End Namespace 'Loop1000

				Namespace Loop2000

					'''<summary></summary>
					Public Interface IK3
						Inherits ISegment

						'''<summary></summary>
						Property IK301 As String
						'''<summary></summary>
						Property IK302 As Decimal?
						'''<summary></summary>
						Property IK303 As String
						'''<summary></summary>
						Property IK304 As String
					End Interface
					'''<summary></summary>
					Public Interface CTX
						Inherits ISegment

						'''<summary></summary>
						Property CTX01 As Edi.Dom.DataElements.Composite.C998
						'''<summary></summary>
						Property CTX02 As String
						'''<summary></summary>
						Property CTX03 As Decimal?
						'''<summary></summary>
						Property CTX04 As String
						'''<summary></summary>
						Property CTX05 As Edi.Dom.DataElements.Composite.C030
						'''<summary></summary>
						Property CTX06 As Edi.Dom.DataElements.Composite.C999
					End Interface
				End Namespace 'Loop2000

				Namespace Loop3000

					'''<summary></summary>
					Public Interface IK4
						Inherits ISegment

						'''<summary></summary>
						Property IK401 As Edi.Dom.DataElements.Composite.C030
						'''<summary></summary>
						Property IK402 As Decimal?
						'''<summary></summary>
						Property IK403 As String
						'''<summary></summary>
						Property IK404 As String
					End Interface
					'''<summary></summary>
					Public Interface CTX
						Inherits ISegment

						'''<summary></summary>
						Property CTX01 As Edi.Dom.DataElements.Composite.C998
						'''<summary></summary>
						Property CTX02 As String
						'''<summary></summary>
						Property CTX03 As Decimal?
						'''<summary></summary>
						Property CTX04 As String
						'''<summary></summary>
						Property CTX05 As Edi.Dom.DataElements.Composite.C030
						'''<summary></summary>
						Property CTX06 As Edi.Dom.DataElements.Composite.C999
					End Interface
				End Namespace 'Loop3000

				'''<summary></summary>
				Public Interface ST
					Inherits ISegment

					'''<summary></summary>
					Property ST01 As String
					'''<summary></summary>
					Property ST02 As String
					'''<summary></summary>
					Property ST03 As String
				End Interface
				'''<summary></summary>
				Public Interface AK1
					Inherits ISegment

					'''<summary></summary>
					Property AK101 As String
					'''<summary></summary>
					Property AK102 As Decimal?
					'''<summary></summary>
					Property AK103 As String
				End Interface
				'''<summary></summary>
				Public Interface AK9
					Inherits ISegment

					'''<summary></summary>
					Property AK901 As String
					'''<summary></summary>
					Property AK902 As Decimal?
					'''<summary></summary>
					Property AK903 As Decimal?
					'''<summary></summary>
					Property AK904 As Decimal?
					'''<summary></summary>
					Property AK905 As String
					'''<summary></summary>
					Property AK906 As String
					'''<summary></summary>
					Property AK907 As String
					'''<summary></summary>
					Property AK908 As String
					'''<summary></summary>
					Property AK909 As String
				End Interface
				'''<summary></summary>
				Public Interface SE
					Inherits ISegment

					'''<summary></summary>
					Property SE01 As Decimal?
					'''<summary></summary>
					Property SE02 As String
				End Interface
			End Namespace 'Segments

			Namespace Composites
			End Namespace 'Composites

			Namespace Loops
				'''<summary></summary>
				Public Interface Loop1000
					Inherits ILoop


					'''<summary></summary>
					Property AK2 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2

					'''<summary></summary>
					ReadOnly Property Loop2000 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000, Edi.Dom.Transactions.Transaction999.Loops.Loop2000)

					'''<summary></summary>
					Property IK5 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5
				End Interface
				'''<summary></summary>
				Public Interface Loop2000
					Inherits ILoop


					'''<summary></summary>
					Property IK3 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3

					'''<summary></summary>
					ReadOnly Property CTX As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX, Edi.Dom.Segments.CTX)

					'''<summary></summary>
					ReadOnly Property Loop3000 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000, Edi.Dom.Transactions.Transaction999.Loops.Loop3000)
				End Interface
				'''<summary></summary>
				Public Interface Loop3000
					Inherits ILoop


					'''<summary></summary>
					Property IK4 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4

					'''<summary></summary>
					ReadOnly Property CTX As SegmentSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX, Edi.Dom.Segments.CTX)
				End Interface

			End Namespace 'Loops

			'''<summary>Implementation Acknowledgment</summary>
			'''<remarks>
			'''<para></para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary></summary>
				Property ST As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST

				'''<summary></summary>
				Property AK1 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1

				'''<summary></summary>
				ReadOnly Property Loop1000 As LoopSubsetContainer(Of Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000, Edi.Dom.Transactions.Transaction999.Loops.Loop1000)

				'''<summary></summary>
				Property AK9 As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9

				'''<summary></summary>
				Property SE As Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE
			End Interface
		End Namespace 'Transaction999
	End Namespace 'Transaction999
End Namespace 'Transaction999
