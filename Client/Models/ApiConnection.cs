using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Client.Models
{
    public class ApiConnection
    {

        string BASE_URL = "http://localhost:1673/api/";

        public IEnumerable<Course> FindAllCourse()
        {

            try
            {


                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("courses").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<Course>>().Result;
                return null;

            }
            catch (Exception)
            {

                return null;
            }


        }




        public IEnumerable<Student> FindAllStudent()
        {

            try
            {


                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("students").Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<Student>>().Result;
                return null;

            }
            catch (Exception)
            {

                return null;
            }


        }


    }
}
