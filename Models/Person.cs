using System;

namespace AvaloniaDataGrid.Models
{
    public class Person
    {
        private int counter = 1;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public OtherObject OtherProperty
        {
            get
            {
                return new OtherObject();
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine($"Setting OtherProperty to null - times {counter}");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Setting OtherProperty to {value}");
                }
            }
        }
    }
}
