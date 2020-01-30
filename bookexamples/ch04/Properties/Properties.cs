namespace Properties
{
    class Properties
    {
        public int Number { get; set; }
        public string Word { get; set; }

        int num2;

        public int Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }
        public string getNumWord() 
        {
            return Number + " " + Word;
        }
    }
}
