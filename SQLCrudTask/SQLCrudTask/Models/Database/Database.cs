using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQLCrudTask.Models.Database
{
    public class Database
    {
        public SqlConnection conn;
        public Admins admins { get; set; }
        public Students students { get; set; }
        public Depts depts { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-01TA4PH;Database=SMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            this.admins = new Admins(conn);
            this.students = new Students(conn);
            this.depts = new Depts(conn);
        }
        public bool verify(Admin admin)
        {
            return admin.verify(this.admins);
        }
        public List<Student> getAllStudents()
        {
            return students.getAll();
        }
        public bool add(Student student)
        {
            return students.add(student);
        }
        public bool edit(Student student)
        {
            return students.edit(student);
        }
        public bool delete(int id)
        {
            return students.delete(id);
        }
        public bool get(int id)
        {
            return students.get(id);
        }

    }
}