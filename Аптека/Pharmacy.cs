using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аптека
{
    public partial class Pharmacy : Form
    {
        public Pharmacy()
        {
            InitializeComponent();
            ShowPharmacy();
        }

        void ShowPharmacy()
        {
            listViewPharmacy.Items.Clear();
            foreach (PharmacySet pharmacy in Program.pharmacy.PharmacySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pharmacy.ID.ToString(), pharmacy.Name, pharmacy.Address, pharmacy.Phone, pharmacy.OpenHourse
                });

                item.Tag = pharmacy;

                listViewPharmacy.Items.Add(item);
            }
            listViewPharmacy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {

        }

        private void listViewPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
                textBoxName.Text = pharmacy.Name;
                textBoxAddress.Text = pharmacy.Address;
                textBoxPhone.Text = pharmacy.Phone;
                textBoxOpenHours.Text = pharmacy.OpenHourse;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxOpenHours.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PharmacySet pharmacy = new PharmacySet();
            pharmacy.Name = textBoxName.Text;
            pharmacy.Address = textBoxAddress.Text;
            pharmacy.Phone = textBoxPhone.Text;
            pharmacy.OpenHourse = textBoxOpenHours.Text;
            Program.pharmacy.PharmacySet.Add(pharmacy);
            Program.pharmacy.SaveChanges();
            ShowPharmacy();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
            pharmacy.Name = textBoxName.Text;
            pharmacy.Address = textBoxAddress.Text;
            pharmacy.Phone = textBoxPhone.Text;
            pharmacy.OpenHourse = textBoxOpenHours.Text;
            Program.pharmacy.SaveChanges();
            ShowPharmacy();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharmacy.SelectedItems.Count == 1)
                {
                    PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
                    Program.pharmacy.PharmacySet.Remove(pharmacy);
                    Program.pharmacy.SaveChanges();
                    ShowPharmacy();
                }
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxOpenHours.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
