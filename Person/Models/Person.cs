
namespace Person.Models
{
    using System.Text;

    using Students.Common;
    
    public class Person
    {
        #region Fields, Ctors, Props
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //Next time Validator lives out of the projects
                Validator.ValidateStringNullOrWhiteSpace(value);
                this.name = value;
            }
        }

        private int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("Name: {0}", this.Name).AppendLine();
            if (this.Age == null)
            {
                output.Append("Age: Unknown Age");
            }
            else
            {
                output.AppendFormat("Age: {0}", this.Age);
            }
            return output.ToString();
        }
        #endregion
    }
}
