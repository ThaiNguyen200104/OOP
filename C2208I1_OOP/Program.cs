using C2208I1_OOP;

#region code cũ
//// Object by constructor (dựa vào constructor)
//Student stu = new Student(1, "Nguyen", true, new DateTime(2004, 01, 20));
//Student stu1 = new(2, "Le", true, new DateTime(2004, 01, 20));
#endregion

#region code mới
// Object initializer (không cần contructor)
Student stu3 = new()
{
    Id = 3,
    Fullname = "Quang",
    Gender = true,
    Dob = DateTime.Now
};
#endregion



