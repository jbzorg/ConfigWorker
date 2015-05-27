ConfigWorker
----

Simple wrapper for strings in config file of application or web site
  
### Basic Usage

```c#
byte Hour = Config.GetSettings<byte>("Caption settings for Hour", 11);
string FileStore = Config.GetSettings<string>("Caption settings for FileStore", somePath);
```

### NuGet repository

https://www.myget.org/F/zorg-public/api/v2