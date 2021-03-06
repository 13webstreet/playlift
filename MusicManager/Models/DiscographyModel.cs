﻿using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebService;

namespace MusicManager.Models
{
    public class ArtistAlbumModel
    {
        public int AlbumId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime AlbumReleaseDate { get; set; }

        [Display(Name = "Title")]
        public string AlbumTitle { get; set; }

        [Display(Name = "Producer")]
        public string AlbumProducer { get; set; }

        [Display(Name = "Label")]
        public string AlbumLabel { get; set; }

        [Display(Name = "Album Cover")]
        public HttpPostedFileBase AlbumCover { get; set; }

        [Display(Name = "Album Cover Image")]
        public string AlbumCoverPath { get; set; }

        [Display(Name = "Genres")]
        public IEnumerable<Genre> GenreCollection { get; set; }

        public IEnumerable<Genre> GenreList
        {
            get
            {
                var WCFWebServiceJson = new WebService.WCFWebServiceJson();
                return WCFWebServiceJson.GetAllGenres();
            }
        }
    }

    public class ArtistSongModel
    {
        public int SongId { get; set; }
        public int AlbumId { get; set; }
        public string AlbumCover { get; set; }
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }

        [Display(Name = "Release Date")]
        public DateTime SongReleaseDate { get; set; }

        [Display(Name = "Title")]
        public string SongTitle { get; set; }

        [Display(Name = "Composer")]
        public string SongComposer { get; set; }

        [Display(Name = "Registered with PRS?")]
        public bool PRS { get; set; }

        [Display(Name = "Audio File")]
        public HttpPostedFileBase MediaAsset { get; set; }
        public string MediaAssetPath { get; set; }

        [Display(Name = "Genres")]
        public IEnumerable<Genre> GenreCollection { get; set; }

        public IEnumerable<Genre> GenreList
        {
            get
            {
                var WCFWebServiceJson = new WebService.WCFWebServiceJson();
                return WCFWebServiceJson.GetAllGenres();
            }
        }
    }

    public class PlaylistModel
    {
        public int PlaylistId { get; set; }

        [Display(Name = "Playlist Name")]
        public string PlaylistName { get; set; }

        [Display(Name = "Is Playlist Active?")]
        public bool Active { get; set; }
    }

    public class PlaylistSongModel
    {
        public int PlaylistSongId { get; set; }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }
        public int Position { get; set; }
    }

    public class DashboardSongModel
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public DateTime SongReleaseDate { get; set; }
        public string SongComposer { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool PRS { get; set; }
        public int TimesPurchased { get; set; }
        public List<Album> AlbumCollection { get; set; }
    }

    public class DashboardVenueModel
    {
        public BusinessUser Venue { get; set; }
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public DateTime SongReleaseDate { get; set; }
        public string SongComposer { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool PRS { get; set; }
        public int TimesPurchased { get; set; }
        public List<Album> AlbumCollection { get; set; }
    }

    public class DashboardArtistModel
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public int UserId { get; set; }
        public int TimesPurchased { get; set; }
        public string ProfileImage { get; set; }
    }

    public class PurchasedSongCountModel
    {
        public int HoursPurchased { get; set; }
        public int CountPerHour { get; set; }
    }

    public class UserPlaylistModel
    {
        public int UserPlaylistId { get; set; }
        public int PlaylistId { get; set; }
        public int UserId { get; set; }
    }
}