namespace OOLab3
{
    using OO_Lab_3;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    class OOLab3
    {
        public static void Main(String[] args)
        {
            List<PatientInfo> patient = new List<PatientInfo>();
            List<string> vaccineList = new List<string>();
            string curFile = "PatientInfo.txt";

            int option = 0;
            do
            {
                Console.WriteLine("Please choose a menu option: ");
                Console.WriteLine("1.   Set Up Data And Display Data");
                Console.WriteLine("2.   Add a New Vaccine ");
                Console.WriteLine("3.   Add a vaccine to the patient information");
                Console.WriteLine("4.   Display the percentage of patients that have taken each vaccine");
                Console.WriteLine("5.   Display a list of patient numbers that have taken each vaccine");
                Console.WriteLine("6.   Enter vaccine(s) to search database for the patients that have taken all vaccines mentioned");
                Console.WriteLine("7.   Enter vaccine(s) to search database for the patients that have taken any of the vaccines mentioned");
                Console.WriteLine("8.   Save to a file");
                Console.WriteLine("9.   Exit");
                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(option);
                switch (option)
                {
                    case 1:
                        {
                            SetUpData(patient);
                            DisplayData(patient);
                            break;
                        }
                    case 2:
                        {
                            AddNewVaccine(vaccineList);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter an id that you want to search: ");
                            string id = Console.ReadLine();
                            PatientInfo foundPatient = FindById(patient, id);
                            if (foundPatient != null)
                            {
                                Console.WriteLine("Patient found:");
                                Console.WriteLine("Please enter a vaccine you would like to add to this patient: ");
                                string newVaccine = Console.ReadLine();
                                AddVaccineToPatient(patient, id, newVaccine);
                                Console.WriteLine(foundPatient.PrintDetailsById());
                            }
                            else
                            {
                                Console.WriteLine("Patient not found.");
                            }
                            break;
                        }
                    case 4:
                        {
                            DisplayPercentage(patient);
                            break;
                        }

                    case 5:
                        {
                            DisplayNumPer(patient);
                            break;
                        }
                    case 6:
                        {

                            FindMatches(patient, vaccineList);

                            break;
                        }
                    case 7:
                        {
                            FindAnyMatch(patient, vaccineList);
                            break;
                        }
                    case 8:
                        {
                            writeDataToFile(patient, curFile);
                            break;
                        }
                    case 9:

                        break;
                    default:
                        {
                            Console.WriteLine("option not implemented ");
                            break;
                        }
                }
            } while (option != 9);
        }
        public static void SetUpData(List<PatientInfo> patient)
        {
            patient.Clear();
            PatientInfo p1 = new PatientInfo("P1", "Grace Marks", new DateTime(1990, 1, 1));
            p1.AddVaccine("MMR");
            p1.AddVaccine("Covid");
            p1.AddVaccine("HPV");
            patient.Add(p1);
            PatientInfo p2 = new PatientInfo("P2", "Joe O'Niell", new DateTime(1998, 7, 10));
            p2.AddVaccine("MMR");
            p2.AddVaccine("Hepatitus B");
            patient.Add(p2);
            PatientInfo p3 = new PatientInfo("P3", "Martin Crane", new DateTime(1968, 5, 6));
            p3.AddVaccine("MMR");
            p3.AddVaccine("Covid");
            patient.Add(p3);
            PatientInfo p4 = new PatientInfo("P4", "Adam Corkery", new DateTime(2003, 2, 15));
            p4.AddVaccine("MMR");
            p4.AddVaccine("Covid");
            p4.AddVaccine("Polio");
            patient.Add(p4);
            PatientInfo p5 = new PatientInfo("P5", "Nadine Clark", new DateTime(2003, 11, 5));
            p5.AddVaccine("MMR");
            p5.AddVaccine("Covid");
            p5.AddVaccine("HPV");
            patient.Add(p5);
            PatientInfo p6 = new PatientInfo("P6", "Ronan Clark", new DateTime(2001, 2, 9));
            p6.AddVaccine("MMR");
            p6.AddVaccine("Covid");
            patient.Add(p6);
            PatientInfo p7 = new PatientInfo("P7", "Mark Clark", new DateTime(1968, 3, 6));
            p7.AddVaccine("MMR");
            p7.AddVaccine("Covid");
            p7.AddVaccine("Polio");
            patient.Add(p7);
            PatientInfo p8 = new PatientInfo("P8", "Connor Buckley", new DateTime(1990, 9, 15));
            p8.AddVaccine("MMR");
            patient.Add(p8);
            PatientInfo p9 = new PatientInfo("P9", "Christian Bale", new DateTime(1986, 10, 17));
            p9.AddVaccine("MMR");
            p9.AddVaccine("HPV");
            patient.Add(p9);
            PatientInfo p10 = new PatientInfo("P10", "Heath Ledger", new DateTime(1982, 7, 18));
            p10.AddVaccine("MMR");
            p10.AddVaccine("Polio");
            patient.Add(p10);
            PatientInfo p11 = new PatientInfo("P11", "Willy Wonka", new DateTime(2005, 8, 10));
            p11.AddVaccine("MMR");
            patient.Add(p11);
            PatientInfo p12 = new PatientInfo("P12", "Billy Joel", new DateTime(1960, 4, 9));
            p12.AddVaccine("MMR");
            patient.Add(p12);
            PatientInfo p13 = new PatientInfo("P13", "Bruce Wayne", new DateTime(1975, 8, 23));
            p13.AddVaccine("MMR");
            p13.AddVaccine("Covid");
            patient.Add(p13);
            PatientInfo p14 = new PatientInfo("P14", "Adam West", new DateTime(1953, 7, 2));
            p14.AddVaccine("MMR");
            p14.AddVaccine("Covid");
            patient.Add(p14);
            PatientInfo p15 = new PatientInfo("P15", "Mark Hamill", new DateTime(1964, 10, 21));
            p15.AddVaccine("MMR");
            p15.AddVaccine("Covid");
            patient.Add(p15);
            PatientInfo p16 = new PatientInfo("P16", "Jim Carey", new DateTime(1990, 7, 27));
            p16.AddVaccine("MMR");
            p16.AddVaccine("Covid");
            patient.Add(p16);
            PatientInfo p17 = new PatientInfo("P17", "Cameron Diaz", new DateTime(1984, 6, 14));
            p17.AddVaccine("MMR");
            p17.AddVaccine("Covid");
            p17.AddVaccine("HPV");
            patient.Add(p17);
            PatientInfo p18 = new PatientInfo("P18", "Olivia Coleman", new DateTime(1993, 5, 17));
            p18.AddVaccine("MMR");
            p18.AddVaccine("Covid");
            p18.AddVaccine("HPV");
            patient.Add(p18);
            PatientInfo p19 = new PatientInfo("P19", "Neve Campbull", new DateTime(1974, 7, 28));
            p19.AddVaccine("MMR");
            p19.AddVaccine("Covid");
            p19.AddVaccine("HPV");
            patient.Add(p19);
            PatientInfo p20 = new PatientInfo("P20", "Holly Holiday", new DateTime(1999, 7, 15));
            p20.AddVaccine("MMR");
            p20.AddVaccine("Covid");
            p20.AddVaccine("HPV");
            patient.Add(p20);
        }
        public static void DisplayData(List<PatientInfo> patients)
        {
            foreach (PatientInfo patient in patients)
            {
                patient.PrintDetails();
            }

        }
        public static void AddNewVaccine(List<String> vaccineList)
        {
            Console.Write("Enter the name of the new vaccine: ");
            string newVaccine = Console.ReadLine();
            if (vaccineList.Contains(newVaccine))
            {
                Console.WriteLine($"{newVaccine} already exists in the system.");
            }
            else
            {
                vaccineList.Add(newVaccine);
                Console.WriteLine($"{newVaccine} has been added to the system.");
            }
        }
        public static PatientInfo FindById(List<PatientInfo> patient, string id)
        {
            foreach (PatientInfo pId in patient)
            {
                if (pId.PatientNo.Equals(id))
                {
                    return pId;
                }
            }
            return null;
        }
        public static void AddVaccineToPatient(List<PatientInfo> patients, string id, string vaccine)
        {
            PatientInfo foundPatient = FindById(patients, id);

            if (foundPatient != null)
            {
                foundPatient.AddVaccine(vaccine);
                Console.WriteLine($"Vaccine {vaccine} added to patient {id}.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
        public static void DisplayPercentage(List<PatientInfo> patients)
        {
            Dictionary<string, int> vaccineCount = new Dictionary<string, int>();
            foreach (PatientInfo patient in patients)
            {
                foreach (string vaccine in patient.Vaccines)
                {
                    if (vaccineCount.ContainsKey(vaccine))
                    {
                        vaccineCount[vaccine]++;
                    }
                    else
                    {
                        vaccineCount[vaccine] = 1;
                    }
                }
            }
            Console.WriteLine("Percentage of patients for each vaccine:");
            foreach (var perppa in vaccineCount)
            {
                double percentage = (double)perppa.Value / patients.Count * 100;
                Console.WriteLine($"{perppa.Key}: {percentage}%");
            }
        }
        public static void DisplayNumPer(List<PatientInfo> patients)
        {
            Dictionary<string, List<string>> vaccineCount = new Dictionary<string, List<string>>();
            foreach (PatientInfo patient in patients)
            {
                foreach (string vaccine in patient.Vaccines)
                {
                    if (vaccineCount.ContainsKey(vaccine))
                    {
                        vaccineCount[vaccine].Add(patient.PatientNo);
                    }
                    else
                    {
                        vaccineCount[vaccine] = new List<string> { patient.PatientNo };
                    }
                }
            }
            Console.WriteLine("Patient numbers for each vaccine:");
            foreach (var perppa in vaccineCount)
            {
                Console.WriteLine($"{perppa.Key}: {string.Join(", ", perppa.Value)}");
            }
        }
        public static void writeDataToFile(List<PatientInfo> patient, string curFile)
        {

            FileInfo fInfo = new FileInfo(curFile);
            FileStream PatientFile;

            if (fInfo.Exists)
            {
                PatientFile = new FileStream(curFile, FileMode.Truncate, FileAccess.Write);
                Console.WriteLine("found file " + fInfo.FullName);
            }
            else
            {
                PatientFile = new FileStream(curFile, FileMode.Create, FileAccess.Write);
                Console.WriteLine("created file " + fInfo.FullName);
            }

            BinaryFormatter bformatter = new BinaryFormatter();

            try
            {
                bformatter.Serialize(PatientFile, patient);


            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            PatientFile.Close();

            Console.WriteLine("data written to file");

        
        }
        public static void FindMatches(List<PatientInfo> patients, List<string> vaccineList)
        {
            Console.WriteLine("Enter vaccine names(They must have the correct case): ");
            string input = Console.ReadLine();
            string[] enteredVaccines = input.Split(' ');
            //make sure to have the cases correct

            int countMatches = 0;
            foreach (PatientInfo patient in patients)
            {
                List<string> patientVaccines = patient.Vaccines;

                if (enteredVaccines.All(enteredVaccine => patientVaccines.Contains(enteredVaccine)))
                {
                    Console.WriteLine("Match:");
                    Console.WriteLine($"Patient Number: {patient.PatientNo}");
                    Console.WriteLine($"Patient Name: {patient.PatientName}");
                    Console.WriteLine($"Date of Birth: {patient.DOB}");
                    Console.WriteLine($"Vaccines: {string.Join(", ", patientVaccines)}\n");

                    countMatches++;
                }
            }

            Console.WriteLine($"Number of matches: {countMatches}");
        }
        public static void FindAnyMatch(List<PatientInfo> patients, List<string> vaccineList)
        {
            Console.WriteLine("Enter vaccine names: ");
            string input = Console.ReadLine();
            string[] enteredVaccines = input.Split(' ');
            //make sure to have the cases correct

            int countMatches = 0;
            foreach (PatientInfo patient in patients)
            {
                List<string> patientVaccines = patient.Vaccines;

                if (enteredVaccines.Any(enteredVaccine => patientVaccines.Contains(enteredVaccine)))
                {
                    Console.WriteLine("Match:");
                    Console.WriteLine($"Patient Number: {patient.PatientNo}");
                    Console.WriteLine($"Patient Name: {patient.PatientName}");
                    Console.WriteLine($"Date of Birth: {patient.DOB}");
                    Console.WriteLine($"Vaccines: {string.Join(", ", patientVaccines)}\n");

                    countMatches++;
                }
            }

            Console.WriteLine($"Number of matches: {countMatches}");
        }
    }
}
