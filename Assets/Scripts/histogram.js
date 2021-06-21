var myArrayTwo = [1, 2, 1, 3, 3, 1, 2, 1, 5, 1];

var oneExcTwo = document.getElementById("oneExcTwo");
var twoExcTwo = document.getElementById("twoExcTwo");
var threeExcTwo = document.getElementById("threeExcTwo");
var fourExcTwo = document.getElementById("fourExcTwo");
var fiveExcTwo = document.getElementById("fiveExcTwo");
var sixExcTwo = document.getElementById("sixExcTwo");
var sevenExcTwo = document.getElementById("sevenExcTwo");
var eigthExcTwo = document.getElementById("eigthExcTwo");
var nineExcTwo = document.getElementById("nineExcTwo");
var tenExcTwo = document.getElementById("tenExcTwo");
var result = document.getElementById("result");
var arrayChanges = document.getElementById("arrayChanges");
var maxFive = document.getElementById("maxFive");

var histOne = document.getElementById("histOne");
var histTwo = document.getElementById("histTwo");
var histThree = document.getElementById("histThree");
var histFour = document.getElementById("histFour");
var histFive = document.getElementById("histFive");

var arrAtributesTwo = [
  oneExcTwo,
  twoExcTwo,
  threeExcTwo,
  fourExcTwo,
  fiveExcTwo,
  sixExcTwo,
  sevenExcTwo,
  eigthExcTwo,
  nineExcTwo,
  tenExcTwo,
];

oneExcTwo.setAttribute("value", myArrayTwo[0]);
twoExcTwo.setAttribute("value", myArrayTwo[1]);
threeExcTwo.setAttribute("value", myArrayTwo[2]);
fourExcTwo.setAttribute("value", myArrayTwo[3]);
fiveExcTwo.setAttribute("value", myArrayTwo[4]);
sixExcTwo.setAttribute("value", myArrayTwo[5]);
sevenExcTwo.setAttribute("value", myArrayTwo[6]);
eigthExcTwo.setAttribute("value", myArrayTwo[7]);
nineExcTwo.setAttribute("value", myArrayTwo[8]);
tenExcTwo.setAttribute("value", myArrayTwo[9]);

function histogram() {
  maxFive.style.display = "none";
  resetHtml();
  validateMaxFive(arrAtributesTwo);
  validateNumbers(arrAtributesTwo);
}

function validateNumbers(numbers) {
  numbers.forEach((num) => {
    console.log(num);
    if (Number(num.value) === 1) {
      histOne.innerText += "*";
    }
    if (Number(num.value) === 2) {
      histTwo.innerText += "*";
    }
    if (Number(num.value) === 3) {
      histThree.innerText += "*";
    }
    if (Number(num.value) === 4) {
      histFour.innerText += "*";
    }
    if (Number(num.value) === 5) {
      histFive.innerText += "*";
    }
  });
}

function validateMaxFive(numbers) {
  var myArrayHistogram = numbers.map((num) => {
    if (Number(num.value) > 5) {
      console.log("active2");
      console.log(num);
      maxFive.style.display = "block";
      num.value = 0;
    }
    return num.value;
  });
  return myArrayHistogram;
}

function resetHtml() {
  histOne.innerText = "";
  histTwo.innerText = "";
  histThree.innerText = "";
  histFour.innerText = "";
  histFive.innerText = "";
}

histogram();

oneExcTwo.addEventListener("change", histogram);
twoExcTwo.addEventListener("change", histogram);
threeExcTwo.addEventListener("change", histogram);
fourExcTwo.addEventListener("change", histogram);
fiveExcTwo.addEventListener("change", histogram);
sixExcTwo.addEventListener("change", histogram);
sevenExcTwo.addEventListener("change", histogram);
eigthExcTwo.addEventListener("change", histogram);
nineExcTwo.addEventListener("change", histogram);
tenExcTwo.addEventListener("change", histogram);
