using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace m_6
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("GoodsID")]
        public Goods Goods { get; set; }
        public int GoodsID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public int Amount { get; set; }
    }
}
