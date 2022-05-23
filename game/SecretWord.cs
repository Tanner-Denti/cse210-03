namespace game
{
    public class SecretWord
    {
        private List<string> wordlist = new List<string>();
        int index;
        string word;
        string guess;
        Random random = new Random();

        public SecretWord()
        {
            string[] words = System.IO.File.ReadAllLines("words.txt");
            wordlist = new List<string>(words);
            guess = " ";
            word = " ";
            
        }

        private string ChooseWord()
        {
            index = random.Next(wordlist.Count);
            word = wordlist[index];
            return word;
        }

        public void GetGuess()
        {
            
        }

        private void UpdateGuess()
        {

        }

        public Boolean ContainsLetter(Char letter)
        {
            return word.Contains(letter);
        }
        
    }
}