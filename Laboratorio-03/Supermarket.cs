using System;
using System.Collections.Generic;
namespace Laboratorio03
{
    public class Supermarket
    {
        private List<Persona> People = new List<Persona>;
        private List<Producto> AllProducts = new List<Producto>;

        public Supermarket()
        {
        }

        public bool AddPerson(Persona Person)
        {
            if (People.Count > 0)
            {
                foreach (Persona Dude in People)
                {
                    if (Dude.GetRUT() == Person.GetRUT())
                    {
                        Console.WriteLine("A person with this RUT already exists.");
                        return false;
                    }
                }
            }

            People.Add(Person);
            Console.WriteLine("Person "+Person.GetName()+" created successfully.");

            return true;
        }

        public bool AddProduct(Producto Product, int AddStock)
        {
            if (AllProducts.Count > 0)
            {
                foreach (Producto producto in AllProducts)
                {
                    if (producto.GetName() == Product.GetName() && producto.GetBrand() == Product.GetBrand())
                    {
                        Product.stock += AddStock;
                        return false;
                    }
                }
            }
            AllProducts.Add(Product);
            return true;
        }

        public bool JobChange(String daRUT, string new_job)
        {
            if (People.Count > 0)
            {
                foreach (Persona person in People)
                {
                    if (daRUT == person.GetRUT())
                    {
                        person.rol = new_job;
                        Console.WriteLine("Job successfully changed.");
                        return true;
                    }
                }
                Console.WriteLine("A person with that RUT does not exist.");
                return false;
            }
            else
            {
                Console.WriteLine("There are no people whose job can be changed.");
                return false;
            }
        }

        public bool AdjustSalary(String daRUT, int new_salary)
        {
            if (People.Count > 0)
            {
                foreach (Persona person in People)
                {
                    if (daRUT == person.GetRUT())
                    {
                        person.sueldo = new_salary;
                        Console.WriteLine("Salary successfully changed.");
                        return true;
                    }
                }
                Console.WriteLine("A person with that RUT does not exist.");
                return false;
            } else
            {
                Console.WriteLine("There are no people whose salary can be adjusted.");
                return false;
            }
        }
    }
}
