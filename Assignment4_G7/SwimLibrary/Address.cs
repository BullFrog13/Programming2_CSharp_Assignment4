using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 
 * Structure Address holds
 * addresses of the clubs and registrants
 */

namespace SwimLibrary
{
    public struct Address
    {
        public String DeliveryAddress;
        public String Municipality;
        public String Province;
        public String PostalCode;

        public Address(String deliveryAddress, String municipality, String province, String postalCode)
        {
            DeliveryAddress = deliveryAddress;
            Municipality = municipality;
            Province = province;
            PostalCode = postalCode;
        }


        public String GetWriteToFileInfo(char delim)
        {
            StringBuilder strBld = new StringBuilder();
            strBld.Append(DeliveryAddress + delim);
            strBld.Append(Municipality + delim);
            strBld.Append(Province + delim);
            strBld.Append(PostalCode);

            return strBld.ToString();
        }

        public override string ToString()
        {
            String indentationAndFormat = "\n\t{0}";
            StringBuilder strBld = new StringBuilder("Adress:");

            strBld.Append(String.Format(indentationAndFormat, DeliveryAddress));
            strBld.Append(String.Format(indentationAndFormat, Municipality));
            strBld.Append(String.Format(indentationAndFormat, Province));
            strBld.Append(String.Format(indentationAndFormat, PostalCode));

            return strBld.ToString();
        }
    }
}