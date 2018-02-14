# TC_WebApi_Website
 
Details of applications : 
	This application is developed for accepting name and number and converting it to word format. 
	The application demonstrates how to make use of a API based design.
	It consists of a simple web page that accepts inputs from user and a web API that is used for processing of the data. 
	The final result is passed back to the web page and it is displayed on the web page.

Development tool : 
	>>Visual Studio 2017
	>>Target .Net Framework: 4.6.1
	
Steps to run the application : 
	>>Open the solution file (PersonDetails.sln) in Visual Studio 2017.
	>>Press F5
	
Technical description : 
	The application contains the following modules
	>>UI  : Developed using HTML, AJAX and Jquery
	>>API : Web API
	>>Unit Test : Developed using MSTest
 
 
Programming techniques utilized : 
	>>The UI page is developed using HTML. Jquery and Ajax.
 	>>UI validation is done using ajax
	>>Using an ajax call, a Post request is send to the WebApi component.
	>>The logic required to convert the number to words is implement is a class named Conversion 
	>>Model class and ModelDTO classes are used.
