function loadQuotes() {
    var text1 = "I was just a goofy little funny kid, who was always getting sent to the principal. It wasn't serious because I was smart. I wasn't like a true troublemaker, just rambunctious - like, talkative and trying to be funny. That was me in middle-school.";
    var text2 = "A wise man has to always listen to the peers he surrounds around himself. That's why you surround yourself with other smart people. Captain Kirk keep Mr. Spock right beside him.";
    var text3 = "It was a very cool thing to be a smart girl, as opposed to some other, different kind. And I think that made a great deal of difference to me growing up and in my life afterward.";
    var text4 = "Smart financial planning - such as budgeting, saving for emergencies, and preparing for retirement - can help households enjoy better lives while weathering financial shocks. Financial education can play a key role in getting to these outcomes.";
    var text5 = "I like smart jokes, I like dumb jokes, and I like dumb jokes done smartly.";

    document.getElementById("pp1").innerHTML = text1;
    document.getElementById("pp2").innerHTML = text2;
    document.getElementById("pp3").innerHTML = text3;
    document.getElementById("pp4").innerHTML = text4;
    document.getElementById("pp5").innerHTML = text5;
    document.getElementById("btn1").innerHTML = "Loaded 5 more quotes...";
}

function changeColor() {
    document.getElementById("hh1").style.color = "red";
    document.getElementById("hh2").style.color = "green";
    document.getElementById("hh3").style.color = "blue";
    document.getElementById("hh4").style.color = "yellow";
    document.getElementById("hh5").style.color = "pink";
}