namespace AvaloniaDataGrid.Models
{
    public class Person
    {
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

            }
        }
    }
}
