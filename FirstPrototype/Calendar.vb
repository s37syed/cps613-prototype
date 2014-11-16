Public Class Calendar
    'user control for days of the first half of the month 
    Friend SelectableDay As Integer
    Private Sub Week1_Click(sender As Object, e As EventArgs) Handles Week1.Click, Week2.Click, Week3.Click, Week4.Click, Week5.Click
        If Main.cal.SelectableDay = 3 Then
            Main.cal2.Day5.Cursor = Cursors.Hand
        Else
            Main.cal2.Day5.Cursor = Cursors.Default
        End If
        Dim selectedWeek As Label = sender
        If selectedWeek.Text = Week1.Text Then
            SelectableDay = 1
            Main.cal2.WeekLabel.Text = "Week 1"
            handleControls()
            Main.cal2.Day1.Text = "Saturday Nov. 1"
            Main.cal2.Day2.Text = "Sunday Nov. 2"
            Main.cal2.Day3.Text = "Monday Nov. 3"
            Main.cal2.Day4.Text = "Tuesday Nov. 4"
            Main.cal2.Day5.Text = "Wednesday Nov. 5"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day6.Text = "Thursday Nov. 6"
            Main.cal2.Day7.Text = "Friday Nov. 7"
        ElseIf selectedWeek.Text = Week2.Text Then
            SelectableDay = 2
            Main.cal2.WeekLabel.Text = "Week 2"
            handleControls()
            Main.cal2.Day1.Text = "Saturday Nov. 8"
            Main.cal2.Day2.Text = "Sunday Nov. 9"
            Main.cal2.Day3.Text = "Monday Nov. 10"
            Main.cal2.Day4.Text = "Tuesday Nov. 11"
            Main.cal2.Day5.Text = "Wednesday Nov. 12"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day6.Text = "Thursday Nov. 13"
            Main.cal2.Day7.Text = "Friday Nov. 14"
        ElseIf selectedWeek.Text = Week3.Text Then
            SelectableDay = 3
            Main.cal2.WeekLabel.Text = "Week 3"
            handleControls()
            Main.cal2.Day1.Text = "Saturday Nov. 15"
            Main.cal2.Day2.Text = "Sunday Nov. 16"
            Main.cal2.Day3.Text = "Monday Nov. 17"
            Main.cal2.Day4.Text = "Tuesday Nov. 18"
            Main.cal2.Day5.Text = "Wednesday Nov. 19"
            Main.cal2.Day5.BackColor = Color.IndianRed
            Main.cal2.Day6.Text = "Thursday Nov. 20"
            Main.cal2.Day7.Text = "Friday Nov. 21"
        ElseIf selectedWeek.Text = Week4.Text Then
            SelectableDay = 4
            Main.cal2.WeekLabel.Text = "Week 4"
            handleControls()
            Main.cal2.Day1.Text = "Saturday Nov. 22"
            Main.cal2.Day2.Text = "Sunday Nov. 23"
            Main.cal2.Day3.Text = "Monday Nov. 24"
            Main.cal2.Day4.Text = "Tuesday Nov. 25"
            Main.cal2.Day5.Text = "Wednesday Nov. 26"
            Main.cal2.Day5.BackColor = Color.Transparent
            Main.cal2.Day6.Text = "Thursday Nov. 27"
            Main.cal2.Day7.Text = "Friday Nov. 28"
        ElseIf selectedWeek.Text = Week5.Text Then
            Main.cal2.WeekLabel.Text = "Week 5"
            handleControls()
            Main.cal2.Day1.Text = "Saturday Nov. 29"
            Main.cal2.Day2.Text = "Sunday Nov. 30"
            Main.cal2.Day3.Text = ""
            Main.cal2.Day4.Text = ""
            Main.cal2.Day5.Text = ""
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
