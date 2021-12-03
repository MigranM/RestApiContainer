using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI
{
    public sealed class SmartEngineRecognitionResultDTO : ISmartEngineRecognitionResult
    {
        private RecognitionFieldDTO[] _fields;
        public ISmartEngineRecognitionField[] Fields { get => _fields; }

        public SmartEngineRecognitionResultDTO(RecognitionFieldDTO[] field)
        {
            _fields = field;
        }

        

    }
    public class RecognitionFieldDTO : ISmartEngineRecognitionField
    {
        private string _name;
        private string _value;
        private double _confidence;
        private bool _acceptance;

        public string Name { get => _name; }
        public string Value { get => _value; }
        public double Confidence { get => _confidence; }
        public bool Acceptance { get => _acceptance; }

        public RecognitionFieldDTO(string name, string value, double confidence, bool acceptance)
        {
            _name = name;
            _value = value;
            _confidence = confidence;
            _acceptance = acceptance;
        }
    }
}
