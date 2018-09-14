Public Class Days_of_Christmas

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles dayNumUpDown.ValueChanged

        purchaseButton.BackColor = Color.Red    'Aesthetics
        resultLabel.BackColor = Color.Red

        resultLabel.Text = ""
        purchaseButton.Enabled = True

    End Sub

    Sub day1(ByRef total As Decimal)

        'Partridge in a pear tree - $104.99.
        Dim result As Decimal = 104.99

        total += result

    End Sub

    Sub day2(ByRef total As Decimal)

        'Turtle doves - $20.00 x 2.
        Dim result As Decimal = 20.0 * 2

        total += result
        day1(total)

    End Sub

    Sub day3(ByRef total As Decimal)

        'French hens - $15.00 x 3.
        Dim result As Decimal = 15.0 * 3

        total += result
        day2(total)

    End Sub

    Sub day4(ByRef total As Decimal)

        'Calling birds - $99.99 x 4.
        Dim result As Decimal = 99.99 * 4

        total += result
        day3(total)

    End Sub

    Sub day5(ByRef total As Decimal)

        'Golden rings - $65.00 x 5.
        Dim result As Decimal = 65.0 * 5

        total += result
        day4(total)

    End Sub

    Sub day6(ByRef total As Decimal)

        'Geese a-laying - $50.00 x 6.
        Dim result As Decimal = 50.0 * 6

        total += result
        day5(total)

    End Sub

    Sub day7(ByRef total As Decimal)

        'Swans a-swimming - $600.00 x 7.
        Dim result As Decimal = 600.0 * 7

        total += result
        day6(total)

    End Sub

    Sub day8(ByRef total As Decimal)

        'Maids a-milking - $5.15 x 8. 
        Dim result As Decimal = 5.15 * 8

        total += result
        day7(total)

    End Sub

    Sub day9(ByRef total As Decimal)

        'Ladies dancing - $508.46 x 9.
        Dim result As Decimal = 508.46 * 9

        total += result
        day8(total)

    End Sub

    Sub day10(ByRef total As Decimal)

        'Lords a-leaping * 403.91 x 10. 
        Dim result As Decimal = 403.91 * 10

        total += result
        day9(total)

    End Sub

    Sub day11(ByRef total As Decimal)

        'Pipers piping - 186.65 x 11.
        Dim result As Decimal = 186.65 * 11

        total += result
        day10(total)

    End Sub

    Sub day12(ByRef total As Decimal)

        'Drummers drumming - 185.36 x 12.
        Dim result As Decimal = 185.36 * 12

        total += result
        day11(total)

    End Sub


    Private Sub purchaseButton_Click(sender As Object, e As EventArgs) Handles purchaseButton.Click

        resultLabel.BackColor = Color.Green
        purchaseButton.BackColor = Color.Green

        Dim total As Decimal = 0    'Variable for total result

        Select Case dayNumUpDown.Value

            Case 1

                day1(total) 'Send in total by reference

                resultLabel.Text = "On the 1st Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 2

                day2(total)     'Call day2

                resultLabel.Text = "On the 2nd Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 3

                day3(total)     'Call day3

                resultLabel.Text = "On the 3rd Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 4

                day4(total)     'Call day4

                resultLabel.Text = "On the 4th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 5

                day5(total)     'Call day5

                resultLabel.Text = "On the 5th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 6

                day6(total)     'Call day6

                resultLabel.Text = "On the 6th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 7

                day7(total)     'Call day7

                resultLabel.Text = "On the 7th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 8

                day8(total)     'Call day8

                resultLabel.Text = "On the 8th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Eight Maids A-Milking" &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 9

                day9(total)     'Call day9

                resultLabel.Text = "On the 9th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Nine Ladies Dancing" &
                                    vbCrLf & "Eight Maids A-Milking" &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 10

                day10(total)    'Call day10

                resultLabel.Text = "On the 10th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Ten Lords A-Leaping" &
                                    vbCrLf & "Nine Ladies Dancing" &
                                    vbCrLf & "Eight Maids A-Milking" &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 11

                day11(total)    'Call day11

                resultLabel.Text = "On the 11th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Eleven Pipers Piping" &
                                    vbCrLf & "Ten Lords A-Leaping" &
                                    vbCrLf & "Nine Ladies Dancing" &
                                    vbCrLf & "Eight Maids A-Milking" &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case 12

                day12(total)    'Call day12

                resultLabel.Text = "On the 12th Day of Christmas, my true love gave to me" & vbCrLf &
                                    vbCrLf & "Twelve Drummers Drumming" &
                                    vbCrLf & "Eleven Pipers Piping" &
                                    vbCrLf & "Ten Lords A-Leaping" &
                                    vbCrLf & "Nine Ladies Dancing" &
                                    vbCrLf & "Eight Maids A-Milking" &
                                    vbCrLf & "Seven Swans A-Swimming" &
                                    vbCrLf & "Six Geese A-Laying" &
                                    vbCrLf & "Five Golden Rings" &
                                    vbCrLf & "Four Calling Birds" &
                                    vbCrLf & "Three French Hens" &
                                    vbCrLf & "Two Turtle Doves" &
                                    vbCrLf & "A Partridge in a Pear Tree" &
                                    vbCrLf & vbCrLf & "Total Cost: $" & total

            Case Else

                'Wrong choice, Error box pop up

                MsgBox("That isn't part of the song.... How can you have 0 Days of Christmas?", MsgBoxStyle.Exclamation, "Bah-Humbug! Error")

        End Select

    End Sub
End Class
