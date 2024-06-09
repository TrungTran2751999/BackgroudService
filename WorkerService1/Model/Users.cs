using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    [Table("user")]
    public class  Users
    {
        public long? id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string deviceToken { get; set; }
    }
}
