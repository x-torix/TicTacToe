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
    }
}