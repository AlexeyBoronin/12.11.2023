using ConsoleApp50;

using(ApplicationContext db=new ApplicationContext())
{
    Human ted = new Human { Name = "Ted", Age = 33 };
    Human jane = new Human { Name = "Jane", Age = 25 };

    db.Humans.Add(ted);
    db.Humans.Add(jane);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    var humans= db.Humans.ToList();
    Console.WriteLine("Список объектов:");
    foreach(Human h in humans)
     Console.WriteLine($"{h.Id}.{h.Name} - {h.Age}");
}
using (ApplicationContext db=new ApplicationContext())
{
    Human? human=db.Humans.FirstOrDefault();
    if(human!=null)
    {
        human.Name = "Bred";
        human.Age = 25;
        db.SaveChanges() ;
    }
    var humans = db.Humans.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Human h in humans)
        Console.WriteLine($"{h.Id}.{h.Name} - {h.Age}");
}
using(ApplicationContext db=new ApplicationContext())
{
    Human? human = db.Humans.FirstOrDefault();
    if(human!=null)
    {
        db.Humans.Remove(human);
        db.SaveChanges();
    }
    var humans = db.Humans.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Human h in humans)
        Console.WriteLine($"{h.Id}.{h.Name} - {h.Age}");
}