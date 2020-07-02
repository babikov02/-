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
    public partial class Availability : Form
    {
        public Availability()
        {
            InitializeComponent();
            ShowPharmacy();
            ShowMedicine();
            ShowAvailability();
        }

        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (AvailabilitySet availability in Program.pharmacy.AvailabilitySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availability.ID.ToString(),
                    availability.IdPharmacy.ToString() + ". " + availability.PharmacySet.Name,
                    availability.IdMedicine.ToString() + ". " + availability.MedicineSet.Name,
                    availability.Amount.ToString(), availability.Price.ToString()
                });
                item.Tag = availability;
                listViewAvailability.Items.Add(item);
            }
        }

        void ShowMedicine()
        {
            comboBoxMedicine.Items.Clear();
            foreach(MedicineSet medicine in Program.pharmacy.MedicineSet)
            {
                string[] item = { medicine.ID.ToString() + ". ", medicine.Name };
                comboBoxMedicine.Items.Add(string.Join(" ", item));
            }
        }
        void ShowPharmacy()
        {
            comboBoxPharmacy.Items.Clear();
            foreach (PharmacySet pharmacy in Program.pharmacy.PharmacySet)
            {
                string[] item = { pharmacy.ID.ToString() + ". ", pharmacy.Name };
                comboBoxPharmacy.Items.Add(string.Join(" ", item));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                AvailabilitySet availability = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                comboBoxPharmacy.SelectedIndex = comboBoxPharmacy.FindString(availability.IdPharmacy.ToString());
                comboBoxMedicine.SelectedIndex = comboBoxMedicine.FindString(availability.IdMedicine.ToString());
                textBoxAmount.Text = availability.Amount.ToString();
                textBoxPrice.Text = availability.Price.ToString();

            }
            else
            {
                comboBoxPharmacy.SelectedItem = null;
                comboBoxMedicine.SelectedItem = null;
                textBoxAmount.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void Availability_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicine.SelectedItem != null && comboBoxPharmacy.SelectedItem != null && textBoxAmount.Text != null && textBoxPrice.Text != null)
            {
                AvailabilitySet availability = new AvailabilitySet();
                availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
                availability.IdMedicine = Convert.ToInt32(comboBoxMedicine.SelectedItem.ToString().Split('.')[0]);
                availability.Amount = Convert.ToInt32(textBoxAmount.Text);
                availability.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.pharmacy.AvailabilitySet.Add(availability);
                Program.pharmacy.SaveChanges();
                ShowAvailability();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                AvailabilitySet availability = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
                availability.IdMedicine = Convert.ToInt32(comboBoxMedicine.SelectedItem.ToString().Split('.')[0]);
                availability.Amount = Convert.ToInt32(textBoxAmount.Text);
                availability.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.pharmacy.SaveChanges();
                ShowAvailability();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    AvailabilitySet availability = listViewAvailability.SelectedItems[0].Tag as AvailabilitySet;
                    Program.pharmacy.AvailabilitySet.Remove(availability);
                    Program.pharmacy.SaveChanges();
                    ShowAvailability();
                }
                comboBoxPharmacy.SelectedItem = null;
                comboBoxMedicine.SelectedItem = null;
                textBoxAmount.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
                char number = e.KeyChar;
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
