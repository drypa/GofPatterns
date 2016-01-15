using System;

namespace Command
{
    internal class UpManipulatorCommand : ManipulatorCommand
    {
        public UpManipulatorCommand(int distance)
        {
            Distance = distance;
        }

        public override void Do(Manipulator manipulator)
        {
            manipulator.MoveVertical(Distance);
        }

        public override void Undo(Manipulator manipulator)
        {
            manipulator.MoveVertical(-Distance);
        }
    }
}