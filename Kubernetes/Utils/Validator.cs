using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kubernetes.Utils
{
    public class Validator
    {
        public bool ValidateNamespace(string name)
        {
            string pattern = @"^[a-z0-9]([-a-z0-9]*[a-z0-9])?$";
            return Regex.IsMatch(name, pattern);
        }

        public bool ValidateLabels(string labelText)
        {
            string labelPattern = @"^[A-Za-z0-9]([-A-Za-z0-9_.]*[A-Za-z0-9])?$";

            string[] labelLines = labelText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in labelLines)
            {
                string[] parts = line.Trim().Split(':');
                if (parts.Length != 2)
                {
                    Console.WriteLine($"Invalid label format: {line}");
                    return false;
                }

                string key = parts[0].Trim().Trim('"');
                string value = parts[1].Trim().Trim('"');

                if (!Regex.IsMatch(key, labelPattern))
                {
                    Console.WriteLine($"Invalid label key: {key}");
                    return false;
                }

                if (!Regex.IsMatch(value, labelPattern))
                {
                    Console.WriteLine($"Invalid label value: {value}");
                    return false;
                }
            }

            return true;
        }

    }
}
