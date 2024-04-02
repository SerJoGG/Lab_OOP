Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
//--------------------------------------------------------------------------------------------------
List<Discipline> LtDisciplines = new List<Discipline>(){
    new Discipline(1,"Программирование"),//0
    new Discipline(1,"Алхимия"),//1
    new Discipline(2,"Математика"),//2
    new Discipline(2,"Иностранный язык"),//3
    new Discipline(3,"Самооборона"),//4
    new Discipline(3,"ООП"),//5
    new Discipline(4,"Мемология")//6
};
List<Student> LtStudents = new List<Student>(){
    new Student("Артём", "Александрович", "Столяров", 22, 0854, LtDisciplines[0]),
    new Student("Александра", "Андреевна", "Новикова", 22, 6243, LtDisciplines[0]),
    new Student("Андрей", "Михайлович", "Кириллов", 22, 1968, LtDisciplines[1]),
    new Student("Тимофей", "Михайлович", "Соболев", 22, 1111, LtDisciplines[2]),
    new Student("Anrei", "Livovich", "Gribov", 22, 1234, LtDisciplines[3]),
    new Student("Кира", "Трошина", "Кирилловна", 22, 3623, LtDisciplines[3]),
    new Student("Дмитрий", "Константинов", "Данилович", 22, 4142, LtDisciplines[5])
};
List<Teacher> LtTeachers = new List<Teacher>(){
    new Teacher("Генри", "Гейтс", "Уильм", 44, LtDisciplines[0]),
    new Teacher("Раззил", "Артёмович", "Калугин", 34, LtDisciplines[1]),
    new Teacher("Варвара", "Сергеевна", "Ларионова", 42, LtDisciplines[2]),
    new Teacher("Фёдор", "Даниилович", "Черкасов", 26, LtDisciplines[3]),
    new Teacher("Эйкичи", "Япу", "Онидзука", 22, LtDisciplines[4]),
    new Teacher("Вадим", "Иванович", "Лебедев", 36, LtDisciplines[5]),
    new Teacher("Симон", "Александрович", "Кабанов", 69, LtDisciplines[6])
};
//--------------------------------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------

void PrintAllDiscipline () {
    Console.WriteLine("------------------------------");
	for(int i=0; i < LtDisciplines.Count; i++){
        Console.Write("№: "); Console.WriteLine(i + 1);
        Console.Write("Курс: "); Console.WriteLine(LtDisciplines[i].CourseNumber);
        Console.Write("Название дисциплины: "); Console.WriteLine(LtDisciplines[i].DisciplineName);
        Console.WriteLine("-----------------");
    }
    Console.WriteLine("------------------------------");
}

void PrintAllStudents () {
    Console.WriteLine("------------------------------");
	for(int i=0; i < LtStudents.Count; i++){
        LtStudents[i].GetInfo();
        Console.WriteLine("-----------------");
    }
    Console.WriteLine("------------------------------");
}

void PrintAllTeachers () {
    Console.WriteLine("------------------------------");
	for(int i=0; i < LtTeachers.Count; i++){
        LtTeachers[i].GetInfo();
        Console.WriteLine("-----------------");
    }
    Console.WriteLine("------------------------------");
}

//---------------------------------------------------------------------------------------------
bool exit = false;
while(exit == false){
    Console.WriteLine("---------------<List Menu>---------------");
    Console.WriteLine("1 - Создание дисциплины.");
    Console.WriteLine("2 - Добавить студента.");
    Console.WriteLine("3 - Добавить преподователя.");
    Console.WriteLine("4 - Выводы.");
    Console.WriteLine("5 - Поиск по ФИО.");
    Console.WriteLine("6 - Exit.");
    Console.WriteLine("---------------<List Menu>---------------");
    Console.Write("Выбирете действие: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1:
            Console.Write("Напишите на каком курсе будет дисциплина: "); int CreateDiscipline_NumberCourse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите название дисциплины: "); string CreateDiscipline_NameDiscipline = Console.ReadLine() ?? "null";
            if(CreateDiscipline_NumberCourse > 0 && CreateDiscipline_NumberCourse < 5){
                LtDisciplines.Add(new Discipline(CreateDiscipline_NumberCourse, CreateDiscipline_NameDiscipline));
            }
            else{
                Console.WriteLine("Приложение не может создать данную дисциплину, т.к. курс не соотвествует!");
                Console.ReadKey();
            }
            Console.WriteLine("Хотите вывести весь список дисциплин? Yes(1) or No(0)"); 
            int YN = Convert.ToInt32(Console.ReadLine()); //надо поправить
            if(YN == 1){
                PrintAllDiscipline();
            }
        break;
        case 2:
            Console.Write("Напишите Фамилию: "); string lastname = Console.ReadLine() ?? "null";
            Console.Write("Напишите Имя: "); string firstname = Console.ReadLine() ?? "null";
            Console.Write("Напишите Отчество: "); string middlename = Console.ReadLine() ?? "null";
            Console.Write("Напишите возраст: "); int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите ID: "); long id = Convert.ToInt32(Console.ReadLine());
            PrintAllDiscipline();
            Console.Write("Выберите дисциплину студента: "); int numS = Convert.ToInt32(Console.ReadLine()) - 1;
            LtStudents.Add(new Student(firstname, middlename, lastname, age, id, LtDisciplines[numS]));
        break;
        case 3:
            Console.Write("Напишите Фамилию: "); string lastname1 = Console.ReadLine() ?? "null";
            Console.Write("Напишите Имя: "); string firstname1 = Console.ReadLine() ?? "null";
            Console.Write("Напишите Отчество: "); string middlename1 = Console.ReadLine() ?? "null";
            Console.Write("Напишите возраст: "); int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("(1)Создать новую дисциплину для преподователя или (0)Выбрать уже существующую: "); int choice3 = Convert.ToInt32(Console.ReadLine());
            switch(choice3){
                case 1:
                    Console.Write("Напишите название дисциплины преподователя: "); string disciplineName = Console.ReadLine() ?? "null";
                    Console.Write("Напишите на каком курсе будет дисциплина: "); int courseNum = Convert.ToInt32(Console.ReadLine());
                    LtDisciplines.Add(new Discipline(courseNum, disciplineName));
                    LtTeachers.Add(new Teacher(firstname1, middlename1, lastname1, age1, LtDisciplines[LtDisciplines.Count - 1]));
                break;
                case 0:
                    PrintAllDiscipline();
                    Console.Write("Выберите дисциплину преподователя: "); int numT = Convert.ToInt32(Console.ReadLine()) - 1;
                    LtTeachers.Add(new Teacher(firstname1, middlename1, lastname1, age1, LtDisciplines[numT]));
                break;
                default:
                    Console.WriteLine("Вы не смогли выбрать!");
                break;
            }
        break;
        case 4:
            Console.WriteLine("1 - Вывод дисциплин");
            Console.WriteLine("2 - Вывод студентов");
            Console.WriteLine("3 - Вывод учителей");
           int choice4 = Convert.ToInt32(Console.ReadLine());
           switch (choice4)
           {
            case 1:
                PrintAllDiscipline();
                int num = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("---------------------");
                LtDisciplines[num].GetInfo(LtDisciplines, LtTeachers, LtStudents, num);
                Console.WriteLine("---------------------");
            break;
            case 2:
                PrintAllStudents(); 
            break;
            case 3:
                PrintAllTeachers();
            break;
            default:
            break;
           }
        break;
        case 5:
            Console.Write("Введите ФИО: "); 
            string str = Console.ReadLine() ?? "null";
            for(int i=0; i < LtStudents.Count; i++){
                if(LtStudents[i].FirstName == str || LtStudents[i].MiddleName == str || LtStudents[i].LastName == str || Convert.ToString(LtStudents[i].LastName + " " +LtStudents[i].FirstName) == str || Convert.ToString(LtStudents[i].LastName + " " + LtStudents[i].FirstName + " " + LtStudents[i].MiddleName) == str){
                    Console.WriteLine($"{LtStudents[i].LastName} {LtStudents[i].FirstName} {LtStudents[i].MiddleName} - студент");
                    LtStudents[i].GetStatus();
                }
            }
             for(int i=0; i < LtTeachers.Count; i++){
                if(LtTeachers[i].FirstName == str || LtTeachers[i].MiddleName == str || LtTeachers[i].LastName == str || Convert.ToString(LtTeachers[i].LastName + " " + LtTeachers[i].FirstName) == str || Convert.ToString(LtTeachers[i].LastName + " " + LtTeachers[i].FirstName + " " + LtTeachers[i].MiddleName) == str){
                    Console.WriteLine($"{LtTeachers[i].LastName} {LtTeachers[i].FirstName} {LtTeachers[i].MiddleName} - Препод");
                    LtTeachers[i].GetStatus();
                }
            }
        break;
        case 6:
            Console.WriteLine("Консольное приложение закрыто!");
            exit = true;
            Console.ReadKey();
        break;
        default:
        Console.WriteLine("default");
        break;
    }

    //LtStudents[2].GetInfo();
    //LtTeachers[1].GetInfo();
    //LtStudents[2].GetStatus();
    //LtTeachers[1].GetStatus();

}
