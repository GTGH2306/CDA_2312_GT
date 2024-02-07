window.addEventListener('load', function(){
    let selectDay = document.getElementById('jour');
    let selectYear = document.getElementById('annee');
    let currentYear = new Date().getFullYear();

    for (let i = 0; i <= 31; i++){
        let option = document.createElement('option');
        if (i == 0){
            option.value = 'unselected';
            option.text = 'Choisissez votre jour';
        } else {
            option.value = i;
            option.text = i;
        }
        
        selectDay.appendChild(option);
    }

    for (let i = currentYear; i >= 1900; i--){
        let option = document.createElement('option');
        option.value = i;
        option.text = i;
        selectYear.appendChild(option);
    }

    for (let element of document.getElementsByClassName('formElement')){
        if (element.id == 'firstname' ||
        element.id == 'uname' ||
        element.id == 'jour' ||
        element.id == 'mois') {
            element.addEventListener('change', function(){
                document.getElementById('pseudo').value = calculerPseudo()
            });
        }

        element.addEventListener('change', function(){
          document.getElementById('submit').disabled = !formOk();
        });
    }


});

document.getElementById('submit').addEventListener('click', function(){
    for (let element of document.getElementsByClassName('formElement')){
        addCookie(element.name, element.value);
    }
    window.location.href = './Accueil.html';
});

function valNum(_mot){
    const alphabet = 'A B C D E F G H I J K L M N O P Q R S T U V W X Y Z'.split(' ');
    let retour = 0;
    _mot = _mot.toUpperCase();

    for (let caracter of _mot){
        retour += alphabet.indexOf(caracter) + 1;
    }
    return retour;
}

function calculerSigne(_jour, _mois){
    const signes = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];
    let retour;

    switch(_mois){
        case 'janvier':
            retour = (_jour <= 20)?signes[0]:signes[1];
            break;
        case 'fevrier':
            retour = (_jour <= 19)?signes[1]:signes[2];
            break;
        case 'mars':
            retour = (_jour <= 20)?signes[2]:signes[3];
            break;
        case 'avril':
            retour = (_jour <= 19)?signes[3]:signes[4];
            break;
        case 'mai':
            retour = (_jour <= 20)?signes[4]:signes[5];
            break;
        case 'juin':
            retour = (_jour <= 21)?signes[5]:signes[6];
            break;
        case 'juillet':
            retour = (_jour <= 22)?signes[6]:signes[7];
            break;
        case 'aout':
            retour = (_jour <= 22)?signes[7]:signes[8];
            break;
        case 'septembre':
            retour = (_jour <= 22)?signes[8]:signes[9];
            break;
        case 'octobre':
            retour = (_jour <= 23)?signes[9]:signes[10];
            break;
        case 'novembre':
            retour = (_jour <= 22)?signes[10]:signes[11];
            break;
        case 'decembre':
            retour = (_jour <= 22)?signes[11]:signes[0];
            break;
    }

    return retour;
}

function formOk(){
    //let form = document.getElementById('form');
    const form = document.getElementsByClassName('formElement');
    let retour = true;

    for (const element of form) {
        switch (element.tagName){
            case 'TEXTAREA':
                if (element.value == ''){
                    retour = false;
                    //console.log(element.name + ' donne false')
                }
            break;
            case 'INPUT':
                if (element.type == 'text' && !element.readOnly){
                    if (element.value == ''){
                        retour = false;
                        //console.log( element.name + ' donne false')
                    }
                }
            break;
            case 'SELECT':
                if (element.value == 'unselected') {
                    retour = false;
                    //console.log( element.name + ' donne false')
                }
            break;
        }
    }

    return retour;
}

function calculerPseudo(){
    const jour = document.getElementById('jour').value;
    const mois = document.getElementById('mois').value;
    const uname = document.getElementById('uname').value;
    const firstname = document.getElementById('firstname').value;
    let retour = '';

    if(jour != 'unselected' && uname != '' && firstname != ''){
       retour = calculerSigne(jour, mois) + (valNum(uname) + valNum(firstname));
    }
    
    return retour;
}