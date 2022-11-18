namespace SchoolDemo
{
    public class ClassRoom
    {
        public int ClassNo { get; set; }
        public string Letter { get; set; }
        public string Department { get; set; }

        //10-FM-C
        public string ClassName { get; }

        private List<Student> students;

        public void AddStudent()
        {

        }

        public int StudentsCount { get => students.Count; }

        public Instructor MasterInstructor { get; set; }

    }
}
