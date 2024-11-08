using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace A_232410101076_utspbo.App.Models
{
    public class M_AkunAdmin
    {
        [Key]
        public int id_admin { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public M_AkunAdmin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
