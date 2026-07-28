using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MesssageService: Sending a text message..." + args.Video.Title);
        }
    }
}
