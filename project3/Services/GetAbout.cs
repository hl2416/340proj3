﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using project3.Models;

namespace project3.Services
{
    //The class that gets the data from the online api and converts it from json to c# for About
    public class GetAbout
    {
        public async Task<About> getAbout()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("about/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var ab = JsonConvert.DeserializeObject<About>(data);

                    return ab;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    About ab = new About();
                    return ab;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    About ab = new About();
                    return ab;
                }
            }
        }
    }
}
