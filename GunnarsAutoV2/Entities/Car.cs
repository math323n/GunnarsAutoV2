using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAutoV2.Entities
{
    public class Car
    {
        protected int id;
        protected string make;
        protected string model;
        protected string vin;
        protected string numberPlate;
        protected string isUsed;

        public Car(int id, string make, string model, string vin, string numberPlate, string isUsed)
        {
            Id = id;
            Make = make;
            Model = model;
            Vin = vin;
            NumberPlate = numberPlate;
            IsUsed = isUsed;
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

        public virtual string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public virtual string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public virtual string Vin
        {
            get
            {
                return vin;
            }

            set
            {
                vin = value;
            }
        }

        public virtual string NumberPlate
        {
            get
            {
                return numberPlate;
            }

            set
            {
                numberPlate = value;
            }
        }

        public virtual string IsUsed
        {
            get
            {
                return isUsed;
            }

            set
            {
                isUsed = value;
            }
        }
    }
}