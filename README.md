# ATFramework


#### Deploy WEB application and Selenium Grid

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
Selenium grid will be launched on localhost:4444

To kill application you must run: 
```bash
docker compose down
```
