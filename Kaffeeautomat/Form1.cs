using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeMaker
{
    public partial class Form1 : Form
    {
        private CoffeeMaker m_coffeeMaker;
        private RadioButton sentRadioButton;
        public ProgressBar[] m_progressBarArrays = new ProgressBar[5];
        //hi you dick
        public Form1()
        {
            InitializeComponent();
            m_coffeeMaker = new CoffeeMaker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarCoffee.Value = m_coffeeMaker.LevelCoffee;
            progressBarChoco.Value = m_coffeeMaker.LevelChoco;
            progressBarMilk.Value = m_coffeeMaker.LevelMilk;
            progressBarWater.Value = m_coffeeMaker.LevelWater;
            progressBarSuguare.Value = m_coffeeMaker.LevelSugar;
        }

        private void btn_OK_Clicked(object sender, EventArgs e)
        {
            m_coffeeMaker.Sugar = trb_zucker.Value;            
            m_coffeeMaker.FairTrade = cbx_fairTrade.Checked;
            if(m_coffeeMaker.ProductNumber != 5)
            {
                tab_select.SelectTab(1);
            }
        }

        private void ProductSelected(object sender, EventArgs e)
        {
            sentRadioButton = sender as RadioButton;      
            m_coffeeMaker.ProductNumber = Convert.ToInt32(sentRadioButton.Tag);
        }

        private void coins_Click(object sender, EventArgs e)
        {
            if(m_coffeeMaker.ProductNumber != 5)
            {
                Button sentButton = sender as Button;
                m_coffeeMaker.InsertedCoins += Convert.ToDouble(sentButton.Tag);
                tbx_credit.Text = String.Format("{0:C2}", m_coffeeMaker.InsertedCoins);
                if (m_coffeeMaker.InsertedCoins >= m_coffeeMaker.Price)
                {
                    tbx_credit.Clear();
                    tab_select.SelectTab(2);
                }
            }
            else
            {
                tab_select.SelectTab(0);
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {           
            if(m_coffeeMaker.InsertedCoins == 0)
            {
                MessageBox.Show("No change available.");
            }
            else
            {
                MessageBox.Show(String.Format("{0:C2} was given back to you!", m_coffeeMaker.InsertedCoins));
                m_coffeeMaker.InsertedCoins = 0;
            }
        }

        private void btn_takeIt_Click(object sender, EventArgs e)
        {
            if(m_coffeeMaker.ProductNumber == 5)
            {
                tbx_change.Clear();
                tab_select.SelectTab(tab_product);
            }
            else
            {
                tbx_change.Text = String.Format("{0:C2}", m_coffeeMaker.InsertedCoins - m_coffeeMaker.Price);
                m_coffeeMaker.InsertedCoins = 0;

                progressBarSuguare.Value -= trb_zucker.Value + 5;
                progressBarCoffee.Value -= m_coffeeMaker.products[m_coffeeMaker.ProductNumber].productCoffee;
                progressBarMilk.Value -= m_coffeeMaker.products[m_coffeeMaker.ProductNumber].productCoffee;
                progressBarChoco.Value -= m_coffeeMaker.products[m_coffeeMaker.ProductNumber].productCoffee;
                progressBarWater.Value -= m_coffeeMaker.products[m_coffeeMaker.ProductNumber].productCoffee;
                m_coffeeMaker.ProductNumber = 5;
            }           
        }

        private void tab_select_Click(object sender, EventArgs e)
        {

        }

        private void tab_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tab_select.SelectedIndex == 2 && m_coffeeMaker.InsertedCoins <= 0.60)
            {
                tab_select.SelectTab(1);
            }
        }
    }
}