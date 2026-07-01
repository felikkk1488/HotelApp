using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controls;

namespace WindowsFormsApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshPanel();
        }

        private void ShowGuests()
        {
            List<Guest> guests = Program.context.Guests.ToList();
            foreach (Guest guest in guests)
            {
                flowLayoutPanel.Controls.Add(new GuestUserControl(guest));
            }
        }

        private void newGuestButton_Click(object sender, EventArgs e)
        {
            CreateUpdateForm createUpdateForm = new CreateUpdateForm();
            DialogResult saved = createUpdateForm.ShowDialog();

            if (saved == DialogResult.OK)
                RefreshPanel();
        }

        public void RefreshPanel()
        {
            Clear();
            ShowGuests();
        }

        public void Clear()
        { 
            flowLayoutPanel.Controls.Clear(); 
        }
    }
}
