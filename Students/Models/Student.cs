namespace Students.Models
{
    using System;
    using System.Text;

    using Common;
    using Enums;
    
    public class Student : ICloneable, IComparable<Student>
    {
        #region Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private string course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;
        #endregion

        #region Ctors
        public Student(string firstName, string middleName, string lastName, string ssn, string address, string phone, string email, string course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }
        #endregion

        #region Props
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.middleName + " " + this.lastName;
            }
        }

        public string Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                Validator.ValidateStringNullOrWhiteSpace(value, this.GetType().Name);
                this.course = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                Validator.ValidateObjectNotNull(value, this.GetType().Name);
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                Validator.ValidateObjectNotNull(value, this.GetType().Name);
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                Validator.ValidateObjectNotNull(value, this.GetType().Name);
                this.specialty = value;
            }
        }
        #endregion

        #region Methods
        public object Clone()
        {
            var clone = new Student(this.FirstName, this.MiddleName, this.lastName, this.Ssn, this.Address, this.Phone, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

            return clone;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;

            if (objAsStudent == null)
            {
                return false;
            }

            if (!this.FirstName.Equals(objAsStudent.FirstName)) return false;
            if (!this.MiddleName.Equals(objAsStudent.MiddleName)) return false;
            if (!this.LastName.Equals(objAsStudent.LastName)) return false;
            if (!this.Ssn.Equals(objAsStudent.Ssn)) return false;
            if (!this.Address.Equals(objAsStudent.Address)) return false;
            if (!this.Phone.Equals(objAsStudent.Phone)) return false;
            if (!this.Email.Equals(objAsStudent.Email)) return false;
            if (!this.Course.Equals(objAsStudent.Course)) return false;
            if (!this.Specialty.Equals(objAsStudent.Specialty)) return false;
            if (!this.Faculty.Equals(objAsStudent.Faculty)) return false;
            if (!this.University.Equals(objAsStudent.University)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 13;

                hash = hash * 31 + this.FirstName.GetHashCode();
                hash = hash * 31 + this.MiddleName.GetHashCode();
                hash = hash * 31 + this.LastName.GetHashCode();
                hash = hash * 31 + this.Ssn.GetHashCode();
                hash = hash * 31 + this.Address.GetHashCode();
                hash = hash * 31 + this.Phone.GetHashCode();
                hash = hash * 31 + this.Email.GetHashCode();
                hash = hash * 31 + this.Course.GetHashCode();
                hash = hash * 31 + this.Specialty.GetHashCode();
                hash = hash * 31 + this.Faculty.GetHashCode();
                hash = hash * 31 + this.University.GetHashCode();

                return hash;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine(string.Format("Name: {0}", this.FullName));
            output.AppendLine(string.Format("SSN: {0}", this.Ssn));
            output.AppendLine(string.Format("Address: {0}", this.Address));
            output.AppendLine(string.Format("Email: {0}, Phone: {1}", this.Email, this.Phone));
            output.AppendLine(string.Format("Course: {0}", this.Course));
            output.AppendLine(string.Format("University: {0}, Faculty: {1}, Specialty: {2}", this.University, this.Faculty, this.Specialty));

            return output.ToString();
        }

        public int CompareTo(Student other)
        {
            var nameComparison = this.FullName.CompareTo(other.FullName);
            if (nameComparison == 0)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }
            return nameComparison;
        }
        #endregion
    }
}
