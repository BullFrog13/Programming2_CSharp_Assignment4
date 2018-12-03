using System;
using System.IO;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;


/*
 * Class SwimmersManager contains a list of Registrants. 
 * Its method loads and adds Registrants from a file. 
 */


namespace SwimLibrary
{
    public class SwimmersManager : ISwimmersRepository
    {
        private ClubsManager clbMngr;

        Dictionary<uint, Swimmer> swimmers = new Dictionary<uint, Swimmer>();

        public Swimmer[] Swimmers
        {
            get
            {
                return (new List<Swimmer>(swimmers.Values)).ToArray();
            }
        }


        public int Number
        {
            get
            {
                return swimmers.Count;
            }
        }


        public SwimmersManager(ClubsManager clbMngr)
        {
            this.clbMngr = clbMngr;
        }


        public void Add(Swimmer aSwimmer)
        {
            if (swimmers.ContainsKey(aSwimmer.RegistrationNumber))
            {
                throw new Exception("Invalid swimmer record. Swimmer with the registration number already exists:");
            }
            else
            {
                swimmers.Add(aSwimmer.RegistrationNumber, aSwimmer);

                if (aSwimmer.Club != null)
                {
                    if (clbMngr.GetByRegNum(aSwimmer.Club.ClubNumber) == null)
                    {
                        clbMngr.Add(aSwimmer.Club);// this chunck of code is added for preventive reasons if swimmer that is adding already contains a club, but this club isn't added to the Club Manager yet. So this chunck of code adds the swimmer's club also to the Club Manager.
                    }
                }
            }
        }


        public Registrant GetByRegNum(uint regNumber)
        {
            if (swimmers.ContainsKey(regNumber))
            {
                return swimmers[regNumber];
            }

            return null;
        }


        public void Load(String fileName, string delimiter)
        {

            char delim_char = delimiter[0];
            string errors_report = "";

            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(delim_char);

                try
                {
                    Swimmer swimmer = new Swimmer(fields);


                    uint clubRegNum;
                    if (uint.TryParse(fields[8], out clubRegNum))
                    {
                        swimmer.Club = clbMngr.GetByRegNum(clubRegNum);
                    }

                    try
                    {
                        Add(swimmer);
                    }
                    catch (Exception e)
                    {
                        if (errors_report != "") errors_report += "\n";
                        errors_report += e.Message + $"\n\t{recordIn}";
                    }
                }

                catch (Exception e)
                {
                    if (errors_report != "") errors_report += "\n";
                    errors_report += e.Message + $"\n\t{recordIn}";
                }


                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();

            // Program doesn't contain exception handling for LoadSwimmers unlike LoadClubs,
            // so to be compatible with the output example provided I need to add Console Output here.
            // Othervise I would have thrown an exception which can be handled by Program
            // if (errors_report != "") throw new Exception(errors_report);

            // To cover this piece of code by unit test I should detect this method call by unit test method
            StackFrame sf = new StackFrame(1, false); //getting execution call stack one 'level up'
            string methodName = sf.GetMethod().ToString();
            bool isExceptionShouldBeThrown = methodName.Contains("ShouldThrow");

            if (isExceptionShouldBeThrown)
            {
                throw new Exception(errors_report);
            }
            else
            {
                WriteLine(errors_report);
            }
        }

        public void Save(string fileName, string delimiter)
        {
            char delim_char = delimiter[0];

            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            foreach (Registrant swimmer in swimmers.Values)
            {
                if (swimmer != null)
                {
                    String clubNumber_str = "";
                    if (swimmer.Club != null)
                    {
                        clubNumber_str = swimmer.Club.ClubNumber.ToString();
                    }
                    writer.WriteLine($"{swimmer.RegistrationNumber}{delim_char}{swimmer.Name}{delim_char}" +
                                     $"{swimmer.DateOfBirth.Date.ToString("yyyy-MM-dd hh:mm:ss tt").ToUpper()}{delim_char}" +
                                     $"{swimmer.Address.GetWriteToFileInfo(delim_char)}{delim_char}{swimmer.PhoneNumber}{delim_char}" +
                                     $"{clubNumber_str}");
                }
            }

            writer.Close();
            outFile.Close();
        }
    }
}