class University
    {
        private string Name;
        private string Address;

        public University(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address;
        }
    }