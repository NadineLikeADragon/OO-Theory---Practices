using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OO_Lab_3
{
    [Serializable]
    internal class PatientInfo
    {          
        
        public static List<string> AvailableVaccines = new List<string>
    {
        "MMR",
        "Covid",
        "HepatitusB",
        "Polio",
        "HPV",
    };
        public string PatientNo { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public List<string> Vaccines { get; set; } = new List<string>();

        public PatientInfo(string patientNo, string patientName, DateTime dOB, List<string> vaccines) : this(patientNo, patientName, dOB)
        {
            Vaccines = vaccines;
        }

        public PatientInfo(string patientNo, string patientName, DateTime dOB)
        {
            PatientNo = patientNo;
            PatientName = patientName;
            DOB = dOB;
        }
        public void AddVaccine(string vaccine)
        {
            if (AvailableVaccines.Contains(vaccine))
            {
                Vaccines.Add(vaccine);
            }
            else
            {
                 Console.WriteLine($"Error: {vaccine} is not a valid vaccine in the system.");               
            }
        }
            public void PrintDetails()
        {
            
             Console.WriteLine($"Patient Number: {PatientNo}");
            Console.WriteLine($"Patient Name: {PatientName}");
            Console.WriteLine($"Date of Birth: {DOB}");
            if (Vaccines.Count > 0)
            {
                Console.WriteLine("Vaccines Received:");
                foreach (string vaccine in Vaccines)
                {
                    Console.WriteLine($"- {vaccine}");
                }
            }
            else
            {
                Console.WriteLine("No vaccines received yet.");
            }

            Console.WriteLine();
        }
        public string PrintDetailsById()
        {
            string details = $"Patient Number: {PatientNo}\n";
            details += $"Patient Name: {PatientName}\n";
            details += $"Date of Birth: {DOB}\n";

            if (Vaccines.Count > 0)
            {
                details += "Vaccines Received:\n";
                foreach (string vaccine in Vaccines)
                {
                    details += $"- {vaccine}\n";
                }
            }
            else
            {
                details += "No vaccines received yet.\n";
            }

            return details;
        }
    }
}