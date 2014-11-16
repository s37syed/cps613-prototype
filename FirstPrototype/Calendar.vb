Public Class Calendar
    'user control for days of the first half of the month 
    Friend SelectableDay As Integer
    Private Sub Week1_Click(sender As Object, e As EventArgs) Handles Week1.Click, Week2.Click, Week3.Click, Week4.Click, Week5.Click
        Dim selectedWeek As Label = sender
        If selectedWeek.Text = Week1.Text Then
            SelectableDay = 1
            Main.cal2.WeekLabel.Text = "Week 1"
            handleControls()
            Main.cal2.Day1.Text = "Sat. Nov. 1"
            Main.cal2.Day2.Text = "Sun. Nov. 2"
            Main.cal2.Day3.Text = "Mon. Nov. 3"
            Main.cal2.Day4.Text = "Tue. Nov. 4"
            Main.cal2.Day5.Text = "Wed. Nov. 5"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day5.Cursor = Cursors.Default
            Main.cal2.Day6.Text = "Thur. Nov. 6"
            Main.cal2.Day7.Text = "Fri. Nov. 7"
        ElseIf selectedWeek.Text = Week2.Text Then
            SelectableDay = 2
            Main.cal2.WeekLabel.Text = "Week 2"
            handleControls()
            Main.cal2.Day1.Text = "Sat. Nov. 8"
            Main.cal2.Day2.Text = "Sun. Nov. 9"
            Main.cal2.Day3.Text = "Mon. Nov. 10"
            Main.cal2.Day4.Text = "Tue. Nov. 11"
            Main.cal2.Day5.Text = "Wed. Nov. 12"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day5.Cursor = Cursors.Default
            Main.cal2.Day6.Text = "Thur. Nov. 13"
            Main.cal2.Day7.Text = "Fri. Nov. 14"
        ElseIf selectedWeek.Text = Week3.Text Then
            SelectableDay = 3
            Main.cal2.WeekLabel.Text = "Week 3"
            handleControls()
            Main.cal2.Day1.Text = "Sat. Nov. 15"
            Main.cal2.Day2.Text = "Sun. Nov. 16"
            Main.cal2.Day3.Text = "Mon. Nov. 17"
            Main.cal2.Day4.Text = "Tue. Nov. 18"
            Main.cal2.Day5.Text = "Wed. Nov. 19"
            Main.cal2.Day5.BackColor = Color.IndianRed
            Main.cal2.Day5.Cursor = Cursors.Hand
            Main.cal2.Day6.Text = "Thur. Nov. 20"
            Main.cal2.Day7.Text = "Fri. Nov. 21"
        ElseIf selectedWeek.Text = Week4.Text Then
            SelectableDay = 4
            Main.cal2.WeekLabel.Text = "Week 4"
            handleControls()
            Main.cal2.Day1.Text = "Sat. Nov. 22"
            Main.cal2.Day2.Text = "Sun. Nov. 23"
            Main.cal2.Day3.Text = "Mon. Nov. 24"
            Main.cal2.Day4.Text = "Tue. Nov. 25"
            Main.cal2.Day5.Text = "Wed. Nov. 26"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day5.Cursor = Cursors.Default
            Main.cal2.Day6.Text = "Thur. Nov. 27"
            Main.cal2.Day7.Text = "Fri. Nov. 28"
        ElseIf selectedWeek.Text = Week5.Text Then
            Main.cal2.WeekLabel.Text = "Week 5"
            handleControls()
            Main.cal2.Day1.Text = "Sat. Nov. 29"
            Main.cal2.Day2.Text = "Sun. Nov. 30"
            Main.cal2.Day3.Text = ""
            Main.cal2.Day4.Text = ""
            Main.cal2.Day5.Text = ""
            Main.cal2.Day5.Cursor = Cursors.Default
            Main.cal2.Day6.Text = ""
            Main.cal2.Day7.Text = ""
        End If
    End Sub

    Private Sub handleControls()
        For Each cont In Main.MainWatch.Controls
            cont.Hide()
        Next
        Main.cal2.Visible = True
    End Sub
End Class
