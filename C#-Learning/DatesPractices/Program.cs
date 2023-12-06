//create Date 

DateTime dateTime = new DateTime(2023, 11, 27);

//date + time now
var now= DateTime.Now;
Console.WriteLine(now);


// just interested in today date not the time

var today= DateTime.Today;
Console.WriteLine(today);

//formatting
Console.WriteLine(today.ToLongDateString());
Console.WriteLine(today.ToShortDateString());
//time
Console.WriteLine(today.ToLongTimeString());
Console.WriteLine(today.ToShortTimeString());

Console.WriteLine(today.AddHours(-8)); ;
Console.WriteLine(today.ToString("yy-MM-dd"));

//TimeSpan

TimeSpan ts = new TimeSpan(1, 20, 0);

TimeSpan ts1 = new TimeSpan(1, 0, 0);
TimeSpan ts2 = TimeSpan.FromHours(1);


var duration = now - today.AddHours(-8);

Console.WriteLine(duration);

Console.WriteLine(ts1);
Console.WriteLine(ts2);


//[properties

Console.WriteLine(ts.Minutes);
Console.WriteLine(ts.TotalMinutes);
Console.WriteLine(ts.TotalHours);
Console.WriteLine(DateTime.Now);