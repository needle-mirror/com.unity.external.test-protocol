namespace Unity.TestProtocol.Messages
{
    public static class ArtifactPublishMessage
    {
        public static readonly string MessageType = Message.GetDefaultMessageTypeValue(typeof(ArtifactPublishMessage));

        public static Message Create(string desination, bool allowOverwrite = false)
        {
            var result = new Message(MessageType);
            result["destination"] = desination;
            result["allowOverwrite"] = allowOverwrite;
            return result;
        }
    }
}
