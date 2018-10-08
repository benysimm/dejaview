TODO: Make the most awesome backend the world has ever seen.

# dejaview-api

This is a dotnet core webapi (i.e. a REST API that returns simple JSON objects). It has a bunch of webapi controllers that simply return hardcoded data objects. The plan is to use this REST API with the React Javascript User Interface (UI). The hope is to eventually knock out the hardcoded data objects, and connect to an actual cloud (AWS?) hosted database.

If using VSCode, recommended to install the C# language extension to get intellisense, and other nice features.

I used this little guide to get going https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc

How to run. Using VSCode open Startup.cs, hit F5. Some example API endpoints:

    http://localhost:5000/api/scrapjob
    http://localhost:5000/api/scrapjob/4f817e9d3ad82887d8cac11f1c41e198

