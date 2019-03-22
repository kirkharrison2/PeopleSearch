#People Search

Simple web application created in ASP.NET  and Vue.js to show a list of people and search based on first and last name.

## Front-End

The front-end consists of a single page application utilizing the Vue.js JavaScript framework to create the UI, manipulate the DOM, and bind data from the server onto the application in a table. The setTimeout() function in app.js is used to simulate a small loading time after a search is initialized.

## WebAPI

The standard REST endpoints are included in the PeopleController(create, list, update, etc), but only the GET /api/People request is used by the front-end client to retrieve the list of people.

## DB

The model in Person.cs was designed and used to create the local database using a code-first approach.