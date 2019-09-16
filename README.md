# BC Assignment
BC Assignment

Create a small C# ASP.NET or .NET Core webpage/web application using the MVC or MVVM framework that fulfills the requirements below

User Story: 
As a student, I would like to view a list of available English courses at Bellevue College, so I know what classes are available for me to take. 

Data Source:
Course information is from https://www2.bellevuecollege.edu/data/api/v1/courses/engl 

Page design and implementation consideration:
Above the list of courses, the followings are included
  - Use one department image from current department site (Department Name is included)
  - Use the department mission statement from web site as the introduction of this page
The available course section should have the following details
  - A message like "No available course found at this time..." is displayed if no course is available
  - A number of available courses were retrieved can be used
  - A page header of "Available Courses" + (counter) is added
  - A table is used to show the list of all available English courses 
  - Use common and easy to read font - default one is used
  - Table header shows Title, Credits, and Description with bold
  - Table content shows each course Title, Number of Credits, and Description below the header defined above
  - Use simple colors. Dark/Black for the font and off-white/light-gray for the background 
  - Alternating row color with off-white/light-gray in the table for better readability
  - Font size can be adjusted by using Ctrl + '+' or Ctrl + '-' in the browser
  - Sort the title with descending order
  
Test cases used
  - No data is returned from the request
  - A list of courses is returned from the request
