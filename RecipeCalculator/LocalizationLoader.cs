using System;
using System.Collections.Generic;
using System.IO;

namespace RecipeCalculator
{
    static class LocalizationLoader
    {
        public static void Load(ItemRepository items)
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../../resources/base.cfg"))
                {
                    bool reading = false;
                    string[] toLoad = { "item-name", "equipment-name", "fluid-name" };
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("["))
                        {
                            // Only read lines if contained in a category that were looking for
                            reading = StringContainsAny(line, toLoad);
                        }
                        else if (reading && line.Length > 0)
                        {
                            LoadLine(items, line);
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine("Missing localization file: " + e.FileName);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error while loading recipes:\n" + e.Message);
            }
        }

        private static bool StringContainsAny(string line, string[] keys)
        {
            foreach (string key in keys)
            {
                if (line.Contains(key))
                {
                    return true;
                }
            }
            return false;
        }

        private static void LoadLine(ItemRepository items, String line)
        {
            string[] tokens = line.Split('=');
            if (tokens.Length != 2)
            {
                Console.WriteLine("Invalid line in CFG file: \"{0}\"", line);
                return;
            }
            string name = tokens[0];
            string newName = tokens[1];

            Item item;
            if (items.Get(name, out item))
            {
                item.LabelName = newName;
            }
        }
    }
}
