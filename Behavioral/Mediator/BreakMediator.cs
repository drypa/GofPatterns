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

            
        }

        public void Start()
        {
            calculator.ItIsTimeToBrake += OnItIsTimeToBrake;
        }

        private void OnItIsTimeToBrake(object sender, EventArgs e)
        {
            alarmer.Alarm();
        }
    }
}
