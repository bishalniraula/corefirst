using CoreFirst.Models;


namespace CoreFirst.Repository.Interface
{
    public interface ICourseRepo
    {
        public  Task<List<Course>> GetCoursesAsync();
        public Task<Course> GetCourseByIdAsync(int? id);
        Task<Course> AddCourseAsync(Course course);
        Task<Course> EditCourseAsync(Course course);
        Task<Course> DeleteCourseAsync(int? id);
        
    }
}
