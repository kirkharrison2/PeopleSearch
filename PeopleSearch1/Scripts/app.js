﻿
function getPeople() {
    return fetch("../api/People");
};
console.log("worked");

var app = new Vue({
    el: '#wrapper',
    created: function () {
        this.getPeopleList();
    },
    data: {
        searchText: "",
        loading: false,
        personsDisplay: [],
        persons: [],
        initialLoadFlag: true,
        pic: ""
    },
    methods: {
        searchPeople: function () {
            // reset list of people displayed                
            this.personsDisplay = [];

            for (let i = 0; i < this.persons.length; i++) {
                // Make everything uppercase for easier searching
                let first = this.persons[i].FirstName.toUpperCase();
                let last = this.persons[i].LastName.toUpperCase();
                if (last.indexOf(this.searchText.toUpperCase()) > -1 ||
                    first.indexOf(this.searchText.toUpperCase()) > -1) {
                    this.personsDisplay.push(this.persons[i]);
                }
            }
            
            console.log("Display list", this.personsDisplay)
            console.log("Searched this name: ", this.searchText);
            this.loading = false;
            this.initialLoadFlag = false;
            this.searchText = "";

        },
        delayedLoad: function () {
            if (this.validateSearchBox()) {
                this.loading = true;
                setTimeout(this.searchPeople, 2000);
            } else {
                return;
            }            
        },
        validateSearchBox: function () {
            if (this.searchText === "") {
                alert("Search box is empty. Please search by first or last name.")
                return false;
            } else {
                return true;
            }
        },
        getPeopleList: function () {
            this.loading = true;
            getPeople().then(response => {                
                response.json().then(data => {
                    this.persons = data;
                    this.personsDisplay = data;
                    this.loading = false;
                });
            });
        },
        getPic: function (person) {
            return person.PicUrl
        }

    }
});
