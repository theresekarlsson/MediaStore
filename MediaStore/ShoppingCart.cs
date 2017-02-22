using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace MediaStore
{
    public class ShoppingCart
    {
        HandleProduct HP;
        List<Product> shoppingList = new List<Product>();   /* Shoppinglistan, med de produkter som lagts i varukorgen. */
        
        public ShoppingCart(HandleProduct hp)
        {
            HP = hp;
        }

        /* Returnerar shoppinglistan. */
        public List<Product> GetShoppingList()
        {
            return shoppingList;
        }

        /* Lägger till produkt i shoppinglistan och därmed varukorgen. Kollar så ingen vara med samma artikelnummer redan
         * lagts till. Kollar så antalet varor i lager på den produkten inte är färre än 1. */
        public void AddToShoppingCart(string pid, string pname, string ptype, string pprice, string pamount)
        {
            string p_id = pid;
            string p_name = pname;
            string p_type = ptype;
            string p_price = pprice;
            string check_amount = pamount;
            Boolean found = false;

            foreach (Product p in shoppingList)
            {
                if (p_id == p.id)
                {
                    found = true;
                }
            }
            if (found)
            {
                throw new Exception("Du kan inte lägga till samma produkt fler gånger.\nAnvänd knapparna med - och + om du vill ändra antalet på en produkt.");
            }
            
            if (Convert.ToInt32(check_amount) < 1)
            {
                throw new Exception("Den här produkten har vi inte på lager.");
            }
            else
            {
                Product aShopProduct = new Product();
                aShopProduct.id = p_id;
                aShopProduct.name = p_name;
                aShopProduct.type = p_type;
                aShopProduct.price = p_price;
                aShopProduct.amount = "1";

                shoppingList.Add(aShopProduct);
            }
        }
        /* Ökar antalet av en vara i shoppinglistan med 1. Kollar så inte antalet överstiger det antal som finns i lager. */
        public void PlusOneInShoppingCart(string spid)
        {
            string selectedId = spid;
            int input_amount = 1;
            int check_amount = 0;

            foreach (Product prod in HP.GetProductList())
            {
                if (prod.id == selectedId)
                {
                    check_amount = Convert.ToInt32(prod.amount);
                }
            }
            Product productToUpdate = shoppingList.SingleOrDefault(p => p.id == selectedId);
            int old_amount = Convert.ToInt32(productToUpdate.amount);
            int new_amount = old_amount + input_amount;

            if (new_amount > check_amount)
            {
                throw new Exception("Det finns inte fler av den här produkten.");
            }
            else
            {
                productToUpdate.amount = new_amount.ToString();
            }
        }

        /* Minskar antalet av en vara i shoppinglistan med 1. Kollar så inte antalet blir mindre än 1. */
        public void MinusOneInShoppingCart(string spid)
        {
            string selectedId = spid;
            int input_amount = 1;
            Product productToUpdate = shoppingList.SingleOrDefault(p => p.id == selectedId);
            int old_amount = Convert.ToInt32(productToUpdate.amount);

            if (old_amount <= 1)
            {
                throw new Exception("Klicka på 'Ta Bort' istället om du vill ta bort en produkt från Varukorgen.");
            }
            else
            {
                int new_amount = old_amount - input_amount;
                productToUpdate.amount = new_amount.ToString();
                Console.WriteLine("Nya antalet: " + productToUpdate.amount);
            }
        }

        /* Kollar så inte varukorgen är tom. Skickar lista till HandleProduct-klassen. */
        public void CompletePurchase()
        {
            if (shoppingList.Count == 0)
            {
                throw new Exception("Varukorgen är tom.");
            }
            else
            {
                HP.DeleteFromExistingProduct(shoppingList);
            }
        }

        /* Letar upp produkt i shoppinglistan och tar bort den. */
        public void DeleteFromCart(string spid)
        {
            string selectedId = spid;
            Product productToDelete = shoppingList.SingleOrDefault(p => p.id == selectedId);
            shoppingList.Remove(productToDelete);
        }

        /* Tömmer shoppinglistan. */
        public void DeleteAllFromCart()
        {
            shoppingList.Clear();
        }
    }
}
