# SweetPi
Having a hoon with .Net Core on Raspberry Pi - http://carlpaton.github.io/2021/03/dot-net-core-paspberry-pi/

## Run 

If your Pi has a desktop then you can clone to the Pi and code locally using [Visual Studio Code](https://www.raspberrypi.org/blog/visual-studio-code-comes-to-raspberry-pi/)

```
sudo apt update 
sudo apt install code -y
```

Install .Net using the [dotnet-install scripts](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script). I specified version [3.1.12](https://dotnet.microsoft.com/download/dotnet/3.1) as at the time of writing, this was in LTS (Long term support). 

* Also see [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

```
curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 3.1.12
dotnet --version
```

After cloning run the application on the Pi

```
dotnet restore SweetPi.sln
dotnet watch --project ./src/SweetPi.Api/SweetPi.Api.csproj run
```

### Build on PC

You can also build on the PC/Mac and then deploy to the Pi.

* [Deploy .NET apps to Raspberry Pi](https://docs.microsoft.com/en-us/dotnet/iot/deployment)

## End Points

### leds

* https://localhost:5001/leds

## Postman Collection

* [Postman Collection]("./devtools/SweetPi%20Api.postman_collection.json")