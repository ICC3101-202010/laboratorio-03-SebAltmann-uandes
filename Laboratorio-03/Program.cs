using System;
using System.Collections.Generic;

namespace Laboratorio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Supermarket Moogle = new Supermarket();
            String response = "x";
            while (true)
            {
                while (response != "A" && response != "a" && response != "B" && response != "B" && response != "S" && response != "s" && response != "C" && response != "c" && response != "D" && response != "d" && response != "E" && response != "e")
                {
                    Console.WriteLine("Welcome to Moogle-mart!!\n");
                    Console.WriteLine("Create Person (Play God): {A}");
                    Console.WriteLine("Create Product: {B}");
                    Console.WriteLine("Make a purchase: {C}");
                    Console.WriteLine("Change a person's role: {D}");
                    Console.WriteLine("Adjust a person's salary: {E}");
                    Console.WriteLine("Exit: {S}");
                    response = Console.ReadLine();

                    if (response != "A" && response != "a" && response != "B" && response != "b" && response != "S" && response != "s" && response != "C" && response != "c" && response != "D" && response != "d" && response != "E" && response != "e")
                    {
                        Console.WriteLine("Invalid response.");
                    }

                    if (response == "A" || response == "a")
                    {
                        String new_name;
                        Console.Write("New person's name: ");
                        new_name = Console.ReadLine();
                        String new_RUT;
                        Console.Write("New person's RUT (XX.XXX.XXX-X): ");
                        new_RUT = Console.ReadLine();
                        String new_last_name;
                        Console.Write("New person's last name: ");
                        new_last_name = Console.ReadLine();
                        String new_dob;
                        Console.Write("New person's date of birth (DD/MM/YYYY): ");
                        new_dob = Console.ReadLine();
                        String new_nationality;
                        Console.Write("New person's nationality: ");
                        new_nationality = Console.ReadLine();
                        String new_role;
                        Console.Write("New person's role (client/worker/supervisor/boss/janitor): ");
                        new_role = Console.ReadLine();
                        String new_salary;
                        Console.Write("New person's salary: ");
                        new_salary = Console.ReadLine();
                        Persona new_person = new Persona(new_RUT, new_name, new_last_name, new_dob, new_nationality, new_role, Convert.ToInt32(new_salary));
                        Moogle.AddPerson(new_person);
                    }

                    if (response == "B" || response == "b")
                    {
                        String new_pname;
                        Console.Write("New product's name: ");
                        new_pname = Console.ReadLine();
                        String new_price;
                        Console.Write("New product's price: ");
                        new_price = Console.ReadLine();
                        String new_brand;
                        Console.Write("New product's brand: ");
                        new_brand = Console.ReadLine();
                        String new_stock;
                        Console.Write("Amount of the new product to add to stock: ");
                        new_stock = Console.ReadLine();
                        Producto new_product = new Producto(new_pname, Convert.ToInt32(new_price), new_brand, Convert.ToInt32(new_stock));
                        Moogle.AddProduct(new_product, Convert.ToInt32(new_stock));
                    }

                    if (response == "C" || response == "c")
                    {
                        while (true)
                        {
                            Cart Kart = new Cart();
                            return;
                        }
                    }

                    if (response == "D" || response == "d")
                    {
                        String j_RUT;
                        Console.Write("What is the RUT if the person whose job you wish to change? ");
                        j_RUT = Console.ReadLine();
                        String n_job;
                        Console.Write("What will be the new job of this person? ");
                        n_job = Console.ReadLine();
                        Moogle.JobChange(j_RUT, n_job);
                    }

                    if (response == "E" || response == "e")
                    {
                        String s_RUT;
                        Console.Write("What is the RUT if the person whose salary you wish to adjust? ");
                        s_RUT = Console.ReadLine();
                        String a_salary;
                        Console.Write("What will be the new salary of this person? ");
                        a_salary = Console.ReadLine();
                        Moogle.AdjustSalary(s_RUT, Convert.ToInt32(a_salary));
                    }

                    if (response == "S" || response == "s")
                    {
                        return;
                    }
                }
                response = "x";
            }
        }
    }
}
