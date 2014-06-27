$(document).ready(function () {

    load();
    
});

function load() {

    var url = "/minesweeper/data";
    $.getJSON(url, function (data) {
        document.grid = data;
    });
    registerClick();
}

function registerClick() {

    $("td").click(function () {
        var row = cellRow(this);
        var col = cellCol(this);
        if (document.grid[row][col] == "bomb") {
            $(this).addClass("lost");
        }
        else {
            $(this).addClass("safe");
        }
    });
}

function cellRow(cell) {
    return parseInt(cell.id.substring(5, 6)) - 1;
}

function cellCol(cell) {
    return parseInt(cell.id.substring(7, 8)) - 1;
}