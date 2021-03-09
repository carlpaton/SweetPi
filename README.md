## SweetPi
Having a hoon with .Net Core on Raspberry Pi - http://carlpaton.github.io/2021/03/dot-net-core-paspberry-pi/

### End Points

`node1` is the name of my Raspberry Pi

* GET: http://node1:5001/ping
* POST: http://node1:5001/leds
* [Postman Collection](https://github.com/carlpaton/SweetPi/blob/main/devtools/SweetPi%20Api.postman_collection.json)

### Run sweetpi on pi

Run and make code changes

```
dotnet restore SweetPi.sln
dotnet watch --project ./src/SweetPi.Api/SweetPi.Api.csproj run
```

Publish and run

```
dotnet publish "./src/SweetPi.Api/SweetPi.Api.csproj" --configuration Release --output ./published --no-restore
dotnet ./published/SweetPi.Api.dll
```

### References

* https://docs.microsoft.com/en-us/dotnet/iot/deployment
* https://dotnet.microsoft.com/download
* https://www.raspberrypi.org/blog/visual-studio-code-comes-to-raspberry-pi/
* https://edi.wang/post/2019/9/29/setup-net-core-30-runtime-and-sdk-on-raspberry-pi-4
* https://elbruno.com/2020/01/05/raspberrypi-how-to-solve-dotnet-core-not-recognized-after-reboot/