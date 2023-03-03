namespace DssHRI.Application.Constants
{
    /// <summary>
    /// Represents the list of topics in Kafka
    /// </summary>
    public static class KafkaTopics
    {       
        public static string AddDocumentRequest => "AddDocumentRequest";
        public static string AddDocumentResponse => "AddDocumentResponse";
        public static string AddDocumentErrorResponse => "AddDocumentErrorResponse";
        public static string AddDocumentSuccessful => "AddDocumentSuccessful";
        public static string BlobCompletedEvent => "BlobCompletedEvent";
        public static string BlobUploadCompletedEvent => "BlobUploadCompletedEvent";
        public static string BlobErrorTimeOutEvent => "BlobErrorTimeOutEvent";
        public static string AddDocumentUnsuccessful => "AddDocumentUnsuccessful";

    }
}
