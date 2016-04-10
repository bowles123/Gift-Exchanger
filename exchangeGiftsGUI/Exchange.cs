using System;
using System.Collections.Generic;

namespace exchangeGiftsGUI
{
    public class Exchange
    {
        public List<string> Names { get { return names; } }
        public List<string> ToNames { get { return toNames; } }
        public List<string> FromNames { get { return fromNames; } }
        public Dictionary<string, string> LastTime { get { return lastTime; } }

        private List<string> names;
        private List<string> toNames;
        private List<string> fromNames;
        private Dictionary<string, string> lastTime;

        public Exchange()
        {
            names = new List<string>();
            toNames = new List<string>();
            fromNames = new List<string>();
            lastTime = new Dictionary<string, string>();
        }

        public void ShuffleNames()
        {
            // Variables.
            Random rand = new Random();
            int n = Names.Count;

            // Shuffle the list.
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string value = Names[k];
                Names[k] = Names[n];
                Names[n] = value;
            }
        }

        public bool ExchangeGift(string from, string to)
        {
            string name;
            LastTime.TryGetValue(from, out name);

            if (from != to && to != name)
            {
                fromNames.Add(from);
                toNames.Add(to);
                return true;
            }
            else
                return false;
        }

        public void InitializeLastTime(string fileName)
        {

        }
    }
}