using System;
namespace ConsoleApp34
{
    class Program
    {
        public static void Main(string[] args)
        {
            WordAdding wordAdding = new("Irada");
            wordAdding.AddWord();
        }

        class WordAdding
        {
            public string Word { get; set; }
            public WordAdding(string word)
            {
                this.Word = word;
            }

            public void AddWord()
            {
                Console.WriteLine($"Hello, {Word}, how are you doing");
            }

        }
    }
}