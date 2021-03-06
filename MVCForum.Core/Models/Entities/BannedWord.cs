﻿namespace MvcForum.Core.Models.Entities
{
    using System;
    using Utilities;

    public partial class BannedWord : Entity
    {
        public BannedWord()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Word { get; set; }
        public bool? IsStopWord { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
