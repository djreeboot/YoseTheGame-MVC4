$(document).ready(function () {

    $("#go").click(function () {

        $("#result").empty();
        $("#results").empty();

        var values = $("#number").val().split(",");
        var multipleValues = (values.length > 1);
        var url = "/primeFactors?";

        for (var i = 0; i < values.length; i++) {
            if (i != values.length - 1) {
                url += "number=" + values[i].trim() + "&";
            }
            else {
                url += "number=" + values[i].trim();
            }
        }

        $.getJSON(url, function (data) {

            if (multipleValues) {
                displayMultipleResults(data, "#results");
            }
            else {
                displaySingleResult(data, "#result");
                var url = "/primeFactors/setlast?value=" + $("#result").text();
                $.ajax({
                    url: url
                });
            }

        });


    });
});

function displaySingleResult(data, target) {

    if (data.error != undefined) {

        if (data.error == "not a number") {
            $(target).text(data.number + " is " + data.error);
        }
        else {
            $(target).text(data.error);
        }
    }
    else {
        var result = data.number + " = " + data.decomposition.join(" x ");
        $(target).text(result);
    }
}

function displayMultipleResults(data, target) {

    for (var i = 0; i < data.length; i++) {
        var html = $("<li></li>").attr("id", "result_" + i);
        html.appendTo(target);
        displaySingleResult(data[i], "#result_" + i);
    }
}