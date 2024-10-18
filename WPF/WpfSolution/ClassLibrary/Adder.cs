namespace ClassLibrary
{
    public class Adder
    {
        private List<int> numberList;
        public Adder()
        {
            this.numberList = new List<int>();
        }

        public void AddNumber(int _numToAdd)
        {
            this.numberList.Add(_numToAdd);
        }

        public int GetResult()
        {
            int result = 0;
            if (this.numberList.Count > 0)
            {
                foreach (int i in this.numberList) 
                {
                    result += i;
                }
                this.numberList = new List<int> { result };
                return result;
            } else
            {
                return result;
            }
        }

    }
}
