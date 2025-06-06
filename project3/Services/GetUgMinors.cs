﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using project3.Models;
using Newtonsoft.Json;

namespace project3.Services
{
    //The class that gets the data from the online api and converts it from json to c# for Minors
    public class GetUgMinors
    {
        public async Task<List<UgMinors>> getUgMinors()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("minors/UgMinors", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UgMinors>>>(data);

                    List<UgMinors> ugMinorsList = new List<UgMinors>();

                    foreach (KeyValuePair<string, List<UgMinors>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            ugMinorsList.Add(item);
                        }
                    }
                    return ugMinorsList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UgMinors> ugMinorsList = new List<UgMinors>();
                    return ugMinorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UgMinors> ugMinorsList = new List<UgMinors>();
                    return ugMinorsList;
                }
            }
        }
    }
}
