using System;

namespace SimpleEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video { Title = "Avengers" };
            Video video2 = new Video { Title = "Memento" };

            VideoEncoder encoder = new VideoEncoder(); // publisher

            _ = new MailService(encoder); // subscriber
            _ = new MessageService(encoder); // subscriber

            // Anonymously subscribing for logging
            encoder.VideoEncoded += (o, ea) =>
            {
                Console.WriteLine($"LoggingService: Video = {ea.Video.Title}, Logging in file n DB");
            };

            encoder.Encode(video1);
            encoder.Encode(video2);

            Console.ReadKey();
        }
    }
}
