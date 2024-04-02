class Teacher : User{
    public Discipline DisciplineName { get; set;}

    public Teacher(string _firstName, string _middleName, string _lastName, int _age, Discipline _disciplineName) : base(_firstName, _middleName, _lastName, _age){
        DisciplineName = _disciplineName;
    }

    public override void GetInfo(){
        Console.WriteLine("----------------<Teacher InFo>----------------");
        Console.WriteLine($"ФИО: {LastName} {FirstName} {MiddleName}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Дисциплина: {DisciplineName.DisciplineName}");
        Console.WriteLine("----------------------------------------------");
    
    }

    public override void GetStatus(){
        Console.WriteLine($"Этот преподователь обучает {DisciplineName.DisciplineName}.");
    }
}