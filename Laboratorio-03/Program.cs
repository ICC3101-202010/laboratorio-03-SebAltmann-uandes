using System;

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
                while (response != "A" && response != "a" && response != "B" && response != "B" && response != "S" && response != "s" && response != "C" && response != "c" && response != "P" && response != "p" && response != "L" && response != "l")
                {
                    Console.WriteLine("Welcome to Moogle-mart!!\n");
                    Console.WriteLine("Create Person (Play God): {A}");
                    Console.WriteLine("Create Product: {B}");
                    Console.WriteLine("Make a purchase: {C}");
                    Console.WriteLine("Crear playlist: {P}");
                    Console.WriteLine("Ver mis Playlists: {L}");
                    Console.WriteLine("Exit: {S}");
                    response = Console.ReadLine();

                    if (response != "A" && response != "a" && response != "B" && response != "b" && response != "S" && response != "s" && response != "C" && response != "c" && response != "P" && response != "p" && response != "L" && response != "l")
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
                        Persona new_person = new Persona(new_RUT, new_name, new_last_name, new_dob, new_nationality, new_role, new_salary);
                        Moogle.AddPerson(new_person);
                    }

                    if (response == "B" || response == "b")
                    {
                        String new_pname;
                        Console.Write("New product's name: ");
                        new_pname = Console.ReadLine();
                        String new_price;
                        int new_price2;
                        Console.Write("New product's price: ");
                        new_price = Console.ReadLine();
                        new_price2 = Convert.ToInt32(new_price);
                        String new_brand;
                        Console.Write("New product's brand: ");
                        new_brand = Console.ReadLine();
                        String new_stock;
                        int new_stock2;
                        Console.Write("Amount of the new product to add to stock: ");
                        new_stock = Console.ReadLine();
                        new_stock2 = Convert.ToInt32(new_stock);
                        Producto new_product = new Producto(new_pname, new_price2, new_brand, new_stock2);
                        Moogle.AddProduct(new_product);
                    }

                    if (response == "C" || response == "c")
                    {
                        String response2 = "x";
                        Console.Write("¿Qué criterio desea utilizar? (Nombre/Artista/Album/Género)  ");
                        response2 = Console.ReadLine();
                        if (response2 == "Nombre" || response2 == "nombre" || response2 == "Artista" || response2 == "artista" || response2 == "Album" || response2 == "album" || response2 == "Género" || response2 == "Genero" || response2 == "género" || response2 == "genero")
                        {
                            if (response2 == "Nombre")
                            {
                                response2 = "nombre";
                            }
                            else if (response2 == "Artista")
                            {
                                response2 = "artista";
                            }
                            else if (response2 == "Album")
                            {
                                response2 = "album";
                            }
                            else if (response2 == "Género" || response2 == "Genero" || response2 == "género")
                            {
                                response2 = "genero";
                            }
                            String response3 = "x";
                            Console.Write("¿Cuál es el " + response2 + " que desea buscar?  ");
                            response3 = Console.ReadLine();
                            //SPOT.CancionesPorCriterio(response2, response3);
                            response2 = "x";
                            response3 = "x";
                        }
                        else
                        {
                            Console.WriteLine("Ése criterio no es válido.");
                        }
                    }

                    if (response == "P" || response == "p")
                    {
                        String new_pl_name = "x";
                        Console.Write("¿Qué nombre desea darle a la playlist?  ");
                        new_pl_name = Console.ReadLine();
                        String response2 = "x";
                        Console.Write("¿Qué criterio desea utilizar? (Nombre/Artista/Album/Género)  ");
                        response2 = Console.ReadLine();
                        if (response2 == "Nombre" || response2 == "nombre" || response2 == "Artista" || response2 == "artista" || response2 == "Album" || response2 == "album" || response2 == "Género" || response2 == "Genero" || response2 == "género" || response2 == "genero")
                        {
                            if (response2 == "Nombre")
                            {
                                response2 = "nombre";
                            }
                            else if (response2 == "Artista")
                            {
                                response2 = "artista";
                            }
                            else if (response2 == "Album")
                            {
                                response2 = "album";
                            }
                            else if (response2 == "Género" || response2 == "Genero" || response2 == "género")
                            {
                                response2 = "genero";
                            }
                            String response3 = "x";
                            Console.Write("¿Cuál es el " + response2 + " que desea utilizar?  ");
                            response3 = Console.ReadLine();
                            //SPOT.GenerarPlaylist(response2, response3, new_pl_name);
                            response2 = "x";
                            response3 = "x";
                        }
                        else
                        {
                            Console.WriteLine("Ése criterio no es válido.");
                        }
                    }

                    if (response == "L" || response == "l")
                    {
                        //Console.WriteLine(SPOT.VerMisPlaylists());
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
