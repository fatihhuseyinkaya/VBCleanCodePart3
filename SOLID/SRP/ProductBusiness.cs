using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
   public class ProductBusiness
    {
        public int UrunEkle(string urunAdi, decimal fiyat)
        {
            string connectionString = @"Data Source=(localdb)\MssqlLocaldb;Initial Catalog=sampleDb;Integrated Security=True;Pooling=False";
            string commandText = "INSERT into Products (Ad,Fiyat) values (@ad,@fiyat)";

            Dictionary<string, object> commandParameters = new Dictionary<string, object>();
            commandParameters.Add("@ad", urunAdi);
            commandParameters.Add("@fiyat", fiyat);

            DbHelper dbHelper = new DbHelper(connectionString);
            int affectedRow = dbHelper.ExecuteCommand(commandText, commandParameters);

            return affectedRow;

          
        }
    }
}
