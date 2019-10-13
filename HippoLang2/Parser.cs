using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserExtensions;

namespace HippoLang2
{
    public class Parser
    {
        private StreamReader input;
        public Parser(string path)
        {
            this.input = new StreamReader(path);
        }

        public List<string> ReadNext()
        {
            return input.ReadLine().HippoSplit();
        }

        public List<List<string>> ReadAll()
        {
            List<List<string>> list = new List<List<string>>();
            while (!input.EndOfStream)
            {
                list.Add(input.ReadLine().HippoSplit());
            }
            return list;
        }
    }

    public class Interpretator
    {
        Dictionary<string, object> variables;
        public Interpretator()
        {
            variables = new Dictionary<string, object>();
        }

        public void Translate(List<string> commands)
        {
            switch (commands[0])
            {
                case "print":
                    Print(commands[1].Trim('\"'));
                    break;
                case "float":
                    variables.Add(commands[1],
                        commands[2]);
                    break;
                case "string":
                    variables.Add(commands[1],
                        commands[2].Trim('\"'));
                    break;
            }
        }

        private void Print(string arg)
        {
            bool canAdd = false;
            string varName = "";
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] == '}')
                {
                    canAdd = false;
                    Console.Write(Search(varName));
                    varName = "";
                    continue;
                }
                if (arg[i] == '{')
                {
                    canAdd = true;
                    continue;
                }

                if (canAdd)
                {
                    varName += arg[i];
                }
                else
                {
                    Console.Write(arg[i]);
                }


            }
        }

        private object Search(string name)
        {
            foreach (KeyValuePair<string, object> keyValue in variables)
            {
                if (keyValue.Key == name)
                {
                    return keyValue.Value;
                }
            }
            return null;
        }
    }
}
