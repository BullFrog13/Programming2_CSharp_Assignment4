using System;
using System.Collections.Generic;


/*
 * Class Coach is a Registrant who has additional class members:
 * a. coaching credentials
 * b. list of swimmers that are being coached by this coach
 */

namespace SwimLibrary
{
    public class Coach : Registrant
    {
        Dictionary<uint, Swimmer> fosterlings = new Dictionary<uint, Swimmer>();

        public string Credentials { get; set; }

        public Coach(String name, DateTime dateOfBirth, Address address, uint phoneNumber) : base(name, dateOfBirth, address, phoneNumber) { }


        public Swimmer GetFosterling(uint registrationNumber)
        {
            if (fosterlings.ContainsKey(registrationNumber))
            {
                return fosterlings[registrationNumber];
            }
            else
            {
                return null;
            }
        }

        public void RemoveFosterling(Swimmer swimmer)
        {
            fosterlings.Remove(swimmer.RegistrationNumber);
        }

        public void AddSwimmer(Swimmer swimmer)
        {
            if(this.Club == null)
            {
                throw new Exception("Coach is not assigned to a club");
            }
            if (!fosterlings.ContainsKey(swimmer.RegistrationNumber))
            {
                fosterlings.Add(swimmer.RegistrationNumber, swimmer);
                swimmer.Coach = this;
            }
        }



        public override string ToString()
        {
            String infoResult = base.ToString();

            infoResult += "\n Credentials: " + Credentials;
            infoResult += "\n Swimmers ";

            foreach (Swimmer swimmer in fosterlings.Values)
            {
                infoResult += "\n\t" + swimmer.Name;
            }

            return infoResult;
        }
    }
}