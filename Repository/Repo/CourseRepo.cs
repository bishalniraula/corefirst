using CoreFirst.Data;
using CoreFirst.Models;
using CoreFirst.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CoreFirst.Repository.Repo
{
    public class CourseRepo : ICourseRepo
    {
        private AppDbContext _context;

        public CourseRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
             _context.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> DeleteCourseAsync(int? id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> EditCourseAsync(Course course)
        {
            _context.Update(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> GetCourseByIdAsync(int? id)
        {
            Course course = new Course();
            if (id == null || _context.Courses == null)
            {
                return course;
            }

            course = await _context.Courses?.FirstOrDefaultAsync(m => m.Id == id);
            return course;
        }

        public Task<List<Course>> GetCoursesAsync()
        {
            return _context.Courses.ToListAsync();
        }
    }
}
