﻿namespace assignment3_brandonstephens.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Gender { get; set; }  
        public int Age { get; set; }
        public string? IMDBLink { get; set; }

        public byte[]? Photo { get; set; }  
    }
}
