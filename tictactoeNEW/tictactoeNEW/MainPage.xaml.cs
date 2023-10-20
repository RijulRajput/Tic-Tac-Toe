using System.Drawing;
namespace tictactoeNEW;


public partial class MainPage : ContentPage
{
	int count = 0;

    Microsoft.Maui.Graphics.Color Red = Microsoft.Maui.Graphics.Color.FromRgb(255, 0, 0);
    Microsoft.Maui.Graphics.Color Blue = Microsoft.Maui.Graphics.Color.FromRgb(0, 0, 255);

    List<string> board = new List<string>();
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnStartClicked(object sender, EventArgs e)
	{
        //count++;
        count = 0;

        ABtn.Text = " ";
        BBtn.Text = " ";
        CBtn.Text = " ";
        DBtn.Text = " ";
        EBtn.Text = " ";
        FBtn.Text = " ";
        GBtn.Text = " ";
        HBtn.Text = " ";
        IBtn.Text = " ";

        ABtn.IsEnabled = true;
        BBtn.IsEnabled = true;
        CBtn.IsEnabled = true;
        DBtn.IsEnabled = true;
        EBtn.IsEnabled = true;
        FBtn.IsEnabled = true;
        GBtn.IsEnabled = true;
        HBtn.IsEnabled = true;
        IBtn.IsEnabled = true;

        winnerNameLbl.Text = "Game Started";
        


    }

    private void OnABtnClicked(object sender, EventArgs e)
    {
        count++;

        if (count % 2 ==0)
        {
            //player 1
            ABtn.Text = "O";
            ABtn.BackgroundColor = Blue;


        }
        else 
        {
            //player2
            ABtn.Text = "X";
            ABtn.BackgroundColor = Red;

        }
        FindWinner();
       
        /* string win = "";
         while (win != "win")

            if (playerNum % 2 == 0)
            {
                 ABtn.Text = "X";
             }
            else if (playerNum % 2 == 1)
            {
                 ABtn.Text = "O";
             }
        */

        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnBBtnClicked(object sender, EventArgs e)
    {
        count++;
        

        if (count % 2 == 0)
        {
            //player 1
            BBtn.Text = "O";
            BBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            BBtn.Text = "X";
            BBtn.BackgroundColor = Red;
        }

        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnCBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            CBtn.Text = "O";
            CBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            CBtn.Text = "X";
            CBtn.BackgroundColor = Red;
        }

        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnDBtnClicked(object sender, EventArgs e)
    {
        count++;

        if (count % 2 == 0)
        {
            //player 1
            DBtn.Text = "O";
            DBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            DBtn.Text = "X";
            DBtn.BackgroundColor = Red;
        }

        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnEBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            EBtn.Text = "O";
            EBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            EBtn.Text = "X";
            EBtn.BackgroundColor = Red;
        }

        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnFBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            FBtn.Text = "O";
            FBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            FBtn.Text = "X";
            FBtn.BackgroundColor = Red;
        }

        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnGBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            GBtn.Text = "O";
            GBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            GBtn.Text = "X";
            GBtn.BackgroundColor = Red;

        }
        FindWinner();
        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnHBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            HBtn.Text = "O";
            HBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            HBtn.Text = "X";
            HBtn.BackgroundColor = Red;
        }
        FindWinner();

        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void OnIBtnClicked(object sender, EventArgs e)
    {
        count++;


        if (count % 2 == 0)
        {
            //player 1
            IBtn.Text = "O";
            IBtn.BackgroundColor = Blue;

        }
        else
        {
            //player2
            IBtn.Text = "X";
            IBtn.BackgroundColor = Red;
        }
        FindWinner();

        /*if (count == 1)
			StartBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		*/
    }
    private void FindWinner()
	{
       
        if ( //player 1 winning
        //horizontal wins
        (ABtn.Text == "O" && BBtn.Text == "O" && CBtn.Text == "O") ||
        (DBtn.Text == "O" && EBtn.Text == "O" && FBtn.Text == "O") ||
        (GBtn.Text == "O" && HBtn.Text == "O" && IBtn.Text == "O") ||
        //vertical wins
        (ABtn.Text == "O" && DBtn.Text == "O" && GBtn.Text == "O") ||
        (BBtn.Text == "O" && EBtn.Text == "O" && HBtn.Text == "O") ||
        (CBtn.Text == "O" && FBtn.Text == "O" && IBtn.Text == "O") ||
        //diagonal wins
        (ABtn.Text == "O" && EBtn.Text == "O" && IBtn.Text == "O") ||
        (CBtn.Text == "O" && EBtn.Text == "O" && GBtn.Text == "O")

        )
        {
            //Console.WriteLine("O Wins! Congratulations!");
            winnerNameLbl.Text = "Player 2 Wins!!! Thanks for playing!!!";
            ABtn.IsEnabled = false;
            BBtn.IsEnabled = false;
            CBtn.IsEnabled = false;
            DBtn.IsEnabled = false;
            EBtn.IsEnabled = false;
            FBtn.IsEnabled = false;
            GBtn.IsEnabled = false;
            HBtn.IsEnabled = false;
            IBtn.IsEnabled = false;
        }
        else if ( //player 2 winning
                  //horizontal wins
         (ABtn.Text == "X" && BBtn.Text == "X" && CBtn.Text == "X") ||
        (DBtn.Text == "X" && EBtn.Text == "X" && FBtn.Text == "X") ||
        (GBtn.Text == "X" && HBtn.Text == "X" && IBtn.Text == "X") ||
        //vertical wins
        (ABtn.Text == "X" && DBtn.Text == "X" && GBtn.Text == "X") ||
        (BBtn.Text == "X" && EBtn.Text == "X" && HBtn.Text == "X") ||
        (CBtn.Text == "X" && FBtn.Text == "X" && IBtn.Text == "X") ||
        //diagonal wins
        (ABtn.Text == "X" && EBtn.Text == "X" && IBtn.Text == "X") ||
        (CBtn.Text == "X" && EBtn.Text == "X" && GBtn.Text == "X")

          )
        {
            //Console.WriteLine("X Wins! Congratulations!");
            winnerNameLbl.Text = "Player 1 Wins!!! Thanks for playing!!!";
            ABtn.IsEnabled = false;
            BBtn.IsEnabled = false;
            CBtn.IsEnabled = false;
            DBtn.IsEnabled = false;
            EBtn.IsEnabled = false;
            FBtn.IsEnabled = false;
            GBtn.IsEnabled = false;
            HBtn.IsEnabled = false;
            IBtn.IsEnabled = false;
        } // tie game
        else if (ABtn.Text != " " && BBtn.Text != " " && CBtn.Text != " " && DBtn.Text != " " && EBtn.Text != " " && FBtn.Text != " " && GBtn.Text != " " && HBtn.Text != " " && IBtn.Text != " ")
        {
            //Console.WriteLine("Tie Game!");
            winnerNameLbl.Text = "Keep playing";
        }
        else
            winnerNameLbl.Text = "Keep playing";
    }
}


