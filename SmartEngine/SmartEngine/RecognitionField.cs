using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEngine
{
    //next step
    /*internal record RecognitionField
    {
        
    }*/
    public class RecognitionField
    {
        private string _name;
        private string _value;
        private double _confidence;
        private bool _acceptance;

        public string Name { get => _name; }
        public string Value { get => _value; }
        public double Confidence { get => _confidence; }
        public bool Acceptance { get => _acceptance; }

        public RecognitionField(string name, string value, double confidence, bool acceptance)
        {
            _name = name;
            _value = value;
            _confidence = confidence;
            _acceptance = acceptance;
        }
    }
}
