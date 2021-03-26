using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArielWeb
{
    public class ActionInputs
    {
        string _repositoryName = null!;
        string _branchName = null!;

        public ActionInputs()
        {

        }

        public string Owner { get; set; } = null!;
        public string Version { get; set; } = null!;

        public string Branch
        {
            get => _branchName;
            set => ParseAndAssign(value, str => _branchName = str);
        }

        static void ParseAndAssign(string? value, Action<string> assign)
        {
            if (value.Length > 0 && assign != null)
            {
                assign(value.Split("/")[^1]);
            }
        }
    }
}
