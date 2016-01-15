using System;

namespace Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    internal class Manipulator
    {
        private int horigontalPosition = 0;
        private int verticalPosition = 0;

        public string GetState()
        {
            return string.Format("x:{0}, y:{1}", horigontalPosition, verticalPosition);
        }

        public void MoveHorisontal(int distance)
        {
            horigontalPosition += distance;
        }

        public void MoveVertical(int distance)
        {
            verticalPosition += distance;
        }
    }
}