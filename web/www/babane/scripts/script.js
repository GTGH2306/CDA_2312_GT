let babanes = 0
const tickrate = 200;


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

    babane.classList.add('clicBabane');
    setTimeout(() =>{
        babane.classList.remove('clicBabane')
    }, 300);
}

function showBabanes(){
    document.getElementById('babaneNb').innerHTML = babanes;
}