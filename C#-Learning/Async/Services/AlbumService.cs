using Async.Models;
using Async.Services.IService;
using Newtonsoft.Json;
using System;


namespace Async.Services
{
    public class AlbumService : IAlbum
    {
        private readonly HttpClient _client;
        private readonly string _URL = "https://jsonplaceholder.typicode.com/albums";

       public AlbumService()
        {
            _client = new HttpClient();
        }
        public  async Task<List<Album>> GetAllAlbums()
        {

            var response =await _client.GetAsync(_URL);
            var content = await response.Content.ReadAsStringAsync();// .json()
            var albums=JsonConvert.DeserializeObject<List<Album>>(content);
            
            if(response.IsSuccessStatusCode && albums!=null && albums.Count>0)
            {
                return albums;
            }
            return new List<Album>();
           
        }
    }
}
