class Transcript
    {
        private Student student;
        private University university;
        private Grade grade;

        public Transcript(Student student, University university, Grade grade)
        {
            this.student = student;
            this.university = university;
            this.grade = grade;
        }

        public override string ToString()
        {
            return "Student: " + student.GetName() + "\n" +
                   "Student ID: " + student.GetId() + "\n" +
                   "Course: " + grade.GetCourse().GetName() + "\n" +
                   "Course Code: " + grade.GetCourse().GetCode() + "\n" +
                   "Teacher: " + grade.GetAssignment().GetName() + "\n" +
                   "Teacher Subject: " + grade.GetAssignment().GetDescription() + "\n" +
                   "Department: " + grade.GetCourse().GetName() + "\n" +
                   "Department Code: " + grade.GetCourse().GetCode() +
                    "Score: " + grade.GetScore() + "\n" +
                   "University: " + university.GetName() + "\n" +
                   "University Address: " + university.GetAddress();
        }
    }