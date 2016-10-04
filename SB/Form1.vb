Public Class Form1

    Dim mSharedData As New SharedData

    Dim mStartPanelImpl As StartPanelImpl
    Dim mCfgSingerImpl As CfgSingerImpl

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        mCfgSingerImpl = New CfgSingerImpl(New CfgSingerImpl.Data With {
            .Panel = cfgSingerPanel,
            .Add = cfgSingerAddButton,
            .Grid = cfgSingerDataGridView,
            .sharedData = mSharedData
        })

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
