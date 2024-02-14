
let response;

window.addEventListener('load', function(){
    getResponse().then(data => {
        response = data;
        createHtmlElement(response)
        showMostPlayed(response)
        showBestRation(response)
    })

    
});

async function getResponse(){
    let retour;
    retour = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    retour = await retour.json();
    return retour;
}

function createHtmlElement(_response) {

    let firstLine = document.createElement('tr')
    let keys = [];

    for (let key in _response[0]){
        let line = document.createElement('th');
        line.innerHTML = key;
        keys.push(key);
        firstLine.appendChild(line);
    }
    document.getElementById('tableau').appendChild(firstLine);

    for (let card of _response){
        let newLine = document.createElement('tr');
        for (let i = 0; i < keys.length; i++){
            let value = document.createElement('td')
            if (card[keys[i]] !== undefined){
                value.innerHTML = card[keys[i]]
            }
            newLine.appendChild(value);
        }
        document.getElementById('tableau').appendChild(newLine);
    }
}

function showMostPlayed(_cards){
    const mostPlayedElement = document.getElementById('mostPlayed');
    let mostPlayedIndex;
    let maxPlayed;
    
    for (let i = 0; i < _cards.length; i++){
        if (_cards[i].played > maxPlayed || maxPlayed === undefined){
            mostPlayedIndex = i;
            maxPlayed =_cards[i].played;
        }
    }

    mostPlayedElement.innerHTML = 'Carte la plus jouée: ' + _cards[mostPlayedIndex].name + ' avec ' + _cards[mostPlayedIndex].victory + ' victoires.';

}

function showBestRation(_cards){
    const bestRatioElement = document.getElementById('bestRatio');
    let bestRatioIndex;
    let bestRatio;
    
    for (let i = 0; i < _cards.length; i++){
        let ratio = _cards[i].victory / _cards[i].defeat;

        if (ratio > bestRatio || bestRatio === undefined){
            bestRatioIndex = i;
            bestRatio = ratio;
        }
    }

    bestRatioElement.innerHTML = 'Carte avec le meilleur ratio: ' + _cards[bestRatioIndex].name + ' avec ' + _cards[bestRatioIndex].victory + ' victoires sur ' + _cards[bestRatioIndex].played + ' parties.';

}