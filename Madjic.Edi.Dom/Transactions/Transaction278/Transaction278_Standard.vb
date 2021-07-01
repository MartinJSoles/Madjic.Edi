Namespace Transactions
	Namespace Transaction278

		Partial Friend Class Standard_Obj
			Inherits TransactionSet
			Implements Standard, Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet, Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet
			Friend Sub New(versionCode As String)
				Me.New(String.Empty, versionCode)
			End Sub

			Friend Sub New(controlNumber As String, versionCode As String)
				MyBase.New("HI", versionCode)

				Children.AddRange({New Dom.Segments.ST_Obj,
													CType(Nothing, Dom.Segments.BHT_Obj),
													New LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2000)(0, 2, 100),
													New Dom.Segments.SE_Obj})

				ST_Obj.ST01 = "278"
				ST_Obj.ST02 = controlNumber
				ST_Obj.ST03 = VersionCode

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
				If String.Compare(segmentName, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.ST_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					ST_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.ST_Obj)
					If MyBase.CompareKey(S2.ST01, ";278;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.ST01, ";278;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 1
						Seg.SetSequence = 36
					End If
				ElseIf String.Compare(segmentName, "BHT", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.BHT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					BHT_Obj = Seg
				ElseIf String.Compare(segmentName, "SE", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SE_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SE_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction278.Loop2000_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(2)
					Loop2000_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000A"
						NewLoop.SetArea = 2
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000B"
						NewLoop.SetArea = 3
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000C"
						NewLoop.SetArea = 4
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000D"
						NewLoop.SetArea = 5
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";EV;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000E"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";SS;") AndAlso String.Compare(args.Implementation, "_278A1", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000F"
						NewLoop.SetArea = 7
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000A"
						NewLoop.SetArea = 2
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000B"
						NewLoop.SetArea = 3
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000C"
						NewLoop.SetArea = 4
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000D"
						NewLoop.SetArea = 5
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";EV;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000E"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 36
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";SS;") AndAlso String.Compare(args.Implementation, "_278A3", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000F"
						NewLoop.SetArea = 7
						NewLoop.SetSequence = 36
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

			Private Property ST_Std As Dom.Segments.ST Implements Dom.Transactions.Transaction278.Standard.ST
				Get
					Return CType(Children(0), Dom.Segments.ST_Obj)
				End Get
				Set(value As Dom.Segments.ST)
					Children(0) = value
				End Set
			End Property

			Private Property ST_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.ST
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Private Property ST_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.ST Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.ST
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.ST)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.ST)
					Children(0) = value
				End Set
			End Property
			Friend Property BHT_Obj As Dom.Segments.BHT_Obj
				Get
					Return CType(Children(1), Dom.Segments.BHT_Obj)
				End Get
				Set(value As Dom.Segments.BHT_Obj)
					Children(1) = value
				End Set
			End Property

			Private Property BHT_Std As Dom.Segments.BHT Implements Dom.Transactions.Transaction278.Standard.BHT
				Get
					Return CType(Children(1), Dom.Segments.BHT_Obj)
				End Get
				Set(value As Dom.Segments.BHT)
					Children(1) = value
				End Set
			End Property

			Private Property BHT_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.BHT
				Get
					Return CType(Children(1), Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT)
					Children(1) = value
				End Set
			End Property
			Private Property BHT_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.BHT Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.BHT
				Get
					Return CType(Children(1), Dom.Transactions.Transaction278.Transaction278_A3.Segments.BHT)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.BHT)
					Children(1) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2000) Implements Dom.Transactions.Transaction278.Standard.Loop2000
				Get
					Return CType(Children(2), LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2000))
				End Get
			End Property

			Private Loop2000ASubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000A_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000A
				Get
					If Loop2000ASubset_Transaction278_A1 Is Nothing Then
						Loop2000ASubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 2, 36)
					End If

					If Loop2000ASubset_Transaction278_A1.Count > 0 Then
						Return Loop2000ASubset_Transaction278_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A)
					If Loop2000ASubset_Transaction278_A1 Is Nothing Then
						Loop2000ASubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 2, 36)
					End If

					If Loop2000ASubset_Transaction278_A1.Count = 0 Then
						Loop2000ASubset_Transaction278_A1.Add(value)
					Else
						Loop2000ASubset_Transaction278_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000BSubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000B_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000B
				Get
					If Loop2000BSubset_Transaction278_A1 Is Nothing Then
						Loop2000BSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 3, 36)
					End If

					If Loop2000BSubset_Transaction278_A1.Count > 0 Then
						Return Loop2000BSubset_Transaction278_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B)
					If Loop2000BSubset_Transaction278_A1 Is Nothing Then
						Loop2000BSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 3, 36)
					End If

					If Loop2000BSubset_Transaction278_A1.Count = 0 Then
						Loop2000BSubset_Transaction278_A1.Add(value)
					Else
						Loop2000BSubset_Transaction278_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000CSubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000C_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000C
				Get
					If Loop2000CSubset_Transaction278_A1 Is Nothing Then
						Loop2000CSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 4, 36)
					End If

					If Loop2000CSubset_Transaction278_A1.Count > 0 Then
						Return Loop2000CSubset_Transaction278_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C)
					If Loop2000CSubset_Transaction278_A1 Is Nothing Then
						Loop2000CSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 4, 36)
					End If

					If Loop2000CSubset_Transaction278_A1.Count = 0 Then
						Loop2000CSubset_Transaction278_A1.Add(value)
					Else
						Loop2000CSubset_Transaction278_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000DSubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000D_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000D
				Get
					If Loop2000DSubset_Transaction278_A1 Is Nothing Then
						Loop2000DSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 5, 36)
					End If

					If Loop2000DSubset_Transaction278_A1.Count > 0 Then
						Return Loop2000DSubset_Transaction278_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D)
					If Loop2000DSubset_Transaction278_A1 Is Nothing Then
						Loop2000DSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 5, 36)
					End If

					If Loop2000DSubset_Transaction278_A1.Count = 0 Then
						Loop2000DSubset_Transaction278_A1.Add(value)
					Else
						Loop2000DSubset_Transaction278_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000ESubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000E_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000E
				Get
					If Loop2000ESubset_Transaction278_A1 Is Nothing Then
						Loop2000ESubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 6, 36)
					End If

					If Loop2000ESubset_Transaction278_A1.Count > 0 Then
						Return Loop2000ESubset_Transaction278_A1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E)
					If Loop2000ESubset_Transaction278_A1 Is Nothing Then
						Loop2000ESubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 6, 36)
					End If

					If Loop2000ESubset_Transaction278_A1.Count = 0 Then
						Loop2000ESubset_Transaction278_A1.Add(value)
					Else
						Loop2000ESubset_Transaction278_A1(0) = value
					End If
				End Set
			End Property
			Private Loop2000FSubset_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private ReadOnly Property Loop2000F_Obj_Transaction278_A1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000) Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.Loop2000F
				Get
					If Loop2000FSubset_Transaction278_A1 Is Nothing Then
						Loop2000FSubset_Transaction278_A1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 0, 7, 36)
					End If

					Return Loop2000FSubset_Transaction278_A1
				End Get
			End Property
			Private Loop2000ASubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000A_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000A
				Get
					If Loop2000ASubset_Transaction278_A3 Is Nothing Then
						Loop2000ASubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 2, 36)
					End If

					If Loop2000ASubset_Transaction278_A3.Count > 0 Then
						Return Loop2000ASubset_Transaction278_A3(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A)
					If Loop2000ASubset_Transaction278_A3 Is Nothing Then
						Loop2000ASubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 2, 36)
					End If

					If Loop2000ASubset_Transaction278_A3.Count = 0 Then
						Loop2000ASubset_Transaction278_A3.Add(value)
					Else
						Loop2000ASubset_Transaction278_A3(0) = value
					End If
				End Set
			End Property
			Private Loop2000BSubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000B_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000B
				Get
					If Loop2000BSubset_Transaction278_A3 Is Nothing Then
						Loop2000BSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 3, 36)
					End If

					If Loop2000BSubset_Transaction278_A3.Count > 0 Then
						Return Loop2000BSubset_Transaction278_A3(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B)
					If Loop2000BSubset_Transaction278_A3 Is Nothing Then
						Loop2000BSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 3, 36)
					End If

					If Loop2000BSubset_Transaction278_A3.Count = 0 Then
						Loop2000BSubset_Transaction278_A3.Add(value)
					Else
						Loop2000BSubset_Transaction278_A3(0) = value
					End If
				End Set
			End Property
			Private Loop2000CSubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000C_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000C
				Get
					If Loop2000CSubset_Transaction278_A3 Is Nothing Then
						Loop2000CSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 4, 36)
					End If

					If Loop2000CSubset_Transaction278_A3.Count > 0 Then
						Return Loop2000CSubset_Transaction278_A3(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C)
					If Loop2000CSubset_Transaction278_A3 Is Nothing Then
						Loop2000CSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 4, 36)
					End If

					If Loop2000CSubset_Transaction278_A3.Count = 0 Then
						Loop2000CSubset_Transaction278_A3.Add(value)
					Else
						Loop2000CSubset_Transaction278_A3(0) = value
					End If
				End Set
			End Property
			Private Loop2000DSubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private Property Loop2000D_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000D
				Get
					If Loop2000DSubset_Transaction278_A3 Is Nothing Then
						Loop2000DSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 5, 36)
					End If

					If Loop2000DSubset_Transaction278_A3.Count > 0 Then
						Return Loop2000DSubset_Transaction278_A3(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D)
					If Loop2000DSubset_Transaction278_A3 Is Nothing Then
						Loop2000DSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 1, 5, 36)
					End If

					If Loop2000DSubset_Transaction278_A3.Count = 0 Then
						Loop2000DSubset_Transaction278_A3.Add(value)
					Else
						Loop2000DSubset_Transaction278_A3(0) = value
					End If
				End Set
			End Property
			Private Loop2000ESubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private ReadOnly Property Loop2000E_Obj_1_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000) Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000E
				Get
					If Loop2000ESubset_Transaction278_A3 Is Nothing Then
						Loop2000ESubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 0, 6, 36)
					End If

					Return Loop2000ESubset_Transaction278_A3
				End Get
			End Property
			Private Loop2000FSubset_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)
			Private ReadOnly Property Loop2000F_Obj_1_Transaction278_A3 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000) Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.Loop2000F
				Get
					If Loop2000FSubset_Transaction278_A3 Is Nothing Then
						Loop2000FSubset_Transaction278_A3 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)(Children(2), 0, 7, 36)
					End If

					Return Loop2000FSubset_Transaction278_A3
				End Get
			End Property
			Friend Property SE_Obj As Dom.Segments.SE_Obj
				Get
					Return CType(Children(3), Dom.Segments.SE_Obj)
				End Get
				Set(value As Dom.Segments.SE_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property SE_Std As Dom.Segments.SE Implements Dom.Transactions.Transaction278.Standard.SE
				Get
					Return CType(Children(3), Dom.Segments.SE_Obj)
				End Get
				Set(value As Dom.Segments.SE)
					Children(3) = value
				End Set
			End Property

			Private Property SE_IFace_Transaction278_A1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE Implements Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet.SE
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE)
					Children(3) = value
				End Set
			End Property
			Private Property SE_IFace_1_Transaction278_A3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.SE Implements Dom.Transactions.Transaction278.Transaction278_A3.TransactionSet.SE
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.SE)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.SE)
					Children(3) = value
				End Set
			End Property
		End Class

		Partial Friend Class Loop2000_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction278.Loops.Loop2000,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.HL_Obj),
														New SegmentContainer(Of Dom.Segments.TRN)(9, 2, 200),
														New SegmentContainer(Of Dom.Segments.AAA)(9, 2, 300),
														CType(Nothing, Dom.Segments.UM_Obj),
														CType(Nothing, Dom.Segments.HCR_Obj),
														New SegmentContainer(Of Dom.Segments.REF)(9, 2, 600),
														New SegmentContainer(Of Dom.Segments.DTP)(9, 2, 700),
														CType(Nothing, Dom.Segments.HI_Obj),
														CType(Nothing, Dom.Segments.SV1_Obj),
														CType(Nothing, Dom.Segments.SV2_Obj),
														CType(Nothing, Dom.Segments.SV3_Obj),
														New SegmentContainer(Of Dom.Segments.TOO)(32, 2, 840),
														CType(Nothing, Dom.Segments.HSD_Obj),
														New SegmentContainer(Of Dom.Segments.CRC)(9, 2, 1000),
														CType(Nothing, Dom.Segments.CL1_Obj),
														CType(Nothing, Dom.Segments.CR1_Obj),
														CType(Nothing, Dom.Segments.CR2_Obj),
														CType(Nothing, Dom.Segments.CR4_Obj),
														CType(Nothing, Dom.Segments.CR5_Obj),
														CType(Nothing, Dom.Segments.CR6_Obj),
														CType(Nothing, Dom.Segments.CR7_Obj),
														CType(Nothing, Dom.Segments.CR8_Obj),
														New SegmentContainer(Of Dom.Segments.PWK)(0, 2, 1550),
														CType(Nothing, Dom.Segments.MSG_Obj),
														New LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2010)(0, 2, 1700)})

				Initialize()
			End Sub

			Partial Private Sub Initialize()

			End Sub

			Private Shared StateMan As New ReaderStateMachine({New ReaderState(0, "HL", ReadAction.PopulateSegment, 1, False),
										New ReaderState(1, "TRN", ReadAction.PopulateSegment, 2, False),
										New ReaderState(2, "TRN", ReadAction.PopulateSegment, 2, False),
										New ReaderState(1, "AAA", ReadAction.PopulateSegment, 4, False),
										New ReaderState(2, "AAA", ReadAction.PopulateSegment, 4, False),
										New ReaderState(4, "AAA", ReadAction.PopulateSegment, 4, False),
										New ReaderState(1, "UM", ReadAction.PopulateSegment, 6, False),
										New ReaderState(2, "UM", ReadAction.PopulateSegment, 6, False),
										New ReaderState(4, "UM", ReadAction.PopulateSegment, 6, False),
										New ReaderState(1, "HCR", ReadAction.PopulateSegment, 7, False),
										New ReaderState(2, "HCR", ReadAction.PopulateSegment, 7, False),
										New ReaderState(4, "HCR", ReadAction.PopulateSegment, 7, False),
										New ReaderState(6, "HCR", ReadAction.PopulateSegment, 7, False),
										New ReaderState(1, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(2, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(4, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(6, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(7, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(8, "REF", ReadAction.PopulateSegment, 8, False),
										New ReaderState(1, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(2, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(4, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(6, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(7, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(8, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(10, "DTP", ReadAction.PopulateSegment, 10, False),
										New ReaderState(1, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(2, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(4, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(6, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(7, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(8, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(10, "HI", ReadAction.PopulateSegment, 12, False),
										New ReaderState(1, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(2, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(4, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(6, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(7, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(8, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(10, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(12, "SV1", ReadAction.PopulateSegment, 13, False),
										New ReaderState(1, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(2, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(4, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(6, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(7, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(8, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(10, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(12, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(13, "SV2", ReadAction.PopulateSegment, 14, False),
										New ReaderState(1, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(2, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(4, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(6, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(7, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(8, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(10, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(12, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(13, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(14, "SV3", ReadAction.PopulateSegment, 15, False),
										New ReaderState(1, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(2, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(4, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(6, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(7, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(8, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(10, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(12, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(13, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(14, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(15, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(16, "TOO", ReadAction.PopulateSegment, 16, False),
										New ReaderState(1, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(2, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(4, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(6, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(7, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(8, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(10, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(12, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(13, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(14, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(15, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(16, "HSD", ReadAction.PopulateSegment, 18, False),
										New ReaderState(1, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(2, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(4, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(6, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(7, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(8, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(10, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(12, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(13, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(14, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(15, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(16, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(18, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(19, "CRC", ReadAction.PopulateSegment, 19, False),
										New ReaderState(1, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(2, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(4, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(6, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(7, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(8, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(10, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(12, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(13, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(14, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(15, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(16, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(18, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(19, "CL1", ReadAction.PopulateSegment, 21, False),
										New ReaderState(1, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(2, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(4, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(6, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(7, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(8, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(10, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(12, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(13, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(14, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(15, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(16, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(18, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(19, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(21, "CR1", ReadAction.PopulateSegment, 22, False),
										New ReaderState(1, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(2, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(4, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(6, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(7, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(8, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(10, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(12, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(13, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(14, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(15, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(16, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(18, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(19, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(21, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(22, "CR2", ReadAction.PopulateSegment, 23, False),
										New ReaderState(1, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(2, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(4, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(6, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(7, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(8, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(10, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(12, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(13, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(14, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(15, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(16, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(18, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(19, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(21, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(22, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(23, "CR4", ReadAction.PopulateSegment, 24, False),
										New ReaderState(1, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(2, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(4, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(6, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(7, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(8, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(10, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(12, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(13, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(14, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(15, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(16, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(18, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(19, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(21, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(22, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(23, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(24, "CR5", ReadAction.PopulateSegment, 25, False),
										New ReaderState(1, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(2, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(4, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(6, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(7, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(8, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(10, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(12, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(13, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(14, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(15, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(16, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(18, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(19, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(21, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(22, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(23, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(24, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(25, "CR6", ReadAction.PopulateSegment, 26, False),
										New ReaderState(1, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(2, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(4, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(6, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(7, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(8, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(10, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(12, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(13, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(14, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(15, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(16, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(18, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(19, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(21, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(22, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(23, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(24, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(25, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(26, "CR7", ReadAction.PopulateSegment, 27, False),
										New ReaderState(1, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(2, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(4, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(6, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(7, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(8, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(10, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(12, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(13, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(14, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(15, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(16, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(18, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(19, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(21, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(22, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(23, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(24, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(25, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(26, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(27, "CR8", ReadAction.PopulateSegment, 28, False),
										New ReaderState(1, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(2, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(4, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(6, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(7, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(8, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(10, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(12, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(13, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(14, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(15, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(16, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(18, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(19, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(21, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(22, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(23, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(24, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(25, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(26, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(27, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(28, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(29, "PWK", ReadAction.PopulateSegment, 29, False),
										New ReaderState(1, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(2, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(4, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(6, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(7, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(8, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(10, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(12, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(13, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(14, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(15, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(16, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(18, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(19, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(21, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(22, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(23, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(24, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(25, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(26, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(27, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(28, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(29, "MSG", ReadAction.PopulateSegment, 31, False),
										New ReaderState(1, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(2, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(4, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(6, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(7, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(8, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(10, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(12, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(13, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(14, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(15, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(16, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(18, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(19, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(21, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(22, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(23, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(24, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(25, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(26, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(27, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(28, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(29, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(31, "NM1", ReadAction.PopulateLoop, 32, False),
										New ReaderState(32, "NM1", ReadAction.PopulateLoop, 32, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "HL", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.HL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HL_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.HL_Obj)
					If MyBase.CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_278A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_278A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_278A1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_278A1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";EV;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";SS;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_278A3__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_278A3__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_278A3__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_278A3__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";EV;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 36
					ElseIf MyBase.CompareKey(S2.HL03, ";SS;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 36
					End If
				ElseIf String.Compare(segmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TRN_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "AAA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.AAA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AAA_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "UM", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.UM_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					UM_Obj = Seg
				ElseIf String.Compare(segmentName, "HCR", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.HCR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HCR_Obj = Seg
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";BB;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 216
					ElseIf MyBase.CompareKey(S2.REF01, ";NT;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 1512
					ElseIf MyBase.CompareKey(S2.REF01, ";BB;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 216
					ElseIf MyBase.CompareKey(S2.REF01, ";NT;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 1512
					ElseIf MyBase.CompareKey(S2.REF01, ";NT;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 216
					ElseIf MyBase.CompareKey(S2.REF01, ";BB;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 1512
					ElseIf MyBase.CompareKey(S2.REF01, ";NT;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 216
					ElseIf MyBase.CompareKey(S2.REF01, ";BB;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 1512
					End If
				ElseIf String.Compare(segmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";439;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 252
					ElseIf MyBase.CompareKey(S2.DTP01, ";484;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 2844
					ElseIf MyBase.CompareKey(S2.DTP01, ";ABC;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 5436
					ElseIf MyBase.CompareKey(S2.DTP01, ";431;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 8028
					ElseIf MyBase.CompareKey(S2.DTP01, ";AAH;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 241308
					ElseIf MyBase.CompareKey(S2.DTP01, ";435;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 9324
					ElseIf MyBase.CompareKey(S2.DTP01, ";096;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 242604
					ElseIf MyBase.CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 252
					ElseIf MyBase.CompareKey(S2.DTP01, ";439;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 252
					ElseIf MyBase.CompareKey(S2.DTP01, ";484;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 233532
					ElseIf MyBase.CompareKey(S2.DTP01, ";ABC;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 1548
					ElseIf MyBase.CompareKey(S2.DTP01, ";431;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 234828
					ElseIf MyBase.CompareKey(S2.DTP01, ";AAH;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 2844
					ElseIf MyBase.CompareKey(S2.DTP01, ";435;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 236124
					ElseIf MyBase.CompareKey(S2.DTP01, ";096;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 4140
					ElseIf MyBase.CompareKey(S2.DTP01, ";102;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 237420
					ElseIf MyBase.CompareKey(S2.DTP01, ";036;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 5436
					ElseIf MyBase.CompareKey(S2.DTP01, ";007;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 238716
					ElseIf MyBase.CompareKey(S2.DTP01, ";472;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 252
					ElseIf MyBase.CompareKey(S2.DTP01, ";102;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 10620
					ElseIf MyBase.CompareKey(S2.DTP01, ";036;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 11916
					ElseIf MyBase.CompareKey(S2.DTP01, ";007;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 13212
					End If
				ElseIf String.Compare(segmentName, "HI", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.HI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HI_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.HI_Obj)
					If MyBase.CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABF;ABJ;ABK;APR;BF;BJ;BK;DR;PR;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 288
					ElseIf MyBase.CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABF;ABJ;ABK;APR;BF;BJ;BK;DR;LOI;PR;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 288
					ElseIf MyBase.CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";LOI;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 288
					End If
				ElseIf String.Compare(segmentName, "SV1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SV1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SV1_Obj = Seg
				ElseIf String.Compare(segmentName, "SV2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SV2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SV2_Obj = Seg
				ElseIf String.Compare(segmentName, "SV3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.SV3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					SV3_Obj = Seg
				ElseIf String.Compare(segmentName, "TOO", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.TOO_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					TOO_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "HSD", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.HSD_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					HSD_Obj = Seg
				ElseIf String.Compare(segmentName, "CRC", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CRC_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CRC_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.CRC_Obj)
					If MyBase.CompareKey(S2.CRC01, ";07;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 1
					ElseIf MyBase.CompareKey(S2.CRC01, ";08;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 233281
					ElseIf MyBase.CompareKey(S2.CRC01, ";09;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 1297
					ElseIf MyBase.CompareKey(S2.CRC01, ";11;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 234577
					ElseIf MyBase.CompareKey(S2.CRC01, ";75;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 2593
					ElseIf MyBase.CompareKey(S2.CRC01, ";76;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 235873
					ElseIf MyBase.CompareKey(S2.CRC01, ";77;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 3889
					End If
				ElseIf String.Compare(segmentName, "CL1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CL1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CL1_Obj = Seg
				ElseIf String.Compare(segmentName, "CR1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR1_Obj = Seg
				ElseIf String.Compare(segmentName, "CR2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR2_Obj = Seg
				ElseIf String.Compare(segmentName, "CR4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR4_Obj = Seg
				ElseIf String.Compare(segmentName, "CR5", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR5_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR5_Obj = Seg
				ElseIf String.Compare(segmentName, "CR6", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR6_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR6_Obj = Seg
				ElseIf String.Compare(segmentName, "CR7", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR7_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR7_Obj = Seg
				ElseIf String.Compare(segmentName, "CR8", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.CR8_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					CR8_Obj = Seg
				ElseIf String.Compare(segmentName, "PWK", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PWK_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PWK_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.PWK_Obj)
					If MyBase.CompareKey(String.Format("{0}:{1}", If(S2.PWK01 IsNot Nothing, S2.PWK01, String.Empty), If(S2.PWK02 IsNot Nothing, S2.PWK02, String.Empty)), ";03:AA;03:BM;03:EL;03:EM;03:FX;03:VO;04:AA;04:BM;04:EL;04:EM;04:FX;04:VO;05:AA;05:BM;05:EL;05:EM;05:FX;05:VO;06:AA;06:BM;06:EL;06:EM;06:FX;06:VO;07:AA;07:BM;07:EL;07:EM;07:FX;07:VO;08:AA;08:BM;08:EL;08:EM;08:FX;08:VO;09:AA;09:BM;09:EL;09:EM;09:FX;09:VO;10:AA;10:BM;10:EL;10:EM;10:FX;10:VO;11:AA;11:BM;11:EL;11:EM;11:FX;11:VO;13:AA;13:BM;13:EL;13:EM;13:FX;13:VO;15:AA;15:BM;15:EL;15:EM;15:FX;15:VO;21:AA;21:BM;21:EL;21:EM;21:FX;21:VO;48:AA;48:BM;48:EL;48:EM;48:FX;48:VO;55:AA;55:BM;55:EL;55:EM;55:FX;55:VO;59:AA;59:BM;59:EL;59:EM;59:FX;59:VO;77:AA;77:BM;77:EL;77:EM;77:FX;77:VO;A3:AA;A3:BM;A3:EL;A3:EM;A3:FX;A3:VO;A4:AA;A4:BM;A4:EL;A4:EM;A4:FX;A4:VO;AM:AA;AM:BM;AM:EL;AM:EM;AM:FX;AM:VO;AS:AA;AS:BM;AS:EL;AS:EM;AS:FX;AS:VO;AT:AA;AT:BM;AT:EL;AT:EM;AT:FX;AT:VO;B2:AA;B2:BM;B2:EL;B2:EM;B2:FX;B2:VO;B3:AA;B3:BM;B3:EL;B3:EM;B3:FX;B3:VO;BR:AA;BR:BM;BR:EL;BR:EM;BR:FX;BR:VO;BS:AA;BS:BM;BS:EL;BS:EM;BS:FX;BS:VO;BT:AA;BT:BM;BT:EL;BT:EM;BT:FX;BT:VO;CB:AA;CB:BM;CB:EL;CB:EM;CB:FX;CB:VO;CK:AA;CK:BM;CK:EL;CK:EM;CK:FX;CK:VO;D2:AA;D2:BM;D2:EL;D2:EM;D2:FX;D2:VO;DA:AA;DA:BM;DA:EL;DA:EM;DA:FX;DA:VO;DB:AA;DB:BM;DB:EL;DB:EM;DB:FX;DB:VO;DG:AA;DG:BM;DG:EL;DG:EM;DG:FX;DG:VO;DJ:AA;DJ:BM;DJ:EL;DJ:EM;DJ:FX;DJ:VO;DS:AA;DS:BM;DS:EL;DS:EM;DS:FX;DS:VO;FM:AA;FM:BM;FM:EL;FM:EM;FM:FX;FM:VO;HC:AA;HC:BM;HC:EL;HC:EM;HC:FX;HC:VO;HR:AA;HR:BM;HR:EL;HR:EM;HR:FX;HR:VO;I5:AA;I5:BM;I5:EL;I5:EM;I5:FX;I5:VO;IR:AA;IR:BM;IR:EL;IR:EM;IR:FX;IR:VO;LA:AA;LA:BM;LA:EL;LA:EM;LA:FX;LA:VO;M1:AA;M1:BM;M1:EL;M1:EM;M1:FX;M1:VO;NN:AA;NN:BM;NN:EL;NN:EM;NN:FX;NN:VO;OB:AA;OB:BM;OB:EL;OB:EM;OB:FX;OB:VO;OC:AA;OC:BM;OC:EL;OC:EM;OC:FX;OC:VO;OD:AA;OD:BM;OD:EL;OD:EM;OD:FX;OD:VO;OE:AA;OE:BM;OE:EL;OE:EM;OE:FX;OE:VO;OX:AA;OX:BM;OX:EL;OX:EM;OX:FX;OX:VO;P4:AA;P4:BM;P4:EL;P4:EM;P4:FX;P4:VO;P5:AA;P5:BM;P5:EL;P5:EM;P5:FX;P5:VO;P6:AA;P6:BM;P6:EL;P6:EM;P6:FX;P6:VO;P7:AA;P7:BM;P7:EL;P7:EM;P7:FX;P7:VO;PE:AA;PE:BM;PE:EL;PE:EM;PE:FX;PE:VO;PN:AA;PN:BM;PN:EL;PN:EM;PN:FX;PN:VO;PO:AA;PO:BM;PO:EL;PO:EM;PO:FX;PO:VO;PQ:AA;PQ:BM;PQ:EL;PQ:EM;PQ:FX;PQ:VO;PY:AA;PY:BM;PY:EL;PY:EM;PY:FX;PY:VO;PZ:AA;PZ:BM;PZ:EL;PZ:EM;PZ:FX;PZ:VO;QC:AA;QC:BM;QC:EL;QC:EM;QC:FX;QC:VO;QR:AA;QR:BM;QR:EL;QR:EM;QR:FX;QR:VO;RB:AA;RB:BM;RB:EL;RB:EM;RB:FX;RB:VO;RR:AA;RR:BM;RR:EL;RR:EM;RR:FX;RR:VO;RT:AA;RT:BM;RT:EL;RT:EM;RT:FX;RT:VO;RX:AA;RX:BM;RX:EL;RX:EM;RX:FX;RX:VO;SG:AA;SG:BM;SG:EL;SG:EM;SG:FX;SG:VO;V5:AA;V5:BM;V5:EL;V5:EM;V5:FX;V5:VO;XP:AA;XP:BM;XP:EL;XP:EM;XP:FX;XP:VO;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 6661
					ElseIf MyBase.CompareKey(String.Format("{0}:{1}", If(S2.PWK01 IsNot Nothing, S2.PWK01, String.Empty), If(S2.PWK02 IsNot Nothing, S2.PWK02, String.Empty)), ";03:AA;03:BM;03:EL;03:EM;03:FX;03:VO;04:AA;04:BM;04:EL;04:EM;04:FX;04:VO;05:AA;05:BM;05:EL;05:EM;05:FX;05:VO;06:AA;06:BM;06:EL;06:EM;06:FX;06:VO;07:AA;07:BM;07:EL;07:EM;07:FX;07:VO;08:AA;08:BM;08:EL;08:EM;08:FX;08:VO;09:AA;09:BM;09:EL;09:EM;09:FX;09:VO;10:AA;10:BM;10:EL;10:EM;10:FX;10:VO;11:AA;11:BM;11:EL;11:EM;11:FX;11:VO;13:AA;13:BM;13:EL;13:EM;13:FX;13:VO;15:AA;15:BM;15:EL;15:EM;15:FX;15:VO;21:AA;21:BM;21:EL;21:EM;21:FX;21:VO;48:AA;48:BM;48:EL;48:EM;48:FX;48:VO;55:AA;55:BM;55:EL;55:EM;55:FX;55:VO;59:AA;59:BM;59:EL;59:EM;59:FX;59:VO;77:AA;77:BM;77:EL;77:EM;77:FX;77:VO;A3:AA;A3:BM;A3:EL;A3:EM;A3:FX;A3:VO;A4:AA;A4:BM;A4:EL;A4:EM;A4:FX;A4:VO;AM:AA;AM:BM;AM:EL;AM:EM;AM:FX;AM:VO;AS:AA;AS:BM;AS:EL;AS:EM;AS:FX;AS:VO;AT:AA;AT:BM;AT:EL;AT:EM;AT:FX;AT:VO;B2:AA;B2:BM;B2:EL;B2:EM;B2:FX;B2:VO;B3:AA;B3:BM;B3:EL;B3:EM;B3:FX;B3:VO;BR:AA;BR:BM;BR:EL;BR:EM;BR:FX;BR:VO;BS:AA;BS:BM;BS:EL;BS:EM;BS:FX;BS:VO;BT:AA;BT:BM;BT:EL;BT:EM;BT:FX;BT:VO;CB:AA;CB:BM;CB:EL;CB:EM;CB:FX;CB:VO;CK:AA;CK:BM;CK:EL;CK:EM;CK:FX;CK:VO;D2:AA;D2:BM;D2:EL;D2:EM;D2:FX;D2:VO;DA:AA;DA:BM;DA:EL;DA:EM;DA:FX;DA:VO;DB:AA;DB:BM;DB:EL;DB:EM;DB:FX;DB:VO;DG:AA;DG:BM;DG:EL;DG:EM;DG:FX;DG:VO;DJ:AA;DJ:BM;DJ:EL;DJ:EM;DJ:FX;DJ:VO;DS:AA;DS:BM;DS:EL;DS:EM;DS:FX;DS:VO;FM:AA;FM:BM;FM:EL;FM:EM;FM:FX;FM:VO;HC:AA;HC:BM;HC:EL;HC:EM;HC:FX;HC:VO;HR:AA;HR:BM;HR:EL;HR:EM;HR:FX;HR:VO;I5:AA;I5:BM;I5:EL;I5:EM;I5:FX;I5:VO;IR:AA;IR:BM;IR:EL;IR:EM;IR:FX;IR:VO;LA:AA;LA:BM;LA:EL;LA:EM;LA:FX;LA:VO;M1:AA;M1:BM;M1:EL;M1:EM;M1:FX;M1:VO;NN:AA;NN:BM;NN:EL;NN:EM;NN:FX;NN:VO;OB:AA;OB:BM;OB:EL;OB:EM;OB:FX;OB:VO;OC:AA;OC:BM;OC:EL;OC:EM;OC:FX;OC:VO;OD:AA;OD:BM;OD:EL;OD:EM;OD:FX;OD:VO;OE:AA;OE:BM;OE:EL;OE:EM;OE:FX;OE:VO;OX:AA;OX:BM;OX:EL;OX:EM;OX:FX;OX:VO;P4:AA;P4:BM;P4:EL;P4:EM;P4:FX;P4:VO;P5:AA;P5:BM;P5:EL;P5:EM;P5:FX;P5:VO;P6:AA;P6:BM;P6:EL;P6:EM;P6:FX;P6:VO;P7:AA;P7:BM;P7:EL;P7:EM;P7:FX;P7:VO;PE:AA;PE:BM;PE:EL;PE:EM;PE:FX;PE:VO;PN:AA;PN:BM;PN:EL;PN:EM;PN:FX;PN:VO;PO:AA;PO:BM;PO:EL;PO:EM;PO:FX;PO:VO;PQ:AA;PQ:BM;PQ:EL;PQ:EM;PQ:FX;PQ:VO;PY:AA;PY:BM;PY:EL;PY:EM;PY:FX;PY:VO;PZ:AA;PZ:BM;PZ:EL;PZ:EM;PZ:FX;PZ:VO;QC:AA;QC:BM;QC:EL;QC:EM;QC:FX;QC:VO;QR:AA;QR:BM;QR:EL;QR:EM;QR:FX;QR:VO;RB:AA;RB:BM;RB:EL;RB:EM;RB:FX;RB:VO;RR:AA;RR:BM;RR:EL;RR:EM;RR:FX;RR:VO;RT:AA;RT:BM;RT:EL;RT:EM;RT:FX;RT:VO;RX:AA;RX:BM;RX:EL;RX:EM;RX:FX;RX:VO;SG:AA;SG:BM;SG:EL;SG:EM;SG:FX;SG:VO;V5:AA;V5:BM;V5:EL;V5:EM;V5:FX;V5:VO;XP:AA;XP:BM;XP:EL;XP:EM;XP:FX;XP:VO;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 6661
					ElseIf MyBase.CompareKey(String.Format("{0}:{1}", If(S2.PWK01 IsNot Nothing, S2.PWK01, String.Empty), If(S2.PWK02 IsNot Nothing, S2.PWK02, String.Empty)), ";03:BM;03:EL;03:EM;03:FX;03:VO;04:BM;04:EL;04:EM;04:FX;04:VO;05:BM;05:EL;05:EM;05:FX;05:VO;06:BM;06:EL;06:EM;06:FX;06:VO;07:BM;07:EL;07:EM;07:FX;07:VO;08:BM;08:EL;08:EM;08:FX;08:VO;09:BM;09:EL;09:EM;09:FX;09:VO;10:BM;10:EL;10:EM;10:FX;10:VO;11:BM;11:EL;11:EM;11:FX;11:VO;13:BM;13:EL;13:EM;13:FX;13:VO;15:BM;15:EL;15:EM;15:FX;15:VO;21:BM;21:EL;21:EM;21:FX;21:VO;48:BM;48:EL;48:EM;48:FX;48:VO;55:BM;55:EL;55:EM;55:FX;55:VO;59:BM;59:EL;59:EM;59:FX;59:VO;77:BM;77:EL;77:EM;77:FX;77:VO;A3:BM;A3:EL;A3:EM;A3:FX;A3:VO;A4:BM;A4:EL;A4:EM;A4:FX;A4:VO;AM:BM;AM:EL;AM:EM;AM:FX;AM:VO;AS:BM;AS:EL;AS:EM;AS:FX;AS:VO;AT:BM;AT:EL;AT:EM;AT:FX;AT:VO;B2:BM;B2:EL;B2:EM;B2:FX;B2:VO;B3:BM;B3:EL;B3:EM;B3:FX;B3:VO;BR:BM;BR:EL;BR:EM;BR:FX;BR:VO;BS:BM;BS:EL;BS:EM;BS:FX;BS:VO;BT:BM;BT:EL;BT:EM;BT:FX;BT:VO;CB:BM;CB:EL;CB:EM;CB:FX;CB:VO;CK:BM;CK:EL;CK:EM;CK:FX;CK:VO;D2:BM;D2:EL;D2:EM;D2:FX;D2:VO;DA:BM;DA:EL;DA:EM;DA:FX;DA:VO;DB:BM;DB:EL;DB:EM;DB:FX;DB:VO;DG:BM;DG:EL;DG:EM;DG:FX;DG:VO;DJ:BM;DJ:EL;DJ:EM;DJ:FX;DJ:VO;DS:BM;DS:EL;DS:EM;DS:FX;DS:VO;FM:BM;FM:EL;FM:EM;FM:FX;FM:VO;HC:BM;HC:EL;HC:EM;HC:FX;HC:VO;HR:BM;HR:EL;HR:EM;HR:FX;HR:VO;I5:BM;I5:EL;I5:EM;I5:FX;I5:VO;IR:BM;IR:EL;IR:EM;IR:FX;IR:VO;LA:BM;LA:EL;LA:EM;LA:FX;LA:VO;M1:BM;M1:EL;M1:EM;M1:FX;M1:VO;NN:BM;NN:EL;NN:EM;NN:FX;NN:VO;OB:BM;OB:EL;OB:EM;OB:FX;OB:VO;OC:BM;OC:EL;OC:EM;OC:FX;OC:VO;OD:BM;OD:EL;OD:EM;OD:FX;OD:VO;OE:BM;OE:EL;OE:EM;OE:FX;OE:VO;OX:BM;OX:EL;OX:EM;OX:FX;OX:VO;P4:BM;P4:EL;P4:EM;P4:FX;P4:VO;P5:BM;P5:EL;P5:EM;P5:FX;P5:VO;P6:BM;P6:EL;P6:EM;P6:FX;P6:VO;P7:BM;P7:EL;P7:EM;P7:FX;P7:VO;PE:BM;PE:EL;PE:EM;PE:FX;PE:VO;PN:BM;PN:EL;PN:EM;PN:FX;PN:VO;PO:BM;PO:EL;PO:EM;PO:FX;PO:VO;PQ:BM;PQ:EL;PQ:EM;PQ:FX;PQ:VO;PY:BM;PY:EL;PY:EM;PY:FX;PY:VO;PZ:BM;PZ:EL;PZ:EM;PZ:FX;PZ:VO;QC:BM;QC:EL;QC:EM;QC:FX;QC:VO;QR:BM;QR:EL;QR:EM;QR:FX;QR:VO;RB:BM;RB:EL;RB:EM;RB:FX;RB:VO;RR:BM;RR:EL;RR:EM;RR:FX;RR:VO;RT:BM;RT:EL;RT:EM;RT:FX;RT:VO;RX:BM;RX:EL;RX:EM;RX:FX;RX:VO;SG:BM;SG:EL;SG:EM;SG:FX;SG:VO;V5:BM;V5:EL;V5:EM;V5:FX;V5:VO;XP:BM;XP:EL;XP:EM;XP:FX;XP:VO;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 6661
					ElseIf MyBase.CompareKey(String.Format("{0}:{1}", If(S2.PWK01 IsNot Nothing, S2.PWK01, String.Empty), If(S2.PWK02 IsNot Nothing, S2.PWK02, String.Empty)), ";03:BM;03:EL;03:EM;03:FX;03:VO;04:BM;04:EL;04:EM;04:FX;04:VO;05:BM;05:EL;05:EM;05:FX;05:VO;06:BM;06:EL;06:EM;06:FX;06:VO;07:BM;07:EL;07:EM;07:FX;07:VO;08:BM;08:EL;08:EM;08:FX;08:VO;09:BM;09:EL;09:EM;09:FX;09:VO;10:BM;10:EL;10:EM;10:FX;10:VO;11:BM;11:EL;11:EM;11:FX;11:VO;13:BM;13:EL;13:EM;13:FX;13:VO;15:BM;15:EL;15:EM;15:FX;15:VO;21:BM;21:EL;21:EM;21:FX;21:VO;48:BM;48:EL;48:EM;48:FX;48:VO;55:BM;55:EL;55:EM;55:FX;55:VO;59:BM;59:EL;59:EM;59:FX;59:VO;77:BM;77:EL;77:EM;77:FX;77:VO;A3:BM;A3:EL;A3:EM;A3:FX;A3:VO;A4:BM;A4:EL;A4:EM;A4:FX;A4:VO;AM:BM;AM:EL;AM:EM;AM:FX;AM:VO;AS:BM;AS:EL;AS:EM;AS:FX;AS:VO;AT:BM;AT:EL;AT:EM;AT:FX;AT:VO;B2:BM;B2:EL;B2:EM;B2:FX;B2:VO;B3:BM;B3:EL;B3:EM;B3:FX;B3:VO;BR:BM;BR:EL;BR:EM;BR:FX;BR:VO;BS:BM;BS:EL;BS:EM;BS:FX;BS:VO;BT:BM;BT:EL;BT:EM;BT:FX;BT:VO;CB:BM;CB:EL;CB:EM;CB:FX;CB:VO;CK:BM;CK:EL;CK:EM;CK:FX;CK:VO;D2:BM;D2:EL;D2:EM;D2:FX;D2:VO;DA:BM;DA:EL;DA:EM;DA:FX;DA:VO;DB:BM;DB:EL;DB:EM;DB:FX;DB:VO;DG:BM;DG:EL;DG:EM;DG:FX;DG:VO;DJ:BM;DJ:EL;DJ:EM;DJ:FX;DJ:VO;DS:BM;DS:EL;DS:EM;DS:FX;DS:VO;FM:BM;FM:EL;FM:EM;FM:FX;FM:VO;HC:BM;HC:EL;HC:EM;HC:FX;HC:VO;HR:BM;HR:EL;HR:EM;HR:FX;HR:VO;I5:BM;I5:EL;I5:EM;I5:FX;I5:VO;IR:BM;IR:EL;IR:EM;IR:FX;IR:VO;LA:BM;LA:EL;LA:EM;LA:FX;LA:VO;M1:BM;M1:EL;M1:EM;M1:FX;M1:VO;NN:BM;NN:EL;NN:EM;NN:FX;NN:VO;OB:BM;OB:EL;OB:EM;OB:FX;OB:VO;OC:BM;OC:EL;OC:EM;OC:FX;OC:VO;OD:BM;OD:EL;OD:EM;OD:FX;OD:VO;OE:BM;OE:EL;OE:EM;OE:FX;OE:VO;OX:BM;OX:EL;OX:EM;OX:FX;OX:VO;P4:BM;P4:EL;P4:EM;P4:FX;P4:VO;P5:BM;P5:EL;P5:EM;P5:FX;P5:VO;P6:BM;P6:EL;P6:EM;P6:FX;P6:VO;P7:BM;P7:EL;P7:EM;P7:FX;P7:VO;PE:BM;PE:EL;PE:EM;PE:FX;PE:VO;PN:BM;PN:EL;PN:EM;PN:FX;PN:VO;PO:BM;PO:EL;PO:EM;PO:FX;PO:VO;PQ:BM;PQ:EL;PQ:EM;PQ:FX;PQ:VO;PY:BM;PY:EL;PY:EM;PY:FX;PY:VO;PZ:BM;PZ:EL;PZ:EM;PZ:FX;PZ:VO;QC:BM;QC:EL;QC:EM;QC:FX;QC:VO;QR:BM;QR:EL;QR:EM;QR:FX;QR:VO;RB:BM;RB:EL;RB:EM;RB:FX;RB:VO;RR:BM;RR:EL;RR:EM;RR:FX;RR:VO;RT:BM;RT:EL;RT:EM;RT:FX;RT:VO;RX:BM;RX:EL;RX:EM;RX:FX;RX:VO;SG:BM;SG:EL;SG:EM;SG:FX;SG:VO;V5:BM;V5:EL;V5:EM;V5:FX;V5:VO;XP:BM;XP:EL;XP:EM;XP:FX;XP:VO;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 6661
					End If
				ElseIf String.Compare(segmentName, "MSG", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.MSG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					MSG_Obj = Seg
				End If
			End Sub

			Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				If String.Compare(args.DataSegment.SegmentID, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Dim NewLoop As LoopBase = New Dom.Transactions.Transaction278.Loop2010_Obj
					Dim LoopKey As String = args.DataSegment.ToStringValue(0)
					Loop2010_Obj.Add(NewLoop)
					If MyBase.CompareKey(LoopKey, ";2B;36;PR;X3;") AndAlso String.Compare(args.Implementation, "_278A1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000A__2010A"
						NewLoop.SetArea = 2
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";1P;2B;36;FA;PR;") AndAlso String.Compare(args.Implementation, "_278A1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000B__2010B"
						NewLoop.SetArea = 3
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_278A1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000C__2010C"
						NewLoop.SetArea = 4
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";QC;") AndAlso String.Compare(args.Implementation, "_278A1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000D__2010D"
						NewLoop.SetArea = 5
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";71;72;73;77;AAJ;DD;DK;DN;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000E__2010EA"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";45;FS;ND;PW;R3;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000E__2010EB"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 290
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";00;CA;GG;") AndAlso String.Compare(args.Implementation, "_278A1__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000E__2010EC"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 327
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";1T;72;73;77;DD;DK;DQ;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A1__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A1__2000F__2010F"
						NewLoop.SetArea = 7
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";2B;36;PR;X3;") AndAlso String.Compare(args.Implementation, "_278A3__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000A__2010A"
						NewLoop.SetArea = 2
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";1P;FA;") AndAlso String.Compare(args.Implementation, "_278A3__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000B__2010B"
						NewLoop.SetArea = 3
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_278A3__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000C__2010C"
						NewLoop.SetArea = 4
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";QC;") AndAlso String.Compare(args.Implementation, "_278A3__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000D__2010D"
						NewLoop.SetArea = 5
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";71;72;73;77;AAJ;DD;DK;DN;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000E__2010EA"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";L5;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000E__2010EB"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 290
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";45;FS;ND;PW;R3;") AndAlso String.Compare(args.Implementation, "_278A3__2000E", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000E__2010EC"
						NewLoop.SetArea = 6
						NewLoop.SetSequence = 39
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";72;73;77;DD;DK;DQ;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000F__2010FA"
						NewLoop.SetArea = 7
						NewLoop.SetSequence = 1513
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					ElseIf MyBase.CompareKey(LoopKey, ";L5;") AndAlso String.Compare(args.Implementation, "_278A3__2000F", StringComparison.OrdinalIgnoreCase) = 0 Then
						args.Implementation = "_278A3__2000F__2010FB"
						NewLoop.SetArea = 7
						NewLoop.SetSequence = 253
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					Else
						Await NewLoop.ReadAsync(args).ConfigureAwait(False)
					End If
				End If
				args.Implementation = Temp
			End Function
			Friend Property HL_Obj As Dom.Segments.HL_Obj
				Get
					Return CType(Children(0), Dom.Segments.HL_Obj)
				End Get
				Set(value As Dom.Segments.HL_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property HL_Std As Dom.Segments.HL Implements Dom.Transactions.Transaction278.Loops.Loop2000.HL
				Get
					Return CType(Children(0), Dom.Segments.HL_Obj)
				End Get
				Set(value As Dom.Segments.HL)
					Children(0) = value
				End Set
			End Property

			Private Property HL_IFace_Loop2000A_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_1_Loop2000B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_2_Loop2000C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_3_Loop2000D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_4_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_5_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_6_Loop2000A_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_7_Loop2000B_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_8_Loop2000C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_9_Loop2000D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_10_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL)
					Children(0) = value
				End Set
			End Property
			Private Property HL_IFace_11_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.HL
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property TRN_Obj As SegmentContainer(Of Dom.Segments.TRN) Implements Dom.Transactions.Transaction278.Loops.Loop2000.TRN
				Get
					Return CType(Children(1), SegmentContainer(Of Dom.Segments.TRN))
				End Get
			End Property

			Private TRNSubset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN, Dom.Segments.TRN)
			Private ReadOnly Property TRN_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN, Dom.Segments.TRN) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.TRN
				Get
					If TRNSubset_Loop2000E_Obj Is Nothing Then
						TRNSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN, Dom.Segments.TRN)(Children(1), 2, 6, 72)
					End If

					Return TRNSubset_Loop2000E_Obj
				End Get
			End Property
			Private TRNSubset_1_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN, Dom.Segments.TRN)
			Private ReadOnly Property TRN_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN, Dom.Segments.TRN) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.TRN
				Get
					If TRNSubset_1_Loop2000F_Obj Is Nothing Then
						TRNSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN, Dom.Segments.TRN)(Children(1), 2, 7, 72)
					End If

					Return TRNSubset_1_Loop2000F_Obj
				End Get
			End Property
			Private TRNSubset_2_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN, Dom.Segments.TRN)
			Private ReadOnly Property TRN_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN, Dom.Segments.TRN) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.TRN
				Get
					If TRNSubset_2_Loop2000E_Obj_1 Is Nothing Then
						TRNSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN, Dom.Segments.TRN)(Children(1), 3, 6, 72)
					End If

					Return TRNSubset_2_Loop2000E_Obj_1
				End Get
			End Property
			Private TRNSubset_3_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN, Dom.Segments.TRN)
			Private ReadOnly Property TRN_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN, Dom.Segments.TRN) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.TRN
				Get
					If TRNSubset_3_Loop2000F_Obj_1 Is Nothing Then
						TRNSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN, Dom.Segments.TRN)(Children(1), 3, 7, 72)
					End If

					Return TRNSubset_3_Loop2000F_Obj_1
				End Get
			End Property
			Friend ReadOnly Property AAA_Obj As SegmentContainer(Of Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Loops.Loop2000.AAA
				Get
					Return CType(Children(2), SegmentContainer(Of Dom.Segments.AAA))
				End Get
			End Property

			Private AAASubset_Loop2000A_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2000A_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A.AAA
				Get
					If AAASubset_Loop2000A_Obj_1 Is Nothing Then
						AAASubset_Loop2000A_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA, Dom.Segments.AAA)(Children(2), 9, 2, 108)
					End If

					Return AAASubset_Loop2000A_Obj_1
				End Get
			End Property
			Private AAASubset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.AAA
				Get
					If AAASubset_1_Loop2000E_Obj_1 Is Nothing Then
						AAASubset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA, Dom.Segments.AAA)(Children(2), 9, 6, 108)
					End If

					Return AAASubset_1_Loop2000E_Obj_1
				End Get
			End Property
			Private AAASubset_2_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.AAA
				Get
					If AAASubset_2_Loop2000F_Obj_1 Is Nothing Then
						AAASubset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA, Dom.Segments.AAA)(Children(2), 9, 7, 108)
					End If

					Return AAASubset_2_Loop2000F_Obj_1
				End Get
			End Property
			Friend Property UM_Obj As Dom.Segments.UM_Obj
				Get
					Return CType(Children(3), Dom.Segments.UM_Obj)
				End Get
				Set(value As Dom.Segments.UM_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property UM_Std As Dom.Segments.UM Implements Dom.Transactions.Transaction278.Loops.Loop2000.UM
				Get
					Return CType(Children(3), Dom.Segments.UM_Obj)
				End Get
				Set(value As Dom.Segments.UM)
					Children(3) = value
				End Set
			End Property

			Private Property UM_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.UM
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM)
					Children(3) = value
				End Set
			End Property
			Private Property UM_IFace_1_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.UM
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM)
					Children(3) = value
				End Set
			End Property
			Private Property UM_IFace_2_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.UM
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM)
					Children(3) = value
				End Set
			End Property
			Private Property UM_IFace_3_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.UM
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM)
					Children(3) = value
				End Set
			End Property
			Friend Property HCR_Obj As Dom.Segments.HCR_Obj
				Get
					Return CType(Children(4), Dom.Segments.HCR_Obj)
				End Get
				Set(value As Dom.Segments.HCR_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property HCR_Std As Dom.Segments.HCR Implements Dom.Transactions.Transaction278.Loops.Loop2000.HCR
				Get
					Return CType(Children(4), Dom.Segments.HCR_Obj)
				End Get
				Set(value As Dom.Segments.HCR)
					Children(4) = value
				End Set
			End Property

			Private Property HCR_IFace_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.HCR
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR)
					Children(4) = value
				End Set
			End Property
			Private Property HCR_IFace_1_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.HCR
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR)
					Children(4) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Loops.Loop2000.REF
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF, Dom.Segments.REF)
			Private Property REF_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.REF
				Get
					If REFSubset_Loop2000E_Obj Is Nothing Then
						REFSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF, Dom.Segments.REF)(Children(5), 1, 6, 216)
					End If

					If REFSubset_Loop2000E_Obj.Count > 0 Then
						Return REFSubset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF)
					If REFSubset_Loop2000E_Obj Is Nothing Then
						REFSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF, Dom.Segments.REF)(Children(5), 1, 6, 216)
					End If

					If REFSubset_Loop2000E_Obj.Count = 0 Then
						REFSubset_Loop2000E_Obj.Add(value)
					Else
						REFSubset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_1_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.REF_1
				Get
					If REF_1Subset_Loop2000E_Obj Is Nothing Then
						REF_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1, Dom.Segments.REF)(Children(5), 1, 6, 1512)
					End If

					If REF_1Subset_Loop2000E_Obj.Count > 0 Then
						Return REF_1Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1)
					If REF_1Subset_Loop2000E_Obj Is Nothing Then
						REF_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1, Dom.Segments.REF)(Children(5), 1, 6, 1512)
					End If

					If REF_1Subset_Loop2000E_Obj.Count = 0 Then
						REF_1Subset_Loop2000E_Obj.Add(value)
					Else
						REF_1Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private REFSubset_1_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF, Dom.Segments.REF)
			Private Property REF_IFace_2_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.REF
				Get
					If REFSubset_1_Loop2000F_Obj Is Nothing Then
						REFSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF, Dom.Segments.REF)(Children(5), 1, 7, 216)
					End If

					If REFSubset_1_Loop2000F_Obj.Count > 0 Then
						Return REFSubset_1_Loop2000F_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF)
					If REFSubset_1_Loop2000F_Obj Is Nothing Then
						REFSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF, Dom.Segments.REF)(Children(5), 1, 7, 216)
					End If

					If REFSubset_1_Loop2000F_Obj.Count = 0 Then
						REFSubset_1_Loop2000F_Obj.Add(value)
					Else
						REFSubset_1_Loop2000F_Obj(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_1_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_3_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.REF_1
				Get
					If REF_1Subset_1_Loop2000F_Obj Is Nothing Then
						REF_1Subset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1, Dom.Segments.REF)(Children(5), 1, 7, 1512)
					End If

					If REF_1Subset_1_Loop2000F_Obj.Count > 0 Then
						Return REF_1Subset_1_Loop2000F_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1)
					If REF_1Subset_1_Loop2000F_Obj Is Nothing Then
						REF_1Subset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1, Dom.Segments.REF)(Children(5), 1, 7, 1512)
					End If

					If REF_1Subset_1_Loop2000F_Obj.Count = 0 Then
						REF_1Subset_1_Loop2000F_Obj.Add(value)
					Else
						REF_1Subset_1_Loop2000F_Obj(0) = value
					End If
				End Set
			End Property
			Private REFSubset_2_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF, Dom.Segments.REF)
			Private Property REF_IFace_4_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.REF
				Get
					If REFSubset_2_Loop2000E_Obj_1 Is Nothing Then
						REFSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF, Dom.Segments.REF)(Children(5), 1, 6, 216)
					End If

					If REFSubset_2_Loop2000E_Obj_1.Count > 0 Then
						Return REFSubset_2_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF)
					If REFSubset_2_Loop2000E_Obj_1 Is Nothing Then
						REFSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF, Dom.Segments.REF)(Children(5), 1, 6, 216)
					End If

					If REFSubset_2_Loop2000E_Obj_1.Count = 0 Then
						REFSubset_2_Loop2000E_Obj_1.Add(value)
					Else
						REFSubset_2_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_2_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_5_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.REF_1
				Get
					If REF_1Subset_2_Loop2000E_Obj_1 Is Nothing Then
						REF_1Subset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1, Dom.Segments.REF)(Children(5), 1, 6, 1512)
					End If

					If REF_1Subset_2_Loop2000E_Obj_1.Count > 0 Then
						Return REF_1Subset_2_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1)
					If REF_1Subset_2_Loop2000E_Obj_1 Is Nothing Then
						REF_1Subset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1, Dom.Segments.REF)(Children(5), 1, 6, 1512)
					End If

					If REF_1Subset_2_Loop2000E_Obj_1.Count = 0 Then
						REF_1Subset_2_Loop2000E_Obj_1.Add(value)
					Else
						REF_1Subset_2_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REFSubset_3_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF, Dom.Segments.REF)
			Private Property REF_IFace_6_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.REF
				Get
					If REFSubset_3_Loop2000F_Obj_1 Is Nothing Then
						REFSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF, Dom.Segments.REF)(Children(5), 1, 7, 216)
					End If

					If REFSubset_3_Loop2000F_Obj_1.Count > 0 Then
						Return REFSubset_3_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF)
					If REFSubset_3_Loop2000F_Obj_1 Is Nothing Then
						REFSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF, Dom.Segments.REF)(Children(5), 1, 7, 216)
					End If

					If REFSubset_3_Loop2000F_Obj_1.Count = 0 Then
						REFSubset_3_Loop2000F_Obj_1.Add(value)
					Else
						REFSubset_3_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Private REF_1Subset_3_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1, Dom.Segments.REF)
			Private Property REF_IFace_7_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.REF_1
				Get
					If REF_1Subset_3_Loop2000F_Obj_1 Is Nothing Then
						REF_1Subset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1, Dom.Segments.REF)(Children(5), 1, 7, 1512)
					End If

					If REF_1Subset_3_Loop2000F_Obj_1.Count > 0 Then
						Return REF_1Subset_3_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1)
					If REF_1Subset_3_Loop2000F_Obj_1 Is Nothing Then
						REF_1Subset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1, Dom.Segments.REF)(Children(5), 1, 7, 1512)
					End If

					If REF_1Subset_3_Loop2000F_Obj_1.Count = 0 Then
						REF_1Subset_3_Loop2000F_Obj_1.Add(value)
					Else
						REF_1Subset_3_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Dom.Segments.DTP) Implements Dom.Transactions.Transaction278.Loops.Loop2000.DTP
				Get
					Return CType(Children(6), SegmentContainer(Of Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP, Dom.Segments.DTP)
			Private Property DTP_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP
				Get
					If DTPSubset_Loop2000E_Obj Is Nothing Then
						DTPSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP, Dom.Segments.DTP)(Children(6), 1, 6, 252)
					End If

					If DTPSubset_Loop2000E_Obj.Count > 0 Then
						Return DTPSubset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP)
					If DTPSubset_Loop2000E_Obj Is Nothing Then
						DTPSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP, Dom.Segments.DTP)(Children(6), 1, 6, 252)
					End If

					If DTPSubset_Loop2000E_Obj.Count = 0 Then
						DTPSubset_Loop2000E_Obj.Add(value)
					Else
						DTPSubset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_1Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)
			Private Property DTP_IFace_1_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_1
				Get
					If DTP_1Subset_Loop2000E_Obj Is Nothing Then
						DTP_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)(Children(6), 1, 6, 2844)
					End If

					If DTP_1Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_1Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1)
					If DTP_1Subset_Loop2000E_Obj Is Nothing Then
						DTP_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)(Children(6), 1, 6, 2844)
					End If

					If DTP_1Subset_Loop2000E_Obj.Count = 0 Then
						DTP_1Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_1Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_2Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)
			Private Property DTP_IFace_2_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_2
				Get
					If DTP_2Subset_Loop2000E_Obj Is Nothing Then
						DTP_2Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)(Children(6), 1, 6, 5436)
					End If

					If DTP_2Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_2Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2)
					If DTP_2Subset_Loop2000E_Obj Is Nothing Then
						DTP_2Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)(Children(6), 1, 6, 5436)
					End If

					If DTP_2Subset_Loop2000E_Obj.Count = 0 Then
						DTP_2Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_2Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_3Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)
			Private Property DTP_IFace_3_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_3
				Get
					If DTP_3Subset_Loop2000E_Obj Is Nothing Then
						DTP_3Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)(Children(6), 1, 6, 8028)
					End If

					If DTP_3Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_3Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3)
					If DTP_3Subset_Loop2000E_Obj Is Nothing Then
						DTP_3Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)(Children(6), 1, 6, 8028)
					End If

					If DTP_3Subset_Loop2000E_Obj.Count = 0 Then
						DTP_3Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_3Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_4Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)
			Private Property DTP_IFace_4_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_4
				Get
					If DTP_4Subset_Loop2000E_Obj Is Nothing Then
						DTP_4Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)(Children(6), 1, 6, 241308)
					End If

					If DTP_4Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_4Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4)
					If DTP_4Subset_Loop2000E_Obj Is Nothing Then
						DTP_4Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)(Children(6), 1, 6, 241308)
					End If

					If DTP_4Subset_Loop2000E_Obj.Count = 0 Then
						DTP_4Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_4Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_5Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)
			Private Property DTP_IFace_5_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_5
				Get
					If DTP_5Subset_Loop2000E_Obj Is Nothing Then
						DTP_5Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)(Children(6), 1, 6, 9324)
					End If

					If DTP_5Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_5Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5)
					If DTP_5Subset_Loop2000E_Obj Is Nothing Then
						DTP_5Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)(Children(6), 1, 6, 9324)
					End If

					If DTP_5Subset_Loop2000E_Obj.Count = 0 Then
						DTP_5Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_5Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTP_6Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)
			Private Property DTP_IFace_6_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.DTP_6
				Get
					If DTP_6Subset_Loop2000E_Obj Is Nothing Then
						DTP_6Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)(Children(6), 1, 6, 242604)
					End If

					If DTP_6Subset_Loop2000E_Obj.Count > 0 Then
						Return DTP_6Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6)
					If DTP_6Subset_Loop2000E_Obj Is Nothing Then
						DTP_6Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)(Children(6), 1, 6, 242604)
					End If

					If DTP_6Subset_Loop2000E_Obj.Count = 0 Then
						DTP_6Subset_Loop2000E_Obj.Add(value)
					Else
						DTP_6Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private DTPSubset_1_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP, Dom.Segments.DTP)
			Private Property DTP_IFace_7_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.DTP
				Get
					If DTPSubset_1_Loop2000F_Obj Is Nothing Then
						DTPSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP, Dom.Segments.DTP)(Children(6), 1, 7, 252)
					End If

					If DTPSubset_1_Loop2000F_Obj.Count > 0 Then
						Return DTPSubset_1_Loop2000F_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP)
					If DTPSubset_1_Loop2000F_Obj Is Nothing Then
						DTPSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP, Dom.Segments.DTP)(Children(6), 1, 7, 252)
					End If

					If DTPSubset_1_Loop2000F_Obj.Count = 0 Then
						DTPSubset_1_Loop2000F_Obj.Add(value)
					Else
						DTPSubset_1_Loop2000F_Obj(0) = value
					End If
				End Set
			End Property
			Private DTPSubset_2_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP, Dom.Segments.DTP)
			Private Property DTP_IFace_8_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP
				Get
					If DTPSubset_2_Loop2000E_Obj_1 Is Nothing Then
						DTPSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP, Dom.Segments.DTP)(Children(6), 1, 6, 252)
					End If

					If DTPSubset_2_Loop2000E_Obj_1.Count > 0 Then
						Return DTPSubset_2_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP)
					If DTPSubset_2_Loop2000E_Obj_1 Is Nothing Then
						DTPSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP, Dom.Segments.DTP)(Children(6), 1, 6, 252)
					End If

					If DTPSubset_2_Loop2000E_Obj_1.Count = 0 Then
						DTPSubset_2_Loop2000E_Obj_1.Add(value)
					Else
						DTPSubset_2_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_1Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)
			Private Property DTP_IFace_9_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_1
				Get
					If DTP_1Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_1Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)(Children(6), 1, 6, 233532)
					End If

					If DTP_1Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_1Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1)
					If DTP_1Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_1Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1, Dom.Segments.DTP)(Children(6), 1, 6, 233532)
					End If

					If DTP_1Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_1Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_1Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_2Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)
			Private Property DTP_IFace_10_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_2
				Get
					If DTP_2Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_2Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)(Children(6), 1, 6, 1548)
					End If

					If DTP_2Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_2Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2)
					If DTP_2Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_2Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2, Dom.Segments.DTP)(Children(6), 1, 6, 1548)
					End If

					If DTP_2Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_2Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_2Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_3Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)
			Private Property DTP_IFace_11_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_3
				Get
					If DTP_3Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_3Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)(Children(6), 1, 6, 234828)
					End If

					If DTP_3Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_3Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3)
					If DTP_3Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_3Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3, Dom.Segments.DTP)(Children(6), 1, 6, 234828)
					End If

					If DTP_3Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_3Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_3Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_4Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)
			Private Property DTP_IFace_12_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_4
				Get
					If DTP_4Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_4Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)(Children(6), 1, 6, 2844)
					End If

					If DTP_4Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_4Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4)
					If DTP_4Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_4Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4, Dom.Segments.DTP)(Children(6), 1, 6, 2844)
					End If

					If DTP_4Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_4Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_4Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_5Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)
			Private Property DTP_IFace_13_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_5
				Get
					If DTP_5Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_5Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)(Children(6), 1, 6, 236124)
					End If

					If DTP_5Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_5Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5)
					If DTP_5Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_5Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5, Dom.Segments.DTP)(Children(6), 1, 6, 236124)
					End If

					If DTP_5Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_5Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_5Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_6Subset_1_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)
			Private Property DTP_IFace_14_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_6
				Get
					If DTP_6Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_6Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)(Children(6), 1, 6, 4140)
					End If

					If DTP_6Subset_1_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_6Subset_1_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6)
					If DTP_6Subset_1_Loop2000E_Obj_1 Is Nothing Then
						DTP_6Subset_1_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6, Dom.Segments.DTP)(Children(6), 1, 6, 4140)
					End If

					If DTP_6Subset_1_Loop2000E_Obj_1.Count = 0 Then
						DTP_6Subset_1_Loop2000E_Obj_1.Add(value)
					Else
						DTP_6Subset_1_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_7Subset_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7, Dom.Segments.DTP)
			Private Property DTP_IFace_15_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_7
				Get
					If DTP_7Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_7Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7, Dom.Segments.DTP)(Children(6), 1, 6, 237420)
					End If

					If DTP_7Subset_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_7Subset_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7)
					If DTP_7Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_7Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7, Dom.Segments.DTP)(Children(6), 1, 6, 237420)
					End If

					If DTP_7Subset_Loop2000E_Obj_1.Count = 0 Then
						DTP_7Subset_Loop2000E_Obj_1.Add(value)
					Else
						DTP_7Subset_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_8Subset_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8, Dom.Segments.DTP)
			Private Property DTP_IFace_16_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_8
				Get
					If DTP_8Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_8Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8, Dom.Segments.DTP)(Children(6), 1, 6, 5436)
					End If

					If DTP_8Subset_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_8Subset_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8)
					If DTP_8Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_8Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8, Dom.Segments.DTP)(Children(6), 1, 6, 5436)
					End If

					If DTP_8Subset_Loop2000E_Obj_1.Count = 0 Then
						DTP_8Subset_Loop2000E_Obj_1.Add(value)
					Else
						DTP_8Subset_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_9Subset_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9, Dom.Segments.DTP)
			Private Property DTP_IFace_17_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.DTP_9
				Get
					If DTP_9Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_9Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9, Dom.Segments.DTP)(Children(6), 1, 6, 238716)
					End If

					If DTP_9Subset_Loop2000E_Obj_1.Count > 0 Then
						Return DTP_9Subset_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9)
					If DTP_9Subset_Loop2000E_Obj_1 Is Nothing Then
						DTP_9Subset_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9, Dom.Segments.DTP)(Children(6), 1, 6, 238716)
					End If

					If DTP_9Subset_Loop2000E_Obj_1.Count = 0 Then
						DTP_9Subset_Loop2000E_Obj_1.Add(value)
					Else
						DTP_9Subset_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTPSubset_3_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP, Dom.Segments.DTP)
			Private Property DTP_IFace_18_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.DTP
				Get
					If DTPSubset_3_Loop2000F_Obj_1 Is Nothing Then
						DTPSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP, Dom.Segments.DTP)(Children(6), 1, 7, 252)
					End If

					If DTPSubset_3_Loop2000F_Obj_1.Count > 0 Then
						Return DTPSubset_3_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP)
					If DTPSubset_3_Loop2000F_Obj_1 Is Nothing Then
						DTPSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP, Dom.Segments.DTP)(Children(6), 1, 7, 252)
					End If

					If DTPSubset_3_Loop2000F_Obj_1.Count = 0 Then
						DTPSubset_3_Loop2000F_Obj_1.Add(value)
					Else
						DTPSubset_3_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_1Subset_2_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1, Dom.Segments.DTP)
			Private Property DTP_IFace_19_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.DTP_1
				Get
					If DTP_1Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_1Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1, Dom.Segments.DTP)(Children(6), 1, 7, 10620)
					End If

					If DTP_1Subset_2_Loop2000F_Obj_1.Count > 0 Then
						Return DTP_1Subset_2_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1)
					If DTP_1Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_1Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1, Dom.Segments.DTP)(Children(6), 1, 7, 10620)
					End If

					If DTP_1Subset_2_Loop2000F_Obj_1.Count = 0 Then
						DTP_1Subset_2_Loop2000F_Obj_1.Add(value)
					Else
						DTP_1Subset_2_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_2Subset_2_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2, Dom.Segments.DTP)
			Private Property DTP_IFace_20_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.DTP_2
				Get
					If DTP_2Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_2Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2, Dom.Segments.DTP)(Children(6), 1, 7, 11916)
					End If

					If DTP_2Subset_2_Loop2000F_Obj_1.Count > 0 Then
						Return DTP_2Subset_2_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2)
					If DTP_2Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_2Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2, Dom.Segments.DTP)(Children(6), 1, 7, 11916)
					End If

					If DTP_2Subset_2_Loop2000F_Obj_1.Count = 0 Then
						DTP_2Subset_2_Loop2000F_Obj_1.Add(value)
					Else
						DTP_2Subset_2_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Private DTP_3Subset_2_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3, Dom.Segments.DTP)
			Private Property DTP_IFace_21_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.DTP_3
				Get
					If DTP_3Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_3Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3, Dom.Segments.DTP)(Children(6), 1, 7, 13212)
					End If

					If DTP_3Subset_2_Loop2000F_Obj_1.Count > 0 Then
						Return DTP_3Subset_2_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3)
					If DTP_3Subset_2_Loop2000F_Obj_1 Is Nothing Then
						DTP_3Subset_2_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3, Dom.Segments.DTP)(Children(6), 1, 7, 13212)
					End If

					If DTP_3Subset_2_Loop2000F_Obj_1.Count = 0 Then
						DTP_3Subset_2_Loop2000F_Obj_1.Add(value)
					Else
						DTP_3Subset_2_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property
			Friend Property HI_Obj As Dom.Segments.HI_Obj
				Get
					Return CType(Children(7), Dom.Segments.HI_Obj)
				End Get
				Set(value As Dom.Segments.HI_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property HI_Std As Dom.Segments.HI Implements Dom.Transactions.Transaction278.Loops.Loop2000.HI
				Get
					Return CType(Children(7), Dom.Segments.HI_Obj)
				End Get
				Set(value As Dom.Segments.HI)
					Children(7) = value
				End Set
			End Property

			Private Property HI_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.HI
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI)
					Children(7) = value
				End Set
			End Property
			Private Property HI_IFace_1_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.HI
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI)
					Children(7) = value
				End Set
			End Property
			Private Property HI_IFace_2_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.HI
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI)
					Children(7) = value
				End Set
			End Property
			Friend Property SV1_Obj As Dom.Segments.SV1_Obj
				Get
					Return CType(Children(8), Dom.Segments.SV1_Obj)
				End Get
				Set(value As Dom.Segments.SV1_Obj)
					Children(8) = value
				End Set
			End Property

			Private Property SV1_Std As Dom.Segments.SV1 Implements Dom.Transactions.Transaction278.Loops.Loop2000.SV1
				Get
					Return CType(Children(8), Dom.Segments.SV1_Obj)
				End Get
				Set(value As Dom.Segments.SV1)
					Children(8) = value
				End Set
			End Property

			Private Property SV1_IFace_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.SV1
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1)
					Children(8) = value
				End Set
			End Property
			Private Property SV1_IFace_1_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.SV1
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1)
					Children(8) = value
				End Set
			End Property
			Friend Property SV2_Obj As Dom.Segments.SV2_Obj
				Get
					Return CType(Children(9), Dom.Segments.SV2_Obj)
				End Get
				Set(value As Dom.Segments.SV2_Obj)
					Children(9) = value
				End Set
			End Property

			Private Property SV2_Std As Dom.Segments.SV2 Implements Dom.Transactions.Transaction278.Loops.Loop2000.SV2
				Get
					Return CType(Children(9), Dom.Segments.SV2_Obj)
				End Get
				Set(value As Dom.Segments.SV2)
					Children(9) = value
				End Set
			End Property

			Private Property SV2_IFace_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.SV2
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2)
					Children(9) = value
				End Set
			End Property
			Private Property SV2_IFace_1_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.SV2
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2)
					Children(9) = value
				End Set
			End Property
			Friend Property SV3_Obj As Dom.Segments.SV3_Obj
				Get
					Return CType(Children(10), Dom.Segments.SV3_Obj)
				End Get
				Set(value As Dom.Segments.SV3_Obj)
					Children(10) = value
				End Set
			End Property

			Private Property SV3_Std As Dom.Segments.SV3 Implements Dom.Transactions.Transaction278.Loops.Loop2000.SV3
				Get
					Return CType(Children(10), Dom.Segments.SV3_Obj)
				End Get
				Set(value As Dom.Segments.SV3)
					Children(10) = value
				End Set
			End Property

			Private Property SV3_IFace_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.SV3
				Get
					Return CType(Children(10), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3)
					Children(10) = value
				End Set
			End Property
			Private Property SV3_IFace_1_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.SV3
				Get
					Return CType(Children(10), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3)
					Children(10) = value
				End Set
			End Property
			Friend ReadOnly Property TOO_Obj As SegmentContainer(Of Dom.Segments.TOO) Implements Dom.Transactions.Transaction278.Loops.Loop2000.TOO
				Get
					Return CType(Children(11), SegmentContainer(Of Dom.Segments.TOO))
				End Get
			End Property

			Private TOOSubset_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO, Dom.Segments.TOO)
			Private ReadOnly Property TOO_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO, Dom.Segments.TOO) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.TOO
				Get
					If TOOSubset_Loop2000F_Obj Is Nothing Then
						TOOSubset_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO, Dom.Segments.TOO)(Children(11), 32, 7, 5472)
					End If

					Return TOOSubset_Loop2000F_Obj
				End Get
			End Property
			Private TOOSubset_1_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO, Dom.Segments.TOO)
			Private ReadOnly Property TOO_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO, Dom.Segments.TOO) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.TOO
				Get
					If TOOSubset_1_Loop2000F_Obj_1 Is Nothing Then
						TOOSubset_1_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO, Dom.Segments.TOO)(Children(11), 32, 7, 5472)
					End If

					Return TOOSubset_1_Loop2000F_Obj_1
				End Get
			End Property
			Friend Property HSD_Obj As Dom.Segments.HSD_Obj
				Get
					Return CType(Children(12), Dom.Segments.HSD_Obj)
				End Get
				Set(value As Dom.Segments.HSD_Obj)
					Children(12) = value
				End Set
			End Property

			Private Property HSD_Std As Dom.Segments.HSD Implements Dom.Transactions.Transaction278.Loops.Loop2000.HSD
				Get
					Return CType(Children(12), Dom.Segments.HSD_Obj)
				End Get
				Set(value As Dom.Segments.HSD)
					Children(12) = value
				End Set
			End Property

			Private Property HSD_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.HSD
				Get
					Return CType(Children(12), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD)
					Children(12) = value
				End Set
			End Property
			Private Property HSD_IFace_1_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.HSD
				Get
					Return CType(Children(12), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD)
					Children(12) = value
				End Set
			End Property
			Private Property HSD_IFace_2_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.HSD
				Get
					Return CType(Children(12), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD)
					Children(12) = value
				End Set
			End Property
			Private Property HSD_IFace_3_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.HSD
				Get
					Return CType(Children(12), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD)
					Children(12) = value
				End Set
			End Property
			Friend ReadOnly Property CRC_Obj As SegmentContainer(Of Dom.Segments.CRC) Implements Dom.Transactions.Transaction278.Loops.Loop2000.CRC
				Get
					Return CType(Children(13), SegmentContainer(Of Dom.Segments.CRC))
				End Get
			End Property

			Private CRCSubset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC, Dom.Segments.CRC)
			Private Property CRC_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC
				Get
					If CRCSubset_Loop2000E_Obj Is Nothing Then
						CRCSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC, Dom.Segments.CRC)(Children(13), 1, 6, 1)
					End If

					If CRCSubset_Loop2000E_Obj.Count > 0 Then
						Return CRCSubset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC)
					If CRCSubset_Loop2000E_Obj Is Nothing Then
						CRCSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC, Dom.Segments.CRC)(Children(13), 1, 6, 1)
					End If

					If CRCSubset_Loop2000E_Obj.Count = 0 Then
						CRCSubset_Loop2000E_Obj.Add(value)
					Else
						CRCSubset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_1Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1, Dom.Segments.CRC)
			Private Property CRC_IFace_1_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_1
				Get
					If CRC_1Subset_Loop2000E_Obj Is Nothing Then
						CRC_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1, Dom.Segments.CRC)(Children(13), 1, 6, 233281)
					End If

					If CRC_1Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_1Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1)
					If CRC_1Subset_Loop2000E_Obj Is Nothing Then
						CRC_1Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1, Dom.Segments.CRC)(Children(13), 1, 6, 233281)
					End If

					If CRC_1Subset_Loop2000E_Obj.Count = 0 Then
						CRC_1Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_1Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_2Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2, Dom.Segments.CRC)
			Private Property CRC_IFace_2_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_2
				Get
					If CRC_2Subset_Loop2000E_Obj Is Nothing Then
						CRC_2Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2, Dom.Segments.CRC)(Children(13), 1, 6, 1297)
					End If

					If CRC_2Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_2Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2)
					If CRC_2Subset_Loop2000E_Obj Is Nothing Then
						CRC_2Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2, Dom.Segments.CRC)(Children(13), 1, 6, 1297)
					End If

					If CRC_2Subset_Loop2000E_Obj.Count = 0 Then
						CRC_2Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_2Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_3Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3, Dom.Segments.CRC)
			Private Property CRC_IFace_3_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_3
				Get
					If CRC_3Subset_Loop2000E_Obj Is Nothing Then
						CRC_3Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3, Dom.Segments.CRC)(Children(13), 1, 6, 234577)
					End If

					If CRC_3Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_3Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3)
					If CRC_3Subset_Loop2000E_Obj Is Nothing Then
						CRC_3Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3, Dom.Segments.CRC)(Children(13), 1, 6, 234577)
					End If

					If CRC_3Subset_Loop2000E_Obj.Count = 0 Then
						CRC_3Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_3Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_4Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4, Dom.Segments.CRC)
			Private Property CRC_IFace_4_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_4
				Get
					If CRC_4Subset_Loop2000E_Obj Is Nothing Then
						CRC_4Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4, Dom.Segments.CRC)(Children(13), 1, 6, 2593)
					End If

					If CRC_4Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_4Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4)
					If CRC_4Subset_Loop2000E_Obj Is Nothing Then
						CRC_4Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4, Dom.Segments.CRC)(Children(13), 1, 6, 2593)
					End If

					If CRC_4Subset_Loop2000E_Obj.Count = 0 Then
						CRC_4Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_4Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_5Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5, Dom.Segments.CRC)
			Private Property CRC_IFace_5_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_5
				Get
					If CRC_5Subset_Loop2000E_Obj Is Nothing Then
						CRC_5Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5, Dom.Segments.CRC)(Children(13), 1, 6, 235873)
					End If

					If CRC_5Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_5Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5)
					If CRC_5Subset_Loop2000E_Obj Is Nothing Then
						CRC_5Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5, Dom.Segments.CRC)(Children(13), 1, 6, 235873)
					End If

					If CRC_5Subset_Loop2000E_Obj.Count = 0 Then
						CRC_5Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_5Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Private CRC_6Subset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6, Dom.Segments.CRC)
			Private Property CRC_IFace_6_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CRC_6
				Get
					If CRC_6Subset_Loop2000E_Obj Is Nothing Then
						CRC_6Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6, Dom.Segments.CRC)(Children(13), 1, 6, 3889)
					End If

					If CRC_6Subset_Loop2000E_Obj.Count > 0 Then
						Return CRC_6Subset_Loop2000E_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6)
					If CRC_6Subset_Loop2000E_Obj Is Nothing Then
						CRC_6Subset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6, Dom.Segments.CRC)(Children(13), 1, 6, 3889)
					End If

					If CRC_6Subset_Loop2000E_Obj.Count = 0 Then
						CRC_6Subset_Loop2000E_Obj.Add(value)
					Else
						CRC_6Subset_Loop2000E_Obj(0) = value
					End If
				End Set
			End Property
			Friend Property CL1_Obj As Dom.Segments.CL1_Obj
				Get
					Return CType(Children(14), Dom.Segments.CL1_Obj)
				End Get
				Set(value As Dom.Segments.CL1_Obj)
					Children(14) = value
				End Set
			End Property

			Private Property CL1_Std As Dom.Segments.CL1 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CL1
				Get
					Return CType(Children(14), Dom.Segments.CL1_Obj)
				End Get
				Set(value As Dom.Segments.CL1)
					Children(14) = value
				End Set
			End Property

			Private Property CL1_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CL1
				Get
					Return CType(Children(14), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1)
					Children(14) = value
				End Set
			End Property
			Private Property CL1_IFace_1_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.CL1
				Get
					Return CType(Children(14), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1)
					Children(14) = value
				End Set
			End Property
			Friend Property CR1_Obj As Dom.Segments.CR1_Obj
				Get
					Return CType(Children(15), Dom.Segments.CR1_Obj)
				End Get
				Set(value As Dom.Segments.CR1_Obj)
					Children(15) = value
				End Set
			End Property

			Private Property CR1_Std As Dom.Segments.CR1 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR1
				Get
					Return CType(Children(15), Dom.Segments.CR1_Obj)
				End Get
				Set(value As Dom.Segments.CR1)
					Children(15) = value
				End Set
			End Property

			Private Property CR1_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CR1
				Get
					Return CType(Children(15), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1)
					Children(15) = value
				End Set
			End Property
			Friend Property CR2_Obj As Dom.Segments.CR2_Obj
				Get
					Return CType(Children(16), Dom.Segments.CR2_Obj)
				End Get
				Set(value As Dom.Segments.CR2_Obj)
					Children(16) = value
				End Set
			End Property

			Private Property CR2_Std As Dom.Segments.CR2 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR2
				Get
					Return CType(Children(16), Dom.Segments.CR2_Obj)
				End Get
				Set(value As Dom.Segments.CR2)
					Children(16) = value
				End Set
			End Property

			Private Property CR2_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CR2
				Get
					Return CType(Children(16), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2)
					Children(16) = value
				End Set
			End Property
			Private Property CR2_IFace_1_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.CR2
				Get
					Return CType(Children(16), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2)
					Children(16) = value
				End Set
			End Property
			Friend Property CR4_Obj As Dom.Segments.CR4_Obj
				Get
					Return CType(Children(17), Dom.Segments.CR4_Obj)
				End Get
				Set(value As Dom.Segments.CR4_Obj)
					Children(17) = value
				End Set
			End Property

			Private Property CR4_Std As Dom.Segments.CR4 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR4
				Get
					Return CType(Children(17), Dom.Segments.CR4_Obj)
				End Get
				Set(value As Dom.Segments.CR4)
					Children(17) = value
				End Set
			End Property

			Friend Property CR5_Obj As Dom.Segments.CR5_Obj
				Get
					Return CType(Children(18), Dom.Segments.CR5_Obj)
				End Get
				Set(value As Dom.Segments.CR5_Obj)
					Children(18) = value
				End Set
			End Property

			Private Property CR5_Std As Dom.Segments.CR5 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR5
				Get
					Return CType(Children(18), Dom.Segments.CR5_Obj)
				End Get
				Set(value As Dom.Segments.CR5)
					Children(18) = value
				End Set
			End Property

			Friend Property CR6_Obj As Dom.Segments.CR6_Obj
				Get
					Return CType(Children(19), Dom.Segments.CR6_Obj)
				End Get
				Set(value As Dom.Segments.CR6_Obj)
					Children(19) = value
				End Set
			End Property

			Private Property CR6_Std As Dom.Segments.CR6 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR6
				Get
					Return CType(Children(19), Dom.Segments.CR6_Obj)
				End Get
				Set(value As Dom.Segments.CR6)
					Children(19) = value
				End Set
			End Property

			Private Property CR6_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.CR6
				Get
					Return CType(Children(19), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6)
					Children(19) = value
				End Set
			End Property
			Private Property CR6_IFace_1_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.CR6
				Get
					Return CType(Children(19), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6)
					Children(19) = value
				End Set
			End Property
			Friend Property CR7_Obj As Dom.Segments.CR7_Obj
				Get
					Return CType(Children(20), Dom.Segments.CR7_Obj)
				End Get
				Set(value As Dom.Segments.CR7_Obj)
					Children(20) = value
				End Set
			End Property

			Private Property CR7_Std As Dom.Segments.CR7 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR7
				Get
					Return CType(Children(20), Dom.Segments.CR7_Obj)
				End Get
				Set(value As Dom.Segments.CR7)
					Children(20) = value
				End Set
			End Property

			Friend Property CR8_Obj As Dom.Segments.CR8_Obj
				Get
					Return CType(Children(21), Dom.Segments.CR8_Obj)
				End Get
				Set(value As Dom.Segments.CR8_Obj)
					Children(21) = value
				End Set
			End Property

			Private Property CR8_Std As Dom.Segments.CR8 Implements Dom.Transactions.Transaction278.Loops.Loop2000.CR8
				Get
					Return CType(Children(21), Dom.Segments.CR8_Obj)
				End Get
				Set(value As Dom.Segments.CR8)
					Children(21) = value
				End Set
			End Property

			Friend ReadOnly Property PWK_Obj As SegmentContainer(Of Dom.Segments.PWK) Implements Dom.Transactions.Transaction278.Loops.Loop2000.PWK
				Get
					Return CType(Children(22), SegmentContainer(Of Dom.Segments.PWK))
				End Get
			End Property

			Private PWKSubset_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK, Dom.Segments.PWK)
			Private ReadOnly Property PWK_Loop2000E_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK, Dom.Segments.PWK) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.PWK
				Get
					If PWKSubset_Loop2000E_Obj Is Nothing Then
						PWKSubset_Loop2000E_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK, Dom.Segments.PWK)(Children(22), 10, 6, 6661)
					End If

					Return PWKSubset_Loop2000E_Obj
				End Get
			End Property
			Private PWKSubset_1_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK, Dom.Segments.PWK)
			Private ReadOnly Property PWK_Loop2000F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK, Dom.Segments.PWK) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.PWK
				Get
					If PWKSubset_1_Loop2000F_Obj Is Nothing Then
						PWKSubset_1_Loop2000F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK, Dom.Segments.PWK)(Children(22), 10, 7, 6661)
					End If

					Return PWKSubset_1_Loop2000F_Obj
				End Get
			End Property
			Private PWKSubset_2_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK, Dom.Segments.PWK)
			Private ReadOnly Property PWK_Loop2000E_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK, Dom.Segments.PWK) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.PWK
				Get
					If PWKSubset_2_Loop2000E_Obj_1 Is Nothing Then
						PWKSubset_2_Loop2000E_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK, Dom.Segments.PWK)(Children(22), 10, 6, 6661)
					End If

					Return PWKSubset_2_Loop2000E_Obj_1
				End Get
			End Property
			Private PWKSubset_3_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK, Dom.Segments.PWK)
			Private ReadOnly Property PWK_Loop2000F_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK, Dom.Segments.PWK) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.PWK
				Get
					If PWKSubset_3_Loop2000F_Obj_1 Is Nothing Then
						PWKSubset_3_Loop2000F_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK, Dom.Segments.PWK)(Children(22), 10, 7, 6661)
					End If

					Return PWKSubset_3_Loop2000F_Obj_1
				End Get
			End Property
			Friend Property MSG_Obj As Dom.Segments.MSG_Obj
				Get
					Return CType(Children(23), Dom.Segments.MSG_Obj)
				End Get
				Set(value As Dom.Segments.MSG_Obj)
					Children(23) = value
				End Set
			End Property

			Private Property MSG_Std As Dom.Segments.MSG Implements Dom.Transactions.Transaction278.Loops.Loop2000.MSG
				Get
					Return CType(Children(23), Dom.Segments.MSG_Obj)
				End Get
				Set(value As Dom.Segments.MSG)
					Children(23) = value
				End Set
			End Property

			Private Property MSG_IFace_Loop2000E_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.MSG
				Get
					Return CType(Children(23), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG)
					Children(23) = value
				End Set
			End Property
			Private Property MSG_IFace_1_Loop2000F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.MSG
				Get
					Return CType(Children(23), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG)
					Children(23) = value
				End Set
			End Property
			Private Property MSG_IFace_2_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.MSG
				Get
					Return CType(Children(23), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG)
					Children(23) = value
				End Set
			End Property
			Private Property MSG_IFace_3_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.MSG
				Get
					Return CType(Children(23), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG)
					Children(23) = value
				End Set
			End Property
			Friend ReadOnly Property Loop2010_Obj As LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Loops.Loop2000.Loop2010
				Get
					Return CType(Children(24), LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2010))
				End Get
			End Property

			Private Loop2010ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010A_IFace_Loop2000A_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A.Loop2010A
				Get
					If Loop2010ASubset_Loop2000A_Obj Is Nothing Then
						Loop2010ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 2, 253)
					End If

					If Loop2010ASubset_Loop2000A_Obj.Count > 0 Then
						Return Loop2010ASubset_Loop2000A_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A)
					If Loop2010ASubset_Loop2000A_Obj Is Nothing Then
						Loop2010ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 2, 253)
					End If

					If Loop2010ASubset_Loop2000A_Obj.Count = 0 Then
						Loop2010ASubset_Loop2000A_Obj.Add(value)
					Else
						Loop2010ASubset_Loop2000A_Obj(0) = value
					End If
				End Set
			End Property
			Private Loop2010BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010B_IFace_Loop2000B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B.Loop2010B
				Get
					If Loop2010BSubset_Loop2000B_Obj Is Nothing Then
						Loop2010BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 3, 253)
					End If

					If Loop2010BSubset_Loop2000B_Obj.Count > 0 Then
						Return Loop2010BSubset_Loop2000B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B)
					If Loop2010BSubset_Loop2000B_Obj Is Nothing Then
						Loop2010BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 3, 253)
					End If

					If Loop2010BSubset_Loop2000B_Obj.Count = 0 Then
						Loop2010BSubset_Loop2000B_Obj.Add(value)
					Else
						Loop2010BSubset_Loop2000B_Obj(0) = value
					End If
				End Set
			End Property
			Private Loop2010CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010C_IFace_Loop2000C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C.Loop2010C
				Get
					If Loop2010CSubset_Loop2000C_Obj Is Nothing Then
						Loop2010CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 4, 253)
					End If

					If Loop2010CSubset_Loop2000C_Obj.Count > 0 Then
						Return Loop2010CSubset_Loop2000C_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C)
					If Loop2010CSubset_Loop2000C_Obj Is Nothing Then
						Loop2010CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 4, 253)
					End If

					If Loop2010CSubset_Loop2000C_Obj.Count = 0 Then
						Loop2010CSubset_Loop2000C_Obj.Add(value)
					Else
						Loop2010CSubset_Loop2000C_Obj(0) = value
					End If
				End Set
			End Property
			Private Loop2010DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010D_IFace_Loop2000D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D.Loop2010D
				Get
					If Loop2010DSubset_Loop2000D_Obj Is Nothing Then
						Loop2010DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 5, 253)
					End If

					If Loop2010DSubset_Loop2000D_Obj.Count > 0 Then
						Return Loop2010DSubset_Loop2000D_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D)
					If Loop2010DSubset_Loop2000D_Obj Is Nothing Then
						Loop2010DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 5, 253)
					End If

					If Loop2010DSubset_Loop2000D_Obj.Count = 0 Then
						Loop2010DSubset_Loop2000D_Obj.Add(value)
					Else
						Loop2010DSubset_Loop2000D_Obj(0) = value
					End If
				End Set
			End Property
			Private Loop2010EASubset_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010EA_Obj_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.Loop2010EA
				Get
					If Loop2010EASubset_Loop2000E_Obj Is Nothing Then
						Loop2010EASubset_Loop2000E_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 14, 6, 253)
					End If

					Return Loop2010EASubset_Loop2000E_Obj
				End Get
			End Property
			Private Loop2010EBSubset_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010EB_Obj_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.Loop2010EB
				Get
					If Loop2010EBSubset_Loop2000E_Obj Is Nothing Then
						Loop2010EBSubset_Loop2000E_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 5, 6, 290)
					End If

					Return Loop2010EBSubset_Loop2000E_Obj
				End Get
			End Property
			Private Loop2010ECSubset_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010EC_Obj_Loop2000E_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E.Loop2010EC
				Get
					If Loop2010ECSubset_Loop2000E_Obj Is Nothing Then
						Loop2010ECSubset_Loop2000E_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 3, 6, 327)
					End If

					Return Loop2010ECSubset_Loop2000E_Obj
				End Get
			End Property
			Private Loop2010FSubset_Loop2000F_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010F_Obj_Loop2000F_Obj As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F.Loop2010F
				Get
					If Loop2010FSubset_Loop2000F_Obj Is Nothing Then
						Loop2010FSubset_Loop2000F_Obj = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 10, 7, 253)
					End If

					Return Loop2010FSubset_Loop2000F_Obj
				End Get
			End Property
			Private Loop2010ASubset_Loop2000A_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010A_IFace_1_Loop2000A_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A.Loop2010A
				Get
					If Loop2010ASubset_Loop2000A_Obj_1 Is Nothing Then
						Loop2010ASubset_Loop2000A_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 2, 253)
					End If

					If Loop2010ASubset_Loop2000A_Obj_1.Count > 0 Then
						Return Loop2010ASubset_Loop2000A_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A)
					If Loop2010ASubset_Loop2000A_Obj_1 Is Nothing Then
						Loop2010ASubset_Loop2000A_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 2, 253)
					End If

					If Loop2010ASubset_Loop2000A_Obj_1.Count = 0 Then
						Loop2010ASubset_Loop2000A_Obj_1.Add(value)
					Else
						Loop2010ASubset_Loop2000A_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2010BSubset_Loop2000B_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010B_Obj_1_Loop2000B_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B.Loop2010B
				Get
					If Loop2010BSubset_Loop2000B_Obj_1 Is Nothing Then
						Loop2010BSubset_Loop2000B_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 2, 3, 253)
					End If

					Return Loop2010BSubset_Loop2000B_Obj_1
				End Get
			End Property
			Private Loop2010CSubset_Loop2000C_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010C_IFace_1_Loop2000C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C.Loop2010C
				Get
					If Loop2010CSubset_Loop2000C_Obj_1 Is Nothing Then
						Loop2010CSubset_Loop2000C_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 4, 253)
					End If

					If Loop2010CSubset_Loop2000C_Obj_1.Count > 0 Then
						Return Loop2010CSubset_Loop2000C_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C)
					If Loop2010CSubset_Loop2000C_Obj_1 Is Nothing Then
						Loop2010CSubset_Loop2000C_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 4, 253)
					End If

					If Loop2010CSubset_Loop2000C_Obj_1.Count = 0 Then
						Loop2010CSubset_Loop2000C_Obj_1.Add(value)
					Else
						Loop2010CSubset_Loop2000C_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2010DSubset_Loop2000D_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010D_IFace_1_Loop2000D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D.Loop2010D
				Get
					If Loop2010DSubset_Loop2000D_Obj_1 Is Nothing Then
						Loop2010DSubset_Loop2000D_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 5, 253)
					End If

					If Loop2010DSubset_Loop2000D_Obj_1.Count > 0 Then
						Return Loop2010DSubset_Loop2000D_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D)
					If Loop2010DSubset_Loop2000D_Obj_1 Is Nothing Then
						Loop2010DSubset_Loop2000D_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 5, 253)
					End If

					If Loop2010DSubset_Loop2000D_Obj_1.Count = 0 Then
						Loop2010DSubset_Loop2000D_Obj_1.Add(value)
					Else
						Loop2010DSubset_Loop2000D_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2010EASubset_Loop2000E_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010EA_Obj_1_Loop2000E_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.Loop2010EA
				Get
					If Loop2010EASubset_Loop2000E_Obj_1 Is Nothing Then
						Loop2010EASubset_Loop2000E_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 14, 6, 253)
					End If

					Return Loop2010EASubset_Loop2000E_Obj_1
				End Get
			End Property
			Private Loop2010EBSubset_Loop2000E_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010EB_IFace_1_Loop2000E_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.Loop2010EB
				Get
					If Loop2010EBSubset_Loop2000E_Obj_1 Is Nothing Then
						Loop2010EBSubset_Loop2000E_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 6, 290)
					End If

					If Loop2010EBSubset_Loop2000E_Obj_1.Count > 0 Then
						Return Loop2010EBSubset_Loop2000E_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB)
					If Loop2010EBSubset_Loop2000E_Obj_1 Is Nothing Then
						Loop2010EBSubset_Loop2000E_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 6, 290)
					End If

					If Loop2010EBSubset_Loop2000E_Obj_1.Count = 0 Then
						Loop2010EBSubset_Loop2000E_Obj_1.Add(value)
					Else
						Loop2010EBSubset_Loop2000E_Obj_1(0) = value
					End If
				End Set
			End Property
			Private Loop2010ECSubset_Loop2000E_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010EC_Obj_1_Loop2000E_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E.Loop2010EC
				Get
					If Loop2010ECSubset_Loop2000E_Obj_1 Is Nothing Then
						Loop2010ECSubset_Loop2000E_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 5, 6, 39)
					End If

					Return Loop2010ECSubset_Loop2000E_Obj_1
				End Get
			End Property
			Private Loop2010FASubset_Loop2000F_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private ReadOnly Property Loop2010FA_Obj_Loop2000F_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA, Dom.Transactions.Transaction278.Loops.Loop2010) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.Loop2010FA
				Get
					If Loop2010FASubset_Loop2000F_Obj_1 Is Nothing Then
						Loop2010FASubset_Loop2000F_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 12, 7, 1513)
					End If

					Return Loop2010FASubset_Loop2000F_Obj_1
				End Get
			End Property
			Private Loop2010FBSubset_Loop2000F_Obj_1 As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB, Dom.Transactions.Transaction278.Loops.Loop2010)
			Private Property Loop2010FB_IFace_Loop2000F_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F.Loop2010FB
				Get
					If Loop2010FBSubset_Loop2000F_Obj_1 Is Nothing Then
						Loop2010FBSubset_Loop2000F_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 7, 253)
					End If

					If Loop2010FBSubset_Loop2000F_Obj_1.Count > 0 Then
						Return Loop2010FBSubset_Loop2000F_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB)
					If Loop2010FBSubset_Loop2000F_Obj_1 Is Nothing Then
						Loop2010FBSubset_Loop2000F_Obj_1 = New LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB, Dom.Transactions.Transaction278.Loops.Loop2010)(Children(24), 1, 7, 253)
					End If

					If Loop2010FBSubset_Loop2000F_Obj_1.Count = 0 Then
						Loop2010FBSubset_Loop2000F_Obj_1.Add(value)
					Else
						Loop2010FBSubset_Loop2000F_Obj_1(0) = value
					End If
				End Set
			End Property

		End Class
		Partial Friend Class Loop2010_Obj
			Inherits LoopBase
			Implements Dom.Transactions.Transaction278.Loops.Loop2010,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC,
											Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA,
											Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB
			Friend Sub New()
				MyBase.New

				Children.AddRange({CType(Nothing, Dom.Segments.NM1_Obj),
														New SegmentContainer(Of Dom.Segments.REF)(9, 2, 1800),
														CType(Nothing, Dom.Segments.N2_Obj),
														CType(Nothing, Dom.Segments.N3_Obj),
														CType(Nothing, Dom.Segments.N4_Obj),
														New SegmentContainer(Of Dom.Segments.PER)(3, 2, 2200),
														New SegmentContainer(Of Dom.Segments.AAA)(9, 2, 2300),
														CType(Nothing, Dom.Segments.PRV_Obj),
														CType(Nothing, Dom.Segments.DMG_Obj),
														CType(Nothing, Dom.Segments.INS_Obj),
														New SegmentContainer(Of Dom.Segments.DTP)(9, 2, 2700)})

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
										New ReaderState(1, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(2, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(4, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(5, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(6, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(7, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(9, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(11, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(12, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(13, "DTP", ReadAction.PopulateSegment, 14, False),
										New ReaderState(14, "DTP", ReadAction.PopulateSegment, 14, False)})

			Friend Overrides Function ReadAsync(args As ReaderArgs) As Task
				Return StateMan.RunAsync(AddressOf PopulateSegment, AddressOf PopulateChildLoop, 0, args)
			End Function

			Private Sub PopulateSegment(ByVal args As ReaderArgs)
				Dim SegmentName As String = args.DataSegment.SegmentID
				Dim Implementation As String = args.Implementation
				Dim Seg As Segment
				If String.Compare(segmentName, "NM1", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					NM1_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.NM1_Obj)
					If MyBase.CompareKey(S2.NM101, ";2B;36;PR;X3;") AndAlso String.Compare(args.Implementation, "_278A1__2000A__2010A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";1P;2B;36;FA;PR;") AndAlso String.Compare(args.Implementation, "_278A1__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_278A1__2000C__2010C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";QC;") AndAlso String.Compare(args.Implementation, "_278A1__2000D__2010D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";71;72;73;77;AAJ;DD;DK;DN;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";45;FS;ND;PW;R3;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EB", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 290
					ElseIf MyBase.CompareKey(S2.NM101, ";00;CA;GG;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EC", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 327
					ElseIf MyBase.CompareKey(S2.NM101, ";1T;72;73;77;DD;DK;DQ;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A1__2000F__2010F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";2B;36;PR;X3;") AndAlso String.Compare(args.Implementation, "_278A3__2000A__2010A", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 2
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";1P;FA;") AndAlso String.Compare(args.Implementation, "_278A3__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_278A3__2000C__2010C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";QC;") AndAlso String.Compare(args.Implementation, "_278A3__2000D__2010D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";71;72;73;77;AAJ;DD;DK;DN;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A3__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 253
					ElseIf MyBase.CompareKey(S2.NM101, ";L5;") AndAlso String.Compare(args.Implementation, "_278A3__2000E__2010EB", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 290
					ElseIf MyBase.CompareKey(S2.NM101, ";45;FS;ND;PW;R3;") AndAlso String.Compare(args.Implementation, "_278A3__2000E__2010EC", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 39
					ElseIf MyBase.CompareKey(S2.NM101, ";72;73;77;DD;DK;DQ;FA;G3;P3;QB;QV;SJ;") AndAlso String.Compare(args.Implementation, "_278A3__2000F__2010FA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 1513
					ElseIf MyBase.CompareKey(S2.NM101, ";L5;") AndAlso String.Compare(args.Implementation, "_278A3__2000F__2010FB", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 253
					End If
				ElseIf String.Compare(segmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					REF_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.REF_Obj)
					If MyBase.CompareKey(S2.REF01, ";1G;1J;EI;G5;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A1__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";1L;3L;6P;DP;EJ;F6;HJ;IG;N6;NQ;SY;") AndAlso String.Compare(args.Implementation, "_278A1__2000C__2010C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";EJ;SY;") AndAlso String.Compare(args.Implementation, "_278A1__2000D__2010D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1G;1J;EI;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";ZZ;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EC", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 4
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1G;1J;EI;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A1__2000F__2010F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";1G;1J;EI;G5;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A3__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";1L;3L;6P;DP;EJ;F6;HJ;IG;N6;NQ;SY;") AndAlso String.Compare(args.Implementation, "_278A3__2000C__2010C", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 4
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";EJ;SY;") AndAlso String.Compare(args.Implementation, "_278A3__2000D__2010D", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 5
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1G;1J;EI;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A3__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 289
					ElseIf MyBase.CompareKey(S2.REF01, ";0B;1G;1J;EI;G5;N5;N7;SY;ZH;") AndAlso String.Compare(args.Implementation, "_278A3__2000F__2010FA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 2809
					End If
				ElseIf String.Compare(segmentName, "N2", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N2_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N2_Obj = Seg
				ElseIf String.Compare(segmentName, "N3", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N3_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N3_Obj = Seg
				ElseIf String.Compare(segmentName, "N4", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.N4_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					N4_Obj = Seg
				ElseIf String.Compare(segmentName, "PER", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PER_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PER_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "AAA", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.AAA_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					AAA_Obj.Add(Seg)
				ElseIf String.Compare(segmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					PRV_Obj = Seg
					Dim S2 = CType(Seg, Dom.Segments.PRV_Obj)
					If MyBase.CompareKey(S2.PRV01, ";AD;AS;AT;CO;CV;OP;OR;OT;PC;PE;RF;") AndAlso String.Compare(args.Implementation, "_278A1__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 146
					ElseIf MyBase.CompareKey(S2.PRV01, ";AD;AS;AT;OP;OR;OT;PC;PE;RF;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 146
					ElseIf MyBase.CompareKey(S2.PRV01, ";AS;OP;OR;OT;PC;PE;") AndAlso String.Compare(args.Implementation, "_278A1__2000F__2010F", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 146
					ElseIf MyBase.CompareKey(S2.PRV01, ";AD;AS;AT;CO;CV;OP;OR;OT;PC;PE;RF;") AndAlso String.Compare(args.Implementation, "_278A3__2000B__2010B", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 3
						Seg.SetSequence = 146
					ElseIf MyBase.CompareKey(S2.PRV01, ";AD;AS;AT;OP;OR;OT;PC;PE;RF;") AndAlso String.Compare(args.Implementation, "_278A3__2000E__2010EA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 146
					ElseIf MyBase.CompareKey(S2.PRV01, ";AS;OP;OR;OT;PC;PE;") AndAlso String.Compare(args.Implementation, "_278A3__2000F__2010FA", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 7
						Seg.SetSequence = 9289
					End If
				ElseIf String.Compare(segmentName, "DMG", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DMG_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DMG_Obj = Seg
				ElseIf String.Compare(segmentName, "INS", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.INS_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					INS_Obj = Seg
				ElseIf String.Compare(segmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg = Dom.Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
					DTP_Obj.Add(Seg)
					Dim S2 = CType(Seg, Dom.Segments.DTP_Obj)
					If MyBase.CompareKey(S2.DTP01, ";598;") AndAlso String.Compare(args.Implementation, "_278A1__2000E__2010EC", StringComparison.OrdinalIgnoreCase) = 0 Then
						Seg.SetArea = 6
						Seg.SetSequence = 328
					End If
				End If
			End Sub

			Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
				Dim LoopID As String = args.ParentLoopID
				Dim Implementation As String = args.Implementation
				Dim Temp = args.Implementation

				args.Implementation = Temp

				Return Task.CompletedTask
			End Function
			Friend Property NM1_Obj As Dom.Segments.NM1_Obj
				Get
					Return CType(Children(0), Dom.Segments.NM1_Obj)
				End Get
				Set(value As Dom.Segments.NM1_Obj)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_Std As Dom.Segments.NM1 Implements Dom.Transactions.Transaction278.Loops.Loop2010.NM1
				Get
					Return CType(Children(0), Dom.Segments.NM1_Obj)
				End Get
				Set(value As Dom.Segments.NM1)
					Children(0) = value
				End Set
			End Property

			Private Property NM1_IFace_Loop2010A_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_1_Loop2010B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_2_Loop2010C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_3_Loop2010D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_4_Loop2010EA_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_5_Loop2010EB_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_6_Loop2010EC_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_7_Loop2010F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_8_Loop2010A_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_9_Loop2010B_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_10_Loop2010C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_11_Loop2010D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_12_Loop2010EA_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_13_Loop2010EB_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_14_Loop2010EC_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_15_Loop2010FA_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.NM1)
					Children(0) = value
				End Set
			End Property
			Private Property NM1_IFace_16_Loop2010FB_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.NM1 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB.NM1
				Get
					Return CType(Children(0), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.NM1)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.NM1)
					Children(0) = value
				End Set
			End Property
			Friend ReadOnly Property REF_Obj As SegmentContainer(Of Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Loops.Loop2010.REF
				Get
					Return CType(Children(1), SegmentContainer(Of Dom.Segments.REF))
				End Get
			End Property

			Private REFSubset_Loop2010B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.REF
				Get
					If REFSubset_Loop2010B_Obj Is Nothing Then
						REFSubset_Loop2010B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF, Dom.Segments.REF)(Children(1), 8, 3, 289)
					End If

					Return REFSubset_Loop2010B_Obj
				End Get
			End Property
			Private REFSubset_1_Loop2010C_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010C_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.REF
				Get
					If REFSubset_1_Loop2010C_Obj Is Nothing Then
						REFSubset_1_Loop2010C_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF, Dom.Segments.REF)(Children(1), 9, 4, 289)
					End If

					Return REFSubset_1_Loop2010C_Obj
				End Get
			End Property
			Private REFSubset_2_Loop2010D_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010D_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.REF
				Get
					If REFSubset_2_Loop2010D_Obj Is Nothing Then
						REFSubset_2_Loop2010D_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF, Dom.Segments.REF)(Children(1), 3, 5, 289)
					End If

					Return REFSubset_2_Loop2010D_Obj
				End Get
			End Property
			Private REFSubset_3_Loop2010EA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010EA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.REF
				Get
					If REFSubset_3_Loop2010EA_Obj Is Nothing Then
						REFSubset_3_Loop2010EA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF, Dom.Segments.REF)(Children(1), 7, 6, 289)
					End If

					Return REFSubset_3_Loop2010EA_Obj
				End Get
			End Property
			Private REFSubset_4_Loop2010EC_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF, Dom.Segments.REF)
			Private Property REF_IFace_4_Loop2010EC_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC.REF
				Get
					If REFSubset_4_Loop2010EC_Obj Is Nothing Then
						REFSubset_4_Loop2010EC_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF, Dom.Segments.REF)(Children(1), 1, 6, 4)
					End If

					If REFSubset_4_Loop2010EC_Obj.Count > 0 Then
						Return REFSubset_4_Loop2010EC_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF)
					If REFSubset_4_Loop2010EC_Obj Is Nothing Then
						REFSubset_4_Loop2010EC_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF, Dom.Segments.REF)(Children(1), 1, 6, 4)
					End If

					If REFSubset_4_Loop2010EC_Obj.Count = 0 Then
						REFSubset_4_Loop2010EC_Obj.Add(value)
					Else
						REFSubset_4_Loop2010EC_Obj(0) = value
					End If
				End Set
			End Property
			Private REFSubset_5_Loop2010F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.REF
				Get
					If REFSubset_5_Loop2010F_Obj Is Nothing Then
						REFSubset_5_Loop2010F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF, Dom.Segments.REF)(Children(1), 8, 7, 289)
					End If

					Return REFSubset_5_Loop2010F_Obj
				End Get
			End Property
			Private REFSubset_6_Loop2010B_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010B_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B.REF
				Get
					If REFSubset_6_Loop2010B_Obj_1 Is Nothing Then
						REFSubset_6_Loop2010B_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.REF, Dom.Segments.REF)(Children(1), 8, 3, 289)
					End If

					Return REFSubset_6_Loop2010B_Obj_1
				End Get
			End Property
			Private REFSubset_7_Loop2010C_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010C_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.REF
				Get
					If REFSubset_7_Loop2010C_Obj_1 Is Nothing Then
						REFSubset_7_Loop2010C_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.REF, Dom.Segments.REF)(Children(1), 9, 4, 289)
					End If

					Return REFSubset_7_Loop2010C_Obj_1
				End Get
			End Property
			Private REFSubset_8_Loop2010D_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010D_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.REF
				Get
					If REFSubset_8_Loop2010D_Obj_1 Is Nothing Then
						REFSubset_8_Loop2010D_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.REF, Dom.Segments.REF)(Children(1), 3, 5, 289)
					End If

					Return REFSubset_8_Loop2010D_Obj_1
				End Get
			End Property
			Private REFSubset_9_Loop2010EA_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010EA_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.REF
				Get
					If REFSubset_9_Loop2010EA_Obj_1 Is Nothing Then
						REFSubset_9_Loop2010EA_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.REF, Dom.Segments.REF)(Children(1), 7, 6, 289)
					End If

					Return REFSubset_9_Loop2010EA_Obj_1
				End Get
			End Property
			Private REFSubset_10_Loop2010FA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.REF, Dom.Segments.REF)
			Private ReadOnly Property REF_Loop2010FA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.REF, Dom.Segments.REF) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.REF
				Get
					If REFSubset_10_Loop2010FA_Obj Is Nothing Then
						REFSubset_10_Loop2010FA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.REF, Dom.Segments.REF)(Children(1), 8, 7, 2809)
					End If

					Return REFSubset_10_Loop2010FA_Obj
				End Get
			End Property
			Friend Property N2_Obj As Dom.Segments.N2_Obj
				Get
					Return CType(Children(2), Dom.Segments.N2_Obj)
				End Get
				Set(value As Dom.Segments.N2_Obj)
					Children(2) = value
				End Set
			End Property

			Private Property N2_Std As Dom.Segments.N2 Implements Dom.Transactions.Transaction278.Loops.Loop2010.N2
				Get
					Return CType(Children(2), Dom.Segments.N2_Obj)
				End Get
				Set(value As Dom.Segments.N2)
					Children(2) = value
				End Set
			End Property

			Friend Property N3_Obj As Dom.Segments.N3_Obj
				Get
					Return CType(Children(3), Dom.Segments.N3_Obj)
				End Get
				Set(value As Dom.Segments.N3_Obj)
					Children(3) = value
				End Set
			End Property

			Private Property N3_Std As Dom.Segments.N3 Implements Dom.Transactions.Transaction278.Loops.Loop2010.N3
				Get
					Return CType(Children(3), Dom.Segments.N3_Obj)
				End Get
				Set(value As Dom.Segments.N3)
					Children(3) = value
				End Set
			End Property

			Private Property N3_IFace_Loop2010B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_1_Loop2010C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_2_Loop2010D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_3_Loop2010EA_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_4_Loop2010EB_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_5_Loop2010F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_6_Loop2010C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_7_Loop2010D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_8_Loop2010EA_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_9_Loop2010EB_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_10_Loop2010EC_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_11_Loop2010FA_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3)
					Children(3) = value
				End Set
			End Property
			Private Property N3_IFace_12_Loop2010FB_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB.N3
				Get
					Return CType(Children(3), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3)
					Children(3) = value
				End Set
			End Property
			Friend Property N4_Obj As Dom.Segments.N4_Obj
				Get
					Return CType(Children(4), Dom.Segments.N4_Obj)
				End Get
				Set(value As Dom.Segments.N4_Obj)
					Children(4) = value
				End Set
			End Property

			Private Property N4_Std As Dom.Segments.N4 Implements Dom.Transactions.Transaction278.Loops.Loop2010.N4
				Get
					Return CType(Children(4), Dom.Segments.N4_Obj)
				End Get
				Set(value As Dom.Segments.N4)
					Children(4) = value
				End Set
			End Property

			Private Property N4_IFace_Loop2010B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_1_Loop2010C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_2_Loop2010D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_3_Loop2010EA_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_4_Loop2010EB_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_5_Loop2010F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4 Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_6_Loop2010C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_7_Loop2010D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_8_Loop2010EA_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_9_Loop2010EB_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_10_Loop2010EC_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_11_Loop2010FA_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4)
					Children(4) = value
				End Set
			End Property
			Private Property N4_IFace_12_Loop2010FB_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4 Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB.N4
				Get
					Return CType(Children(4), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4)
					Children(4) = value
				End Set
			End Property
			Friend ReadOnly Property PER_Obj As SegmentContainer(Of Dom.Segments.PER) Implements Dom.Transactions.Transaction278.Loops.Loop2010.PER
				Get
					Return CType(Children(5), SegmentContainer(Of Dom.Segments.PER))
				End Get
			End Property

			Private PERSubset_Loop2010B_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER, Dom.Segments.PER)
			Private Property PER_IFace_Loop2010B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.PER
				Get
					If PERSubset_Loop2010B_Obj Is Nothing Then
						PERSubset_Loop2010B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER, Dom.Segments.PER)(Children(5), 1, 3, 74)
					End If

					If PERSubset_Loop2010B_Obj.Count > 0 Then
						Return PERSubset_Loop2010B_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER)
					If PERSubset_Loop2010B_Obj Is Nothing Then
						PERSubset_Loop2010B_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER, Dom.Segments.PER)(Children(5), 1, 3, 74)
					End If

					If PERSubset_Loop2010B_Obj.Count = 0 Then
						PERSubset_Loop2010B_Obj.Add(value)
					Else
						PERSubset_Loop2010B_Obj(0) = value
					End If
				End Set
			End Property
			Private PERSubset_1_Loop2010EA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER, Dom.Segments.PER)
			Private Property PER_IFace_1_Loop2010EA_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.PER
				Get
					If PERSubset_1_Loop2010EA_Obj Is Nothing Then
						PERSubset_1_Loop2010EA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER, Dom.Segments.PER)(Children(5), 1, 6, 74)
					End If

					If PERSubset_1_Loop2010EA_Obj.Count > 0 Then
						Return PERSubset_1_Loop2010EA_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER)
					If PERSubset_1_Loop2010EA_Obj Is Nothing Then
						PERSubset_1_Loop2010EA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER, Dom.Segments.PER)(Children(5), 1, 6, 74)
					End If

					If PERSubset_1_Loop2010EA_Obj.Count = 0 Then
						PERSubset_1_Loop2010EA_Obj.Add(value)
					Else
						PERSubset_1_Loop2010EA_Obj(0) = value
					End If
				End Set
			End Property
			Private PERSubset_2_Loop2010F_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER, Dom.Segments.PER)
			Private Property PER_IFace_2_Loop2010F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.PER
				Get
					If PERSubset_2_Loop2010F_Obj Is Nothing Then
						PERSubset_2_Loop2010F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER, Dom.Segments.PER)(Children(5), 1, 7, 74)
					End If

					If PERSubset_2_Loop2010F_Obj.Count > 0 Then
						Return PERSubset_2_Loop2010F_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER)
					If PERSubset_2_Loop2010F_Obj Is Nothing Then
						PERSubset_2_Loop2010F_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER, Dom.Segments.PER)(Children(5), 1, 7, 74)
					End If

					If PERSubset_2_Loop2010F_Obj.Count = 0 Then
						PERSubset_2_Loop2010F_Obj.Add(value)
					Else
						PERSubset_2_Loop2010F_Obj(0) = value
					End If
				End Set
			End Property
			Private PERSubset_3_Loop2010A_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER, Dom.Segments.PER)
			Private Property PER_IFace_3_Loop2010A_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A.PER
				Get
					If PERSubset_3_Loop2010A_Obj_1 Is Nothing Then
						PERSubset_3_Loop2010A_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER, Dom.Segments.PER)(Children(5), 1, 2, 74)
					End If

					If PERSubset_3_Loop2010A_Obj_1.Count > 0 Then
						Return PERSubset_3_Loop2010A_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER)
					If PERSubset_3_Loop2010A_Obj_1 Is Nothing Then
						PERSubset_3_Loop2010A_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER, Dom.Segments.PER)(Children(5), 1, 2, 74)
					End If

					If PERSubset_3_Loop2010A_Obj_1.Count = 0 Then
						PERSubset_3_Loop2010A_Obj_1.Add(value)
					Else
						PERSubset_3_Loop2010A_Obj_1(0) = value
					End If
				End Set
			End Property
			Private PERSubset_4_Loop2010EA_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER, Dom.Segments.PER)
			Private Property PER_IFace_4_Loop2010EA_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.PER
				Get
					If PERSubset_4_Loop2010EA_Obj_1 Is Nothing Then
						PERSubset_4_Loop2010EA_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER, Dom.Segments.PER)(Children(5), 1, 6, 74)
					End If

					If PERSubset_4_Loop2010EA_Obj_1.Count > 0 Then
						Return PERSubset_4_Loop2010EA_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER)
					If PERSubset_4_Loop2010EA_Obj_1 Is Nothing Then
						PERSubset_4_Loop2010EA_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER, Dom.Segments.PER)(Children(5), 1, 6, 74)
					End If

					If PERSubset_4_Loop2010EA_Obj_1.Count = 0 Then
						PERSubset_4_Loop2010EA_Obj_1.Add(value)
					Else
						PERSubset_4_Loop2010EA_Obj_1(0) = value
					End If
				End Set
			End Property
			Private PERSubset_5_Loop2010EB_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER, Dom.Segments.PER)
			Private Property PER_IFace_5_Loop2010EB_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB.PER
				Get
					If PERSubset_5_Loop2010EB_Obj_1 Is Nothing Then
						PERSubset_5_Loop2010EB_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER, Dom.Segments.PER)(Children(5), 1, 6, 6806)
					End If

					If PERSubset_5_Loop2010EB_Obj_1.Count > 0 Then
						Return PERSubset_5_Loop2010EB_Obj_1(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER)
					If PERSubset_5_Loop2010EB_Obj_1 Is Nothing Then
						PERSubset_5_Loop2010EB_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER, Dom.Segments.PER)(Children(5), 1, 6, 6806)
					End If

					If PERSubset_5_Loop2010EB_Obj_1.Count = 0 Then
						PERSubset_5_Loop2010EB_Obj_1.Add(value)
					Else
						PERSubset_5_Loop2010EB_Obj_1(0) = value
					End If
				End Set
			End Property
			Private PERSubset_6_Loop2010FA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER, Dom.Segments.PER)
			Private Property PER_IFace_6_Loop2010FA_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.PER
				Get
					If PERSubset_6_Loop2010FA_Obj Is Nothing Then
						PERSubset_6_Loop2010FA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER, Dom.Segments.PER)(Children(5), 1, 7, 6697)
					End If

					If PERSubset_6_Loop2010FA_Obj.Count > 0 Then
						Return PERSubset_6_Loop2010FA_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER)
					If PERSubset_6_Loop2010FA_Obj Is Nothing Then
						PERSubset_6_Loop2010FA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER, Dom.Segments.PER)(Children(5), 1, 7, 6697)
					End If

					If PERSubset_6_Loop2010FA_Obj.Count = 0 Then
						PERSubset_6_Loop2010FA_Obj.Add(value)
					Else
						PERSubset_6_Loop2010FA_Obj(0) = value
					End If
				End Set
			End Property
			Private PERSubset_7_Loop2010FB_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER, Dom.Segments.PER)
			Private Property PER_IFace_7_Loop2010FB_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB.PER
				Get
					If PERSubset_7_Loop2010FB_Obj Is Nothing Then
						PERSubset_7_Loop2010FB_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER, Dom.Segments.PER)(Children(5), 1, 7, 74)
					End If

					If PERSubset_7_Loop2010FB_Obj.Count > 0 Then
						Return PERSubset_7_Loop2010FB_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER)
					If PERSubset_7_Loop2010FB_Obj Is Nothing Then
						PERSubset_7_Loop2010FB_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER, Dom.Segments.PER)(Children(5), 1, 7, 74)
					End If

					If PERSubset_7_Loop2010FB_Obj.Count = 0 Then
						PERSubset_7_Loop2010FB_Obj.Add(value)
					Else
						PERSubset_7_Loop2010FB_Obj(0) = value
					End If
				End Set
			End Property
			Friend ReadOnly Property AAA_Obj As SegmentContainer(Of Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Loops.Loop2010.AAA
				Get
					Return CType(Children(6), SegmentContainer(Of Dom.Segments.AAA))
				End Get
			End Property

			Private AAASubset_Loop2010A_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010A_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A.AAA
				Get
					If AAASubset_Loop2010A_Obj_1 Is Nothing Then
						AAASubset_Loop2010A_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA, Dom.Segments.AAA)(Children(6), 9, 2, 110)
					End If

					Return AAASubset_Loop2010A_Obj_1
				End Get
			End Property
			Private AAASubset_1_Loop2010B_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010B_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B.AAA
				Get
					If AAASubset_1_Loop2010B_Obj_1 Is Nothing Then
						AAASubset_1_Loop2010B_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA, Dom.Segments.AAA)(Children(6), 9, 3, 110)
					End If

					Return AAASubset_1_Loop2010B_Obj_1
				End Get
			End Property
			Private AAASubset_2_Loop2010C_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010C_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.AAA
				Get
					If AAASubset_2_Loop2010C_Obj_1 Is Nothing Then
						AAASubset_2_Loop2010C_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA, Dom.Segments.AAA)(Children(6), 9, 4, 110)
					End If

					Return AAASubset_2_Loop2010C_Obj_1
				End Get
			End Property
			Private AAASubset_3_Loop2010D_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010D_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.AAA
				Get
					If AAASubset_3_Loop2010D_Obj_1 Is Nothing Then
						AAASubset_3_Loop2010D_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA, Dom.Segments.AAA)(Children(6), 9, 5, 110)
					End If

					Return AAASubset_3_Loop2010D_Obj_1
				End Get
			End Property
			Private AAASubset_4_Loop2010EA_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010EA_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.AAA
				Get
					If AAASubset_4_Loop2010EA_Obj_1 Is Nothing Then
						AAASubset_4_Loop2010EA_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA, Dom.Segments.AAA)(Children(6), 9, 6, 110)
					End If

					Return AAASubset_4_Loop2010EA_Obj_1
				End Get
			End Property
			Private AAASubset_5_Loop2010EC_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010EC_Obj_1 As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC.AAA
				Get
					If AAASubset_5_Loop2010EC_Obj_1 Is Nothing Then
						AAASubset_5_Loop2010EC_Obj_1 = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA, Dom.Segments.AAA)(Children(6), 9, 6, 6627)
					End If

					Return AAASubset_5_Loop2010EC_Obj_1
				End Get
			End Property
			Private AAASubset_6_Loop2010FA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA, Dom.Segments.AAA)
			Private ReadOnly Property AAA_Loop2010FA_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA, Dom.Segments.AAA) Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.AAA
				Get
					If AAASubset_6_Loop2010FA_Obj Is Nothing Then
						AAASubset_6_Loop2010FA_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA, Dom.Segments.AAA)(Children(6), 9, 7, 7993)
					End If

					Return AAASubset_6_Loop2010FA_Obj
				End Get
			End Property
			Friend Property PRV_Obj As Dom.Segments.PRV_Obj
				Get
					Return CType(Children(7), Dom.Segments.PRV_Obj)
				End Get
				Set(value As Dom.Segments.PRV_Obj)
					Children(7) = value
				End Set
			End Property

			Private Property PRV_Std As Dom.Segments.PRV Implements Dom.Transactions.Transaction278.Loops.Loop2010.PRV
				Get
					Return CType(Children(7), Dom.Segments.PRV_Obj)
				End Get
				Set(value As Dom.Segments.PRV)
					Children(7) = value
				End Set
			End Property

			Private Property PRV_IFace_Loop2010B_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV)
					Children(7) = value
				End Set
			End Property
			Private Property PRV_IFace_1_Loop2010EA_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV)
					Children(7) = value
				End Set
			End Property
			Private Property PRV_IFace_2_Loop2010F_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV)
					Children(7) = value
				End Set
			End Property
			Private Property PRV_IFace_3_Loop2010B_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV)
					Children(7) = value
				End Set
			End Property
			Private Property PRV_IFace_4_Loop2010EA_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV)
					Children(7) = value
				End Set
			End Property
			Private Property PRV_IFace_5_Loop2010FA_Obj As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA.PRV
				Get
					Return CType(Children(7), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV)
					Children(7) = value
				End Set
			End Property
			Friend Property DMG_Obj As Dom.Segments.DMG_Obj
				Get
					Return CType(Children(8), Dom.Segments.DMG_Obj)
				End Get
				Set(value As Dom.Segments.DMG_Obj)
					Children(8) = value
				End Set
			End Property

			Private Property DMG_Std As Dom.Segments.DMG Implements Dom.Transactions.Transaction278.Loops.Loop2010.DMG
				Get
					Return CType(Children(8), Dom.Segments.DMG_Obj)
				End Get
				Set(value As Dom.Segments.DMG)
					Children(8) = value
				End Set
			End Property

			Private Property DMG_IFace_Loop2010C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.DMG
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG)
					Children(8) = value
				End Set
			End Property
			Private Property DMG_IFace_1_Loop2010D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.DMG
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG)
					Children(8) = value
				End Set
			End Property
			Private Property DMG_IFace_2_Loop2010C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.DMG
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG)
					Children(8) = value
				End Set
			End Property
			Private Property DMG_IFace_3_Loop2010D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.DMG
				Get
					Return CType(Children(8), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG)
					Children(8) = value
				End Set
			End Property
			Friend Property INS_Obj As Dom.Segments.INS_Obj
				Get
					Return CType(Children(9), Dom.Segments.INS_Obj)
				End Get
				Set(value As Dom.Segments.INS_Obj)
					Children(9) = value
				End Set
			End Property

			Private Property INS_Std As Dom.Segments.INS Implements Dom.Transactions.Transaction278.Loops.Loop2010.INS
				Get
					Return CType(Children(9), Dom.Segments.INS_Obj)
				End Get
				Set(value As Dom.Segments.INS)
					Children(9) = value
				End Set
			End Property

			Private Property INS_IFace_Loop2010C_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C.INS
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS)
					Children(9) = value
				End Set
			End Property
			Private Property INS_IFace_1_Loop2010D_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D.INS
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS)
					Children(9) = value
				End Set
			End Property
			Private Property INS_IFace_2_Loop2010C_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C.INS
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS)
					Children(9) = value
				End Set
			End Property
			Private Property INS_IFace_3_Loop2010D_Obj_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS Implements Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D.INS
				Get
					Return CType(Children(9), Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS)
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS)
					Children(9) = value
				End Set
			End Property
			Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Dom.Segments.DTP) Implements Dom.Transactions.Transaction278.Loops.Loop2010.DTP
				Get
					Return CType(Children(10), SegmentContainer(Of Dom.Segments.DTP))
				End Get
			End Property

			Private DTPSubset_Loop2010EC_Obj As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP, Dom.Segments.DTP)
			Private Property DTP_IFace_Loop2010EC_Obj As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP Implements Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC.DTP
				Get
					If DTPSubset_Loop2010EC_Obj Is Nothing Then
						DTPSubset_Loop2010EC_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP, Dom.Segments.DTP)(Children(10), 1, 6, 328)
					End If

					If DTPSubset_Loop2010EC_Obj.Count > 0 Then
						Return DTPSubset_Loop2010EC_Obj(0)
					Else
						Return Nothing
					End If
				End Get
				Set(value As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP)
					If DTPSubset_Loop2010EC_Obj Is Nothing Then
						DTPSubset_Loop2010EC_Obj = New SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP, Dom.Segments.DTP)(Children(10), 1, 6, 328)
					End If

					If DTPSubset_Loop2010EC_Obj.Count = 0 Then
						DTPSubset_Loop2010EC_Obj.Add(value)
					Else
						DTPSubset_Loop2010EC_Obj(0) = value
					End If
				End Set
			End Property

		End Class
		'''<summary>Health Care Services Review Information</summary>
		'''<remarks></remarks>
		Public Interface Standard
			'''<summary>Transaction Set Header</summary>
			Property ST As Dom.Segments.ST
			'''<summary>Beginning of Hierarchical Transaction</summary>
			Property BHT As Dom.Segments.BHT
			'''<summary>Hierarchical Level</summary>
			ReadOnly Property Loop2000 As LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2000)
			'''<summary>Transaction Set Trailer</summary>
			Property SE As Dom.Segments.SE
		End Interface
		Namespace Loops

			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2000
				Inherits ILoop
				'''<summary>Hierarchical Level</summary>
				Property HL As Dom.Segments.HL
				'''<summary>Trace</summary>
				ReadOnly Property TRN As SegmentContainer(Of Dom.Segments.TRN)
				'''<summary>Request Validation</summary>
				ReadOnly Property AAA As SegmentContainer(Of Dom.Segments.AAA)
				'''<summary>Health Care Services Review Information</summary>
				Property UM As Dom.Segments.UM
				'''<summary>Health Care Services Review</summary>
				Property HCR As Dom.Segments.HCR
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Dom.Segments.DTP)
				'''<summary>Health Care Information Codes</summary>
				Property HI As Dom.Segments.HI
				'''<summary>Professional Service</summary>
				Property SV1 As Dom.Segments.SV1
				'''<summary>Institutional Service</summary>
				Property SV2 As Dom.Segments.SV2
				'''<summary>Dental Service</summary>
				Property SV3 As Dom.Segments.SV3
				'''<summary>Tooth Identification</summary>
				ReadOnly Property TOO As SegmentContainer(Of Dom.Segments.TOO)
				'''<summary>Health Care Services Delivery</summary>
				Property HSD As Dom.Segments.HSD
				'''<summary>Conditions Indicator</summary>
				ReadOnly Property CRC As SegmentContainer(Of Dom.Segments.CRC)
				'''<summary>Claim Codes</summary>
				Property CL1 As Dom.Segments.CL1
				'''<summary>Ambulance Certification</summary>
				Property CR1 As Dom.Segments.CR1
				'''<summary>Chiropractic Certification</summary>
				Property CR2 As Dom.Segments.CR2
				'''<summary>Enteral or Parenteral Therapy Certification</summary>
				Property CR4 As Dom.Segments.CR4
				'''<summary>Oxygen Therapy Certification</summary>
				Property CR5 As Dom.Segments.CR5
				'''<summary>Home Health Care Certification</summary>
				Property CR6 As Dom.Segments.CR6
				'''<summary>Home Health Treatment Plan Certification</summary>
				Property CR7 As Dom.Segments.CR7
				'''<summary>Pacemaker Certification</summary>
				Property CR8 As Dom.Segments.CR8
				'''<summary>Paperwork</summary>
				ReadOnly Property PWK As SegmentContainer(Of Dom.Segments.PWK)
				'''<summary>Message Text</summary>
				Property MSG As Dom.Segments.MSG
				'''<summary>Individual or Organizational Name</summary>
				ReadOnly Property Loop2010 As LoopContainer(Of Dom.Transactions.Transaction278.Loops.Loop2010)
			End Interface
			'''<summary></summary>
			'''<remarks></remarks>
			Public Interface Loop2010
				Inherits ILoop
				'''<summary>Individual or Organizational Name</summary>
				Property NM1 As Dom.Segments.NM1
				'''<summary>Reference Information</summary>
				ReadOnly Property REF As SegmentContainer(Of Dom.Segments.REF)
				'''<summary>Additional Name Information</summary>
				Property N2 As Dom.Segments.N2
				'''<summary>Party Location</summary>
				Property N3 As Dom.Segments.N3
				'''<summary>Geographic Location</summary>
				Property N4 As Dom.Segments.N4
				'''<summary>Administrative Communications Contact</summary>
				ReadOnly Property PER As SegmentContainer(Of Dom.Segments.PER)
				'''<summary>Request Validation</summary>
				ReadOnly Property AAA As SegmentContainer(Of Dom.Segments.AAA)
				'''<summary>Provider Information</summary>
				Property PRV As Dom.Segments.PRV
				'''<summary>Demographic Information</summary>
				Property DMG As Dom.Segments.DMG
				'''<summary>Insured Benefit</summary>
				Property INS As Dom.Segments.INS
				'''<summary>Date or Time or Period</summary>
				ReadOnly Property DTP As SegmentContainer(Of Dom.Segments.DTP)
			End Interface

		End Namespace 'Loops


		Namespace Transaction278_A1
			Namespace Segments

				Namespace Loop2000A

					'''<summary>Utilization Management Organization (UMO) Level</summary>
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

				Namespace Loop2010A

					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Utilization Management Organization (UMO) Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Utilization Management Organization (UMO) First Name</summary>
						Property NM104 As String
						'''<summary>Utilization Management Organization (UMO) Middle Name</summary>
						Property NM105 As String
						'''<summary>Utilization Management Organization (UMO) Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Utilization Management Organization (UMO) Identifier</summary>
						Property NM109 As String
					End Interface
				End Namespace 'Loop2010A

				Namespace Loop2000B

					'''<summary>Requester Level</summary>
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

				Namespace Loop2010B

					'''<summary>Requester Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Requester Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Requester First Name</summary>
						Property NM104 As String
						'''<summary>Requester Middle Name</summary>
						Property NM105 As String
						'''<summary>Requester Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Requester Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Requester Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Requester Supplemental Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Requester Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Requester Address Line</summary>
						Property N301 As String
						'''<summary>Requester Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Requester City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Requester City Name</summary>
						Property N401 As String
						'''<summary>Requester State or Province Code</summary>
						Property N402 As String
						'''<summary>Requester Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Requester Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Requester Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Requester Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Requester Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Requester Contact Communication Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Requester Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010B

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
				End Namespace 'Loop2000C

				Namespace Loop2010C

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
						'''<summary>Subscriber Name Prefix</summary>
						Property NM106 As String
						'''<summary>Subscriber Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Subscriber Primary Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Subscriber Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Subscriber Supplemental Identifier</summary>
						Property REF02 As String
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
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
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
						'''<summary>Use to qualify the patient's relationship to the military.</summary>
						Property INS08 As String
					End Interface
				End Namespace 'Loop2010C

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
				End Namespace 'Loop2000D

				Namespace Loop2010D

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
					'''<summary>Dependent Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Dependent Supplemental Identifier</summary>
						Property REF02 As String
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
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
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
						'''<summary>Birth Sequence Number</summary>
						Property INS17 As Decimal?
					End Interface
				End Namespace 'Loop2010D

				Namespace Loop2000E

					'''<summary>Patient Event Level</summary>
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
					'''<summary>Patient Event Tracking Number</summary>
					Public Interface TRN
						Inherits ISegment

						'''<summary>Trace Type Code</summary>
						Property TRN01 As String
						'''<summary>Patient Event Trace Number</summary>
						Property TRN02 As String
						'''<summary>Use this element to identify the organization that assigned this trace number. TRN03 must be completed to aid requesters and clearinghouses in identifying their TRN in the 278 response.</summary>
						Property TRN03 As String
						'''<summary>Trace Assigning Entity Additional Identifier</summary>
						Property TRN04 As String
					End Interface
					'''<summary>Health Care Services Review Information</summary>
					Public Interface UM
						Inherits ISegment

						'''<summary>Request Category Code</summary>
						Property UM01 As String
						'''<summary>Certification Type Code</summary>
						Property UM02 As String
						'''<summary>Service Type Code</summary>
						Property UM03 As String
						'''<summary>Value at 2000F, Service Level, overrides the patient event for that service only.</summary>
						Property UM04 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023
						'''<summary></summary>
						Property UM05 As Dom.DataElements.Composite.C024
						'''<summary>Level of Service Code</summary>
						Property UM06 As String
						'''<summary>Current Health Condition Code</summary>
						Property UM07 As String
						'''<summary>Prognosis Code</summary>
						Property UM08 As String
						'''<summary>The Release of Information response is limited to the information carried in this service review.</summary>
						Property UM09 As String
						'''<summary>Delay Reason Code</summary>
						Property UM10 As String
					End Interface
					'''<summary>Previous Review Authorization Number</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Review Authorization Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Previous Review Administrative Reference Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Administrative Reference Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Accident Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Accident Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Last Menstrual Period Date</summary>
					Public Interface DTP_1
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Last Menstrual Period Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Estimated Date of Birth</summary>
					Public Interface DTP_2
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Estimated Birth Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Onset of Current Symptoms or Illness Date</summary>
					Public Interface DTP_3
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Onset Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Event Date</summary>
					Public Interface DTP_4
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Event Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Admission Date</summary>
					Public Interface DTP_5
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Admission Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Discharge Date</summary>
					Public Interface DTP_6
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Discharge Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Patient Diagnosis</summary>
					Public Interface HI
						Inherits ISegment

						'''<summary></summary>
						Property HI01 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022
						'''<summary></summary>
						Property HI02 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022
						'''<summary></summary>
						Property HI03 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022
						'''<summary></summary>
						Property HI04 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022
						'''<summary></summary>
						Property HI05 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022
						'''<summary></summary>
						Property HI06 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022
						'''<summary></summary>
						Property HI07 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022
						'''<summary></summary>
						Property HI08 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022
						'''<summary></summary>
						Property HI09 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022
						'''<summary></summary>
						Property HI10 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022
						'''<summary></summary>
						Property HI11 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022
						'''<summary></summary>
						Property HI12 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022
					End Interface
					'''<summary>Health Care Services Delivery</summary>
					Public Interface HSD
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property HSD01 As String
						'''<summary>Service Unit Count</summary>
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
					'''<summary>Ambulance Certification Information</summary>
					Public Interface CRC
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Chiropractic Certification Information</summary>
					Public Interface CRC_1
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Durable Medical Equipment Information</summary>
					Public Interface CRC_2
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Oxygen Therapy Certification Information</summary>
					Public Interface CRC_3
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Functional Limitations Information</summary>
					Public Interface CRC_4
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Activities Permitted Information</summary>
					Public Interface CRC_5
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Mental Status Information</summary>
					Public Interface CRC_6
						Inherits ISegment

						'''<summary>Code Category</summary>
						Property CRC01 As String
						'''<summary>Certification Condition Indicator</summary>
						Property CRC02 As String
						'''<summary>Condition Code</summary>
						Property CRC03 As String
						'''<summary>Condition Code</summary>
						Property CRC04 As String
						'''<summary>Condition Code</summary>
						Property CRC05 As String
						'''<summary>Condition Code</summary>
						Property CRC06 As String
						'''<summary>Condition Code</summary>
						Property CRC07 As String
					End Interface
					'''<summary>Institutional Claim Code</summary>
					Public Interface CL1
						Inherits ISegment

						'''<summary>Admission Type Code</summary>
						Property CL101 As String
						'''<summary>Admission Source Code</summary>
						Property CL102 As String
						'''<summary>Patient Status Code</summary>
						Property CL103 As String
						'''<summary>Nursing Home Residential Status Code</summary>
						Property CL104 As String
					End Interface
					'''<summary>Ambulance Transport Information</summary>
					Public Interface CR1
						Inherits ISegment

						'''<summary>Unit or Basis for Measurement Code</summary>
						Property CR101 As String
						'''<summary>Patient Weight</summary>
						Property CR102 As Decimal?
						'''<summary>Ambulance Transport Code</summary>
						Property CR103 As String
						'''<summary>Ambulance Transport Reason Code</summary>
						Property CR104 As String
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property CR105 As String
						'''<summary>Transport Distance</summary>
						Property CR106 As Decimal?
						'''<summary>Round Trip Purpose Description</summary>
						Property CR109 As String
						'''<summary>Stretcher Purpose Description</summary>
						Property CR110 As String
					End Interface
					'''<summary>Spinal Manipulation Service Information</summary>
					Public Interface CR2
						Inherits ISegment

						'''<summary>Treatment Series Number</summary>
						Property CR201 As Decimal?
						'''<summary>Treatment Count</summary>
						Property CR202 As Decimal?
						'''<summary>Subluxation Level Code</summary>
						Property CR203 As String
						'''<summary>Subluxation Level Code</summary>
						Property CR204 As String
						'''<summary>Patient Condition Code</summary>
						Property CR208 As String
						'''<summary>Complication Indicator</summary>
						Property CR209 As String
						'''<summary>Patient Condition Description</summary>
						Property CR210 As String
						'''<summary>Patient Condition Description</summary>
						Property CR211 As String
						'''<summary>X-ray Availability Indicator</summary>
						Property CR212 As String
					End Interface
					'''<summary>Home Oxygen Therapy Information</summary>
					Public Interface CR5
						Inherits ISegment

						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR503 As String
						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR504 As String
						'''<summary>Equipment Reason Description</summary>
						Property CR505 As String
						'''<summary>Oxygen Flow Rate</summary>
						Property CR506 As Decimal?
						'''<summary>Daily Oxygen Use Count</summary>
						Property CR507 As Decimal?
						'''<summary>Oxygen Use Period Hour Count</summary>
						Property CR508 As Decimal?
						'''<summary>Respiratory Therapist Order Text</summary>
						Property CR509 As String
						'''<summary>Either CR510 or CR511 is required.</summary>
						Property CR510 As Decimal?
						'''<summary>Either CR510 or CR511 is required.</summary>
						Property CR511 As Decimal?
						'''<summary>Oxygen Test Condition Code</summary>
						Property CR512 As String
						'''<summary>Oxygen Test Findings Code</summary>
						Property CR513 As String
						'''<summary>Oxygen Test Findings Code</summary>
						Property CR514 As String
						'''<summary>Oxygen Test Findings Code</summary>
						Property CR515 As String
						'''<summary>Portable Oxygen System Flow Rate</summary>
						Property CR516 As Decimal?
						'''<summary>Oxygen Delivery System Code</summary>
						Property CR517 As String
						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR518 As String
					End Interface
					'''<summary>Home Health Care Information</summary>
					Public Interface CR6
						Inherits ISegment

						'''<summary>Prognosis Code</summary>
						Property CR601 As String
						'''<summary>Home Health Start Date</summary>
						Property CR602 As Date?
						'''<summary>Date Time Period Format Qualifier</summary>
						Property CR603 As String
						'''<summary>Home Health Certification Period</summary>
						Property CR604 As String
						'''<summary>Medicare Coverage Indicator</summary>
						Property CR607 As String
						'''<summary>This element must have the same value as UM02.</summary>
						Property CR608 As String
						'''<summary>Surgery Date</summary>
						Property CR609 As Date?
						'''<summary>Product or Service ID Qualifier</summary>
						Property CR610 As String
						'''<summary>Surgical Procedure Code</summary>
						Property CR611 As String
						'''<summary>Physician Order Date</summary>
						Property CR612 As Date?
						'''<summary>Last Visit Date</summary>
						Property CR613 As Date?
						'''<summary>Physician Contact Date</summary>
						Property CR614 As Date?
						'''<summary>Date Time Period Format Qualifier</summary>
						Property CR615 As String
						'''<summary>Last Admission Period</summary>
						Property CR616 As String
						'''<summary>Patient Location Code</summary>
						Property CR617 As String
					End Interface
					'''<summary>Additional Patient Information</summary>
					Public Interface PWK
						Inherits ISegment

						'''<summary>Attachment Report Type Code</summary>
						Property PWK01 As String
						'''<summary>Report Transmission Code</summary>
						Property PWK02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property PWK05 As String
						'''<summary>Attachment Control Number</summary>
						Property PWK06 As String
						'''<summary>Attachment Description</summary>
						Property PWK07 As String
					End Interface
					'''<summary>Message Text</summary>
					Public Interface MSG
						Inherits ISegment

						'''<summary>Free Form Message Text</summary>
						Property MSG01 As String
					End Interface
				End Namespace 'Loop2000E

				Namespace Loop2010EA

					'''<summary>Patient Event Provider Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Patient Event Provider Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Patient Event Provider First Name</summary>
						Property NM104 As String
						'''<summary>Patient Event Provider Middle Name</summary>
						Property NM105 As String
						'''<summary>Patient Event Provider Name Prefix</summary>
						Property NM106 As String
						'''<summary>Patient Event Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Patient Event Provider Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Patient Event Provider Supplemental Information</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Patient Event Provider Supplemental Identifier</summary>
						Property REF02 As String
						'''<summary>License Number State Code</summary>
						Property REF03 As String
					End Interface
					'''<summary>Patient Event Provider Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Patient Event Provider Address Line</summary>
						Property N301 As String
						'''<summary>Patient Event Provider Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Patient Event City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Patient Event Provider City Name</summary>
						Property N401 As String
						'''<summary>Patient Event Provider State Code</summary>
						Property N402 As String
						'''<summary>Patient Event Provider Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Patient Event Provider Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Patient Event Provider Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Patient Event Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010EA

				Namespace Loop2010EB

					'''<summary>Patient Event Transport Information</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Patient Event Transport Location Name</summary>
						Property NM103 As String
					End Interface
					'''<summary>Patient Event Transport Location Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Patient Event Transport Location Address Line</summary>
						Property N301 As String
						'''<summary>Patient Event Transport Location Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Patient Event Transport Location City/State/ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Patient Event Transport Location City Name</summary>
						Property N401 As String
						'''<summary>Patient Event Transport Location State or Province Code</summary>
						Property N402 As String
						'''<summary>Patient Event Transport Location Postal Zone or ZIP Code</summary>
						Property N403 As String
					End Interface
				End Namespace 'Loop2010EB

				Namespace Loop2010EC

					'''<summary>Patient Event Other UMO Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Other UMO Name</summary>
						Property NM103 As String
					End Interface
					'''<summary>Other UMO Denial Reason</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Other UMO Denial Reason</summary>
						Property REF02 As String
						'''<summary></summary>
						Property REF04 As Dom.DataElements.Composite.C040
					End Interface
					'''<summary>Other UMO Denial Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Other UMO Denial Date</summary>
						Property DTP03 As String
					End Interface
				End Namespace 'Loop2010EC

				Namespace Loop2000F

					'''<summary>Service Level</summary>
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
					'''<summary>Service Trace Number</summary>
					Public Interface TRN
						Inherits ISegment

						'''<summary>Trace Type Code</summary>
						Property TRN01 As String
						'''<summary>Service Trace Number</summary>
						Property TRN02 As String
						'''<summary>Use this element to identify the organization that assigned this trace number. TRN03 must be completed to aid requesters and clearinghouses in identifying their TRN in the 278 response.</summary>
						Property TRN03 As String
						'''<summary>Trace Assigning Entity Additional Identifier</summary>
						Property TRN04 As String
					End Interface
					'''<summary>Health Care Services Review Information</summary>
					Public Interface UM
						Inherits ISegment

						'''<summary>Request Category Code</summary>
						Property UM01 As String
						'''<summary>Certification Type Code</summary>
						Property UM02 As String
						'''<summary>Values at the Service Level override the values entered at the Patient Event Level for this service.</summary>
						Property UM03 As String
						'''<summary></summary>
						Property UM04 As Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023
					End Interface
					'''<summary>Previous Review Authorization Number</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Review Authorization Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Previous Review Administrative Reference Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Administrative Reference Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Service Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Service Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Professional Service</summary>
					Public Interface SV1
						Inherits ISegment

						'''<summary></summary>
						Property SV101 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV102 As Decimal?
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property SV103 As String
						'''<summary>Service Unit Count</summary>
						Property SV104 As Decimal?
						'''<summary></summary>
						Property SV107 As Dom.DataElements.Composite.C004
						'''<summary>EPSDT Indicator</summary>
						Property SV111 As String
						'''<summary>Nursing Home Level of Care</summary>
						Property SV120 As String
					End Interface
					'''<summary>Institutional Service Line</summary>
					Public Interface SV2
						Inherits ISegment

						'''<summary>Service Line Revenue Code</summary>
						Property SV201 As String
						'''<summary></summary>
						Property SV202 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV203 As Decimal?
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property SV204 As String
						'''<summary>Service Unit Count</summary>
						Property SV205 As Decimal?
						'''<summary>Service Line Rate</summary>
						Property SV206 As Decimal?
						'''<summary>Nursing Home Residential Status Code</summary>
						Property SV209 As String
						'''<summary>Nursing Home Level of Care</summary>
						Property SV210 As String
					End Interface
					'''<summary>Dental Service</summary>
					Public Interface SV3
						Inherits ISegment

						'''<summary></summary>
						Property SV301 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV302 As Decimal?
						'''<summary></summary>
						Property SV304 As Dom.DataElements.Composite.C006
						'''<summary>Prosthesis, Crown, or Inlay Code</summary>
						Property SV305 As String
						'''<summary>Number of procedures</summary>
						Property SV306 As Decimal?
						'''<summary>Description</summary>
						Property SV307 As String
					End Interface
					'''<summary>Tooth Information</summary>
					Public Interface TOO
						Inherits ISegment

						'''<summary>Code List Qualifier Code</summary>
						Property TOO01 As String
						'''<summary>Code source 135: American Dental Association Codes</summary>
						Property TOO02 As String
						'''<summary></summary>
						Property TOO03 As Dom.DataElements.Composite.C005
					End Interface
					'''<summary>Health Care Services Delivery</summary>
					Public Interface HSD
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property HSD01 As String
						'''<summary>Service Unit Count</summary>
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
					'''<summary>Additional Service Information</summary>
					Public Interface PWK
						Inherits ISegment

						'''<summary>Attachment Report Type Code</summary>
						Property PWK01 As String
						'''<summary>Report Transmission Code</summary>
						Property PWK02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property PWK05 As String
						'''<summary>Attachment Control Number</summary>
						Property PWK06 As String
						'''<summary>Attachment Description</summary>
						Property PWK07 As String
					End Interface
					'''<summary>Message Text</summary>
					Public Interface MSG
						Inherits ISegment

						'''<summary>Free Form Message Text</summary>
						Property MSG01 As String
					End Interface
				End Namespace 'Loop2000F

				Namespace Loop2010F

					'''<summary>Service Provider Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Service Provider Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Service Provider First Name</summary>
						Property NM104 As String
						'''<summary>Service Provider Middle Name</summary>
						Property NM105 As String
						'''<summary>Service Provider Name Prefix</summary>
						Property NM106 As String
						'''<summary>Service Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Service Provider Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Service Provider Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Service Provider Supplemental Identifier</summary>
						Property REF02 As String
						'''<summary>License Number State Code</summary>
						Property REF03 As String
					End Interface
					'''<summary>Service Provider Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Service Provider Address Line</summary>
						Property N301 As String
						'''<summary>Service Provider Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Service Provider City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Service Provider City Name</summary>
						Property N401 As String
						'''<summary>Service Provider State or Province Code</summary>
						Property N402 As String
						'''<summary>Service Provider Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Service Provider Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Service Provider Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Service Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010F

				'''<summary>Transaction Set Header</summary>
				Public Interface ST
					Inherits ISegment

					'''<summary>Transaction Set Identifier Code</summary>
					Property ST01 As String
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. The number is assigned by the originator and must be unique within a functional group (GS-GE). For example, start with the number 0001 and increment from there. The number also aids in error resolution research. Use the corresponding value in SE02 for this transaction set.</summary>
					Property ST02 As String
					'''<summary>This element must be populated with the guide identifier named in Section 1.2.</summary>
					Property ST03 As String
				End Interface
				'''<summary>Beginning of Hierarchical Transaction</summary>
				Public Interface BHT
					Inherits ISegment

					'''<summary>Hierarchical Structure Code</summary>
					Property BHT01 As String
					'''<summary>Transaction Set Purpose Code</summary>
					Property BHT02 As String
					'''<summary>Use this element to trace the transaction from one point to the next point, such as when the transaction is passed from one clearinghouse to another clearinghouse. This identifier must be returned in the corresponding 278 response transaction's BHT03. This identifier will only be returned by the last entity to handle the 278. This identifier will not be passed through the complete life of the transaction. All recipients of 278 request transactions are required to return the Submitter Transaction Identifier in their 278 response if one is submitted.</summary>
					Property BHT03 As String
					'''<summary>Transaction Set Creation Date</summary>
					Property BHT04 As Date?
					'''<summary>Transaction Set Creation Time</summary>
					Property BHT05 As Timespan?
					'''<summary>Transaction Type Code</summary>
					Property BHT06 As String
				End Interface
				'''<summary>Transaction Set Trailer</summary>
				Public Interface SE
					Inherits ISegment

					'''<summary>Transaction Segment Count</summary>
					Property SE01 As Decimal?
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. The number is assigned by the originator and must be unique within a functional group (GS-GE). For example, start with the number 0001 and increment from there. The number also aids in error resolution research.</summary>
					Property SE02 As String
				End Interface
			End Namespace 'Segments

			Namespace Composites
				Namespace Loop2000E.UM.UM_04
					'''<summary></summary>
					Public Interface C023
						'''<summary>Facility Type Code</summary>
						Property C023_01 As String
						'''<summary>Facility Code Qualifier</summary>
						Property C023_02 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_01
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_02
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_03
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_04
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_05
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_06
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_07
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_08
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_09
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_10
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_11
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_12
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000F.UM.UM_04
					'''<summary></summary>
					Public Interface C023
						'''<summary>Facility Type Code</summary>
						Property C023_01 As String
						'''<summary>Facility Code Qualifier</summary>
						Property C023_02 As String
					End Interface
				End Namespace
			End Namespace 'Composites

			Namespace Loops
				'''<summary>Utilization Management Organization (UMO) Level</summary>
				Public Interface Loop2000A
					Inherits ILoop


					'''<summary>Utilization Management Organization (UMO) Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL

					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Property Loop2010A As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A
				End Interface
				'''<summary>Utilization Management Organization (UMO) Name</summary>
				Public Interface Loop2010A
					Inherits ILoop


					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1
				End Interface
				'''<summary>Requester Level</summary>
				Public Interface Loop2000B
					Inherits ILoop


					'''<summary>Requester Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL

					'''<summary>Requester Name</summary>
					Property Loop2010B As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B
				End Interface
				'''<summary>Requester Name</summary>
				Public Interface Loop2010B
					Inherits ILoop


					'''<summary>Requester Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1

					'''<summary>Requester Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF, Dom.Segments.REF)

					'''<summary>Requester Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3

					'''<summary>Requester City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4

					'''<summary>Requester Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER

					'''<summary>Requester Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV
				End Interface
				'''<summary>Subscriber Level</summary>
				Public Interface Loop2000C
					Inherits ILoop


					'''<summary>Subscriber Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL

					'''<summary>Subscriber Name</summary>
					Property Loop2010C As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C
				End Interface
				'''<summary>Subscriber Name</summary>
				Public Interface Loop2010C
					Inherits ILoop


					'''<summary>Subscriber Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1

					'''<summary>Subscriber Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF, Dom.Segments.REF)

					'''<summary>Subscriber Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3

					'''<summary>Subscriber City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4

					'''<summary>Subscriber Demographic Information</summary>
					Property DMG As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG

					'''<summary>Subscriber Relationship</summary>
					Property INS As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS
				End Interface
				'''<summary>Dependent Level</summary>
				Public Interface Loop2000D
					Inherits ILoop


					'''<summary>Dependent Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL

					'''<summary>Dependent Name</summary>
					Property Loop2010D As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D
				End Interface
				'''<summary>Dependent Name</summary>
				Public Interface Loop2010D
					Inherits ILoop


					'''<summary>Dependent Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1

					'''<summary>Dependent Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF, Dom.Segments.REF)

					'''<summary>Dependent Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3

					'''<summary>Dependent City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4

					'''<summary>Dependent Demographic Information</summary>
					Property DMG As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG

					'''<summary>Dependent Relationship</summary>
					Property INS As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS
				End Interface
				'''<summary>Patient Event Level</summary>
				Public Interface Loop2000E
					Inherits ILoop


					'''<summary>Patient Event Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL

					'''<summary>Patient Event Tracking Number</summary>
					ReadOnly Property TRN As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN, Dom.Segments.TRN)

					'''<summary>Health Care Services Review Information</summary>
					Property UM As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM

					'''<summary>Previous Review Authorization Number</summary>
					Property REF As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF

					'''<summary>Previous Review Administrative Reference Number</summary>
					Property REF_1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1

					'''<summary>Accident Date</summary>
					Property DTP As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP

					'''<summary>Last Menstrual Period Date</summary>
					Property DTP_1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1

					'''<summary>Estimated Date of Birth</summary>
					Property DTP_2 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2

					'''<summary>Onset of Current Symptoms or Illness Date</summary>
					Property DTP_3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3

					'''<summary>Event Date</summary>
					Property DTP_4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4

					'''<summary>Admission Date</summary>
					Property DTP_5 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5

					'''<summary>Discharge Date</summary>
					Property DTP_6 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6

					'''<summary>Patient Diagnosis</summary>
					Property HI As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI

					'''<summary>Health Care Services Delivery</summary>
					Property HSD As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD

					'''<summary>Ambulance Certification Information</summary>
					Property CRC As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC

					'''<summary>Chiropractic Certification Information</summary>
					Property CRC_1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1

					'''<summary>Durable Medical Equipment Information</summary>
					Property CRC_2 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2

					'''<summary>Oxygen Therapy Certification Information</summary>
					Property CRC_3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3

					'''<summary>Functional Limitations Information</summary>
					Property CRC_4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4

					'''<summary>Activities Permitted Information</summary>
					Property CRC_5 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5

					'''<summary>Mental Status Information</summary>
					Property CRC_6 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6

					'''<summary>Institutional Claim Code</summary>
					Property CL1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1

					'''<summary>Ambulance Transport Information</summary>
					Property CR1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1

					'''<summary>Spinal Manipulation Service Information</summary>
					Property CR2 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2

					'''<summary>Home Health Care Information</summary>
					Property CR6 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6

					'''<summary>Additional Patient Information</summary>
					ReadOnly Property PWK As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK, Dom.Segments.PWK)

					'''<summary>Message Text</summary>
					Property MSG As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG

					'''<summary>Patient Event Provider Name</summary>
					ReadOnly Property Loop2010EA As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)

					'''<summary>Patient Event Transport Information</summary>
					ReadOnly Property Loop2010EB As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB, Dom.Transactions.Transaction278.Loops.Loop2010)

					'''<summary>Patient Event Other UMO Name</summary>
					ReadOnly Property Loop2010EC As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)
				End Interface
				'''<summary>Patient Event Provider Name</summary>
				Public Interface Loop2010EA
					Inherits ILoop


					'''<summary>Patient Event Provider Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1

					'''<summary>Patient Event Provider Supplemental Information</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF, Dom.Segments.REF)

					'''<summary>Patient Event Provider Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3

					'''<summary>Patient Event City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4

					'''<summary>Patient Event Provider Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER

					'''<summary>Patient Event Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV
				End Interface
				'''<summary>Patient Event Transport Information</summary>
				Public Interface Loop2010EB
					Inherits ILoop


					'''<summary>Patient Event Transport Information</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1

					'''<summary>Patient Event Transport Location Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3

					'''<summary>Patient Event Transport Location City/State/ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4
				End Interface
				'''<summary>Patient Event Other UMO Name</summary>
				Public Interface Loop2010EC
					Inherits ILoop


					'''<summary>Patient Event Other UMO Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1

					'''<summary>Other UMO Denial Reason</summary>
					Property REF As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF

					'''<summary>Other UMO Denial Date</summary>
					Property DTP As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP
				End Interface
				'''<summary>Service Level</summary>
				Public Interface Loop2000F
					Inherits ILoop


					'''<summary>Service Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL

					'''<summary>Service Trace Number</summary>
					ReadOnly Property TRN As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN, Dom.Segments.TRN)

					'''<summary>Health Care Services Review Information</summary>
					Property UM As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM

					'''<summary>Previous Review Authorization Number</summary>
					Property REF As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF

					'''<summary>Previous Review Administrative Reference Number</summary>
					Property REF_1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1

					'''<summary>Service Date</summary>
					Property DTP As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP

					'''<summary>Professional Service</summary>
					Property SV1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1

					'''<summary>Institutional Service Line</summary>
					Property SV2 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2

					'''<summary>Dental Service</summary>
					Property SV3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3

					'''<summary>Tooth Information</summary>
					ReadOnly Property TOO As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO, Dom.Segments.TOO)

					'''<summary>Health Care Services Delivery</summary>
					Property HSD As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD

					'''<summary>Additional Service Information</summary>
					ReadOnly Property PWK As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK, Dom.Segments.PWK)

					'''<summary>Message Text</summary>
					Property MSG As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG

					'''<summary>Service Provider Name</summary>
					ReadOnly Property Loop2010F As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F, Dom.Transactions.Transaction278.Loops.Loop2010)
				End Interface
				'''<summary>Service Provider Name</summary>
				Public Interface Loop2010F
					Inherits ILoop


					'''<summary>Service Provider Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1

					'''<summary>Service Provider Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF, Dom.Segments.REF)

					'''<summary>Service Provider Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3

					'''<summary>Service Provider City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4

					'''<summary>Service Provider Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER

					'''<summary>Service Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV
				End Interface

			End Namespace 'Loops

			'''<summary>Health Care Services Review Information - Request</summary>
			'''<remarks>
			'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Health Care Services Review Information Transaction Set (278) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to transmit health care service information, such as subscriber, patient, demographic, diagnosis or treatment data for the purpose of request for review, certification, notification or reporting the outcome of a health care services review.<br /><br />Expected users of this transaction set are payors, plan sponsors, providers, utilization management and other entities involved in health care services review.</para>
			'''<para>It is required that separate transaction sets be used for different patients.</para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary>Transaction Set Header</summary>
				Property ST As Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST

				'''<summary>Beginning of Hierarchical Transaction</summary>
				Property BHT As Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT

				'''<summary>Utilization Management Organization (UMO) Level</summary>
				Property Loop2000A As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A

				'''<summary>Requester Level</summary>
				Property Loop2000B As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B

				'''<summary>Subscriber Level</summary>
				Property Loop2000C As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C

				'''<summary>Dependent Level</summary>
				Property Loop2000D As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D

				'''<summary>Patient Event Level</summary>
				Property Loop2000E As Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E

				'''<summary>Service Level</summary>
				ReadOnly Property Loop2000F As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)

				'''<summary>Transaction Set Trailer</summary>
				Property SE As Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE
			End Interface
		End Namespace 'Transaction278_A1

		Namespace Transaction278_A3
			Namespace Segments

				Namespace Loop2000A

					'''<summary>Utilization Management Organization (UMO) Level</summary>
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

				Namespace Loop2010A

					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Utilization Management Organization (UMO) Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Utilization Management Organization (UMO) First Name</summary>
						Property NM104 As String
						'''<summary>Utilization Management Organization (UMO) Middle Name</summary>
						Property NM105 As String
						'''<summary>Utilization Management Organization (UMO) Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Utilization Management Organization (UMO) Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Utilization Management Organization (UMO) Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Utilization Management Organization (UMO) Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Utilization Management Organization (UMO) Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Utilization Management Organization (UMO) Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Utilization Management Organization (UMO) Contact Communication Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Utilization Management Organization (UMO) Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
				End Namespace 'Loop2010A

				Namespace Loop2000B

					'''<summary>Requester Level</summary>
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

				Namespace Loop2010B

					'''<summary>Requester Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Requester Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Requester First Name</summary>
						Property NM104 As String
						'''<summary>Requester Middle Name</summary>
						Property NM105 As String
						'''<summary>Requester Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Requester Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Requester Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Requester Supplemental Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Requester Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
					'''<summary>Requester Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010B

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
				End Namespace 'Loop2000C

				Namespace Loop2010C

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
						'''<summary>Subscriber Name Prefix</summary>
						Property NM106 As String
						'''<summary>Subscriber Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Subscriber Primary Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Subscriber Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Subscriber Supplemental Identifier</summary>
						Property REF02 As String
					End Interface
					'''<summary>Subscriber Mailing Address</summary>
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
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
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
						'''<summary>Use to qualify the patient's relationship to the military.</summary>
						Property INS08 As String
					End Interface
				End Namespace 'Loop2010C

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
				End Namespace 'Loop2000D

				Namespace Loop2010D

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
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Dependent Primary Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Dependent Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Dependent Supplemental Identifier</summary>
						Property REF02 As String
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
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
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
						'''<summary>Birth Sequence Number</summary>
						Property INS17 As Decimal?
					End Interface
				End Namespace 'Loop2010D

				Namespace Loop2000E

					'''<summary>Patient Event Level</summary>
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
					'''<summary>Patient Event Tracking Number</summary>
					Public Interface TRN
						Inherits ISegment

						'''<summary>Trace Type Code</summary>
						Property TRN01 As String
						'''<summary>Patient Event Trace Number</summary>
						Property TRN02 As String
						'''<summary>Use this element to identify the organization that assigned this trace number. If TRN01 is "2", this is the value received in the original 278 request transaction. If TRN01 is "1", use this information to identify the UMO organization that assigned this trace number.</summary>
						Property TRN03 As String
						'''<summary>Trace Assigning Entity Additional Identifier</summary>
						Property TRN04 As String
					End Interface
					'''<summary>Patient Event Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
					'''<summary>Health Care Services Review Information</summary>
					Public Interface UM
						Inherits ISegment

						'''<summary>Request Category Code</summary>
						Property UM01 As String
						'''<summary>Certification Type Code</summary>
						Property UM02 As String
						'''<summary>Service Type Code</summary>
						Property UM03 As String
						'''<summary>Values entered at the Service Level for this data element override values at the Patient Event Level for that service only.</summary>
						Property UM04 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04.C023
						'''<summary>Level of Service Code</summary>
						Property UM06 As String
					End Interface
					'''<summary>Health Care Services Review</summary>
					Public Interface HCR
						Inherits ISegment

						'''<summary>Action Code</summary>
						Property HCR01 As String
						'''<summary>Review Identification Number</summary>
						Property HCR02 As String
						'''<summary>Review Decision Reason Code</summary>
						Property HCR03 As String
						'''<summary>Second Surgical Opinion Indicator</summary>
						Property HCR04 As String
					End Interface
					'''<summary>Administrative Reference Number</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Administrative Reference Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Previous Review Authorization Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Review Authorization Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Accident Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Accident Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Last Menstrual Period Date</summary>
					Public Interface DTP_1
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Last Menstrual Period Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Estimated Date of Birth</summary>
					Public Interface DTP_2
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Estimated Birth Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Onset of Current Symptoms or Illness Date</summary>
					Public Interface DTP_3
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Onset Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Event Date</summary>
					Public Interface DTP_4
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Event Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Admission Date</summary>
					Public Interface DTP_5
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Admission Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Discharge Date</summary>
					Public Interface DTP_6
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Discharge Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Issue Date</summary>
					Public Interface DTP_7
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Issue Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Expiration Date</summary>
					Public Interface DTP_8
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Expiration Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Effective Date</summary>
					Public Interface DTP_9
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Effective Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Patient Diagnosis</summary>
					Public Interface HI
						Inherits ISegment

						'''<summary></summary>
						Property HI01 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01.C022
						'''<summary></summary>
						Property HI02 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02.C022
						'''<summary></summary>
						Property HI03 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03.C022
						'''<summary></summary>
						Property HI04 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04.C022
						'''<summary></summary>
						Property HI05 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05.C022
						'''<summary></summary>
						Property HI06 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06.C022
						'''<summary></summary>
						Property HI07 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07.C022
						'''<summary></summary>
						Property HI08 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08.C022
						'''<summary></summary>
						Property HI09 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09.C022
						'''<summary></summary>
						Property HI10 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10.C022
						'''<summary></summary>
						Property HI11 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11.C022
						'''<summary></summary>
						Property HI12 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12.C022
					End Interface
					'''<summary>Health Care Services Delivery</summary>
					Public Interface HSD
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property HSD01 As String
						'''<summary>Service Unit Count</summary>
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
					'''<summary>Institutional Claim Code</summary>
					Public Interface CL1
						Inherits ISegment

						'''<summary>Admission Type Code</summary>
						Property CL101 As String
						'''<summary>Admission Source Code</summary>
						Property CL102 As String
						'''<summary>Patient Status Code</summary>
						Property CL103 As String
					End Interface
					'''<summary>Ambulance Transport Information</summary>
					Public Interface CR1
						Inherits ISegment

						'''<summary>Ambulance Transport Code</summary>
						Property CR103 As String
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property CR105 As String
						'''<summary>Transport Distance</summary>
						Property CR106 As Decimal?
					End Interface
					'''<summary>Spinal Manipulation Service Information</summary>
					Public Interface CR2
						Inherits ISegment

						'''<summary>Treatment Series Number</summary>
						Property CR201 As Decimal?
						'''<summary>Treatment Count</summary>
						Property CR202 As Decimal?
						'''<summary>Subluxation Level Code</summary>
						Property CR203 As String
						'''<summary>Subluxation Level Code</summary>
						Property CR204 As String
					End Interface
					'''<summary>Home Oxygen Therapy Information</summary>
					Public Interface CR5
						Inherits ISegment

						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR503 As String
						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR504 As String
						'''<summary>Oxygen Flow Rate</summary>
						Property CR506 As Decimal?
						'''<summary>Daily Oxygen Use Count</summary>
						Property CR507 As Decimal?
						'''<summary>Oxygen Use Period Hour Count</summary>
						Property CR508 As Decimal?
						'''<summary>Respiratory Therapist Order Text</summary>
						Property CR509 As String
						'''<summary>Portable Oxygen System Flow Rate</summary>
						Property CR516 As Decimal?
						'''<summary>Oxygen Delivery System Code</summary>
						Property CR517 As String
						'''<summary>Oxygen Equipment Type Code</summary>
						Property CR518 As String
					End Interface
					'''<summary>Home Health Care Information</summary>
					Public Interface CR6
						Inherits ISegment

						'''<summary>Prognosis Code</summary>
						Property CR601 As String
						'''<summary>Home Health Start Date</summary>
						Property CR602 As Date?
						'''<summary>Date Time Period Format Qualifier</summary>
						Property CR603 As String
						'''<summary>Home Health Certification Period</summary>
						Property CR604 As String
						'''<summary>Medicare Coverage Indicator</summary>
						Property CR607 As String
						'''<summary>This element must have the same value as UM02.</summary>
						Property CR608 As String
					End Interface
					'''<summary>Additional Patient Information</summary>
					Public Interface PWK
						Inherits ISegment

						'''<summary>Attachment Report Type Code</summary>
						Property PWK01 As String
						'''<summary>Report Transmission Code</summary>
						Property PWK02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property PWK05 As String
						'''<summary>Attachment Control Number</summary>
						Property PWK06 As String
						'''<summary>Attachment Description</summary>
						Property PWK07 As String
					End Interface
					'''<summary>Message Text</summary>
					Public Interface MSG
						Inherits ISegment

						'''<summary>Free Form Message Text</summary>
						Property MSG01 As String
					End Interface
				End Namespace 'Loop2000E

				Namespace Loop2010EA

					'''<summary>Patient Event Provider Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Patient Event Provider Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Patient Event Provider First Name</summary>
						Property NM104 As String
						'''<summary>Patient Event Provider Middle Name</summary>
						Property NM105 As String
						'''<summary>Patient Event Provider Name Prefix</summary>
						Property NM106 As String
						'''<summary>Patient Event Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Patient Event Provider Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Patient Event Provider Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Patient Event Provider Supplemental Identifier</summary>
						Property REF02 As String
						'''<summary>License Number State Code</summary>
						Property REF03 As String
					End Interface
					'''<summary>Patient Event Provider Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Patient Event Provider Address Line</summary>
						Property N301 As String
						'''<summary>Patient Event Provider Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Patient Event Provider City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Patient Event Provider City Name</summary>
						Property N401 As String
						'''<summary>Patient Event Provider State Code</summary>
						Property N402 As String
						'''<summary>Patient Event Provider Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Provider Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Patient Event Provider Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Patient Event Provider Contact Communications Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Patient Event Provider Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
					'''<summary>Patient Event Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010EA

				Namespace Loop2010EB

					'''<summary>Additional Patient Information Contact Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Response Contact Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Response Contact First Name</summary>
						Property NM104 As String
						'''<summary>Response Contact Middle Name</summary>
						Property NM105 As String
						'''<summary>Response Contact Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Response Contact Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Additional Patient Information Contact Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Response Contact Address Line</summary>
						Property N301 As String
						'''<summary>Response Contact Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Additional Patient Information Contact City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Additional Patient Information Contact City Name</summary>
						Property N401 As String
						'''<summary>Additional Patient Information Contact State Code</summary>
						Property N402 As String
						'''<summary>Additional Patient Information Contact Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Additional Patient Information Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Response Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER08 As String
					End Interface
				End Namespace 'Loop2010EB

				Namespace Loop2010EC

					'''<summary>Patient Event Transport Information</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Patient Event Transport Location Name</summary>
						Property NM103 As String
					End Interface
					'''<summary>Patient Event Transport Location Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Patient Event Transport Location Address Line</summary>
						Property N301 As String
						'''<summary>Patient Event Transport Location Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Patient Event Transport Location City/State/ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Patient Event Transport Location City Name</summary>
						Property N401 As String
						'''<summary>Patient Event Transport Location State or Province Code</summary>
						Property N402 As String
						'''<summary>Patient Event Transport Location Postal Zone or ZIP Code</summary>
						Property N403 As String
					End Interface
					'''<summary>Patient Event Transport Location Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
				End Namespace 'Loop2010EC

				Namespace Loop2000F

					'''<summary>Service Level</summary>
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
					'''<summary>Service Trace Number</summary>
					Public Interface TRN
						Inherits ISegment

						'''<summary>Trace Type Code</summary>
						Property TRN01 As String
						'''<summary>Service Trace Number</summary>
						Property TRN02 As String
						'''<summary>Use this element to identify the organization that assigned this trace number. If TRN01 is "2", this is the value received in the original 278 request transaction. If TRN01 is "1", use this information to identify the UMO organization that assigned this trace number.</summary>
						Property TRN03 As String
						'''<summary>Trace Assigning Entity Additional Identifier</summary>
						Property TRN04 As String
					End Interface
					'''<summary>Service Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
					'''<summary>Health Care Services Review Information</summary>
					Public Interface UM
						Inherits ISegment

						'''<summary>Request Category Code</summary>
						Property UM01 As String
						'''<summary>Certification Type Code</summary>
						Property UM02 As String
						'''<summary>Service Type Code</summary>
						Property UM03 As String
						'''<summary></summary>
						Property UM04 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04.C023
					End Interface
					'''<summary>Health Care Services Review</summary>
					Public Interface HCR
						Inherits ISegment

						'''<summary>Action Code</summary>
						Property HCR01 As String
						'''<summary>Review Identification Number</summary>
						Property HCR02 As String
						'''<summary>Review Decision Reason Code</summary>
						Property HCR03 As String
						'''<summary>Second Surgical Opinion Indicator</summary>
						Property HCR04 As String
					End Interface
					'''<summary>Administrative Reference Number</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Administrative Reference Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Previous Review Authorization Number</summary>
					Public Interface REF_1
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Previous Review Authorization Number</summary>
						Property REF02 As String
					End Interface
					'''<summary>Service Date</summary>
					Public Interface DTP
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Proposed or Actual Service Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Issue Date</summary>
					Public Interface DTP_1
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Issue Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Expiration Date</summary>
					Public Interface DTP_2
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Expiration Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Certification Effective Date</summary>
					Public Interface DTP_3
						Inherits ISegment

						'''<summary>Date Time Qualifier</summary>
						Property DTP01 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property DTP02 As String
						'''<summary>Certification Effective Date</summary>
						Property DTP03 As String
					End Interface
					'''<summary>Request For Additional Information</summary>
					Public Interface HI
						Inherits ISegment

						'''<summary></summary>
						Property HI01 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01.C022
						'''<summary></summary>
						Property HI02 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02.C022
						'''<summary></summary>
						Property HI03 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03.C022
						'''<summary></summary>
						Property HI04 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04.C022
						'''<summary></summary>
						Property HI05 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05.C022
						'''<summary></summary>
						Property HI06 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06.C022
						'''<summary></summary>
						Property HI07 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07.C022
						'''<summary></summary>
						Property HI08 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08.C022
						'''<summary></summary>
						Property HI09 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09.C022
						'''<summary></summary>
						Property HI10 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10.C022
						'''<summary></summary>
						Property HI11 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11.C022
						'''<summary></summary>
						Property HI12 As Dom.Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12.C022
					End Interface
					'''<summary>Professional Service</summary>
					Public Interface SV1
						Inherits ISegment

						'''<summary></summary>
						Property SV101 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV102 As Decimal?
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property SV103 As String
						'''<summary>Service Unit Count</summary>
						Property SV104 As Decimal?
						'''<summary>EPSDT Indicator</summary>
						Property SV111 As String
						'''<summary>Nursing Home Level of Care</summary>
						Property SV120 As String
					End Interface
					'''<summary>Institutional Service Line</summary>
					Public Interface SV2
						Inherits ISegment

						'''<summary>Service Line Revenue Code</summary>
						Property SV201 As String
						'''<summary></summary>
						Property SV202 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV203 As Decimal?
						'''<summary>Unit or Basis for Measurement Code</summary>
						Property SV204 As String
						'''<summary>Service Unit Count</summary>
						Property SV205 As Decimal?
						'''<summary>Service Line Rate</summary>
						Property SV206 As Decimal?
						'''<summary>Nursing Home Level of Care</summary>
						Property SV210 As String
					End Interface
					'''<summary>Dental Service</summary>
					Public Interface SV3
						Inherits ISegment

						'''<summary></summary>
						Property SV301 As Dom.DataElements.Composite.C003
						'''<summary>Service Line Amount</summary>
						Property SV302 As Decimal?
						'''<summary></summary>
						Property SV304 As Dom.DataElements.Composite.C006
						'''<summary>Prosthesis, Crown, or Inlay Code</summary>
						Property SV305 As String
						'''<summary>Number of procedures.</summary>
						Property SV306 As Decimal?
					End Interface
					'''<summary>Tooth Information</summary>
					Public Interface TOO
						Inherits ISegment

						'''<summary>Code List Qualifier Code</summary>
						Property TOO01 As String
						'''<summary>See Code Source 135: American Dental Association Codes.</summary>
						Property TOO02 As String
						'''<summary></summary>
						Property TOO03 As Dom.DataElements.Composite.C005
					End Interface
					'''<summary>Health Care Services Delivery</summary>
					Public Interface HSD
						Inherits ISegment

						'''<summary>Quantity Qualifier</summary>
						Property HSD01 As String
						'''<summary>Service Unit Count</summary>
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
					'''<summary>Additional Service Information</summary>
					Public Interface PWK
						Inherits ISegment

						'''<summary>Attachment Report Type Code</summary>
						Property PWK01 As String
						'''<summary>Report Transmission Code</summary>
						Property PWK02 As String
						'''<summary>Identification Code Qualifier</summary>
						Property PWK05 As String
						'''<summary>Attachment Control Number</summary>
						Property PWK06 As String
						'''<summary>Attachment Description</summary>
						Property PWK07 As String
					End Interface
					'''<summary>Message Text</summary>
					Public Interface MSG
						Inherits ISegment

						'''<summary>Free Form Message Text</summary>
						Property MSG01 As String
					End Interface
				End Namespace 'Loop2000F

				Namespace Loop2010FA

					'''<summary>Service Provider Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Service Provider Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Service Provider First Name</summary>
						Property NM104 As String
						'''<summary>Service Provider Middle Name</summary>
						Property NM105 As String
						'''<summary>Service Provider Name Prefix</summary>
						Property NM106 As String
						'''<summary>Service Provider Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Service Provider Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Service Provider Supplemental Identification</summary>
					Public Interface REF
						Inherits ISegment

						'''<summary>Reference Identification Qualifier</summary>
						Property REF01 As String
						'''<summary>Service Provider Supplemental Identifier</summary>
						Property REF02 As String
						'''<summary>License Number State Code</summary>
						Property REF03 As String
					End Interface
					'''<summary>Service Provider Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Service Provider Address Line</summary>
						Property N301 As String
						'''<summary>Service Provider Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Service Provider City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Service Provider City Name</summary>
						Property N401 As String
						'''<summary>Service Provider State or Province Code</summary>
						Property N402 As String
						'''<summary>Service Provider Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Service Provider Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Service Provider Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Service Provider Contact Communication Number</summary>
						Property PER08 As String
					End Interface
					'''<summary>Service Provider Request Validation</summary>
					Public Interface AAA
						Inherits ISegment

						'''<summary>Valid Request Indicator</summary>
						Property AAA01 As String
						'''<summary>Reject Reason Code</summary>
						Property AAA03 As String
						'''<summary>Follow-up Action Code</summary>
						Property AAA04 As String
					End Interface
					'''<summary>Service Provider Information</summary>
					Public Interface PRV
						Inherits ISegment

						'''<summary>Provider Code</summary>
						Property PRV01 As String
						'''<summary>Reference Identification Qualifier</summary>
						Property PRV02 As String
						'''<summary>Provider Taxonomy Code</summary>
						Property PRV03 As String
					End Interface
				End Namespace 'Loop2010FA

				Namespace Loop2010FB

					'''<summary>Additional Service Information Contact Name</summary>
					Public Interface NM1
						Inherits ISegment

						'''<summary>Entity Identifier Code</summary>
						Property NM101 As String
						'''<summary>Entity Type Qualifier</summary>
						Property NM102 As String
						'''<summary>Response Contact Last or Organization Name</summary>
						Property NM103 As String
						'''<summary>Response Contact First Name</summary>
						Property NM104 As String
						'''<summary>Response Contact Middle Name</summary>
						Property NM105 As String
						'''<summary>Response Contact Name Suffix</summary>
						Property NM107 As String
						'''<summary>Identification Code Qualifier</summary>
						Property NM108 As String
						'''<summary>Response Contact Identifier</summary>
						Property NM109 As String
					End Interface
					'''<summary>Additional Service Information Contact Address</summary>
					Public Interface N3
						Inherits ISegment

						'''<summary>Response Contact Address Line</summary>
						Property N301 As String
						'''<summary>Response Contact Address Line</summary>
						Property N302 As String
					End Interface
					'''<summary>Additional Service Information Contact City, State, ZIP Code</summary>
					Public Interface N4
						Inherits ISegment

						'''<summary>Additional Service Information Contact City Name</summary>
						Property N401 As String
						'''<summary>Additional Service Information Contact State Code</summary>
						Property N402 As String
						'''<summary>Additional Service Information Contact Postal Zone or ZIP Code</summary>
						Property N403 As String
						'''<summary>Country Code</summary>
						Property N404 As String
						'''<summary>Country Subdivision Code</summary>
						Property N407 As String
					End Interface
					'''<summary>Additional Service Information Contact Information</summary>
					Public Interface PER
						Inherits ISegment

						'''<summary>Contact Function Code</summary>
						Property PER01 As String
						'''<summary>Response Contact Name</summary>
						Property PER02 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER03 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER04 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER05 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER06 As String
						'''<summary>Communication Number Qualifier</summary>
						Property PER07 As String
						'''<summary>Response Contact Communication Number</summary>
						Property PER08 As String
					End Interface
				End Namespace 'Loop2010FB

				'''<summary>Transaction Set Header</summary>
				Public Interface ST
					Inherits ISegment

					'''<summary>Transaction Set Identifier Code</summary>
					Property ST01 As String
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. The number is assigned by the originator and must be unique within a functional group (GS-GE). For example, start with the number 0001 and increment from there. The number also aids in error resolution research. Use the corresponding value in SE02 for this transaction set.</summary>
					Property ST02 As String
					'''<summary>This element must be populated with the guide identifier named in Section 1.2.</summary>
					Property ST03 As String
				End Interface
				'''<summary>Beginning of Hierarchical Transaction</summary>
				Public Interface BHT
					Inherits ISegment

					'''<summary>Hierarchical Structure Code</summary>
					Property BHT01 As String
					'''<summary>Transaction Set Purpose Code</summary>
					Property BHT02 As String
					'''<summary>Return the transaction identifier entered in BHT03 on the 278 request.</summary>
					Property BHT03 As String
					'''<summary>Transaction Set Creation Date</summary>
					Property BHT04 As Date?
					'''<summary>Transaction Set Creation Time</summary>
					Property BHT05 As Timespan?
					'''<summary>Transaction Type Code</summary>
					Property BHT06 As String
				End Interface
				'''<summary>Transaction Set Trailer</summary>
				Public Interface SE
					Inherits ISegment

					'''<summary>Transaction Segment Count</summary>
					Property SE01 As Decimal?
					'''<summary>The Transaction Set Control Numbers in ST02 and SE02 must be identical. The number is assigned by the originator and must be unique within a functional group (GS-GE). For example, start with the number 0001 and increment from there. The number also aids in error resolution research.</summary>
					Property SE02 As String
				End Interface
			End Namespace 'Segments

			Namespace Composites
				Namespace Loop2000E.UM.UM_04
					'''<summary></summary>
					Public Interface C023
						'''<summary>Facility Type Code</summary>
						Property C023_01 As String
						'''<summary>Facility Code Qualifier</summary>
						Property C023_02 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_01
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_02
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_03
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_04
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_05
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_06
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_07
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_08
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_09
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_10
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_11
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000E.HI.HI_12
					'''<summary></summary>
					Public Interface C022
						'''<summary>Diagnosis Type Code</summary>
						Property C022_01 As String
						'''<summary>Diagnosis Code</summary>
						Property C022_02 As String
						'''<summary>Date Time Period Format Qualifier</summary>
						Property C022_03 As String
						'''<summary>Diagnosis Date</summary>
						Property C022_04 As String
					End Interface
				End Namespace
				Namespace Loop2000F.UM.UM_04
					'''<summary></summary>
					Public Interface C023
						'''<summary>Facility Type Code</summary>
						Property C023_01 As String
						'''<summary>Facility Code Qualifier</summary>
						Property C023_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_01
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_02
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_03
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_04
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_05
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_06
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_07
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_08
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_09
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_10
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_11
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
				Namespace Loop2000F.HI.HI_12
					'''<summary></summary>
					Public Interface C022
						'''<summary>Code List Qualifier Code</summary>
						Property C022_01 As String
						'''<summary>LOINC Code</summary>
						Property C022_02 As String
					End Interface
				End Namespace
			End Namespace 'Composites

			Namespace Loops
				'''<summary>Utilization Management Organization (UMO) Level</summary>
				Public Interface Loop2000A
					Inherits ILoop


					'''<summary>Utilization Management Organization (UMO) Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL

					'''<summary>Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA, Dom.Segments.AAA)

					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Property Loop2010A As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010A
				End Interface
				'''<summary>Utilization Management Organization (UMO) Name</summary>
				Public Interface Loop2010A
					Inherits ILoop


					'''<summary>Utilization Management Organization (UMO) Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.NM1

					'''<summary>Utilization Management Organization (UMO) Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER

					'''<summary>Utilization Management Organization (UMO) Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA, Dom.Segments.AAA)
				End Interface
				'''<summary>Requester Level</summary>
				Public Interface Loop2000B
					Inherits ILoop


					'''<summary>Requester Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL

					'''<summary>Requester Name</summary>
					ReadOnly Property Loop2010B As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010B, Dom.Transactions.Transaction278.Loops.Loop2010)
				End Interface
				'''<summary>Requester Name</summary>
				Public Interface Loop2010B
					Inherits ILoop


					'''<summary>Requester Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.NM1

					'''<summary>Requester Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.REF, Dom.Segments.REF)

					'''<summary>Requester Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA, Dom.Segments.AAA)

					'''<summary>Requester Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV
				End Interface
				'''<summary>Subscriber Level</summary>
				Public Interface Loop2000C
					Inherits ILoop


					'''<summary>Subscriber Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL

					'''<summary>Subscriber Name</summary>
					Property Loop2010C As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010C
				End Interface
				'''<summary>Subscriber Name</summary>
				Public Interface Loop2010C
					Inherits ILoop


					'''<summary>Subscriber Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.NM1

					'''<summary>Subscriber Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.REF, Dom.Segments.REF)

					'''<summary>Subscriber Mailing Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3

					'''<summary>Subscriber City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4

					'''<summary>Subscriber Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA, Dom.Segments.AAA)

					'''<summary>Subscriber Demographic Information</summary>
					Property DMG As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG

					'''<summary>Subscriber Relationship</summary>
					Property INS As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS
				End Interface
				'''<summary>Dependent Level</summary>
				Public Interface Loop2000D
					Inherits ILoop


					'''<summary>Dependent Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL

					'''<summary>Dependent Name</summary>
					Property Loop2010D As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010D
				End Interface
				'''<summary>Dependent Name</summary>
				Public Interface Loop2010D
					Inherits ILoop


					'''<summary>Dependent Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.NM1

					'''<summary>Dependent Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.REF, Dom.Segments.REF)

					'''<summary>Dependent Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3

					'''<summary>Dependent City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4

					'''<summary>Dependent Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA, Dom.Segments.AAA)

					'''<summary>Dependent Demographic Information</summary>
					Property DMG As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG

					'''<summary>Dependent Relationship</summary>
					Property INS As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS
				End Interface
				'''<summary>Patient Event Level</summary>
				Public Interface Loop2000E
					Inherits ILoop


					'''<summary>Patient Event Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL

					'''<summary>Patient Event Tracking Number</summary>
					ReadOnly Property TRN As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN, Dom.Segments.TRN)

					'''<summary>Patient Event Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA, Dom.Segments.AAA)

					'''<summary>Health Care Services Review Information</summary>
					Property UM As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM

					'''<summary>Health Care Services Review</summary>
					Property HCR As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR

					'''<summary>Administrative Reference Number</summary>
					Property REF As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF

					'''<summary>Previous Review Authorization Number</summary>
					Property REF_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.REF_1

					'''<summary>Accident Date</summary>
					Property DTP As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP

					'''<summary>Last Menstrual Period Date</summary>
					Property DTP_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_1

					'''<summary>Estimated Date of Birth</summary>
					Property DTP_2 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_2

					'''<summary>Onset of Current Symptoms or Illness Date</summary>
					Property DTP_3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_3

					'''<summary>Event Date</summary>
					Property DTP_4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_4

					'''<summary>Admission Date</summary>
					Property DTP_5 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_5

					'''<summary>Discharge Date</summary>
					Property DTP_6 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_6

					'''<summary>Certification Issue Date</summary>
					Property DTP_7 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_7

					'''<summary>Certification Expiration Date</summary>
					Property DTP_8 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_8

					'''<summary>Certification Effective Date</summary>
					Property DTP_9 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.DTP_9

					'''<summary>Patient Diagnosis</summary>
					Property HI As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI

					'''<summary>Health Care Services Delivery</summary>
					Property HSD As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD

					'''<summary>Institutional Claim Code</summary>
					Property CL1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1

					'''<summary>Spinal Manipulation Service Information</summary>
					Property CR2 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2

					'''<summary>Home Health Care Information</summary>
					Property CR6 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6

					'''<summary>Additional Patient Information</summary>
					ReadOnly Property PWK As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK, Dom.Segments.PWK)

					'''<summary>Message Text</summary>
					Property MSG As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG

					'''<summary>Patient Event Provider Name</summary>
					ReadOnly Property Loop2010EA As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EA, Dom.Transactions.Transaction278.Loops.Loop2010)

					'''<summary>Additional Patient Information Contact Name</summary>
					Property Loop2010EB As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EB

					'''<summary>Patient Event Transport Information</summary>
					ReadOnly Property Loop2010EC As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010EC, Dom.Transactions.Transaction278.Loops.Loop2010)
				End Interface
				'''<summary>Patient Event Provider Name</summary>
				Public Interface Loop2010EA
					Inherits ILoop


					'''<summary>Patient Event Provider Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.NM1

					'''<summary>Patient Event Provider Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.REF, Dom.Segments.REF)

					'''<summary>Patient Event Provider Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3

					'''<summary>Patient Event Provider City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4

					'''<summary>Provider Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER

					'''<summary>Patient Event Provider Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA, Dom.Segments.AAA)

					'''<summary>Patient Event Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV
				End Interface
				'''<summary>Additional Patient Information Contact Name</summary>
				Public Interface Loop2010EB
					Inherits ILoop


					'''<summary>Additional Patient Information Contact Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.NM1

					'''<summary>Additional Patient Information Contact Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3

					'''<summary>Additional Patient Information Contact City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4

					'''<summary>Additional Patient Information Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER
				End Interface
				'''<summary>Patient Event Transport Information</summary>
				Public Interface Loop2010EC
					Inherits ILoop


					'''<summary>Patient Event Transport Information</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.NM1

					'''<summary>Patient Event Transport Location Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3

					'''<summary>Patient Event Transport Location City/State/ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4

					'''<summary>Patient Event Transport Location Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA, Dom.Segments.AAA)
				End Interface
				'''<summary>Service Level</summary>
				Public Interface Loop2000F
					Inherits ILoop


					'''<summary>Service Level</summary>
					Property HL As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL

					'''<summary>Service Trace Number</summary>
					ReadOnly Property TRN As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN, Dom.Segments.TRN)

					'''<summary>Service Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA, Dom.Segments.AAA)

					'''<summary>Health Care Services Review Information</summary>
					Property UM As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM

					'''<summary>Health Care Services Review</summary>
					Property HCR As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR

					'''<summary>Administrative Reference Number</summary>
					Property REF As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF

					'''<summary>Previous Review Authorization Number</summary>
					Property REF_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.REF_1

					'''<summary>Service Date</summary>
					Property DTP As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP

					'''<summary>Certification Issue Date</summary>
					Property DTP_1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_1

					'''<summary>Certification Expiration Date</summary>
					Property DTP_2 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_2

					'''<summary>Certification Effective Date</summary>
					Property DTP_3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.DTP_3

					'''<summary>Request For Additional Information</summary>
					Property HI As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI

					'''<summary>Professional Service</summary>
					Property SV1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1

					'''<summary>Institutional Service Line</summary>
					Property SV2 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2

					'''<summary>Dental Service</summary>
					Property SV3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3

					'''<summary>Tooth Information</summary>
					ReadOnly Property TOO As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO, Dom.Segments.TOO)

					'''<summary>Health Care Services Delivery</summary>
					Property HSD As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD

					'''<summary>Additional Service Information</summary>
					ReadOnly Property PWK As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK, Dom.Segments.PWK)

					'''<summary>Message Text</summary>
					Property MSG As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG

					'''<summary>Service Provider Name</summary>
					ReadOnly Property Loop2010FA As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FA, Dom.Transactions.Transaction278.Loops.Loop2010)

					'''<summary>Additional Service Information Contact Name</summary>
					Property Loop2010FB As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2010FB
				End Interface
				'''<summary>Service Provider Name</summary>
				Public Interface Loop2010FA
					Inherits ILoop


					'''<summary>Service Provider Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.NM1

					'''<summary>Service Provider Supplemental Identification</summary>
					ReadOnly Property REF As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.REF, Dom.Segments.REF)

					'''<summary>Service Provider Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3

					'''<summary>Service Provider City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4

					'''<summary>Service Provider Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER

					'''<summary>Service Provider Request Validation</summary>
					ReadOnly Property AAA As SegmentSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA, Dom.Segments.AAA)

					'''<summary>Service Provider Information</summary>
					Property PRV As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV
				End Interface
				'''<summary>Additional Service Information Contact Name</summary>
				Public Interface Loop2010FB
					Inherits ILoop


					'''<summary>Additional Service Information Contact Name</summary>
					Property NM1 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.NM1

					'''<summary>Additional Service Information Contact Address</summary>
					Property N3 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3

					'''<summary>Additional Service Information Contact City, State, ZIP Code</summary>
					Property N4 As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4

					'''<summary>Additional Service Information Contact Information</summary>
					Property PER As Dom.Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER
				End Interface

			End Namespace 'Loops

			'''<summary>Health Care Services Review Information - Response</summary>
			'''<remarks>
			'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Health Care Services Review Information Transaction Set (278) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to transmit health care service information, such as subscriber, patient, demographic, diagnosis or treatment data for the purpose of request for review, certification, notification or reporting the outcome of a health care services review.<br /><br />Expected users of this transaction set are payors, plan sponsors, providers, utilization management and other entities involved in health care services review.</para>
			'''<para>It is required that separate transaction sets be used for different patients.</para>
			'''</remarks>
			Public Interface TransactionSet

				'''<summary>Transaction Set Header</summary>
				Property ST As Dom.Transactions.Transaction278.Transaction278_A3.Segments.ST

				'''<summary>Beginning of Hierarchical Transaction</summary>
				Property BHT As Dom.Transactions.Transaction278.Transaction278_A3.Segments.BHT

				'''<summary>Utilization Management Organization (UMO) Level</summary>
				Property Loop2000A As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000A

				'''<summary>Requester Level</summary>
				Property Loop2000B As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000B

				'''<summary>Subscriber Level</summary>
				Property Loop2000C As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000C

				'''<summary>Dependent Level</summary>
				Property Loop2000D As Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000D

				'''<summary>Patient Event Level</summary>
				ReadOnly Property Loop2000E As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000E, Dom.Transactions.Transaction278.Loops.Loop2000)

				'''<summary>Service Level</summary>
				ReadOnly Property Loop2000F As LoopSubsetContainer(Of Dom.Transactions.Transaction278.Transaction278_A3.Loops.Loop2000F, Dom.Transactions.Transaction278.Loops.Loop2000)

				'''<summary>Transaction Set Trailer</summary>
				Property SE As Dom.Transactions.Transaction278.Transaction278_A3.Segments.SE
			End Interface
		End Namespace 'Transaction278_A3
	End Namespace 'Transaction278
End Namespace 'Transaction278
