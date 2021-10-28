using System;

namespace ModuleHW
{
    public interface ISubject
    {
        event EventHandler OnSaved;

        void Save();
        string ToString();
    }
}