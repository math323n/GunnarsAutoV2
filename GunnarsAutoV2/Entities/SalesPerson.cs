using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAutoV2.Entities
{
    public class SalesPerson
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected string initials;

        public SalesPerson(int id, string firstName, string lastName, string initials)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Initials = initials;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public virtual string Initials
        {
            get
            {
                return initials;
            }

            set
            {
                initials = value;
            }
        }
    }
}