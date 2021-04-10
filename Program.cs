using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song woah = new Song("Woah","Koko", 175);
            Console.WriteLine(Song.songCount);
            Song hey = new Song("Hey", "Tony", 220);

            Console.WriteLine(hey.getSongCount());// static class attribute is about the CLASS, not the objects of the class.
        }
    }
}
