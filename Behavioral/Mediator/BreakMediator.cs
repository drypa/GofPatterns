using System;

namespace Mediator
{
    public class BreakMediator
    {
        private readonly Alarmer alarmer;
        private readonly BreakCalculator calculator;

        public BreakMediator(Alarmer alarmer, BreakCalculator calculator)
        {
            this.alarmer = alarmer;
            this.calculator = calculator;

            this.calculator.ItIsTimeToBrake += (sender, args) => this.alarmer.Alarm();
        }
    }
}
