class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Goal(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}";
        }
    }