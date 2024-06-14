using BOL;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDB db = new StudentDB();
            IEnumerable<Student> s= db.GetAll();
            foreach (Student ss in s)
            {
                Console.WriteLine(ss.Name+" "+ss.RollNo);
            }
        }
    } 
}
