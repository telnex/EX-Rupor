﻿Public Class SetApp
    Private Sub SetApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MAX.Value = My.Settings.count
        ListNum.Value = My.Settings.list
        If My.Settings.action = True Then
            R_YES.Checked = True
        ElseIf My.Settings.action = False Then
            R_NO.Checked = True
        End If
    End Sub
    Private Sub SaveSet_Click(sender As Object, e As EventArgs) Handles SaveSet.Click
        My.Settings.count = Convert.ToInt32(MAX.Value)
        My.Settings.list = Convert.ToInt32(ListNum.Value)
        If R_YES.Checked = True Then
            My.Settings.action = True
        ElseIf R_NO.Checked = True Then
            My.Settings.action = False
        End If
        Application.Exit()
    End Sub

End Class