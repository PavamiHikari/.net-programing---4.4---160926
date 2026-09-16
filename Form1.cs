using System;
using System.Windows.Forms;

namespace _4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void LoadMenu()
        {
            lstMenu.Items.Add(new FoodItem { Name = "Hamburger", Price = 50 });
            lstMenu.Items.Add(new FoodItem { Name = "Pizza", Price = 120 });
            lstMenu.Items.Add(new FoodItem { Name = "Gà Rán", Price = 35 });
            lstMenu.Items.Add(new FoodItem { Name = "Pepsi", Price = 15 });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                UpdateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            int total = 0;
            foreach (FoodItem item in lstSelected.Items)
            {
                total += item.Price;
            }
            lblTotal.Text = $"Tổng tiền: {total}k";
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Price}k";
        }
    }
}
