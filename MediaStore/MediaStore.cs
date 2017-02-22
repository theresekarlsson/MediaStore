using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MediaStore
{
    public partial class View : Form
    {
        FileHandler FH;
        HandleProduct HP;
        ShoppingCart SC;

        public View(FileHandler fh, HandleProduct hp, ShoppingCart sc)
        {
            FH = fh;
            HP = hp;
            SC = sc;

            InitializeComponent();
            FH.ReadFromFile();

            myPLbindingSource.DataSource = HP.GetProductList();
            dgvInventory.DataSource = myPLbindingSource;
            dgvCheckout.DataSource = myPLbindingSource;

            dgvShoppingCart.DataSource = SC.GetShoppingList();
        }

        /* Sparar värdena till ny produkt som matats in i Lagervyn, skickar till HandleProduct-klassen */
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            string p_id = txtboxProductID1.Text;
            string p_name = txtboxProductName1.Text;
            string p_type = cboboxProductType1.Text;
            string p_price = txtboxProductPrice.Text;
            double Num;
            bool isNumId = double.TryParse(p_id, out Num);
            bool isNumPrice = double.TryParse(p_price, out Num);

            try
            {
                // Kollar så att inget textfält är tomt.
                if (String.IsNullOrEmpty(p_id) || String.IsNullOrEmpty(p_name) || String.IsNullOrEmpty(p_type) || String.IsNullOrEmpty(p_price))
                {
                    throw new Exception("Du måste fylla i all information när du ska lägga till en produkt.");
                }
                // Kollar så att inmatat artikelnummer och pris består av siffror
                if (!isNumId || !isNumPrice)
                {
                    throw new Exception("Du kan bara ange artikelnummer och pris i siffror.");
                }
                // Kollar så artikelnummer och pris inte är lägre än 1
                if (Convert.ToInt32(p_id) < 1 || Convert.ToInt32(p_price) < 1)
                {
                    throw new Exception("Artikelnummer och pris måste anges med positiva tal.");
                }
                else
                {
                    HP.AddNewProduct(p_id, p_name, p_type, p_price);
                    UpdateCheckoutAndInventoryDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }

        // Ändrar antal av en produkt i Lagervyn till inmatat värde + det gamla antalet. Skickar till HandleProduct-klassen.
        private void btnAddToProduct_Click(object sender, EventArgs e)
        {
            string input_amount = txtboxProductAmount.Text;
            string p_id = txtboxProductID2.Text;
            int num;  
            bool isNumInputAmount = int.TryParse(input_amount, out num);

            try
            {
                if (String.IsNullOrEmpty(p_id))
                {
                    throw new Exception("Du måste välja en produkt där en leverans ska läggas till.");
                }
                 if(String.IsNullOrEmpty(input_amount))
                {
                    throw new Exception("Du måste ange antal produkter du vill lägga till.");
                }
                if (!isNumInputAmount || Convert.ToInt32(input_amount) < 1)
                {
                    throw new FormatException("Du kan bara ange antal med ett positivt heltal.");
                }
                else
                {
                    foreach (DataGridViewRow datarow in dgvInventory.SelectedRows)
                    {
                        HP.AddToExistingProduct(input_amount, p_id);
                    }
                    UpdateCheckoutAndInventoryDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Tar bort den produkt man valt från Lagervyn. */
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string p_input = txtboxDeleteProduct.Text;
            string p_id = String.Empty;
            string p_amount = String.Empty;

            try
            {
                if (String.IsNullOrEmpty(p_input))
                {
                    throw new Exception("Du måste välja en produkt att ta bort.");
                }
                else
                {
                    foreach (DataGridViewRow datarow in dgvCheckout.SelectedRows)
                    {
                        p_id = datarow.Cells["id"].Value.ToString();
                        p_amount = datarow.Cells["amount"].Value.ToString();
                    }
                    
                    if (Convert.ToInt32(p_amount) != 0)
                    {
                        string message = "Det finns fortfarande " + p_amount + " varor kvar av den här produkten.\nÄr du säker på att du vill ta bort den?";
                        const string caption = "Ta bort produkt?";

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            HP.DeleteProduct(p_id);
                            UpdateCheckoutAndInventoryDGV();
                        }
                    }
                    else
                    {
                        HP.DeleteProduct(p_id);
                        UpdateCheckoutAndInventoryDGV();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Rensar textrutorna i 'Lägg till produkt'-rutan. */
        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtboxProductID1.Clear();
            txtboxProductName1.Clear();
            cboboxProductType1.Text = null;
            txtboxProductPrice.Clear();
        }

        /* Rensar textrutorna i 'Lägg till leverans av produkt'-rutan. */
        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtboxProductID2.Clear();
            txtboxProductName2.Clear();
            txtboxProductType2.Clear();
            txtboxProductAmount.Clear();
        }

        /* Anropas när något förändrats i produktlistan så vyerna där denna visas uppdateas. */
        private void UpdateCheckoutAndInventoryDGV()
        {
            dgvInventory.DataSource = null;
            dgvCheckout.DataSource = null;
            myPLbindingSource.DataSource = HP.GetProductList();
            dgvInventory.DataSource = myPLbindingSource;
            dgvCheckout.DataSource = myPLbindingSource;
        }

        /* Anropas när något förändrats i shoppinglistan så varukorgen där denna visas uppdateas. */
        private void UpdateShoppingCartDGV()
        {
            dgvShoppingCart.DataSource = null;
            mySLbindingSource.DataSource = SC.GetShoppingList();
            dgvShoppingCart.DataSource = mySLbindingSource;
        }

        /* Hämtar värdena från den markerade raden i Lagervyn. */
        private void SelectRowInInventory(object sender, EventArgs e)
        {
            foreach (DataGridViewRow datarow in dgvInventory.SelectedRows)
            {
                string p_id = datarow.Cells["id"].Value.ToString();
                string p_name = datarow.Cells["name"].Value.ToString();
                string p_type = datarow.Cells["type"].Value.ToString();
                string p_amount = datarow.Cells["amount"].Value.ToString();

                txtboxProductID2.Text = p_id;
                txtboxProductName2.Text = p_name;
                txtboxProductType2.Text = p_type;
                txtboxDeleteProduct.Text = ("Art.nr: " + p_id) + " , '" + p_name + "' . " + p_type + " . Antal: " + p_amount;
            }
        }

        /* Lägger till produkt i Varukorgen. Skickar produktens properties till ShoppingCart-klassen */
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow datarow in dgvCheckout.SelectedRows)
            {
                string p_id = datarow.Cells["id"].Value.ToString();
                string p_name = datarow.Cells["name"].Value.ToString();
                string p_type = datarow.Cells["type"].Value.ToString();
                string p_price = datarow.Cells["price"].Value.ToString();
                string p_amount = datarow.Cells["amount"].Value.ToString();
                try
                {
                    SC.AddToShoppingCart(p_id, p_name, p_type, p_price, p_amount);
                    UpdateShoppingCartDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /* Ökar antal på vald produkt i varukorgen med 1 via anrop till ShoppingCart-klassen */
        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow datarow in dgvShoppingCart.SelectedRows)
                {
                    string sp_id = datarow.Cells["id"].Value.ToString();
                    SC.PlusOneInShoppingCart(sp_id);
                    UpdateShoppingCartDGV();
                }
                // Här är jag nu! Jämför dgv:erna och hämta gamla antalet för att kolla att nya antalet inte blir mer!
            }        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Minskar antal på vald produkt i varukorgen med 1 via anrop till ShoppingCart-klassen. */
        private void btnMinusOne_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow datarow in dgvShoppingCart.SelectedRows)
                {
                    string sp_id = datarow.Cells["id"].Value.ToString();    
                    SC.MinusOneInShoppingCart(sp_id);
                    UpdateShoppingCartDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Sparar id på den valda produkten i varukorgen, skickar till ShoppingCart-klassen. 
         * Uppdaterar Varukorgsvyn och tömmer textrutorna ovanför varukorgen. */
        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow datarow in dgvCheckout.SelectedRows)
            {
                string sp_id = datarow.Cells["id"].Value.ToString();
                SC.DeleteFromCart(sp_id);
            }
            UpdateShoppingCartDGV();
        }

        /* Tar bort alla varor i Varukorgs-vyn */
        private void btnDeleteAllFromCart_Click(object sender, EventArgs e)
        {
            SC.DeleteAllFromCart();
            UpdateShoppingCartDGV();
        }
        /* Anropar ShoppingCart-klassen för genomförande av köp, tömmer varukorgen på varor. */
        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                SC.CompletePurchase();

                SC.DeleteAllFromCart();
                UpdateShoppingCartDGV();
                UpdateCheckoutAndInventoryDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}