%systemroot%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe stfu.sln /t:Build /p:Configuration=Release;Platform=x64 /flp:Verbosity=normal;PerformanceSummary;Summary;Append;LogFile=build-release-x64.log /m