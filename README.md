## SweetPi
Having a hoon with .Net Core on Raspberry Pi - http://carlpaton.github.io/2021/03/dot-net-core-paspberry-pi/

### End Points

`node1` is the name of my Raspberry Pi

* GET: http://node1:5001/ping
* POST: http://node1:5001/leds

You can confirm if the port is listing on your Pi with `netstat -nltp`, it needs to have a `Local Address` of `:::5001` this means its listing to the outside world.

All ports on the Pi should be open but if this still doesnt work you can try Uncomplicated Firewall (UFW) which is a front-end to iptables.

```
apt-get install ufw
ufw status
ufw allow in from any to any port 5001
```

### Postman Collection

* [Postman Collection](https://github.com/carlpaton/SweetPi/blob/main/devtools/SweetPi%20Api.postman_collection.json)

### Install .Net Core

I tried to use the [dotnet-install scripts](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script) and even after manually adding to path it didnt work. So I did it manually:

Update the OS

```
sudo apt-get update
sudo apt-get upgrade
```

Check for dotnet and install it

```
dotnet --info                      ~ fails: 'dotnet1' is not recognized as an internal or external command, operable program or batch file.
echo $0                            ~ expect `bash`

mkdir dev
cd dev
wget https://download.visualstudio.microsoft.com/download/pr/349f13f0-400e-476c-ba10-fe284b35b932/44a5863469051c5cf103129f1423ddb8/dotnet-sdk-3.1.102-linux-arm.tar.gz
wget https://download.visualstudio.microsoft.com/download/pr/8ccacf09-e5eb-481b-a407-2398b08ac6ac/1cef921566cb9d1ca8c742c9c26a521c/aspnetcore-runtime-3.1.2-linux-arm.tar.gz

mkdir dotnet-arm32
tar zxf dotnet-sdk-3.1.102-linux-arm.tar.gz -C $HOME/dev/dotnet-arm32
tar zxf aspnetcore-runtime-3.1.2-linux-arm.tar.gz -C $HOME/dev/dotnet-arm32

export DOTNET_ROOT=$HOME/dev/dotnet-arm32
export PATH=$PATH:$HOME/dev/dotnet-arm32

dotnet --info                      ~ works
```

Adding `export` above only adds it for that session, you can perminantly add it as follows

```
echo $PATH                        ~ wont have `dev/dotnet`
sudo nano ~/.bashrc               ~ edit PATH in [~/.bashrc] file

At the bottom of the file add the exports. Save and exit.

export DOTNET_ROOT=$HOME/dev/dotnet-arm32
export PATH=$PATH:$HOME/dev/dotnet-arm32

source ~/.bashrc                 ~ reload the [~/.bashrc] file 
```

### Run sweetpi on pi

```
~ run and make code changes
dotnet restore SweetPi.sln
dotnet watch --project ./src/SweetPi.Api/SweetPi.Api.csproj run

~ publish and run
dotnet publish "./src/SweetPi.Api/SweetPi.Api.csproj" --configuration Release --output ./published --no-restore
dotnet ./published/SweetPi.Api.dll
```

### Install VS Code

```
sudo apt update 
sudo apt install code -y
```

### References

* https://docs.microsoft.com/en-us/dotnet/iot/deployment
* https://dotnet.microsoft.com/download
* https://www.raspberrypi.org/blog/visual-studio-code-comes-to-raspberry-pi/
* https://edi.wang/post/2019/9/29/setup-net-core-30-runtime-and-sdk-on-raspberry-pi-4
* https://elbruno.com/2020/01/05/raspberrypi-how-to-solve-dotnet-core-not-recognized-after-reboot/