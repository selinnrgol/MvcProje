﻿namespace MvcProje.Models.Entity
{
    public class Animal
    {
        public int AnimalID { get; set; }

        public int AnimalAge { get; set; }
        public string AnimalImage { get; set; }

        public string AnimalName { get; set; }

        public string AnimalDescription { get; set; }
        public bool AnimalStatus { get; set; }
        public List <Comment> Comments { get; set; }

       
    }
}
