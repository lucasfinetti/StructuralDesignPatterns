using StructuralDesignPatterns.Composite.Domain;
using StructuralDesignPatterns.Composite.Domain.Interface;
using System;

namespace StructuralDesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IObject mainFoldeer = new Folder("Files");
            IObject folder1 = new Folder("Images");
            IObject folder2 = new Folder("Office");

            mainFoldeer.Add(folder1);
            mainFoldeer.Add(folder2);

            folder1.Add(new File("Beach.png"));
            folder1.Add(new File("Naruto.jpeg"));
            folder1.Add(new File("Sasuke.png"));

            folder2.Add(new File("ProjectX.docx"));
            folder2.Add(new File("Document1.pdf"));
            folder2.Add(new File("Document2.pdf"));

            Console.WriteLine(mainFoldeer);

            Console.ReadKey();
        }
    }
}
