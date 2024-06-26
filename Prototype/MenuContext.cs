﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //what is the problem on this implementation
    //- It violate the OCP, as each time we add a new componenet type we need to modify the duplicate method
    //- MenuContext must know details about all types that implemnt Icomponent, so it is very coupled to them 
    //- it block the extensibility of MenuContext, if we need other developer make thier own shapes that implement IComponent and still using
    //MenuContext, they couldn't do that cause Duplicte should know all shapes! How to solve this?

    public class MenuContext
    {
        public void Duplicate (IComponent component)
        {
            if (component.GetType() == typeof(Circle))
            {
                Circle source = (Circle)component;
                Circle target = new ();

                target.Raduis = source.Raduis;
                // Add target to our slide
                Console.WriteLine("Duplicate new circle with raduis of: " + target.Raduis);
            }
            else if (component.GetType() == typeof(Square))
            {
                Square source = (Square)component;
                Square target = new();

                target.Side = source.Side;
                // Add target to our slide
                Console.WriteLine("Duplicate new square with raduis of: " + target.Side);
            }
        }
    }
}
