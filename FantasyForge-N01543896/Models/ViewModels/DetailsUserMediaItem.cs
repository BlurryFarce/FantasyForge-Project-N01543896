using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyForge_N01543896.Models.ViewModels
{
    public class DetailsUserMediaItem
    {
        public UserMediaItemDto UserMediaItem { get; set; }
        public IEnumerable<UserDto> Users { get; set; }
        public IEnumerable<MediaItemDto> MediaItems { get; set; }
    }
}