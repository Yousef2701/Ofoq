document.querySelectorAll("#supscripe").forEach(ele => {
    ele.onchange = () => {
        ele.value = ele.checked;
        document.getElementById("submit").classList.remove("d-none");
    }
})
let searchCol = document.querySelector(".search select").value;
document.querySelector(".search select").onchange = () => {
    searchCol = document.querySelector(".search select").value;
    search();
}
function search() {
    let search = document.getElementById('search').value.toLowerCase();
    let tr = document.querySelectorAll('tbody tr');
    for (let i = 0; i < tr.length; i++) {
        let name = tr[i].children[searchCol].getElementsByTagName("h3")[0];
        let value = name.innerHTML || name.innerText || name.textContent;
        if (value.toLowerCase().indexOf(search) > -1) {
            tr[i].style.display = '';
        }
        else {
            tr[i].style.display = 'none';
        }
    }
}