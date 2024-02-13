Public Class frm1

    Private Sub picCanada_Click(sender As Object, e As EventArgs) Handles picCanada.Click
        MessageBox.Show("Canada is another country, not as big as the USA but still large, and it's known for its diverse culture and natural beauty. The Canadian flag, called the Maple Leaf, features a red maple leaf on a white background with two red bars, symbolizing Canada's unity and natural resources.", "HISTORY ABOUT CANADA")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Do you wish to Exit?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub picUsa_Click(sender As Object, e As EventArgs) Handles picUsa.Click
        Dim Usa As String
        MessageBox.Show("The USA is a big country made up of 50 states, and its flag has red and white stripes that represent the first 13 states and white stars on a blue background that stand for all 50 states.", "HISTORY ABOUT USA")
    End Sub

    Private Sub picJamaica_Click(sender As Object, e As EventArgs) Handles picJamaica.Click
        Dim Jamaica As String
        MessageBox.Show("Jamaica is an island nation in the Caribbean known for its vibrant culture and reggae music. The Jamaican flag features diagonal black, green, and gold (yellow) stripes. The black represents the strength and creativity of the Jamaican people, the green symbolizes the lush vegetation and agriculture, and the gold stands for the natural wealth and beauty of the island.", "HISTORY ABOUT JAMAICA")
    End Sub

    Private Sub picBrazil_Click(sender As Object, e As EventArgs) Handles picBrazil.Click
        Dim Brazil As String
        MessageBox.Show("Brazil is a country in South America known for its vast Amazon rainforest, beautiful beaches, and vibrant culture. The Brazilian flag has a green background with a yellow diamond in the center containing a blue globe with stars, representing the sky over Rio de Janeiro . The green background symbolizes Brazil's forests.", "HISTORY ABOUT BRAZIL")

    End Sub

    Private Sub picCosta_Click(sender As Object, e As EventArgs) Handles picCosta.Click
        Dim Costa As String
        MessageBox.Show("Costa Rica is a Central American country recognized for its stunning natural landscapes, including rainforests and volcanoes. The Costa Rican flag features five horizontal stripes - blue at the top and bottom, with white in the middle, representing the clear blue skies and the pure intentions of the country. In between the white stripes are two red stripes, signifying the warmth and hospitality of the Costa Rican people. The national coat of arms is in the white stripe.", "HISTORY ABOUT COSTA RICA")
    End Sub

    Private Sub picBahamas_Click(sender As Object, e As EventArgs) Handles picBahamas.Click
        Dim Bahamas As String
        MessageBox.Show("The Bahamas is an island nation in the Atlantic Ocean, famous for its beautiful turquoise waters and stunning beaches. The Bahamian flag consists of three horizontal stripes: aquamarine at the top and bottom, representing the surrounding ocean, and a yellow stripe in the middle, symbolizing the sandy beaches and the sunny climate. In the center of the yellow stripe is a black equilateral triangle, which represents the resilience and strength of the Bahamian people.", "HISTORY ABOUT BAHAMAS")
    End Sub

    Private Sub picArgen_Click(sender As Object, e As EventArgs) Handles picArgen.Click
        Dim Argen As String
        MessageBox.Show("Argentina is a South American country famous for its vast pampas, tango music, and delicious beef. The Argentine flag consists of three horizontal stripes - light blue and white. The blue and white stripes represent the sky and clouds, and in the center, there is a golden sun with a face.", "HISTORY ABOUT ARGENTINA")
    End Sub

    Private Sub picChile_Click(sender As Object, e As EventArgs) Handles picChile.Click
        Dim Chile As String
        MessageBox.Show("Chile is a South American country celebrated for its stunning natural landscapes, including the Andes Mountains and Pacific coastline. The Chilean flag features two horizontal bands: a white one on the top, representing the snow-capped Andes Mountains, and a red one on the bottom, symbolizing the bloodshed in the country's fight for independence. There's also a blue square in the upper hoist-side corner with a white five-pointed star, signifying a guide to progress and honor", "HISTORY ABOUT CHILE")
    End Sub

    Private Sub picPeru_Click(sender As Object, e As EventArgs) Handles picPeru.Click
        Dim Peru As String
        MessageBox.Show("Peru is a South American nation famous for its rich history, ancient civilizations like the Incas, and diverse landscapes. The flag of Peru consists of three vertical stripes: red on the left, white in the middle, and red on the right. The red stripes symbolize the bloodshed for independence, while the white stripe represents peace and purity.", "HISTORY ABOUT PERU")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles picUruguay.Click
        Dim Uruguay As String
        MessageBox.Show("Uruguay is a South American country known for its beautiful beaches and progressive policies. The flag of Uruguay features nine alternating blue and white horizontal stripes, with a white sun with a face. The blue and white stripes symbolize the country's nine original departments.", "HISTORY ABOUT URUGUAY")
    End Sub


End Class
