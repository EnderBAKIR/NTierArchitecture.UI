using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public List<CardItem> CardItems { get; set; } = new List<CardItem>();


        public void AddItem(CardItem item)
        {
            var p = CardItems.FirstOrDefault(x => x.ProductID == item.ProductID);
            if (p != null)
            {
                p.Quantity += item.Quantity;
            }
            else
            {
                CardItems.Add(item);
            }
        }

        public void DeleteItem(Guid cardItemID)
        {
            var p = CardItems.FirstOrDefault(x => x.CardItemID == cardItemID);

            if (p != null)
            {
                p.Quantity -= 1;


                if (p.Quantity == 0)
                {
                    CardItems.Remove(p);
                }
            }
        }
    }
}
