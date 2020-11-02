using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace m_6
{
    public class Customer
    {
       
            [Key]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
        
    }
}
