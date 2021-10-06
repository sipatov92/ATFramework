# ATFramework


#### Deploy WEB application

For deploy application you must install
[Docker](https://www.docker.com/)

To check Docker you can use:

```bash
docker --version
```
To deploy application you must run:
```bash
docker compose up -d
```

App will be able on:
```bash
http://localhost/
```

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