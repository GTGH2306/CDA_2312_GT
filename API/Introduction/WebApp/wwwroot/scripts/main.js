const app = {
    data(){
        return {
            countries : [],
            selectedCountry : null,
            addCityName: "",
            addCityCode: "",
            addCityMsg: ""
        }
    },
    async mounted(){
        const response = await fetch('https://localhost:7068/api/Countries');
        this.countries = await response.json();
    },
    methods : {
        getFlagLink(_countryCode, _size){
            return "https://flagsapi.com/" + _countryCode + "/flat/" + _size + ".png"
        },
        selectCountry(_event) {
            const selected = _event.target.dataset.countryIndex
            this.selectedCountry = this.countries[selected];
        },
        unselectCountry(){
            this.selectedCountry = null;
        },
        bodyScroll(){
            if(this.selectedCountry === null){
                document.body.classList.remove('no-scroll')
            } else {
                document.body.classList.add('no-scroll')
            }
        },
        async addCity(e){
            e.preventDefault();
            if(this.addCityCode.length < 2 || this.addCityCode.length > 8){
                this.addCityMsg = "*Le Code Postal doit comprendre entre 2 et 8 caractères"
            } else {
                const cityToAdd = {
                    cityCode : this.addCityCode,
                    cityName : this.addCityName,
                    countryId : this.selectedCountry.id
                }
                const response = await fetch("https://localhost:7068/api/Cities", {
                    method: "POST",
                    body: JSON.stringify(cityToAdd),
                    headers: {
                      "Content-type": "application/json; charset=UTF-8"
                    }
                  });
                if(response.ok){
                    this.addCityMsg = "*Ville Ajoutée"
                    this.selectedCountry.cities.push(cityToAdd);
                } else {
                    this.addCityMsg = "*Erreur lors de la requête"
                }
            }
        },
        resetForm(){
            this.addCityCode = "";
            this.addCityName = "";
            this.addCityMsg = "";
        }
    },
    watch: {
        selectedCountry() {
            this.bodyScroll();
            if(this.selectedCountry === null){ this.resetForm() }
        }
    }
}

Vue.createApp(app).mount('#app')