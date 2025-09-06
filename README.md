# docker-dotnet-console

1. Build image
    ```bash
    docker image build -t hello-net .
    ```

2. Check image
    ```bash
    docker image ls
    ```

3. Run container
    ``` bash
    docker container run hello-net
    ```

Ref
https://github.com/DamirsCorner/20210305-dotnet-env-config/blob/master/EnvironmentConfiguration.Cli/Program.cs
https://lock29down.medium.com/using-iconfiguration-inside-console-app-net-core-5564c1493e0e