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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
            ShowMedicine();
            
        }

        void ShowMedicine()
        {
            listViewMedicine.Items.Clear();
            foreach (MedicineSet medicine in Program.pharmacy.MedicineSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    medicine.ID.ToString(), medicine.Name, medicine.ReleaseForm, medicine.Dosage, 
                    medicine.Manufacturer, medicine.ShelfLife
                    
                });

                item.Tag = medicine;

               listViewMedicine.Items.Add(item);
            }
           listViewMedicine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        
        private void Medicine_Load(object sender, EventArgs e)
        {

        }

        private void listViewMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedicine.SelectedItems.Count == 1)
            {
                
                MedicineSet medicine = listViewMedicine.SelectedItems[0].Tag as MedicineSet;
                
                textBoxName.Text = medicine.Name;
                comboBoxReleaseForm.Text = medicine.ReleaseForm;
                textBoxDosage.Text = medicine.Dosage;
                textBoxManufacturer.Text = medicine.Manufacturer;
                textBoxShelfLife.Text = medicine.ShelfLife;
                
            }
            else
            {
                textBoxName.Text = "";
                comboBoxReleaseForm.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxShelfLife.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MedicineSet medicine = new MedicineSet();
            medicine.Name = textBoxName.Text;
            medicine.ReleaseForm = comboBoxReleaseForm.Text;
            medicine.Dosage = textBoxDosage.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.ShelfLife = textBoxShelfLife.Text;
            Program.pharmacy.MedicineSet.Add(medicine);
            Program.pharmacy.SaveChanges();
            ShowMedicine();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MedicineSet medicine = listViewMedicine.SelectedItems[0].Tag as MedicineSet;
            medicine.Name = textBoxName.Text;
            medicine.ReleaseForm = comboBoxReleaseForm.Text;
            medicine.Dosage = textBoxDosage.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.ShelfLife = textBoxShelfLife.Text;
            Program.pharmacy.SaveChanges();
            ShowMedicine();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMedicine.SelectedItems.Count == 1)
                {
                    MedicineSet medicine = listViewMedicine.SelectedItems[0].Tag as MedicineSet;
                    Program.pharmacy.MedicineSet.Remove(medicine);
                    Program.pharmacy.SaveChanges();
                    ShowMedicine();
                }
                textBoxName.Text = "";
                comboBoxReleaseForm.Text = "";
                textBoxDosage.Text = "";
                textBoxManufacturer.Text = "";
                textBoxShelfLife.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
