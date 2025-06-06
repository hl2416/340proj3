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
    //The class that gets the data from the online api and converts it from json to c# for Staff
    public class GetStaff
    {
        public async Task<List<Staff>> getAllStaff()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("people/staff", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Staff>>>(data);

                    List<Staff> staffList = new List<Staff>();

                    foreach (KeyValuePair<string, List<Staff>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            staffList.Add(item);
                        }
                    }
                    return staffList;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Staff> staffList = new List<Staff>();
                    return staffList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Staff> staffList = new List<Staff>();
                    return staffList;
                }
            }
        }
    }
}
