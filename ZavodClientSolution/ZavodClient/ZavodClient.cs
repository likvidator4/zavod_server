﻿using System.Net.Http;

namespace ZavodClient
{
    public class ZavodClient
    {
        public static HttpClient Client;
        private static string baseUrl;

        public Unit Unit;
        public Building Building;

        public ZavodClient(string url)
        {
            Client = new HttpClient();
            baseUrl = url;
            Unit = new Unit(baseUrl);
            Building = new Building(baseUrl);
        }
    }
}
