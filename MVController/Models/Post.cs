﻿using System;

namespace MVController.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ImagePath{ get; set; }
    }
}
