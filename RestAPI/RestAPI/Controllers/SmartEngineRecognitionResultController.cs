using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace RestAPI.Controllers
{
    public class SmartEngineRecognitionResultController : Controller
    {
        [HttpGet("recognizeFromBase64Image")]
        public SmartEngineRecognitionResultDTO GetRecognitionResult([FromBody] string base64Image)
        {
            SmartEngine.RecognitionResult resultFromLibrary = SmartEngine.RecognitionResult.CreateResult();
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<SmartEngine.RecognitionField, RecognitionFieldDTO>());

            var mapper = new Mapper(mapperConfig);
            List<RecognitionFieldDTO> fieldsDTO = new List<RecognitionFieldDTO>();
            foreach(var field in resultFromLibrary.Fields)
            {
                var fieldFromLibrary = mapper.Map<RecognitionFieldDTO>(field);
                fieldsDTO.Add(fieldFromLibrary);
            }
            SmartEngineRecognitionResultDTO result = new SmartEngineRecognitionResultDTO(fieldsDTO.ToArray());

            return result;
        }

        [HttpGet("ping")]
        public string Ping()
        {
            return "Pong " + DateTime.UtcNow.AddHours(3).ToLongTimeString();
        }
    }
}
