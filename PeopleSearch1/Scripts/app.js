﻿
function getPeople() {
    return fetch("api/People");
};
console.log("worked");

var app = new Vue({
    el: '#wrapper',
    created: function () {
        this.grabPeople();
    },
    data: {
        searchText: "",
        loading: false,
        personsDisplay: [],
        persons: []
    },
    methods: {
        searchLoading: function () {
            // reset list of people displayed
            console.log("clicked");
            // Quick data validation
            if (this.searchText === "") {
                alert("Search box is empty. Please search by first or last name.")
                return;
            }
            this.personsDisplay = []
     
            this.loading = true


            for (let i = 0; i < this.persons.length; i++) {
                // Make everything uppercase for easier searching
                let first = this.persons[i].FirstName.toUpperCase();
                let last = this.persons[i].LastName.toUpperCase();
                if (last.indexOf(this.searchText.toUpperCase()) > -1 ||
                    first.indexOf(this.searchText.toUpperCase()) > -1) {
                    this.personsDisplay.push(this.persons[i])
       
                }
            }
            
            console.log("Display list", this.personsDisplay)
            console.log("Searched this name: ", this.searchText);
            this.loading = false
            this.searchText = ""

        },
        delayedClick: function () {
            setTimeout(this.searchLoading(), 500);
            // this.grabPeople();
        }, 
        grabPeople: function () {
            getPeople().then(response => {
                response.json().then(data => {
                    console.log("grabbed data")
                    console.log(data);
                    this.persons = data;
                });
            });
        }

    }
});
