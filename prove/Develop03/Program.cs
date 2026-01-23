using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Moses", 1, 39);
        Reference reference2 = new Reference("Moses", 7, 18);
        Reference reference3 = new Reference("Abraham", 2, 9, 11);
        Reference reference4 = new Reference("Abraham", 3, 22, 23);
        Reference reference5 = new Reference("Genesis", 1, 26, 27);
        Reference reference6 = new Reference("Genesis", 2, 24);
        Reference reference7 = new Reference("Genesis", 39, 9);
        Reference reference8 = new Reference("Exodus", 20, 3, 17);
        Reference reference9 = new Reference("Joshua", 24, 15);
        Reference reference10 = new Reference("Psalm", 24, 3, 4);
        Reference reference11 = new Reference("Proverbs", 3, 5, 6);
        Reference reference12 = new Reference("Isaiah", 1, 18);

        List<Reference> referenceLibrary =
        [
            reference1,
            reference2,
            reference3,
            reference4,
            reference5,
            reference6,
            reference7,
            reference8,
            reference9,
            reference10,
            reference11,
            reference12,
        ];

        string text1 ="“This is my work and my glory—to bring to pass the immortality and eternal life of man.”";
        string text2 ="“The Lord called his people Zion, because they were of one heart and one mind.”";
        string text3 ="The Lord promised Abraham that his seed would “bear this ministry and Priesthood unto all nations.”";
        string text4 ="As spirits we “were organized before the world was.”";
        string text5 ="“God created man in his own image.”";
        string text6 ="“A man … shall cleave unto his wife: and they shall be one.”";
        string text7 ="“How then can I do this great wickedness, and sin against God?”";
        string text8 ="The Ten Commandments";
        string text9 ="“Choose you this day whom ye will serve.”";
        string text10 ="“Who shall stand in his holy place? He that hath clean hands, and a pure heart.”";
        string text11 ="“Trust in the Lord with all thine heart … and he shall direct thy paths.”";
        string text12 ="“Trust in the Lord with all thine heart … and he shall direct thy paths.”";

        List<string> textLibrary =
        [
            text1, 
            text2, 
            text3, 
            text4, 
            text5, 
            text6, 
            text7, 
            text8, 
            text9, 
            text10,
            text11,
            text12,
        ];
    
        Random random = new Random();
        int index = random.Next(0,12);

        Reference reference = referenceLibrary[index];
        string text = textLibrary[index];
        Scripture scripture = new Scripture(reference, text);

        string input = "";
        while(input.ToLowerInvariant() != "quit")
        {
            Console.Clear();
            scripture.DisplayText();
            if (scripture.IsCompleteHidden())
            {
                break;
            }

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            scripture.HideRandomWords(3);
        }
    }
}