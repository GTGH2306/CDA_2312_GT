let babanes = 0
const tickrate = 200;
let timeoutHandle;


window.addEventListener('load', function() {
    
    
    setInterval(function(){
        showBabanes();
        
    });
});

document.getElementById('babaneImg').addEventListener('click', function(){
    playAnimation();
    babanes ++;
    showBabanes();
});



function playAnimation(){
    let babane = document.getElementById('babaneImg');

    if (babane.classList.contains('clicBabane')){
        clearTimeout(timeoutHandle);
        babane.classList.remove('clicBabane');
    }

    setTimeout(() =>{
        babane.classList.add('clicBabane');
    }, 1);

    timeoutHandle = setTimeout(() =>{
        babane.classList.remove('clicBabane')
    }, 300);

}

function showBabanes(){
    document.getElementById('babaneNb').innerHTML = babanes;
}