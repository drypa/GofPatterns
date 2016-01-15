using System;

namespace Command
{
    internal abstract class ManipulatorCommand
    {
        protected int Distance { get; set; }
        public abstract void Do(Manipulator manipulator);
        public abstract void Undo(Manipulator manipulator);
    }
}