namespace game
{
        /// <summary>
    /// <para>The Secret Word.</para>
    /// <para>
    /// The responsibility of SecretWord is to choose a random word from a list, store that word as an attribute, 
    /// check to see if the player guess is in that word, store the player's guess as a new variable, and allow other classes
    /// to get the guess.
    /// </para>
    /// </summary>
    public class SecretWord
    {
        private List<string> wordlist;
        private List<string> guessList;
        int index;
        string word;
        string guess;
        Random random = new Random();

        /// <summary>
        /// Constructs a new instance of SecretWord. 
        /// </summary>
        public SecretWord()
        {
            //Create an array from the words txt file and then add it to a list
            string[] words = System.IO.File.ReadAllLines("words.txt");
            wordlist = new List<string>(words);
            //
            guessList = new List<string>();
            guess = "";
            word = "";
            //Choose a random word from the words list
            ChooseWord();
            
        }
        /// <summary>
        /// Chooses a random word from the word list. 
        /// </summary>
        private void ChooseWord()
        {
            index = random.Next(wordlist.Count);
            word = wordlist[index];
        }

        public string GetGuess()
        {
            return guess;
        }


        public void CreateUnderscores() 
        {
            for (int i = 0; i < word.Length; i++)
            {
                guessList.Add("_");
            }
        }
        public void UpdateGuess(string guess, string word) //TANNER FINISH THIS
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                if (guess == Convert.ToString(word[i]))
                {
                    guessList[i] = Convert.ToString(word[i]);
                }
            }
        }

        /// <summary>
        /// Checks if the player's guess exists in the secret word. Returns a boolean. 
        /// </summary>
        public Boolean ContainsLetter(Char letter)
        {
            return word.Contains(letter);
        }
        
    }
}