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

        // This function does the exchange gifts for the Thompson family.
        static bool individualThompsonFamily()
        {
            // Variables.
            List<string> individualNames1 = new List<string>(), individualNames2 = new List<string>();
            Dictionary<string, string> lastYear = new Dictionary<string, string>();
            System.IO.StreamWriter outFile = new System.IO.StreamWriter(@"individualThompsonThisYear.txt");
            int individualParticipants = 0, individualDone = 0;
            string name, one, two, last;

            // Get the assignments from the previous year.
            lastYear = readFromFile("individualThompsonLastYear.txt");

            // Get the name of the first participant for the individual exchange gifts.
            Console.Write("Please enter participants name for individual trade: ");
            name = Console.ReadLine();
            individualNames1.Add(name);
            individualNames2.Add(name);
            individualDone++;

            while (individualParticipants > individualDone)
            {
                // Keep getting the names of the participants for the indiviudal exchange gifst
                // until all of them have been entered.
                Console.Write("Please enter participants name for individual trade: ");
                name = Console.ReadLine();
                individualNames1.Add(name);
                individualNames2.Add(name);
                individualDone++;
            }
            Shuffle(individualNames1); // Shuffle the names so the list is randomized.

            // Assign people to names until everyone has been assigned.
            do
            {
                // Get the two names.
                one = individualNames1[0];
                individualNames1.Remove(one);
                two = individualNames2[0];
                individualNames2.Remove(two);
                bool there = lastYear.TryGetValue(one, out last);

                // If the names are the same or the first gave to the second last year retry the assignment.
                while (one == two || (there == true && two == last))
                {
                    // Add the names back, shuffle the second list, and try again.
                    individualNames2.Add(two);
                    two = individualNames2[0];
                    individualNames2.Remove(two);
                    there = lastYear.TryGetValue(one, out last);
                }

                // Output the assignments to the console and to a file.
                Console.WriteLine("{0} -> {1}.", one, two);
                outFile.WriteLine(String.Format("{0},{1}", one, two));
                individualDone++;
            }
            while (individualNames1.Count > 0 && individualDone <= individualParticipants);

            if (individualNames1.Count > 0) return false;
            outFile.Close();
            return true;
        }

        static bool familyThompsonFamily()
        {
            List<string> familyNames1 = new List<string>(), familyNames2 = new List<string>();
            Dictionary<string, string> lastYear = new Dictionary<string, string>();
            System.IO.StreamWriter outFile = new System.IO.StreamWriter(@"familyThompsonThisYear.txt");
            int familyParticipants = 0, familyDone = 0;
            string name, one, two, last;

            // Get the assignments from the previous year.
            lastYear = readFromFile("familyThompsonLastYear.txt");

            // Get the name of the first participant for the individual exchange gifts.
            Console.Write("Please enter participants name for family trade: ");
            name = Console.ReadLine();
            familyNames1.Add(name);
            familyNames2.Add(name);
            familyDone++;

            while (familyParticipants > familyDone)
            {
                // Keep getting the names of the participants for the indiviudal exchange gifst
                // until all of them have been entered.
                Console.Write("Please enter participants name for family trade: ");
                name = Console.ReadLine();
                familyNames1.Add(name);
                familyNames2.Add(name);
                familyParticipants++;
            }
            Shuffle(familyNames1); // Shuffle the names so the list is randomized.

            // Assign people to names until everyone has been assigned.
            do
            {
                // Get the two names.
                one = familyNames1[0];
                familyNames1.Remove(one);
                two = familyNames2[0];
                familyNames2.Remove(two);
                bool there = lastYear.TryGetValue(one, out last);

                // If the names are the same or the first gave to the second last year retry the assignment.
                while (one == two || (there == true && two == last))
                {
                    // Add the names back, shuffle the second list, and try again.
                    familyNames2.Add(two);
                    two = familyNames2[0];
                    familyNames2.Remove(two);
                    there = lastYear.TryGetValue(one, out last);
                }

                // Output the assignments to the console and to a file.
                Console.WriteLine("{0} -> {1}.", one, two);
                outFile.WriteLine(String.Format("{0},{1}", one, two));
                familyDone++;
            }
            while (familyNames1.Count > 0 && familyDone <= familyParticipants);

            if (familyNames1.Count > 0) return false;
            outFile.Close();
            return true;
        }

        // This function does the exchange gifts for the Bowles family.
        static bool BowlesFamily()
        {
            // Variables.
            List<string> names1 = new List<string>(), names2 = new List<string>();
            Dictionary<string, string> lastYear = new Dictionary<string, string>();
            System.IO.StreamWriter outFile = new System.IO.StreamWriter(@"thisYear.txt");
            int participants, done = 0;
            string name, one, two, last;

            // Get the number of particpants for the year.
            lastYear = readFromFile("lastYear.txt"); // Get the assignments from the previous year.
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
        static Dictionary<string, string> readFromFile(string fileName)
        {
            // Variables.
            Dictionary<string, string> lastTime = new Dictionary<string, string>();
            String[] lines = File.ReadAllLines(fileName);
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
