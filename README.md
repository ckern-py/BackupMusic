# BackupMusic 
This is a repo containing a console app I created that backs up my music files.

## Description
This repo contains a console app I created that backs up my music files. Copying them from my main music directory into my backup music directory. The program will walk a source directory and a target directory. Then do a comparison between both directories to find any differences. After finding all the differences it will copy the files that don't exist in the target directory from the source directory so that both directories are matching. 

## Install
Installing this application should be simple. You need to make sure you have NETFramework Version 4.7.2 installed. Then you can clone the repo in Visual Studio and open the solution file.

## Use
To use the project you'll first need to load it up in Visual Studio. After loading you’ll need to make sure the source directory and target directory are pointing to the correct locations. Once both directories are correct, you'll be able to run the project. The project will walk through both directories getting a list of all files. Once that is done it will do a compare to find any differences. After differences are found it will go through and create all the new folders it requires. Then it will copy the necessary files from the source directory to the target directory. 

## License
[GNU GPLv3](https://choosealicense.com/licenses/gpl-3.0/)
