const app = {
    data(){
        return {
            countries : []
        }
    },
    async mounted(){
        const response = await fetch('https://localhost:7068/api/Countries');
        this.countries = await response.json();
    },
    methods : {
        getFlagLink(_countryCode, _size){
            return "https://flagsapi.com/" + _countryCode + "/flat/" + _size + ".png"
        }
    }
}

Vue.createApp(app).mount('#app')