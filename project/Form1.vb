Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "srinivas" And TextBox2.Text = "sri17" Or TextBox1.Text = "amey" And TextBox2.Text = "amey23" Or TextBox1.Text = "rahul12" And TextBox2.Text = "rahul" Then

            TabPage2.Visible = True
            TabPage1.Visible = False


        Else
            MessageBox.Show("PLEASE ENTER VALID USERNAME OR PASSWORD", "INVALID CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabPage3.Visible = True
        TabPage2.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabPage6.Visible = True
        TabPage3.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) Then
            ErrorProvider1.SetError(TextBox3, "only Number allowed")
        Else
            ErrorProvider1.SetError(TextBox3, "")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If Not IsNumeric(TextBox5.Text) Then
            ErrorProvider2.SetError(TextBox5, "only Number allowed")
        Else
            ErrorProvider2.SetError(TextBox5, "")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("(COMPUTER ENGINEERING)/(FIRST YEAR)")
        ComboBox1.Items.Add("(COMPUTER ENGINEERING)/(DIRECT SECOND YEAR)")
        ComboBox1.Items.Add("(ELECTRONICS AND TELECOMMUNICATION)/(FIRST YEAR)")
        ComboBox1.Items.Add("(ELECTRONICS AND TELECOMMUNICATION)/(DIRECT SECOND YEAR)")
        ComboBox1.Items.Add("(INFORMATION TECHNOLOGY)/(FIRST YEAR)")
        ComboBox1.Items.Add("(INFORMATION TECHNOLOGY)/(DIRECT SECOND YEAR)")

        ComboBox2.Items.Add("(SSC RESULT) / (LEAVING CERTIFICATE)")
        ComboBox2.Items.Add("(SSC RESULT) & (HSC RESULT) / (LEAVING CERTIFICATE)")


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TabPage4.Visible = True
        TabPage3.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabPage5.Visible = True
        TabPage3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabPage7.Visible = True
        TabPage2.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabPage3.Visible = True
        TabPage4.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabPage3.Visible = True
        TabPage5.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TabPage3.Visible = True
        TabPage6.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabPage2.Visible = True
        TabPage3.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabPage2.Visible = True
        TabPage7.Visible = False
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If TextBox3.Text = "amey" Then
            TabPage9.Visible = True
            TabPage7.Visible = False
        ElseIf TextBox3.Text = "srinivas" Then
            TabPage8.Visible = True
            TabPage7.Visible = False
        Else TextBox3.Text = "rahul"
            TabPage10.Visible = True
            TabPage7.Visible = False
        End If

        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Butt_Click(sender As Object, e As EventArgs) Handles Butt.Click
        TabPage1.Visible = True
        TabPage8.Visible = False
    End Sub

    Private Sub TabPage9_Click(sender As Object, e As EventArgs) Handles TabPage9.Click

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TabPage1.Visible = True
        TabPage9.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TabPage1.Visible = True
        TabPage10.Visible = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TabPage1.Visible = True
        TabPage2.Visible = False
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
    End Sub
End Class
