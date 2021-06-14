Namespace Transactions.Transaction270

	Partial Friend Class Standard_Obj
		Inherits TransactionSet
		Implements Standard, Transaction270_B1.TransactionSet
		Friend Sub New(versionCode As String)
			Me.New(String.Empty, versionCode)
		End Sub

		Friend Sub New(controlNumber As String, versionCode As String)
			MyBase.New("HS", versionCode)

			Children.AddRange({New Segments.ST_Obj,
															CType(Nothing, Segments.BHT_Obj),
															New LoopContainer(Of Loops.Loop2000)(0, 2, 100),
															New Segments.SE_Obj})

			ST_Obj.ST01 = "270"
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
				If CompareKey(S2.ST01, ";270;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
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
				If CompareKey(LoopKey, ";20;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000A"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";21;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000B"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";22;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000C"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";23;") AndAlso String.Compare(args.Implementation, "_270B1", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000D"
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

		Private Property ST_IFace_Transaction270_B1 As Transaction270_B1.Segments.ST Implements Transaction270_B1.TransactionSet.ST
			Get
				Return CType(Children(0), Transaction270_B1.Segments.ST)
			End Get
			Set(value As Transaction270_B1.Segments.ST)
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

		Private Property BHT_IFace_Transaction270_B1 As Transaction270_B1.Segments.BHT Implements Transaction270_B1.TransactionSet.BHT
			Get
				Return CType(Children(1), Transaction270_B1.Segments.BHT)
			End Get
			Set(value As Transaction270_B1.Segments.BHT)
				Children(1) = value
			End Set
		End Property
		Friend ReadOnly Property Loop2000_Obj As LoopContainer(Of Loops.Loop2000) Implements Standard.Loop2000
			Get
				Return CType(Children(2), LoopContainer(Of Loops.Loop2000))
			End Get
		End Property

		Private Loop2000ASubset_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000A, Loops.Loop2000)
		Private ReadOnly Property Loop2000A_Obj_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000A, Loops.Loop2000) Implements Transaction270_B1.TransactionSet.Loop2000A
			Get
				If Loop2000ASubset_Transaction270_B1 Is Nothing Then
					Loop2000ASubset_Transaction270_B1 = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000A, Loops.Loop2000)(Children(2), 0, 2, 36)
				End If

				Return Loop2000ASubset_Transaction270_B1
			End Get
		End Property
		Private Loop2000BSubset_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000B, Loops.Loop2000)
		Private ReadOnly Property Loop2000B_Obj_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000B, Loops.Loop2000) Implements Transaction270_B1.TransactionSet.Loop2000B
			Get
				If Loop2000BSubset_Transaction270_B1 Is Nothing Then
					Loop2000BSubset_Transaction270_B1 = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000B, Loops.Loop2000)(Children(2), 0, 3, 36)
				End If

				Return Loop2000BSubset_Transaction270_B1
			End Get
		End Property
		Private Loop2000CSubset_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000C, Loops.Loop2000)
		Private ReadOnly Property Loop2000C_Obj_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000C, Loops.Loop2000) Implements Transaction270_B1.TransactionSet.Loop2000C
			Get
				If Loop2000CSubset_Transaction270_B1 Is Nothing Then
					Loop2000CSubset_Transaction270_B1 = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000C, Loops.Loop2000)(Children(2), 0, 4, 36)
				End If

				Return Loop2000CSubset_Transaction270_B1
			End Get
		End Property
		Private Loop2000DSubset_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000D, Loops.Loop2000)
		Private ReadOnly Property Loop2000D_Obj_Transaction270_B1 As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000D, Loops.Loop2000) Implements Transaction270_B1.TransactionSet.Loop2000D
			Get
				If Loop2000DSubset_Transaction270_B1 Is Nothing Then
					Loop2000DSubset_Transaction270_B1 = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2000D, Loops.Loop2000)(Children(2), 0, 5, 36)
				End If

				Return Loop2000DSubset_Transaction270_B1
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

		Private Property SE_IFace_Transaction270_B1 As Transaction270_B1.Segments.SE Implements Transaction270_B1.TransactionSet.SE
			Get
				Return CType(Children(3), Transaction270_B1.Segments.SE)
			End Get
			Set(value As Transaction270_B1.Segments.SE)
				Children(3) = value
			End Set
		End Property
	End Class

	Partial Friend Class Loop2000_Obj
		Inherits LoopBase
		Implements Loops.Loop2000,
													Transaction270_B1.Loops.Loop2000A,
													Transaction270_B1.Loops.Loop2000B,
													Transaction270_B1.Loops.Loop2000C,
													Transaction270_B1.Loops.Loop2000D
		Friend Sub New()
			MyBase.New

			Children.AddRange({CType(Nothing, Segments.HL_Obj),
																New SegmentContainer(Of Segments.TRN)(9, 2, 200),
																New LoopContainer(Of Loops.Loop2100)(0, 2, 300)})

			Initialize()
		End Sub

		Partial Private Sub Initialize()

		End Sub

		Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "HL", ReadAction.PopulateSegment, 1, False),
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
				Seg = Segments.HL_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				HL_Obj = Seg
				Dim S2 = CType(Seg, Segments.HL_Obj)
				If CompareKey(S2.HL03, ";20;") AndAlso String.Compare(args.Implementation, "_270B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 2
					Seg.SetSequence = 36
				ElseIf CompareKey(S2.HL03, ";21;") AndAlso String.Compare(args.Implementation, "_270B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 3
					Seg.SetSequence = 36
				ElseIf CompareKey(S2.HL03, ";22;") AndAlso String.Compare(args.Implementation, "_270B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 36
				ElseIf CompareKey(S2.HL03, ";23;") AndAlso String.Compare(args.Implementation, "_270B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 36
				End If
			ElseIf String.Compare(SegmentName, "TRN", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.TRN_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				TRN_Obj.Add(Seg)
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
				If CompareKey(LoopKey, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000A", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000A__2100A"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000B", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000B__2100B"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";IL;") AndAlso String.Compare(args.Implementation, "_270B1__2000C", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000C__2100C"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf CompareKey(LoopKey, ";03;") AndAlso String.Compare(args.Implementation, "_270B1__2000D", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000D__2100D"
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

		Private Property HL_IFace_Loop2000A_Obj As Transaction270_B1.Segments.Loop2000A.HL Implements Transaction270_B1.Loops.Loop2000A.HL
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2000A.HL)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2000A.HL)
				Children(0) = value
			End Set
		End Property
		Private Property HL_IFace_1_Loop2000B_Obj As Transaction270_B1.Segments.Loop2000B.HL Implements Transaction270_B1.Loops.Loop2000B.HL
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2000B.HL)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2000B.HL)
				Children(0) = value
			End Set
		End Property
		Private Property HL_IFace_2_Loop2000C_Obj As Transaction270_B1.Segments.Loop2000C.HL Implements Transaction270_B1.Loops.Loop2000C.HL
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2000C.HL)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2000C.HL)
				Children(0) = value
			End Set
		End Property
		Private Property HL_IFace_3_Loop2000D_Obj As Transaction270_B1.Segments.Loop2000D.HL Implements Transaction270_B1.Loops.Loop2000D.HL
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2000D.HL)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2000D.HL)
				Children(0) = value
			End Set
		End Property
		Friend ReadOnly Property TRN_Obj As SegmentContainer(Of Segments.TRN) Implements Loops.Loop2000.TRN
			Get
				Return CType(Children(1), SegmentContainer(Of Segments.TRN))
			End Get
		End Property

		Private TRNSubset_Loop2000C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000C.TRN, Segments.TRN)
		Private ReadOnly Property TRN_Loop2000C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000C.TRN, Segments.TRN) Implements Transaction270_B1.Loops.Loop2000C.TRN
			Get
				If TRNSubset_Loop2000C_Obj Is Nothing Then
					TRNSubset_Loop2000C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000C.TRN, Segments.TRN)(Children(1), 2, 4, 72)
				End If

				Return TRNSubset_Loop2000C_Obj
			End Get
		End Property
		Private TRNSubset_1_Loop2000D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000D.TRN, Segments.TRN)
		Private ReadOnly Property TRN_Loop2000D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000D.TRN, Segments.TRN) Implements Transaction270_B1.Loops.Loop2000D.TRN
			Get
				If TRNSubset_1_Loop2000D_Obj Is Nothing Then
					TRNSubset_1_Loop2000D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2000D.TRN, Segments.TRN)(Children(1), 2, 5, 72)
				End If

				Return TRNSubset_1_Loop2000D_Obj
			End Get
		End Property
		Friend ReadOnly Property Loop2100_Obj As LoopContainer(Of Loops.Loop2100) Implements Loops.Loop2000.Loop2100
			Get
				Return CType(Children(2), LoopContainer(Of Loops.Loop2100))
			End Get
		End Property

		Private Loop2100ASubset_Loop2000A_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100A, Loops.Loop2100)
		Private Property Loop2100A_IFace_Loop2000A_Obj As Transaction270_B1.Loops.Loop2100A Implements Transaction270_B1.Loops.Loop2000A.Loop2100A
			Get
				If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
					Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100A, Loops.Loop2100)(Children(2), 1, 2, 108)
				End If

				If Loop2100ASubset_Loop2000A_Obj.Count > 0 Then
					Return Loop2100ASubset_Loop2000A_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Loops.Loop2100A)
				If Loop2100ASubset_Loop2000A_Obj Is Nothing Then
					Loop2100ASubset_Loop2000A_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100A, Loops.Loop2100)(Children(2), 1, 2, 108)
				End If

				If Loop2100ASubset_Loop2000A_Obj.Count = 0 Then
					Loop2100ASubset_Loop2000A_Obj.Add(value)
				Else
					Loop2100ASubset_Loop2000A_Obj(0) = value
				End If
			End Set
		End Property
		Private Loop2100BSubset_Loop2000B_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100B, Loops.Loop2100)
		Private Property Loop2100B_IFace_Loop2000B_Obj As Transaction270_B1.Loops.Loop2100B Implements Transaction270_B1.Loops.Loop2000B.Loop2100B
			Get
				If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
					Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100B, Loops.Loop2100)(Children(2), 1, 3, 108)
				End If

				If Loop2100BSubset_Loop2000B_Obj.Count > 0 Then
					Return Loop2100BSubset_Loop2000B_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Loops.Loop2100B)
				If Loop2100BSubset_Loop2000B_Obj Is Nothing Then
					Loop2100BSubset_Loop2000B_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100B, Loops.Loop2100)(Children(2), 1, 3, 108)
				End If

				If Loop2100BSubset_Loop2000B_Obj.Count = 0 Then
					Loop2100BSubset_Loop2000B_Obj.Add(value)
				Else
					Loop2100BSubset_Loop2000B_Obj(0) = value
				End If
			End Set
		End Property
		Private Loop2100CSubset_Loop2000C_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100C, Loops.Loop2100)
		Private Property Loop2100C_IFace_Loop2000C_Obj As Transaction270_B1.Loops.Loop2100C Implements Transaction270_B1.Loops.Loop2000C.Loop2100C
			Get
				If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
					Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100C, Loops.Loop2100)(Children(2), 1, 4, 108)
				End If

				If Loop2100CSubset_Loop2000C_Obj.Count > 0 Then
					Return Loop2100CSubset_Loop2000C_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Loops.Loop2100C)
				If Loop2100CSubset_Loop2000C_Obj Is Nothing Then
					Loop2100CSubset_Loop2000C_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100C, Loops.Loop2100)(Children(2), 1, 4, 108)
				End If

				If Loop2100CSubset_Loop2000C_Obj.Count = 0 Then
					Loop2100CSubset_Loop2000C_Obj.Add(value)
				Else
					Loop2100CSubset_Loop2000C_Obj(0) = value
				End If
			End Set
		End Property
		Private Loop2100DSubset_Loop2000D_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100D, Loops.Loop2100)
		Private Property Loop2100D_IFace_Loop2000D_Obj As Transaction270_B1.Loops.Loop2100D Implements Transaction270_B1.Loops.Loop2000D.Loop2100D
			Get
				If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
					Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100D, Loops.Loop2100)(Children(2), 1, 5, 108)
				End If

				If Loop2100DSubset_Loop2000D_Obj.Count > 0 Then
					Return Loop2100DSubset_Loop2000D_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Loops.Loop2100D)
				If Loop2100DSubset_Loop2000D_Obj Is Nothing Then
					Loop2100DSubset_Loop2000D_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2100D, Loops.Loop2100)(Children(2), 1, 5, 108)
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
													Transaction270_B1.Loops.Loop2100A,
													Transaction270_B1.Loops.Loop2100B,
													Transaction270_B1.Loops.Loop2100C,
													Transaction270_B1.Loops.Loop2100D
		Friend Sub New()
			MyBase.New

			Children.AddRange({CType(Nothing, Segments.NM1_Obj),
																New SegmentContainer(Of Segments.REF)(9, 2, 400),
																CType(Nothing, Segments.N2_Obj),
																CType(Nothing, Segments.N3_Obj),
																CType(Nothing, Segments.N4_Obj),
																New SegmentContainer(Of Segments.PER)(3, 2, 800),
																CType(Nothing, Segments.PRV_Obj),
																CType(Nothing, Segments.DMG_Obj),
																CType(Nothing, Segments.INS_Obj),
																CType(Nothing, Segments.HI_Obj),
																New SegmentContainer(Of Segments.DTP)(9, 2, 1200),
																New SegmentContainer(Of Segments.MPI)(9, 2, 1250),
																New LoopContainer(Of Loops.Loop2110)(99, 2, 1300)})

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
				Seg = Segments.NM1_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				NM1_Obj = Seg
				Dim S2 = CType(Seg, Segments.NM1_Obj)
				If CompareKey(S2.NM101, ";2B;36;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000A__2100A", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 2
					Seg.SetSequence = 108
				ElseIf CompareKey(S2.NM101, ";1P;2B;36;80;FA;GP;P5;PR;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 3
					Seg.SetSequence = 108
				ElseIf CompareKey(S2.NM101, ";IL;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 108
				ElseIf CompareKey(S2.NM101, ";03;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 108
				End If
			ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				REF_Obj.Add(Seg)
				Dim S2 = CType(Seg, Segments.REF_Obj)
				If CompareKey(S2.REF01, ";0B;1C;1D;1J;4A;CT;EL;EO;HPI;JD;N5;N7;Q4;SY;TJ;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 3
					Seg.SetSequence = 144
				ElseIf CompareKey(S2.REF01, ";18;1L;1W;3H;6P;CT;EA;EJ;F6;GH;HJ;IG;N6;NQ;SY;Y4;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 144
				ElseIf CompareKey(S2.REF01, ";18;1L;1W;6P;CT;EA;EJ;F6;GH;HJ;IF;IG;MRC;N6;SY;Y4;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
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
			ElseIf String.Compare(SegmentName, "PRV", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.PRV_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				PRV_Obj = Seg
				Dim S2 = CType(Seg, Segments.PRV_Obj)
				If CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SB;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000B__2100B", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 3
					Seg.SetSequence = 324
				ElseIf CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 324
				ElseIf CompareKey(S2.PRV01, ";AD;AT;BI;CO;CV;H;HH;LA;OT;P1;P2;PC;PE;R;RF;SK;SU;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
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
				If CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 6517
				ElseIf CompareKey(If(S2.HI01 IsNot Nothing, S2.HI01.C022_01, String.Empty), ";ABK;BK;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 6517
				End If
			ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				DTP_Obj.Add(Seg)
				Dim S2 = CType(Seg, Segments.DTP_Obj)
				If CompareKey(S2.DTP01, ";102;291;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 73
				ElseIf CompareKey(S2.DTP01, ";102;291;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 73
				End If
			ElseIf String.Compare(SegmentName, "MPI", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.MPI_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				MPI_Obj.Add(Seg)
			End If
		End Sub

		Private Async Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
			Dim LoopID As String = args.ParentLoopID
			Dim Implementation As String = args.Implementation
			Dim Temp = args.Implementation

			If String.Compare(args.DataSegment.SegmentID, "EQ", StringComparison.OrdinalIgnoreCase) = 0 Then
				Dim NewLoop As LoopBase = New Loop2110_Obj
				Dim LoopKey As String = args.DataSegment.ToStringValue(0)
				Loop2110_Obj.Add(NewLoop)
				If String.Compare(args.Implementation, "_270B1__2000C__2100C", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000C__2100C__2110C"
					Await NewLoop.ReadAsync(args).ConfigureAwait(False)
				ElseIf String.Compare(args.Implementation, "_270B1__2000D__2100D", StringComparison.OrdinalIgnoreCase) = 0 Then
					args.Implementation = "_270B1__2000D__2100D__2110D"
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

		Private Property NM1_IFace_Loop2100A_Obj As Transaction270_B1.Segments.Loop2100A.NM1 Implements Transaction270_B1.Loops.Loop2100A.NM1
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2100A.NM1)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100A.NM1)
				Children(0) = value
			End Set
		End Property
		Private Property NM1_IFace_1_Loop2100B_Obj As Transaction270_B1.Segments.Loop2100B.NM1 Implements Transaction270_B1.Loops.Loop2100B.NM1
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2100B.NM1)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100B.NM1)
				Children(0) = value
			End Set
		End Property
		Private Property NM1_IFace_2_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.NM1 Implements Transaction270_B1.Loops.Loop2100C.NM1
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2100C.NM1)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.NM1)
				Children(0) = value
			End Set
		End Property
		Private Property NM1_IFace_3_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.NM1 Implements Transaction270_B1.Loops.Loop2100D.NM1
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2100D.NM1)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.NM1)
				Children(0) = value
			End Set
		End Property
		Friend ReadOnly Property REF_Obj As SegmentContainer(Of Segments.REF) Implements Loops.Loop2100.REF
			Get
				Return CType(Children(1), SegmentContainer(Of Segments.REF))
			End Get
		End Property

		Private REFSubset_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100B.REF, Segments.REF)
		Private ReadOnly Property REF_Loop2100B_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100B.REF, Segments.REF) Implements Transaction270_B1.Loops.Loop2100B.REF
			Get
				If REFSubset_Loop2100B_Obj Is Nothing Then
					REFSubset_Loop2100B_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100B.REF, Segments.REF)(Children(1), 9, 3, 144)
				End If

				Return REFSubset_Loop2100B_Obj
			End Get
		End Property
		Private REFSubset_1_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.REF, Segments.REF)
		Private ReadOnly Property REF_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.REF, Segments.REF) Implements Transaction270_B1.Loops.Loop2100C.REF
			Get
				If REFSubset_1_Loop2100C_Obj Is Nothing Then
					REFSubset_1_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.REF, Segments.REF)(Children(1), 9, 4, 144)
				End If

				Return REFSubset_1_Loop2100C_Obj
			End Get
		End Property
		Private REFSubset_2_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.REF, Segments.REF)
		Private ReadOnly Property REF_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.REF, Segments.REF) Implements Transaction270_B1.Loops.Loop2100D.REF
			Get
				If REFSubset_2_Loop2100D_Obj Is Nothing Then
					REFSubset_2_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.REF, Segments.REF)(Children(1), 9, 5, 144)
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

		Private Property N3_IFace_Loop2100B_Obj As Transaction270_B1.Segments.Loop2100B.N3 Implements Transaction270_B1.Loops.Loop2100B.N3
			Get
				Return CType(Children(3), Transaction270_B1.Segments.Loop2100B.N3)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100B.N3)
				Children(3) = value
			End Set
		End Property
		Private Property N3_IFace_1_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.N3 Implements Transaction270_B1.Loops.Loop2100C.N3
			Get
				Return CType(Children(3), Transaction270_B1.Segments.Loop2100C.N3)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.N3)
				Children(3) = value
			End Set
		End Property
		Private Property N3_IFace_2_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.N3 Implements Transaction270_B1.Loops.Loop2100D.N3
			Get
				Return CType(Children(3), Transaction270_B1.Segments.Loop2100D.N3)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.N3)
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

		Private Property N4_IFace_Loop2100B_Obj As Transaction270_B1.Segments.Loop2100B.N4 Implements Transaction270_B1.Loops.Loop2100B.N4
			Get
				Return CType(Children(4), Transaction270_B1.Segments.Loop2100B.N4)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100B.N4)
				Children(4) = value
			End Set
		End Property
		Private Property N4_IFace_1_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.N4 Implements Transaction270_B1.Loops.Loop2100C.N4
			Get
				Return CType(Children(4), Transaction270_B1.Segments.Loop2100C.N4)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.N4)
				Children(4) = value
			End Set
		End Property
		Private Property N4_IFace_2_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.N4 Implements Transaction270_B1.Loops.Loop2100D.N4
			Get
				Return CType(Children(4), Transaction270_B1.Segments.Loop2100D.N4)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.N4)
				Children(4) = value
			End Set
		End Property
		Friend ReadOnly Property PER_Obj As SegmentContainer(Of Segments.PER) Implements Loops.Loop2100.PER
			Get
				Return CType(Children(5), SegmentContainer(Of Segments.PER))
			End Get
		End Property

		Friend Property PRV_Obj As Segments.PRV_Obj
			Get
				Return CType(Children(6), Segments.PRV_Obj)
			End Get
			Set(value As Segments.PRV_Obj)
				Children(6) = value
			End Set
		End Property

		Private Property PRV_Std As Segments.PRV Implements Loops.Loop2100.PRV
			Get
				Return CType(Children(6), Segments.PRV_Obj)
			End Get
			Set(value As Segments.PRV)
				Children(6) = value
			End Set
		End Property

		Private Property PRV_IFace_Loop2100B_Obj As Transaction270_B1.Segments.Loop2100B.PRV Implements Transaction270_B1.Loops.Loop2100B.PRV
			Get
				Return CType(Children(6), Transaction270_B1.Segments.Loop2100B.PRV)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100B.PRV)
				Children(6) = value
			End Set
		End Property
		Private Property PRV_IFace_1_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.PRV Implements Transaction270_B1.Loops.Loop2100C.PRV
			Get
				Return CType(Children(6), Transaction270_B1.Segments.Loop2100C.PRV)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.PRV)
				Children(6) = value
			End Set
		End Property
		Private Property PRV_IFace_2_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.PRV Implements Transaction270_B1.Loops.Loop2100D.PRV
			Get
				Return CType(Children(6), Transaction270_B1.Segments.Loop2100D.PRV)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.PRV)
				Children(6) = value
			End Set
		End Property
		Friend Property DMG_Obj As Segments.DMG_Obj
			Get
				Return CType(Children(7), Segments.DMG_Obj)
			End Get
			Set(value As Segments.DMG_Obj)
				Children(7) = value
			End Set
		End Property

		Private Property DMG_Std As Segments.DMG Implements Loops.Loop2100.DMG
			Get
				Return CType(Children(7), Segments.DMG_Obj)
			End Get
			Set(value As Segments.DMG)
				Children(7) = value
			End Set
		End Property

		Private Property DMG_IFace_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.DMG Implements Transaction270_B1.Loops.Loop2100C.DMG
			Get
				Return CType(Children(7), Transaction270_B1.Segments.Loop2100C.DMG)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.DMG)
				Children(7) = value
			End Set
		End Property
		Private Property DMG_IFace_1_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.DMG Implements Transaction270_B1.Loops.Loop2100D.DMG
			Get
				Return CType(Children(7), Transaction270_B1.Segments.Loop2100D.DMG)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.DMG)
				Children(7) = value
			End Set
		End Property
		Friend Property INS_Obj As Segments.INS_Obj
			Get
				Return CType(Children(8), Segments.INS_Obj)
			End Get
			Set(value As Segments.INS_Obj)
				Children(8) = value
			End Set
		End Property

		Private Property INS_Std As Segments.INS Implements Loops.Loop2100.INS
			Get
				Return CType(Children(8), Segments.INS_Obj)
			End Get
			Set(value As Segments.INS)
				Children(8) = value
			End Set
		End Property

		Private Property INS_IFace_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.INS Implements Transaction270_B1.Loops.Loop2100C.INS
			Get
				Return CType(Children(8), Transaction270_B1.Segments.Loop2100C.INS)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.INS)
				Children(8) = value
			End Set
		End Property
		Private Property INS_IFace_1_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.INS Implements Transaction270_B1.Loops.Loop2100D.INS
			Get
				Return CType(Children(8), Transaction270_B1.Segments.Loop2100D.INS)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.INS)
				Children(8) = value
			End Set
		End Property
		Friend Property HI_Obj As Segments.HI_Obj
			Get
				Return CType(Children(9), Segments.HI_Obj)
			End Get
			Set(value As Segments.HI_Obj)
				Children(9) = value
			End Set
		End Property

		Private Property HI_Std As Segments.HI Implements Loops.Loop2100.HI
			Get
				Return CType(Children(9), Segments.HI_Obj)
			End Get
			Set(value As Segments.HI)
				Children(9) = value
			End Set
		End Property

		Private Property HI_IFace_Loop2100C_Obj As Transaction270_B1.Segments.Loop2100C.HI Implements Transaction270_B1.Loops.Loop2100C.HI
			Get
				Return CType(Children(9), Transaction270_B1.Segments.Loop2100C.HI)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100C.HI)
				Children(9) = value
			End Set
		End Property
		Private Property HI_IFace_1_Loop2100D_Obj As Transaction270_B1.Segments.Loop2100D.HI Implements Transaction270_B1.Loops.Loop2100D.HI
			Get
				Return CType(Children(9), Transaction270_B1.Segments.Loop2100D.HI)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2100D.HI)
				Children(9) = value
			End Set
		End Property
		Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2100.DTP
			Get
				Return CType(Children(10), SegmentContainer(Of Segments.DTP))
			End Get
		End Property

		Private DTPSubset_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.DTP, Segments.DTP)
		Private ReadOnly Property DTP_Loop2100C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.DTP, Segments.DTP) Implements Transaction270_B1.Loops.Loop2100C.DTP
			Get
				If DTPSubset_Loop2100C_Obj Is Nothing Then
					DTPSubset_Loop2100C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100C.DTP, Segments.DTP)(Children(10), 2, 4, 73)
				End If

				Return DTPSubset_Loop2100C_Obj
			End Get
		End Property
		Private DTPSubset_1_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.DTP, Segments.DTP)
		Private ReadOnly Property DTP_Loop2100D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.DTP, Segments.DTP) Implements Transaction270_B1.Loops.Loop2100D.DTP
			Get
				If DTPSubset_1_Loop2100D_Obj Is Nothing Then
					DTPSubset_1_Loop2100D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2100D.DTP, Segments.DTP)(Children(10), 2, 5, 73)
				End If

				Return DTPSubset_1_Loop2100D_Obj
			End Get
		End Property
		Friend ReadOnly Property MPI_Obj As SegmentContainer(Of Segments.MPI) Implements Loops.Loop2100.MPI
			Get
				Return CType(Children(11), SegmentContainer(Of Segments.MPI))
			End Get
		End Property

		Friend ReadOnly Property Loop2110_Obj As LoopContainer(Of Loops.Loop2110) Implements Loops.Loop2100.Loop2110
			Get
				Return CType(Children(12), LoopContainer(Of Loops.Loop2110))
			End Get
		End Property

		Private Loop2110CSubset_Loop2100C_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110C, Loops.Loop2110)
		Private ReadOnly Property Loop2110C_Obj_Loop2100C_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110C, Loops.Loop2110) Implements Transaction270_B1.Loops.Loop2100C.Loop2110C
			Get
				If Loop2110CSubset_Loop2100C_Obj Is Nothing Then
					Loop2110CSubset_Loop2100C_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110C, Loops.Loop2110)(Children(12), 99, 4, 109)
				End If

				Return Loop2110CSubset_Loop2100C_Obj
			End Get
		End Property
		Private Loop2110DSubset_Loop2100D_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110D, Loops.Loop2110)
		Private ReadOnly Property Loop2110D_Obj_Loop2100D_Obj As LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110D, Loops.Loop2110) Implements Transaction270_B1.Loops.Loop2100D.Loop2110D
			Get
				If Loop2110DSubset_Loop2100D_Obj Is Nothing Then
					Loop2110DSubset_Loop2100D_Obj = New LoopSubsetContainer(Of Transaction270_B1.Loops.Loop2110D, Loops.Loop2110)(Children(12), 99, 5, 109)
				End If

				Return Loop2110DSubset_Loop2100D_Obj
			End Get
		End Property

	End Class
	Partial Friend Class Loop2110_Obj
		Inherits LoopBase
		Implements Loops.Loop2110,
													Transaction270_B1.Loops.Loop2110C,
													Transaction270_B1.Loops.Loop2110D
		Friend Sub New()
			MyBase.New

			Children.AddRange({CType(Nothing, Segments.EQ_Obj),
																New SegmentContainer(Of Segments.AMT)(2, 2, 1350),
																CType(Nothing, Segments.VEH_Obj),
																CType(Nothing, Segments.PDR_Obj),
																CType(Nothing, Segments.PDP_Obj),
																New SegmentContainer(Of Segments.III)(10, 2, 1700),
																CType(Nothing, Segments.REF_Obj),
																New SegmentContainer(Of Segments.DTP)(9, 2, 2000)})

			Initialize()
		End Sub

		Partial Private Sub Initialize()

		End Sub

		Private Shared ReadOnly StateMan As New ReaderStateMachine({New ReaderState(0, "EQ", ReadAction.PopulateSegment, 1, False),
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
				Seg = Segments.EQ_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				EQ_Obj = Seg
			ElseIf String.Compare(SegmentName, "AMT", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.AMT_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				AMT_Obj.Add(Seg)
				Dim S2 = CType(Seg, Segments.AMT_Obj)
				If CompareKey(S2.AMT01, ";R;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 6589
				ElseIf CompareKey(S2.AMT01, ";PB;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 239869
				End If
			ElseIf String.Compare(SegmentName, "VEH", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.VEH_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				VEH_Obj = Seg
			ElseIf String.Compare(SegmentName, "PDR", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.PDR_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				PDR_Obj = Seg
			ElseIf String.Compare(SegmentName, "PDP", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.PDP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				PDP_Obj = Seg
			ElseIf String.Compare(SegmentName, "III", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.III_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				III_Obj.Add(Seg)
			ElseIf String.Compare(SegmentName, "REF", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.REF_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				REF_Obj = Seg
				Dim S2 = CType(Seg, Segments.REF_Obj)
				If CompareKey(S2.REF01, ";9F;G1;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 145
				ElseIf CompareKey(S2.REF01, ";9F;G1;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 145
				End If
			ElseIf String.Compare(SegmentName, "DTP", StringComparison.OrdinalIgnoreCase) = 0 Then
				Seg = Segments.DTP_Obj.FromGenericSegment(args.DataSegment, args.Reader.Reader)
				DTP_Obj.Add(Seg)
				Dim S2 = CType(Seg, Segments.DTP_Obj)
				If CompareKey(S2.DTP01, ";291;") AndAlso String.Compare(args.Implementation, "_270B1__2000C__2100C__2110C", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 4
					Seg.SetSequence = 181
				ElseIf CompareKey(S2.DTP01, ";291;") AndAlso String.Compare(args.Implementation, "_270B1__2000D__2100D__2110D", StringComparison.OrdinalIgnoreCase) = 0 Then
					Seg.SetArea = 5
					Seg.SetSequence = 181
				End If
			End If
		End Sub

		Private Function PopulateChildLoop(ByVal args As ReaderArgs) As Task
			Return Task.CompletedTask()
		End Function
		Friend Property EQ_Obj As Segments.EQ_Obj
			Get
				Return CType(Children(0), Segments.EQ_Obj)
			End Get
			Set(value As Segments.EQ_Obj)
				Children(0) = value
			End Set
		End Property

		Private Property EQ_Std As Segments.EQ Implements Loops.Loop2110.EQ
			Get
				Return CType(Children(0), Segments.EQ_Obj)
			End Get
			Set(value As Segments.EQ)
				Children(0) = value
			End Set
		End Property

		Private Property EQ_IFace_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.EQ Implements Transaction270_B1.Loops.Loop2110C.EQ
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2110C.EQ)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.EQ)
				Children(0) = value
			End Set
		End Property
		Private Property EQ_IFace_1_Loop2110D_Obj As Transaction270_B1.Segments.Loop2110D.EQ Implements Transaction270_B1.Loops.Loop2110D.EQ
			Get
				Return CType(Children(0), Transaction270_B1.Segments.Loop2110D.EQ)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110D.EQ)
				Children(0) = value
			End Set
		End Property
		Friend ReadOnly Property AMT_Obj As SegmentContainer(Of Segments.AMT) Implements Loops.Loop2110.AMT
			Get
				Return CType(Children(1), SegmentContainer(Of Segments.AMT))
			End Get
		End Property

		Private AMTSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT, Segments.AMT)
		Private Property AMT_IFace_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.AMT Implements Transaction270_B1.Loops.Loop2110C.AMT
			Get
				If AMTSubset_Loop2110C_Obj Is Nothing Then
					AMTSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT, Segments.AMT)(Children(1), 1, 4, 6589)
				End If

				If AMTSubset_Loop2110C_Obj.Count > 0 Then
					Return AMTSubset_Loop2110C_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.AMT)
				If AMTSubset_Loop2110C_Obj Is Nothing Then
					AMTSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT, Segments.AMT)(Children(1), 1, 4, 6589)
				End If

				If AMTSubset_Loop2110C_Obj.Count = 0 Then
					AMTSubset_Loop2110C_Obj.Add(value)
				Else
					AMTSubset_Loop2110C_Obj(0) = value
				End If
			End Set
		End Property
		Private AMT_1Subset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT_1, Segments.AMT)
		Private Property AMT_IFace_1_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.AMT_1 Implements Transaction270_B1.Loops.Loop2110C.AMT_1
			Get
				If AMT_1Subset_Loop2110C_Obj Is Nothing Then
					AMT_1Subset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT_1, Segments.AMT)(Children(1), 1, 4, 239869)
				End If

				If AMT_1Subset_Loop2110C_Obj.Count > 0 Then
					Return AMT_1Subset_Loop2110C_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.AMT_1)
				If AMT_1Subset_Loop2110C_Obj Is Nothing Then
					AMT_1Subset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.AMT_1, Segments.AMT)(Children(1), 1, 4, 239869)
				End If

				If AMT_1Subset_Loop2110C_Obj.Count = 0 Then
					AMT_1Subset_Loop2110C_Obj.Add(value)
				Else
					AMT_1Subset_Loop2110C_Obj(0) = value
				End If
			End Set
		End Property
		Friend Property VEH_Obj As Segments.VEH_Obj
			Get
				Return CType(Children(2), Segments.VEH_Obj)
			End Get
			Set(value As Segments.VEH_Obj)
				Children(2) = value
			End Set
		End Property

		Private Property VEH_Std As Segments.VEH Implements Loops.Loop2110.VEH
			Get
				Return CType(Children(2), Segments.VEH_Obj)
			End Get
			Set(value As Segments.VEH)
				Children(2) = value
			End Set
		End Property

		Friend Property PDR_Obj As Segments.PDR_Obj
			Get
				Return CType(Children(3), Segments.PDR_Obj)
			End Get
			Set(value As Segments.PDR_Obj)
				Children(3) = value
			End Set
		End Property

		Private Property PDR_Std As Segments.PDR Implements Loops.Loop2110.PDR
			Get
				Return CType(Children(3), Segments.PDR_Obj)
			End Get
			Set(value As Segments.PDR)
				Children(3) = value
			End Set
		End Property

		Friend Property PDP_Obj As Segments.PDP_Obj
			Get
				Return CType(Children(4), Segments.PDP_Obj)
			End Get
			Set(value As Segments.PDP_Obj)
				Children(4) = value
			End Set
		End Property

		Private Property PDP_Std As Segments.PDP Implements Loops.Loop2110.PDP
			Get
				Return CType(Children(4), Segments.PDP_Obj)
			End Get
			Set(value As Segments.PDP)
				Children(4) = value
			End Set
		End Property

		Friend ReadOnly Property III_Obj As SegmentContainer(Of Segments.III) Implements Loops.Loop2110.III
			Get
				Return CType(Children(5), SegmentContainer(Of Segments.III))
			End Get
		End Property

		Private IIISubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.III, Segments.III)
		Private Property III_IFace_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.III Implements Transaction270_B1.Loops.Loop2110C.III
			Get
				If IIISubset_Loop2110C_Obj Is Nothing Then
					IIISubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.III, Segments.III)(Children(5), 1, 4, 11773)
				End If

				If IIISubset_Loop2110C_Obj.Count > 0 Then
					Return IIISubset_Loop2110C_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.III)
				If IIISubset_Loop2110C_Obj Is Nothing Then
					IIISubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.III, Segments.III)(Children(5), 1, 4, 11773)
				End If

				If IIISubset_Loop2110C_Obj.Count = 0 Then
					IIISubset_Loop2110C_Obj.Add(value)
				Else
					IIISubset_Loop2110C_Obj(0) = value
				End If
			End Set
		End Property
		Private IIISubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.III, Segments.III)
		Private Property III_IFace_1_Loop2110D_Obj As Transaction270_B1.Segments.Loop2110D.III Implements Transaction270_B1.Loops.Loop2110D.III
			Get
				If IIISubset_1_Loop2110D_Obj Is Nothing Then
					IIISubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.III, Segments.III)(Children(5), 1, 5, 11773)
				End If

				If IIISubset_1_Loop2110D_Obj.Count > 0 Then
					Return IIISubset_1_Loop2110D_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110D.III)
				If IIISubset_1_Loop2110D_Obj Is Nothing Then
					IIISubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.III, Segments.III)(Children(5), 1, 5, 11773)
				End If

				If IIISubset_1_Loop2110D_Obj.Count = 0 Then
					IIISubset_1_Loop2110D_Obj.Add(value)
				Else
					IIISubset_1_Loop2110D_Obj(0) = value
				End If
			End Set
		End Property
		Friend Property REF_Obj As Segments.REF_Obj
			Get
				Return CType(Children(6), Segments.REF_Obj)
			End Get
			Set(value As Segments.REF_Obj)
				Children(6) = value
			End Set
		End Property

		Private Property REF_Std As Segments.REF Implements Loops.Loop2110.REF
			Get
				Return CType(Children(6), Segments.REF_Obj)
			End Get
			Set(value As Segments.REF)
				Children(6) = value
			End Set
		End Property

		Private Property REF_IFace_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.REF Implements Transaction270_B1.Loops.Loop2110C.REF
			Get
				Return CType(Children(6), Transaction270_B1.Segments.Loop2110C.REF)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.REF)
				Children(6) = value
			End Set
		End Property
		Private Property REF_IFace_1_Loop2110D_Obj As Transaction270_B1.Segments.Loop2110D.REF Implements Transaction270_B1.Loops.Loop2110D.REF
			Get
				Return CType(Children(6), Transaction270_B1.Segments.Loop2110D.REF)
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110D.REF)
				Children(6) = value
			End Set
		End Property
		Friend ReadOnly Property DTP_Obj As SegmentContainer(Of Segments.DTP) Implements Loops.Loop2110.DTP
			Get
				Return CType(Children(7), SegmentContainer(Of Segments.DTP))
			End Get
		End Property

		Private DTPSubset_Loop2110C_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.DTP, Segments.DTP)
		Private Property DTP_IFace_Loop2110C_Obj As Transaction270_B1.Segments.Loop2110C.DTP Implements Transaction270_B1.Loops.Loop2110C.DTP
			Get
				If DTPSubset_Loop2110C_Obj Is Nothing Then
					DTPSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.DTP, Segments.DTP)(Children(7), 1, 4, 181)
				End If

				If DTPSubset_Loop2110C_Obj.Count > 0 Then
					Return DTPSubset_Loop2110C_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110C.DTP)
				If DTPSubset_Loop2110C_Obj Is Nothing Then
					DTPSubset_Loop2110C_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110C.DTP, Segments.DTP)(Children(7), 1, 4, 181)
				End If

				If DTPSubset_Loop2110C_Obj.Count = 0 Then
					DTPSubset_Loop2110C_Obj.Add(value)
				Else
					DTPSubset_Loop2110C_Obj(0) = value
				End If
			End Set
		End Property
		Private DTPSubset_1_Loop2110D_Obj As SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.DTP, Segments.DTP)
		Private Property DTP_IFace_1_Loop2110D_Obj As Transaction270_B1.Segments.Loop2110D.DTP Implements Transaction270_B1.Loops.Loop2110D.DTP
			Get
				If DTPSubset_1_Loop2110D_Obj Is Nothing Then
					DTPSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.DTP, Segments.DTP)(Children(7), 1, 5, 181)
				End If

				If DTPSubset_1_Loop2110D_Obj.Count > 0 Then
					Return DTPSubset_1_Loop2110D_Obj(0)
				Else
					Return Nothing
				End If
			End Get
			Set(value As Transaction270_B1.Segments.Loop2110D.DTP)
				If DTPSubset_1_Loop2110D_Obj Is Nothing Then
					DTPSubset_1_Loop2110D_Obj = New SegmentSubsetContainer(Of Transaction270_B1.Segments.Loop2110D.DTP, Segments.DTP)(Children(7), 1, 5, 181)
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
			'''<summary>Military Personnel Information</summary>
			ReadOnly Property MPI As SegmentContainer(Of Segments.MPI)
			'''<summary>Eligibility or Benefit Inquiry</summary>
			ReadOnly Property Loop2110 As LoopContainer(Of Loop2110)
		End Interface
		'''<summary></summary>
		'''<remarks></remarks>
		Public Interface Loop2110
			Inherits ILoop
			'''<summary>Eligibility or Benefit Inquiry</summary>
			Property EQ As Segments.EQ
			'''<summary>Monetary Amount Information</summary>
			ReadOnly Property AMT As SegmentContainer(Of Segments.AMT)
			'''<summary>Vehicle Information</summary>
			Property VEH As Segments.VEH
			'''<summary>Property Description - Real</summary>
			Property PDR As Segments.PDR
			'''<summary>Property Description - Personal</summary>
			Property PDP As Segments.PDP
			'''<summary>Information</summary>
			ReadOnly Property III As SegmentContainer(Of Segments.III)
			'''<summary>Reference Information</summary>
			Property REF As Segments.REF
			'''<summary>Date or Time or Period</summary>
			ReadOnly Property DTP As SegmentContainer(Of Segments.DTP)
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
					'''<summary>Hierarchical Level Code</summary>
					Property HL03 As String
					'''<summary>Hierarchical Child Code</summary>
					Property HL04 As String
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
				'''<summary>Multiple Birth Sequence Number</summary>
				Public Interface INS
					Inherits ISegment

					'''<summary>Insured Indicator</summary>
					Property INS01 As String
					'''<summary>Individual Relationship Code</summary>
					Property INS02 As String
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
			End Namespace 'Loop2100C

			Namespace Loop2110C

				'''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
				Public Interface EQ
					Inherits ISegment

					'''<summary>Service Type Code</summary>
					Property EQ01 As String
					'''<summary></summary>
					Property EQ02 As Composites.Loop2110C.EQ.EQ_02.C003
					'''<summary>Coverage Level Code</summary>
					Property EQ03 As String
					'''<summary></summary>
					Property EQ05 As DataElements.Composite.C004
				End Interface
				'''<summary>Subscriber Spend Down Amount</summary>
				Public Interface AMT
					Inherits ISegment

					'''<summary>Amount Qualifier Code</summary>
					Property AMT01 As String
					'''<summary>Spend Down Amount</summary>
					Property AMT02 As Decimal?
				End Interface
				'''<summary>Subscriber Spend Down Total Billed Amount</summary>
				Public Interface AMT_1
					Inherits ISegment

					'''<summary>Amount Qualifier Code</summary>
					Property AMT01 As String
					'''<summary>Spend Down Total Billed Amount</summary>
					Property AMT02 As Decimal?
				End Interface
				'''<summary>Subscriber Eligibility or Benefit Additional Inquiry Information</summary>
				Public Interface III
					Inherits ISegment

					'''<summary>Code List Qualifier Code</summary>
					Property III01 As String
					'''<summary>Industry Code</summary>
					Property III02 As String
				End Interface
				'''<summary>Subscriber Additional Information</summary>
				Public Interface REF
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>Prior Authorization or Referral Number</summary>
					Property REF02 As String
				End Interface
				'''<summary>Subscriber Eligibility/Benefit Date</summary>
				Public Interface DTP
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTP01 As String
					'''<summary>Date Time Period Format Qualifier</summary>
					Property DTP02 As String
					'''<summary>Date Time Period</summary>
					Property DTP03 As String
				End Interface
			End Namespace 'Loop2110C

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
			End Namespace 'Loop2100D

			Namespace Loop2110D

				'''<summary>Dependent Eligibility or Benefit Inquiry</summary>
				Public Interface EQ
					Inherits ISegment

					'''<summary>Service Type Code</summary>
					Property EQ01 As String
					'''<summary></summary>
					Property EQ02 As Composites.Loop2110D.EQ.EQ_02.C003
					'''<summary></summary>
					Property EQ05 As DataElements.Composite.C004
				End Interface
				'''<summary>Dependent Eligibility or Benefit Additional Inquiry Information</summary>
				Public Interface III
					Inherits ISegment

					'''<summary>Code List Qualifier Code</summary>
					Property III01 As String
					'''<summary>Industry Code</summary>
					Property III02 As String
				End Interface
				'''<summary>Dependent Additional Information</summary>
				Public Interface REF
					Inherits ISegment

					'''<summary>Reference Identification Qualifier</summary>
					Property REF01 As String
					'''<summary>Prior Authorization or Referral Number</summary>
					Property REF02 As String
				End Interface
				'''<summary>Dependent Eligibility/Benefit Date</summary>
				Public Interface DTP
					Inherits ISegment

					'''<summary>Date Time Qualifier</summary>
					Property DTP01 As String
					'''<summary>Date Time Period Format Qualifier</summary>
					Property DTP02 As String
					'''<summary>Date Time Period</summary>
					Property DTP03 As String
				End Interface
			End Namespace 'Loop2110D

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

				'''<summary>Information Source Name</summary>
				Property Loop2100A As Loop2100A
			End Interface
			'''<summary>Information Source Name</summary>
			Public Interface Loop2100A
				Inherits ILoop


				'''<summary>Information Source Name</summary>
				Property NM1 As Segments.Loop2100A.NM1
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

				'''<summary>Provider Information</summary>
				Property PRV As Segments.Loop2100C.PRV

				'''<summary>Subscriber Demographic Information</summary>
				Property DMG As Segments.Loop2100C.DMG

				'''<summary>Multiple Birth Sequence Number</summary>
				Property INS As Segments.Loop2100C.INS

				'''<summary>Subscriber Health Care Diagnosis Code</summary>
				Property HI As Segments.Loop2100C.HI

				'''<summary>Subscriber Date</summary>
				ReadOnly Property DTP As SegmentSubsetContainer(Of Segments.Loop2100C.DTP, Dom.Segments.DTP)

				'''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
				ReadOnly Property Loop2110C As LoopSubsetContainer(Of Loop2110C, Transaction270.Loops.Loop2110)
			End Interface
			'''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
			Public Interface Loop2110C
				Inherits ILoop


				'''<summary>Subscriber Eligibility or Benefit Inquiry</summary>
				Property EQ As Segments.Loop2110C.EQ

				'''<summary>Subscriber Spend Down Amount</summary>
				Property AMT As Segments.Loop2110C.AMT

				'''<summary>Subscriber Spend Down Total Billed Amount</summary>
				Property AMT_1 As Segments.Loop2110C.AMT_1

				'''<summary>Subscriber Eligibility or Benefit Additional Inquiry Information</summary>
				Property III As Segments.Loop2110C.III

				'''<summary>Subscriber Additional Information</summary>
				Property REF As Segments.Loop2110C.REF

				'''<summary>Subscriber Eligibility/Benefit Date</summary>
				Property DTP As Segments.Loop2110C.DTP
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

				'''<summary>Dependent Eligibility or Benefit Inquiry</summary>
				ReadOnly Property Loop2110D As LoopSubsetContainer(Of Loop2110D, Transaction270.Loops.Loop2110)
			End Interface
			'''<summary>Dependent Eligibility or Benefit Inquiry</summary>
			Public Interface Loop2110D
				Inherits ILoop


				'''<summary>Dependent Eligibility or Benefit Inquiry</summary>
				Property EQ As Segments.Loop2110D.EQ

				'''<summary>Dependent Eligibility or Benefit Additional Inquiry Information</summary>
				Property III As Segments.Loop2110D.III

				'''<summary>Dependent Additional Information</summary>
				Property REF As Segments.Loop2110D.REF

				'''<summary>Dependent Eligibility/Benefit Date</summary>
				Property DTP As Segments.Loop2110D.DTP
			End Interface

		End Namespace 'Loops

		'''<summary>Health Care Eligibility Benefit Inquiry</summary>
		'''<remarks>
		'''<para>This X12 Transaction Set contains the format and establishes the data contents of the Eligibility, Coverage or Benefit Inquiry Transaction Set (270) for use within the context of an Electronic Data Interchange (EDI) environment. This transaction set can be used to inquire about the eligibility, coverages or benefits associated with a benefit plan, employer, plan sponsor, subscriber or a dependent under the subscriber's policy. The transaction set is intended to be used by all lines of insurance such as Health, Life, and Property and Casualty.</para>
		'''</remarks>
		Public Interface TransactionSet

			'''<summary>Transaction Set Header</summary>
			Property ST As Segments.ST

			'''<summary>Beginning of Hierarchical Transaction</summary>
			Property BHT As Segments.BHT

			'''<summary>Information Source Level</summary>
			ReadOnly Property Loop2000A As LoopSubsetContainer(Of Loops.Loop2000A, Transaction270.Loops.Loop2000)

			'''<summary>Information Receiver Level</summary>
			ReadOnly Property Loop2000B As LoopSubsetContainer(Of Loops.Loop2000B, Transaction270.Loops.Loop2000)

			'''<summary>Subscriber Level</summary>
			ReadOnly Property Loop2000C As LoopSubsetContainer(Of Loops.Loop2000C, Transaction270.Loops.Loop2000)

			'''<summary>Dependent Level</summary>
			ReadOnly Property Loop2000D As LoopSubsetContainer(Of Loops.Loop2000D, Transaction270.Loops.Loop2000)

			'''<summary>Transaction Set Trailer</summary>
			Property SE As Segments.SE
		End Interface
	End Namespace 'Transaction270_B1
End Namespace 'Transaction270
