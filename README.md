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
In this case, the application will be launched on the localhost:5000
(127.0.0.1:5000)

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