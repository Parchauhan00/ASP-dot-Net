using ModelsAspcore.Models;

namespace ModelsAspcore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudent(int id)
        {
            //throw new NotImplementedException();
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();

        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
            
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>()
            {
                new StudentModel() { rollNo = 1,Name = "prime", Gender = "Male",Standard=11 },
                 new StudentModel() { rollNo = 2,Name = "prime", Gender = "Male",Standard=12 },
                  new StudentModel() { rollNo = 3,Name = "prime king", Gender = "Male",Standard=7 },
                   new StudentModel() { rollNo = 4,Name = "prime super", Gender = "Male",Standard=5 },
                    new StudentModel() { rollNo = 5,Name = "prime vip", Gender = "Male",Standard=10 }
            };
        }
    }
}
