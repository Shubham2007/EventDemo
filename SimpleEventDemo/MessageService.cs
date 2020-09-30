using System;

namespace SimpleEventDemo
{
    // Another publisher of video encoder
    public class MessageService
    {
        public MessageService(VideoEncoder encoder)
        {
            encoder.VideoEncoded += OnVideoEncoded;
        }
        public void OnVideoEncoded(object o, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Video = {e.Video.Title}, Sending Message...");
        }
    }
}
