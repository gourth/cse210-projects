class Course
    {
        private string Name;
        private int Code;

        public Course(string name, int code)
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