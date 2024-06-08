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
                    return false;
                }

                string key = parts[0].Trim().Trim('"');
                string value = parts[1].Trim().Trim('"');

                if (!Regex.IsMatch(key, labelPattern))
                {
                    return false;
                }

                if (!Regex.IsMatch(value, labelPattern))
                {
                    return false;
                }
            }

            return true;
        }


        public bool ValidateAnnotations(string annotationText)
        {
            string labelPattern = @"^[A-Za-z0-9]([-A-Za-z0-9_.]*[A-Za-z0-9])?$";

            string[] annolLines = annotationText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in annolLines)
            {
                string[] parts = line.Trim().Split(':');
                if (parts.Length != 2)
                {
                    return false;
                }

                string key = parts[0].Trim().Trim('"');
                string value = parts[1].Trim().Trim('"');

                if (!Regex.IsMatch(key, labelPattern))
                {
                    return false;
                }

                if (!Regex.IsMatch(value, labelPattern))
                {
                    return false;
                }
            }

            return true;
        }
        public bool ValidatePorts(string portsText)
        {
            string portPattern = @"^\d+(,\d+)*$"; // Regex pattern for validating comma-separated numbers

            // Check if the ports text matches the pattern
            if (!Regex.IsMatch(portsText, portPattern))
            {
                return false;
            }

            // Split the ports text by commas
            string[] ports = portsText.Split(',');

            // Validate each port individually
            foreach (string port in ports)
            {
                // Convert port to integer and check if it's within valid range (1-65535)
                if (!int.TryParse(port, out int portNumber) || portNumber < 1 || portNumber > 65535)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
