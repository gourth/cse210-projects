class Teacher
    {
        private string Name;
        private string Subject;

        public Teacher(string name, string subject)
        {   Name = name;
            Subject = subject;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSubject()
        {
            return Subject;
        }
    }