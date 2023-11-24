namespace C2208I1_OOP;
internal class Student
{
    // Properties: C# có cách viết riêng - không dùng getter & setter, khác với Java
    // Style cũ thường dùng cho Mobile (do Java cũ)
    #region style code cũ
    //// Các field
    //int? id;
    //string? fullname;
    //bool? gender;
    //DateTime? dob;

    //public int? Id { get => id; set => id = value; }
    //public string? Fullname { get => fullname; set => fullname = value; }
    //public bool? Gender { get => gender; set => gender = value; }
    //public DateTime? Dob { get => dob; set => dob = value; }
    #endregion

    #region style code mới
    // Vừa là field vừa là auto property
    public int? Id { get; set; }
    public string? Fullname { get; set; }
    public bool? Gender { get; set; }
    public DateTime? Dob { get; set; }
    #endregion

    //public Student() { }
    //public Student(int? id, string? fullname, bool? gender, DateTime? dob)
    //{
    //    Id = id;
    //    Fullname = fullname;
    //    Gender = gender;
    //    Dob = dob;
    //}

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
    }
}
