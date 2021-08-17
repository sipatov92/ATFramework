# ATFramework


#### Deploy WEB application

For deploy application you must install
[Docker](https://www.docker.com/)

To check Docker you can use:

```bash
docker --version
```
To deploy application you must run clone it from [github](https://github.com/dotnet-architecture/eShopOnContainers):
```bash
git clone https://github.com/dotnet-architecture/eShopOnContainers/
```

Than you must go to src folder and run:

```bash
docker compose up -d
```
In this case, the application will be launched on the http://host.docker.internal:5104/
Swagger will be able on http://host.docker.internal:5101

To kill application you must run: 
```bash
docker compose down
```
#### Deploy selenoid

You can start selenoid:
```bash
./start_selenoid_unix.sh
```

To kill selenoid you must run:

You can run:
```bash
./stop_selenoid_unix.sh
```

For Windows to deploy you can run with powershell

```bash
.\start_selenoid_win.ps1
```
For Windows to kill app you can run with powershell

```bash
.\stop_selenoid_win.ps1
```

If you want add android you must copy browsers.json to:

```bash
C:\Users\<user>\.aerokube\selenoid\browsers.json
```