using System;

namespace SimpleEventDemo
{
    // Publisher of video encoder
    public class MailService
    {
        public MailService(VideoEncoder encoder)
        {
            encoder.VideoEncoded += OnVideoEncoded;
        }
        public void OnVideoEncoded(object o, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Video = {e.Video.Title}, Sending Email...");
        }
    }
}
