class Student : User{

    public long ID { get; set; }
    public Discipline DisciplineName { get; set;}


    public Student(string _firstName, string _middleName, string _lastName, int _age, long _id, Discipline _disciplineName) : base(_firstName, _middleName, _lastName, _age){
        ID = _id;
        DisciplineName = _disciplineName;
    }
    public override void GetInfo(){
        Console.WriteLine("----------------<Student InFo>----------------");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"ФИО: {LastName} {FirstName} {MiddleName}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Курс: {DisciplineName.CourseNumber}");
        Console.WriteLine($"Дисциплина: {DisciplineName.DisciplineName}");
        Console.WriteLine("----------------------------------------------");
    }
    public override void GetStatus(){
        Console.WriteLine($"Это студент.");
    }
}