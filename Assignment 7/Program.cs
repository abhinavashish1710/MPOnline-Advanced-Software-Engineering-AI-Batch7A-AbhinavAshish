using System;
using System.Collections.Generic;

namespace Assignment7_PlaylistManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> playlist = new List<string>();

            int choice;

            do
            {
                Console.WriteLine("\n===== Playlist Management =====");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Display Playlist");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Song Title: ");
                        string song = Console.ReadLine();
                        playlist.Add(song);
                        Console.WriteLine("Song added successfully!");
                        break;

                    case 2:
                        if (playlist.Count == 0)
                        {
                            Console.WriteLine("Playlist is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nPlaylist");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Index\tSong Title");

                            for (int i = 0; i < playlist.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}\t{playlist[i]}");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 3);

            Console.ReadLine();
        }
    }
}
