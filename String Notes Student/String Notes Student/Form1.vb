Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' A STRING is a value that represents text 
        ' (like a word or phrase)


        ' String values must be surrounded by " "

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' We can take multiple strings and combine them with
        ' the & sign. This is called CONCATONATION
        Dim greeting, name, title As String

        name = TextBox2.Text
        title = TextBox1.Text



    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' We can use .toUpperand .toLower to make
        ' a string upper or lower case
        Dim state, lower, upper As String
        state = "mICHigAn"


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' We can find the location of something within a
        ' string using INDEXOF

        Dim sentence As String
        sentence = "I am a cat."



        ' But what is an index? 
        ' Each position in the string is given a number starting at 0
        '        I   a m   a   c a t .
        ' index: 0 1 2 3 4 5 6 7 8 9 10

        ' IndexOf finds the first occurance of a, which is at index 2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' If indexOf searches and doesn't find what
        ' we're looking for, it gives us -1

        Dim animal As String
        animal = "Koala Bear"


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Substring allows us to extract a piece of a string
        Dim food As String
        food = "Avocados"


        '5 = start index, 3 = how many characters
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim name, lastName As String
        name = "Pete Cat"

        ' Locate the space


        ' When you only give substring 1 number, it takes everything
        ' from that index to the end

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim name, initial As String
        name = "Pete Cat"

        ' Write a substring to get the first initial

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim fullName As String
        fullName = "Pete The Cat"

        ' Locate the spaces


        ' IndexOf can take an optional start index
        ' For space1, we search from the beginning
        ' For space2, we search from one after space1


    End Sub
End Class
