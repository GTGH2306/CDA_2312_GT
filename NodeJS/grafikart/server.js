let http = require('http'); //permet de gerer des requêtes HTTP
let fs = require('fs'); //FS = FileSystem pour pouvoir gerer des fichiers
let url = require('url'); //Ajoute des methodes de parsing(entre autre) pour l'url
const EventEmitter = require('events')


let App = {
    start: function(_port) {
        let emmitter = new EventEmitter()
        let server = http.createServer((_request, _response) =>{
            _response.writeHead(200, {
                'Content-type': 'text/html; charset=utf-8'
            })
            if(_request.url === '/') {
                emmitter.emit('root', _response)
            }
            _response.end();
        }).listen(_port)

        return emmitter
    }
}

let app = App.start(80)
app.on('root', (_response) => {
    _response.write('Je suis à la racine')
})

// let monEcouteur = new EventEmitter();
// monEcouteur.on('saute', (_a, _b) => {
//     console.log(`J'ai sauté` + _a + _b)
// })

// monEcouteur.emit('saute', 10, 20)
// monEcouteur.emit('saute')

// let server = http.createServer();
// //On peux utiliser la fonction anonyme directement dans le constructeur

// server.on('request', (_request, _response) => {
    
//     let query = url.parse(_request.url, true).query
//     // if (query.name === undefined) {
//     //     _response.write('Bonjour, Anonyme')
//     // } else {
//     //     _response.write('Bonjour, ' + query.name)
//     // }
//     let name = query.name === undefined? 'anonyme' : query.name;

//     fs.readFile('index.html', 'utf8', (_err,  _data) => {
//         //if (_err) throw _err; //Throw l'erreur s'il y'en a une
//         //La suite ne s'execute pas s'il y'a eu une erreur.
//         if (_err) {
//             _response.writeHead(404);
//             _response.end("Ce fichier n'existe pas");
//         } else {
//             _response.writeHead(200, { //On ecrit le code 200 dans l'en-rête pour dire que la requête à réussit
//                 'Content-type': 'text/html; charset=utf-8' //Ici on indique que la reponse est un texte html avec le charser utf8
//             });
//             _data = _data.replace('{{ name }}', name);
//             _response.write(_data); //Renvoi les données demandées
//             // _response.end(`Salut comment ça va?`); //Le serveur renvoi "Salut comment ça va" à chaque requête
//             _response.end(); //Termine la réponse (fonctionne comme writr pour le parametre)
//         }
//     });
// });
 
// server.listen(8080)