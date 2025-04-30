# Use the runtime image for running the application  


# Windows server core does not shut down gracefully
FROM mcr.microsoft.com/dotnet/runtime:8.0-windowsservercore-ltsc2019 AS base  

# nano-server does shut down gracefully
# FROM mcr.microsoft.com/dotnet/runtime:8.0-nanoserver-1809 AS base  
WORKDIR /app  

# Copy pre-built Debug files from the host machine into the container  
COPY ./bin/Debug/net8.0/ ./  

# Set the entry point for the application  
ENTRYPOINT ["dotnet", "Shutdown.dll"]