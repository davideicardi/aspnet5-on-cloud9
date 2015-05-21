{
    "version": "1.0.0-*",
    "webroot": "wwwroot",
    "exclude": [
        "wwwroot"
    ],
    "packExclude": [
        "**.kproj",
        "**.user",
        "**.vspscc"
    ],
    "dependencies": {
        "Kestrel": "1.0.0-beta4",
        "Microsoft.AspNet.Diagnostics": "1.0.0-beta4",
        "Microsoft.AspNet.Hosting": "1.0.0-beta4",
        "Microsoft.AspNet.Server.IIS": "1.0.0-beta4",
        "Microsoft.AspNet.Server.WebListener": "1.0.0-beta4",
        "Microsoft.AspNet.StaticFiles": "1.0.0-beta4"
    },
    "commands": {
        "web": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.WebListener --server.urls http://localhost:5001",
        "kestrel": "Microsoft.AspNet.Hosting --server Kestrel --server.urls http://$IP:$PORT"
    },
    "frameworks": {
        "dnx451": { },
        "dnxcore50": { }
    }
}
