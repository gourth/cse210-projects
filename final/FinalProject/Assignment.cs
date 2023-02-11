class Assignment
    {
        private string Name;
        private int Code;
        private string Description;

        public Assignment(string name, int code, string description)
        {
            Name = name;
            Code = code;
            Description = description;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetCode()
        {
            return Code;
        }

        public string GetDescription()
        {
            return Description;
        }
    }