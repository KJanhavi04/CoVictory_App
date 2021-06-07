Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem = "Mumbai" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            'adding items Listbox1 = Private
            ListBox1.Items.Add("Kokilaben Hospital")
            ListBox1.Items.Add("Nanavati Hospital")
            ListBox1.Items.Add("Zaydus Hospital")

            'adding items Listbox2 = Public
            ListBox2.Items.Add("KEM Hospital")
            ListBox2.Items.Add("Hindusabha")
            ListBox2.Items.Add("Wadia")
        End If

        If ComboBox1.SelectedItem = "Pune" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            'adding items Listbox1 = Private
            ListBox1.Items.Add("Sanchiti Hospital")
            ListBox1.Items.Add("Sahyadri Hospital")
            ListBox1.Items.Add("Jupiter Hospital")

            'adding items Listbox2 = Public
            ListBox2.Items.Add("Bharti Vidyapeeth")
            ListBox2.Items.Add("Ruby Hospital")
            ListBox2.Items.Add("Sassoon Hospital")

        End If

        If ComboBox1.SelectedItem = "Aurangabad" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            'adding items Listbox1 = Private
            ListBox1.Items.Add("Centruy Hospital")
            ListBox1.Items.Add("JJ Hospital")
            ListBox1.Items.Add("Zen Hospital")

            'adding items Listbox2 = Public
            ListBox2.Items.Add("A.S Hospital")
            ListBox2.Items.Add("MGM Hospital")
            ListBox2.Items.Add("Aurangabad Hospital")

        End If

        If ComboBox1.SelectedItem = "Nashik" Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            'adding items Listbox1 = Private
            ListBox1.Items.Add("Ashoka Hospital")
            ListBox1.Items.Add("Sahyadri Hospital")
            ListBox1.Items.Add("Zaya Hospital")

            'adding items Listbox2 = Public
            ListBox2.Items.Add("Nagpur Main Road Hospital")
            ListBox2.Items.Add("Gov Hospital")
            ListBox2.Items.Add("GP Hospital")

        End If

        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(40, 40, 40, 80)
        'Adding items into comboBox

        ComboBox1.Items.Add("Mumbai")
        ComboBox1.Items.Add("Pune")
        ComboBox1.Items.Add("Aurangabad")
        ComboBox1.Items.Add("Nashik")

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If RadioButton9.Checked Then
            TextBox1.Text = MonthCalendar1.SelectionStart.ToShortDateString
            TextBox2.Text = MonthCalendar1.SelectionStart.AddDays(42).ToShortDateString
            TextBox5.Text = RadioButton9.Text
        ElseIf RadioButton10.Checked Then
            TextBox1.Text = MonthCalendar1.SelectionStart.ToShortDateString
            TextBox2.Text = MonthCalendar1.SelectionStart.AddDays(48).ToShortDateString
            TextBox5.Text = RadioButton10.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()
        Form1.infoPnel.Show()

    End Sub

    Private Sub Receipt_Load(sender As Object, e As PaintEventArgs) Handles Receipt.Paint

        Dim tempHos, tempCity, tempTime As String

        TextBox9.Text = System.DateTime.Now.ToString("dd/MM/yyyy")

        TextBox3.Text = Form1.tempUni
        TextBox4.Text = Form1.tempName
        If RadioButton1.Checked Then
            tempHos = ListBox1.SelectedItem
        ElseIf RadioButton2.Checked Then
            tempHos = ListBox2.SelectedItem
        End If
        tempCity = ComboBox1.SelectedItem

        TextBox6.Text = tempHos & ", " & tempCity
        'RUN KRNA
        'TextBox6.Text = tempCity
        TextBox8.Text = TextBox2.Text

        If RadioButton4.Checked Then
            tempTime = RadioButton4.Text
        ElseIf RadioButton3.Checked Then
            tempTime = RadioButton3.Text
        ElseIf RadioButton5.Checked Then
            tempTime = RadioButton5.Text
        ElseIf RadioButton6.Checked Then
            tempTime = RadioButton6.Text
        ElseIf RadioButton7.Checked Then
            tempTime = RadioButton7.Text
        ElseIf RadioButton8.Checked Then
            tempTime = RadioButton8.Text
        End If

        TextBox7.Text = tempTime & ", " & TextBox1.Text

        TextBox3.Text = Form1.TextBox8.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Receipt.Visible = True
        TabControl1.Visible = False
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class



