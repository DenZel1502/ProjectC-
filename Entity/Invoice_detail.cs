using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice_detail
    {
        public int Detail_id { get; set; }
        public int Invoice_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public bool Active { get; set; }

    }
}

/*
 CREATE TABLE invoice_details (
    detail_id INT PRIMARY KEY IDENTITY(1,1),
    invoice_id INT,
    product_id INT,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    active BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (invoice_id) REFERENCES invoices(invoice_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);
*/
