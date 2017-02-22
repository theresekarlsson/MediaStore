using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MediaStore
{
    public class HandleProduct
    {
        FileHandler FH;
        List<Product> productList = new List<Product>();    /* Produktlista, med de produkter som finns i lager */

        public HandleProduct(FileHandler fh) 
        {
            FH = fh;
            FH.setHPconnection(this);
        }

        /* Returnerar produktlistan. */
        public List<Product> GetProductList() 
        {
            return productList;
        }

        /* Tar emot en string från FileHandler, splittar den och läser in som en ny produkt, lägger till den i produktlistan. */
        public void LoadAllProducts(string line)
        {
            string[] lineData = line.Split(',');
            Product aProduct = new Product();
            aProduct.id = lineData[0];
            aProduct.name = lineData[1];
            aProduct.type = lineData[2];
            aProduct.price = lineData[3];
            aProduct.amount = lineData[4];

            productList.Add(aProduct);
        }

        /* Lägger till ny produkt i produktlistan, och skickar den nya produktens värden till FileHandler för att sparas i fil.
         * Om artikelnumret på den nya produkten redan finns hos en produkt i produktlistan så varnas användaren om detta och 
         * ombeds välja ett annat artikelnummer. */
        public void AddNewProduct(string pid, string pname, string ptype, string pprice) 
        {
            string p_id = pid;
            string p_name = pname;
            string p_type = ptype;
            string p_price = pprice;
            string p_amount = "0";
            Boolean found = false;

            foreach (Product p in productList)
            {
                if (p_id == p.id)
                {
                    found = true;
                }
            }
            if (found)
            {
                throw new Exception("Det här artikelnumret är upptaget, välj ett annat.");
            }
            else
            {
                Product aProduct = new Product();
                aProduct.id = p_id;
                aProduct.name = p_name;
                aProduct.type = p_type;
                aProduct.price = p_price;
                aProduct.amount = p_amount;
                productList.Add(aProduct);

                FH.WriteToFile(productList);
            }
        }

        /* Letar upp produkten i produktlistan med det artikelnummer som matchar den produkt anv. vill ändra antalet på. 
         * Lägger ihop det befintliga antalet med det inmatade och sparar det nya i produktlistan. 
         * Skickar nya listan till FileHandler-klassen */
        public void AddToExistingProduct(string ip_amount, string pid) 
        {
            string selectedId = pid;
            int input_amount = Convert.ToInt32(ip_amount);

            Product productToUpdate = productList.SingleOrDefault(p => p.id == selectedId);

            int old_amount = Convert.ToInt32(productToUpdate.amount);
            int new_amount = input_amount + old_amount;
            productToUpdate.amount = new_amount.ToString();

            FH.WriteToFile(productList);
        }

        /* Tar emot shoppinglista, jämför sedan den och produktlistan och tar bort det antal på
         * en produkt i produktlistan som finns i motsvarande produkt i shoppinglistan. 
         * Skickar uppdaterad lista till FileHandler. */
        public void DeleteFromExistingProduct(List<Product> shoppingList)
        {
            int delete_amount, old_amount, new_amount;
            Product productToDelete;

            foreach (Product toBuy in shoppingList)
            {
                productToDelete = shoppingList.SingleOrDefault(sp => sp.id == toBuy.id);
                delete_amount = Convert.ToInt32(productToDelete.amount);
                Product aProduct = productList.SingleOrDefault(p => p.id == toBuy.id);
                old_amount = Convert.ToInt32(aProduct.amount);
                new_amount = old_amount - delete_amount;
                aProduct.amount = new_amount.ToString();
            }
            FH.WriteToFile(productList);
        }

        /* Letar upp produkt i produktlistan och tar bort den. 
        * Skickar uppdaterad lista till FileHandler. */
        public void DeleteProduct(string pid)
        {
            string selectedId = pid;
            Product productToDelete = productList.SingleOrDefault(p => p.id == selectedId);
            productList.Remove(productToDelete);
            FH.WriteToFile(productList);
        }
    }
}
