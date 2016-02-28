# EfPowerTools
Entity Framework Power Tools custom .tt templates.

This project has included Entity Framework 6 and [Entity Framework Power Tools](https://visualstudiogallery.msdn.microsoft.com/72a60b14-1581-4b9b-89f2-846072eff19d). 

For using EF Power Tools in Visual Studio 2015 check this question and answer on [StackOverflow](http://stackoverflow.com/questions/27999235/how-to-use-entity-framework-power-tools-in-visual-studio-2015).

The main goal of this project is to show how to specify filtering for a subset of tables specified by a string array. Nothing special is added to this project, POCO and mapping classes are basic, the only change is filtering for tables inside .tt template files.
The change is documented with: 

// START Filter for specific tables only
...

