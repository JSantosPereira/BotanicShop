using BotanicShop.Areas.Identity.Data;
using BotanicShop.Models;

namespace BotanicShop
{
    public class Purchase
    {
        // ###############################################################################################################

        static int SalesNr = 1;
        public String ID { get; set; }
        public DateTime timeofpurchase { get; set; }

        public string UserID { get; set; }
        public string UserName  {get; set;}

        public ICollection<Product> Items { get; set; }


        // ###############################################################################################################
        public Purchase(User user,ICollection<Product> products)
        {
            this.UserID = user.Id ?? "";
            this.UserName = user.UserName ?? "";
            this.Items= products;
            this.ID = DateTime.Now.Year+"-"+SalesNr++;
            this.timeofpurchase = DateTime.Now;
        }

        // ###############################################################################################################
        public string toString(){
            return "Purchase toString() To be implemented";
        }
    }
}
