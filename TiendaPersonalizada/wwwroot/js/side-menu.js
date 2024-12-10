function toggleMenu() {
    const sideMenu = document.getElementById("sideMenu");
    if (sideMenu.classList.contains("open")) {
        sideMenu.classList.remove("open"); // Cierra el men�
    } else {
        sideMenu.classList.add("open"); // Abre el men�
    }
}

function closeMenu() {
    document.getElementById("sideMenu").classList.remove("open"); // Solo cierra el men�
}
