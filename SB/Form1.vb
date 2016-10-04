Public Class Form1

    Private mSharedData As New SharedData

    Private mStartPanelImpl As StartPanelImpl
    Private mCfgSingerImpl As CfgSingerImpl
    Private mCfgJurorImpl As CfgJurorImpl

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        mCfgJurorImpl = New CfgJurorImpl(New CfgJurorImpl.Data With {
            .Panel = cfgJurorPanel,
            .Add = cfgJurorAddButton,
            .Grid = cfgJurorDataGridView,
            .sharedData = mSharedData
        })

        mCfgSingerImpl = New CfgSingerImpl(New CfgSingerImpl.Data With {
            .Panel = cfgSingerPanel,
            .Add = cfgSingerAddButton,
            .Grid = cfgSingerDataGridView,
            .sharedData = mSharedData
        })
        mCfgSingerImpl.Child = mCfgJurorImpl

        mStartPanelImpl = New StartPanelImpl(New StartPanelImpl.Data With {
            .Panel = startPanel,
            .Create = startCreateButton,
            .Load = startLoadButton,
            .sharedData = mSharedData
        })
        mStartPanelImpl.Child = mCfgSingerImpl

    End Sub

    Private Sub OnMainButonClick(sender As Object, e As EventArgs) Handles mainNextButton.Click, mainPrevButton.Click
        Debug.Assert(Not IsNothing(mSharedData.sequencePanel))

        If sender Is mainNextButton Then
            mSharedData.sequencePanel = mSharedData.sequencePanel.NextPanel()
        ElseIf (sender Is mainPrevButton) Then
            mSharedData.sequencePanel = mSharedData.sequencePanel.PreviousPanel()
        End If
    End Sub

End Class
