namespace Task2.PhoneBook
{

    class PhoneNumber
    {
        public long Number { get; set; }

        public PhoneNumber(long number)
        {
            Number = number;
        }


        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
