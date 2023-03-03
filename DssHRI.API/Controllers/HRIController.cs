using Confluent.Kafka;
using DssHRI.application.Interfaces;
using DssHRI.Application.Constants;
using DssHRI.Domain.Models.MRM;
using DssHRI.Domain.MRM;
using Kafka.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DssHRI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HRIController : ControllerBase
    {
        private readonly IKafkaProducer<string, AddDocument> _kafkaAddDocProducer;
        private readonly IKafkaProducer<string, SASUrlResponse> _kafkaMRMResponseProducer;    
        private readonly ILogger<HRIController> _logger;        
        public HRIController(
            IKafkaProducer<string, AddDocument> kafkaAddDocProducer,
            IKafkaProducer<string, SASUrlResponse> kafkaMRMResponseProducer,           
            ILogger<HRIController> logger          
            )
        {
            _kafkaAddDocProducer = kafkaAddDocProducer;
            _kafkaMRMResponseProducer = kafkaMRMResponseProducer;           
            _logger = logger;           
        }

        [HttpPost]
        [Route("AddDocument")]       
        public async Task<IActionResult> AddDocument(AddDocument addDocument)
        {
            try
            {
                addDocument.CorrelationId = Guid.NewGuid();
                var topicPart = new TopicPartition(KafkaTopics.AddDocumentRequest, new Partition(1));
                await _kafkaAddDocProducer.ProduceAsync(topicPart, null, addDocument);

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }                    
        }

    }
}
