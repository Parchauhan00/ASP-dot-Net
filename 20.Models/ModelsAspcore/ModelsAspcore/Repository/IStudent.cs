using ModelsAspcore.Models;

namespace ModelsAspcore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudent(int id);
    }
}
