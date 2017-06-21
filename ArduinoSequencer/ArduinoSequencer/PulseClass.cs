using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSequencer
{
    public class PulseClass
    {
        public int pin       { get; set; }
        public bool output   { get; set; } //High or Low
        public int duration  { get; set; }

        public PulseClass(int p_pin, bool p_output, int p_duration)
        {
            pin = p_pin;
            output = p_output;
            duration = p_duration;

        }

        public string PulseToCode()
        {
            string result = "digitalWrite(" + pin + "," + (output ? "HIGH" : "LOW") + ");\n";
            //result += "delay(" + duration + ");\n";
            //result += "digitalWrite(" + pin + "," + (!output ? "HIGH" : "LOW") + ");\n";
            return result;
        }

    }
}
