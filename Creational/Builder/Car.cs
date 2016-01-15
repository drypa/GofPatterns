using System;

namespace Builder
{
    internal class Car
    {
        public bool BackBumper { get; set; }
        public bool Carcase { get; set; }
        public bool Electric { get; set; }
        public bool EngineExists { get; set; }
        public bool FrontBumper { get; set; }
        public int WheelsCount { get; set; }

        public override string ToString()
        {
            return string.Format("Car: {0}; {1} wheels; {2}; {3}; {4}; {5}", EngineStr(), WheelsCount, CarcaseStr(), FrontBumperStr(), BackBumperStr(), ElectricStr());
        }

        private string BackBumperStr()
        {
            return BackBumper ? "BackBumper exists" : "No BackBumper";
        }

        private string CarcaseStr()
        {
            return Carcase ? "Carcase exists" : "No Carcase";
        }

        private string ElectricStr()
        {
            return Electric ? "Electric exists" : "No Electric";
        }

        private string EngineStr()
        {
            return EngineExists ? "Engine exists" : "No engine";
        }

        private string FrontBumperStr()
        {
            return FrontBumper ? "FrontBumper exists" : "No FrontBumper";
        }
    }
}