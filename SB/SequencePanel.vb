Public Class SequencePanel

#Region "Events and delegates"

    Protected Delegate Sub OnVisibilityChanged(visible As Boolean)
    Protected Event VisibilityChanged As OnVisibilityChanged

#End Region

#Region "Internal variables"

    Dim mPanel As System.Windows.Forms.Panel

    Dim mPrevious As SequencePanel
    Dim mNext As SequencePanel

#End Region

#Region "Properties"

    Public WriteOnly Property Child As SequencePanel
        Set(child As SequencePanel)
            Debug.Assert(Not IsNothing(child))
            mNext = child
            child.mPrevious = Me
        End Set
    End Property

    Protected Property Visible As Boolean
        Get
            Return mPanel.Visible
        End Get

        Set(visible As Boolean)
            mPanel.Visible = visible
        End Set
    End Property

#End Region

#Region "Constructors"

    Protected Sub New(ByRef panel As System.Windows.Forms.Panel)
        Debug.Assert(Not IsNothing(panel))

        mPanel = panel
        mPanel.Visible = False
        AddHandler mPanel.VisibleChanged, AddressOf OnVisibleChanged

    End Sub

#End Region

    Public Overridable Function NextPanel() As SequencePanel
        Debug.Assert(Not IsNothing(mNext))

        mPanel.Visible = False
        mNext.mPanel.Visible = True
        mNext.mPrevious = Me
        Return mNext
    End Function

    Public Overridable Function PreviousPanel() As SequencePanel
        Debug.Assert(Not IsNothing(mPrevious))

        mPanel.Visible = False
        mPrevious.mPanel.Visible = True
        Return mPrevious
    End Function

    Private Sub OnVisibleChanged(sender As Object, e As EventArgs)
        RaiseEvent VisibilityChanged(Visible)
    End Sub

End Class
