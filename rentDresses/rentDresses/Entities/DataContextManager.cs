﻿namespace rentDresses.Entities
{
    public class DataContextManager
    {
        public static DataContext DataContext { get; set; }= new DataContext();
    }
}