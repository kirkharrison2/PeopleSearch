
var app = new Vue({
    el: '#wrapper',
    data: {
        searchText: "",
        loading: false,
        personsDisplay: [],
        persons: [
            {
                firstName: "MICHAEL",
                lastName: "SCOTT",
                address: "Dunder Mifflin",
                age: "45",
                interests: "Improv",
                pic: "ADD LINK HERE"
            }


        ]

    },
    methods: {
        searchLoading: function () {
            this.personsDisplay = []
            this.loading = true
            for (let i = 0; i < this.persons.length; i++) {
                if (this.persons[i].lastName.indexOf(this.searchText.toUpperCase()) > -1 ||
                    this.persons[i].firstName.indexOf(this.searchText.toUpperCase()) > -1) {
                    this.personsDisplay.push(this.persons[i])
                }
            }
            this.loading = false

        },
        delayedClick: function () {
            setTimeout(this.searchLoading(), 2000)
        }

    },
    created: function () {

    }
});
