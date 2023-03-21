using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_A
{
    class Experiment
    {
        //Constructor
        public Experiment ()
        {
            StudentName = "";
            ExperimentNumber =0;
            ExperimentDescription = "";
            Weight = 0;
            Volume = 0;
            Color = "";
        }

        //student name property
        public string StudentName { get; set; }

        //description property
        public string ExperimentDescription { get; set; }

        //experiment number property
        public int ExperimentNumber { get; set; }

        //experiment weight property
        public double Weight { get; set; }

        //volume property
        public double Volume { get; set; }

        //color property
        public string Color { get; set; }

    }
}
