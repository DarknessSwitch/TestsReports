using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsReports
{
    class DataRepository
    {
        public List<User> Users {get; set;}
        public List<Test> Tests { get; set; }
        public List<TestResult> TestResults { get; set; }
        public void Initialize()
        {
            Users = new List<User>
            {
                new User
                {
                    Name = "Andrey",
                    Email = "andrew1337@gmail.com",
                    Age = 19,
                    Category = Categories.Net, 
                    City = "Zaporizhya",
                    University = "ZNTU"
                },
                new User
                {
                    Name = "Sergey",
                    Email = "sergey1336@gmail.com",
                    Age = 20,
                    Category = Categories.JS, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Alexandr",
                    Email = "sanyok@gmail.com",
                    Age = 21,
                    Category = Categories.PHP, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Varvara",
                    Email = "varya@gmail.com",
                    Age = 19,
                    Category = Categories.Net, 
                    City = "Lviv",
                    University = "LNU"
                },
                new User
                {
                    Name = "Nikita",
                    Email = "nekit@gmail.com",
                    Age = 21,
                    Category = Categories.PHP, 
                    City = "Lviv",
                    University = "LNU"
                },
                new User
                {
                    Name = "Irakliy",
                    Email = "irakliy@gmail.com",
                    Age = 19,
                    Category = Categories.JS, 
                    City = "Kharkiv",
                    University = "KNU"
                },
                new User
                {
                    Name = "Anton",
                    Email = "antoha@gmail.com",
                    Age = 20,
                    Category = Categories.JS, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Konstantin",
                    Email = "bones@gmail.com",
                    Age = 22,
                    Category = Categories.Net, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Georgiy",
                    Email = "jora1337@gmail.com",
                    Age = 21,
                    Category = Categories.PHP, 
                    City = "Lviv",
                    University = "LNU"
                },
                new User
                {
                    Name = "Tomara",
                    Email = "tomato@gmail.com",
                    Age = 22,
                    Category = Categories.JS, 
                    City = "Kharkiv",
                    University = "KNU"
                },
                new User
                {
                    Name = "Vladimir",
                    Email = "wow4ik@gmail.com",
                    Age = 20,
                    Category = Categories.Net, 
                    City = "Zaporizhya",
                    University = "ZNTU"
                },
                new User
                {
                    Name = "Valentin",
                    Email = "valek@gmail.com",
                    Age = 19,
                    Category = Categories.Net, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Yacov",
                    Email = "yasha@gmail.com",
                    Age = 22,
                    Category = Categories.JS, 
                    City = "Lviv",
                    University = "LNU"
                },
                new User
                {
                    Name = "Yaroslav",
                    Email = "yasha123@gmail.com",
                    Age = 20,
                    Category = Categories.JS, 
                    City = "Kiev",
                    University = "KPI"
                },
                new User
                {
                    Name = "Maksim",
                    Email = "maximum@gmail.com",
                    Age = 19,
                    Category = Categories.Net, 
                    City = "Kiev",
                    University = "KPI"
                }
            };
            Tests = new List<Test>
            {
                new Test
                {
                    Name = ".Net test 1",
                    Category = Categories.Net,
                    PassingScore = 60,
                    TimeGiven = 20,
                    Questions =  new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.Net,
                            Text = "How many classes can a class inherit in C#?"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 1"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 2"
                        },new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 3"
                        },new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 4"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 5"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 6"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 7"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 8"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 9"
                        }                  
                    }
                },
                new Test
                {
                    Name = ".Net test 2",
                    Category = Categories.Net,
                    PassingScore = 70,
                    TimeGiven = 35,
                    Questions =  new List<Question>
                    {
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 10"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 11"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 12"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 13"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 14"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 15"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 16"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 17"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 18"
                        },
                        new Question
                        {
                              Category = Categories.Net,
                              Text = ".Net question text 19"
                        },
                    }
                },
                new Test
                {
                    Name = "JS test 1",
                    Category = Categories.JS,
                    PassingScore = 60,
                    TimeGiven = 30,
                    Questions =  new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 1"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 2"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 3"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 4"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 5"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 6"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 7"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 8"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 9"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 10"
                        }                    
                    }
                },
                new Test 
                {
                    Name = "JS test 2",
                    Category = Categories.JS,
                    PassingScore = 50,
                    TimeGiven = 15,
                    Questions =  new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 11"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 12"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 13"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 14"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 15"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 16"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 17"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 18"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 19"
                        },
                        new Question
                        {
                            Category = Categories.JS,
                            Text = "JS question text 20"
                        }
                    }
                },
                new Test 
                {
                    Name = "PHP test 1",
                    Category = Categories.PHP,
                    PassingScore = 60,
                    TimeGiven = 30,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 1"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 2"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 3"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 4"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 5"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 6"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 7"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 8"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 9"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 10"
                        }
                    }
                },
                new Test 
                {
                    Name = "PHP test 2",
                    Category = Categories.PHP,
                    PassingScore = 70,
                    TimeGiven = 30,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 11"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 12"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 13"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 14"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 15"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 16"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 17"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 18"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 19"
                        },
                        new Question
                        {
                            Category = Categories.PHP,
                            Text = "PHP question 20"
                        }
                    }
                },
                new Test
                {
                    Name = "Datebase test",
                    Category = Categories.DB,
                    PassingScore = 60,
                    TimeGiven = 30,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 1"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 2"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 3"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 4"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 5"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 6"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 7"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 8"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 9"
                        },
                        new Question
                        {
                            Category = Categories.DB,
                            Text = "DB question 10"
                        }
                    }
                },
                new Test
                {
                    Name = "OOP test",
                    Category = Categories.OOP,
                    PassingScore = 60,
                    TimeGiven = 30,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 1"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 2"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 3"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 4"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 5"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 6"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 7"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 8"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 9"
                        },
                        new Question
                        {
                            Category = Categories.OOP,
                            Text = "OOP question 10"
                        }
                    }
                },
                new Test
                {
                    Name = "English test",
                    Category = Categories.English,
                    PassingScore = 60,
                    TimeGiven = 30,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 1"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 2"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 3"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 4"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 5"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 6"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 7"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 8"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 9"
                        },
                        new Question
                        {
                            Category = Categories.English,
                            Text = "English question 10"
                        }
                    }
                }            
            };
            TestResults = new List<TestResult>
            {
                new TestResult
                {
                    Test = Tests[8],
                    Result = 85,
                    TimeTaken = 18,
                    User = Users[0]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 65,
                    TimeTaken = 15,
                    User = Users[0]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 90,
                    TimeTaken = 17,
                    User = Users[0]
                },
                new TestResult
                {
                    Test = Tests[0],
                    Result = 90,
                    TimeTaken = 19,
                    User = Users[0]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 90,
                    TimeTaken = 30,
                    User = Users[1]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 85,
                    TimeTaken = 30,
                    User = Users[1]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 65,
                    TimeTaken = 15,
                    User = Users[1]
                },
                new TestResult
                {
                    Test = Tests[2],
                    Result = 95,
                    TimeTaken = 22,
                    User = Users[1]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 85,
                    TimeTaken = 40,
                    User = Users[2]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 90,
                    TimeTaken = 40,
                    User = Users[2]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 95,
                    TimeTaken = 40,
                    User = Users[2]
                },
                new TestResult
                {
                    Test = Tests[4],
                    Result = 65,
                    TimeTaken = 15,
                    User = Users[2]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 85,
                    TimeTaken = 22,
                    User = Users[3]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 65,
                    TimeTaken = 40,
                    User = Users[3]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 65,
                    TimeTaken = 30,
                    User = Users[3]
                },
                new TestResult
                {
                    Test = Tests[1],
                    Result = 85,
                    TimeTaken = 40,
                    User = Users[3]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 95,
                    TimeTaken = 15,
                    User = Users[4]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 50,
                    TimeTaken = 22,
                    User = Users[4]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 65,
                    TimeTaken = 30,
                    User = Users[4]
                },
                new TestResult
                {
                    Test = Tests[5],
                    Result = 85,
                    TimeTaken = 30,
                    User = Users[4]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 70,
                    TimeTaken = 15,
                    User = Users[5]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 50,
                    TimeTaken = 30,
                    User = Users[5]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 65,
                    TimeTaken = 22,
                    User = Users[5]
                },
                new TestResult
                {
                    Test = Tests[3],
                    Result = 95,
                    TimeTaken = 30,
                    User = Users[5]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 85,
                    TimeTaken = 20,
                    User = Users[6]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 60,
                    TimeTaken = 17,
                    User = Users[6]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 85,
                    TimeTaken = 18,
                    User = Users[6]
                },
                new TestResult
                {
                    Test = Tests[2],
                    Result = 95,
                    TimeTaken = 15,
                    User = Users[6]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 60,
                    TimeTaken = 30,
                    User = Users[7]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 49,
                    TimeTaken = 30,
                    User = Users[7]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 49,
                    TimeTaken = 15,
                    User = Users[7]
                },
                new TestResult
                {
                    Test = Tests[1],
                    Result = 90,
                    TimeTaken = 22,
                    User = Users[7]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 49,
                    TimeTaken = 40,
                    User = Users[8]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 60,
                    TimeTaken = 40,
                    User = Users[8]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 49,
                    TimeTaken = 15,
                    User = Users[8]
                },
                new TestResult
                {
                    Test = Tests[5],
                    Result = 49,
                    TimeTaken = 22,
                    User = Users[8]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 85,
                    TimeTaken = 40,
                    User = Users[9]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 60,
                    TimeTaken = 40,
                    User = Users[9]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 90,
                    TimeTaken = 40,
                    User = Users[9]
                },
                new TestResult
                {
                    Test = Tests[3],
                    Result = 60,
                    TimeTaken = 15,
                    User = Users[9]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 60,
                    TimeTaken = 22,
                    User = Users[10]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 49,
                    TimeTaken = 40,
                    User = Users[10]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 60,
                    TimeTaken = 30,
                    User = Users[10]
                },
                new TestResult
                {
                    Test = Tests[0],
                    Result = 60,
                    TimeTaken = 22,
                    User = Users[10]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 78,
                    TimeTaken = 30,
                    User = Users[11]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 78,
                    TimeTaken = 15,
                    User = Users[11]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 49,
                    TimeTaken = 40,
                    User = Users[11]
                },
                new TestResult
                {
                    Test = Tests[1],
                    Result = 78,
                    TimeTaken = 30,
                    User = Users[11]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 78,
                    TimeTaken = 15,
                    User = Users[12]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 78,
                    TimeTaken = 30,
                    User = Users[12]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 80,
                    TimeTaken = 40,
                    User = Users[12]
                },
                new TestResult
                {
                    Test = Tests[2],
                    Result = 75,
                    TimeTaken = 15,
                    User = Users[12]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 49,
                    TimeTaken = 30,
                    User = Users[13]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 80,
                    TimeTaken = 30,
                    User = Users[13]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 70,
                    TimeTaken = 21,
                    User = Users[13]
                },
                new TestResult
                {
                    Test = Tests[2],
                    Result = 90,
                    TimeTaken = 23,
                    User = Users[13]
                },
                new TestResult
                {
                    Test = Tests[8],
                    Result = 60,
                    TimeTaken = 30,
                    User = Users[14]
                },
                new TestResult
                {
                    Test = Tests[7],
                    Result = 75,
                    TimeTaken = 25,
                    User = Users[14]
                },
                new TestResult
                {
                    Test = Tests[6],
                    Result = 55,
                    TimeTaken = 40,
                    User = Users[14]
                },
                new TestResult
                {
                    Test = Tests[1],
                    Result = 80,
                    TimeTaken = 10,
                    User = Users[14]
                }              
            };
        } 
    }
}
