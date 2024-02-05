function returnDate(){
    const currentDate = new Date();
    let retour = '';

    retour += currentDate.getDate() + '/' + (currentDate.getMonth() + 1) + '/' + currentDate.getFullYear()
    return retour;
}

function returnHour(){
    const currentDate = new Date();
    let retour ='';

    retour += currentDate.getHours().toString() + ":" + currentDate.getMinutes().toString() + ":" + currentDate.getSeconds();
    return retour;
}

function applyDate(){
    let champ = document.getElementById('date');
    champ.value = returnDate();
}

function applyHour(){
    let champ = document.getElementById('heure');
    champ.value = returnHour();
}