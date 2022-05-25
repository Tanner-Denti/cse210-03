namespace game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {   
        private Jumper jumper = new Jumper();
        private bool isPlaying = true;
        private SecretWord secretword = new SecretWord();
        private TerminalService terminalService = new TerminalService();

        private char guess;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets the player's guess
        /// </summary>
        private void GetInputs()
        {
            guess = char.Parse(terminalService.ReadText("Enter your guess: "));
        }

        /// <summary>
        /// 
        /// </summary>
        private void DoUpdates()
        {
            if (secretword.ContainsLetter(guess))
            {
                secretword.UpdateGuess();
            }
            else
            {
                jumper.removeLine();
                jumper.wrongGuesses();
                jumper.gameOver();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DoOutputs()
        {
            
        }
    }
}