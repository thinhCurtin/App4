using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
