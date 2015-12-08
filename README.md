# aspnet5-on-cloud9

Running asp.net 5 on Cloud 9

## Installing instruction for ASP.NET 5

https://github.com/aspnet/Home/blob/dev/GettingStartedDeb.md

## Sample

Sample app from:

https://github.com/aspnet/Home/tree/dev/samples/1.0.0-beta4/HelloWeb


## Running sample

Restore packages using 

    dnu restore

If you receive HTTP timeout errors first use (see http://stackoverflow.com/a/31975260/209727):

    export MONO_THREADS_PER_CPU=2000    
    dnu restore

Then run the web server using:

    dnx web
    
Note that port 8080 is the default used by cloud 9 ide.
