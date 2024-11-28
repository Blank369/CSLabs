using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal interface IExpired
    {
        DateTime ExpirationDate {  get; set; }
        int GetExpireDays();
        
    }
}
