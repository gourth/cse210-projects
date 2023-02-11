class Grade
    {
        private Student student;
        private Course course;
        private Assignment assignment;
        private int Score;

        public Grade(Student student, Course course, Assignment assignment, int score)
        {
            this.student = student;
            this.course = course;
            this.assignment = assignment;
            Score = score;
        }

        public Student GetStudent()
        {
            return student;
        }

        public Course GetCourse()
        {
            return course;
        }

        public Assignment GetAssignment()
        {
            return assignment;
        }

        public int GetScore()
        {
            return Score;
        }
    }