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
        checkCell(row, col);
    });
}

function checkCell(row, col) {

    var elementId = cellId(row + 1, col + 1);
    $(elementId).removeClass("lost");
    $(elementId).removeClass("safe");
    $(elementId).removeClass("suspect");
    $(elementId).text("");

    if ($("#suspect-mode").is(':checked')) {
        $(elementId).addClass("suspect");
    }
    else {
        if (document.grid[row][col] == "bomb") {
            $(elementId).addClass("lost");
        }
        else {
            checkSafeCell(row, col);
        }
    }
}

function checkSafeCell(row, col) {

    if (document.grid[row] != undefined) {
        if (document.grid[row][col] != undefined) {

            if (document.grid[row][col] != "bomb") {

                var elementId = cellId(row + 1, col + 1);

                $(elementId).addClass("safe");
                var count = countNeighbors(row, col);
                if (count > 0) {
                    $(elementId).text(count.toString());
                }
                else {
                    $(elementId).text("");
                    openField(row, col);
                }
            }
        }
    }
}

function openField(row, col) {

    checkSafeCell(row - 1, col);
    checkSafeCell(row + 1, col);
    checkSafeCell(row, col + 1);
    checkSafeCell(row, col - 1);
    checkSafeCell(row + 1, col + 1);
    checkSafeCell(row + 1, col - 1);
    checkSafeCell(row - 1, col + 1);
    checkSafeCell(row - 1, col - 1);
}

function countNeighbors(row, col) {

    var count = 0;

    count += cellBomb(row - 1, col);
    count += cellBomb(row + 1, col);
    count += cellBomb(row, col + 1);
    count += cellBomb(row, col - 1);
    count += cellBomb(row + 1, col + 1);
    count += cellBomb(row + 1, col - 1);
    count += cellBomb(row - 1, col + 1);
    count += cellBomb(row - 1, col - 1);

    return count;
}

function cellRow(cell) {
    return parseInt(cell.id.substring(5, 6)) - 1;
}

function cellCol(cell) {
    return parseInt(cell.id.substring(7, 8)) - 1;
}

function cellId(row, col) {
    return "#cell-" + row.toString() + "x" + col.toString();
}

function cellBomb(row, col) {
    if (document.grid[row] != undefined) {
        if (document.grid[row][col] != undefined) {
            if (document.grid[row][col] == "bomb") {
                return 1;
            }
        }
    }
    return 0;
}