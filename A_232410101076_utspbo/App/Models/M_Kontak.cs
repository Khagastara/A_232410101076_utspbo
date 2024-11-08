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
    public class M_Kontak
    {
        [Key]
        public int idKontak { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int NoHP { get; set; }
    }
}
