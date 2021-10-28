using System;

namespace ModuleHW
{
    public class Starter
    {
        public void Run()
        {
            var subject = new Subject("ConcreteSubject");
            _ = new Observer("ConcreteObserver", subject);

            subject.Save();

            Console.ReadLine();
        }
    }
}
