using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;


/*
 * Class Registrant holds the following information:
 * a. registrant’s club affiliation 
 * b. identification number for a registrant
 * c. registrant’s name
 * d. date of birth
 * e. address of the registrant
 * f. telephone number
 */

namespace SwimLibrary
{
    public class Registrant
    {
        private Club club;
        private static uint nextRegistrantNumber = 1;
        private readonly uint registrationNumber;
        private String name;
        private DateTime dateOfBirth;
        private Address address;
        private uint phoneNumber;

        public Club Club
        {
            get
            {
                return club;
            }
            set
            {
                if (club != null)
                {
                    throw new Exception("Swimmer is registered with a different club");
                }
                else
                {
                    club = value;
                    club.RegisterMember(this);
                }
            }
        }

        private static uint NextRegistrantNumber
        {
            get
            {
                return nextRegistrantNumber++;
            }
        }

        public uint RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public uint PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }


        public Registrant()
        {
            registrationNumber = NextRegistrantNumber;
        }

        public Registrant(string[] fields)
        {
            try
            {
                registrationNumber = uint.Parse(fields[0]);
            }
            catch
            {
                throw new Exception("Invalid swimmer record. Invalid registration number: ");
            }
            if (fields[1] == "") throw new Exception("Invalid swimmer record. Invalid swimmer name: ");

            Name = fields[1];

            try
            {
                DateOfBirth = DateTime.ParseExact(fields[2], "yyyy-MM-dd hh:mm:ss tt", CultureInfo.InvariantCulture);// 1974-04-04 12:00:00 AM
            }
            catch
            {
                throw new Exception("Invalid swimmer record. Burth date is invalid: ");
            }

            Address = new Address(fields[3], fields[4], fields[5], fields[6]);

            try
            {
                PhoneNumber = uint.Parse(fields[7]);
            }
            catch
            {
                throw new Exception("Invalid swimmer record. Phone number wrong format: "); // in previous assignments phone# was 10-digits number. Nothing is said about the limit in this assignment, so I decided not to react to 9-digits number to be inline with the output (Swimmer's 12 phone number contains 9 digits) 
            }
        }

        public Registrant(String name, DateTime dateOfBirth, Address address, uint phoneNumber)
        {
            registrationNumber = NextRegistrantNumber;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
        }


        public override string ToString()
        {
            String infoResult = "Name: " + Name + "\n";
            infoResult += Address.ToString() + "\n";
            infoResult += "Phone: " + PhoneNumber + "\n";
            infoResult += "DOB: " + DateOfBirth.Date.ToString("yyyy-MM-dd hh:mm:ss tt").ToUpper() + "\n";

            infoResult += "Reg number: " + RegistrationNumber + "\n";


            String strClubInfo = "not assigned";
            if (club != null)
            {
                strClubInfo = club.Name;
            }

            infoResult += "Club: " + strClubInfo;

            return infoResult;
        }
    }
}