using System;
using System.IO;
using System.Text;

namespace ModuleHW
{
    public class Subject : ISubject
    {
        private readonly string _name;

        public Subject(string name)
        {
            _name = name;
        }

        public event EventHandler OnSaved;

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter("temp.txt", false, Encoding.Default))
            {
                sw.WriteLine(_name);
            }

            OnSaved?.Invoke(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
