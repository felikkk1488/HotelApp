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
using WindowsFormsApp.Forms;

namespace WindowsFormsApp.Controls
{
    public partial class GuestUserControl : UserControl
    {
        private Guest _guest;
        public GuestUserControl(Guest guest)
        {
            InitializeComponent();
            ShowGuest(guest);
            _guest = guest;
        }

        private void ShowGuest(Guest guest)
        {
            fio.Text = "ФИО: " + guest.FullName;
            gender.Text = "Пол: " + guest.Gender.GenderName;
            count.Text = "Сколько раз останавливался: " + guest.Histories.Count;
            birthday.Text = "Дата рождения: " + guest.Birthday.ToShortDateString();
            status.Text = "Статус: " + guest.Status.StatusName;
        }

        private void GuestUserControl_Click(object sender, EventArgs e)
        {
            CreateUpdateForm createUpdateForm = new CreateUpdateForm(_guest);
            DialogResult saved = createUpdateForm.ShowDialog();
            
            if (saved == DialogResult.OK)
            {
                ((MainForm)this.Parent.Parent.Parent.Parent).RefreshPanel();
            }    
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_guest);
            historyForm.ShowDialog();
        }
    }
}
