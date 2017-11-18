using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    class Program
    {
        static void Main(string[] args)
        {
            var pencilRepository = new PencilRepository(3);

            var pencil = new Pencil 
            { PencilId = 1, 
              Brand = "Bic", 
              Price = 3.32m 
            };

            
            pencilRepository.Add(pencil);
            pencilRepository.Print(pencil);
            Console.WriteLine(pencilRepository.Count);
            pencilRepository.Add(new Pencil { PencilId = 2, Brand = "Olimp", Price = 1.23m });
            pencilRepository.Print(pencilRepository[1]);
            pencilRepository.Add(new Pencil { PencilId = 3, Brand = "Перо", Price = 88.23m });           
            pencilRepository.Print(pencilRepository[2]);
            pencilRepository.Add(new Pencil { PencilId = 4, Brand = "Volt", Price = 8.2m });
            Console.WriteLine(pencilRepository.Count);
            pencilRepository.Delete(1);
            pencilRepository.Add(new Pencil { PencilId = 4, Brand = "Volt", Price = 8.2m });
            pencilRepository.Print(pencilRepository[2]);
            Console.WriteLine(pencilRepository.Count);
            Console.WriteLine(pencilRepository.Get(1));
            Console.ReadLine();       
        }
    }
}
