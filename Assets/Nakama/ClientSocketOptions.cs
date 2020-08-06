namespace Nakama
{
    public class ClientSocketOptions
    {
        public int KeepAliveIntervalSec { get; set; }
        public int SendTimeoutSec { get; set; }
        public int MaxMessageSizeBytes { get; set; }

        public ClientSocketOptions(int keepAliveIntervalSecs, int sendTimeoutSec, int maxMessageSizeBytes)
        {
            KeepAliveIntervalSec = keepAliveIntervalSecs;
            SendTimeoutSec = sendTimeoutSec;
            MaxMessageSizeBytes = maxMessageSizeBytes;
        }
    }
}