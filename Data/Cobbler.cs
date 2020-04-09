using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit 
        { 
            get { return Fruit; } 
            set 
            {
                Fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
            } 
        }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream 
        {
            get { return WithIceCream; }
            set { WithIceCream = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream")); } 
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    return 5.32;
                }
                else
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    return 4.25;
                }
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions")); return new List<string>(); }
                else { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions")); return new List<string>() { "Hold Ice Cream" }; }
            }
        }
    }
}
