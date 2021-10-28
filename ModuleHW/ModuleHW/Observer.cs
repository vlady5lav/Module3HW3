using System;

namespace ModuleHW
{
    public class Observer : IObserver
    {
        private readonly string _title;

        public Observer(string title, Subject subject)
        {
            _title = title;
            subject.OnSaved += SubjectOnSaved;
        }

        public override string ToString()
        {
            return _title;
        }

        private void SubjectOnSaved(object obj, EventArgs e)
        {
            string format = "dd.MM.yyyy hh:mm:ss";
            Console.WriteLine($"[{DateTime.Now.ToString(format)}] Observer \"{this}\": Object \"{obj}\" saved");
        }
    }
}
