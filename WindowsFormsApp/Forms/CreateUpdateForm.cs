using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class CreateUpdateForm : Form
    {
        private Guest _guest;
        public CreateUpdateForm()
        {
            InitializeComponent();
            _guest = new Guest();
        }

        public CreateUpdateForm(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
        }

        private void FillForm(Guest guest)
        {
            fullNameTextBox.Text = guest.FullName;
            birthdayDateTimePicker.Value = guest.Birthday;
            genderIdComboBox.SelectedValue = guest.GenderId;
            statusIdComboBox.SelectedValue = guest.StatusId;
        }
        
        private void Save()
        {
            if (_guest.IsNew())
            {
                Program.context.Guests.Add(_guest);
            }

            Program.context.SaveChanges();
        }

        private void CloseForm()
        {
            DialogResult = DialogResult.OK;
        }
            
        private void FillModel()
        {
            _guest.FullName = fullNameTextBox.Text;
            _guest.Birthday = birthdayDateTimePicker.Value;
            _guest.GenderId = (int)genderIdComboBox.SelectedValue;
            _guest.StatusId = (int)statusIdComboBox.SelectedValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FillModel();
            Save();
            CloseForm();
        }

        private void CreateUpdateForm_Load(object sender, EventArgs e)
        {
            genderBindingSource.DataSource = Program.context.Genders.ToList();
            statusBindingSource.DataSource = Program.context.Status.ToList();

            if (!_guest.IsNew())
                FillForm(_guest);
        }
    }
}
