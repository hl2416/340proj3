using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using project3.Models;

namespace project3.Services
{
    //The class that gets the data from the online api and converts it from json to c# for Courses
    public class GetCourses
    {
        public async Task<Courses> getCourses()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync("course/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var c = JsonConvert.DeserializeObject<Courses>(data);

                    return c;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Courses c = new Courses();
                    return c;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Courses c = new Courses();
                    return c;
                }
            }
        }
    }
}
