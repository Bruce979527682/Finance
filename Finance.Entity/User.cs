using System;
using System.ComponentModel.DataAnnotations;

namespace Finance.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string UserName { get; set; }

        [Required, StringLength(30)]
        public string Password { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public string HeadImg { get; set; }

        public DateTime LoginTime { get; set; }

        public string Ip { get; set; }

        public int LoginError { get; set; }
    }
}
