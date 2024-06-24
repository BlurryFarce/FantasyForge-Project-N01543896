using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyForge_N01543896.Models.ViewModels {
    public class DetailsMediaItem {
        
        public MediaItemDto SelectedMediaItem { get; set; }

        //all of the related users to that particular media item
        public IEnumerable<UserDto> RelatedUsers { get; set; }

        public IEnumerable<UserMediaItemDto> RelatedUserLists { get; set; }
    }
}