using System;
using System.Threading;

namespace SimpleEventDemo
{
    // Publisher class
    public class VideoEncoder
    {
        // Delegate
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        // Event based on that delegate
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Video = {video.Title}, Encoding Video...");
            Thread.Sleep(2000);
            Console.WriteLine($"Video = {video.Title}, Encoded Video...");

            OnVideoEncoded(video);
        }

        // Event raised
        protected virtual void OnVideoEncoded(Video video)
            => VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
    }
}
