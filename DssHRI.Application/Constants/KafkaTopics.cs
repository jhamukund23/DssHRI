namespace DssHRI.Application.Constants
{
    /// <summary>
    /// Represents the list of topics in Kafka
    /// </summary>
    public static class KafkaTopics
    {    
        public static string SendNewFileToIDM => "SendNewFileToIDM";
        public static string SASUrlResponse => "SASUrlResponse";
        public static string BlobUploadCompletedEvent => "BlobUploadCompletedEvent";

        public static string AddDocumentRequest => "AddDocumentRequest";
        public static string AddDocumentResponse => "AddDocumentResponse";
    }
}
