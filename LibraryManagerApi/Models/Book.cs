﻿using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using LibraryManagerApi.Models.Commands;

namespace LibraryManagerApi.Models
{
    [Serializable()]
    public class Book 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Money Price { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string Publisher { get; set; }
        public Author Author { get; set; }
    }
}