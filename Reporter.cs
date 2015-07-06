using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsReports
{
    static class Reporter
    {
        public static void Report()
        {
            DataRepository repository = new DataRepository();
            repository.Initialize();
            
            // Test results grouped by user. Used in other queries.
            var resultsByUser = from tr in repository.TestResults
                                group tr by tr.User into tmp
                                select new {User = tmp.Key, Result = tmp};

            // Report 1. Users that successfully passed their tests, regardless of time taken. 
            var Report1 = from ru in resultsByUser
                        where (from tr in ru.Result
                               where tr.Result >= tr.Test.PassingScore
                               select tr).Count() == ru.Result.Count()
                        select ru.User;

            // Report 2. Users that successfully passed their tests in time.
            var Report2 = from ru in resultsByUser
                          where (from tr in ru.Result
                                 where tr.Result >= tr.Test.PassingScore && tr.TimeTaken <= tr.Test.TimeGiven
                                 select tr).Count() == ru.Result.Count()
                          select ru.User;

            // Report 3. Users that successfully passed their tests, but didn't make it in time.
            var Report3 = from ru in resultsByUser
                          where (from tr in ru.Result
                                 where tr.Result >= tr.Test.PassingScore && tr.TimeTaken > tr.Test.TimeGiven
                                 select tr).Count() > 0
                                 && 
                                 (from tr in ru.Result
                                  where tr.Result >= tr.Test.PassingScore
                                  select tr).Count() == ru.Result.Count()
                          select ru.User;
            // Report 4. Number of students grouped by city
            var Report4 = from u in repository.Users
                          group u by u.City into tmp
                          select new { City = tmp.Key, User = tmp };

            // Report 5. Successful students grouped by city
            var Report5 = from u in
                              (from ru in resultsByUser
                               where (from tr in ru.Result
                                      where tr.Result >= tr.Test.PassingScore && tr.TimeTaken <= tr.Test.TimeGiven
                                      select tr).Count() == ru.Result.Count()
                               select ru.User)
                          group u by u.City into tmp
                          select new { City = tmp.Key, User = tmp };

            // Report 6. Results for every student + success rate (%)
            var Report6 = from s in
                              (from tr in repository.TestResults
                               group tr by tr.User into tmp
                               select new { User = tmp.Key, Result = tmp })
                          select new { User = s.User, Result = s.Result, Rate = (double)s.Result.Sum(item => item.Result) / 400 * 100 };

            Console.WriteLine("\nReport 1. Users that successfully passed their tests, regardless of time taken");
            foreach (var item in Report1)
            {
                Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
            }
            Console.WriteLine("\nReport 2. Users that successfully passed their tests in time");
            foreach (var item in Report2)
            {
                Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
            }
            Console.WriteLine("\nReport 3. Users that successfully passed their tests but didn't make it in time");
            foreach (var item in Report3)
            {
                Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
            }
            Console.WriteLine("\nReport 4. Number of students grouped by city");
            foreach (var item in Report4)
            {
                Console.WriteLine("{0} -- {1} student(s)", item.City, item.User.Count());
                foreach (var student in item.User)
                {
                    Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", student.Name, student.Email, student.Age, student.Category, student.City, student.University);
                }
            }
            Console.WriteLine("\nReport 5. Successful students grouped by city");
            foreach (var item in Report5)
            {
                Console.WriteLine("{0} -- {1} successful student(s)", item.City, item.User.Count());
                foreach (var student in item.User)
                {
                    Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", student.Name, student.Email, student.Age, student.Category, student.City, student.University);
                }
            }
            Console.WriteLine("\nReport 6. Results for every student + success rate (%)");
            foreach (var item in Report6)
            {
                Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.User.Name, item.User.Email, item.User.Age, item.User.Category, item.User.City, item.User.University);
                Console.WriteLine("Success rate = {0}", item.Rate);
                foreach (var result in item.Result)
                {
                    Console.WriteLine("{0} -- {1}", result.Test.Name, result.Result);
                }
            }
        }    
    }
}
