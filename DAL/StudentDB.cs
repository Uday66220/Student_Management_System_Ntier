using BOL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IStudent
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void insert(Student student);
        void update(Student student);
        void delete(int id);

        void save();
    }

    public class StudentDB : IStudent, IDisposable
    {
        OrgDBContext _dbContext;
        public StudentDB()
        {
            _dbContext = new OrgDBContext();
        }

        public void delete(int id)
        {
            Student s = _dbContext.Students.Find(id);
            _dbContext.Students.Remove(s);
        }

        public IEnumerable<Student> GetAll()
        {
            IEnumerable<Student> s= _dbContext.Students;
            return s;
        }

        public Student GetById(int id)
        {
            Student s=_dbContext.Students.Find(id);
            return s;
        }

        public void insert(Student student)
        {
            _dbContext.Students.Add(student);    
        }

        

        public void update(Student student)
        {
            _dbContext.Students.Update(student);
        }
        public void save()
        {
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
