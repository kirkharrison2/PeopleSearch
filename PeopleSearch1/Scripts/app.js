
function getPeople() {
    return fetch("api/People");
};
console.log("worked");

var app = new Vue({
    el: '#wrapper',
    created: function () {
        this.grabPeople();
        this.personsDisplay = this.persons;
    },
    data: {
        searchText: "",
        loading: false,
        personsDisplay: [],
        persons: []

    },
    methods: {
        searchLoading: function () {
            this.personsDisplay = []
            this.loading = true
            for (let i = 0; i < this.persons.length; i++) {
                if (this.persons[i].LastName.indexOf(this.searchText.toUpperCase()) > -1 ||
                    this.persons[i].FirstName.indexOf(this.searchText.toUpperCase()) > -1) {
                    this.personsDisplay.push(this.persons[i])
                }
            }
            this.loading = false

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
