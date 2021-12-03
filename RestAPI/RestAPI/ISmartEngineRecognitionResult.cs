using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI
{
    public interface ISmartEngineRecognitionResult
    {
        public ISmartEngineRecognitionField[] Fields { get; }
    }
    
}
