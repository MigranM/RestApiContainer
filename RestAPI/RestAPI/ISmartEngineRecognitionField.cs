using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI
{
    public interface ISmartEngineRecognitionField
    {
        public string Name { get; }
        public string Value { get; }
        public double Confidence { get; }
        public bool Acceptance { get; }
    }
}
