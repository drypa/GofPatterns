using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    internal class RemoteController
    {
        private readonly Manipulator manipulator;
        private readonly Stack<ManipulatorCommand> commands = new Stack<ManipulatorCommand>();

        public RemoteController(Manipulator manipulator)
        {
            this.manipulator = manipulator;
        }

        public void Up(int distance)
        {
            var command = new UpManipulatorCommand(distance);
            ExecuteCommand(command);
        }
        public void Down(int distance)
        {
            var command = new DownManipulatorCommand(distance);
            ExecuteCommand(command);
        }
        public void Left(int distance)
        {
            var command = new LeftManipulatorCommand(distance);
            ExecuteCommand(command);
        }
        public void Right(int distance)
        {
            var command = new RightManipulatorCommand(distance);
            ExecuteCommand(command);
        }

        public void UndoLastCommand()
        {
            commands.Pop().Undo(manipulator);
        }

        private void ExecuteCommand(ManipulatorCommand command)
        {
            command.Do(manipulator);
            commands.Push(command);
        }
    }
}