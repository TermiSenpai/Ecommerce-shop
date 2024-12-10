function toggleMenu() {
    const sideMenu = document.getElementById("sideMenu");
    if (sideMenu.classList.contains("open")) {
        sideMenu.classList.remove("open"); // Cierra el menú
    } else {
        sideMenu.classList.add("open"); // Abre el menú
    }
}

function closeMenu() {
    document.getElementById("sideMenu").classList.remove("open"); // Solo cierra el menú
}
