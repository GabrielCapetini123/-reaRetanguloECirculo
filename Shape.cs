﻿using ConsoleApp19.Entities.Enums;

namespace ConsoleApp19.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

    
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
