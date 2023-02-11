class Department
    {
        private string Name;
        private int Code;

        public Department(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetCode()
        {
            return Code;
        }
    }