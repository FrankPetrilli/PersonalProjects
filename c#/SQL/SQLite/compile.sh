mcs -t:library  -r:Mono.Data.Sqlite -r:System.Data DBManager.cs
mcs -r:DBManager.dll DBManagerClient.cs
