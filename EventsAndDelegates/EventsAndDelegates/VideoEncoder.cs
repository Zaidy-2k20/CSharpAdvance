using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an envent based on that delegate
        // 3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, EventArgs e);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        // instead of creating our own delegate, we can make use of in buid delegate i.e EventHandler or EventHandler<>
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null) 
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}
