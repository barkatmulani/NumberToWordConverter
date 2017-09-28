# Number-to-Words Converter
## Technical Document

### Minimum Requirements

This application is created in Microsoft .NET 4.5.1 using Visual Studio 2012. The minimum requirements to run this application are as follows:

### Operating System
Windows 7 (or later) must be installed.

### Code Editor / IDE
Visual Studio 2012 (or later) must be installed.

### .NET Framework Version
.NET Framework 4.5.1 must be installed.

### Browser
Application could be run on any browser supporting ES6, i.e. the latest version of Mozilla Firefox or Google Chrome.

---

### Software Architecture

The application is composed of following 2 projects:

1. **NumberToWordConvert** is the main project containing all the code files of the application.
2. **NumberToWordConvert.Tests** contains all the tests of the application.

The main project NumberToWordConvert is composed of the following layers:

#### 1. Applicaiton Layer
The application comprises of a HTML file **index.html** which is the starting point of the application. This html file acts as the **View** of the application, with the corresponding logic/code written in the **myscript.js** file (inside **script** folder) which acts as the **Controller** of the Application / Front-End Layer. This is accompanied by the **Site.css** file (inside **Content** folder).

#### 2.	API Layer
**ConversionController** is the file containing the actual API logic in the form of a **Get** function. This acts as the WebAPI of the application.

#### 3.	Service Layer
**NumberToWord.cs** is the file containing the single service for this application in the form of a public method **Convert** of class **MoneyToWords**. This service is responsible to convert a number (currency value) into words and return it to the API Layer.

The following classes are shared by multiple layers:

**NameAndMoney** (inside **NameAndMoney.cs**)

---
