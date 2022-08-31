using FourPillarsOOP;
using FourPillarsOOP.Abstraction;
using FourPillarsOOP.Encapsulation;
using FourPillarsOOP.Inheritance;
using FourPillarsOOP.Polymorphism;

#region Encapsulation

BankAccount account = new BankAccount("Luigi Ricciato", 1234);
account.MakeDeposit(10_000);
decimal balance = account.GetBalance();
account.MakeWithdrawal(8_000);
balance = account.GetBalance();

#endregion

#region Abstraction

CoffeeMachine machine = new CoffeeMachine();
machine.RefillCoffee(1000);
machine.RefillWater(1000);

Coffee coffee = machine.BrewCoffee(CoffeeSelection.Espresso);
Console.WriteLine(coffee.GetType());

#endregion

#region Inheritance

Student s = new Student(1234, "Sasha", "Lupo", new DateTime(1991, 10, 31));
Teacher t = new Teacher("Luigi", "Ricciato", new DateTime(1982, 1, 18));
t.Disciplines = new List<string>{ "C#", "Git" };
int differenceOfAge = t.Age - s.Age;
Console.WriteLine(differenceOfAge);

Person p1 = s;
Person p2 = t;
// s = t; error

#endregion

#region Polymorphism

Shape shape1 = new Rectangle(10, 20);
Shape shape2 = new Circle(1);

Console.WriteLine($"Area of {shape1.GetType().Name}: {shape1.GetArea().ToString("0.00")}");
Console.WriteLine($"Area of {shape2.GetType().Name}: {shape2.GetArea().ToString("0.00")}");

#endregion

Console.ReadKey();
