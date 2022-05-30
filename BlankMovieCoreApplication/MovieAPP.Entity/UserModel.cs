  using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;//for model validations
using System.ComponentModel.DataAnnotations.Schema;//for sql constraints

namespace MovieAPP.Entity
{
     public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Mobile { get; set; }

    }
}
