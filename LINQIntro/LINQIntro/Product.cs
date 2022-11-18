﻿namespace LINQIntro
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public double? Rating { get; set; }
        public string Description { get; set; }
        public bool IsStock { get; set; }
        public Category Category { get; set; }
    }
}
