namespace kółko_i_krzyżyk
{ 
    enum CurrentPlayer 
    {
        cross, 
        circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer cp;

        public Form1()
        {
            InitializeComponent();
            cp = CurrentPlayer.cross;
            currentPlayer.Text = "krzyżyk";
            changeLabel();
        }

        private void Jackson(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;

            if(cp ==CurrentPlayer.cross)
            {
                senderButton.Text = "X";
                cp = CurrentPlayer.circle;
            }
            else
            {
                senderButton.Text = "0";
                cp = CurrentPlayer.cross;
            }

            checkForWinner();
            changeLabel();
        }
        public void changeLabel()
        {
            if (cp == CurrentPlayer.cross)
            {
                currentPlayer.Text = "Krzyżyk";
            }
            else
            {
                currentPlayer.Text = "Kółko";
            }
        }
        public void checkForWinner()
        {
            if (String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(tc.Text, cc.Text) == 0 && String.Compare(cc.Text, bc.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tc.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(tr.Text, cr.Text) == 0 && String.Compare(cr.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(tl.Text, tc.Text) == 0 && String.Compare(tc.Text, tr.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(cl.Text, cc.Text) == 0 && String.Compare(cc.Text, cr.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = cl.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(bl.Text, bc.Text) == 0 && String.Compare(bc.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = bl.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(tl.Text, cc.Text) == 0 && String.Compare(cc.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();

            }
            else if (String.Compare(tr.Text, cc.Text) == 0 && String.Compare(cc.Text, bl.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();

        }
            else
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = "remis";
            }
        }
        //string.compare zwraca zero
        //jeśli są identyczne
    }
}
