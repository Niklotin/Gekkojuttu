using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace aikakoneGekko.apijutut
{
    public static class ApiHelper
    {
        public static int difference;
        private static List<long> datesStamps = new List<long>();
        private static List<decimal> prices = new List<decimal>();
        private static List<decimal> totalVolumes = new List<decimal>();

        // List Getters for the data things class.

        public static List<decimal> getListHinnat()
        {
            return prices;
        }
        public static List<decimal> getListTotalVolumes()
        {
            return totalVolumes;
        }
        public static List<long> getDateStamps()
        {
            return datesStamps;
        }
        /// <summary>
        /// Flushes the lists.
        /// </summary>
        public static void FlushLists()
        {
            datesStamps.Clear();
            prices.Clear();
            totalVolumes.Clear();
        }

        /// <summary>
        /// Gets the data from coingeckos api and puts them into lists
        /// </summary>
        /// <param name="start"> Unix timestamp to tell the api from what date to start the query with </param>
        /// <param name="end"> Unix timestamp to tell the api to which date to end the query with </param>
        public static async Task GetData(long start, long end)
        {
            HttpClient client = new HttpClient();
            string url = $"https://api.coingecko.com/api/v3/coins/bitcoin/market_chart/range?vs_currency=eur&from={start}&to={end}";
            var response = await client.GetStringAsync(url);

            // Difference is never used here, its just here to tell datamanipulation what kind of intervals should the data picked up in be.
            difference = Convert.ToInt32(end-start) / 86400;

            FlushLists();

            DataModel modeldata = JsonConvert.DeserializeObject<DataModel>(response);

            foreach (List<decimal> sublist in modeldata.Prices)
            {
                foreach (var item in sublist)
                {

                    if (sublist.IndexOf(item) % 2 == 0)
                    {
                        datesStamps.Add(Convert.ToInt64(item));
                    }
                    else
                    {
                        prices.Add(item);
                    }
                }
            }

            foreach (List<decimal> sublist in modeldata.TotalVolumes)
            {
                foreach (var item in sublist)
                {

                    if (sublist.IndexOf(item) % 2 == 0)
                    {
                    }
                    else
                    {
                        totalVolumes.Add(item);
                    }
                }
            }

            modeldata.Prices.Clear();
            modeldata.TotalVolumes.Clear();
        }

        /// <summary>
        /// Datamodel for the bitcoin prices and total volumes
        /// </summary>
        public class DataModel
        {
            [JsonProperty("prices")]
            public List<List<decimal>> Prices { get; set; }

            [JsonProperty("total_volumes")]
            public List<List<decimal>> TotalVolumes { get; set; }
        }

    }
}
