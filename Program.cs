using Shopping_spree.Modules;
using System;
using System.Collections.Generic;


namespace Shopping_spree
{
    public class OverflowException : ArithmeticException { }
    class Program
    { 


        static void Main(string[] args)
        {Dictionary<string,Person>chowek = new Dictionary<string, Person>();
            Dictionary<string,Product> product = new Dictionary<string, Product>();
            List<string> dumi = new List<string>();

            

            string pplinfo = Console.ReadLine();

            string[] red = pplinfo.Split(" ");


            for (int i = 0; i < red.Length; i++)
            {
                string[] red1 = red[i].Split("=");

                List<string> bag = new List<string>();
                int chislo = (int)Convert.ToInt32(red1[1]);
                if (chislo < 0)
                {
                    throw new Exception("Money can not be negative!");
                }
                if (red1[0] == null || red1[0]=="")
                {
                    throw new Exception("Name can not be empty!");
                }

                Person p1 = new Person(red1[0], chislo, bag);

                chowek.Add(red1[0], p1);
            }

            string productinfo = Console.ReadLine();

            string[] line = productinfo.Split(" ");


            for (int i = 0; i < line.Length; i++)
            {
                string[] line1 = line[i].Split("=");
                for (int v = 0; v < line1.Length - 1; v++)
                {

                    List<Product> bag = new List<Product>();
                    int chislo = (int)Convert.ToInt32(line1[1]);
                    if (chislo<0)
                    {
                        throw new Exception("Money can not be negative!");
                    }
                    if (line1[0] == null || line1[0] == "")
                    {
                        throw new Exception("Name can not be empty!");
                    }
                    Product p1 = new Product(line1[0], chislo);

                    product.Add(line1[0], p1);
                }


            }
            while (true)
            {
                
                var pishi = Console.ReadLine().Trim();
                if (pishi == "END")
                {
                    break;
                

                  }
                string[] komanda = pishi.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string person = komanda[0];
                string product1 = komanda[1];
                int personMoney = chowek[person].Money;
                int productprice = product[product1].Cost;
                if (personMoney-productprice<0)
                {
                    dumi.Add($"{person} can't afford {product1}.");
                   
                }
                else
                {dumi.Add($"{person} bought {product1}.");
                    chowek[person].Money -= productprice;
                    chowek[person].Bag.Add(product1);
                  
                }

                

            }
            foreach (var el in dumi) { Console.WriteLine(el); }
            Console.WriteLine(" ");
            
            
            foreach (var person in chowek)
            {
               
                if (person.Value.Bag.Count==0)
                {
                    Console.WriteLine($"{person.Key} - Nothing bought.");
                }
                else
                {
                    Console.WriteLine($"{person.Key} - " + string.Join(",",person.Value.Bag));
                }
            }
        }
    }
 }
                        

