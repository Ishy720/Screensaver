namespace Ambience
{
    class userSettings
    {
        private string backgroundColour = "Black";

        public userSettings setBackgroundColour(string newColour) //setter
        {
            this.backgroundColour = newColour;
            return this;
        }

        public string getBackgroundColour() //getter
        {
            return this.backgroundColour;
        }
    }
}
