# SweetPi
Having a hoon with .Net Core on Raspberry Pi - http://carlpaton.github.io/2021/03/dot-net-core-paspberry-pi/

## Run 

After cloning run the application on the Pi

```
dotnet restore SweetPi.sln
dotnet watch --project ./src/SweetPi.Api/SweetPi.Api.csproj run
```

## End Points

### leds

* https://localhost:5001/leds

## Postman Collection

* [Postman Collection]("./devtools/SweetPi%20Api.postman_collection.json")