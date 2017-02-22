using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MediaStore
{
    public class FileHandler
    {
        HandleProduct HP;
        string fileName = "InventoryFile.txt";  // Namn på fil dit datan sparas.

        public void setHPconnection(HandleProduct hp)
        {
            HP = hp;
        }

        /* Läser in data från fil. */
        public void ReadFromFile() 
        {
            StreamReader reader = new StreamReader(fileName);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                HP.LoadAllProducts(line); 
            }
            reader.Close();
        }

        /* Skriver data till fil. */
        public void WriteToFile(List<Product> productList)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (Product p in productList)
                {
                    writer.WriteLine(String.Join(",", p.id, p.name, p.type, p.price, p.amount));
                }
                writer.Close();
            }
        }
    }
}
