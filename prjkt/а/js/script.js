$(document).ready(() => {
    $('.res-btn').on('click',(e) => {
    e.preventDefault();
    let wood = Number(document.querySelector('.wood').value);
    let length = Number(document.querySelector('.length').value);
    let width = Number(document.querySelector('.width').value);
    let height = Number(document.querySelector('.height').value);
    let wall = Number(document.querySelector('.wall').value);
    wood = wood/1000;
    console.log(wood);
    let result = ((length+width+wall+(length+width))*height)/wood;
    console.log(result);
    document.getElementById('result').innerHTML = result;
    })
})