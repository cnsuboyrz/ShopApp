﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.entity
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }
    }
}
