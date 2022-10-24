Public Class Map_of_Treasure

    Dim chance As Integer

    Private Sub btn_coordinate_Click(sender As Object, e As EventArgs) Handles btn_coordinate.Click
        Dim coord As String = txt_coordinate.Text
        Dim j As Integer = 0
        Dim arr(79) As String
        Dim i As Integer = 0
        Dim def_coord As String = "67"


        While i < 80
            If i < 10 Then
                arr(i) = "0" + i.ToString()
            Else
                arr(i) = i.ToString()
            End If
            'MessageBox.Show(arr(i))
            i += 1

        End While



        If coord = def_coord Then
            btn_67.BackColor = Color.Green
            MessageBox.Show("You are lucky one.")
        ElseIf coord = arr(0) Then
            btn_00.BackColor = Color.Red
        ElseIf coord = arr(1) Then
            btn_01.BackColor = Color.Red
        ElseIf coord = arr(2) Then
            btn_02.BackColor = Color.Red
        ElseIf coord = arr(3) Then
            btn_03.BackColor = Color.Red
        ElseIf coord = arr(4) Then
            btn_04.BackColor = Color.Red
        ElseIf coord = arr(5) Then
            btn_05.BackColor = Color.Red
        ElseIf coord = arr(6) Then
            btn_06.BackColor = Color.Red
        ElseIf coord = arr(7) Then
            btn_07.BackColor = Color.Red
        ElseIf coord = arr(8) Then
            btn_08.BackColor = Color.Red
        ElseIf coord = arr(9) Then
            btn_09.BackColor = Color.Red
        ElseIf coord = arr(10) Then
            btn_10.BackColor = Color.Red
        ElseIf coord = arr(11) Then
            btn_11.BackColor = Color.Red
        ElseIf coord = arr(12) Then
            btn_12.BackColor = Color.Red
        ElseIf coord = arr(13) Then
            btn_13.BackColor = Color.Red
        ElseIf coord = arr(14) Then
            btn_14.BackColor = Color.Red
        ElseIf coord = arr(15) Then
            btn_15.BackColor = Color.Red
        ElseIf coord = arr(16) Then
            btn_16.BackColor = Color.Red
        ElseIf coord = arr(17) Then
            btn_17.BackColor = Color.Red
        ElseIf coord = arr(18) Then
            btn_18.BackColor = Color.Red
        ElseIf coord = arr(19) Then
            btn_19.BackColor = Color.Red
        ElseIf coord = arr(20) Then
            btn_20.BackColor = Color.Red
        ElseIf coord = arr(21) Then
            btn_21.BackColor = Color.Red
        ElseIf coord = arr(22) Then
            btn_22.BackColor = Color.Red
        ElseIf coord = arr(23) Then
            btn_23.BackColor = Color.Red
        ElseIf coord = arr(24) Then
            btn_24.BackColor = Color.Red
        ElseIf coord = arr(25) Then
            btn_25.BackColor = Color.Red
        ElseIf coord = arr(26) Then
            btn_26.BackColor = Color.Red
        ElseIf coord = arr(27) Then
            btn_27.BackColor = Color.Red
        ElseIf coord = arr(28) Then
            btn_28.BackColor = Color.Red
        ElseIf coord = arr(29) Then
            btn_29.BackColor = Color.Red
        ElseIf coord = arr(30) Then
            btn_30.BackColor = Color.Red
        ElseIf coord = arr(31) Then
            btn_31.BackColor = Color.Red
        ElseIf coord = arr(32) Then
            btn_32.BackColor = Color.Red
        ElseIf coord = arr(33) Then
            btn_33.BackColor = Color.Red
        ElseIf coord = arr(34) Then
            btn_34.BackColor = Color.Red
        ElseIf coord = arr(35) Then
            btn_35.BackColor = Color.Red
        ElseIf coord = arr(36) Then
            btn_36.BackColor = Color.Red
        ElseIf coord = arr(37) Then
            btn_37.BackColor = Color.Red
        ElseIf coord = arr(38) Then
            btn_38.BackColor = Color.Red
        ElseIf coord = arr(39) Then
            btn_39.BackColor = Color.Red
        ElseIf coord = arr(40) Then
            btn_40.BackColor = Color.Red
        ElseIf coord = arr(41) Then
            btn_41.BackColor = Color.Red
        ElseIf coord = arr(42) Then
            btn_42.BackColor = Color.Red
        ElseIf coord = arr(43) Then
            btn_43.BackColor = Color.Red
        ElseIf coord = arr(44) Then
            btn_44.BackColor = Color.Red
        ElseIf coord = arr(45) Then
            btn_45.BackColor = Color.Red
        ElseIf coord = arr(46) Then
            btn_46.BackColor = Color.Red
        ElseIf coord = arr(47) Then
            btn_47.BackColor = Color.Red
        ElseIf coord = arr(48) Then
            btn_48.BackColor = Color.Red
        ElseIf coord = arr(49) Then
            btn_49.BackColor = Color.Red
        ElseIf coord = arr(50) Then
            btn_50.BackColor = Color.Red
        ElseIf coord = arr(51) Then
            btn_51.BackColor = Color.Red
        ElseIf coord = arr(52) Then
            btn_52.BackColor = Color.Red
        ElseIf coord = arr(53) Then
            btn_53.BackColor = Color.Red
        ElseIf coord = arr(54) Then
            btn_54.BackColor = Color.Red
        ElseIf coord = arr(55) Then
            btn_55.BackColor = Color.Red
        ElseIf coord = arr(56) Then
            btn_56.BackColor = Color.Red
        ElseIf coord = arr(57) Then
            btn_57.BackColor = Color.Red
        ElseIf coord = arr(58) Then
            btn_58.BackColor = Color.Red
        ElseIf coord = arr(59) Then
            btn_59.BackColor = Color.Red
        ElseIf coord = arr(60) Then
            btn_60.BackColor = Color.Red
        ElseIf coord = arr(61) Then
            btn_61.BackColor = Color.Red
        ElseIf coord = arr(62) Then
            btn_62.BackColor = Color.Red
        ElseIf coord = arr(63) Then
            btn_63.BackColor = Color.Red
        ElseIf coord = arr(64) Then
            btn_64.BackColor = Color.Red
        ElseIf coord = arr(65) Then
            btn_65.BackColor = Color.Red
        ElseIf coord = arr(66) Then
            btn_66.BackColor = Color.Red
        ElseIf coord = arr(67) Then
            btn_67.BackColor = Color.Red
        ElseIf coord = arr(68) Then
            btn_68.BackColor = Color.Red
        ElseIf coord = arr(69) Then
            btn_69.BackColor = Color.Red
        ElseIf coord = arr(70) Then
            btn_70.BackColor = Color.Red
        ElseIf coord = arr(71) Then
            btn_71.BackColor = Color.Red
        ElseIf coord = arr(72) Then
            btn_72.BackColor = Color.Red
        ElseIf coord = arr(73) Then
            btn_73.BackColor = Color.Red
        ElseIf coord = arr(74) Then
            btn_74.BackColor = Color.Red
        ElseIf coord = arr(75) Then
            btn_75.BackColor = Color.Red
        ElseIf coord = arr(76) Then
            btn_76.BackColor = Color.Red
        ElseIf coord = arr(77) Then
            btn_77.BackColor = Color.Red
        ElseIf coord = arr(78) Then
            btn_78.BackColor = Color.Red
        ElseIf coord = arr(79) Then
            btn_79.BackColor = Color.Red
        End If

        chance -= 1
        If chance = 0 Then
            MessageBox.Show("Game Over...")
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show($"You have {chance} chance.")
        End If


    End Sub

    Private Sub Map_of_Treasure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.cbo_level.SelectedIndex = 0 Then
            chance = 40
        ElseIf Form1.cbo_level.SelectedIndex = 1 Then
            chance = 35
        ElseIf Form1.cbo_level.SelectedIndex = 2 Then
            chance = 30
        End If
    End Sub
End Class