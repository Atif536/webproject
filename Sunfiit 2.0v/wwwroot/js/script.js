
var searchForm = document.querySelector('.search-form');
document.querySelector('#search-btn').onclick = () => {
    searchForm.classList.toggle('active');
    cartbtn.classList.remove('active');
    loginbtn.classList.remove('active');
    menu.classList.remove('active');
}
var cartbtn = document.querySelector('.shopping-cart');
document.querySelector('#cart-btn').onclick = () => {
    cartbtn.classList.toggle('active');
    searchForm.classList.remove('active');

    loginbtn.classList.remove('active');
    menu.classList.remove('active');
}
var loginbtn = document.querySelector('.login-form');
document.querySelector('#login-btn').onclick = () => {
    loginbtn.classList.toggle('active');
    searchForm.classList.remove('active');
    cartbtn.classList.remove('active');

    menu.classList.remove('active');
}
var menu = document.querySelector('.navbar');
document.querySelector('#menu-btn').onclick = () => {
    menu.classList.toggle('active');
    searchForm.classList.remove('active');
    cartbtn.classList.remove('active');
    loginbtn.classList.remove('active');

}
window.scroll = () => {
    searchForm.classList.remove('active');
    cartbtn.classList.remove('active');
    loginbtn.classList.remove('active');
    menu.classList.remove('active');

}
