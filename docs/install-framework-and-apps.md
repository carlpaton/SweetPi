### Install VS Code

```
sudo apt update 
sudo apt install code -y
```

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