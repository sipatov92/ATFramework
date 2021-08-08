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
For Unix OS first of all you need to give permissions:
```bash
chmod u+r+x ./start_selenoid.sh
```

After that you can start selenoid:
```bash
./start_selenoid.sh
```

To kill selenoid you must run:

For Unix OS first of all you need to give permissions:
```bash
chmod u+r+x ./stop_selenoid.sh
```
After that you can run:
```bash
./stop_selenoid.sh
```