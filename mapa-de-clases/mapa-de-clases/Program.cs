
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        var member1 = new communitymember
        {
            id = 1,
            name = "Mario",
            age = 19
        };
        var employee1 = new employee
        {
            id = 2,
            name = "Juanita",
            age = 27,
            employee_card = "JN123"
        };
        var student1 = new student
        {
            id = 3,
            name = "Miguel",
            age = 19,
            list_number = "MG123"
        };
        var exstudent1 = new exstudent
        {
            id = 4,
            name = "Juan",
            age = 23,
            list_number = "JN123"
        };
        var teacher1 = new teacher
        {
            id = 5,
            name = "Pablo",
            age = 35,
            employee_card = "J456",
            subject = "Matematica"
        };
        var administrative1 = new administrative
        {
            id = 6,
            name = "Jose Manuel",
            age = 32,
            employee_card = "JM123",
            registration = "J456"
        };
        var administrator1 = new administrator
        {
            id = 7,
            name = "Jimmy",
            age = 33,
            employee_card = "JMY123",
            registration = "JM456",
            subject = "Matematica"
        };
        var master1 = new master
        {
            id = 8,
            name = "Camila",
            age = 40,
            employee_card = "CM123",
            registration = "C456",
            subject = "Matematica"
        };

        Console.WriteLine($"Member: {member1.name}, Age: {member1.age}, Id: {member1.id}");
        Console.WriteLine($"Employee: {employee1.name}, Age: {employee1.age}, Employee Card: {employee1.employee_card}");
        Console.WriteLine($"Student: {student1.name}, Age: {student1.age}, List Number: {student1.list_number}");
        Console.WriteLine($"Exstudent: {exstudent1.name}, Age: {exstudent1.age}, List Number: {exstudent1.list_number}");
        Console.WriteLine($"Teacher: {teacher1.name}, Age: {teacher1.age}, Id: {teacher1.id}), Subject: {teacher1.subject}, Employee Card: {teacher1.employee_card}");
        Console.WriteLine($"Administrative: {administrative1.name}, Age: {administrative1.age}, Registration: {administrative1.registration}, Employee Card: {administrative1.employee_card}");
        Console.WriteLine($"Administrator: {administrator1.name}, Age: {administrator1.age}, Subject: {administrator1.subject}, Employee Card: {administrator1.employee_card}, Registration: {administrator1.registration}");
        Console.WriteLine($"Master: {master1.name}, Age: {master1.age}, Subject: {master1.subject}, Employee Card: {master1.employee_card}, Registration: {master1.registration}");

        Console.ReadKey();
    }
}