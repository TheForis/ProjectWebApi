﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.CommentDto
{
    public class UpdateCommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
    }
}
