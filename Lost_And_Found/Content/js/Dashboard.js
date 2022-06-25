function openCloseSidebar() {
    var checked = document.getElementById("header-hamburger__checkbox");

    if(checked.checked == true) {
        document.getElementById("sidebar").setAttribute("style", "width: 16rem; overflow: visible; transition: all 0.15s ease");
    }
    else {
        document.getElementById("sidebar").setAttribute("style", "width: 3.3rem; overflow:hidden; transition: all 0.15s ease");
    }
}