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


        /// <summary>
        /// it return all the courses saved in the database
        /// </summary>
        /// <returns>IEnumerable<course></returns>
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

        /// <summary>
        /// it return all the students saved in the database
        /// </summary>
        /// <returns>IEnumerable<Student></returns>
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

        /// <summary>
        /// retur a student based on his identifier from the database
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public Student FindStudent(int identifier)
        {

            try
            {


                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("students/"+identifier).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Student>().Result;
                return null;

            }
            catch (Exception)
            {

                return null;
            }


        }



        public Course FindCourse( int courseCode)
        {

            try
            {


                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("courses/" + courseCode).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Course>().Result;
                return null;

            }
            catch (Exception)
            {

                return null;
            }


        }

        public bool Create(Course courseCode)
        {

            try
            {


                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("courses",courseCode ).Result;
                return response.IsSuccessStatusCode;

            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}
