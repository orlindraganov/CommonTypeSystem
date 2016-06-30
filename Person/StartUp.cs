namespace Person
{
    using System;

    using Models;

    class StartUp
    {
        static void Main()
        {
            var theAuthor = new Person("Author Of Code", 30);
            var malkoKote = new Person("Malko Kote");

            Console.WriteLine(theAuthor);
            Console.WriteLine(malkoKote);
        }
    }
}
