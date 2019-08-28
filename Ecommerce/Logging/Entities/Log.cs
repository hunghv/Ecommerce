namespace Logging.Entities
{
    public class Logs : Entity
    {
        public string Message { get; set; }
        public LogMessageType MessageType { get; set; }
        public string Exception { get; set; }
        public string MachineName { get; set; }
        public string Ip { get; set; }
    }
}
