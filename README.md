The application will MP3 files in WPF.
The Media Player allows user to select file by clicking the open file button, then select the file. 
User then clicks the Load button to load the file into the player.
Once file is loaded into player, user can click the Play button to play file.
User can also click the Repeat button to loop through the file. //Currently does not repeat. Will be fixed soon.
Once user is finished, user can click the Stop button to stop the file or Exit button to exit the application.
This is my second project from what I've learned about C# and XAML.
There has been some improvements from my last application but this applications still needs improvements.
I've added a progress bar to give a progress of the file while playing and also a timer to show minutes and seconds of the file and total time of file.
I was able to fix application from crashing by adding the HasTimeSpan property so that I can use TimeSpan for the timer and progress bar.
Application runs perfectly fine now.
