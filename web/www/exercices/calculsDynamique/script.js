var tabLines = [document.getElementById('Line1')];

function addLine(){
    let id = tabLines.length + 1;
    let name = 'Line' + id;

    let labelQte = document.createElement('label');
    let labelPrixUni = document.createElement('label');
    let labelPrix = document.createElement('label');
    let champQte = document.createElement('input');
    let champPrixUni = document.createElement('input');
    let champPrix = document.createElement('input');
    let ligne = document.createElement('div');

    ligne.id = name;

    labelQte.setAttribute('for', ('Qte' + id));
    labelQte.textContent = 'Qté:';
    labelPrixUni.setAttribute('for', ('PrixUni' + id));
    labelPrixUni.textContent = 'Prix Unitaire:';
    labelPrix.setAttribute('for', ('Prix' + id));
    labelPrix.textContent = 'Prix:';


    //Setup du champ Qte
    champQte.setAttribute('type', 'text');
    champQte.setAttribute('onchange', 'calculPrix(' + id + ')');
    champQte.setAttribute('value', 0);
    champQte.setAttribute('name', 'Qte' + id);
    champQte.id ='Qte' + id;

    //Setup du champ Prix Unitaire
    champPrixUni.setAttribute('type', 'text');
    champPrixUni.setAttribute('onchange', 'calculPrix(' + id + ')');
    champPrixUni.setAttribute('value', 0);
    champPrixUni.setAttribute('name', 'PrixUni' + id);
    champPrixUni.id ='PrixUni' + id;

    //Setup du champ Prix
    champPrix.setAttribute('type', 'text');
    champPrix.setAttribute('onchange', 'calculPrix(' + id + ')');
    champPrix.setAttribute('value', 0);
    champPrix.setAttribute('name', 'Prix' + id);
    champPrix.id ='Prix' + id;

    //Attribution des enfants
    ligne.appendChild(labelQte);
    ligne.appendChild(champQte);
    ligne.appendChild(labelPrixUni);
    ligne.appendChild(champPrixUni);
    ligne.appendChild(labelPrix);
    ligne.appendChild(champPrix);


    tabLines.push(ligne);
    //Ajout au HTML
    document.getElementById('Lines').appendChild(ligne);
}

function removeLine(){
    document.getElementById('Lines').removeChild(tabLines[tabLines.length - 1]);
    tabLines.pop();
    calculTotal();
}

function calculPrix(_ligne){
    let qte = document.getElementById("Qte" + _ligne);
    let prixUni = document.getElementById("PrixUni" + _ligne);
    let prix = document.getElementById("Prix" + _ligne);
    

    prix.value = qte.value * prixUni.value;
    calculTotal();

    
}

function calculTotal(){
    let champTotal = document.getElementById('champTotal');
    let total = 0;
    for(let i = 0; i < tabLines.length; i++){
        let prix = document.getElementById('Prix' + (i + 1));
        total += parseFloat(prix.value);
    }
    champTotal.value = total;
}