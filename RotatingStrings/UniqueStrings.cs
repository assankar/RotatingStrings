using System;
using System.Collections.Generic;

namespace RotatingStrings
{
    class UniqueStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "AGA";
            string t = "AAG";
            string u = "CAA";
            List<string> list = new List<string>();
            list.Add(s);
            list.Add(t);
            list.Add(u);
            UniqueStrings p = new UniqueStrings();
            Console.WriteLine(p.uniqueStrings(list));
        }

        public UniqueStrings()
        {

        }

        public int uniqueStrings(List<string> list)
        {
            HashSet<string> set = new HashSet<string>();

            foreach(string s in list)
            {
                bool isUnique = true;
                string temp = s;
                for(int i = 0; i < s.Length; i++)
                {
                    if (set.Contains(temp))
                    {
                        isUnique = false;
                        break;
                    }
                    temp = temp.Substring(1) + temp.Substring(0, 1);
                }

                if (isUnique == true)
                {
                    set.Add(s);
                }
            }

            return set.Count;
        }

        public int isMatch(List<string> list)
        {
            HashSet<string> set = new HashSet<string>();
            bool isUnique = true;

            foreach(string s in list)
            {
                string temp = s;
                foreach (char c in s.ToCharArray())
                {
                    if (set.Contains(temp))
                    {
                        isUnique = false;
                        break;
                    }
                    else
                    {
                        temp = temp.Substring(1) + temp[0];
                    }
                }
                if (isUnique)
                {
                    set.Add(s);
                }
            }
            return set.Count;
        }
    }
}
