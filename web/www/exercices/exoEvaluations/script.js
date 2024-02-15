const minGrade = 12;
let students = [];

window.addEventListener('load', function() {

    fetch('./eval.json')
    .then( function(_reponse){
        return _reponse.json();
    }).then(function(_results){
        addAllStudents(_results);
        showNbStudents();
        showAverage();
        showNbAboveAvg();
        addObtained();
    })
});

document.getElementById('addStudent').addEventListener('click', function(){
    let fullnameText = document.getElementById('fullname');
    let gradeText = document.getElementById('grade');

    addStudent(fullnameText.value, gradeText.value);
    showNbStudents();
    showAverage()
    showNbAboveAvg()
});

function addAllStudents(_results){
    _results.sort(function (a, b) {
        return b.grade - a.grade;
    });

    for (let student of _results){
        addStudent(student.fullname, student.grade);
        students.push(student);
    }
}

function addStudent(_fullname, _grade){
    let lastName;
    let firstName;
    let line;
    let gradeElement;

    lastName = _fullname.split(' ')[0];
    firstName = _fullname.split(' ')[1];
    line = document.createElement('tr');
    
    line.appendChild(document.createElement('td')).textContent = lastName;
    line.appendChild(document.createElement('td')).textContent = firstName;
    gradeElement = document.createElement('td');
    gradeElement.textContent = _grade;
    gradeElement.classList.add('grade');
    line.appendChild(gradeElement);

    line.classList.add('line')

    document.getElementById('resultsBody').appendChild(line)
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

function addObtained(){
    document.getElementById('resultsHead').appendChild(document.createElement('th')).textContent = 'Obtenu'

    for (let i = 0; i < students.length; i++){
        if (students[i].grade >= minGrade){
            document.getElementsByClassName('line')[i].appendChild(document.createElement('td')).textContent = 'Oui'
        } else {
            document.getElementsByClassName('line')[i].appendChild(document.createElement('td')).textContent = 'Non'
        }
    }

    document.getElementById('list').appendChild(document.createElement('li')).textContent = 'Note éliminatoire : ' + minGrade;
}