using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningSemaphoreSlim : IDemo
    {
        private HttpClient _httpClient = new HttpClient();
        private SemaphoreSlim _semaphoregate = new SemaphoreSlim(1);

        public void Demo()
        {
            Task.WaitAll(CallOtherAPI().ToArray());
        }

        public IEnumerable<Task> CallOtherAPI()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return CallAPI();
            }
        }

        public async Task CallAPI()
        {
            try
            {
                await _semaphoregate.WaitAsync();
                var response = await _httpClient.GetAsync("https://someapiurl.com");
                _semaphoregate.Release();

                Console.WriteLine(response.StatusCode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}