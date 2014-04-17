﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    [Table(Name="ArtistAlbum")]
    public class ArtistAlbum
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ArtistAlbumId { get; set; }
        [Column]
        public int UserId { get; set; }
        [Column]
        public int AlbumId { get; set; }
    }
}
