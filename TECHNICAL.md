# Number to Words Converter
## Technical Architecture Document

The application is composed of following 2 projects:

1. **NumberToWordConvert** is the main project containing all the code files of the application.
2. **NumberToWordConvert.Tests** contains all the tests of the application.

The main project NumberToWordConvert is composed of the following layers:

### 1. Applicaiton Layer
The application comprises of a HTML file **index.html** which is the starting point of the application. This html file acts as the **View** of the application, with the corresponding logic/code written in the **myscript.js** file (inside **script** folder) which acts as the **Controller** of the Application / Front-End Layer. This is accompanied by the **Site.css** file (inside **Content** folder).

### 2.	API Layer
**ConversionController** is the file containing the actual API logic in the form of a **Get** function. This acts as the WebAPI of the application.

### 3.	Service Layer
**NumberToWord.cs** is the file containing the single service for this application in the form of a public method **Convert** of class **MoneyToWords**. This service is responsible to convert a number (currency value) into words and return it to the API Layer.

The following classes are shared by multiple layers:

**NameAndMoney** (inside **NameAndMoney.cs**)


