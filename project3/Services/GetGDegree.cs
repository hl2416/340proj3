using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using project3.Models;
using Newtonsoft.Json;

namespace project3.Services
{
    //The class that gets the data from the online api and converts it from json to c# for Graduate Degrees
    public class GetGDegrees
    {
        public async Task<List<Graduate>> getGDegrees()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("degrees/graduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Graduate>>>(data);

                    List<Graduate> gDegreeList = new List<Graduate>();

                    foreach (KeyValuePair<string, List<Graduate>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            gDegreeList.Add(item);
                        }
                    }
                    return gDegreeList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Graduate> gDegreeList = new List<Graduate>();
                    return gDegreeList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Graduate> gDegreeList = new List<Graduate>();
                    return gDegreeList;
                }
            }
        }
    }
}
