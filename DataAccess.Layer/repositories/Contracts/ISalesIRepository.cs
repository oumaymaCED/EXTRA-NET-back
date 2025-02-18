﻿using DataAccess.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.repositories.Contracts
{
    public interface ISalesIRepository
    {
        SalesInvoice GetSalesInvoiceById(Guid ClientID);

        List<SalesInvoice> GetAllSalesInvoices(Guid ClientID); 
    }
}
