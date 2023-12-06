
using Async.Services;

AlbumService albumService= new AlbumService();
var albums= await albumService.GetAllAlbums();
foreach (var album in albums)
{
    Console.WriteLine($"{album.title}");
}

Console.WriteLine(albums.Count);