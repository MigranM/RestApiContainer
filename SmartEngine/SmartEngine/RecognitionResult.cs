using System;

namespace SmartEngine
{
    public class RecognitionResult
    {
        private RecognitionField[] _fields;

        public RecognitionField[] Fields { get => _fields; }

        public RecognitionResult(RecognitionField[] field)
        {
            _fields = field;
        }

        //stub object
        public static RecognitionResult CreateResult()
        {

            RecognitionField[] fields = new RecognitionField[]
            {
                new RecognitionField("First Name","Ivan",0.995648D,true),
                new RecognitionField("Second Name","Ivanov",0.97986D,true),
                new RecognitionField("Last Name","Ivanovich",0.89856D,true),
                new RecognitionField("First Name","Ivan",0.999658D,true),
                new RecognitionField("Birch Date","01.01.2000",0.999658D,true)
            };
            RecognitionResult result = new RecognitionResult(fields);

            return result;
        }
    }

}
