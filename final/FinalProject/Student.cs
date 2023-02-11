class Student
    {
        private string Name;
        private int Id;

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetId()
        {
            return Id;
        }
    }