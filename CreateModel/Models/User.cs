using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateModel.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; } // bool veri türü ,true/false gibi iki seçenekli verileri tutmamıza yarar.
        public DateTime EntryDate { get; set; } // DateTime , gün/ay/yıl/saat şeklinde verileri tutar.
    }
}