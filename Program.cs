using Microsoft.EntityFrameworkCore;
using ScaffoldingWorkshop;

using var db = new ChinookContext();

var albums = db.Albums.ToList();
//var albumsPlusArtist = db.Albums.Include(x => x.Artist);
    
//  var result = albumsPlusArtist.ToList();



Console.WriteLine("Hello, World!");

//Data Source=localhost;Initial Catalog=chinook;Integrated Security=True;Trust Server Certificate=True