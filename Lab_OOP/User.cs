abstract class User{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public User(string _firstName, string _middleName, string _lastName, int _age){
        FirstName = _firstName;
        MiddleName = _middleName;
        LastName = _lastName;
        Age = _age;
    }
     public virtual void GetInfo(){
        Console.WriteLine($"ФИО: {LastName} {FirstName} {MiddleName}");
        Console.WriteLine($"Возраст: {Age}");
    }

    public abstract void GetStatus();
}