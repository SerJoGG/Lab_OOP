class Discipline : Course{
    public string DisciplineName { get; set;}
    public Discipline(int _courseNumber, string _disciplineName) : base(_courseNumber){
        DisciplineName = _disciplineName;
    }

    public void GetInfo(List<Discipline> LtDisciplines, List<Teacher> LtTeachers, List<Student> LtStudents, int num){
        Console.Write("Курс: "); Console.WriteLine(CourseNumber);
        Console.Write("Название дисциплины: "); Console.WriteLine(DisciplineName);
        for(int i=0; i < LtTeachers.Count; i++){
            if(LtDisciplines[num] == LtTeachers[i].DisciplineName){
                Console.WriteLine($"Преподователь: {LtTeachers[i].LastName} {LtTeachers[i].FirstName} {LtTeachers[i].MiddleName}");
            }
        }
        int count = 0;
        for(int i=0; i < LtStudents.Count; i++){
            if(LtDisciplines[num] == LtStudents[i].DisciplineName){
                count++;
            }
        }
        Console.WriteLine($"Кол-во учащихся: {count}");
    }
}