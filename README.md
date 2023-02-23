# Sonic Orbitron

#### By **Hans Ellis, Peter Philavanh, Greg Ramsower, Jonathan Liera**

### Push buttons, play sounds!

## Technologies Used
* C#
* .NET7
* XAML
* Git
* VisualStudio 2022

### Description
* This program presents the user with a selection of buttons that, when pressed, play a notes comprising an octave between Middle C and C5.
* The layout is structred to provide the user with a hint for the next note in the octave.
* When the user presses a button, the button animates and plays a note. 
* The next button on the scale then appears for the user to click in sequence. 

### Application Instructions
* NOTE: 
  - Before running the program, the user must have Visual Studio 2022 installed. Visit [this link](https:https://visualstudio.microsoft.com/vs/) to download Visual Studio and for additional information.
  - Follow [this tutorial](https://learn.microsoft.com/en-us/training/modules/write-your-first-windows10-app/2-writing-wpf-app) if you have not installed a WPF application before.

#### Initial Setup 
1. Open Visual Studio and select 'Clone A Repository' and paste this link into the Repository Location field: https://github.com/mrhansellis/pianoalpha4.solution.git
2. Navigate to MainWindow.xaml.cs. The code on lines 82 - 89 must be changed to match the path on your computer. 
	```C4Note =  new Uri("file:///C:/YourPath/path/pianoalpha4.Solution/PianoAlpha4/Resources/c4.mp3");```
2. Within Visual Studio, press the green arrow at the top center of the screen which will run the program.
3. Enjoy!

## Known Bugs
* Does not work on non-Intel/Windows PCs
* Quick successive mouse clicks will cancel animations and cause them to stack (resulting in incomplete or 'paused' animations)

## License

* Licensed under GNU license v3.0

