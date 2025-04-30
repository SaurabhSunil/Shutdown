## Steps to Reproduce
 1. Build the shutdown project in Debug mode. This is required as docker file uses ./bin/Debug/net8.0 to copy from.
 2. Build the docker image. For this navigate to the Shutdown project location
   `docker build . -t shutdown-trial`
 3. Run a container using the image shutdown-trial
 4. Stop the container after starting

## Behavior

This does not write "Stopping my Application..." to the console when using `mcr.microsoft.com/dotnet/runtime:8.0-windowsservercore-ltsc2019`

## Expected behavior 

Writes  "Stopping my Application..." to the console.
