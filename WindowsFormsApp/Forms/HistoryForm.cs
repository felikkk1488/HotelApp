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

namespace WindowsFormsApp.Forms
{
    public partial class HistoryForm : Form
    {
        private Guest _guest;
        public HistoryForm(Guest guest)
        {
            InitializeComponent();
            _guest = guest;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            roomBindingSource.DataSource = Program.context.Rooms.ToList(); 

            historyBindingSource.DataSource = Program.context.Histories
                .Where(h => h.GuestId == _guest.IdGuest)
                .ToList();
        }
    }
}
