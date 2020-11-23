using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModals
{
    class DepolarVM
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int FirmalarID { get; set; }
        public int PageCount { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
