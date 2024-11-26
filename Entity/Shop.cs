using System;

namespace c_sharp_overload.Entity
{
    internal class Shop
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Contact_number { get; set; }
        public double Square { get; set; }

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

        public Shop()
        {
            Name = "No_name";
            Address = "No_adress";
            Description = "No_description";
            Contact_number = "No_ip_address";
            email = "No_email";
            Square = 0;
        }
        public Shop(string name) : this()
        {
            Name = name;
        }
        public Shop(string name, string address) : this(name)
        {
            Address = address;
        }
        public Shop(string name, string address, string description) : this(name, address)
        {
            Description = description;
        }

        public Shop(string name, string address, string description, string contact_number) : this(name, address, description)
        {
            Contact_number = contact_number;
        }

        public Shop(string name, string address, string description, string contact_number, string email) : this(name, address, description, contact_number)
        {
            Email = email;
        }

        public Shop(string name, string address, string description, string contact_number, string email, double square) : this(name, address, description, contact_number, email)
        {
            Square = square;
        }

        public static Shop operator +(Shop shop, double square)
        {
            shop.Square += square;
            return shop;
        }

        public static Shop operator -(Shop shop, double square)
        {
            shop.Square -= square;
            return shop;
        }

        public override bool Equals(object? obj)
        {

            if (obj == null)
            {
                return false;
            }
            else if (obj is double)
            {
                return Square == (double)obj;
            }
            else if (obj is int)
            {
                return Square == (int)obj;
            }
            else { 
                Shop? shop = obj as Shop;
                return shop.Square == Square; 
            }
        }

        static public bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Equals(shop2);
        }
        static public bool operator ==(Shop shop, double square)
        {
            return shop.Equals(square);
        }

        static public bool operator !=(Shop shop1, Shop shop2)
        {
            return !shop1.Equals(shop2);
        }

        static public bool operator !=(Shop shop, double square)
        {
            return !shop.Equals(square);
        }

        static public bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Square > shop2.Square;
        }

        static public bool operator >(Shop shop, double square)
        {
            return shop.Square > square;
        }

        static public bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Square < shop2.Square;
        }

        static public bool operator <(Shop shop, double square)
        {
            return shop.Square < square;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} \nDescription: {Description} \nContact_number: {Contact_number} \nEmail: {Email} \nSquare: {Square} m2";
        }

    }
}



