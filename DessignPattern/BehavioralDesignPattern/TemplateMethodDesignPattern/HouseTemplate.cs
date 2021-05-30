using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    public abstract class HouseTemplate
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}
