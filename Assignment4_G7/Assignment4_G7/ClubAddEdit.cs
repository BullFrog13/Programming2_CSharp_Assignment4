using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimLibrary;

namespace TNurislamova_301025614_A4
{
    public partial class ClubEditForm : Form
    {
        public Club club2Edit;
        public ClubsManager clbMng;

        public ClubEditForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (club2Edit == null)
            {
                this.Text = "Add New Club";
            }
            else
            {
                textBoxClubNumber.Text = club2Edit.ClubNumber.ToString();
                textBoxClubName.Text = club2Edit.Name;
                textBoxClubDeliveryAddress.Text = club2Edit.Address.DeliveryAddress;
                textBoxClubMunicipality.Text = club2Edit.Address.Municipality;
                textBoxClubProvince.Text = club2Edit.Address.Province;
                textBoxClubPostalCode.Text = club2Edit.Address.PostalCode;
                textBoxClubPhoneNumber.Text = club2Edit.PhoneNumber.ToString();
            }
        }

        private void textBoxClubNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveClub_Click(object sender, EventArgs e)
        {
            if(club2Edit == null)
            {
                club2Edit = new Club();
                clbMng.Add(club2Edit);
            }

            club2Edit.Name = textBoxClubName.Text;
            club2Edit.PhoneNumber = uint.Parse(textBoxClubPhoneNumber.Text);
            Address address = new Address(textBoxClubDeliveryAddress.Text, textBoxClubMunicipality.Text, textBoxClubProvince.Text, textBoxClubPostalCode.Text);
            club2Edit.Address = address;

            // add Address here

            

            this.Close();

        }

        private void textBoxClubPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if(!uint.TryParse(textBoxClubPhoneNumber.Text, out uint x))
            {
                MessageBox.Show("Phone Number must be an integer");
                e.Cancel = true;
                
            }
        }

        private void buttonCancelClub_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}