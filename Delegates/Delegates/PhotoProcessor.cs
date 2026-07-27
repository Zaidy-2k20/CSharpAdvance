using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // Custom Delegate that points to a method that return void and take Photo as a parameter.
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }


        // Using Action<> delegate (its build-in)
        public void Process2(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
