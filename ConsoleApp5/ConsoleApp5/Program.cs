using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public class user
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public Boolean site_admin { get; set; }

        }

        static async Task CallApi()
            {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com/users");
            client.DefaultRequestHeaders.Add("User-Agent", "c#App");
            HttpResponseMessage response = await client.GetAsync("");
            var ui = await response.Content.ReadAsAsync<List<user>>();

            foreach(user i in ui )
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}\n{14}\n{15}\n{16}\n{17}\n", i.id, i.login,i.node_id,i.avatar_url,i.gravatar_id,i.url,i.html_url,i.followers_url,i.following_url,i.gists_url,i.starred_url,i.subscriptions_url,i.organizations_url,i.repos_url,i.events_url,i.received_events_url,i.type,i.site_admin);
            }
        }

        static void Main(string[] args)
        {
            CallApi().Wait();
           
        }
        }
    }

