namespace game
{
    public class Jumper
    {
        bool isAlive;
        private List<string> jumper = new List<string>();
        int guessCount;
        public Jumper()
        {
            isAlive = true;
            guessCount = 0;
            string[] parachute = new string[]{"  ---  "," /   \\ ","  ---  "," \\   / ","  \\ /  ","   o   ","  /|\\  ","  / \\  ","       ","^^^^^^^"};
            jumper.AddRange(parachute) ;
        }
        // guess parameter will be boolean from secretWord letter guess.
        public void removeLine(bool guess){
            if(guess == false){
                jumper.RemoveAt(0);
            }
        }
        private void countGuesses(){
            guessCount+= 1;
        }
        private void guessRemaining(int guessCount){
            if (guessCount >= 5){
                isAlive = false;
            }
        }

        
    }
}