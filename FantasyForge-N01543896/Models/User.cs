﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyForge_N01543896.Models {
    public class User {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Bio { get; set; }

        public string FavoriteGenre { get; set; }

        public DateTime JoinDate { get; set; }

        public string Location { get; set; }

        //data needed for keeping track of user profile images uploaded
        //images deposited into /Content/Images/Users/{id}.{extension}
        public bool UserHasPic { get; set; }
        public string PicExtension { get; set; }
        public virtual ICollection<UserMediaItem> UserMediaItems { get; set; }
    }

    public class UserDto {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Bio { get; set; }

        public string FavoriteGenre { get; set; }

        public DateTime JoinDate { get; set; }

        public string Location { get; set; }

        //data needed for keeping track of user profile images uploaded
        //images deposited into /Content/Images/Users/{id}.{extension}
        public bool UserHasPic { get; set; }
        public string PicExtension { get; set; }
    }
}