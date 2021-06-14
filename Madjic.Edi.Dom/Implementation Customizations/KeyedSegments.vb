''' <summary>
''' Identifies segments that have key information.
''' </summary>
''' <remarks>Used to differentiate instances of a loop or segment.</remarks>
Friend Interface IKeyedSegment
    ''' <summary>
    ''' Gets the element in a keyed segment that can differentiate this segment from other instances.
    ''' </summary>
    ReadOnly Property KeyValue As String
End Interface

Namespace Global.Madjic.Edi.Dom.Segments

    Partial Friend Class AMT_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return AMT01
            End Get
        End Property
    End Class

    Partial Friend Class CRC_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return CRC01
            End Get
        End Property
    End Class

    Partial Friend Class DTP_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return DTP01
            End Get
        End Property
    End Class

    Partial Friend Class HI_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return HI01.C022_01
            End Get
        End Property
    End Class

    Partial Friend Class HL_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return HL03
            End Get
        End Property
    End Class

    Partial Friend Class NM1_Obj
        Implements IKeyedSegment

        ''' <summary>
        ''' Gets the NM1 element that can uniquely identify the NM1 loop to its parent.
        ''' </summary>
        ''' <remarks>There are multiple instances of the NM1 loops for the implementations that can only be differentiated by examining this key field.</remarks>
        Friend ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return Me.NM101
            End Get
        End Property
    End Class

    Partial Friend Class NTE_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return NTE01
            End Get
        End Property
    End Class

    Partial Friend Class PRV_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return PRV01
            End Get
        End Property
    End Class

    Partial Friend Class PWK_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return String.Format("{0}:{1}", If(PWK01, String.Empty), If(PWK02, String.Empty))
            End Get
        End Property
    End Class

    Partial Friend Class QTY_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return QTY01
            End Get
        End Property
    End Class

    Partial Friend Class Ref_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return REF01
            End Get
        End Property
    End Class

    Partial Friend Class ST_Obj
        Implements IKeyedSegment

        Public ReadOnly Property KeyValue As String Implements IKeyedSegment.KeyValue
            Get
                Return ST01
            End Get
        End Property
    End Class

End Namespace