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
    public partial class FormSwimTracker : Form
    {
        //Huyachim code like a boss
        //Fields, properties and methods below can be moved to dedicated class, but not sure we need it
        ClubsManager clubsManager;
        SwimmersManager swimmerManager;

        private void AddTestClub2ClubManager() // TODO this method should be removed later
        {
            Club aClub = new Club("Club1", new Address("Deliv Adr", "TO", "ON", "777777"), 77555777U);
            clubsManager.Add(aClub);
            UpdateClubView();
        }

        private void AddNewClub()
        {
            ClubEditForm frm = new ClubEditForm();
            frm.clbMng = clubsManager;
            frm.ShowDialog();
            UpdateClubView();
        }

        private void EditClub()
        {
            ClubEditForm frm = new ClubEditForm();

            frm.clbMng = clubsManager;
            frm.club2Edit = (Club)ClubsListView.SelectedItems[0].Tag;
            frm.ShowDialog();
            UpdateClubView();
            UpdateSwimmersView(null);// может сделать отображение измененного номера клуба?
        }

        public FormSwimTracker()
        {
            clubsManager = new ClubsManager();
            swimmerManager = new SwimmersManager(clubsManager);
            InitializeComponent();

            AddTestClub2ClubManager();
        }

        private void UpdateClubView()
        {
            ClubsListView.Items.Clear();

            foreach (Club club in clubsManager.Clubs)
            {
                String[] items = new String[2];
                items[0] = club.ClubNumber.ToString();
                items[1] = club.Name;
                /*ListViewItem*/
                ListViewItem listViewItem = new ListViewItem(items);
                listViewItem.ToolTipText = club.ToString();
                listViewItem.Tag = club;
           
                ClubsListView.Items.Add(listViewItem);
                // MessageBox.Show(club.ToString());
            }

            ClubsListView.Update();// Causes the control to redraw the invalidated regions within its client area.
            ClubsListView.Refresh();// Forces the control to invalidate its client area and immediately redraw itself and any child controls.

        }

        private void ClubsListView_DoubleClick(object sender, EventArgs e)
        {
            EditClub();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClubsListView_Click(object sender, EventArgs e)
        {
            Club club = (Club)ClubsListView.SelectedItems[0].Tag;

            // Later it would be nice to create 2 separate methods
            // ShowClubsCoachesab
            labelCoaches.Text = $"Coaches {club.Name}";


            // ShowClubsSwimmers


            UpdateSwimmersView(club);
            

        }

        private void ClubsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddClub_Click(object sender, EventArgs e)
        {
            AddNewClub();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult clubFile2LoadResult = openFileDialog.ShowDialog();
            if (clubFile2LoadResult == DialogResult.OK)
            {
                //lets make club Manager clear...little bit stupid, but should be ok for this type of application
                //better to ask end-user do he/she really want to replace all records by new set
                clubsManager = new ClubsManager();
                try
                {
                    clubsManager.Load(openFileDialog.FileName, ",");
                }catch(Exception excpt)
                {
                    MessageBox.Show(excpt.Message, "Club loading errors...");
                }
                UpdateClubView();
            }
        }

        private void LoadSwimmers_ShouldThrowException(string fileName)
        {
            //lets make Swimmers Manager clear...little bit stupid, but should be ok for this type of application
            //better to ask end-user do he/she really want to replace all records by new set
            swimmerManager = new SwimmersManager(clubsManager);
            try
            {
                swimmerManager.Load(fileName, ",");
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message, "Swimmers loading errors...");
            }
            UpdateSwimmersView(null);

        }

        private void loadSwimmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult swimmersFile2LoadResult = openFileDialog.ShowDialog();
            if (swimmersFile2LoadResult == DialogResult.OK)
            {
                LoadSwimmers_ShouldThrowException(openFileDialog.FileName);
            }
        }

        private void UpdateSwimmersView(Club club)
        {
            swimmerListView.Items.Clear();

            if(club != null)
            {
                labelSwimmers.Text = $"Swimmers {club.Name}";
            }
            else
            {
                labelSwimmers.Text = "All swimmers";
            }


            foreach (Registrant swimmer in swimmerManager.Swimmers)
            {
                if ((club == null) || (swimmer.Club == club))
                {
                    string[] items = new string[3];
                    items[0] = swimmer.RegistrationNumber.ToString();
                    items[1] = swimmer.Name;
                    if(swimmer.Club == null)
                    {
                        items[2] = "No club assigned";
                    }
                    else
                    {
                        items[2] = swimmer.Club.ClubNumber.ToString();
                    }

                    ListViewItem listViewItem = new ListViewItem(items);
                    listViewItem.ToolTipText = swimmer.ToString();
                    listViewItem.Tag = swimmer;
                    swimmerListView.Items.Add(listViewItem);
                }
                
            }
        }

        private void labelClubs_Click(object sender, EventArgs e)
        {

        }

        private void labelSwimmers_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllSwimmers_Click(object sender, EventArgs e)
        {
            UpdateSwimmersView(null);

        }

        private void buttonAllCoaches_Click(object sender, EventArgs e)
        {
            UpdateClubView();
        }

        private void swimmerListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void Form1_Enter(object sender, EventArgs e)
        //{
        //    // UpdateClubView();
        //}



    }
}
