var myArrayThree = [1, 2, 2, 4, 5, 7, 7, 8, 8, 8];

var oneExcThree = document.getElementById("oneExcThree");
var twoExcThree = document.getElementById("twoExcThree");
var threeExcThree = document.getElementById("threeExcThree");
var fourExcThree = document.getElementById("fourExcThree");
var fiveExcThree = document.getElementById("fiveExcThree");
var sixExcThree = document.getElementById("sixExcThree");
var sevenExcThree = document.getElementById("sevenExcThree");
var eigthExcThree = document.getElementById("eigthExcThree");
var nineExcThree = document.getElementById("nineExcThree");
var tenExcThree = document.getElementById("tenExcThree");
var longest = document.getElementById("Longest");
var number = document.getElementById("Number");
var maxTen = document.getElementById("maxTen");

var arrAtributesThree = [
  oneExcThree,
  twoExcThree,
  threeExcThree,
  fourExcThree,
  fiveExcThree,
  sixExcThree,
  sevenExcThree,
  eigthExcThree,
  nineExcThree,
  tenExcThree,
];

oneExcThree.setAttribute("value", myArrayThree[0]);
twoExcThree.setAttribute("value", myArrayThree[1]);
threeExcThree.setAttribute("value", myArrayThree[2]);
fourExcThree.setAttribute("value", myArrayThree[3]);
fiveExcThree.setAttribute("value", myArrayThree[4]);
sixExcThree.setAttribute("value", myArrayThree[5]);
sevenExcThree.setAttribute("value", myArrayThree[6]);
eigthExcThree.setAttribute("value", myArrayThree[7]);
nineExcThree.setAttribute("value", myArrayThree[8]);
tenExcThree.setAttribute("value", myArrayThree[9]);

function validateLonger() {
  maxTen.style.display = "none";
  var newMyArray = validateMaxTen(arrAtributesThree);
  repeatNumber(newMyArray);
}

function repeatNumber(arrNumber) {
  var cont = 0;
  var longestRepeat = 0;
  var numberRepeat = 0;

  for (let index = 1; index < arrNumber.length; index++) {
    arrNumber.forEach((num) => {
      let num1 = num;
      let num2 = arrNumber[index];
      if (num1 === num2) {
        cont++;
      }
      if (cont > longestRepeat) {
        longestRepeat = cont;
        numberRepeat = num1;
      }
    });
    cont = 0;
  }
  longest.innerText = longestRepeat;
  number.innerText = numberRepeat;
}

function validateMaxTen(numbers) {
  var myArrayHistogram = numbers.map((num) => {
    if (Number(num.value) > 10) {
      maxTen.style.display = "block";
      num.value = 0;
    }
    return num.value;
  });
  return myArrayHistogram;
}

validateLonger();

oneExcThree.addEventListener("change", validateLonger);
twoExcThree.addEventListener("change", validateLonger);
threeExcThree.addEventListener("change", validateLonger);
fourExcThree.addEventListener("change", validateLonger);
fiveExcThree.addEventListener("change", validateLonger);
sixExcThree.addEventListener("change", validateLonger);
sevenExcThree.addEventListener("change", validateLonger);
eigthExcThree.addEventListener("change", validateLonger);
nineExcThree.addEventListener("change", validateLonger);
tenExcThree.addEventListener("change", validateLonger);
