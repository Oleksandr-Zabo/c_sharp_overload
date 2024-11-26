using System;

namespace c_sharp_class_1.Entity
{
    internal class Journal
    {

        public string Name { get; set; }
        public int Year_of_foundation { get; set; }
        public string Description { get; set; }
        public string Contact_number { get; set; }
        public int Num_of_workers { get; set; }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Invalid email");
                }
            }
        }

        public Journal()
        {
            Name = "No_name";
            Year_of_foundation = 1000;
            Description = "No_description";
            Contact_number = "No_ip_address";
            email = "No_email";
            Num_of_workers = 0;
        }
        public Journal(string name) : this()
        {
            Name = name;
        }
        public Journal(string name, int year) : this(name)
        {
            Year_of_foundation = year;
        }
        public Journal(string name, int year, string description) : this(name, year)
        {
            Description = description;
        }

        public Journal(string name, int year, string description, string contact_number) : this(name, year, description)
        {
            Contact_number = contact_number;
        }

        public Journal(string name, int year, string description, string ip_address, string email) : this(name, year, description, ip_address)
        {
            Email = email;
        }

        public Journal(string name, int year, string description, string ip_address, string email, int num_workers) : this(name, year, description, ip_address, email)
        {
            Num_of_workers = num_workers;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nYear of foundation: {Year_of_foundation} \nDescription: {Description} \nContact_number: {Contact_number} \nEmail: {Email} \nNumber of workers: {Num_of_workers}";
        }

        public static Journal operator +(Journal j,int add_number)
        {
            j.Num_of_workers += add_number;
            return j;
        }

        public static Journal operator -(Journal j, int add_number)
        {
            if (j.Num_of_workers >= add_number)
            {
                j.Num_of_workers -= add_number;
                return j;
            }
            else
            {
                throw new Exception("Invalid number of workers");
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Journal)
            {
                var j = obj as Journal;
                return Num_of_workers == j.Num_of_workers;
            }
            else if (obj is int)
            {
                return Num_of_workers == (int)obj;
            }
            return false;
        }


        public static bool operator !=(Journal j1, Journal j2)
        {
            return !j1.Equals(j2);
        }
        public static bool operator !=(Journal j, int num_workers)
        {
            return !j.Equals(num_workers);
        }

        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.Equals(j2);
        }
        public static bool operator ==(Journal j, int num_workers)
        {
            return j.Equals(num_workers);
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.Num_of_workers > j2.Num_of_workers;
        }

        public static bool operator >(Journal j, int num_workers)
        {
            return j.Num_of_workers > num_workers;
        }

        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.Num_of_workers < j2.Num_of_workers;
        }

        public static bool operator <(Journal j, int num_workers)
        {
            return j.Num_of_workers < num_workers;
        }

    }
}


