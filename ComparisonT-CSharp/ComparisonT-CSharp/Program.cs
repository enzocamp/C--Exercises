using System;
using System.Collections.Generic;
using ComparisonT_CSharp.Entities;

namespace ComparisonT_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //Lambda expression to delegate variable

            list.Sort(comp);

            Console.WriteLine(Thread.CurrentThread.CurrentCulture.);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}

/*
 *  static void Main(string[] args) // Aqui na Classe Product tbm nao necessita implementar IComparable
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = CompareProducts; //Method reference to delegate variable

            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
 */

//Metodo Sort com Funcao no parametro
/*
class Program
{
    static void Main(string[] args)
    {

        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        list.Sort();
        list.Sort(CompareProducts);

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }

        static int CompareProducts(Product p1, Product p2) {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}*/

//Metodo 1 
/*
class Program // para isso rodar, na Classe Product deve implementar o IComparable
{
    static void Main(string[] args)
    {

        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        list.Sort();

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }
}
}*/