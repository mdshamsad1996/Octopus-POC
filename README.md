## Steps

    step 1
    I have created an web application MyApp using .Net Framework,
    simple printing Hello World from <Env key> on localhost port no 8080
    In Web.Config add key  Env
        <appSettings>
             <add key="Env" value="Dev"/>
        </appSettings>
        
    Create nuspec file using below command
            nuget spec Myapp.csproj
            

    put required file in MyApp.nuspec to make nuget package for example
        <files>
            <file src="bin\**" target="bin" />
            <file src="*.asax" target="." />
            <file src="Web.config" target="." />
            <file src="packages.config" target="." />
        </files>
  
    Create a nudget package using below bat script
            del *.nupkg
            nuget.exe pack MyApp.nuspec -Prop Configuration=Debug -Version 1.0.0 -Properties
            
    Push/upload nudget package to octopus server

   Step 2 : Octopus part
   
    Octopus Deploy is an automated deployment and release management server.
    It is designed to simplify deployment of ASP.NET applications



    i)Add Environments in Infrastructure of Octopus
        a.Dev
        b.Test
        c.Prod

![](https://github.com/mdshamsad1996/Octopus-POC/blob/master/Screenshots/Octopus_Environment.JPG)






     ii)Install Tentacle Manager and then Add Polling Tentacle 

![](https://github.com/mdshamsad1996/Octopus-POC/blob/master/Screenshots/Tenant.JPG)

    
    iii) Add Environment Variable to replace value of web.config using key Env for diffrent Environment
    
    
  ![](https://github.com/mdshamsad1996/Octopus-POC/blob/master/Screenshots/EnvironmentVariable.JPG)


     iv)Create a Pipeline on Octopus server to Deploy our Application on Dev,Test and
         Prod environment
         
         
  ![](https://github.com/mdshamsad1996/Octopus-POC/blob/master/Screenshots/OctopusPipeline1.JPG)
  
  ![](https://github.com/mdshamsad1996/Octopus-POC/blob/master/Screenshots/OctopusPipeline2.JPG)
     
         
      
