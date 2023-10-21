using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoices
    {
        public int Invoice_id { get; set; }
        public int Customer_id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }
    }
}

/*
 CREATE TABLE invoices (
    invoice_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT,
    date DATETIME NOT NULL,
    total DECIMAL(10, 2) NOT NULL,
    active BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);
 */