namespace game
{
    public class SecretWord
    {
        string[] words;
        private List<string> wordlist = new List<string>();
        int index;
        string word;

        public SecretWord()
        {
            Random random = new Random();
            words = System.IO.File.ReadAllLines("words.txt");
            word = " ";
            foreach (string word in words)
            {
                wordlist.Add(word);
            }
            
        }

        private string ChooseWord()
        {
            index = Random.Next(wordlist.Count);
            word = wordlist[index];
            return word;
        }

        
    }
}