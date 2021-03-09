### Netstat & UFW

You can confirm if the port is listing on your Pi with `netstat -nltp`, it needs to have a `Local Address` of `:::5001` this means its listing to the outside world.

All ports on the Pi should be open but if this still doesnt work you can try Uncomplicated Firewall (UFW) which is a front-end to iptables.

```
apt-get install ufw
ufw status
ufw allow in from any to any port 5001
```