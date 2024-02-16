const students = [];
const minGrade = 12;

window.addEventListener('load', function() {

    fetch('./eval.json')
    .then( function(_reponse){
        return _reponse.json();
    }).then(function(_results){
        addStudentsToTable(_results);
        showNbStudents();
        showAverage();
        showNbAboveAvg();
        showObtained();
    })
});


function addStudent(_student){
    try {
        checkStudent(_student)
        let lastName;
        let firstName;
        let line;
        let gradeElement;
        
        lastName = _student.fullname.split(' ')[0];
        firstName = _student.fullname.split(' ')[1];
        line = document.createElement('tr');
        
        line.appendChild(document.createElement('td')).textContent = lastName;
        line.appendChild(document.createElement('td')).textContent = firstName;
        gradeElement = document.createElement('td');
        gradeElement.textContent = _student.grade;
        gradeElement.classList.add('grade');
        line.appendChild(gradeElement);
    
        line.classList.add('line')
    
        document.getElementById('resultsBody').appendChild(line)
    } catch (_error) {
        console.log('Error: ' + _error)
    }
}

function checkStudent(_student){
    if (_student.grade < 0){
        throw new Error(_student.fullname + ' grade is lesser than 0')
    } else if (_student.grade > 20){
        throw new Error (_student.fullname + ' grade is greater than 20')
    } else if (_student.fullname.split(' ').length > 2){
        throw new Error (_student.fullname + ' name is invalid(too big)')
    } else if (_student.fullname.split(' ').length < 2){
        throw new Error(_student.fullname + ' name is invalid(too small)')
    }
}

function addStudentsToTable(_students){

    while (document.getElementById('resultsBody').firstChild){
        document.getElementById('resultsBody').removeChild(document.getElementById('resultsBody').firstChild)
    }


    _students.sort(function (a, b) {
        return b.grade - a.grade;
    });

    for (const student of _students){
        addStudent(student);
        if (students.indexOf(student) === -1){
            students.push(student);
        }
    }
}

function showNbStudents(){
    document.getElementById('nbStudents').textContent = 'Nombrre d\'étudiants : ' + students.length;
}

function getAverage(){
    let average = 0;

    for (let student of students){
        average += student.grade;
    }
    average /= students.length;
    average = Math.round(average * 100) / 100;
    return average;
}

function showAverage(){
    document.getElementById('classAverage').textContent = 'Moyenne de la classe : ' + getAverage();
}

function showNbAboveAvg(){
    let nbAboveAvg = 0;
    for (let student of students){
        nbAboveAvg = (student.grade > getAverage())?nbAboveAvg + 1:nbAboveAvg;
    }
    document.getElementById('nbAboveAverage').textContent = 'Nombre d\'étudiants au dessus de la moyenne : ' + nbAboveAvg;
}

function showObtained(){
    const lines = document.getElementsByClassName('line');


    if (!document.getElementById('obtainedHead')){
        const header = document.createElement('th');
        header.textContent = 'Obtenu';
        header.id = 'obtainedHead';
        document.getElementById('resultsHead').appendChild(header)
    }

    while (document.getElementsByClassName('obtained').length > 0){
        document.getElementsByClassName('obtained').remove()[0];
    }

    for (let i = 0; i < lines.length; i++){
        const obtained = document.createElement('td')
        obtained.id = 'obtained'
        if (students[i].grade >= minGrade){
            obtained.textContent = 'Oui';
        } else {
            obtained.textContent = 'Non';
        }
        lines[i].appendChild(obtained);
    }

}