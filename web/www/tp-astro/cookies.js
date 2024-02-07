function addCookie(_name, _value){
    document.cookie = _name + '=' + _value
}

function getCookie(_name){
    const cookies = document.cookie.split('; ');
    const cookie = cookies.find(c => c.startsWith(_name));
    return cookie.split('=')[1];
}