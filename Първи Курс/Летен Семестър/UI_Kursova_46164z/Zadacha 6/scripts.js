function moveItems() {
    var node = document.getElementById("myList2").lastChild;
    var list = document.getElementById("myList1");
    list.insertBefore(node, list.childNodes[0]);
}

function loadLorem() {
    var text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam," +
        "eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem quia voluptas" +
        "sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.Neque porro quisquam est," +
        "qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore" +
        "magnam aliquam quaerat voluptatem.Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid" +
        "ex ea commodi consequatur?...";
    var content = document.getElementById("lorem").childNodes;
    content[3].innerHTML = text;
    content[3].style.backgroundColor = "yellow";
    document.getElementById("lorem").removeChild(content[7]);
}

function loadCredits() {
    // Show the credits
    var content = document.createElement("p");
    content.innerHTML = "Created by Valeri Lyubenov UniBIT 46164z &copy; 2019";
    document.getElementById("footer").appendChild(content);

    // Remove the button
    document.getElementById("foot").style.display = 'none';
}

var checkflag = "false";
function check(field) {
    if (checkflag == "false") {
        for (i = 0; i < field.length; i++) {
            field[i].checked = true;
        }
        checkflag = "true";
        return "Uncheck All";
    }
    else {
        for (i = 0; i < field.length; i++) {
            field[i].checked = false;
        }
        checkflag = "false";
        return "Check All";
    }
}