
This application asks for user input and then does some simple manipulations on the strings provided. The original is not mine, but taken from https://wellsb.com/csharp/

This project showcases a number of aspects of Visual Studio and its projects, as well as the use of git. 
It demonstrates the concept of unit testing and the refactoring necessary to have Visual Studio propose stubs for the unit tests.

It serves mostly as a personal learning experience.

What I learnt so far:
-how to prepare for using git by placing a .gitignore file in the project directory from github geared for C# specifically.
-how to git add files (to the staging area), commit them together with a message in a file using Atom.
-how to set global config parameters like name and e-mail in git
-how to amend a commit in case of a small error
-how to install the NUnit 3 plugin vxi file
-it's not possible to have a .NET Core (console) application generate unit tests: you need a .NET Framework (console) application
-to refactor, separate the business logic from the controlling code and extract methods
-it's possible to change the application from .NET Core to .NET Framework via the project options in VS:
Generate a .NET Framework app, close VS and copy over the relevant data to your project, specifically App.config and Properties folder. Adjust the GUID in the solution (add the GUID in the globalsection for debug and release "Debug|Any CPU.ActiveCfg", etc) and adjust the TargetFrameworkVersion in the project file. Throw away bin and obj folders. If there are problems, then remove the project from the solution and then add it back.
-right click on base class and select 'create unit tests'.

16-6-2021 
-added unit tests for methods ReverseString and RemoveWhitespace and ran them in Test Explorer





