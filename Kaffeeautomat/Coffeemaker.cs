using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMaker
{
    class CoffeeMaker
    {
        public Product[] products = new Product[5] {new Product { productCoffee = 8, productWater = 100, productMilkPowder = 5, productSugar = 5, productKakao = 0 },
            new Product { productCoffee = 8, productWater = 100, productMilkPowder = 15, productSugar = 5, productKakao = 0 },
            new Product { productCoffee = 8, productWater = 100, productMilkPowder = 10, productSugar = 5, productKakao = 0 },
            new Product { productCoffee = 0, productWater = 100, productMilkPowder = 0, productSugar = 5, productKakao = 0 },
            new Product { productCoffee = 0, productWater = 100, productMilkPowder = 0, productSugar = 5, productKakao = 8 } };

        /*public Product melange = new Product { productCoffee = 8, productWater = 100, productMilkPouder = 5, productSugar = 5, productKakao = 0 };
        public Product latteMacciato = new Product() { productCoffee = 8, productWater = 100, productMilkPouder = 15, productSugar = 5, productKakao = 0 };
        public Product cappuccino = new Product() { productCoffee = 8, productWater = 100, productMilkPouder = 10, productSugar = 5, productKakao = 0 };
        public Product tea = new Product() { productCoffee = 0, productWater = 100, productMilkPouder = 0, productSugar = 5, productKakao = 0 };
        public Product chocolate = new Product() { productCoffee = 0, productWater = 100, productMilkPouder = 0, productSugar = 5, productKakao = 8 };*/
        private double m_insertedCoins = 0;
        public double InsertedCoins
        {
            get
            {
                return m_insertedCoins;
            }
            set
            {
                //if (m_insertedCoins >= m_price)
                //{
                //    m_insertedCoins = value;
                //    m_insertedCoins -= m_price;
                //}
                //else
                //{
                    m_insertedCoins = value;
                //}
            }
        }

        /// <summary>
        /// This property is the current amount of sugar
        /// </summary>
        public int Sugar
        {
            get;
            set;
        }

        /// <summary>
        /// If this bool is true then you have to pay 20 cents more for fair trade coffee
        /// </summary>
        public bool FairTrade
        {
            get;
            set;
        }

        /// <summary>
        /// This is the number of the product you want
        /// </summary>
        private int m_productNumber = 5; //"5" stands for "no product", if one is selected, it gets the value of the selected product
        public int ProductNumber
        {
            get
            {
                return m_productNumber;
            }
            set
            {
                m_productNumber = value;
            }
        }

        /// <summery>
        /// The following int propertys are the remaining level of ingridients in the coffe machine
        /// </summery>
        private int m_levelCoffee = 1000;
        public int LevelCoffee
        {
            get
            {
                return m_levelCoffee;
            }
            set
            {
                CheckMinMaxAndSet(m_levelCoffee, value);
            }
        }

        private int m_levelChoco = 1000;
        public int LevelChoco
        {
            get
            {
                return m_levelChoco;
            }
            set
            {
                CheckMinMaxAndSet(m_levelChoco, value);
            }
        }

        private int m_levelWater = 10000;
        public int LevelWater
        {
            get
            {
                return m_levelWater;
            }
            set
            {
                if ((m_levelWater >= 0 && m_levelWater <= 10000))
                {
                    value = m_levelWater;
                }
            }
        }

        private int m_levelSugar = 1000;
        public int LevelSugar
        {
            get
            {
                return m_levelSugar;
            }
            set
            {
                CheckMinMaxAndSet(m_levelSugar, value);
            }
        }

        private int m_levelMilk = 1000;
        public int LevelMilk
        { 
            get
            {
                return m_levelMilk;
            }
            set
            {
                CheckMinMaxAndSet(m_levelMilk, value);
            }
        }
        
        private void CheckMinMaxAndSet(int level, int value)
        {
            if((level >= 0 && level <= 1000))
            {
                value = level;
            }
        }

        private double m_price = 0.60;
        public double Price
        {
            get
            {
                if(FairTrade)
                {
                    return m_price + 0.20;
                }
                else
                {
                    return m_price;
                }
            }
            private set //private, damit niemand 60c überschreiben kann
            {
                value = m_price;
            }
        }

        public void BuyCoffee()
        {
            products[ProductNumber].productCoffee = 8;
        }
        // Properties:
        // für alle Füllstände (Kaffee, Milch, etc. )
        // für die Speicherung des Zustandes "Kaffee fertig/nicht fertig"
        // ...

        // Methoden:
        // zur Veränderung der Füllstände
        // zur Veränderung des Guthabens (10cent, 20cent, ...)
        // Ausgabe der Überzahlung
        // Rückgabe des Münzeinwurfes
        // ...
    }
}
