using System;

namespace Command
{
    internal class DownManipulatorCommand : ManipulatorCommand
    {
        public DownManipulatorCommand(int distance)
        {
            Distance = distance;
        }

        public override void Do(Manipulator manipulator)
        {
            manipulator.MoveVertical(-Distance);
        }

        public override void Undo(Manipulator manipulator)
        {
            manipulator.MoveVertical(Distance);
        }
    }
}