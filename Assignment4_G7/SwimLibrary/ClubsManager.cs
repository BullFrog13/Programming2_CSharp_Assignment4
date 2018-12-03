using System;
using System.Collections.Generic;
using System.IO;

/* 
 * class ClubsManager contains a list of Clubs.
 * It's method loads from a clubs text file and adds all Clubs to the clubs field
 */

namespace SwimLibrary
{
    public class ClubsManager : IClubsRepository
    {
        Dictionary<uint, Club> clubs = new Dictionary<uint, Club>();

        public Club[] Clubs
        {
            get
            {
                return (new List<Club>(clubs.Values)).ToArray();
            }
        }


        public int Number
        {
            get
            {
                return clubs.Count;
            }
        }


        public ClubsManager()
        {
        }


        public void Add(Club aClub)
        {
            if (clubs.ContainsKey(aClub.ClubNumber))
            {
                throw new Exception("Invalid club record. Club with the registration number already exists: ");
            }
            else
            {
                clubs.Add(aClub.ClubNumber, aClub);
            }
        }
        


        public Club GetByRegNum(uint regNumber)
        {
            if (clubs.ContainsKey(regNumber))
            {
                return clubs[regNumber];
            }
            
            return null;
        }

        public void Load(string fileName, string delimiter)
        {
            char delim_char = delimiter[0];
            string errors_report = "";

            FileStream inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] elements;
            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                elements = recordIn.Split(delim_char);

                try
                {
                    Club club = new Club(elements);

                    try
                    {
                        Add(club);
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

            if (errors_report != "") throw new Exception(errors_report);
        }



        public void Save(string fileName, string delimiter)
        {
            char delim_char = delimiter[0];

            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            foreach (Club club in clubs.Values)
            {
                if (club != null)
                {
                    writer.WriteLine($"{club.ClubNumber}{delim_char}{club.Name}{delim_char}" +
                                     $"{club.Address.GetWriteToFileInfo(delim_char)}{delim_char}{club.PhoneNumber}");
                }
            }

            writer.Close();
            outFile.Close();
        }
    }
}