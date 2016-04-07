using System;
using System.Collections.Generic;
using System.IO;

namespace exchangeGifts
{
    class Exchange
    {
        static void Main(string[] args)
        {
            bool finished = false;

            while (!finished)
                finished = BowlesFamily();
        }
        static bool BowlesFamily()
        {
            // Variables.
            List<string> names1 = new List<string>(), names2 = new List<string>();
            Dictionary<string, string> lastYear = new Dictionary<string, string>();
            System.IO.StreamWriter outFile = new System.IO.StreamWriter(@"thisYear.txt");
            int participants, done = 0;
            string name, one, two, last;

            // Get the number of particpants for the year.
            lastYear = readFromFile(); // Get the assignments from the previous year.
            Console.Write("How many are participating this year? ");
            participants = int.Parse(Console.ReadLine());

            if (participants == 12)
            {
                names1 = new List<string>() { "Derek", "Aaron", "Brian", "Jason", "Philip",
                    "Corey", "Sam", "Sarah", "Tim", "Abe", "Rosa", "Hannah" };
                names2 = new List<string>(names1);
            }
            else
            {
                // Get the name of the first participant.
                Console.Write("Please enter participants name: ");
                name = Console.ReadLine();
                names1.Add(name);
                names2.Add(name);
                done++;

                while (participants > done)
                {
                    // Keep getting the names of the participants until all of them have been entered.
                    Console.Write("Please enter participants name: ");
                    name = Console.ReadLine();
                    names1.Add(name);
                    names2.Add(name);
                    done++;
                }
            }
            Shuffle(names1); // Shuffle the names so the list is randomized.
            done = 0;

            // Assign people to names until everyone has been assigned.
            while (names1.Count > 0 && done <= participants)
            {
                // Get the two names.
                one = names1[0];
                names1.Remove(one);
                two = names2[0];
                names2.Remove(two);
                bool there = lastYear.TryGetValue(one, out last);

                // If the names are the same or the first gave to the second last year retry the assignment.
                while (one == two || (there == true && two == last))
                {
                    // Add the names back, shuffle the second list, and try again.
                    names2.Add(two);
                    two = names2[0];
                    names2.Remove(two);
                    there = lastYear.TryGetValue(one, out last);
                }

                // Output the assignments to the console and to a file.
                Console.WriteLine("{0} -> {1}.", one, two);
                outFile.WriteLine(String.Format("{0},{1}", one, two));
                done++;
            }

            if (names1.Count > 0) return false;
            outFile.Close();
            return true;
        }

        // This function shuffles a given list so it's not in order.
        static void Shuffle(List<string> lst)
        {
            // Variables.
            Random rand = new Random();
            int n = lst.Count;

            // Shuffle the list.
            while(n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string value = lst[k];
                lst[k] = lst[n];
                lst[n] = value;
            }
        }

        // This function reads from the "lastYear.txt" file 
        // and returns a dictionary of who was assigned to whom the previous year.
        static Dictionary<string, string> readFromFile()
        {
            // Variables.
            Dictionary<string, string> lastTime = new Dictionary<string, string>();
            String[] lines = File.ReadAllLines("lastYear.txt");
            string[] names;
            string one, two;

            // For each assignment add that assignment to the dictionary.
            for (int i = 0; i < lines.Length; i++)
            {
                names = lines[i].Split(',');

                one = names[0];
                two = names[1];
                lastTime.Add(one, two);
            }
            return lastTime;
        }
    }
}
