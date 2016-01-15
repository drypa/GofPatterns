using System;

namespace Command
{
    internal class RightManipulatorCommand : ManipulatorCommand
    {
        public RightManipulatorCommand(int distance)
        {
            Distance = distance;
        }

        public override void Do(Manipulator manipulator)
        {
            manipulator.MoveHorisontal(Distance);
        }

        public override void Undo(Manipulator manipulator)
        {
            manipulator.MoveHorisontal(-Distance);
        }
    }
}