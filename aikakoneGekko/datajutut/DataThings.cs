using System;
using System.Collections.Generic;
using System.Linq;

namespace aikakoneGekko.datajutut
{
    class DataThings
    {
        /// <summary>
        /// Checks the longest bearish (downward) trend of prices on the given list.
        /// </summary>
        /// <param name="listOfPrices"> A decimal list of prices from the fetched data </param>
        /// <returns> Returns a string of how long the longest bearish trend was on the given price list </returns>

        public static string LongestBearish(List<decimal> listOfPrices)
        {
            int days = 0;
            int longest = 0;
            int i = 0;
            int j = 1;
            int sizeOfList = listOfPrices.Count();

            while(j < sizeOfList)
            {
                if(listOfPrices[i] > listOfPrices[j])
                {
                    days++;
                    if(days >= longest)
                    {
                        longest++;
                    }
                }
                if(listOfPrices[i] <= listOfPrices[j])
                {
                    days = 0;
                }
                j++;
                i++;
            }

            return "Longest bearish trend was  " + longest + " days long.";
        }

        /// <summary>
        /// Checks what day on the given daterange has the highest trading volume of bitcoin. The two lists are in order so tradingVolumes[0] and unixTimeStamp[0] are a pair.
        /// </summary>
        /// <param name="tradingVolumes"> A list of the trading volumes </param>
        /// <param name="unixTimeStamp"> A list of unix timestamps </param>
        /// <returns> Returns a string containing the day of the highest trading volume, and the trading volume on that day </returns>

        public static string HighestTradingVolume(List<decimal> tradingVolumes, List<long> unixTimeStamp)
        {
            DateTime highestDay = new DateTime();
            decimal volume = tradingVolumes.Max();
            int i = tradingVolumes.IndexOf(tradingVolumes.Max());
            long timeStamp = unixTimeStamp[i];
            highestDay = TimeThings.UnixTimeStamptoDateTime(timeStamp);

            return "Date with the highest trading volume was " + highestDay.ToString("dd.MM.yyyy") +  " And the volume that day was " +  volume + " eur.";
        }

        /// <summary>
        /// On a given date range, checks when was the best time to buy and sell for maximum moneyprofits$€$€
        /// </summary>
        /// <param name="prices"> A list of prices </param>
        /// <param name="timestamp"> A list of unix timestamps </param>
        /// <returns> Returns a string containing the best day to buy and sell or if in the given date range the price only drops(or the program gets confused by too short date ranges :/ ) </returns>
        public static string WhenToBuyWhenToSell(List<decimal> prices, List<long> timestamp)
        {
            DateTime daySell, dayBuy = new DateTime();
            decimal min = prices[0];
            decimal sellPrice = 0, buyPrice = 0;
            decimal maxDiff = 0;
            int indexOfBuy;
            int indexOfHighestPrice = prices.IndexOf(prices.Max());
            int indexOfLowestPrice = prices.IndexOf(prices.Min());

            daySell = TimeThings.UnixTimeStamptoDateTime(timestamp[0]);
            dayBuy = TimeThings.UnixTimeStamptoDateTime(timestamp[0]);

            if(prices.Count() >= 2)
            {
                for (int i = 0; i < prices.Count(); i++)
                {
                    if ((prices[i] - min) > maxDiff)
                    {
                        daySell = TimeThings.UnixTimeStamptoDateTime(timestamp[i]);
                        sellPrice = prices[i];
                        dayBuy = TimeThings.UnixTimeStamptoDateTime(timestamp[prices.IndexOf(min)]);
                        buyPrice = prices[prices.IndexOf(min)];
                        maxDiff = prices[i] - min;
                    }
                    if(prices[i] < min)
                    {
                    min = prices[i];
                    }
                }
                if(maxDiff <= 0)
                {
                    return "The price of BTC only drops on the give daterange";
                }
                else
                {
                    return $"Day to buy: {dayBuy.ToString("d")} when the price is {buyPrice}€ Day to sell: {daySell.ToString("d")} when the price is {sellPrice}€ Profit:  {maxDiff}€";
                }
            }


            return "Something went wrong, please check your daterange input.";
        }

    
        /// <summary>
        /// Handles the data and puts it into Lists. Also sends strings to the textfields in ui, might be wise to separate these two.
        /// </summary>
        /// <param name="i"> number to handle the return switch </param>
        /// <returns> Returns a string that contains the text to put into textfield for each button. </returns>
        public static string HaluttuData(int i)
        {
            string palautettava;

            List<long> haettuDateStamps = new List<long>();
            List<decimal> haettuHinta = new List<decimal>();
            List<decimal> haettuVolyymi = new List<decimal>();

            List<long> muokattavaDateStamps = new List<long>();
            List<decimal> muokattavaHinta = new List<decimal>();
            List<decimal> muokattavaVolyymi = new List<decimal>();

            muokattavaDateStamps.Clear();
            muokattavaHinta.Clear();
            muokattavaVolyymi.Clear();

            haettuDateStamps = apijutut.ApiHelper.getDateStamps();
            haettuHinta = apijutut.ApiHelper.getListHinnat();
            haettuVolyymi = apijutut.ApiHelper.getListTotalVolumes();

            int difference = apijutut.ApiHelper.difference;


            if(haettuHinta.Count == 0 || haettuVolyymi.Count == 0 || haettuDateStamps.Count == 0)
            {
                return "Something has gone wrong, please try again.";
            }

            if (difference < 90)
            {
                foreach(var item in haettuHinta)
                {
                    if(haettuHinta.IndexOf(item) % 24 == 0)
                    {
                        muokattavaHinta.Add(item);
                    }

                }

                foreach (var item in haettuVolyymi)
                {
                    if (haettuVolyymi.IndexOf(item) % 24 == 0)
                    {
                        muokattavaVolyymi.Add(item);
                    }

                }

                foreach (var timeStamp in haettuDateStamps)
                {
                    if (haettuDateStamps.IndexOf(timeStamp)% 24 == 0)
                    {
                        muokattavaDateStamps.Add(timeStamp);
                    }
                }
            }
            else if (difference >= 90)
            {
                foreach(var item in haettuHinta)
                {
                    if(haettuHinta.IndexOf(item)%2 == 0)
                    {
                        muokattavaHinta.Add(item);
                    }
                }

                foreach (var item in haettuVolyymi)
                {
                    if (haettuVolyymi.IndexOf(item) % 2 == 0)
                    {
                        muokattavaVolyymi.Add(item);
                    }
                }

                foreach (var timeStamp in haettuDateStamps)
                {
                    if (haettuDateStamps.IndexOf(timeStamp) % 2 == 0)
                    {
                        muokattavaDateStamps.Add(timeStamp);
                    }
                }
            }
            else
            {
                muokattavaHinta.Add(haettuHinta[0]);
                muokattavaVolyymi.Add(haettuVolyymi[0]);
                muokattavaDateStamps.Add(haettuDateStamps[0]);
            }


            switch (i)
            {
                case 1:
                    palautettava = LongestBearish(muokattavaHinta);
                    return palautettava;
                case 2:
                    palautettava = HighestTradingVolume(muokattavaVolyymi, muokattavaDateStamps);
                    return palautettava;
                case 3:
                    palautettava = WhenToBuyWhenToSell(muokattavaHinta, muokattavaDateStamps);
                    return palautettava;
                default:
                    return "This shouldn't happen :D";


            }

        }

    }
}
