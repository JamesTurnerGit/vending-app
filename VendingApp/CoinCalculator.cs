﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    interface ICoinCalculator
    {
        List<ICoin> ToCoins(int totalValue);
    }

    /// <summary>
    /// understands how to convert an INT into a list of coins
    /// </summary>
    public class CoinCalculator : ICoinCalculator
    { 
        public List<ICoin> ToCoins(int totalValue)
        {
            var result = new List<ICoin>();

            foreach (int coinValue in Coin.ValidCoinValues)
            {
                while(coinValue <= totalValue)
                {
                    totalValue -= coinValue;
                    result.Add(new Coin(coinValue));
                }
            }
            return result;
        }
    }
}
