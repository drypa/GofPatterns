using System;
using System.Timers;

namespace Mediator
{
    public class BreakCalculator : IDisposable
    {
        private readonly Timer timer;

        public BreakCalculator(int brakeIntervalInSeconds)
        {
            timer = new Timer { Interval = brakeIntervalInSeconds * 1000 };
            timer.Elapsed += (sender, args) => OnItIsTimeToBrake();
            timer.Start();
        }

        public event EventHandler ItIsTimeToBrake;

        public void Dispose()
        {
            timer.Stop();
        }

        private void OnItIsTimeToBrake()
        {
            EventHandler handler = ItIsTimeToBrake;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
