using Jectory.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JectoryLibrary
{
    public class Item : Record<Item>
    {
        [PrimaryKey]
        [MaxLength(20)]
        public string No { get; set; }
        public DateTime PurchasedAt { get; set; }

    }
}
