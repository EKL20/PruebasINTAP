var myArrayOne = [13, 2, 3, 35, 1];

var one = document.getElementById("oneExcOne");
var two = document.getElementById("twoExcOne");
var three = document.getElementById("threeExcOne");
var four = document.getElementById("fourExcOne");
var five = document.getElementById("fiveExcOne");
var result = document.getElementById("result");
var maxHundred = document.getElementById("maxHundred");

one.setAttribute("value", myArrayOne[0]);
two.setAttribute("value", myArrayOne[1]);
three.setAttribute("value", myArrayOne[2]);
four.setAttribute("value", myArrayOne[3]);
five.setAttribute("value", myArrayOne[4]);

function biggerNumber() {
  maxHundred.style.display = "none";
  var newMyArray = validateMaxHundred(newMyArray);
  var numberMax = Math.max(...newMyArray);
  return result.setAttribute("value", numberMax);
}

function validateMaxHundred(array = [one, two, three, four, five]) {
  var myArrayValidation = array.map((num) => {
    if (Number(num.value) > 100) {
      maxHundred.style.display = "block";
      num.value = 0;
    }
    return num.value;
  });
  return myArrayValidation;
}

biggerNumber();

one.addEventListener("change", biggerNumber, false);
two.addEventListener("change", biggerNumber, false);
three.addEventListener("change", biggerNumber, false);
four.addEventListener("change", biggerNumber, false);
five.addEventListener("change", biggerNumber, false);
