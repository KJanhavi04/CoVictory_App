Imports System.Data.OleDb
Public Class Form1
    Dim value1 As Integer
    Dim value2 As Integer
    Public tempUni As String
    Public tempName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserInfoDataSet4.userInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter1.Fill(Me.UserInfoDataSet4.userInfo)

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty

        'Random no; generator code
        Randomize()
        'Generate random value between 1 and 6. 
        value1 = CInt(Int((10 * Rnd()) + 1))
        TextBox3.Text = value1
        value2 = CInt(Int((10 * Rnd()) + 1))
        TextBox9.Text = value2

        welcomePan1.BackColor = Color.FromArgb(40, 40, 40, 80)
        welcomePan2.BackColor = Color.FromArgb(40, 40, 40, 80)
        Panel3.BackColor = Color.FromArgb(40, 40, 40, 80)
        'Button1.BackColor = Color.FromArgb(40, 40, 40, 80)
        Label12.Text = "We proposed an architecture whose main goal is to improve productivity in user interface development for a Vaccine Management System."
        Label13.Text = "Our project is a set of classes that encapsulates the creation of the graphical user interface (GUI) portion of a typical management system application."

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        welcomePan.Visible = False
        Login.Visible = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles back.Click
        welcomePan.Visible = True
        Login.Visible = False

    End Sub

    Private Sub LoginB1_Click(sender As Object, e As EventArgs) Handles LoginB1.Click
        If TextBox10.Text = (value1 + value2) Then
            Login.Visible = False
            infoPnel.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        welcomePan.Visible = True
        Register.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        welcomePan.Visible = False
        Register.Visible = True
        UserInfoBindingSource1.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form2.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        infoPnel.Visible = True
        Register.Visible = False

        On Error GoTo SaveError
        Me.Validate()
        UserInfoBindingSource1.EndEdit()
        Me.UserInfoTableAdapter1.Update(Me.UserInfoDataSet4.userInfo)
        Me.UserInfoTableAdapter1.Fill(Me.UserInfoDataSet4.userInfo)
        MessageBox.Show("Your Data Saved Successfully !!!")

SaveError:
        Exit Sub


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        infoPnel.Visible = False
        welcomePan.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        dataHide.Visible = True
        welcomePan.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dataHide.Visible = False
        welcomePan.Visible = True
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        infoPnel.Visible = True
        welcomePan.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim counter As Integer
        Dim db = UserInfoDataSet4.userInfo
        For Each user In db
            If (TextBox1.Text = user.Username) Then
                counter = 1
                tempName = user.Username
                tempUni = user.unique_id
            End If

        Next

        If counter = 1 Then
            MessageBox.Show("User Found")
        Else
            MessageBox.Show("User Not Found")
        End If

        Dim UserSum As Integer = TextBox10.Text

        If UserSum = (value1 + value2) Then
            MessageBox.Show("Correct Answer")
        Else
            MessageBox.Show("InCorrect Answer")
        End If


    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

        Randomize()
        TextBox8.Text = CInt(Int((100 * Rnd()) + 1))

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class