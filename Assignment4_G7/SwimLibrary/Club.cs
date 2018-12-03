using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * Class Club holds the following information:
 * a. club’s registration number
 * b. name of the club
 * c. address of the club
 * d. telephone number
 * e. registrants' club member list
 */

namespace SwimLibrary
{
    public class Club
    {
        Dictionary<uint, Registrant> swimmers = new Dictionary<uint, Registrant>();

        readonly Dictionary<uint, Registrant> coaches = new Dictionary<uint, Registrant>();

        private static uint nextClubNumber = 4;
        private readonly uint clubNumber;
        private string name;
        private Address address;
        private uint phoneNumber;

        private static uint NextClubNumber
        {
            get
            {
                return nextClubNumber++;
            }
        }

        public uint ClubNumber
        {
            get
            {
                return clubNumber;
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


        public Club()
        {
            clubNumber = NextClubNumber;
        }


        public Club(string[] elements)
        {
            try
            {
                clubNumber = uint.Parse(elements[0]);
            }
            catch
            {
                throw new Exception("Invalid club record Club number is not valid: ");
            }

            Name = elements[1];

            Address = new Address(elements[2], elements[3], elements[4], elements[5]);

            try
            {
                PhoneNumber = uint.Parse(elements[6]);
            }
            catch
            {
                throw new Exception("Invalid club record. Phone number wrong format: ");// in previous assignments phone# was 10-digits number. Nothing is said about the limit in this assignment, so to be consistent with the Registrant class I decided not to react to 9-digits number to be inline with the output (Swimmer 10's and 12's phone numbers contain 9 digits) 
            }
        }

        public Club(String name, Address address, uint phoneNumber)
        {
            clubNumber = NextClubNumber;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()// new
        {
            String infoResult = "Name: " + Name + "\n";
            infoResult += Address.ToString() + "\n";
            infoResult += "Phone: " + PhoneNumber + "\n";
            infoResult += "Reg number: " + ClubNumber + "\n";

            infoResult += "Swimmers: ";

            foreach (Swimmer swimmer in swimmers.Values)
            {
                infoResult += "\n\t" + swimmer.Name;
            }

            infoResult += "\nCoaches: ";

            foreach (Coach coach in coaches.Values)
            {
                infoResult += "\n\t" + coach.Name;
            }

            return infoResult;
        }


        public void RegisterMember(Registrant registrant)
        {
            if(typeof(Swimmer) == registrant.GetType() || typeof(Coach) == registrant.GetType())
            {
                var dict = coaches;
                if (typeof(Swimmer) == registrant.GetType())
                {
                    dict = swimmers;
                }

                if (!dict.ContainsKey(registrant.RegistrationNumber))
                {
                    dict.Add(registrant.RegistrationNumber, registrant);
                }
            }
            else
            {
                throw new Exception("Registrant type should be a Swimmer or a Coach");
            }
        }

        public void AddSwimmer(Registrant swimmer)
        {
            swimmer.Club = this;
        }


        public void AddCoach(Coach coach)
        {
            coach.Club = this;
        }
    }
}